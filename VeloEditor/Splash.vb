Imports System.Web.Script.Serialization
Imports System.IO
Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim playerA As String = 0
        'Dim ser As JavaScriptSerializer = New JavaScriptSerializer
        'Dim jsonstring As String = File.ReadAllText("game.json")
        'playerA = ser.Deserialize(Of String)(jsonstring)
        'MsgBox(playerA)


        'aun no funciona del todo
        '  Dim Audiores As String = System.Windows.Forms.Application.StartupPath() + "\veloeng\General.ief"
        '  If System.IO.File.Exists(Audiores) Then
        '  Using IEFContainer As New PackageStream(Audiores)
        '  Dim PCM_OLD As HostedStream = IEFContainer.GetContainedFileStream("Volatile Reaction.wav")
        '        Dim Player As New SoundPlayer(PCM_OLD)
        'My.Computer.Audio.Play("\veloeng\General.ief")
        'Musica_API.SndPlaySoundA_wrapper(Player, True, True)
        'Player.PlaySync()
        '       End Using
        '      Else
        '     MessageBox.Show("Error al iniciar AudioRes.ief", ".ief", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End
        '   End If
    End Sub
End Class