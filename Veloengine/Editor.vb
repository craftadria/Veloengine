Imports System.Windows.Forms
Imports System.IO
Imports System
Imports System.Collections
Imports System.Media
Imports Veloengine.PackageLoader

Public Class Editor

    Private m_ChildFormNumber As Integer
    Dim OSArch As String = 0
    Dim Engine_EditorMode As Boolean = True
    Dim veloengineDIR As String = System.Windows.Forms.Application.StartupPath() + "/veloeng/"
    Dim ProgramArchitecture As String = 0
    Dim AppLaunch As String = System.Windows.Forms.Application.StartupPath() + "/config/LaunchMode.HLD"
    Dim GameGraphics As String = System.Windows.Forms.Application.StartupPath() + "/config/GameGraphics.HLD"

    Function CheckArchitecture()

        If Environment.Is64BitOperatingSystem Then
            OSArch = "x64"
        Else
            OSArch = "x86"
        End If
    End Function

    Function UseHLDDefault()
        If System.IO.File.Exists(AppLaunch) Then
            AxShockwaveFlash1.Movie = (veloengineDIR & File.ReadLines(AppLaunch)(0))
        Else
            MsgBox("Setup file 'LaunchMode.HLD' doesn't exist in subdirectory '..\veloeng'. Check your -game parameter or vconfig setting")
            'ejecutar un end
            MsgBox("Error En el parseado se debe cerrar")
        End If
    End Function


    Private Function AudioCatalog()

        Dim AudioRes As String = System.Windows.Forms.Application.StartupPath() + "\Veloeng\General.ief"
        If System.IO.File.Exists(AudioRes) Then
            Using IEFContainer As New PackageStream(AudioRes)

                Dim Music0 As HostedStream = IEFContainer.GetContainedFileStream("Music0.wav")
                Dim Music1 As HostedStream = IEFContainer.GetContainedFileStream("Music1.wav")
                Dim Music3 As HostedStream = IEFContainer.GetContainedFileStream("Music3.wav")
                Dim Music4 As HostedStream = IEFContainer.GetContainedFileStream("Music4.wav")
                Dim Music5 As HostedStream = IEFContainer.GetContainedFileStream("Music5.wav")
                Dim Music6 As HostedStream = IEFContainer.GetContainedFileStream("Music6.wav")
                Dim Player As New SoundPlayer(Music0)
                ' Player.PlayLooping()
            End Using
        Else
            MessageBox.Show("Error al iniciar AudioRes.ief", ".ief", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ejecutar un END
            MsgBox("Error En el parseado se debe cerrar")
        End If
    End Function

    Function NewMDIForm1()
        Dim ChildForm As New Veloengine.Form1
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber
        ChildForm.Show()
    End Function

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewMDIForm1()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        NewMDIForm1()
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = "Loading Veloengine"
        'AudioCatalog()
        CheckArchitecture()

        If Engine_EditorMode = True Then

        Else

        End If

        ToolStripLabel1.Text = "Ready"
        Timer1.Start()
    End Sub

    Private Sub TextureEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextureEditorToolStripMenuItem.Click
        Dim ChildForm As New Paint.MainForm
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber
        ChildForm.Show()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ChildForm As New Veloengine.DirectoryViewer
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "DirectoryViewer " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        Dim ChildForm As New Veloengine.Form1
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Text = ("Veloengine " & My.Application.Info.AssemblyName & " (" & OSArch & ") " & File.ReadLines(AppLaunch)(0) & " " & Me.Width & "*" & Me.Height & " - PC <DirectXVersion>")
        'Me.Text = ("Veloengine " & My.Application.Info.AssemblyName & " (" & OSArch & ") " & "Veloengine " & Me.Width & "*" & Me.Height & " - PC <DirectXVersion>")

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
        WebBrowser1.Navigate("https://incompetech.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Base3DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Base3DToolStripMenuItem.Click

    End Sub

    Private Sub RPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RPGToolStripMenuItem.Click

    End Sub

    Private Sub DPlataformasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DPlataformasToolStripMenuItem.Click

    End Sub

    Private Sub TESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TESTToolStripMenuItem.Click

    End Sub

    Private Sub OpenGameProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGameProjectToolStripMenuItem.Click

    End Sub

    Private Sub AssetBuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssetBuilderToolStripMenuItem.Click

    End Sub

    Private Sub CreateNewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewGameToolStripMenuItem.Click

    End Sub
End Class