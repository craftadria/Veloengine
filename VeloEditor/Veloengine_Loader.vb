Module Veloengine_Loader
    Sub Main()
        Dim CMDCommand As String = Command()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(True)
        Dim Loader As New Veloengine.Editor
        Loader.Show()
    End Sub

    Public Class GlobalVariables
        Public Shared receivedtext As String = Command()
    End Class
End Module
'Public receivedtext As String = Command()