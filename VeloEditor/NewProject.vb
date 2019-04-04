Imports System.IO
Public Class NewProject
    Private Sub NewProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each ARCHIVOA In My.Computer.FileSystem.GetFiles(TextBox1.Text, FileIO.SearchOption.SearchAllSubDirectories)
            Dim NOMBRE As String = ARCHIVOA.Remove(0, TextBox1.TextLength + 1)
            Dim ARCHIVOB As String = TextBox2.Text & "\" & NOMBRE

            If My.Computer.FileSystem.FileExists(ARCHIVOB) Then
                If My.Computer.FileSystem.GetFileInfo(ARCHIVOA).LastWriteTime > My.Computer.FileSystem.GetFileInfo(ARCHIVOB).LastWriteTime Then
                    My.Computer.FileSystem.CopyFile(ARCHIVOA, ARCHIVOB, True)
                End If
            Else
                My.Computer.FileSystem.CopyFile(ARCHIVOA, ARCHIVOB)
            End If
        Next
        MsgBox("DONE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Inserta un nombre de projecto para continuar")
        Else


            Dim title As String
            Dim msg As String
            Dim style As MsgBoxStyle
            Dim response As MsgBoxResult
            Dim inport As New OpenFileDialog
            Dim export As New SaveFileDialog

            msg = "¿Desea crear el proyecto?"
            style = MsgBoxStyle.DefaultButton2 Or
        MsgBoxStyle.Information Or MsgBoxStyle.YesNo
            title = "Veloengine 3.1"
            response = MsgBox(msg, style, title)
            If response = MsgBoxResult.Yes Then
                With export
                    .AddExtension = True
                    .CheckFileExists = False
                    .CheckPathExists = True
                    .DefaultExt = "HldProj"
                    .DereferenceLinks = True
                    .RestoreDirectory = True
                    .Title = "Crear Juego desde Base"
                    .SupportMultiDottedExtensions = True
                    .ShowHelp = False
                    .Filter = "Ficheros de Veloengine (*.HldProj)|*.HldProj"
                    .FilterIndex = 1
                End With
                If export.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub


                MsgBox(export.FileName)
                Dim folderpath As String = export.FileName
                folderpath = export.FileName
                If Directory.Exists(folderpath) Then
                    MessageBox.Show("Directorio existente")
                Else
                    Directory.CreateDirectory(folderpath)
                    'File.Create(folderpath & TextBox1.Text)
                End If
                RichTextBox1.SaveFile(export.FileName & "/VeloengineBase.veloscript")

                RichTextBox1.Text = ("<VeloengineProj>
<GameDir>" &
TextBox1.Text &
"</GameDir>
</VeloengineProj>")
                RichTextBox1.SaveFile(export.FileName & "/ProjectData.vsk")


                RichTextBox1.Text = ("<VeloengineProj>
<Scripts>" &
TextBox1.Text &
"</Scripts>
</VeloengineProj>")
                RichTextBox1.SaveFile(export.FileName & "/Scripts.HLD")


                RichTextBox1.Text = ("<VeloengineProj>
<Scripts>" &
TextBox1.Text &
"</Scripts>
</VeloengineProj>")

                MsgBox("Modulo base Creado", MsgBoxStyle.Information)
                If response = MsgBoxResult.No Then Close()
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub
End Class