Imports System
Imports System.IO
Imports System.Collections
Imports System.Media
Imports Veloengine
Imports AxShockwaveFlashObjects

Public Class Form1
    Dim GameInfo As String = System.Windows.Forms.Application.StartupPath() + "/config/GameInfo.LCK"
    Dim veloengineDIR As String = System.Windows.Forms.Application.StartupPath() + "/veloeng/"
    Dim receivedtext As String = Command()

    Function CompileScene()
        Dim FormCarga As New Veloengine.Editor
        FormCarga.Show()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.ReadLines(GameInfo)(24) = "" Then
                AxShockwaveFlash1.Movie = (veloengineDIR & receivedtext)
            Else
                AxShockwaveFlash1.Movie = (veloengineDIR & File.ReadLines(GameInfo)(24))
            End If

            '        If receivedtext = "-compile" Then

            'End If

            If receivedtext = "-SAXGUYSECRET" Then

                Dim SAX1 As String = Application.StartupPath() + "/veloeng/AudioTemplates/SAXGUYSECRET.GH3"
                Dim SAX2 As String = Application.StartupPath() + "/veloeng/AudioTemplates/SAXGUYSECRET.GH3_SFX"
                Musica_API.SndPlaySoundA_wrapper(SAX1, True, True)
            End If


            Dim Loader As New Veloengine.Editor
            Loader.Show()

            Me.Hide()
            Me.WindowState = FormWindowState.Normal
            Me.Width = File.ReadLines(GameInfo)(7)
            Me.Height = File.ReadLines(GameInfo)(11)

        Catch ex As Exception
            Throw New Exception("Se ha producido un error al detectar los parametros o el archivo LaunchMode.HLD no existe", ex)
        MsgBox(ex.Message)
        End Try
        ToolStripStatusLabel1.Text = "Ready"

        Me.Show()
        Timer1.Start()
        CompileScene()
    End Sub

    Private Sub BuildToolsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FileReader.Show()
    End Sub

    Private Sub CompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileToolStripMenuItem.Click
        'CompileAudio()
        CompileScene()
    End Sub

    Private Sub TextureEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Process.Start(My.Application.Info.DirectoryPath + "/TextureEditor/paint.exe", "veloengine")

    End Sub

    Private Sub TESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TESTToolStripMenuItem.Click
        NewProject.Show()
    End Sub
End Class
