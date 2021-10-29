Imports MySql.Data.MySqlClient
Imports ssh
Imports ssh.My
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace ssh.chrilyhd_matriculaagzDataSetTableAdapters
	<DataObject(True)>
	<Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
	<DesignerCategory("code")>
	<HelpKeyword("vs.data.TableAdapter")>
	<ToolboxItem(True)>
	Public Class matricula2TableAdapter
		Inherits Component
		Private _connection As MySqlConnection

		Private _transaction As MySqlTransaction

		Private _commandCollection As MySqlCommand()

		Private _clearBeforeFill As Boolean

        Friend Overridable Property _adapter As MySqlDataAdapter

        <DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Friend ReadOnly Property Adapter As MySqlDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property ClearBeforeFill As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected ReadOnly Property CommandCollection As MySqlCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Friend Property Connection As MySqlConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As MySqlConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim num As Integer = 0
				While num < CInt(Me.CommandCollection.Length)
					If (Me.CommandCollection(num) IsNot Nothing) Then
						Me.CommandCollection(num).Connection = value
					End If
					num = num + 1
				End While
			End Set
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Friend Property Transaction As MySqlTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As MySqlTransaction)
				Me._transaction = value
				Dim num As Integer = 0
				While num < CInt(Me.CommandCollection.Length)
					Me.CommandCollection(num).Transaction = Me._transaction
					num = num + 1
				End While
				If (If(Me.Adapter Is Nothing, False, Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If (If(Me.Adapter Is Nothing, False, Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If (If(Me.Adapter Is Nothing, False, Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Sub New()
			MyBase.New()
			Me.ClearBeforeFill = True
		End Sub

		<DataObjectMethod(DataObjectMethodType.Delete, True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Delete(ByVal p1 As Integer, ByVal p2 As String, ByVal p4 As String, ByVal p6 As String, ByVal p8 As String, ByVal p10 As String, ByVal p12 As String, ByVal p14 As String, ByVal p16 As String, ByVal p18 As String, ByVal p20 As String) As Integer
			Dim num As Integer
			Me.Adapter.DeleteCommand.Parameters(0).Value = p1
			If (p2 Is Nothing) Then
				Throw New ArgumentNullException("p2")
			End If
			Me.Adapter.DeleteCommand.Parameters(1).Value = p2
			If (p4 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(2).Value = 0
				Me.Adapter.DeleteCommand.Parameters(3).Value = p4
			Else
				Me.Adapter.DeleteCommand.Parameters(2).Value = 1
				Me.Adapter.DeleteCommand.Parameters(3).Value = DBNull.Value
			End If
			If (p6 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(4).Value = 0
				Me.Adapter.DeleteCommand.Parameters(5).Value = p6
			Else
				Me.Adapter.DeleteCommand.Parameters(4).Value = 1
				Me.Adapter.DeleteCommand.Parameters(5).Value = DBNull.Value
			End If
			If (p8 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(6).Value = 0
				Me.Adapter.DeleteCommand.Parameters(7).Value = p8
			Else
				Me.Adapter.DeleteCommand.Parameters(6).Value = 1
				Me.Adapter.DeleteCommand.Parameters(7).Value = DBNull.Value
			End If
			If (p10 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(8).Value = 0
				Me.Adapter.DeleteCommand.Parameters(9).Value = p10
			Else
				Me.Adapter.DeleteCommand.Parameters(8).Value = 1
				Me.Adapter.DeleteCommand.Parameters(9).Value = DBNull.Value
			End If
			If (p12 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(10).Value = 0
				Me.Adapter.DeleteCommand.Parameters(11).Value = p12
			Else
				Me.Adapter.DeleteCommand.Parameters(10).Value = 1
				Me.Adapter.DeleteCommand.Parameters(11).Value = DBNull.Value
			End If
			If (p14 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(12).Value = 0
				Me.Adapter.DeleteCommand.Parameters(13).Value = p14
			Else
				Me.Adapter.DeleteCommand.Parameters(12).Value = 1
				Me.Adapter.DeleteCommand.Parameters(13).Value = DBNull.Value
			End If
			If (p16 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(14).Value = 0
				Me.Adapter.DeleteCommand.Parameters(15).Value = p16
			Else
				Me.Adapter.DeleteCommand.Parameters(14).Value = 1
				Me.Adapter.DeleteCommand.Parameters(15).Value = DBNull.Value
			End If
			If (p18 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(16).Value = 0
				Me.Adapter.DeleteCommand.Parameters(17).Value = p18
			Else
				Me.Adapter.DeleteCommand.Parameters(16).Value = 1
				Me.Adapter.DeleteCommand.Parameters(17).Value = DBNull.Value
			End If
			If (p20 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(18).Value = 0
				Me.Adapter.DeleteCommand.Parameters(19).Value = p20
			Else
				Me.Adapter.DeleteCommand.Parameters(18).Value = 1
				Me.Adapter.DeleteCommand.Parameters(19).Value = DBNull.Value
			End If
			Dim state As ConnectionState = Me.Adapter.DeleteCommand.Connection.State
			If ((Me.Adapter.DeleteCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open) Then
				Me.Adapter.DeleteCommand.Connection.Open()
			End If
			Try
				num = Me.Adapter.DeleteCommand.ExecuteNonQuery()
			Finally
				If (state = ConnectionState.Closed) Then
					Me.Adapter.DeleteCommand.Connection.Close()
				End If
			End Try
			Return num
		End Function

		<DataObjectMethod(DataObjectMethodType.Fill, True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Fill(ByVal dataTable As chrilyhd_matriculaagzDataSet.matricula2DataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill) Then
				dataTable.Clear()
			End If
			Return Me.Adapter.Fill(dataTable)
		End Function

		<DataObjectMethod(DataObjectMethodType.[Select], True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function GetData() As chrilyhd_matriculaagzDataSet.matricula2DataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim _matricula2DataTable As chrilyhd_matriculaagzDataSet.matricula2DataTable = New chrilyhd_matriculaagzDataSet.matricula2DataTable()
			Me.Adapter.Fill(_matricula2DataTable)
			Return _matricula2DataTable
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitAdapter()
			Me._adapter = New MySqlDataAdapter()
			Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping() With
			{
				.SourceTable = "Table",
				.DataSetTable = "matricula2"
			}
			dataTableMapping.ColumnMappings.Add("id_matricula", "id_matricula")
			dataTableMapping.ColumnMappings.Add("nombre", "nombre")
			dataTableMapping.ColumnMappings.Add("identidad_alumno", "identidad_alumno")
			dataTableMapping.ColumnMappings.Add("idp", "idp")
			dataTableMapping.ColumnMappings.Add("grado", "grado")
			dataTableMapping.ColumnMappings.Add("profesion", "profesion")
			dataTableMapping.ColumnMappings.Add("padre", "padre")
			dataTableMapping.ColumnMappings.Add("telefono", "telefono")
			dataTableMapping.ColumnMappings.Add("email", "email")
			dataTableMapping.ColumnMappings.Add("codigo", "codigo")
			dataTableMapping.ColumnMappings.Add("direccion", "direccion")
			Me._adapter.TableMappings.Add(CObj(dataTableMapping))
			Me._adapter.DeleteCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "DELETE FROM `matricula2` WHERE ((`id_matricula` = @p1) AND (`nombre` = @p2) AND ((@p3 = 1 AND `identidad_alumno` IS NULL) OR (`identidad_alumno` = @p4)) AND ((@p5 = 1 AND `idp` IS NULL) OR (`idp` = @p6)) AND ((@p7 = 1 AND `grado` IS NULL) OR (`grado` = @p8)) AND ((@p9 = 1 AND `profesion` IS NULL) OR (`profesion` = @p10)) AND ((@p11 = 1 AND `padre` IS NULL) OR (`padre` = @p12)) AND ((@p13 = 1 AND `telefono` IS NULL) OR (`telefono` = @p14)) AND ((@p15 = 1 AND `email` IS NULL) OR (`email` = @p16)) AND ((@p17 = 1 AND `codigo` IS NULL) OR (`codigo` = @p18)) AND ((@p19 = 1 AND `direccion` IS NULL) OR (`direccion` = @p20)))",
				.CommandType = CommandType.Text
			}
			Dim mySqlParameter As MySql.Data.MySqlClient.MySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p1",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "id_matricula",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p2",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p3",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p4",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p5",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p6",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p7",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p8",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p9",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p10",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p11",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p12",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p13",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p14",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p15",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p16",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p17",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p18",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p19",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p20",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			Me._adapter.InsertCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "INSERT INTO `matricula2` (`nombre`, `identidad_alumno`, `idp`, `grado`, `profesion`, `padre`, `telefono`, `email`, `codigo`, `direccion`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)",
				.CommandType = CommandType.Text
			}
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p1",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p2",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p3",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p4",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p5",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p6",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p7",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p8",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p9",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p10",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			Me._adapter.UpdateCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "UPDATE `matricula2` SET `nombre` = @p1, `identidad_alumno` = @p2, `idp` = @p3, `grado` = @p4, `profesion` = @p5, `padre` = @p6, `telefono` = @p7, `email` = @p8, `codigo` = @p9, `direccion` = @p10 WHERE ((`id_matricula` = @p11) AND (`nombre` = @p12) AND ((@p13 = 1 AND `identidad_alumno` IS NULL) OR (`identidad_alumno` = @p14)) AND ((@p15 = 1 AND `idp` IS NULL) OR (`idp` = @p16)) AND ((@p17 = 1 AND `grado` IS NULL) OR (`grado` = @p18)) AND ((@p19 = 1 AND `profesion` IS NULL) OR (`profesion` = @p20)) AND ((@p21 = 1 AND `padre` IS NULL) OR (`padre` = @p22)) AND ((@p23 = 1 AND `telefono` IS NULL) OR (`telefono` = @p24)) AND ((@p25 = 1 AND `email` IS NULL) OR (`email` = @p26)) AND ((@p27 = 1 AND `codigo` IS NULL) OR (`codigo` = @p28)) AND ((@p29 = 1 AND `direccion` IS NULL) OR (`direccion` = @p30)))",
				.CommandType = CommandType.Text
			}
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p1",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p2",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p3",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p4",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p5",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p6",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p7",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p8",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p9",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p10",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p11",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "id_matricula",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p12",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p13",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p14",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p15",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p16",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p17",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p18",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p19",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p20",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p21",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p22",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p23",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p24",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p25",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p26",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p27",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p28",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p29",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p30",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitCommandCollection()
			Me._commandCollection = New MySqlCommand() { New MySqlCommand() }
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT `id_matricula`, `nombre`, `identidad_alumno`, `idp`, `grado`, `profesion`, `padre`, `telefono`, `email`, `codigo`, `direccion` FROM `matricula2`"
			Me._commandCollection(0).CommandType = CommandType.Text
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitConnection()
            Me._connection = New MySqlConnection() With
            {
                .ConnectionString = My.MySettings.Default.chrilyhd_matriculaagzConnectionString
            }
        End Sub

		<DataObjectMethod(DataObjectMethodType.Insert, True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Insert(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String, ByVal p8 As String, ByVal p9 As String, ByVal p10 As String) As Integer
			Dim num As Integer
			If (p1 Is Nothing) Then
				Throw New ArgumentNullException("p1")
			End If
			Me.Adapter.InsertCommand.Parameters(0).Value = p1
			If (p2 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(1).Value = p2
			Else
				Me.Adapter.InsertCommand.Parameters(1).Value = DBNull.Value
			End If
			If (p3 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(2).Value = p3
			Else
				Me.Adapter.InsertCommand.Parameters(2).Value = DBNull.Value
			End If
			If (p4 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(3).Value = p4
			Else
				Me.Adapter.InsertCommand.Parameters(3).Value = DBNull.Value
			End If
			If (p5 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(4).Value = p5
			Else
				Me.Adapter.InsertCommand.Parameters(4).Value = DBNull.Value
			End If
			If (p6 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(5).Value = p6
			Else
				Me.Adapter.InsertCommand.Parameters(5).Value = DBNull.Value
			End If
			If (p7 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(6).Value = p7
			Else
				Me.Adapter.InsertCommand.Parameters(6).Value = DBNull.Value
			End If
			If (p8 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(7).Value = p8
			Else
				Me.Adapter.InsertCommand.Parameters(7).Value = DBNull.Value
			End If
			If (p9 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(8).Value = p9
			Else
				Me.Adapter.InsertCommand.Parameters(8).Value = DBNull.Value
			End If
			If (p10 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(9).Value = p10
			Else
				Me.Adapter.InsertCommand.Parameters(9).Value = DBNull.Value
			End If
			Dim state As ConnectionState = Me.Adapter.InsertCommand.Connection.State
			If ((Me.Adapter.InsertCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open) Then
				Me.Adapter.InsertCommand.Connection.Open()
			End If
			Try
				num = Me.Adapter.InsertCommand.ExecuteNonQuery()
			Finally
				If (state = ConnectionState.Closed) Then
					Me.Adapter.InsertCommand.Connection.Close()
				End If
			End Try
			Return num
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal dataTable As chrilyhd_matriculaagzDataSet.matricula2DataTable) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal dataSet As chrilyhd_matriculaagzDataSet) As Integer
			Return Me.Adapter.Update(dataSet, "matricula2")
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal dataRow As System.Data.DataRow) As Integer
			Return Me.Adapter.Update(New System.Data.DataRow() { dataRow })
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal dataRows As DataRow()) As Integer
			Return Me.Adapter.Update(dataRows)
		End Function

		<DataObjectMethod(DataObjectMethodType.Update, True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String, ByVal p8 As String, ByVal p9 As String, ByVal p10 As String, ByVal p11 As Integer, ByVal p12 As String, ByVal p14 As String, ByVal p16 As String, ByVal p18 As String, ByVal p20 As String, ByVal p22 As String, ByVal p24 As String, ByVal p26 As String, ByVal p28 As String, ByVal p30 As String) As Integer
			Dim num As Integer
			If (p1 Is Nothing) Then
				Throw New ArgumentNullException("p1")
			End If
			Me.Adapter.UpdateCommand.Parameters(0).Value = p1
			If (p2 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(1).Value = p2
			Else
				Me.Adapter.UpdateCommand.Parameters(1).Value = DBNull.Value
			End If
			If (p3 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(2).Value = p3
			Else
				Me.Adapter.UpdateCommand.Parameters(2).Value = DBNull.Value
			End If
			If (p4 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(3).Value = p4
			Else
				Me.Adapter.UpdateCommand.Parameters(3).Value = DBNull.Value
			End If
			If (p5 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(4).Value = p5
			Else
				Me.Adapter.UpdateCommand.Parameters(4).Value = DBNull.Value
			End If
			If (p6 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(5).Value = p6
			Else
				Me.Adapter.UpdateCommand.Parameters(5).Value = DBNull.Value
			End If
			If (p7 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(6).Value = p7
			Else
				Me.Adapter.UpdateCommand.Parameters(6).Value = DBNull.Value
			End If
			If (p8 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(7).Value = p8
			Else
				Me.Adapter.UpdateCommand.Parameters(7).Value = DBNull.Value
			End If
			If (p9 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(8).Value = p9
			Else
				Me.Adapter.UpdateCommand.Parameters(8).Value = DBNull.Value
			End If
			If (p10 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(9).Value = p10
			Else
				Me.Adapter.UpdateCommand.Parameters(9).Value = DBNull.Value
			End If
			Me.Adapter.UpdateCommand.Parameters(10).Value = p11
			If (p12 Is Nothing) Then
				Throw New ArgumentNullException("p12")
			End If
			Me.Adapter.UpdateCommand.Parameters(11).Value = p12
			If (p14 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(12).Value = 0
				Me.Adapter.UpdateCommand.Parameters(13).Value = p14
			Else
				Me.Adapter.UpdateCommand.Parameters(12).Value = 1
				Me.Adapter.UpdateCommand.Parameters(13).Value = DBNull.Value
			End If
			If (p16 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(14).Value = 0
				Me.Adapter.UpdateCommand.Parameters(15).Value = p16
			Else
				Me.Adapter.UpdateCommand.Parameters(14).Value = 1
				Me.Adapter.UpdateCommand.Parameters(15).Value = DBNull.Value
			End If
			If (p18 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(16).Value = 0
				Me.Adapter.UpdateCommand.Parameters(17).Value = p18
			Else
				Me.Adapter.UpdateCommand.Parameters(16).Value = 1
				Me.Adapter.UpdateCommand.Parameters(17).Value = DBNull.Value
			End If
			If (p20 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(18).Value = 0
				Me.Adapter.UpdateCommand.Parameters(19).Value = p20
			Else
				Me.Adapter.UpdateCommand.Parameters(18).Value = 1
				Me.Adapter.UpdateCommand.Parameters(19).Value = DBNull.Value
			End If
			If (p22 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(20).Value = 0
				Me.Adapter.UpdateCommand.Parameters(21).Value = p22
			Else
				Me.Adapter.UpdateCommand.Parameters(20).Value = 1
				Me.Adapter.UpdateCommand.Parameters(21).Value = DBNull.Value
			End If
			If (p24 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(22).Value = 0
				Me.Adapter.UpdateCommand.Parameters(23).Value = p24
			Else
				Me.Adapter.UpdateCommand.Parameters(22).Value = 1
				Me.Adapter.UpdateCommand.Parameters(23).Value = DBNull.Value
			End If
			If (p26 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(24).Value = 0
				Me.Adapter.UpdateCommand.Parameters(25).Value = p26
			Else
				Me.Adapter.UpdateCommand.Parameters(24).Value = 1
				Me.Adapter.UpdateCommand.Parameters(25).Value = DBNull.Value
			End If
			If (p28 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(26).Value = 0
				Me.Adapter.UpdateCommand.Parameters(27).Value = p28
			Else
				Me.Adapter.UpdateCommand.Parameters(26).Value = 1
				Me.Adapter.UpdateCommand.Parameters(27).Value = DBNull.Value
			End If
			If (p30 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(28).Value = 0
				Me.Adapter.UpdateCommand.Parameters(29).Value = p30
			Else
				Me.Adapter.UpdateCommand.Parameters(28).Value = 1
				Me.Adapter.UpdateCommand.Parameters(29).Value = DBNull.Value
			End If
			Dim state As ConnectionState = Me.Adapter.UpdateCommand.Connection.State
			If ((Me.Adapter.UpdateCommand.Connection.State And ConnectionState.Open) <> ConnectionState.Open) Then
				Me.Adapter.UpdateCommand.Connection.Open()
			End If
			Try
				num = Me.Adapter.UpdateCommand.ExecuteNonQuery()
			Finally
				If (state = ConnectionState.Closed) Then
					Me.Adapter.UpdateCommand.Connection.Close()
				End If
			End Try
			Return num
		End Function
	End Class
End Namespace