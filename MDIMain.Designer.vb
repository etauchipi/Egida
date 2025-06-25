<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TooltStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDiv1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TooltStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDiv2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLbl2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDiv22 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDiv23 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripActualizacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuMain = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepcionStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimeToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistapreviaToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercadeTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInventario = New System.Windows.Forms.TextBox()
        Me.lblLavanderia = New System.Windows.Forms.TextBox()
        Me.lblEntregados = New System.Windows.Forms.TextBox()
        Me.cbColor = New System.Windows.Forms.CheckedListBox()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTalla = New System.Windows.Forms.CheckedListBox()
        Me.TallaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbElementoTipo = New System.Windows.Forms.CheckedListBox()
        Me.ElementoTipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chb_Baja = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_Inventario = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventarioDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Lavanderia = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TallaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMain = New Egida.dsMain()
        Me.dgv_Entregados = New System.Windows.Forms.DataGridView()
        Me.IdentificacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OficioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElementoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TallaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.pbIngreso = New System.Windows.Forms.PictureBox()
        Me.lblIngreso = New System.Windows.Forms.Label()
        Me.tbIngreso = New System.Windows.Forms.TextBox()
        Me.btIngreso = New System.Windows.Forms.Button()
        Me.btLavanderia = New System.Windows.Forms.Button()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btOk = New System.Windows.Forms.Button()
        Me.lblCodigo4 = New System.Windows.Forms.Label()
        Me.tbCodigo4 = New System.Windows.Forms.TextBox()
        Me.lblCodigo3 = New System.Windows.Forms.Label()
        Me.tbCodigo3 = New System.Windows.Forms.TextBox()
        Me.lblCodigo2 = New System.Windows.Forms.Label()
        Me.tbCodigo2 = New System.Windows.Forms.TextBox()
        Me.lblCodigo1 = New System.Windows.Forms.Label()
        Me.tbCodigo1 = New System.Windows.Forms.TextBox()
        Me.pbBata = New System.Windows.Forms.PictureBox()
        Me.lblCaptura = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgv_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Oficio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.pbUsr = New System.Windows.Forms.PictureBox()
        Me.btDevolucion = New System.Windows.Forms.Button()
        Me.btEntrega = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElementoTipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Inventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Lavanderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Entregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntregadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TooltStatusUser, Me.ToolStripDiv1, Me.TooltStatusLabel, Me.ToolStripDiv2, Me.ToolStripStatusLbl2, Me.ToolStripDiv22, Me.ToolStripStatusLabel2, Me.ToolStripDiv23, Me.ToolStripActualizacion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 873)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1545, 22)
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip"
        '
        'TooltStatusUser
        '
        Me.TooltStatusUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TooltStatusUser.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TooltStatusUser.Name = "TooltStatusUser"
        Me.TooltStatusUser.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripDiv1
        '
        Me.ToolStripDiv1.Name = "ToolStripDiv1"
        Me.ToolStripDiv1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripDiv1.Text = "|"
        '
        'TooltStatusLabel
        '
        Me.TooltStatusLabel.Name = "TooltStatusLabel"
        Me.TooltStatusLabel.Size = New System.Drawing.Size(12, 17)
        Me.TooltStatusLabel.Text = "-"
        '
        'ToolStripDiv2
        '
        Me.ToolStripDiv2.Name = "ToolStripDiv2"
        Me.ToolStripDiv2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripDiv2.Text = "|"
        '
        'ToolStripStatusLbl2
        '
        Me.ToolStripStatusLbl2.Name = "ToolStripStatusLbl2"
        Me.ToolStripStatusLbl2.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLbl2.Text = "Estado"
        '
        'ToolStripDiv22
        '
        Me.ToolStripDiv22.Name = "ToolStripDiv22"
        Me.ToolStripDiv22.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripDiv22.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripDiv23
        '
        Me.ToolStripDiv23.Name = "ToolStripDiv23"
        Me.ToolStripDiv23.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripDiv23.Text = "|"
        '
        'ToolStripActualizacion
        '
        Me.ToolStripActualizacion.Name = "ToolStripActualizacion"
        Me.ToolStripActualizacion.Size = New System.Drawing.Size(0, 17)
        '
        'MenuMain
        '
        Me.MenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStrip, Me.HelpMenu})
        Me.MenuMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuMain.Name = "MenuMain"
        Me.MenuMain.Size = New System.Drawing.Size(1545, 24)
        Me.MenuMain.TabIndex = 9
        Me.MenuMain.Text = "MenuStrip"
        '
        'InicioToolStrip
        '
        Me.InicioToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregaStrip, Me.RecepcionStrip, Me.ToolStripSeparator3, Me.ImprimeToolStrip, Me.VistapreviaToolStrip, Me.ToolStripSeparator4, Me.ToolStripSeparator5, Me.SalirToolStripMenuItem})
        Me.InicioToolStrip.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.InicioToolStrip.Name = "InicioToolStrip"
        Me.InicioToolStrip.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStrip.Text = "&Inicio"
        '
        'EntregaStrip
        '
        Me.EntregaStrip.Image = CType(resources.GetObject("EntregaStrip.Image"), System.Drawing.Image)
        Me.EntregaStrip.ImageTransparentColor = System.Drawing.Color.Black
        Me.EntregaStrip.Name = "EntregaStrip"
        Me.EntregaStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.EntregaStrip.Size = New System.Drawing.Size(206, 22)
        Me.EntregaStrip.Text = "&Entrega"
        '
        'RecepcionStrip
        '
        Me.RecepcionStrip.Name = "RecepcionStrip"
        Me.RecepcionStrip.Size = New System.Drawing.Size(206, 22)
        Me.RecepcionStrip.Text = "&Recepción"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(203, 6)
        '
        'ImprimeToolStrip
        '
        Me.ImprimeToolStrip.Image = CType(resources.GetObject("ImprimeToolStrip.Image"), System.Drawing.Image)
        Me.ImprimeToolStrip.ImageTransparentColor = System.Drawing.Color.Black
        Me.ImprimeToolStrip.Name = "ImprimeToolStrip"
        Me.ImprimeToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimeToolStrip.Size = New System.Drawing.Size(206, 22)
        Me.ImprimeToolStrip.Text = "&Imprimir"
        '
        'VistapreviaToolStrip
        '
        Me.VistapreviaToolStrip.Image = CType(resources.GetObject("VistapreviaToolStrip.Image"), System.Drawing.Image)
        Me.VistapreviaToolStrip.ImageTransparentColor = System.Drawing.Color.Black
        Me.VistapreviaToolStrip.Name = "VistapreviaToolStrip"
        Me.VistapreviaToolStrip.Size = New System.Drawing.Size(206, 22)
        Me.VistapreviaToolStrip.Text = "&Vista previa de impresión"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(203, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(203, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.AcercadeTool})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(132, 6)
        '
        'AcercadeTool
        '
        Me.AcercadeTool.Name = "AcercadeTool"
        Me.AcercadeTool.Size = New System.Drawing.Size(135, 22)
        Me.AcercadeTool.Text = "&Acerca de..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblInventario)
        Me.Panel1.Controls.Add(Me.lblLavanderia)
        Me.Panel1.Controls.Add(Me.lblEntregados)
        Me.Panel1.Controls.Add(Me.cbColor)
        Me.Panel1.Controls.Add(Me.cbTalla)
        Me.Panel1.Controls.Add(Me.cbElementoTipo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.chb_Baja)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dgv_Inventario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgv_Lavanderia)
        Me.Panel1.Controls.Add(Me.dgv_Entregados)
        Me.Panel1.Controls.Add(Me.btIngresar)
        Me.Panel1.Controls.Add(Me.pbIngreso)
        Me.Panel1.Controls.Add(Me.lblIngreso)
        Me.Panel1.Controls.Add(Me.tbIngreso)
        Me.Panel1.Controls.Add(Me.btIngreso)
        Me.Panel1.Controls.Add(Me.btLavanderia)
        Me.Panel1.Controls.Add(Me.btSearch)
        Me.Panel1.Controls.Add(Me.btCancelar)
        Me.Panel1.Controls.Add(Me.btOk)
        Me.Panel1.Controls.Add(Me.lblCodigo4)
        Me.Panel1.Controls.Add(Me.tbCodigo4)
        Me.Panel1.Controls.Add(Me.lblCodigo3)
        Me.Panel1.Controls.Add(Me.tbCodigo3)
        Me.Panel1.Controls.Add(Me.lblCodigo2)
        Me.Panel1.Controls.Add(Me.tbCodigo2)
        Me.Panel1.Controls.Add(Me.lblCodigo1)
        Me.Panel1.Controls.Add(Me.tbCodigo1)
        Me.Panel1.Controls.Add(Me.pbBata)
        Me.Panel1.Controls.Add(Me.lblCaptura)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.dgv_Usuarios)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.tbSearch)
        Me.Panel1.Controls.Add(Me.pbUsr)
        Me.Panel1.Controls.Add(Me.btDevolucion)
        Me.Panel1.Controls.Add(Me.btEntrega)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1545, 849)
        Me.Panel1.TabIndex = 11
        '
        'lblInventario
        '
        Me.lblInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventario.Location = New System.Drawing.Point(1382, 10)
        Me.lblInventario.Name = "lblInventario"
        Me.lblInventario.Size = New System.Drawing.Size(100, 26)
        Me.lblInventario.TabIndex = 42
        '
        'lblLavanderia
        '
        Me.lblLavanderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLavanderia.Location = New System.Drawing.Point(1422, 770)
        Me.lblLavanderia.Name = "lblLavanderia"
        Me.lblLavanderia.Size = New System.Drawing.Size(62, 26)
        Me.lblLavanderia.TabIndex = 41
        '
        'lblEntregados
        '
        Me.lblEntregados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregados.Location = New System.Drawing.Point(843, 770)
        Me.lblEntregados.Name = "lblEntregados"
        Me.lblEntregados.Size = New System.Drawing.Size(62, 26)
        Me.lblEntregados.TabIndex = 40
        '
        'cbColor
        '
        Me.cbColor.CheckOnClick = True
        Me.cbColor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ColorBindingSource, "Color", True))
        Me.cbColor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ColorBindingSource, "id", True))
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Location = New System.Drawing.Point(1362, 348)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(120, 139)
        Me.cbColor.TabIndex = 39
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataSource = GetType(Egida.dsMain.ColorDataTable)
        '
        'cbTalla
        '
        Me.cbTalla.CheckOnClick = True
        Me.cbTalla.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.TallaBindingSource, "Talla", True))
        Me.cbTalla.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TallaBindingSource, "id", True))
        Me.cbTalla.FormattingEnabled = True
        Me.cbTalla.Location = New System.Drawing.Point(1227, 348)
        Me.cbTalla.Name = "cbTalla"
        Me.cbTalla.Size = New System.Drawing.Size(120, 139)
        Me.cbTalla.TabIndex = 38
        '
        'TallaBindingSource
        '
        Me.TallaBindingSource.DataSource = GetType(Egida.dsMain.TallaDataTable)
        '
        'cbElementoTipo
        '
        Me.cbElementoTipo.CheckOnClick = True
        Me.cbElementoTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ElementoTipoBindingSource, "id", True))
        Me.cbElementoTipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ElementoTipoBindingSource, "Elemento", True))
        Me.cbElementoTipo.FormattingEnabled = True
        Me.cbElementoTipo.Location = New System.Drawing.Point(1091, 348)
        Me.cbElementoTipo.Name = "cbElementoTipo"
        Me.cbElementoTipo.Size = New System.Drawing.Size(120, 139)
        Me.cbElementoTipo.TabIndex = 37
        '
        'ElementoTipoBindingSource
        '
        Me.ElementoTipoBindingSource.DataSource = GetType(Egida.dsMain.Elemento_TipoDataTable)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Egida.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(879, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 50)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'chb_Baja
        '
        Me.chb_Baja.AutoSize = True
        Me.chb_Baja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_Baja.Location = New System.Drawing.Point(719, 473)
        Me.chb_Baja.Name = "chb_Baja"
        Me.chb_Baja.Size = New System.Drawing.Size(92, 17)
        Me.chb_Baja.TabIndex = 35
        Me.chb_Baja.Text = "Dar de baja"
        Me.chb_Baja.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1189, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Disponible"
        '
        'dgv_Inventario
        '
        Me.dgv_Inventario.AllowUserToAddRows = False
        Me.dgv_Inventario.AllowUserToDeleteRows = False
        Me.dgv_Inventario.AllowUserToResizeRows = False
        Me.dgv_Inventario.AutoGenerateColumns = False
        Me.dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Inventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgv_Inventario.DataSource = Me.InventarioDataTableBindingSource
        Me.dgv_Inventario.Location = New System.Drawing.Point(1169, 39)
        Me.dgv_Inventario.MultiSelect = False
        Me.dgv_Inventario.Name = "dgv_Inventario"
        Me.dgv_Inventario.ReadOnly = True
        Me.dgv_Inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_Inventario.RowHeadersVisible = False
        Me.dgv_Inventario.Size = New System.Drawing.Size(315, 284)
        Me.dgv_Inventario.TabIndex = 33
        Me.dgv_Inventario.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 63
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Elemento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Elemento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 74
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Talla"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Talla"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 53
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 54
        '
        'InventarioDataTableBindingSource
        '
        Me.InventarioDataTableBindingSource.DataSource = GetType(Egida.dsMain.InventarioDataTable)
        Me.InventarioDataTableBindingSource.Sort = "Elemento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(937, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "En lavandería"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Entregados"
        '
        'dgv_Lavanderia
        '
        Me.dgv_Lavanderia.AllowUserToAddRows = False
        Me.dgv_Lavanderia.AllowUserToDeleteRows = False
        Me.dgv_Lavanderia.AllowUserToResizeRows = False
        Me.dgv_Lavanderia.AutoGenerateColumns = False
        Me.dgv_Lavanderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Lavanderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.ElementoDataGridViewTextBoxColumn, Me.TallaDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgv_Lavanderia.DataSource = Me.SuciosBindingSource
        Me.dgv_Lavanderia.Location = New System.Drawing.Point(925, 521)
        Me.dgv_Lavanderia.MultiSelect = False
        Me.dgv_Lavanderia.Name = "dgv_Lavanderia"
        Me.dgv_Lavanderia.ReadOnly = True
        Me.dgv_Lavanderia.RowHeadersVisible = False
        Me.dgv_Lavanderia.Size = New System.Drawing.Size(559, 243)
        Me.dgv_Lavanderia.TabIndex = 30
        Me.dgv_Lavanderia.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ElementoDataGridViewTextBoxColumn
        '
        Me.ElementoDataGridViewTextBoxColumn.DataPropertyName = "Elemento"
        Me.ElementoDataGridViewTextBoxColumn.HeaderText = "Elemento"
        Me.ElementoDataGridViewTextBoxColumn.Name = "ElementoDataGridViewTextBoxColumn"
        Me.ElementoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TallaDataGridViewTextBoxColumn
        '
        Me.TallaDataGridViewTextBoxColumn.DataPropertyName = "Talla"
        Me.TallaDataGridViewTextBoxColumn.HeaderText = "Talla"
        Me.TallaDataGridViewTextBoxColumn.Name = "TallaDataGridViewTextBoxColumn"
        Me.TallaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuciosBindingSource
        '
        Me.SuciosBindingSource.DataMember = "Sucios"
        Me.SuciosBindingSource.DataSource = Me.DsMain
        '
        'DsMain
        '
        Me.DsMain.DataSetName = "dsMain"
        Me.DsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv_Entregados
        '
        Me.dgv_Entregados.AllowUserToAddRows = False
        Me.dgv_Entregados.AllowUserToDeleteRows = False
        Me.dgv_Entregados.AllowUserToResizeRows = False
        Me.dgv_Entregados.AutoGenerateColumns = False
        Me.dgv_Entregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Entregados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificacionDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.OficioDataGridViewTextBoxColumn1, Me.CodigoDataGridViewTextBoxColumn1, Me.ElementoDataGridViewTextBoxColumn1, Me.TallaDataGridViewTextBoxColumn1, Me.ColorDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1})
        Me.dgv_Entregados.DataSource = Me.EntregadosBindingSource
        Me.dgv_Entregados.Location = New System.Drawing.Point(25, 521)
        Me.dgv_Entregados.MultiSelect = False
        Me.dgv_Entregados.Name = "dgv_Entregados"
        Me.dgv_Entregados.ReadOnly = True
        Me.dgv_Entregados.RowHeadersVisible = False
        Me.dgv_Entregados.Size = New System.Drawing.Size(880, 243)
        Me.dgv_Entregados.TabIndex = 29
        Me.dgv_Entregados.Visible = False
        '
        'IdentificacionDataGridViewTextBoxColumn1
        '
        Me.IdentificacionDataGridViewTextBoxColumn1.DataPropertyName = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn1.HeaderText = "Identificacion"
        Me.IdentificacionDataGridViewTextBoxColumn1.Name = "IdentificacionDataGridViewTextBoxColumn1"
        Me.IdentificacionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'OficioDataGridViewTextBoxColumn1
        '
        Me.OficioDataGridViewTextBoxColumn1.DataPropertyName = "Oficio"
        Me.OficioDataGridViewTextBoxColumn1.HeaderText = "Oficio"
        Me.OficioDataGridViewTextBoxColumn1.Name = "OficioDataGridViewTextBoxColumn1"
        Me.OficioDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ElementoDataGridViewTextBoxColumn1
        '
        Me.ElementoDataGridViewTextBoxColumn1.DataPropertyName = "Elemento"
        Me.ElementoDataGridViewTextBoxColumn1.HeaderText = "Elemento"
        Me.ElementoDataGridViewTextBoxColumn1.Name = "ElementoDataGridViewTextBoxColumn1"
        Me.ElementoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TallaDataGridViewTextBoxColumn1
        '
        Me.TallaDataGridViewTextBoxColumn1.DataPropertyName = "Talla"
        Me.TallaDataGridViewTextBoxColumn1.HeaderText = "Talla"
        Me.TallaDataGridViewTextBoxColumn1.Name = "TallaDataGridViewTextBoxColumn1"
        Me.TallaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn1
        '
        Me.ColorDataGridViewTextBoxColumn1.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn1.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn1.Name = "ColorDataGridViewTextBoxColumn1"
        Me.ColorDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EntregadosBindingSource
        '
        Me.EntregadosBindingSource.DataMember = "Entregados"
        Me.EntregadosBindingSource.DataSource = Me.DsMain
        '
        'btIngresar
        '
        Me.btIngresar.BackColor = System.Drawing.Color.PaleGreen
        Me.btIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btIngresar.Image = Global.Egida.My.Resources.Resources.yes
        Me.btIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btIngresar.Location = New System.Drawing.Point(929, 408)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(146, 49)
        Me.btIngresar.TabIndex = 25
        Me.btIngresar.Text = "        Ingresar"
        Me.btIngresar.UseVisualStyleBackColor = False
        '
        'pbIngreso
        '
        Me.pbIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbIngreso.Image = Global.Egida.My.Resources.Resources.ppe_apron_2x
        Me.pbIngreso.Location = New System.Drawing.Point(929, 271)
        Me.pbIngreso.Name = "pbIngreso"
        Me.pbIngreso.Size = New System.Drawing.Size(64, 71)
        Me.pbIngreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIngreso.TabIndex = 24
        Me.pbIngreso.TabStop = False
        '
        'lblIngreso
        '
        Me.lblIngreso.AutoSize = True
        Me.lblIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreso.Location = New System.Drawing.Point(925, 379)
        Me.lblIngreso.Name = "lblIngreso"
        Me.lblIngreso.Size = New System.Drawing.Size(63, 20)
        Me.lblIngreso.TabIndex = 23
        Me.lblIngreso.Text = "Label1"
        '
        'tbIngreso
        '
        Me.tbIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIngreso.Location = New System.Drawing.Point(929, 348)
        Me.tbIngreso.Name = "tbIngreso"
        Me.tbIngreso.Size = New System.Drawing.Size(143, 26)
        Me.tbIngreso.TabIndex = 22
        '
        'btIngreso
        '
        Me.btIngreso.BackColor = System.Drawing.Color.Gold
        Me.btIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIngreso.Location = New System.Drawing.Point(658, 16)
        Me.btIngreso.Name = "btIngreso"
        Me.btIngreso.Size = New System.Drawing.Size(177, 41)
        Me.btIngreso.TabIndex = 21
        Me.btIngreso.Text = "INGRESO"
        Me.btIngreso.UseVisualStyleBackColor = False
        '
        'btLavanderia
        '
        Me.btLavanderia.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btLavanderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLavanderia.Location = New System.Drawing.Point(456, 16)
        Me.btLavanderia.Name = "btLavanderia"
        Me.btLavanderia.Size = New System.Drawing.Size(177, 41)
        Me.btLavanderia.TabIndex = 20
        Me.btLavanderia.Text = "LAVANDERÍA"
        Me.btLavanderia.UseVisualStyleBackColor = False
        '
        'btSearch
        '
        Me.btSearch.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btSearch.Image = Global.Egida.My.Resources.Resources.magnifying_glass
        Me.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSearch.Location = New System.Drawing.Point(496, 90)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(146, 49)
        Me.btSearch.TabIndex = 19
        Me.btSearch.Text = "Buscar"
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.Violet
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btCancelar.Image = Global.Egida.My.Resources.Resources.no
        Me.btCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancelar.Location = New System.Drawing.Point(719, 408)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(146, 49)
        Me.btCancelar.TabIndex = 18
        Me.btCancelar.Text = "        Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btOk
        '
        Me.btOk.BackColor = System.Drawing.Color.PaleGreen
        Me.btOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.btOk.Image = Global.Egida.My.Resources.Resources.yes
        Me.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btOk.Location = New System.Drawing.Point(719, 337)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(146, 49)
        Me.btOk.TabIndex = 17
        Me.btOk.Text = "        Entregar"
        Me.btOk.UseVisualStyleBackColor = False
        '
        'lblCodigo4
        '
        Me.lblCodigo4.AutoSize = True
        Me.lblCodigo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo4.Location = New System.Drawing.Point(271, 456)
        Me.lblCodigo4.Name = "lblCodigo4"
        Me.lblCodigo4.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo4.TabIndex = 16
        Me.lblCodigo4.Text = "Label1"
        '
        'tbCodigo4
        '
        Me.tbCodigo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo4.Location = New System.Drawing.Point(133, 450)
        Me.tbCodigo4.Name = "tbCodigo4"
        Me.tbCodigo4.Size = New System.Drawing.Size(132, 26)
        Me.tbCodigo4.TabIndex = 15
        '
        'lblCodigo3
        '
        Me.lblCodigo3.AutoSize = True
        Me.lblCodigo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo3.Location = New System.Drawing.Point(271, 422)
        Me.lblCodigo3.Name = "lblCodigo3"
        Me.lblCodigo3.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo3.TabIndex = 14
        Me.lblCodigo3.Text = "Label1"
        '
        'tbCodigo3
        '
        Me.tbCodigo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo3.Location = New System.Drawing.Point(133, 416)
        Me.tbCodigo3.Name = "tbCodigo3"
        Me.tbCodigo3.Size = New System.Drawing.Size(132, 26)
        Me.tbCodigo3.TabIndex = 13
        '
        'lblCodigo2
        '
        Me.lblCodigo2.AutoSize = True
        Me.lblCodigo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo2.Location = New System.Drawing.Point(271, 388)
        Me.lblCodigo2.Name = "lblCodigo2"
        Me.lblCodigo2.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo2.TabIndex = 12
        Me.lblCodigo2.Text = "Label1"
        '
        'tbCodigo2
        '
        Me.tbCodigo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo2.Location = New System.Drawing.Point(133, 382)
        Me.tbCodigo2.Name = "tbCodigo2"
        Me.tbCodigo2.Size = New System.Drawing.Size(132, 26)
        Me.tbCodigo2.TabIndex = 11
        '
        'lblCodigo1
        '
        Me.lblCodigo1.AutoSize = True
        Me.lblCodigo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo1.Location = New System.Drawing.Point(271, 354)
        Me.lblCodigo1.Name = "lblCodigo1"
        Me.lblCodigo1.Size = New System.Drawing.Size(63, 20)
        Me.lblCodigo1.TabIndex = 10
        Me.lblCodigo1.Text = "Label1"
        '
        'tbCodigo1
        '
        Me.tbCodigo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo1.Location = New System.Drawing.Point(133, 348)
        Me.tbCodigo1.Name = "tbCodigo1"
        Me.tbCodigo1.Size = New System.Drawing.Size(132, 26)
        Me.tbCodigo1.TabIndex = 9
        '
        'pbBata
        '
        Me.pbBata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbBata.Image = Global.Egida.My.Resources.Resources.ppe_apron_2x
        Me.pbBata.Location = New System.Drawing.Point(56, 312)
        Me.pbBata.Name = "pbBata"
        Me.pbBata.Size = New System.Drawing.Size(64, 71)
        Me.pbBata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBata.TabIndex = 8
        Me.pbBata.TabStop = False
        '
        'lblCaptura
        '
        Me.lblCaptura.AutoSize = True
        Me.lblCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptura.Location = New System.Drawing.Point(136, 311)
        Me.lblCaptura.Name = "lblCaptura"
        Me.lblCaptura.Size = New System.Drawing.Size(20, 20)
        Me.lblCaptura.TabIndex = 7
        Me.lblCaptura.Text = "-:"
        Me.lblCaptura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(927, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 149)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'dgv_Usuarios
        '
        Me.dgv_Usuarios.AllowUserToAddRows = False
        Me.dgv_Usuarios.AllowUserToDeleteRows = False
        Me.dgv_Usuarios.AllowUserToOrderColumns = True
        Me.dgv_Usuarios.AllowUserToResizeRows = False
        Me.dgv_Usuarios.AutoGenerateColumns = False
        Me.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Usuario, Me.Nombre, Me.Oficio, Me.Identificacion, Me.IdDataGridViewTextBoxColumn})
        Me.dgv_Usuarios.DataSource = Me.UsuariosBindingSource
        Me.dgv_Usuarios.Location = New System.Drawing.Point(133, 153)
        Me.dgv_Usuarios.MultiSelect = False
        Me.dgv_Usuarios.Name = "dgv_Usuarios"
        Me.dgv_Usuarios.ReadOnly = True
        Me.dgv_Usuarios.Size = New System.Drawing.Size(588, 137)
        Me.dgv_Usuarios.TabIndex = 5
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 5
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 50
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 66
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 50
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 67
        '
        'Oficio
        '
        Me.Oficio.DataPropertyName = "Oficio"
        Me.Oficio.HeaderText = "Oficio"
        Me.Oficio.Name = "Oficio"
        Me.Oficio.ReadOnly = True
        '
        'Identificacion
        '
        Me.Identificacion.DataPropertyName = "Identificacion"
        Me.Identificacion.HeaderText = "Identificación"
        Me.Identificacion.MinimumWidth = 50
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.ReadOnly = True
        Me.Identificacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DsMain
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(129, 73)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(20, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "-:"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(133, 106)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(357, 26)
        Me.tbSearch.TabIndex = 3
        '
        'pbUsr
        '
        Me.pbUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbUsr.Image = Global.Egida.My.Resources.Resources.person_2x
        Me.pbUsr.Location = New System.Drawing.Point(56, 73)
        Me.pbUsr.Name = "pbUsr"
        Me.pbUsr.Size = New System.Drawing.Size(64, 71)
        Me.pbUsr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsr.TabIndex = 2
        Me.pbUsr.TabStop = False
        '
        'btDevolucion
        '
        Me.btDevolucion.BackColor = System.Drawing.Color.YellowGreen
        Me.btDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDevolucion.Location = New System.Drawing.Point(254, 16)
        Me.btDevolucion.Name = "btDevolucion"
        Me.btDevolucion.Size = New System.Drawing.Size(177, 41)
        Me.btDevolucion.TabIndex = 1
        Me.btDevolucion.Text = "DEVOLUCIÓN"
        Me.btDevolucion.UseVisualStyleBackColor = False
        '
        'btEntrega
        '
        Me.btEntrega.BackColor = System.Drawing.Color.Coral
        Me.btEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEntrega.Location = New System.Drawing.Point(56, 16)
        Me.btEntrega.Name = "btEntrega"
        Me.btEntrega.Size = New System.Drawing.Size(177, 41)
        Me.btEntrega.TabIndex = 0
        Me.btEntrega.Text = "ENTREGA"
        Me.btEntrega.UseVisualStyleBackColor = False
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1545, 895)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuMain)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIMain"
        Me.Text = "MDIMAIN"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuMain.ResumeLayout(False)
        Me.MenuMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElementoTipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Inventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Lavanderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Entregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntregadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents TooltStatusUser As ToolStripStatusLabel
    Friend WithEvents ToolStripDiv1 As ToolStripStatusLabel
    Friend WithEvents TooltStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripDiv2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLbl2 As ToolStripStatusLabel
    Friend WithEvents ToolStripDiv22 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripDiv23 As ToolStripStatusLabel
    Friend WithEvents ToolStripActualizacion As ToolStripStatusLabel
    Friend WithEvents MenuMain As MenuStrip
    Friend WithEvents InicioToolStrip As ToolStripMenuItem
    Friend WithEvents EntregaStrip As ToolStripMenuItem
    Friend WithEvents RecepcionStrip As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ImprimeToolStrip As ToolStripMenuItem
    Friend WithEvents VistapreviaToolStrip As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AcercadeTool As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btDevolucion As Button
    Friend WithEvents btEntrega As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents pbUsr As PictureBox
    Friend WithEvents dgv_Usuarios As DataGridView
    Friend WithEvents lblUsuario As Label
    Friend WithEvents DsMain As dsMain
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCaptura As Label
    Friend WithEvents pbBata As PictureBox
    Friend WithEvents lblCodigo4 As Label
    Friend WithEvents tbCodigo4 As TextBox
    Friend WithEvents lblCodigo3 As Label
    Friend WithEvents tbCodigo3 As TextBox
    Friend WithEvents lblCodigo2 As Label
    Friend WithEvents tbCodigo2 As TextBox
    Friend WithEvents lblCodigo1 As Label
    Friend WithEvents tbCodigo1 As TextBox
    Public WithEvents btOk As Button
    Public WithEvents btCancelar As Button
    Public WithEvents btSearch As Button
    Friend WithEvents btLavanderia As Button
    Friend WithEvents btIngreso As Button
    Friend WithEvents pbIngreso As PictureBox
    Friend WithEvents lblIngreso As Label
    Friend WithEvents tbIngreso As TextBox
    Public WithEvents btIngresar As Button
    Friend WithEvents dgv_Lavanderia As DataGridView
    Friend WithEvents dgv_Entregados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SuciosBindingSource As BindingSource
    Friend WithEvents EntregadosBindingSource As BindingSource
    Friend WithEvents dgv_Inventario As DataGridView
    Friend WithEvents InventarioDataTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ElementoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TallaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents chb_Baja As CheckBox
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OficioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ElementoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TallaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents TallaBindingSource As BindingSource
    Friend WithEvents ElementoTipoBindingSource As BindingSource
    Friend WithEvents cbElementoTipo As CheckedListBox
    Friend WithEvents cbTalla As CheckedListBox
    Friend WithEvents cbColor As CheckedListBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Oficio As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblInventario As TextBox
    Friend WithEvents lblLavanderia As TextBox
    Friend WithEvents lblEntregados As TextBox
End Class
