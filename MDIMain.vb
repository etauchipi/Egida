Imports System.Globalization
Imports System.Threading
Imports AppGeneral
Imports Egida.wsEgida.wsEgidausrMovimiento

Public Class MDIMain

	Private appProxy As wsEgida.IwsEgidaClient
	Private nId_Usuario As Integer

	Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		''Dim frm As New frmLogin
		''frm.Show()
		Inicializar()

	End Sub

	Sub Inicializar()

		Me.WindowState = FormWindowState.Maximized

		Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
		Me.Text = "Clinica de la Mujer - " & Application.ProductName & " - " & "Ver: " & Application.ProductVersion & " - " & "Publicación: " & My.Application.Deployment.CurrentVersion.ToString()
		TooltStatusLabel.Text = "No conectado"

		Inicializar_Forma()

	End Sub

	Sub Inicializar_Forma()

		UsuariosBindingSource.DataSource = vbNull
		dgv_Usuarios.Refresh()

		If ePermisos.Administrador Then
			Me.btIngreso.Visible = True
			Me.btIngreso.Enabled = True
			Carga_Color()
			Carga_Elemento_Tipo()
			Carga_Talla()
		Else
			Me.btIngreso.Visible = False
		End If

		Me.btEntrega.Visible = True
		Me.btDevolucion.Visible = True
		Me.btLavanderia.Visible = True
		Me.btEntrega.Enabled = True
		Me.btDevolucion.Enabled = True
		Me.btLavanderia.Enabled = True
		Me.btSearch.Visible = False
		Me.btOk.Visible = False
		Me.btCancelar.Visible = False

		Me.lblUsuario.Text = ""
		Me.lblCaptura.Text = ""
		Me.tbSearch.Text = ""
		Me.tbSearch.Visible = False
		Me.dgv_Usuarios.Visible = False
		Me.dgv_Lavanderia.Visible = True
		Me.dgv_Entregados.Visible = True
		Me.dgv_Inventario.Visible = False

		pbUsr.Visible = False
		pbBata.Visible = False

		'Inicializa área de captura de códigos
		tbCodigo1.Text = ""
		tbCodigo2.Text = ""
		tbCodigo3.Text = ""
		tbCodigo4.Text = ""
		tbCodigo1.Visible = False
		tbCodigo2.Visible = False
		tbCodigo3.Visible = False
		tbCodigo4.Visible = False
		chb_Baja.Checked = False
		chb_Baja.Visible = False

		lblCodigo1.Text = ""
		lblCodigo2.Text = ""
		lblCodigo3.Text = ""
		lblCodigo4.Text = ""
		lblIngreso.Text = ""

		bDevolucion = False
		bEntrega = False
		bLavandería = False
		bIngreso = False

		ActivarVista()
		Carga_EnUso()
		Carga_Inventario()
		Actualiza_BDUser()
		limpiar_cbs()

		lblIngreso.Visible = False
		tbIngreso.Visible = False
		pbIngreso.Visible = False
		btIngresar.Visible = False
		cbElementoTipo.Visible = False
		cbColor.Visible = False
		cbTalla.Visible = False

		ResetCods()

	End Sub

	Public Sub Activar_menu()

		Me.InicioToolStrip.Enabled = True
		Me.EntregaStrip.Visible = False
		'Me.HerramientasToolStrip.Visible = False
		'Me.HerramientasToolStrip.Visible = False
		Me.EntregaStrip.Visible = False
		Me.ImprimeToolStrip.Visible = False
		Me.VistapreviaToolStrip.Visible = False

		If oAuthRes._auth = True Then 'dtSession.autorizado Then

			'Me.HerramientasToolStrip.Visible = False
			'Me.OptionsToolStrip.Visible = False
			Me.ImprimeToolStrip.Visible = False
			Me.VistapreviaToolStrip.Visible = False
			Me.RecepcionStrip.Visible = False
			Me.EntregaStrip.Visible = False
			'Me.UsuariosToolStrip.Visible = False
			'Me.ToolStripMenuAdmin.Visible = False

			If (ePermisos.Administrador) Or (ePermisos.Permiso_2) Then
				'Me.HerramientasToolStrip.Visible = True
				'Me.SolicitudToolStrip.Visible = True
			End If

			If (ePermisos.Administrador) Then
				'Me.OptionsToolStrip.Visible = True
				'Me.UsuariosToolStrip.Visible = True
				'Me.ToolStripMenuAdmin.Visible = True
			End If

			If (ePermisos.Administrador) Or (ePermisos.Permiso_1) Then
				Me.EntregaStrip.Visible = True
				Me.RecepcionStrip.Visible = True
			End If

			Me.TooltStatusLabel.Text = "Conectado: " & oAuthRes._names
			Me.TooltStatusUser.Visible = True

		End If

		'Opción global habilitada para todos los perfiles
		Me.SalirToolStripMenuItem.Visible = True

		dtSession.autorizado = oAuthRes._auth
		dtSession.idenom = oAuthRes._names
		dtSession.ideact = oAuthRes._auth

		ActivarVista()

		' Inicia timer
		Timer1.Interval = 300000
		Timer1.Start()
		Mostrar_EnUso()

	End Sub

	Private Sub Mostrar_EnUso()

		'Carga_Data()
		Me.dgv_Lavanderia.Visible = True
		Me.dgv_Entregados.Visible = True
		Me.dgv_Inventario.Visible = True

	End Sub
	Private Sub ActivarVista()

		Dim sCad As String

		sCad = IIf(oAuthRes._names <> "", oAuthRes._names, String.Concat(oAuthRes._name, " ", oAuthRes._surname))
		TooltStatusUser.Text = sCad
		sCad = Format(Date.Now(), "Long Date") + " " + Date.Now().ToString("HH:mm:ss")
		TooltStatusLabel.Text = "Ingreso: " + sCad
		ToolStripStatusLbl2.Text = oAuthRes._email
		TooltStatusUser.Image = My.Resources.green_user_16

		If (oAuthRes._accountstatus = 0) Then
			ToolStripStatusLabel2.Text = "Miembro del dominio"
		Else
			ToolStripStatusLabel2.Text = "Invitado/Externo"
		End If

	End Sub

	Private Sub Carga_Data()
		'Carga_Pacientes()
		'Carga_Formulas()
		'nIdRegistro = 0
	End Sub

	Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
		Application.Exit()
	End Sub

	Private Sub AcercadeTool_Click(sender As Object, e As EventArgs) Handles AcercadeTool.Click
		Dim frmAbout As AboutBox

		frmAbout = New AboutBox
		frmAbout.Show()
	End Sub


	Private Sub btEntrega_Click(sender As Object, e As EventArgs) Handles btEntrega.Click

		bEntrega = True
		bDevolucion = False
		bIngreso = False
		bLavandería = False

		Me.dgv_Lavanderia.Visible = True
		Me.dgv_Entregados.Visible = True
		Me.dgv_Inventario.Visible = True
		btLavanderia.Visible = False
		'btIngreso.Visible = False
		btDevolucion.Visible = False
		btSearch.Visible = True

		btCancelar.Visible = True
		tbSearch.Visible = True
		dgv_Usuarios.Visible = False
		pbBata.Visible = True
		pbUsr.Visible = True
		lblUsuario.Text = "SELECCIONAR USUARIO PARA ENTREGA DE ELEMENTOS"
		lblCaptura.Text = "Seleccionar elementos:"
		tbCodigo1.Text = ""

		ResetCods()

	End Sub

	Private Sub btDevolucion_Click(sender As Object, e As EventArgs) Handles btDevolucion.Click

		bEntrega = False
		bDevolucion = True
		bLavandería = False
		bIngreso = False

		Me.dgv_Lavanderia.Visible = True
		Me.dgv_Entregados.Visible = True
		Me.dgv_Inventario.Visible = True
		'btIngreso.Visible = False
		btLavanderia.Visible = False
		btEntrega.Visible = False
		btCancelar.Visible = True

		tbSearch.Visible = False
		lblUsuario.Text = "DEVOLUCIÓN DE ELEMENTOS"
		lblCaptura.Text = "ingresar los código de los elementos a devolver:"
		dgv_Usuarios.Visible = False

		tbCodigo1.Visible = True
		tbCodigo1.Text = ""

		ResetCods()

	End Sub

	Private Sub dgv_Usuarios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_Usuarios.RowHeaderMouseClick
		Dim nRow As Integer
		Dim nUser As Integer

		nRow = dgv_Usuarios.CurrentCellAddress.Y
		nUser = CInt(dgv_Usuarios.Rows(nRow).Cells("Id").Value)
		nId_Usuario = nUser

		lblCaptura.Text = dgv_Usuarios.Rows(nRow).Cells(2).Value
		dgv_Usuarios.Enabled = False
		dgv_Usuarios.Visible = False
		tbCodigo1.Visible = True

	End Sub


	'Data -----------------------------------------
	Private Function Carga_Elemento(codigo As String) As String

		Dim ds As DataSet
		Dim sds As String
		Dim retorno As String
		Dim retorno1 As String
		Dim retorno2 As String
		Dim retorno3 As String
		Dim sIdent As String

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		If bEntrega Then
			nId_Usuario = CInt(dgv_Usuarios.SelectedCells.Item(0).Value)
			sIdent = dgv_Usuarios.SelectedCells.Item(4).Value.ToString
		Else
			nId_Usuario = 0
			sIdent = String.Empty
		End If

		Try
			If bDevolucion Then
				sds = appProxy.Get_elemento(codigo, wsEgida.wsEgidawsMovimientoTipo.Devolucion, 0)
			ElseIf bEntrega Then
				sds = appProxy.Get_elemento(codigo, wsEgida.wsEgidawsMovimientoTipo.Entrega, nId_Usuario)
			ElseIf bLavandería Then
				sds = appProxy.Get_elemento(codigo, wsEgida.wsEgidawsMovimientoTipo.Lavanderia, 0)
			End If

		Catch ex As Exception
			sds = String.Empty
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				sds = String.Empty
				AppGen.RegistreEvento("Error servicio: Carga_Elemento - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try
		End If

		If sds <> String.Empty Then
			Try
				retorno1 = ds.Tables(0).Rows(0).Item("Elemento").ToString
				retorno2 = " " & ds.Tables(0).Rows(0).Item("Color").ToString
				retorno3 = " - Talla: " & ds.Tables(0).Rows(0).Item("Talla").ToString
				retorno = retorno1.Trim & " " & retorno2.Trim & " " & retorno3.Trim
				btOk.Visible = True
			Catch ex As Exception
				retorno = "Con pendientes por devolver / No disponible / No existe"
				EntregadosBindingSource.Filter = "Identificacion LIKE '%" & Trim(sIdent) & "%'"
				btOk.Visible = False
			Finally
			End Try
		End If

		sds = ""

		Return retorno

	End Function


	Private Sub Carga_EnUso()

		Dim ds As DataSet
		Dim ds1 As DataSet
		Dim dv As DataView
		Dim DtDatos As DataTable
		Dim dv1 As DataView
		Dim DtDatos1 As DataTable
		Dim sds As String
		Dim sds1 As String

		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion
		sds = ""
		sds1 = ""

		Try
			sds = appProxy.Get_EnUso(wsEgida.wsEgidawsMovimientoTipo.Entrega)
			sds1 = appProxy.Get_EnUso(wsEgida.wsEgidawsMovimientoTipo.Devolucion)
		Catch ex As Exception
			AppGen.RegistreEvento("Error servicio: Carga_EnUso - " & ex.Message, TipoEvento.Ev_General, "Application")
			sds = String.Empty
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
				ds1 = Compresion.DescomprimirDataset(sds1)
			Catch ex As Exception
				sds = String.Empty
				AppGen.RegistreEvento("Error servicio: Carga_EnUso (final) - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try
		End If

		dv = ds.Tables(0).DefaultView
		dv.Sort = "Fecha" & " Desc"
		EntregadosBindingSource.DataSource = dv.ToTable
		dgv_Entregados.Refresh()
		nEntregado = ds.Tables(0).Rows.Count()

		dv1 = ds1.Tables(0).DefaultView
		dv1.Sort = "Fecha" & " Desc"
		SuciosBindingSource.DataSource = dv1.ToTable
		dgv_Lavanderia.Refresh()
		nLavanderia = ds1.Tables(0).Rows.Count()

		lblEntregados.Text = Format(nEntregado, "#,##0")
		lblLavanderia.Text = Format(nLavanderia, "#,##0")

	End Sub

	Private Sub tbCodigo1_Validated(sender As Object, e As EventArgs) Handles tbCodigo1.Validated

		Dim codigo As String

		btEntrega.Visible = False
		codigo = Trim(tbCodigo1.Text)
		lblCodigo1.Text = Carga_Elemento(codigo)

		If (lblCodigo1.Text <> "Con pendientes por devolver / No disponible / No existe" And Trim(lblCodigo1.Text) <> "") Then
			tbCodigo2.Visible = True
			btOk.Visible = True
		Else
			tbCodigo2.Text = ""
			tbCodigo2.Visible = False
			lblCodigo2.Text = ""
			btOk.Visible = False
		End If

	End Sub

	Private Sub tbCodigo2_Validated(sender As Object, e As EventArgs) Handles tbCodigo2.Validated

		Dim codigo As String

		btEntrega.Visible = False
		codigo = Trim(tbCodigo2.Text)
		lblCodigo2.Text = Carga_Elemento(codigo)
		btOk.Visible = True

		If ((lblCodigo2.Text <> "Con pendientes por devolver / No disponible / No existe" And codigo <> "") And (codigo <> Trim(tbCodigo1.Text))) Then
			tbCodigo3.Visible = True
			btOk.Visible = True
		Else
			tbCodigo3.Text = ""
			lblCodigo3.Text = ""
			tbCodigo3.Visible = False
			btOk.Visible = False
		End If

	End Sub

	Private Sub tbCodigo3_Validated(sender As Object, e As EventArgs) Handles tbCodigo3.Validated

		Dim codigo As String

		btEntrega.Visible = False
		codigo = Trim(tbCodigo3.Text)
		lblCodigo3.Text = Carga_Elemento(codigo)
		btOk.Visible = True

		If ((lblCodigo3.Text <> "Con pendientes por devolver / No disponible / No existe" And codigo <> "") And (codigo <> Trim(tbCodigo1.Text)) And (codigo <> Trim(tbCodigo2.Text))) Then
			tbCodigo4.Visible = True
			btOk.Visible = True
		Else
			tbCodigo4.Text = ""
			lblCodigo4.Text = ""
			tbCodigo4.Visible = False
			lblCodigo4.Text = ""
			btOk.Visible = False
		End If

	End Sub

	Private Sub tbCodigo4_Validated(sender As Object, e As EventArgs) Handles tbCodigo4.Validated

		Dim codigo As String

		btEntrega.Visible = False
		codigo = Trim(codigo)
		lblCodigo4.Text = Carga_Elemento(codigo)

		If ((lblCodigo4.Text <> "Con pendientes por devolver / No disponible / No existe" And codigo <> "") And (codigo <> Trim(tbCodigo1.Text)) And (codigo <> Trim(tbCodigo2.Text)) And (codigo <> Trim(tbCodigo3.Text))) Then
			btOk.Visible = True
		Else
			btOk.Visible = False
		End If

	End Sub

	Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click

		EntregadosBindingSource.Filter = ""
		Mostrar_EnUso()
		limpiar_cbs()
		Inicializar_Forma()

	End Sub

	Private Sub ResetCods()

		Cod1 = 0
		Cod2 = 0
		Cod3 = 0
		Cod4 = 0
		CodUsr = 0

	End Sub

	Private Sub Graba_movimiento(nIdUsuario As Integer, sCodigo As String, nMovTipo As wsEgida.wsEgidawsMovimientoTipo)

		Dim Registro As wsEgida.wsEgidausrMovimiento
		Dim bFlag As Boolean

		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Registro = New wsEgida.wsEgidausrMovimiento

		Registro.Id_Usuario = nIdUsuario
		Registro.Codigo = sCodigo

		Try
			bFlag = appProxy.Set_Movimiento(Registro, nMovTipo)
		Catch ex As Exception
			AppGen.RegistreEvento("Error Servicio: Graba_movimiento - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally

		End Try

	End Sub

	Private Sub Graba_elemento(nId_elemento_Tipo As Integer, nId_Talla As Integer, nId_Color As Integer, sCodigo As String)

		Dim Registro As wsEgida.wsEgidausrMovimiento
		Dim bFlag As Boolean

		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Try
			bFlag = appProxy.Set_Elemento(nId_elemento_Tipo, nId_Talla, nId_Color, sCodigo)
		Catch ex As Exception
			AppGen.RegistreEvento("Error Servicio: Graba_elemento - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally

		End Try

	End Sub

	Private Sub Actualiza_BDUser()

		Dim bFlag As Boolean

		appProxy = New wsEgida.IwsEgidaClient

		Try
			bFlag = appProxy.Actualiza_Usuarios()
		Catch ex As Exception
			AppGen.RegistreEvento("Error Servicio: Graba_elemento - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally

		End Try

	End Sub


	Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click

		Dim sCad As String

		sCad = tbSearch.Text.Trim
		Carga_Usuarios(sCad)

	End Sub


	Private Sub Carga_Usuarios(sCad As String)

		Dim ds As DataSet
		Dim sds As String
		Dim dv As DataView

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Try
			sds = appProxy.Get_usuarios(sCad)
		Catch ex As Exception
			sds = String.Empty
			AppGen.RegistreEvento("Error extrayendo usuarios - Carga_Usuarios - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				AppGen.RegistreEvento("Error Servicio: Carga_Usuarios - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try

		End If

		Try
			dv = ds.Tables(0).DefaultView
			dv.Sort = "Nombre" & " Asc"
			UsuariosBindingSource.DataSource = dv.ToTable
			dgv_Usuarios.Visible = True
			dgv_Usuarios.Refresh()
			dgv_Usuarios.Enabled = True
		Catch ex As Exception
			AppGen.RegistreEvento("Error binding dataset USUARIOS - Carga_Usuarios - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
		End Try

	End Sub

	Private Sub Carga_Color()

		Dim ds As DataSet
		Dim sds As String

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Try
			sds = appProxy.Get_colores()
		Catch ex As Exception
			sds = String.Empty
			AppGen.RegistreEvento("Error extrayendo usuarios - Carga_Color - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				AppGen.RegistreEvento("Error Servicio: Carga_Color (1) - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try

		End If

		Try
			cbColor.Items.Clear()
			ReDim nItemColor(ds.Tables(0).Rows.Count)

			For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				cbColor.Items.Add(ds.Tables(0).Rows(i).Item("Color").ToString)
				nItemColor(i) = (CInt(ds.Tables(0).Rows(i).Item("Id").ToString))
			Next

			cbColor.Visible = True
			cbColor.SelectionMode = SelectionMode.One
		Catch ex As Exception
			AppGen.RegistreEvento("Error binding dataset COLOR - Carga_Color (2) - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
		End Try

	End Sub

	Private Sub Carga_Talla()

		Dim ds As DataSet
		Dim sds As String

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Try
			sds = appProxy.Get_tallas()
		Catch ex As Exception
			sds = String.Empty
			AppGen.RegistreEvento("Error extrayendo usuarios - Carga_Talla - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				AppGen.RegistreEvento("Error Servicio: Carga_Talla (1) - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try

		End If

		Try
			cbTalla.Items.Clear()
			ReDim nItemTalla(ds.Tables(0).Rows.Count)

			For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				cbTalla.Items.Add(ds.Tables(0).Rows(i).Item("Talla").ToString)
				nItemTalla(i) = (CInt(ds.Tables(0).Rows(i).Item("Id").ToString))
			Next

			cbTalla.Visible = True
		Catch ex As Exception
			AppGen.RegistreEvento("Error binding dataset TALLA - Carga_Talla (2) - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
		End Try

		cbTalla.SelectionMode = SelectionMode.One

	End Sub

	Private Sub Carga_Elemento_Tipo()

		Dim ds As DataSet
		Dim sds As String

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion

		Try
			sds = appProxy.Get_elementos_tipo()
		Catch ex As Exception
			sds = String.Empty
			AppGen.RegistreEvento("Error extrayendo usuarios - Carga_Elemento_Tipo - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				AppGen.RegistreEvento("Error Servicio: Carga_Elemento_Tipo (1) - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try

		End If

		Try
			cbElementoTipo.Items.Clear()
			ReDim nItemTipo(ds.Tables(0).Rows.Count)

			For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				cbElementoTipo.Items.Add(ds.Tables(0).Rows(i).Item("Elemento").ToString)
				nItemTipo(i) = (CInt(ds.Tables(0).Rows(i).Item("Id").ToString))
			Next

			cbElementoTipo.Visible = True
		Catch ex As Exception
			AppGen.RegistreEvento("Error binding dataset ELEMENTO TIPO - Carga_Elemento_Tipo (2) - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
		End Try

		cbElementoTipo.SelectionMode = SelectionMode.One

	End Sub


	Private Sub Carga_Inventario()

		Dim ds As DataSet
		Dim sds As String
		Dim dv As DataView
		Dim DtDatos As DataTable

		ds = New DataSet
		appProxy = New wsEgida.IwsEgidaClient
		AppGen = New AppGeneral.AppGeneral
		Compresion = New Compresion.Compresion
		DtDatos = New DataTable

		Try
			sds = appProxy.Get_elemento("0", wsEgida.wsEgidawsMovimientoTipo.Inventario, 0)
		Catch ex As Exception
			sds = String.Empty
			AppGen.RegistreEvento("Error extrayendo - Carga_Inventario - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
			'AppProxy.Close()
		End Try

		If sds <> String.Empty Then
			Try
				ds = Compresion.DescomprimirDataset(sds)
			Catch ex As Exception
				AppGen.RegistreEvento("Error Servicio: Carga_Inventario (1) - " & ex.Message, TipoEvento.Ev_General, "Application")
			Finally
			End Try

		End If

		Try
			dv = ds.Tables(0).DefaultView
			dv.Sort = "Elemento"
			dgv_Inventario.DataSource = dv.ToTable
			dgv_Inventario.Visible = True
			dgv_Inventario.Refresh()
			nDisponible = ds.Tables(0).Rows.Count()
		Catch ex As Exception
			AppGen.RegistreEvento("Error binding dataset COLOR - Carga_Inventario (2) - " & ex.Message, TipoEvento.Ev_General, "Application")
		Finally
		End Try

		lblInventario.Text = Format(nDisponible, "#,##0")

	End Sub


	Private Sub tbCodigo1_TextChanged(sender As Object, e As EventArgs) Handles tbCodigo1.TextChanged

		If lblCodigo1.Text <> "" Then
			tbCodigo2.Visible = True
			btOk.Visible = True
		End If

	End Sub

	Private Sub btOk_Click(sender As Object, e As EventArgs) Handles btOk.Click

		Dim nRow As Integer
		Dim nUser As Integer
		Dim ntipoEnt = 0

		If (chb_Baja.Checked And ePermisos.Administrador = True) Then
			ntipoEnt = wsEgida.wsEgidawsMovimientoTipo.Baja
			nUser = 0
		ElseIf bEntrega Then
			ntipoEnt = wsEgida.wsEgidawsMovimientoTipo.Entrega
			nRow = dgv_Usuarios.SelectedCells.Item(0).RowIndex()
			nUser = dgv_Usuarios.SelectedCells.Item(0).Value
		ElseIf bDevolucion Then
			ntipoEnt = wsEgida.wsEgidawsMovimientoTipo.Devolucion
			nUser = 0
		ElseIf bLavandería Then
			ntipoEnt = wsEgida.wsEgidawsMovimientoTipo.Lavanderia
			nUser = 0
		End If

		nId_Usuario = nUser

		If Len(tbCodigo1.Text.Trim()) > 0 Then
			Graba_movimiento(nUser, tbCodigo1.Text.Trim(), ntipoEnt)
		End If

		If Len(tbCodigo2.Text.Trim()) > 0 Then
			Graba_movimiento(nUser, tbCodigo2.Text.Trim(), ntipoEnt)
		End If

		If Len(tbCodigo3.Text.Trim()) > 0 Then
			Graba_movimiento(nUser, tbCodigo3.Text.Trim(), ntipoEnt)
		End If

		If Len(tbCodigo4.Text.Trim()) > 0 Then
			Graba_movimiento(nUser, tbCodigo4.Text.Trim(), ntipoEnt)
		End If

		EntregadosBindingSource.Filter = ""
		Inicializar_Forma()
		Mostrar_EnUso()
		btOk.Visible = False

	End Sub

	Private Sub btLavanderia_Click(sender As Object, e As EventArgs) Handles btLavanderia.Click

		bLavandería = True
		bEntrega = False
		bDevolucion = False
		bIngreso = False

		Me.dgv_Lavanderia.Visible = True
		Me.dgv_Entregados.Visible = True
		Me.dgv_Inventario.Visible = True
		'btIngreso.Visible = False
		btDevolucion.Visible = False
		btEntrega.Visible = False
		btLavanderia.Visible = True
		btCancelar.Visible = True
		dgv_Usuarios.Visible = False
		tbSearch.Visible = False

		lblUsuario.Text = "ENTRADA DESDE LAVANDERÍA"
		lblCaptura.Text = "ingresar los código de los elementos a ingresar:"

		tbCodigo1.Visible = True
		tbCodigo1.Text = ""

		If ePermisos.Administrador Then
			chb_Baja.Visible = True
			chb_Baja.Checked = False
		Else
			chb_Baja.Visible = False
		End If

		ResetCods()

	End Sub

	Private Sub btIngreso_Click(sender As Object, e As EventArgs) Handles btIngreso.Click

		If ePermisos.Administrador Then
			Me.dgv_Lavanderia.Visible = True
			Me.dgv_Entregados.Visible = True
			Me.dgv_Inventario.Visible = True
			bEntrega = False
			bDevolucion = False
			bLavandería = False
			bIngreso = True
			btCancelar.Visible = True
			btDevolucion.Visible = False
			btEntrega.Visible = False
			btLavanderia.Visible = False
			cbTalla.Visible = True
			cbColor.Visible = True
			cbElementoTipo.Visible = True
			lblIngreso.Visible = True
			tbIngreso.Visible = True
			pbIngreso.Visible = True
			chb_Baja.Visible = False
			chb_Baja.Checked = False

			Carga_Color()
			Carga_Elemento_Tipo()
			Carga_Talla()
		End If


	End Sub

	Private Sub tbIngreso_TextChanged(sender As Object, e As EventArgs) Handles tbIngreso.TextChanged

		btIngresar.Visible = True

	End Sub

	Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

		Dim sCod As String

		If ePermisos.Administrador Then
			sCod = Trim(tbIngreso.Text)

			If ((Len(Trim(sCod)) > 0) And (nIdColor > 0) And (nIdTalla > 0) And (nIdtipoE > 0)) Then
				Graba_elemento(nIdtipoE, nIdTalla, nIdColor, sCod)
				btIngresar.Visible = False
				tbIngreso.Text = ""
				Carga_Inventario()
				limpiar_cbs()
				btIngresar.Visible = False
			End If

		End If

	End Sub

	Private Sub cbElementoTipo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbElementoTipo.SelectedIndexChanged

		nIdtipoE = nItemTipo(cbElementoTipo.SelectedIndex)


	End Sub

	Private Sub cbTalla_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbTalla.SelectedIndexChanged

		nIdTalla = nItemTalla(cbTalla.SelectedIndex)

	End Sub

	Private Sub cbColor_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbColor.SelectedIndexChanged

		nIdColor = nItemColor(cbColor.SelectedIndex)

	End Sub

	Private Sub limpiar_cbs()

		Carga_Color()
		Carga_Elemento_Tipo()
		Carga_Talla()

		nIdColor = 0
		nIdTalla = 0
		nIdtipoE = 0

	End Sub

End Class
