Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh.My
Imports ssh.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace ssh
	<DesignerGenerated>
	Public Class buscar_ficha
		Inherits Form
		Private components As IContainer

        Friend Overridable Property _Button10 As Button
            Get
                Dim stackVariable1 = Me._Button10
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button10_Click)
                Dim button As System.Windows.Forms.Button = Me._Button10
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button10 = value
                button = Me._Button10
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button11 As Button
            Get
                Dim stackVariable1 = Me._Button11
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button11_Click)
                Dim button As System.Windows.Forms.Button = Me._Button11
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button11 = value
                button = Me._Button11
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button12 As Button
            Get
                Dim stackVariable1 = Me._Button12
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button12_Click)
                Dim button As System.Windows.Forms.Button = Me._Button12
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button12 = value
                button = Me._Button12
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button5 As Button
            Get
                Dim stackVariable1 = Me._Button5
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button5_Click)
                Dim button As System.Windows.Forms.Button = Me._Button5
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button5 = value
                button = Me._Button5
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button7 As Button
            Get
                Dim stackVariable1 = Me._Button7
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button7_Click)
                Dim button As System.Windows.Forms.Button = Me._Button7
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button7 = value
                button = Me._Button7
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button8 As Button
            Get
                Dim stackVariable1 = Me._Button8
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button8_Click)
                Dim button As System.Windows.Forms.Button = Me._Button8
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button8 = value
                button = Me._Button8
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Button9 As Button
            Get
                Dim stackVariable1 = Me._Button9
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button9_Click)
                Dim button As System.Windows.Forms.Button = Me._Button9
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me._Button9 = value
                button = Me._Button9
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _DataGridView1 As DataGridView
            Get
                Dim stackVariable1 = Me._DataGridView1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.DataGridView)
                Dim dataGridViewColumnEventHandler As System.Windows.Forms.DataGridViewColumnEventHandler = New System.Windows.Forms.DataGridViewColumnEventHandler(AddressOf Me.DataGridView1_ColumnAdded)
                Dim dataGridViewCellEventHandler As System.Windows.Forms.DataGridViewCellEventHandler = New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.DataGridView1_CellClick)
                Dim dataGridView As System.Windows.Forms.DataGridView = Me._DataGridView1
                If (dataGridView IsNot Nothing) Then
                    RemoveHandler dataGridView.ColumnAdded, dataGridViewColumnEventHandler
                    RemoveHandler dataGridView.CellClick, dataGridViewCellEventHandler
                End If
                Me._DataGridView1 = value
                dataGridView = Me._DataGridView1
                If (dataGridView IsNot Nothing) Then
                    AddHandler dataGridView.ColumnAdded, dataGridViewColumnEventHandler
                    AddHandler dataGridView.CellClick, dataGridViewCellEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox

		Friend Overridable Property GroupBox2 As GroupBox

		Friend Overridable Property GroupBox3 As GroupBox

		Friend Overridable Property GroupBox4 As GroupBox

		Friend Overridable Property Label1 As Label

		Friend Overridable Property Label2 As Label

		Friend Overridable Property Label3 As Label

		Friend Overridable Property Label4 As Label

		Friend Overridable Property Label5 As Label

		Friend Overridable Property Label6 As Label

		Friend Overridable Property Label7 As Label

		Friend Overridable Property Label8 As Label

		Friend Overridable Property Panel1 As Panel

		Friend Overridable Property Panel2 As Panel

		Friend Overridable Property Panel3 As Panel

		Friend Overridable Property Panel4 As Panel

        Friend Overridable Property _PictureBox1 As PictureBox
            Get
                Dim stackVariable1 = Me._PictureBox1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.PictureBox)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.PictureBox1_Click)
                Dim pictureBox As System.Windows.Forms.PictureBox = Me._PictureBox1
                If (pictureBox IsNot Nothing) Then
                    RemoveHandler pictureBox.Click, eventHandler
                End If
                Me._PictureBox1 = value
                pictureBox = Me._PictureBox1
                If (pictureBox IsNot Nothing) Then
                    AddHandler pictureBox.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _RadioButton1 As RadioButton
            Get
                Dim stackVariable1 = Me._RadioButton1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton1_CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me._RadioButton1
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me._RadioButton1 = value
                radioButton = Me._RadioButton1
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _RadioButton2 As RadioButton
            Get
                Dim stackVariable1 = Me._RadioButton2
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton2_CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me._RadioButton2
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me._RadioButton2 = value
                radioButton = Me._RadioButton2
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _RadioButton3 As RadioButton
            Get
                Dim stackVariable1 = Me._RadioButton3
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton3_CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me._RadioButton3
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me._RadioButton3 = value
                radioButton = Me._RadioButton3
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _Textbuscar As TextEdit
            Get
                Dim stackVariable1 = Me._Textbuscar
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Textbuscar_Enter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.Textbuscar_Leave)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.Textbuscar_KeyDown)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me._Textbuscar
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                End If
                Me._Textbuscar = value
                textEdit = Me._Textbuscar
                If (textEdit IsNot Nothing) Then
                    AddHandler textEdit.Enter, eventHandler
                    AddHandler textEdit.Leave, eventHandler1
                    AddHandler textEdit.KeyDown, keyEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _TextEdit1 As TextEdit
            Get
                Dim stackVariable1 = Me._TextEdit1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit1_Enter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit1_Leave)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextEdit1_KeyDown)
                Dim keyPressEventHandler As System.Windows.Forms.KeyPressEventHandler = New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.TextEdit1_KeyPress)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me._TextEdit1
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                    RemoveHandler textEdit.KeyPress, keyPressEventHandler
                End If
                Me._TextEdit1 = value
                textEdit = Me._TextEdit1
                If (textEdit IsNot Nothing) Then
                    AddHandler textEdit.Enter, eventHandler
                    AddHandler textEdit.Leave, eventHandler1
                    AddHandler textEdit.KeyDown, keyEventHandler
                    AddHandler textEdit.KeyPress, keyPressEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property _TextEdit2 As TextEdit
            Get
                Dim stackVariable1 = Me._TextEdit2
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit2_Enter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit2_Leave)
                Dim keyPressEventHandler As System.Windows.Forms.KeyPressEventHandler = New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.TextEdit2_KeyPress)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextEdit2_KeyDown)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me._TextEdit2
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyPress, keyPressEventHandler
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                End If
                Me._TextEdit2 = value
                textEdit = Me._TextEdit2
                If (textEdit IsNot Nothing) Then
                    AddHandler textEdit.Enter, eventHandler
                    AddHandler textEdit.Leave, eventHandler1
                    AddHandler textEdit.KeyPress, keyPressEventHandler
                    AddHandler textEdit.KeyDown, keyEventHandler
                End If
            End Set
        End Property

        Public Sub New()
			MyBase.New()
			AddHandler MyBase.MouseMove,  New MouseEventHandler(AddressOf Me.Listado_MouseMove)
			AddHandler MyBase.Activated,  New EventHandler(AddressOf Me.buscar_ficha_Activated)
			Me.InitializeComponent()
		End Sub

		Private Sub buscar_ficha_Activated(ByVal sender As Object, ByVal e As EventArgs)
            Me._DataGridView1.DataSource = Nothing
            Me.Panel1.Visible = False
		End Sub

		Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs)
			conexionmysql.Abrir_MYBD()
			Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where identidad_alumno like '%", Me._TextEdit1.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
				Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
				If (dataTable.Rows.Count <= 0) Then
					MessageBox.Show("No hay descripcion para este ID")
                    Me._DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
					modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Año anterior', lugar_anterior as 'Lugar anterior'  "
					modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me._DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where identidad_alumno Like  '%", Me._TextEdit1.Text, "%'")
                    modulo_funciones_sql.carga_data()
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
				ProjectData.ClearProjectError()
			End Try
			conexionmysql.Cerrar_MYBD()
		End Sub

		Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me._TextEdit2.Text = ""
        End Sub

		Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs)
			conexionmysql.Abrir_MYBD()
			Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where codigo like '%", Me._TextEdit2.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
				Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
				If (dataTable.Rows.Count <= 0) Then
					MessageBox.Show("No hay descripcion para este ID")
                    Me._DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
					modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Anio anterior', lugar_anterior as 'Lugar anterior'"
					modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me._DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where codigo Like  '%", Me._TextEdit2.Text, "%'")
                    modulo_funciones_sql.carga_data()
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
				ProjectData.ClearProjectError()
			End Try
			conexionmysql.Cerrar_MYBD()
		End Sub

		Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.Hide()
			MyProject.Forms.ficha_matricula.Show()
		End Sub

		Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me._Textbuscar.Text = ""
        End Sub

		Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs)
			conexionmysql.Abrir_MYBD()
			Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where nombre like '%", Me._Textbuscar.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
				Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
				If (dataTable.Rows.Count <= 0) Then
					MessageBox.Show("No hay descripcion para este ID")
                    Me._DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
					modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Año anterior', lugar_anterior as 'Lugar anterior'  "
					modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me._DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where nombre Like  '%", Me._Textbuscar.Text, "%'")
                    modulo_funciones_sql.carga_data()
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
				ProjectData.ClearProjectError()
			End Try
			conexionmysql.Cerrar_MYBD()
		End Sub

		Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me._TextEdit1.Text = ""
        End Sub

		Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
			Try
                Dim currentRow As DataGridViewRow = Me._DataGridView1.CurrentRow
                modulo_variables_globales.valor_del_cellclick = Conversions.ToInteger(currentRow.Cells(0).Value)
				Me.Panel1.Visible = True
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub DataGridView1_ColumnAdded(ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)
			e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
		End Sub

		<DebuggerNonUserCode>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
				If (If(Not disposing, False, Me.components IsNot Nothing)) Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscar_ficha))
			Me.Panel4 = New Panel()
			Me.Label1 = New Label()
			Me.GroupBox1 = New GroupBox()
            Me._Button7 = New Button()
            Me._Textbuscar = New TextEdit()
            Me._Button8 = New Button()
            Me.Label2 = New Label()
            Me._TextEdit2 = New TextEdit()
            Me._Button11 = New Button()
            Me._Button12 = New Button()
            Me.Label7 = New Label()
			Me.GroupBox4 = New GroupBox()
			Me.Panel3 = New Panel()
			Me.Label8 = New Label()
			Me.Panel2 = New Panel()
			Me.Label5 = New Label()
			Me.GroupBox3 = New GroupBox()
            Me._Button9 = New Button()
            Me._TextEdit1 = New TextEdit()
            Me._Button10 = New Button()
            Me.Label6 = New Label()
            Me._RadioButton3 = New RadioButton()
            Me._RadioButton2 = New RadioButton()
            Me.GroupBox2 = New GroupBox()
            Me._RadioButton1 = New RadioButton()
            Me.Label3 = New Label()
            Me._DataGridView1 = New DataGridView()
            Me.Panel1 = New Panel()
			Me.Label4 = New Label()
            Me._Button5 = New Button()
            Me._PictureBox1 = New PictureBox()
            Me.Panel4.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
            DirectCast(Me._Textbuscar.Properties, ISupportInitialize).BeginInit()
            DirectCast(Me._TextEdit2.Properties, ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
            DirectCast(Me._TextEdit1.Properties, ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            DirectCast(Me._DataGridView1, ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            DirectCast(Me._PictureBox1, ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
			Me.Panel4.Controls.Add(Me.Label1)
			Me.Panel4.Controls.Add(Me.GroupBox1)
			Me.Panel4.Controls.Add(Me.Label2)
			Me.Panel4.Location = New Point(26, 99)
			Me.Panel4.Name = "Panel4"
			Me.Panel4.Size = New System.Drawing.Size(385, 72)
			Me.Panel4.TabIndex = 200
			Me.Panel4.Visible = False
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Color.Black
			Me.Label1.Location = New Point(7, 7)
			Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New System.Drawing.Size(111, 13)
			Me.Label1.TabIndex = 160
			Me.Label1.Text = "Búsqueda por nombre"
			Me.Label1.Visible = False
            Me.GroupBox1.Controls.Add(Me._Button7)
            Me.GroupBox1.Controls.Add(Me._Textbuscar)
            Me.GroupBox1.Controls.Add(Me._Button8)
            Me.GroupBox1.Location = New Point(3, 16)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New System.Drawing.Size(379, 38)
			Me.GroupBox1.TabIndex = 164
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Visible = False
            Me._Button7.BackColor = Color.Transparent
            Me._Button7.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button7.BackgroundImage"), Image)
            Me._Button7.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button7.FlatAppearance.BorderColor = Color.White
            Me._Button7.FlatAppearance.BorderSize = 0
            Me._Button7.FlatStyle = FlatStyle.Flat
            Me._Button7.Location = New Point(326, 11)
            Me._Button7.Name = "Button7"
            Me._Button7.Size = New System.Drawing.Size(24, 23)
            Me._Button7.TabIndex = 188
            Me._Button7.UseVisualStyleBackColor = False
            Me._Button7.Visible = False
            Me._Textbuscar.EditValue = "Búsqueda por nombre"
            Me._Textbuscar.Location = New Point(3, 12)
            Me._Textbuscar.Margin = New System.Windows.Forms.Padding(4)
            Me._Textbuscar.Name = "Textbuscar"
            Me._Textbuscar.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me._Textbuscar.Properties.Appearance.ForeColor = Color.DimGray
            Me._Textbuscar.Properties.Appearance.Options.UseFont = True
            Me._Textbuscar.Properties.Appearance.Options.UseForeColor = True
            Me._Textbuscar.Properties.BorderStyle = BorderStyles.NoBorder
            Me._Textbuscar.Size = New System.Drawing.Size(324, 22)
            Me._Textbuscar.TabIndex = 13
            Me._Textbuscar.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me._Textbuscar.ToolTipIconType = ToolTipIconType.Information
            Me._Button8.BackColor = Color.Transparent
            Me._Button8.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button8.BackgroundImage"), Image)
            Me._Button8.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button8.FlatAppearance.BorderColor = Color.White
            Me._Button8.FlatAppearance.BorderSize = 0
            Me._Button8.FlatStyle = FlatStyle.Flat
            Me._Button8.Location = New Point(349, 12)
            Me._Button8.Name = "Button8"
            Me._Button8.Size = New System.Drawing.Size(24, 22)
            Me._Button8.TabIndex = 187
            Me._Button8.UseVisualStyleBackColor = False
            Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, FontStyle.Italic, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.DimGray
			Me.Label2.Location = New Point(1, 52)
			Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New System.Drawing.Size(298, 15)
			Me.Label2.TabIndex = 161
			Me.Label2.Text = "Presione la tecla ""Enter"" para realizar una búsqueda"
			Me.Label2.Visible = False
            Me._TextEdit2.EditValue = "Búsqueda por codigo"
            Me._TextEdit2.Location = New Point(3, 12)
            Me._TextEdit2.Margin = New System.Windows.Forms.Padding(4)
            Me._TextEdit2.Name = "TextEdit2"
            Me._TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me._TextEdit2.Properties.Appearance.ForeColor = Color.DimGray
            Me._TextEdit2.Properties.Appearance.Options.UseFont = True
            Me._TextEdit2.Properties.Appearance.Options.UseForeColor = True
            Me._TextEdit2.Properties.BorderStyle = BorderStyles.NoBorder
            Me._TextEdit2.Size = New System.Drawing.Size(324, 22)
            Me._TextEdit2.TabIndex = 13
            Me._TextEdit2.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me._TextEdit2.ToolTipIconType = ToolTipIconType.Information
            Me._Button11.BackColor = Color.Transparent
            Me._Button11.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button11.BackgroundImage"), Image)
            Me._Button11.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button11.FlatAppearance.BorderColor = Color.White
            Me._Button11.FlatAppearance.BorderSize = 0
            Me._Button11.FlatStyle = FlatStyle.Flat
            Me._Button11.Location = New Point(326, 11)
            Me._Button11.Name = "Button11"
            Me._Button11.Size = New System.Drawing.Size(24, 23)
            Me._Button11.TabIndex = 188
            Me._Button11.UseVisualStyleBackColor = False
            Me._Button11.Visible = False
            Me._Button12.BackColor = Color.Transparent
            Me._Button12.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button12.BackgroundImage"), Image)
            Me._Button12.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button12.FlatAppearance.BorderColor = Color.White
            Me._Button12.FlatAppearance.BorderSize = 0
            Me._Button12.FlatStyle = FlatStyle.Flat
            Me._Button12.Location = New Point(349, 12)
            Me._Button12.Name = "Button12"
            Me._Button12.Size = New System.Drawing.Size(24, 22)
            Me._Button12.TabIndex = 187
            Me._Button12.UseVisualStyleBackColor = False
            Me.Label7.AutoSize = True
			Me.Label7.ForeColor = Color.Black
			Me.Label7.Location = New Point(7, 9)
			Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New System.Drawing.Size(108, 13)
			Me.Label7.TabIndex = 189
			Me.Label7.Text = "Búsqueda por codigo"
			Me.Label7.Visible = False
            Me.GroupBox4.Controls.Add(Me._TextEdit2)
            Me.GroupBox4.Controls.Add(Me._Button11)
            Me.GroupBox4.Controls.Add(Me._Button12)
            Me.GroupBox4.Location = New Point(3, 18)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New System.Drawing.Size(379, 38)
			Me.GroupBox4.TabIndex = 191
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Visible = False
			Me.Panel3.Controls.Add(Me.Label7)
			Me.Panel3.Controls.Add(Me.GroupBox4)
			Me.Panel3.Controls.Add(Me.Label8)
			Me.Panel3.Location = New Point(23, 99)
			Me.Panel3.Name = "Panel3"
			Me.Panel3.Size = New System.Drawing.Size(385, 72)
			Me.Panel3.TabIndex = 201
			Me.Panel3.Visible = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, FontStyle.Italic, GraphicsUnit.Point, 0)
			Me.Label8.ForeColor = Color.DimGray
			Me.Label8.Location = New Point(1, 54)
			Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New System.Drawing.Size(298, 15)
			Me.Label8.TabIndex = 190
			Me.Label8.Text = "Presione la tecla ""Enter"" para realizar una búsqueda"
			Me.Label8.Visible = False
			Me.Panel2.Controls.Add(Me.Label5)
			Me.Panel2.Controls.Add(Me.GroupBox3)
			Me.Panel2.Controls.Add(Me.Label6)
			Me.Panel2.Location = New Point(20, 99)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New System.Drawing.Size(385, 72)
			Me.Panel2.TabIndex = 199
			Me.Panel2.Visible = False
			Me.Label5.AutoSize = True
			Me.Label5.ForeColor = Color.Black
			Me.Label5.Location = New Point(7, 9)
			Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New System.Drawing.Size(87, 13)
			Me.Label5.TabIndex = 189
			Me.Label5.Text = "Búsqueda por ID"
			Me.Label5.Visible = False
            Me.GroupBox3.Controls.Add(Me._Button9)
            Me.GroupBox3.Controls.Add(Me._TextEdit1)
            Me.GroupBox3.Controls.Add(Me._Button10)
            Me.GroupBox3.Location = New Point(3, 18)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New System.Drawing.Size(379, 38)
			Me.GroupBox3.TabIndex = 191
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Visible = False
            Me._Button9.BackColor = Color.Transparent
            Me._Button9.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button9.BackgroundImage"), Image)
            Me._Button9.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button9.FlatAppearance.BorderColor = Color.White
            Me._Button9.FlatAppearance.BorderSize = 0
            Me._Button9.FlatStyle = FlatStyle.Flat
            Me._Button9.Location = New Point(326, 11)
            Me._Button9.Name = "Button9"
            Me._Button9.Size = New System.Drawing.Size(24, 23)
            Me._Button9.TabIndex = 188
            Me._Button9.UseVisualStyleBackColor = False
            Me._Button9.Visible = False
            Me._TextEdit1.EditValue = "Búsqueda por ID"
            Me._TextEdit1.Location = New Point(3, 12)
            Me._TextEdit1.Margin = New System.Windows.Forms.Padding(4)
            Me._TextEdit1.Name = "TextEdit1"
            Me._TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me._TextEdit1.Properties.Appearance.ForeColor = Color.DimGray
            Me._TextEdit1.Properties.Appearance.Options.UseFont = True
            Me._TextEdit1.Properties.Appearance.Options.UseForeColor = True
            Me._TextEdit1.Properties.BorderStyle = BorderStyles.NoBorder
            Me._TextEdit1.Size = New System.Drawing.Size(324, 22)
            Me._TextEdit1.TabIndex = 13
            Me._TextEdit1.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me._TextEdit1.ToolTipIconType = ToolTipIconType.Information
            Me._Button10.BackColor = Color.Transparent
            Me._Button10.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button10.BackgroundImage"), Image)
            Me._Button10.BackgroundImageLayout = ImageLayout.Zoom
            Me._Button10.FlatAppearance.BorderColor = Color.White
            Me._Button10.FlatAppearance.BorderSize = 0
            Me._Button10.FlatStyle = FlatStyle.Flat
            Me._Button10.Location = New Point(349, 12)
            Me._Button10.Name = "Button10"
            Me._Button10.Size = New System.Drawing.Size(24, 22)
            Me._Button10.TabIndex = 187
            Me._Button10.UseVisualStyleBackColor = False
            Me.Label6.AutoSize = True
			Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, FontStyle.Italic, GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Color.DimGray
			Me.Label6.Location = New Point(1, 54)
			Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New System.Drawing.Size(298, 15)
			Me.Label6.TabIndex = 190
			Me.Label6.Text = "Presione la tecla ""Enter"" para realizar una búsqueda"
			Me.Label6.Visible = False
            Me._RadioButton3.AutoSize = True
            Me._RadioButton3.Location = New Point(19, 17)
            Me._RadioButton3.Name = "RadioButton3"
            Me._RadioButton3.Size = New System.Drawing.Size(143, 20)
            Me._RadioButton3.TabIndex = 167
            Me._RadioButton3.TabStop = True
            Me._RadioButton3.Text = "Busqueda por codigo"
            Me._RadioButton3.UseVisualStyleBackColor = True
            Me._RadioButton2.AutoSize = True
            Me._RadioButton2.Location = New Point(206, 15)
            Me._RadioButton2.Name = "RadioButton2"
            Me._RadioButton2.Size = New System.Drawing.Size(159, 20)
            Me._RadioButton2.TabIndex = 166
            Me._RadioButton2.TabStop = True
            Me._RadioButton2.Text = "Busqueda por identidad"
            Me._RadioButton2.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me._RadioButton3)
            Me.GroupBox2.Controls.Add(Me._RadioButton2)
            Me.GroupBox2.Controls.Add(Me._RadioButton1)
            Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.GroupBox2.ForeColor = Color.DimGray
			Me.GroupBox2.Location = New Point(22, 33)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New System.Drawing.Size(376, 63)
			Me.GroupBox2.TabIndex = 198
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Tipo de búsqueda"
            Me._RadioButton1.AutoSize = True
            Me._RadioButton1.Location = New Point(206, 37)
            Me._RadioButton1.Name = "RadioButton1"
            Me._RadioButton1.Size = New System.Drawing.Size(147, 20)
            Me._RadioButton1.TabIndex = 165
            Me._RadioButton1.TabStop = True
            Me._RadioButton1.Text = "Búsqueda por nombre"
            Me._RadioButton1.UseVisualStyleBackColor = True
            Me.Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Color.Black
			Me.Label3.Location = New Point(371, 0)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New System.Drawing.Size(524, 41)
			Me.Label3.TabIndex = 196
			Me.Label3.Text = "BÚSQUEDA FICHA DE ALUMNO"
            Me._DataGridView1.AllowUserToAddRows = False
            Me._DataGridView1.AllowUserToDeleteRows = False
            Me._DataGridView1.AllowUserToResizeRows = False
            Me._DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Me._DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me._DataGridView1.BackgroundColor = SystemColors.ControlLightLight
            Me._DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me._DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            Me._DataGridView1.Location = New Point(23, 174)
            Me._DataGridView1.Margin = New System.Windows.Forms.Padding(4)
            Me._DataGridView1.MultiSelect = False
            Me._DataGridView1.Name = "DataGridView1"
            Me._DataGridView1.RowHeadersVisible = False
            Me._DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me._DataGridView1.Size = New System.Drawing.Size(1180, 454)
            Me._DataGridView1.TabIndex = 195
            Me.Panel1.BackColor = Color.White
			Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me._Button5)
            Me.Panel1.Location = New Point(492, 96)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New System.Drawing.Size(403, 57)
			Me.Panel1.TabIndex = 197
			Me.Panel1.Visible = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Color.DimGray
			Me.Label4.Location = New Point(4, 3)
			Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New System.Drawing.Size(377, 21)
			Me.Label4.TabIndex = 15
			Me.Label4.Text = "¿Deseas ver la ficha de matricula este alumno?"
            Me._Button5.BackColor = Color.RoyalBlue
            Me._Button5.FlatAppearance.BorderSize = 0
            Me._Button5.FlatStyle = FlatStyle.Flat
            Me._Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me._Button5.ForeColor = Color.White
            Me._Button5.Location = New Point(110, 25)
            Me._Button5.Name = "Button5"
            Me._Button5.Size = New System.Drawing.Size(186, 30)
            Me._Button5.TabIndex = 20
            Me._Button5.Text = "Ver"
            Me._Button5.UseVisualStyleBackColor = False
            Me._PictureBox1.Image = Resources.close_x
            Me._PictureBox1.Location = New Point(1195, 0)
            Me._PictureBox1.Name = "PictureBox1"
            Me._PictureBox1.Size = New System.Drawing.Size(57, 51)
            Me._PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Me._PictureBox1.TabIndex = 194
            Me._PictureBox1.TabStop = False
            MyBase.AutoScaleDimensions = New SizeF(6!, 13!)
			MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.White
			MyBase.ClientSize = New System.Drawing.Size(1273, 641)
			MyBase.Controls.Add(Me.Panel4)
			MyBase.Controls.Add(Me.Panel3)
			MyBase.Controls.Add(Me.Panel2)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me._DataGridView1)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me._PictureBox1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "buscar_ficha"
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Buscar ficha"
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
            DirectCast(Me._Textbuscar.Properties, ISupportInitialize).EndInit()
            DirectCast(Me._TextEdit2.Properties, ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
            DirectCast(Me._TextEdit1.Properties, ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
            DirectCast(Me._DataGridView1, ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
            DirectCast(Me._PictureBox1, ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		Public Sub Limpiar()
			Me.Panel1.Visible = False
			Me.Panel2.Visible = False
			Me.Panel3.Visible = False
			Me.Panel4.Visible = False
            Me._RadioButton1.Checked = False
            Me._RadioButton2.Checked = False
            Me._RadioButton3.Checked = False
            Me._DataGridView1.DataSource = Nothing
        End Sub

		Private Sub Listado_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			buscar_ficha.Releasecapture()
			buscar_ficha.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.Close()
		End Sub

		Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me._RadioButton1.Checked) Then
                Me.Panel4.Visible = False
                Me.Label1.Visible = False
                Me.GroupBox1.Visible = False
                Me.Label2.Visible = False
            Else
                Me.Panel2.Visible = False
				Me.Panel3.Visible = False
				Me.Panel4.Visible = True
				Me.Label1.Visible = True
				Me.GroupBox1.Visible = True
				Me.Label2.Visible = True
			End If
		End Sub

		Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me._RadioButton2.Checked) Then
                Me.Label5.Visible = False
                Me.GroupBox3.Visible = False
                Me.Label6.Visible = False
                Me.Panel2.Visible = False
            Else
                Me.Panel3.Visible = False
				Me.Panel4.Visible = False
				Me.Panel2.Visible = True
				Me.Label5.Visible = True
				Me.GroupBox3.Visible = True
				Me.Label6.Visible = True
			End If
		End Sub

		Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me._RadioButton3.Checked) Then
                Me.Label7.Visible = False
                Me.GroupBox4.Visible = False
                Me.Label8.Visible = False
                Me.Panel3.Visible = False
            Else
                Me.Panel2.Visible = False
				Me.Panel4.Visible = False
				Me.Panel3.Visible = True
				Me.Label7.Visible = True
				Me.GroupBox4.Visible = True
				Me.Label8.Visible = True
			End If
		End Sub

		<DllImport("user32.dll", CharSet:=CharSet.None, EntryPoint:="ReleaseCapture", ExactSpelling:=False)>
		Private Shared Sub Releasecapture()
		End Sub

		<DllImport("user32.dll", CharSet:=CharSet.None, ExactSpelling:=False)>
		Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lparam As Integer)
		End Sub

		Private Sub Textbuscar_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._Textbuscar.Text, "Búsqueda por nombre", False) = 0) Then
                Me._Textbuscar.Text = ""
                Me._Button7.Visible = True
                Me.Label1.Visible = True
                Me.Label2.Visible = True
            End If
        End Sub

		Private Sub Textbuscar_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If (e.KeyData = Keys.[Return]) Then
				conexionmysql.Abrir_MYBD()
				Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where nombre like '%", Me._Textbuscar.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
					Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
					If (dataTable.Rows.Count <= 0) Then
						MessageBox.Show("No hay descripcion para este ID")
                        Me._DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
						modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Año anterior', lugar_anterior as 'Lugar anterior'  "
						modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me._DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where nombre Like  '%", Me._Textbuscar.Text, "%'")
                        modulo_funciones_sql.carga_data()
					End If
				Catch exception As System.Exception
					ProjectData.SetProjectError(exception)
					Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
					ProjectData.ClearProjectError()
				End Try
				conexionmysql.Cerrar_MYBD()
			End If
		End Sub

		Private Sub Textbuscar_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._Textbuscar.Text, "", False) = 0) Then
                Me._Textbuscar.Text = "Búsqueda por nombre"
                Me._Button7.Visible = False
                Me.Label1.Visible = False
                Me.Label2.Visible = False
            End If
        End Sub

		Private Sub TextEdit1_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._TextEdit1.Text, "Búsqueda por ID", False) = 0) Then
                Me._TextEdit1.Text = ""
                Me._Button9.Visible = True
                Me.Label5.Visible = True
                Me.Label6.Visible = True
            End If
        End Sub

		Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If (e.KeyData = Keys.[Return]) Then
				conexionmysql.Abrir_MYBD()
				Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where identidad_alumno like '%", Me._TextEdit1.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
					Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
					If (dataTable.Rows.Count <= 0) Then
						MessageBox.Show("No hay descripcion para este ID")
                        Me._DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
						modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Año anterior', lugar_anterior as 'Lugar anterior'  "
						modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me._DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where identidad_alumno Like  '%", Me._TextEdit1.Text, "%'")
                        modulo_funciones_sql.carga_data()
					End If
				Catch exception As System.Exception
					ProjectData.SetProjectError(exception)
					Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
					ProjectData.ClearProjectError()
				End Try
				conexionmysql.Cerrar_MYBD()
			End If
		End Sub

		Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			e.Handled = Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If (Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
				Interaction.MsgBox("Solo Puede digitar numeros", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub TextEdit1_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._TextEdit1.Text, "", False) = 0) Then
                Me._TextEdit1.Text = "Búsqueda por ID"
                Me._Button9.Visible = False
                Me.Label5.Visible = False
                Me.Label6.Visible = False
            End If
        End Sub

		Private Sub TextEdit2_Enter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._TextEdit2.Text, "Búsqueda por codigo", False) = 0) Then
                Me._TextEdit2.Text = ""
                Me._Button11.Visible = True
                Me.Label7.Visible = True
                Me.Label8.Visible = True
            End If
        End Sub

		Private Sub TextEdit2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If (e.KeyData = Keys.[Return]) Then
				conexionmysql.Abrir_MYBD()
				Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where codigo like '%", Me._TextEdit2.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
					Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
					If (dataTable.Rows.Count <= 0) Then
						MessageBox.Show("No hay descripcion para este ID")
                        Me._DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
						modulo_funciones_sql.columna1w = "id_matricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidad_alumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugar_trabajo as 'Lugar de trabajo', nombre_padre as 'Nombre del padre', lugar_trabajo_padre as 'Lugar de trabajo del padre', telefono_padre as 'Telefono del padre', nombre_madre as 'Nombre de la madre', lugar_trabajo_madre as 'Lugar de trabajo de la madre', telefono_madre as 'Telefono madre', fecha_nac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefono_emergencia as 'Telefono de emergencia', depto_nac as 'Departamento de nacimiento', municipio_nac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegio_anterior as 'Colegio anterior',curso_anterior as 'Curso anterior', modalidad_anterior as 'Modalidad anterior', anio_anterior as 'Año anterior', lugar_anterior as 'Lugar anterior'  "
						modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me._DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where codigo Like  '%", Me._TextEdit2.Text, "%'")
                        modulo_funciones_sql.carga_data()
					End If
				Catch exception As System.Exception
					ProjectData.SetProjectError(exception)
					Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
					ProjectData.ClearProjectError()
				End Try
				conexionmysql.Cerrar_MYBD()
			End If
		End Sub

		Private Sub TextEdit2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			e.Handled = Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
			If (Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
				Interaction.MsgBox("Solo Puede digitar numeros", MsgBoxStyle.OkOnly, Nothing)
			End If
		End Sub

		Private Sub TextEdit2_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me._TextEdit2.Text, "", False) = 0) Then
                Me._TextEdit2.Text = "Búsqueda por codigo"
                Me._Button11.Visible = False
                Me.Label7.Visible = False
                Me.Label8.Visible = False
            End If
        End Sub
	End Class
End Namespace