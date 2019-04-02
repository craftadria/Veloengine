﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using CSCore;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.CoreAudioAPI;
using CSCore.Streams;
using CSCore.Codecs;

namespace PitchShifter
{
    public partial class MainForm : Form
    {
        private MMDeviceCollection mInputDevices;
        private MMDeviceCollection mOutputDevices;
        private WasapiCapture mSoundIn;
        private WasapiOut mSoundOut;
        private SampleDSP mDsp;
        private SimpleMixer mMixer;
        private ISampleSource mMp3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Find sound capture devices and fill the cmbInput combo
            MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
            mInputDevices = deviceEnum.EnumAudioEndpoints(DataFlow.Capture, DeviceState.Active);
            MMDevice activeDevice = deviceEnum.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);
            foreach (MMDevice device in mInputDevices)
            {
                cmbInput.Items.Add(device.FriendlyName);
                if (device.DeviceID == activeDevice.DeviceID) cmbInput.SelectedIndex = cmbInput.Items.Count - 1;
            }

            //Find sound render devices and fill the cmbOutput combo
            activeDevice = deviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            mOutputDevices = deviceEnum.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active);
            foreach (MMDevice device in mOutputDevices)
            {
                cmbOutput.Items.Add(device.FriendlyName);
                if (device.DeviceID == activeDevice.DeviceID) cmbOutput.SelectedIndex = cmbOutput.Items.Count - 1;
            }

        }

        private bool StartFullDuplex()
        {
            try
            {
                //Init sound capture device with a latency of 5 ms.
                //ATTENTION: WasapiCapture works on Vista and higher Windows versions.
                mSoundIn = new WasapiCapture(false, AudioClientShareMode.Exclusive, 5);
                mSoundIn.Device = mInputDevices[cmbInput.SelectedIndex]; 
                mSoundIn.Initialize();
                mSoundIn.Start();

                var source = new SoundInSource(mSoundIn) { FillWithZeros = true };

                //Init DSP for pitch shifting 
                mDsp = new SampleDSP(source.ToSampleSource().ToMono());
                mDsp.GainDB = trackGain.Value;
                SetPitchShiftValue();

                //Init mixer
                mMixer = new SimpleMixer(1, 44100) //mono, 44,1 KHz
                {
                    FillWithZeros = false,
                    DivideResult = true //This is set to true for avoiding tick sounds because of exceeding -1 and 1
                };
               
                //Add our sound source to the mixer
                mMixer.AddSource(mDsp.ChangeSampleRate(mMixer.WaveFormat.SampleRate));

                //Init sound play device with a latency of 5 ms.
                mSoundOut = new WasapiOut(false, AudioClientShareMode.Exclusive, 5);
                mSoundOut.Device = mOutputDevices[cmbOutput.SelectedIndex];
                mSoundOut.Initialize(mMixer.ToWaveSource(16));
                
                //Start rolling!
                mSoundOut.Play();
                return true;
            }
            catch (Exception ex)
            {
                string msg = "Error in StartFullDuplex: \r\n" + ex.Message;
                MessageBox.Show(msg);
                Debug.WriteLine(msg);
            }
            return false;
        }

        private void StopFullDuplex()
        {
            if (mSoundOut != null) mSoundOut.Dispose();
            if (mSoundIn != null) mSoundIn.Dispose();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            StopFullDuplex();
            if (StartFullDuplex())
            {
                trackGain.Enabled = true;
                trackPitch.Enabled = true;
                chkAddMp3.Enabled = true;
            }
        }

        private void SetPitchShiftValue()
        {
            mDsp.PitchShift = (float)Math.Pow(2.0F, trackPitch.Value / 12.0F);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopFullDuplex();
        }

        private void trackGain_Scroll(object sender, EventArgs e)
        {
            mDsp.GainDB = trackGain.Value;
        }

        private void trackGain_ValueChanged(object sender, EventArgs e)
        {
            mDsp.GainDB = trackGain.Value;
        }

        private void trackPitch_Scroll(object sender, EventArgs e)
        {
            SetPitchShiftValue();
        }

        private void trackPitch_ValueChanged(object sender, EventArgs e)
        {
            SetPitchShiftValue();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            trackGain.Value = 0;            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            trackPitch.Value = 0;
        }

        private void chkAddMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (mMixer != null)
            {
                if (chkAddMp3.Checked)
                {
                    mMp3 = CodecFactory.Instance.GetCodec("test.mp3").ToMono().ToSampleSource();
                    mMixer.AddSource(mMp3.ChangeSampleRate(mMixer.WaveFormat.SampleRate));
                }
                else
                {
                    mMixer.RemoveSource(mMp3);
                }
            } 
        }

    }
}
