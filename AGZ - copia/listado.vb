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
	Public Class listado
		Inherits Form
		Private components As IContainer

		Friend Overridable Property Button10 As Button
			Get
                Dim stackVariable1 = Me.Button10
                Return stackVariable1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button10Click)
                Dim button As System.Windows.Forms.Button = Me.Button10
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button10 = value
                button = Me.Button10
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button11 As Button
            Get
                Dim stackVariable1 = Me.Button11
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button11Click)
                Dim button As System.Windows.Forms.Button = Me.Button11
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button11 = value
                button = Me.Button11
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button12 As Button
            Get
                Dim stackVariable1 = Me.Button12
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button12Click)
                Dim button As System.Windows.Forms.Button = Me.Button12
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button12 = value
                button = Me.Button12
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button5 As Button
            Get
                Dim stackVariable1 = Me.Button5
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button5Click)
                Dim button As System.Windows.Forms.Button = Me.Button5
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button5 = value
                button = Me.Button5
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button7 As Button
            Get
                Dim stackVariable1 = Me.Button7
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button7Click)
                Dim button As System.Windows.Forms.Button = Me.Button7
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button7 = value
                button = Me.Button7
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button8 As Button
            Get
                Dim stackVariable1 = Me.Button8
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button8Click)
                Dim button As System.Windows.Forms.Button = Me.Button8
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button8 = value
                button = Me.Button8
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Button9 As Button
            Get
                Dim stackVariable1 = Me.Button9
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.Button)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.Button9Click)
                Dim button As System.Windows.Forms.Button = Me.Button9
                If (button IsNot Nothing) Then
                    RemoveHandler button.Click, eventHandler
                End If
                Me.Button9 = value
                button = Me.Button9
                If (button IsNot Nothing) Then
                    AddHandler button.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property DataGridView1 As DataGridView
            Get
                Dim stackVariable1 = Me.DataGridView1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.DataGridView)
                Dim dataGridViewColumnEventHandler As System.Windows.Forms.DataGridViewColumnEventHandler = New System.Windows.Forms.DataGridViewColumnEventHandler(AddressOf Me.DataGridView1ColumnAdded)
                Dim dataGridViewCellEventHandler As System.Windows.Forms.DataGridViewCellEventHandler = New System.Windows.Forms.DataGridViewCellEventHandler(AddressOf Me.DataGridView1CellClick)
                Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
                If (dataGridView IsNot Nothing) Then
                    RemoveHandler dataGridView.ColumnAdded, dataGridViewColumnEventHandler
                    RemoveHandler dataGridView.CellClick, dataGridViewCellEventHandler
                End If
                Me.DataGridView1 = value
                dataGridView = Me.DataGridView1
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

        Friend Overridable Property PictureBox1 As PictureBox
            Get
                Dim stackVariable1 = Me.PictureBox1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.PictureBox)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.PictureBox1Click)
                Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
                If (pictureBox IsNot Nothing) Then
                    RemoveHandler pictureBox.Click, eventHandler
                End If
                Me.PictureBox1 = value
                pictureBox = Me.PictureBox1
                If (pictureBox IsNot Nothing) Then
                    AddHandler pictureBox.Click, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property RadioButton1 As RadioButton
            Get
                Dim stackVariable1 = Me.RadioButton1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton1CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me.RadioButton1
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me.RadioButton1 = value
                radioButton = Me.RadioButton1
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property RadioButton2 As RadioButton
            Get
                Dim stackVariable1 = Me.RadioButton2
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton2CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me.RadioButton2
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me.RadioButton2 = value
                radioButton = Me.RadioButton2
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property RadioButton3 As RadioButton
            Get
                Dim stackVariable1 = Me.RadioButton3
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As System.Windows.Forms.RadioButton)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.RadioButton3CheckedChanged)
                Dim radioButton As System.Windows.Forms.RadioButton = Me.RadioButton3
                If (radioButton IsNot Nothing) Then
                    RemoveHandler radioButton.CheckedChanged, eventHandler
                End If
                Me.RadioButton3 = value
                radioButton = Me.RadioButton3
                If (radioButton IsNot Nothing) Then
                    AddHandler radioButton.CheckedChanged, eventHandler
                End If
            End Set
        End Property

        Friend Overridable Property Textbuscar As TextEdit
            Get
                Dim stackVariable1 = Me.Textbuscar
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.TextbuscarEnter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.TextbuscarLeave)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextbuscarKeyDown)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me.Textbuscar
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                End If
                Me.Textbuscar = value
                textEdit = Me.Textbuscar
                If (textEdit IsNot Nothing) Then
                    AddHandler textEdit.Enter, eventHandler
                    AddHandler textEdit.Leave, eventHandler1
                    AddHandler textEdit.KeyDown, keyEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property TextEdit1 As TextEdit
            Get
                Dim stackVariable1 = Me.TextEdit1
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit1Enter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit1Leave)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextEdit1KeyDown)
                Dim keyPressEventHandler As System.Windows.Forms.KeyPressEventHandler = New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.TextEdit1KeyPress)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me.TextEdit1
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                    RemoveHandler textEdit.KeyPress, keyPressEventHandler
                End If
                Me.TextEdit1 = value
                textEdit = Me.TextEdit1
                If (textEdit IsNot Nothing) Then
                    AddHandler textEdit.Enter, eventHandler
                    AddHandler textEdit.Leave, eventHandler1
                    AddHandler textEdit.KeyDown, keyEventHandler
                    AddHandler textEdit.KeyPress, keyPressEventHandler
                End If
            End Set
        End Property

        Friend Overridable Property TextEdit2 As TextEdit
            Get
                Dim stackVariable1 = Me.TextEdit2
                Return stackVariable1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            Set(ByVal value As DevExpress.XtraEditors.TextEdit)
                Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit2Enter)
                Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf Me.TextEdit2Leave)
                Dim keyPressEventHandler As System.Windows.Forms.KeyPressEventHandler = New System.Windows.Forms.KeyPressEventHandler(AddressOf Me.TextEdit2KeyPress)
                Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf Me.TextEdit2KeyDown)
                Dim textEdit As DevExpress.XtraEditors.TextEdit = Me.TextEdit2
                If (textEdit IsNot Nothing) Then
                    RemoveHandler textEdit.Enter, eventHandler
                    RemoveHandler textEdit.Leave, eventHandler1
                    RemoveHandler textEdit.KeyPress, keyPressEventHandler
                    RemoveHandler textEdit.KeyDown, keyEventHandler
                End If
                Me.TextEdit2 = value
                textEdit = Me.TextEdit2
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
            AddHandler MyBase.MouseMove, New MouseEventHandler(AddressOf Me.ListadoMouseMove)
            AddHandler MyBase.FormClosing, New FormClosingEventHandler(AddressOf Me.ListadoFormClosing)
            AddHandler MyBase.Activated, New EventHandler(AddressOf Me.listadoActivated)
            Me.InitializeComponent()
        End Sub

        Private Sub Button10Click(ByVal sender As Object, ByVal e As EventArgs)
            conexionmysql.Abrir_MYBD()
            Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where identidadalumno like '%", Me.TextEdit1.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                If (dataTable.Rows.Count <= 0) Then
                    MessageBox.Show("No hay descripcion para este ID")
                    Me.DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                    modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Año anterior', lugaranterior as 'Lugar anterior'  "
                    modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me.DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where identidadalumno Like  '%", Me.TextEdit1.Text, "%'")
                    modulo_funciones_sql.carga_data()
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
                ProjectData.ClearProjectError()
            End Try
            conexionmysql.Cerrar_MYBD()
        End Sub

        Private Sub Button11Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.TextEdit2.Text = ""
        End Sub

        Private Sub Button12Click(ByVal sender As Object, ByVal e As EventArgs)
            conexionmysql.Abrir_MYBD()
            Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where codigo like '%", Me.TextEdit2.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                If (dataTable.Rows.Count <= 0) Then
                    MessageBox.Show("No hay descripcion para este ID")
                    Me.DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                    modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Anio anterior', lugaranterior as 'Lugar anterior'"
                    modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me.DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where codigo Like  '%", Me.TextEdit2.Text, "%'")
                    modulo_funciones_sql.carga_data()
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
                ProjectData.ClearProjectError()
            End Try
            conexionmysql.Cerrar_MYBD()
        End Sub

        Private Sub Button5Click(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.Hide()
            MyProject.Forms.Registro.Show()
        End Sub

        Private Sub Button7Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Textbuscar.Text = ""
        End Sub

        Private Sub Button8Click(ByVal sender As Object, ByVal e As EventArgs)
            conexionmysql.Abrir_MYBD()
            Try
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where nombre like '%", Me.Textbuscar.Text, "%'"), conexionmysql.myconn)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                If (dataTable.Rows.Count <= 0) Then
                    MessageBox.Show("No hay descripcion para este ID")
                    Me.DataGridView1.DataSource = Nothing
                ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                    modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Año anterior', lugaranterior as 'Lugar anterior'  "
                    modulo_funciones_sql.tabla1w = "matricula2"
                    modulo_funciones_sql.data1w = Me.DataGridView1
                    modulo_funciones_sql.where = String.Concat(" where nombre Like  '%", Me.Textbuscar.Text, "%'")
                    modulo_funciones_sql.carga_data()
                End If
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registros")
                ProjectData.ClearProjectError()
            End Try
            conexionmysql.Cerrar_MYBD()
        End Sub

        Private Sub Button9Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.TextEdit1.Text = ""
        End Sub

        Private Sub DataGridView1CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
            Try
                Try
                    Dim currentRow As DataGridViewRow = Me.DataGridView1.CurrentRow
                    modulo_variables_globales.valor_del_cellclick = Conversions.ToInteger(currentRow.Cells(0).Value)
                    MyProject.Forms.Registro.TextBox2.Text = Conversions.ToString(currentRow.Cells(1).Value)
                    MyProject.Forms.Registro.TextBox6.Text = Conversions.ToString(currentRow.Cells(6).Value)
                    MyProject.Forms.Registro.TextBox3.Text = Conversions.ToString(currentRow.Cells(2).Value)
                    MyProject.Forms.Registro.TextBox7.Text = Conversions.ToString(currentRow.Cells(3).Value)
                    MyProject.Forms.Registro.TextBox4.Text = Conversions.ToString(currentRow.Cells(5).Value)
                    If (Not (Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(8).Value)) Or Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow.Cells(8).Value), "", False) = 0)) Then
                        MyProject.Forms.Registro.TextBox8.Text = Conversions.ToString(currentRow.Cells(8).Value)
                    Else
                        MyProject.Forms.Registro.TextBox8.Text = "Correo electronico (opcional)"
                    End If
                    MyProject.Forms.Registro.TextBox9.Text = Conversions.ToString(currentRow.Cells(7).Value)
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(9).Value))) Then
                        MyProject.Forms.Registro.TextBox13.Text = Conversions.ToString(currentRow.Cells(9).Value)
                    Else
                        MyProject.Forms.Registro.TextBox13.Text = "Altos de San José, Instituto Alfonso Guillén Zelaya, Tegucigalpa Honduras 11101"
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(4).Value))) Then
                        MyProject.Forms.Registro.ComboBox1.Text = Conversions.ToString(currentRow.Cells(4).Value)
                    Else
                        MyProject.Forms.Registro.ComboBox1.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(10).Value))) Then
                        MyProject.Forms.Registro.TextBox5.Text = Conversions.ToString(currentRow.Cells(10).Value)
                    Else
                        MyProject.Forms.Registro.TextBox5.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(11).Value))) Then
                        MyProject.Forms.Registro.TextBox10.Text = Conversions.ToString(currentRow.Cells(11).Value)
                    Else
                        MyProject.Forms.Registro.TextBox10.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(12).Value))) Then
                        MyProject.Forms.Registro.TextBox11.Text = Conversions.ToString(currentRow.Cells(12).Value)
                    Else
                        MyProject.Forms.Registro.TextBox11.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(13).Value))) Then
                        MyProject.Forms.Registro.TextBox15.Text = Conversions.ToString(currentRow.Cells(13).Value)
                    Else
                        MyProject.Forms.Registro.TextBox15.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(14).Value))) Then
                        MyProject.Forms.Registro.TextBox14.Text = Conversions.ToString(currentRow.Cells(14).Value)
                    Else
                        MyProject.Forms.Registro.TextBox14.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(15).Value))) Then
                        MyProject.Forms.Registro.TextBox12.Text = Conversions.ToString(currentRow.Cells(15).Value)
                    Else
                        MyProject.Forms.Registro.TextBox12.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(16).Value))) Then
                        MyProject.Forms.Registro.TextBox16.Text = Conversions.ToString(currentRow.Cells(16).Value)
                    Else
                        MyProject.Forms.Registro.TextBox16.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(22).Value))) Then
                        MyProject.Forms.Registro.TextBox20.Text = Conversions.ToString(currentRow.Cells(22).Value)
                    Else
                        MyProject.Forms.Registro.TextBox20.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(23).Value))) Then
                        MyProject.Forms.Registro.TextBox21.Text = Conversions.ToString(currentRow.Cells(23).Value)
                    Else
                        MyProject.Forms.Registro.TextBox21.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(20).Value))) Then
                        MyProject.Forms.Registro.TextBox17.Text = Conversions.ToString(currentRow.Cells(20).Value)
                    Else
                        MyProject.Forms.Registro.TextBox17.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(21).Value))) Then
                        MyProject.Forms.Registro.TextBox18.Text = Conversions.ToString(currentRow.Cells(21).Value)
                    Else
                        MyProject.Forms.Registro.TextBox18.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(17).Value))) Then
                        MyProject.Forms.Registro.DateEdit1.EditValue = Conversions.ToDate(currentRow.Cells(17).Value)
                    Else
                        MyProject.Forms.Registro.DateEdit1.EditValue = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(19).Value))) Then
                        MyProject.Forms.Registro.TextBox19.Text = Conversions.ToString(currentRow.Cells(19).Value)
                    Else
                        MyProject.Forms.Registro.TextBox19.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(26).Value))) Then
                        MyProject.Forms.Registro.TextBox22.Text = Conversions.ToString(currentRow.Cells(26).Value)
                    Else
                        MyProject.Forms.Registro.TextBox22.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(27).Value))) Then
                        MyProject.Forms.Registro.ComboBox2.Text = Conversions.ToString(currentRow.Cells(27).Value)
                    Else
                        MyProject.Forms.Registro.ComboBox2.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(29).Value))) Then
                        MyProject.Forms.Registro.TextBox24.Text = Conversions.ToString(currentRow.Cells(29).Value)
                    Else
                        MyProject.Forms.Registro.TextBox24.Text = ""
                    End If
                    If (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(30).Value))) Then
                        MyProject.Forms.Registro.TextBox25.Text = Conversions.ToString(currentRow.Cells(30).Value)
                    Else
                        MyProject.Forms.Registro.TextBox25.Text = ""
                    End If
                    If (Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(18).Value))) Then
                        MyProject.Forms.Registro.RadioButton1.Checked = False
                        MyProject.Forms.Registro.RadioButton2.Checked = False
                    ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow.Cells(18).Value), "Masculino", False) <> 0) Then
                        MyProject.Forms.Registro.RadioButton2.Checked = True
                    Else
                        MyProject.Forms.Registro.RadioButton1.Checked = True
                    End If
                    If (Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(24).Value))) Then
                        MyProject.Forms.Registro.RadioButton3.Checked = False
                        MyProject.Forms.Registro.RadioButton4.Checked = False
                    ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow.Cells(24).Value), "Si", False) <> 0) Then
                        MyProject.Forms.Registro.RadioButton3.Checked = True
                    Else
                        MyProject.Forms.Registro.RadioButton4.Checked = True
                    End If
                    If (Information.IsDBNull(RuntimeHelpers.GetObjectValue(currentRow.Cells(25).Value))) Then
                        MyProject.Forms.Registro.RadioButton5.Checked = False
                        MyProject.Forms.Registro.RadioButton6.Checked = False
                    ElseIf (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(currentRow.Cells(25).Value), "Si", False) <> 0) Then
                        MyProject.Forms.Registro.RadioButton5.Checked = True
                    Else
                        MyProject.Forms.Registro.RadioButton6.Checked = True
                    End If
                    MyProject.Forms.Registro.SimpleButton1.Visible = False
                    MyProject.Forms.Registro.SimpleButton2.Visible = False
                    MyProject.Forms.Registro.SimpleButton3.Visible = True
                    Me.Panel1.Visible = True
                Catch exception As System.Exception
                    ProjectData.SetProjectError(exception)
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
                    ProjectData.ClearProjectError()
                End Try
            Finally
                conexionmysql.Cerrar_MYBD()
            End Try
        End Sub

        Private Sub DataGridView1ColumnAdded(ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado))
            Me.PictureBox1 = New PictureBox()
            Me.Button5 = New Button()
            Me.Label4 = New Label()
            Me.Panel1 = New Panel()
            Me.DataGridView1 = New DataGridView()
            Me.Label2 = New Label()
            Me.Label3 = New Label()
            Me.Button8 = New Button()
            Me.Textbuscar = New TextEdit()
            Me.Button7 = New Button()
            Me.GroupBox1 = New GroupBox()
            Me.Label1 = New Label()
            Me.RadioButton1 = New RadioButton()
            Me.GroupBox2 = New GroupBox()
            Me.RadioButton3 = New RadioButton()
            Me.RadioButton2 = New RadioButton()
            Me.Label5 = New Label()
            Me.GroupBox3 = New GroupBox()
            Me.Button9 = New Button()
            Me.TextEdit1 = New TextEdit()
            Me.Button10 = New Button()
            Me.Label6 = New Label()
            Me.Panel2 = New Panel()
            Me.Panel3 = New Panel()
            Me.Label7 = New Label()
            Me.GroupBox4 = New GroupBox()
            Me.TextEdit2 = New TextEdit()
            Me.Button11 = New Button()
            Me.Button12 = New Button()
            Me.Label8 = New Label()
            Me.Panel4 = New Panel()
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            DirectCast(Me.DataGridView1, ISupportInitialize).BeginInit()
            DirectCast(Me.Textbuscar.Properties, ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            DirectCast(Me.TextEdit1.Properties, ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            DirectCast(Me.TextEdit2.Properties, ISupportInitialize).BeginInit()
            Me.Panel4.SuspendLayout()
            MyBase.SuspendLayout()
            Me.PictureBox1.Image = Resources.close
            Me.PictureBox1.Location = New Point(1223, 2)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(57, 51)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 158
            Me.PictureBox1.TabStop = False
            Me.Button5.BackColor = Color.RoyalBlue
            Me.Button5.FlatAppearance.BorderSize = 0
            Me.Button5.FlatStyle = FlatStyle.Flat
            Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.Button5.ForeColor = Color.White
            Me.Button5.Location = New Point(28, 24)
            Me.Button5.Name = "Button5"
            Me.Button5.Size = New System.Drawing.Size(186, 30)
            Me.Button5.TabIndex = 20
            Me.Button5.Text = "Editar"
            Me.Button5.UseVisualStyleBackColor = False
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = Color.DimGray
            Me.Label4.Location = New Point(4, 3)
            Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(234, 21)
            Me.Label4.TabIndex = 15
            Me.Label4.Text = "¿Deseas editar este alumno?"
            Me.Panel1.BackColor = Color.White
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Button5)
            Me.Panel1.Location = New Point(520, 98)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(243, 57)
            Me.Panel1.TabIndex = 163
            Me.Panel1.Visible = False
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AllowUserToResizeRows = False
            Me.DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.DataGridView1.BackgroundColor = SystemColors.ControlLightLight
            Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
            Me.DataGridView1.Location = New Point(51, 176)
            Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.DataGridView1.Size = New System.Drawing.Size(1180, 395)
            Me.DataGridView1.TabIndex = 159
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
            Me.Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = Color.Black
            Me.Label3.Location = New Point(432, 1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(410, 41)
            Me.Label3.TabIndex = 162
            Me.Label3.Text = "BÚSQUEDA DE ALUMNO"
            Me.Button8.BackColor = Color.Transparent
            Me.Button8.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button8.BackgroundImage"), Image)
            Me.Button8.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button8.FlatAppearance.BorderColor = Color.White
            Me.Button8.FlatAppearance.BorderSize = 0
            Me.Button8.FlatStyle = FlatStyle.Flat
            Me.Button8.Location = New Point(349, 12)
            Me.Button8.Name = "Button8"
            Me.Button8.Size = New System.Drawing.Size(24, 22)
            Me.Button8.TabIndex = 187
            Me.Button8.UseVisualStyleBackColor = False
            Me.Textbuscar.EditValue = "Búsqueda por nombre"
            Me.Textbuscar.Location = New Point(3, 12)
            Me.Textbuscar.Margin = New System.Windows.Forms.Padding(4)
            Me.Textbuscar.Name = "Textbuscar"
            Me.Textbuscar.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.Textbuscar.Properties.Appearance.ForeColor = Color.DimGray
            Me.Textbuscar.Properties.Appearance.Options.UseFont = True
            Me.Textbuscar.Properties.Appearance.Options.UseForeColor = True
            Me.Textbuscar.Properties.BorderStyle = BorderStyles.NoBorder
            Me.Textbuscar.Size = New System.Drawing.Size(324, 22)
            Me.Textbuscar.TabIndex = 13
            Me.Textbuscar.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me.Textbuscar.ToolTipIconType = ToolTipIconType.Information
            Me.Button7.BackColor = Color.Transparent
            Me.Button7.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button7.BackgroundImage"), Image)
            Me.Button7.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button7.FlatAppearance.BorderColor = Color.White
            Me.Button7.FlatAppearance.BorderSize = 0
            Me.Button7.FlatStyle = FlatStyle.Flat
            Me.Button7.Location = New Point(326, 11)
            Me.Button7.Name = "Button7"
            Me.Button7.Size = New System.Drawing.Size(24, 23)
            Me.Button7.TabIndex = 188
            Me.Button7.UseVisualStyleBackColor = False
            Me.Button7.Visible = False
            Me.GroupBox1.Controls.Add(Me.Button7)
            Me.GroupBox1.Controls.Add(Me.Textbuscar)
            Me.GroupBox1.Controls.Add(Me.Button8)
            Me.GroupBox1.Location = New Point(3, 16)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(379, 38)
            Me.GroupBox1.TabIndex = 164
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = Color.Black
            Me.Label1.Location = New Point(7, 7)
            Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(111, 13)
            Me.Label1.TabIndex = 160
            Me.Label1.Text = "Búsqueda por nombre"
            Me.Label1.Visible = False
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.Location = New Point(206, 37)
            Me.RadioButton1.Name = "RadioButton1"
            Me.RadioButton1.Size = New System.Drawing.Size(147, 20)
            Me.RadioButton1.TabIndex = 165
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Búsqueda por nombre"
            Me.RadioButton1.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.RadioButton3)
            Me.GroupBox2.Controls.Add(Me.RadioButton2)
            Me.GroupBox2.Controls.Add(Me.RadioButton1)
            Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.GroupBox2.ForeColor = Color.DimGray
            Me.GroupBox2.Location = New Point(50, 35)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(376, 63)
            Me.GroupBox2.TabIndex = 166
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Tipo de búsqueda"
            Me.RadioButton3.AutoSize = True
            Me.RadioButton3.Location = New Point(19, 17)
            Me.RadioButton3.Name = "RadioButton3"
            Me.RadioButton3.Size = New System.Drawing.Size(143, 20)
            Me.RadioButton3.TabIndex = 167
            Me.RadioButton3.TabStop = True
            Me.RadioButton3.Text = "Busqueda por codigo"
            Me.RadioButton3.UseVisualStyleBackColor = True
            Me.RadioButton2.AutoSize = True
            Me.RadioButton2.Location = New Point(206, 15)
            Me.RadioButton2.Name = "RadioButton2"
            Me.RadioButton2.Size = New System.Drawing.Size(159, 20)
            Me.RadioButton2.TabIndex = 166
            Me.RadioButton2.TabStop = True
            Me.RadioButton2.Text = "Busqueda por identidad"
            Me.RadioButton2.UseVisualStyleBackColor = True
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = Color.Black
            Me.Label5.Location = New Point(7, 9)
            Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(87, 13)
            Me.Label5.TabIndex = 189
            Me.Label5.Text = "Búsqueda por ID"
            Me.Label5.Visible = False
            Me.GroupBox3.Controls.Add(Me.Button9)
            Me.GroupBox3.Controls.Add(Me.TextEdit1)
            Me.GroupBox3.Controls.Add(Me.Button10)
            Me.GroupBox3.Location = New Point(3, 18)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(379, 38)
            Me.GroupBox3.TabIndex = 191
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Visible = False
            Me.Button9.BackColor = Color.Transparent
            Me.Button9.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button9.BackgroundImage"), Image)
            Me.Button9.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button9.FlatAppearance.BorderColor = Color.White
            Me.Button9.FlatAppearance.BorderSize = 0
            Me.Button9.FlatStyle = FlatStyle.Flat
            Me.Button9.Location = New Point(326, 11)
            Me.Button9.Name = "Button9"
            Me.Button9.Size = New System.Drawing.Size(24, 23)
            Me.Button9.TabIndex = 188
            Me.Button9.UseVisualStyleBackColor = False
            Me.Button9.Visible = False
            Me.TextEdit1.EditValue = "Búsqueda por ID"
            Me.TextEdit1.Location = New Point(3, 12)
            Me.TextEdit1.Margin = New System.Windows.Forms.Padding(4)
            Me.TextEdit1.Name = "TextEdit1"
            Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.TextEdit1.Properties.Appearance.ForeColor = Color.DimGray
            Me.TextEdit1.Properties.Appearance.Options.UseFont = True
            Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
            Me.TextEdit1.Properties.BorderStyle = BorderStyles.NoBorder
            Me.TextEdit1.Size = New System.Drawing.Size(324, 22)
            Me.TextEdit1.TabIndex = 13
            Me.TextEdit1.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me.TextEdit1.ToolTipIconType = ToolTipIconType.Information
            Me.Button10.BackColor = Color.Transparent
            Me.Button10.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button10.BackgroundImage"), Image)
            Me.Button10.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button10.FlatAppearance.BorderColor = Color.White
            Me.Button10.FlatAppearance.BorderSize = 0
            Me.Button10.FlatStyle = FlatStyle.Flat
            Me.Button10.Location = New Point(349, 12)
            Me.Button10.Name = "Button10"
            Me.Button10.Size = New System.Drawing.Size(24, 22)
            Me.Button10.TabIndex = 187
            Me.Button10.UseVisualStyleBackColor = False
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
            Me.Panel2.Controls.Add(Me.Label5)
            Me.Panel2.Controls.Add(Me.GroupBox3)
            Me.Panel2.Controls.Add(Me.Label6)
            Me.Panel2.Location = New Point(48, 101)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(385, 72)
            Me.Panel2.TabIndex = 192
            Me.Panel2.Visible = False
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.GroupBox4)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Location = New Point(51, 101)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(385, 72)
            Me.Panel3.TabIndex = 193
            Me.Panel3.Visible = False
            Me.Label7.AutoSize = True
            Me.Label7.ForeColor = Color.Black
            Me.Label7.Location = New Point(7, 9)
            Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(108, 13)
            Me.Label7.TabIndex = 189
            Me.Label7.Text = "Búsqueda por codigo"
            Me.Label7.Visible = False
            Me.GroupBox4.Controls.Add(Me.TextEdit2)
            Me.GroupBox4.Controls.Add(Me.Button11)
            Me.GroupBox4.Controls.Add(Me.Button12)
            Me.GroupBox4.Location = New Point(3, 18)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(379, 38)
            Me.GroupBox4.TabIndex = 191
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Visible = False
            Me.TextEdit2.EditValue = "Búsqueda por codigo"
            Me.TextEdit2.Location = New Point(3, 12)
            Me.TextEdit2.Margin = New System.Windows.Forms.Padding(4)
            Me.TextEdit2.Name = "TextEdit2"
            Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.TextEdit2.Properties.Appearance.ForeColor = Color.DimGray
            Me.TextEdit2.Properties.Appearance.Options.UseFont = True
            Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
            Me.TextEdit2.Properties.BorderStyle = BorderStyles.NoBorder
            Me.TextEdit2.Size = New System.Drawing.Size(324, 22)
            Me.TextEdit2.TabIndex = 13
            Me.TextEdit2.ToolTip = "Presione la tecla ""Enter"" para realizar una búsqueda"
            Me.TextEdit2.ToolTipIconType = ToolTipIconType.Information
            Me.Button11.BackColor = Color.Transparent
            Me.Button11.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button11.BackgroundImage"), Image)
            Me.Button11.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button11.FlatAppearance.BorderColor = Color.White
            Me.Button11.FlatAppearance.BorderSize = 0
            Me.Button11.FlatStyle = FlatStyle.Flat
            Me.Button11.Location = New Point(326, 11)
            Me.Button11.Name = "Button11"
            Me.Button11.Size = New System.Drawing.Size(24, 23)
            Me.Button11.TabIndex = 188
            Me.Button11.UseVisualStyleBackColor = False
            Me.Button11.Visible = False
            Me.Button12.BackColor = Color.Transparent
            Me.Button12.BackgroundImage = DirectCast(componentResourceManager.GetObject("Button12.BackgroundImage"), Image)
            Me.Button12.BackgroundImageLayout = ImageLayout.Zoom
            Me.Button12.FlatAppearance.BorderColor = Color.White
            Me.Button12.FlatAppearance.BorderSize = 0
            Me.Button12.FlatStyle = FlatStyle.Flat
            Me.Button12.Location = New Point(349, 12)
            Me.Button12.Name = "Button12"
            Me.Button12.Size = New System.Drawing.Size(24, 22)
            Me.Button12.TabIndex = 187
            Me.Button12.UseVisualStyleBackColor = False
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
            Me.Panel4.Controls.Add(Me.Label1)
            Me.Panel4.Controls.Add(Me.GroupBox1)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Location = New Point(54, 101)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(385, 72)
            Me.Panel4.TabIndex = 193
            Me.Panel4.Visible = False
            MyBase.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = Color.White
            MyBase.ClientSize = New System.Drawing.Size(1289, 608)
            MyBase.Controls.Add(Me.PictureBox1)
            MyBase.Controls.Add(Me.Panel4)
            MyBase.Controls.Add(Me.Panel3)
            MyBase.Controls.Add(Me.GroupBox2)
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "listado"
            MyBase.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "listado"
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            DirectCast(Me.DataGridView1, ISupportInitialize).EndInit()
            DirectCast(Me.Textbuscar.Properties, ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            DirectCast(Me.TextEdit1.Properties, ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            DirectCast(Me.TextEdit2.Properties, ISupportInitialize).EndInit()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub

        Public Sub Limpiar()
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            Me.RadioButton1.Checked = False
            Me.RadioButton2.Checked = False
            Me.RadioButton3.Checked = False
            Me.DataGridView1.DataSource = Nothing
        End Sub

        Private Sub listadoActivated(ByVal sender As Object, ByVal e As EventArgs)
            Me.DataGridView1.DataSource = Nothing
            Me.Panel1.Visible = False
        End Sub

        Private Sub ListadoFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            MyProject.Forms.Registro.SimpleButton1.Visible = True
            MyProject.Forms.Registro.SimpleButton2.Visible = True
            MyProject.Forms.Registro.SimpleButton3.Visible = False
            MyProject.Forms.Registro.Limpiar()
            MyProject.Forms.Form1.Show()
        End Sub

        Private Sub ListadoMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            listado.Releasecapture()
            listado.SendMessage(MyBase.Handle, 274, 61458, 0)
        End Sub

        Private Sub PictureBox1Click(ByVal sender As Object, ByVal e As EventArgs)
            MyBase.Close()
        End Sub

        Private Sub RadioButton1CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me.RadioButton1.Checked) Then
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

        Private Sub RadioButton2CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me.RadioButton2.Checked) Then
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

        Private Sub RadioButton3CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If (Not Me.RadioButton3.Checked) Then
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

        Private Sub TextbuscarEnter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Textbuscar.Text, "Búsqueda por nombre", False) = 0) Then
                Me.Textbuscar.Text = ""
                Me.Button7.Visible = True
                Me.Label1.Visible = True
                Me.Label2.Visible = True
            End If
        End Sub

        Private Sub TextbuscarKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyData = Keys.[Return]) Then
                conexionmysql.Abrir_MYBD()
                Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where nombre like '%", Me.Textbuscar.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                    Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                    If (dataTable.Rows.Count <= 0) Then
                        MessageBox.Show("No hay descripcion para este ID")
                        Me.DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                        modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Año anterior', lugaranterior as 'Lugar anterior'  "
                        modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me.DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where nombre Like  '%", Me.Textbuscar.Text, "%'")
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

        Private Sub TextbuscarLeave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Textbuscar.Text, "", False) = 0) Then
                Me.Textbuscar.Text = "Búsqueda por nombre"
                Me.Button7.Visible = False
                Me.Label1.Visible = False
                Me.Label2.Visible = False
            End If
        End Sub

        Private Sub TextEdit1Enter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextEdit1.Text, "Búsqueda por ID", False) = 0) Then
                Me.TextEdit1.Text = ""
                Me.Button9.Visible = True
                Me.Label5.Visible = True
                Me.Label6.Visible = True
            End If
        End Sub

        Private Sub TextEdit1KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyData = Keys.[Return]) Then
                conexionmysql.Abrir_MYBD()
                Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where identidadalumno like '%", Me.TextEdit1.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                    Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                    If (dataTable.Rows.Count <= 0) Then
                        MessageBox.Show("No hay descripcion para este ID")
                        Me.DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                        modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Año anterior', lugaranterior as 'Lugar anterior'  "
                        modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me.DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where identidadalumno Like  '%", Me.TextEdit1.Text, "%'")
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

        Private Sub TextEdit1KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.Handled = Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If (Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
                Interaction.MsgBox("Solo Puede digitar numeros", MsgBoxStyle.OkOnly, Nothing)
            End If
        End Sub

        Private Sub TextEdit1Leave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextEdit1.Text, "", False) = 0) Then
                Me.TextEdit1.Text = "Búsqueda por ID"
                Me.Button9.Visible = False
                Me.Label5.Visible = False
                Me.Label6.Visible = False
            End If
        End Sub

        Private Sub TextEdit2Enter(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextEdit2.Text, "Búsqueda por codigo", False) = 0) Then
                Me.TextEdit2.Text = ""
                Me.Button11.Visible = True
                Me.Label7.Visible = True
                Me.Label8.Visible = True
            End If
        End Sub

        Private Sub TextEdit2KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyData = Keys.[Return]) Then
                conexionmysql.Abrir_MYBD()
                Try
                    Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(String.Concat("select * from matricula2 where codigo like '%", Me.TextEdit2.Text, "%'"), conexionmysql.myconn)
                    Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                    Dim num As Integer = (New MySqlDataAdapter(mySqlCommand)).Fill(dataTable)
                    If (dataTable.Rows.Count <= 0) Then
                        MessageBox.Show("No hay descripcion para este ID")
                        Me.DataGridView1.DataSource = Nothing
                    ElseIf (dataTable.Rows.Count > 0 Or dataTable.Rows.Count > 0) Then
                        modulo_funciones_sql.columna1w = "idmatricula as 'ID del Alumno', nombre as 'Nombre del Alumno', identidadalumno as 'Identidad Alumno', idp as 'Identidad Padre', grado as 'Grado', profesion as 'Profesion u Oficio', padre as 'Nombre Padre', telefono as 'Telefono', email as 'Correo electronico', direccion as 'Direccion', lugartrabajo as 'Lugar de trabajo', nombrepadre as 'Nombre del padre', lugartrabajopadre as 'Lugar de trabajo del padre', telefonopadre as 'Telefono del padre', nombremadre as 'Nombre de la madre', lugartrabajomadre as 'Lugar de trabajo de la madre', telefonomadre as 'Telefono madre', fechanac as 'Fecha de nacimiento', sexo as 'Sexo', nacionalidad as 'Nacionalidad', emergencia as 'Emergencia', telefonoemergencia as 'Telefono de emergencia', deptonac as 'Departamento de nacimiento', municipionac as 'Municipio de nacimiento', condicionado as 'Condicionado', repitente as 'Repitente', colegioanterior as 'Colegio anterior',cursoanterior as 'Curso anterior', modalidadanterior as 'Modalidad anterior', anioanterior as 'Año anterior', lugaranterior as 'Lugar anterior'  "
                        modulo_funciones_sql.tabla1w = "matricula2"
                        modulo_funciones_sql.data1w = Me.DataGridView1
                        modulo_funciones_sql.where = String.Concat(" where codigo Like  '%", Me.TextEdit2.Text, "%'")
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

        Private Sub TextEdit2KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.Handled = Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
            If (Not Versioned.IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)) Then
                Interaction.MsgBox("Solo Puede digitar numeros", MsgBoxStyle.OkOnly, Nothing)
            End If
        End Sub

        Private Sub TextEdit2Leave(ByVal sender As Object, ByVal e As EventArgs)
            If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.TextEdit2.Text, "", False) = 0) Then
                Me.TextEdit2.Text = "Búsqueda por codigo"
                Me.Button11.Visible = False
                Me.Label7.Visible = False
                Me.Label8.Visible = False
            End If
        End Sub
    End Class
End Namespace