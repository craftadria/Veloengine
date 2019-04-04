<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Base3DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DPlataformasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenGameProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetBuilderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1183, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CompileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1183, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewGameToolStripMenuItem, Me.OpenGameProjectToolStripMenuItem, Me.AssetBuilderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CreateNewGameToolStripMenuItem
        '
        Me.CreateNewGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Base3DToolStripMenuItem, Me.RPGToolStripMenuItem, Me.DPlataformasToolStripMenuItem, Me.TESTToolStripMenuItem})
        Me.CreateNewGameToolStripMenuItem.Name = "CreateNewGameToolStripMenuItem"
        Me.CreateNewGameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CreateNewGameToolStripMenuItem.Text = "Create new game"
        '
        'Base3DToolStripMenuItem
        '
        Me.Base3DToolStripMenuItem.Name = "Base3DToolStripMenuItem"
        Me.Base3DToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.Base3DToolStripMenuItem.Text = "Base 3D"
        '
        'RPGToolStripMenuItem
        '
        Me.RPGToolStripMenuItem.Name = "RPGToolStripMenuItem"
        Me.RPGToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RPGToolStripMenuItem.Text = "RPG"
        '
        'DPlataformasToolStripMenuItem
        '
        Me.DPlataformasToolStripMenuItem.Name = "DPlataformasToolStripMenuItem"
        Me.DPlataformasToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DPlataformasToolStripMenuItem.Text = "2D Plataformas"
        '
        'TESTToolStripMenuItem
        '
        Me.TESTToolStripMenuItem.Name = "TESTToolStripMenuItem"
        Me.TESTToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TESTToolStripMenuItem.Text = "TEST"
        '
        'OpenGameProjectToolStripMenuItem
        '
        Me.OpenGameProjectToolStripMenuItem.Name = "OpenGameProjectToolStripMenuItem"
        Me.OpenGameProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OpenGameProjectToolStripMenuItem.Text = "Open Game project"
        '
        'AssetBuilderToolStripMenuItem
        '
        Me.AssetBuilderToolStripMenuItem.Name = "AssetBuilderToolStripMenuItem"
        Me.AssetBuilderToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AssetBuilderToolStripMenuItem.Text = "Asset Builder"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Image = CType(resources.GetObject("CompileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(197, 144)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(192, 192)
        Me.AxShockwaveFlash1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 536)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents CreateNewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenGameProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetBuilderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Base3DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RPGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DPlataformasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
