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
        Me.menu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_abrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.btn_gcomo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_compilar = New System.Windows.Forms.ToolStripButton()
        Me.btn_ejecutar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cerrar_ej = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menu_estado = New System.Windows.Forms.ToolStrip()
        Me.lbl_tipo = New System.Windows.Forms.ToolStripLabel()
        Me.codificacion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ubicación = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbl_pos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbl_num = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarCtrlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodoCtrlAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumeroDeLineaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepurarF10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompilarF9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.EjecutarF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetenerEjecucionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustarColorDeFunteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDeFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDePaginaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComentariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SoporteTecnicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgfuente = New System.Windows.Forms.FontDialog()
        Me.dlgcolor = New System.Windows.Forms.ColorDialog()
        Me.dlggrabar = New System.Windows.Forms.SaveFileDialog()
        Me.dlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CerrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasMenosLaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompilarToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.CompilarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_visor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cerr_vis = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtTexto = New ICSharpCode.TextEditor.TextEditorControl()
        Me.BuildMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        Me.menu_estado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.btn_abrir, Me.ToolStripSeparator11, Me.btn_guardar, Me.btn_gcomo, Me.ToolStripSeparator12, Me.btn_compilar, Me.btn_ejecutar, Me.btn_cerrar_ej})
        Me.menu.Location = New System.Drawing.Point(0, 24)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(24, 331)
        Me.menu.TabIndex = 14
        Me.menu.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Veloengine.My.Resources.Resources.Paint
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'btn_abrir
        '
        Me.btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_abrir.Image = Global.Veloengine.My.Resources.Resources.Folder
        Me.btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_abrir.Name = "btn_abrir"
        Me.btn_abrir.Size = New System.Drawing.Size(21, 20)
        Me.btn_abrir.Text = "Abrir"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(21, 6)
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Image = Global.Veloengine.My.Resources.Resources.media_floppy
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(21, 20)
        Me.btn_guardar.Text = "Guardar"
        '
        'btn_gcomo
        '
        Me.btn_gcomo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gcomo.Image = Global.Veloengine.My.Resources.Resources.document_save_as
        Me.btn_gcomo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gcomo.Name = "btn_gcomo"
        Me.btn_gcomo.Size = New System.Drawing.Size(21, 20)
        Me.btn_gcomo.Text = "Guardar como"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(21, 6)
        '
        'btn_compilar
        '
        Me.btn_compilar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_compilar.Image = Global.Veloengine.My.Resources.Resources.audacious
        Me.btn_compilar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_compilar.Name = "btn_compilar"
        Me.btn_compilar.Size = New System.Drawing.Size(21, 20)
        Me.btn_compilar.Text = "Compilar"
        '
        'btn_ejecutar
        '
        Me.btn_ejecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ejecutar.Enabled = False
        Me.btn_ejecutar.Image = Global.Veloengine.My.Resources.Resources.Media_file
        Me.btn_ejecutar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ejecutar.Name = "btn_ejecutar"
        Me.btn_ejecutar.Size = New System.Drawing.Size(21, 20)
        Me.btn_ejecutar.Text = "Ejecutar"
        '
        'btn_cerrar_ej
        '
        Me.btn_cerrar_ej.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cerrar_ej.Image = Global.Veloengine.My.Resources.Resources.Xion
        Me.btn_cerrar_ej.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cerrar_ej.Name = "btn_cerrar_ej"
        Me.btn_cerrar_ej.Size = New System.Drawing.Size(21, 20)
        Me.btn_cerrar_ej.Text = "Cerrar"
        '
        'Timer1
        '
        '
        'menu_estado
        '
        Me.menu_estado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.menu_estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_tipo, Me.codificacion, Me.ToolStripSeparator7, Me.ubicación, Me.ToolStripSeparator8, Me.lbl_pos, Me.ToolStripSeparator9, Me.lbl_num})
        Me.menu_estado.Location = New System.Drawing.Point(0, 416)
        Me.menu_estado.Name = "menu_estado"
        Me.menu_estado.Size = New System.Drawing.Size(765, 25)
        Me.menu_estado.TabIndex = 17
        Me.menu_estado.Text = "ToolStrip1"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(68, 22)
        Me.lbl_tipo.Text = "Texto plano"
        '
        'codificacion
        '
        Me.codificacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.codificacion.Name = "codificacion"
        Me.codificacion.Size = New System.Drawing.Size(33, 22)
        Me.codificacion.Text = "ANSI"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ubicación
        '
        Me.ubicación.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ubicación.Name = "ubicación"
        Me.ubicación.Size = New System.Drawing.Size(13, 22)
        Me.ubicación.Text = "  "
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'lbl_pos
        '
        Me.lbl_pos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_pos.Name = "lbl_pos"
        Me.lbl_pos.Size = New System.Drawing.Size(60, 22)
        Me.lbl_pos.Text = "lin:      col:"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'lbl_num
        '
        Me.lbl_num.Name = "lbl_num"
        Me.lbl_num.Size = New System.Drawing.Size(0, 22)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.FormatoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ToolStripSeparator1, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripSeparator2, Me.RecientesToolStripMenuItem, Me.SalirToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo         "
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir        "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(233, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar     "
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Image = CType(resources.GetObject("GuardarComoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como                            "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(233, 6)
        '
        'RecientesToolStripMenuItem
        '
        Me.RecientesToolStripMenuItem.Name = "RecientesToolStripMenuItem"
        Me.RecientesToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RecientesToolStripMenuItem.Text = "Recientes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SalirToolStripMenuItem.Text = "Imprimir"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesacerToolStripMenuItem, Me.ToolStripComboBox1, Me.ToolStripSeparator3, Me.CortarCtrlXToolStripMenuItem, Me.CopiarCtrlCToolStripMenuItem, Me.PegarCtrlVToolStripMenuItem, Me.ToolStripSeparator4, Me.SeleccionarTodoCtrlAToolStripMenuItem, Me.ToolStripSeparator5, Me.BuscarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'DesacerToolStripMenuItem
        '
        Me.DesacerToolStripMenuItem.Image = CType(resources.GetObject("DesacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DesacerToolStripMenuItem.Name = "DesacerToolStripMenuItem"
        Me.DesacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DesacerToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DesacerToolStripMenuItem.Text = "Deshacer       "
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Image = CType(resources.GetObject("ToolStripComboBox1.Image"), System.Drawing.Image)
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(217, 22)
        Me.ToolStripComboBox1.Text = "Rehacer      "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(214, 6)
        '
        'CortarCtrlXToolStripMenuItem
        '
        Me.CortarCtrlXToolStripMenuItem.Image = CType(resources.GetObject("CortarCtrlXToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarCtrlXToolStripMenuItem.Name = "CortarCtrlXToolStripMenuItem"
        Me.CortarCtrlXToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarCtrlXToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CortarCtrlXToolStripMenuItem.Text = "Cortar     "
        '
        'CopiarCtrlCToolStripMenuItem
        '
        Me.CopiarCtrlCToolStripMenuItem.Image = CType(resources.GetObject("CopiarCtrlCToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarCtrlCToolStripMenuItem.Name = "CopiarCtrlCToolStripMenuItem"
        Me.CopiarCtrlCToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarCtrlCToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CopiarCtrlCToolStripMenuItem.Text = "Copiar      "
        '
        'PegarCtrlVToolStripMenuItem
        '
        Me.PegarCtrlVToolStripMenuItem.Image = CType(resources.GetObject("PegarCtrlVToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarCtrlVToolStripMenuItem.Name = "PegarCtrlVToolStripMenuItem"
        Me.PegarCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PegarCtrlVToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PegarCtrlVToolStripMenuItem.Text = "Pegar       "
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(214, 6)
        '
        'SeleccionarTodoCtrlAToolStripMenuItem
        '
        Me.SeleccionarTodoCtrlAToolStripMenuItem.Name = "SeleccionarTodoCtrlAToolStripMenuItem"
        Me.SeleccionarTodoCtrlAToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SeleccionarTodoCtrlAToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.SeleccionarTodoCtrlAToolStripMenuItem.Text = "Seleccionar todo     "
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(214, 6)
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Image = CType(resources.GetObject("BuscarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar "
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumeroDeLineaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'NumeroDeLineaToolStripMenuItem
        '
        Me.NumeroDeLineaToolStripMenuItem.Checked = True
        Me.NumeroDeLineaToolStripMenuItem.CheckOnClick = True
        Me.NumeroDeLineaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NumeroDeLineaToolStripMenuItem.Name = "NumeroDeLineaToolStripMenuItem"
        Me.NumeroDeLineaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NumeroDeLineaToolStripMenuItem.Text = "Numero de linea"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepurarF10ToolStripMenuItem, Me.CompilarF9ToolStripMenuItem, Me.ToolStripSeparator10, Me.EjecutarF5ToolStripMenuItem, Me.DetenerEjecucionToolStripMenuItem, Me.BuildMeToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'DepurarF10ToolStripMenuItem
        '
        Me.DepurarF10ToolStripMenuItem.Name = "DepurarF10ToolStripMenuItem"
        Me.DepurarF10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.DepurarF10ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DepurarF10ToolStripMenuItem.Text = "Depurar   "
        '
        'CompilarF9ToolStripMenuItem
        '
        Me.CompilarF9ToolStripMenuItem.Name = "CompilarF9ToolStripMenuItem"
        Me.CompilarF9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.CompilarF9ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CompilarF9ToolStripMenuItem.Text = "Compilar  "
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(185, 6)
        '
        'EjecutarF5ToolStripMenuItem
        '
        Me.EjecutarF5ToolStripMenuItem.Enabled = False
        Me.EjecutarF5ToolStripMenuItem.Name = "EjecutarF5ToolStripMenuItem"
        Me.EjecutarF5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.EjecutarF5ToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EjecutarF5ToolStripMenuItem.Text = "Ejecutar    "
        '
        'DetenerEjecucionToolStripMenuItem
        '
        Me.DetenerEjecucionToolStripMenuItem.Enabled = False
        Me.DetenerEjecucionToolStripMenuItem.Name = "DetenerEjecucionToolStripMenuItem"
        Me.DetenerEjecucionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.DetenerEjecucionToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DetenerEjecucionToolStripMenuItem.Text = "Detener ejecucion"
        '
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustarColorDeFunteToolStripMenuItem, Me.FuentesToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.FormatoToolStripMenuItem.Text = "Formato"
        '
        'AjustarColorDeFunteToolStripMenuItem
        '
        Me.AjustarColorDeFunteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorDeFuenteToolStripMenuItem, Me.ColorDePaginaToolStripMenuItem})
        Me.AjustarColorDeFunteToolStripMenuItem.Name = "AjustarColorDeFunteToolStripMenuItem"
        Me.AjustarColorDeFunteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AjustarColorDeFunteToolStripMenuItem.Text = "Ajustar color "
        '
        'ColorDeFuenteToolStripMenuItem
        '
        Me.ColorDeFuenteToolStripMenuItem.Name = "ColorDeFuenteToolStripMenuItem"
        Me.ColorDeFuenteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ColorDeFuenteToolStripMenuItem.Text = "Color de fuente"
        '
        'ColorDePaginaToolStripMenuItem
        '
        Me.ColorDePaginaToolStripMenuItem.Name = "ColorDePaginaToolStripMenuItem"
        Me.ColorDePaginaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ColorDePaginaToolStripMenuItem.Text = "Color de pagina"
        '
        'FuentesToolStripMenuItem
        '
        Me.FuentesToolStripMenuItem.Image = CType(resources.GetObject("FuentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        Me.FuentesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FuentesToolStripMenuItem.Text = "Fuentes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAyudaToolStripMenuItem, Me.ComentariosToolStripMenuItem, Me.ToolStripSeparator6, Me.SoporteTecnicoToolStripMenuItem, Me.AercaDeToolStripMenuItem, Me.DonarToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerAyudaToolStripMenuItem
        '
        Me.VerAyudaToolStripMenuItem.Image = CType(resources.GetObject("VerAyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerAyudaToolStripMenuItem.Name = "VerAyudaToolStripMenuItem"
        Me.VerAyudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.VerAyudaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VerAyudaToolStripMenuItem.Text = "Ver ayuda"
        '
        'ComentariosToolStripMenuItem
        '
        Me.ComentariosToolStripMenuItem.Name = "ComentariosToolStripMenuItem"
        Me.ComentariosToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ComentariosToolStripMenuItem.Text = "Comentarios"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(154, 6)
        '
        'SoporteTecnicoToolStripMenuItem
        '
        Me.SoporteTecnicoToolStripMenuItem.Image = CType(resources.GetObject("SoporteTecnicoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SoporteTecnicoToolStripMenuItem.Name = "SoporteTecnicoToolStripMenuItem"
        Me.SoporteTecnicoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SoporteTecnicoToolStripMenuItem.Text = "Soporte tecnico"
        '
        'AercaDeToolStripMenuItem
        '
        Me.AercaDeToolStripMenuItem.Image = CType(resources.GetObject("AercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AercaDeToolStripMenuItem.Name = "AercaDeToolStripMenuItem"
        Me.AercaDeToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'DonarToolStripMenuItem
        '
        Me.DonarToolStripMenuItem.Name = "DonarToolStripMenuItem"
        Me.DonarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DonarToolStripMenuItem.Text = "Donar"
        '
        'dlgfuente
        '
        Me.dlgfuente.AllowVectorFonts = False
        Me.dlgfuente.AllowVerticalFonts = False
        Me.dlgfuente.FixedPitchOnly = True
        Me.dlgfuente.ShowApply = True
        Me.dlgfuente.ShowColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem1, Me.CerrarTodasMenosLaActualToolStripMenuItem, Me.CompilarToolStripMenuItem, Me.CompilarToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(225, 76)
        '
        'CerrarToolStripMenuItem1
        '
        Me.CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        Me.CerrarToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.CerrarToolStripMenuItem1.Text = "Cerrar"
        '
        'CerrarTodasMenosLaActualToolStripMenuItem
        '
        Me.CerrarTodasMenosLaActualToolStripMenuItem.Name = "CerrarTodasMenosLaActualToolStripMenuItem"
        Me.CerrarTodasMenosLaActualToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CerrarTodasMenosLaActualToolStripMenuItem.Text = "Cerrar todas menos la actual"
        '
        'CompilarToolStripMenuItem
        '
        Me.CompilarToolStripMenuItem.Name = "CompilarToolStripMenuItem"
        Me.CompilarToolStripMenuItem.Size = New System.Drawing.Size(221, 6)
        '
        'CompilarToolStripMenuItem1
        '
        Me.CompilarToolStripMenuItem1.Name = "CompilarToolStripMenuItem1"
        Me.CompilarToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.CompilarToolStripMenuItem1.Text = "Compilar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_visor
        '
        Me.txt_visor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_visor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_visor.Location = New System.Drawing.Point(0, 355)
        Me.txt_visor.Multiline = True
        Me.txt_visor.Name = "txt_visor"
        Me.txt_visor.ReadOnly = True
        Me.txt_visor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_visor.Size = New System.Drawing.Size(765, 61)
        Me.txt_visor.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(669, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 18)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cerr_vis
        '
        Me.btn_cerr_vis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerr_vis.Location = New System.Drawing.Point(720, 395)
        Me.btn_cerr_vis.Name = "btn_cerr_vis"
        Me.btn_cerr_vis.Size = New System.Drawing.Size(20, 18)
        Me.btn_cerr_vis.TabIndex = 21
        Me.btn_cerr_vis.Text = "X"
        Me.btn_cerr_vis.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.menu)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 355)
        Me.Panel1.TabIndex = 23
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(24, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(741, 331)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtTexto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(733, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "nuevo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtTexto
        '
        Me.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTexto.IsReadOnly = False
        Me.txtTexto.Location = New System.Drawing.Point(0, 0)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(733, 305)
        Me.txtTexto.TabIndex = 16
        '
        'BuildMeToolStripMenuItem
        '
        Me.BuildMeToolStripMenuItem.Name = "BuildMeToolStripMenuItem"
        Me.BuildMeToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.BuildMeToolStripMenuItem.Text = "BuildMe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cerr_vis)
        Me.Controls.Add(Me.txt_visor)
        Me.Controls.Add(Me.menu_estado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.menu_estado.ResumeLayout(False)
        Me.menu_estado.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btn_abrir As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents btn_guardar As ToolStripButton
    Friend WithEvents btn_gcomo As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents btn_compilar As ToolStripButton
    Friend WithEvents btn_ejecutar As ToolStripButton
    Friend WithEvents btn_cerrar_ej As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents menu_estado As ToolStrip
    Friend WithEvents lbl_tipo As ToolStripLabel
    Friend WithEvents codificacion As ToolStripLabel
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ubicación As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents lbl_pos As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents lbl_num As ToolStripLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RecientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CortarCtrlXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegarCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionarTodoCtrlAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumeroDeLineaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepurarF10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompilarF9ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents EjecutarF5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetenerEjecucionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustarColorDeFunteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDeFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDePaginaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerAyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComentariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SoporteTecnicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgfuente As FontDialog
    Friend WithEvents dlgcolor As ColorDialog
    Friend WithEvents dlggrabar As SaveFileDialog
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CerrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CerrarTodasMenosLaActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompilarToolStripMenuItem As ToolStripSeparator
    Friend WithEvents CompilarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txt_visor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_cerr_vis As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtTexto As TextEditorControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BuildMeToolStripMenuItem As ToolStripMenuItem
End Class
