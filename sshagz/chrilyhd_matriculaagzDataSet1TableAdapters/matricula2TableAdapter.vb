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

Namespace ssh.chrilyhd_matriculaagzDataSet1TableAdapters
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

        Public Overridable Property _adapter As MySqlDataAdapter

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
		Public Overridable Function Delete(ByVal p1 As Integer, ByVal p2 As String, ByVal p4 As String, ByVal p6 As String, ByVal p8 As String, ByVal p10 As String, ByVal p12 As String, ByVal p14 As String, ByVal p16 As String, ByVal p18 As String, ByVal p20 As String, ByVal p22 As String, ByVal p24 As String, ByVal p26 As String, ByVal p28 As String, ByVal p30 As String, ByVal p32 As String, ByVal p34 As String, ByVal p36 As Nullable(Of DateTime), ByVal p38 As String, ByVal p40 As String, ByVal p42 As String, ByVal p44 As String, ByVal p46 As String, ByVal p48 As String, ByVal p50 As String, ByVal p52 As String, ByVal p54 As String, ByVal p56 As String, ByVal p58 As String, ByVal p60 As String, ByVal p62 As String, ByVal p64 As String, ByVal p66 As String) As Integer
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
			If (p22 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(20).Value = 0
				Me.Adapter.DeleteCommand.Parameters(21).Value = p22
			Else
				Me.Adapter.DeleteCommand.Parameters(20).Value = 1
				Me.Adapter.DeleteCommand.Parameters(21).Value = DBNull.Value
			End If
			If (p24 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(22).Value = 0
				Me.Adapter.DeleteCommand.Parameters(23).Value = p24
			Else
				Me.Adapter.DeleteCommand.Parameters(22).Value = 1
				Me.Adapter.DeleteCommand.Parameters(23).Value = DBNull.Value
			End If
			If (p26 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(24).Value = 0
				Me.Adapter.DeleteCommand.Parameters(25).Value = p26
			Else
				Me.Adapter.DeleteCommand.Parameters(24).Value = 1
				Me.Adapter.DeleteCommand.Parameters(25).Value = DBNull.Value
			End If
			If (p28 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(26).Value = 0
				Me.Adapter.DeleteCommand.Parameters(27).Value = p28
			Else
				Me.Adapter.DeleteCommand.Parameters(26).Value = 1
				Me.Adapter.DeleteCommand.Parameters(27).Value = DBNull.Value
			End If
			If (p30 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(28).Value = 0
				Me.Adapter.DeleteCommand.Parameters(29).Value = p30
			Else
				Me.Adapter.DeleteCommand.Parameters(28).Value = 1
				Me.Adapter.DeleteCommand.Parameters(29).Value = DBNull.Value
			End If
			If (p32 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(30).Value = 0
				Me.Adapter.DeleteCommand.Parameters(31).Value = p32
			Else
				Me.Adapter.DeleteCommand.Parameters(30).Value = 1
				Me.Adapter.DeleteCommand.Parameters(31).Value = DBNull.Value
			End If
			If (p34 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(32).Value = 0
				Me.Adapter.DeleteCommand.Parameters(33).Value = p34
			Else
				Me.Adapter.DeleteCommand.Parameters(32).Value = 1
				Me.Adapter.DeleteCommand.Parameters(33).Value = DBNull.Value
			End If
			If (Not p36.HasValue) Then
				Me.Adapter.DeleteCommand.Parameters(34).Value = 1
				Me.Adapter.DeleteCommand.Parameters(35).Value = DBNull.Value
			Else
				Me.Adapter.DeleteCommand.Parameters(34).Value = 0
				Me.Adapter.DeleteCommand.Parameters(35).Value = p36.Value
			End If
			If (p38 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(36).Value = 0
				Me.Adapter.DeleteCommand.Parameters(37).Value = p38
			Else
				Me.Adapter.DeleteCommand.Parameters(36).Value = 1
				Me.Adapter.DeleteCommand.Parameters(37).Value = DBNull.Value
			End If
			If (p40 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(38).Value = 0
				Me.Adapter.DeleteCommand.Parameters(39).Value = p40
			Else
				Me.Adapter.DeleteCommand.Parameters(38).Value = 1
				Me.Adapter.DeleteCommand.Parameters(39).Value = DBNull.Value
			End If
			If (p42 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(40).Value = 0
				Me.Adapter.DeleteCommand.Parameters(41).Value = p42
			Else
				Me.Adapter.DeleteCommand.Parameters(40).Value = 1
				Me.Adapter.DeleteCommand.Parameters(41).Value = DBNull.Value
			End If
			If (p44 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(42).Value = 0
				Me.Adapter.DeleteCommand.Parameters(43).Value = p44
			Else
				Me.Adapter.DeleteCommand.Parameters(42).Value = 1
				Me.Adapter.DeleteCommand.Parameters(43).Value = DBNull.Value
			End If
			If (p46 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(44).Value = 0
				Me.Adapter.DeleteCommand.Parameters(45).Value = p46
			Else
				Me.Adapter.DeleteCommand.Parameters(44).Value = 1
				Me.Adapter.DeleteCommand.Parameters(45).Value = DBNull.Value
			End If
			If (p48 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(46).Value = 0
				Me.Adapter.DeleteCommand.Parameters(47).Value = p48
			Else
				Me.Adapter.DeleteCommand.Parameters(46).Value = 1
				Me.Adapter.DeleteCommand.Parameters(47).Value = DBNull.Value
			End If
			If (p50 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(48).Value = 0
				Me.Adapter.DeleteCommand.Parameters(49).Value = p50
			Else
				Me.Adapter.DeleteCommand.Parameters(48).Value = 1
				Me.Adapter.DeleteCommand.Parameters(49).Value = DBNull.Value
			End If
			If (p52 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(50).Value = 0
				Me.Adapter.DeleteCommand.Parameters(51).Value = p52
			Else
				Me.Adapter.DeleteCommand.Parameters(50).Value = 1
				Me.Adapter.DeleteCommand.Parameters(51).Value = DBNull.Value
			End If
			If (p54 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(52).Value = 0
				Me.Adapter.DeleteCommand.Parameters(53).Value = p54
			Else
				Me.Adapter.DeleteCommand.Parameters(52).Value = 1
				Me.Adapter.DeleteCommand.Parameters(53).Value = DBNull.Value
			End If
			If (p56 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(54).Value = 0
				Me.Adapter.DeleteCommand.Parameters(55).Value = p56
			Else
				Me.Adapter.DeleteCommand.Parameters(54).Value = 1
				Me.Adapter.DeleteCommand.Parameters(55).Value = DBNull.Value
			End If
			If (p58 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(56).Value = 0
				Me.Adapter.DeleteCommand.Parameters(57).Value = p58
			Else
				Me.Adapter.DeleteCommand.Parameters(56).Value = 1
				Me.Adapter.DeleteCommand.Parameters(57).Value = DBNull.Value
			End If
			If (p60 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(58).Value = 0
				Me.Adapter.DeleteCommand.Parameters(59).Value = p60
			Else
				Me.Adapter.DeleteCommand.Parameters(58).Value = 1
				Me.Adapter.DeleteCommand.Parameters(59).Value = DBNull.Value
			End If
			If (p62 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(60).Value = 0
				Me.Adapter.DeleteCommand.Parameters(61).Value = p62
			Else
				Me.Adapter.DeleteCommand.Parameters(60).Value = 1
				Me.Adapter.DeleteCommand.Parameters(61).Value = DBNull.Value
			End If
			If (p64 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(62).Value = 0
				Me.Adapter.DeleteCommand.Parameters(63).Value = p64
			Else
				Me.Adapter.DeleteCommand.Parameters(62).Value = 1
				Me.Adapter.DeleteCommand.Parameters(63).Value = DBNull.Value
			End If
			If (p66 IsNot Nothing) Then
				Me.Adapter.DeleteCommand.Parameters(64).Value = 0
				Me.Adapter.DeleteCommand.Parameters(65).Value = p66
			Else
				Me.Adapter.DeleteCommand.Parameters(64).Value = 1
				Me.Adapter.DeleteCommand.Parameters(65).Value = DBNull.Value
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
		Public Overridable Function Fill(ByVal dataTable As chrilyhd_matriculaagzDataSet1.matricula2DataTable) As Integer
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
		Public Overridable Function GetData() As chrilyhd_matriculaagzDataSet1.matricula2DataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim _matricula2DataTable As chrilyhd_matriculaagzDataSet1.matricula2DataTable = New chrilyhd_matriculaagzDataSet1.matricula2DataTable()
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
			dataTableMapping.ColumnMappings.Add("lugar_trabajo", "lugar_trabajo")
			dataTableMapping.ColumnMappings.Add("nombre_padre", "nombre_padre")
			dataTableMapping.ColumnMappings.Add("lugar_trabajo_padre", "lugar_trabajo_padre")
			dataTableMapping.ColumnMappings.Add("telefono_padre", "telefono_padre")
			dataTableMapping.ColumnMappings.Add("nombre_madre", "nombre_madre")
			dataTableMapping.ColumnMappings.Add("lugar_trabajo_madre", "lugar_trabajo_madre")
			dataTableMapping.ColumnMappings.Add("telefono_madre", "telefono_madre")
			dataTableMapping.ColumnMappings.Add("fecha_nac", "fecha_nac")
			dataTableMapping.ColumnMappings.Add("edad", "edad")
			dataTableMapping.ColumnMappings.Add("sexo", "sexo")
			dataTableMapping.ColumnMappings.Add("modalidad", "modalidad")
			dataTableMapping.ColumnMappings.Add("nacionalidad", "nacionalidad")
			dataTableMapping.ColumnMappings.Add("emergencia", "emergencia")
			dataTableMapping.ColumnMappings.Add("telefono_emergencia", "telefono_emergencia")
			dataTableMapping.ColumnMappings.Add("depto_nac", "depto_nac")
			dataTableMapping.ColumnMappings.Add("municipio_nac", "municipio_nac")
			dataTableMapping.ColumnMappings.Add("condicionado", "condicionado")
			dataTableMapping.ColumnMappings.Add("repitente", "repitente")
			dataTableMapping.ColumnMappings.Add("colegio_anterior", "colegio_anterior")
			dataTableMapping.ColumnMappings.Add("curso_anterior", "curso_anterior")
			dataTableMapping.ColumnMappings.Add("modalidad_anterior", "modalidad_anterior")
			dataTableMapping.ColumnMappings.Add("anio_anterior", "anio_anterior")
			dataTableMapping.ColumnMappings.Add("lugar_anterior", "lugar_anterior")
			Me._adapter.TableMappings.Add(CObj(dataTableMapping))
			Me._adapter.DeleteCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "DELETE FROM `matricula2` WHERE ((`id_matricula` = @p1) AND (`nombre` = @p2) AND ((@p3 = 1 AND `identidad_alumno` IS NULL) OR (`identidad_alumno` = @p4)) AND ((@p5 = 1 AND `idp` IS NULL) OR (`idp` = @p6)) AND ((@p7 = 1 AND `grado` IS NULL) OR (`grado` = @p8)) AND ((@p9 = 1 AND `profesion` IS NULL) OR (`profesion` = @p10)) AND ((@p11 = 1 AND `padre` IS NULL) OR (`padre` = @p12)) AND ((@p13 = 1 AND `telefono` IS NULL) OR (`telefono` = @p14)) AND ((@p15 = 1 AND `email` IS NULL) OR (`email` = @p16)) AND ((@p17 = 1 AND `codigo` IS NULL) OR (`codigo` = @p18)) AND ((@p19 = 1 AND `direccion` IS NULL) OR (`direccion` = @p20)) AND ((@p21 = 1 AND `lugar_trabajo` IS NULL) OR (`lugar_trabajo` = @p22)) AND ((@p23 = 1 AND `nombre_padre` IS NULL) OR (`nombre_padre` = @p24)) AND ((@p25 = 1 AND `lugar_trabajo_padre` IS NULL) OR (`lugar_trabajo_padre` = @p26)) AND ((@p27 = 1 AND `telefono_padre` IS NULL) OR (`telefono_padre` = @p28)) AND ((@p29 = 1 AND `nombre_madre` IS NULL) OR (`nombre_madre` = @p30)) AND ((@p31 = 1 AND `lugar_trabajo_madre` IS NULL) OR (`lugar_trabajo_madre` = @p32)) AND ((@p33 = 1 AND `telefono_madre` IS NULL) OR (`telefono_madre` = @p34)) AND ((@p35 = 1 AND `fecha_nac` IS NULL) OR (`fecha_nac` = @p36)) AND ((@p37 = 1 AND `edad` IS NULL) OR (`edad` = @p38)) AND ((@p39 = 1 AND `sexo` IS NULL) OR (`sexo` = @p40)) AND ((@p41 = 1 AND `modalidad` IS NULL) OR (`modalidad` = @p42)) AND ((@p43 = 1 AND `nacionalidad` IS NULL) OR (`nacionalidad` = @p44)) AND ((@p45 = 1 AND `emergencia` IS NULL) OR (`emergencia` = @p46)) AND ((@p47 = 1 AND `telefono_emergencia` IS NULL) OR (`telefono_emergencia` = @p48)) AND ((@p49 = 1 AND `depto_nac` IS NULL) OR (`depto_nac` = @p50)) AND ((@p51 = 1 AND `municipio_nac` IS NULL) OR (`municipio_nac` = @p52)) AND ((@p53 = 1 AND `condicionado` IS NULL) OR (`condicionado` = @p54)) AND ((@p55 = 1 AND `repitente` IS NULL) OR (`repitente` = @p56)) AND ((@p57 = 1 AND `colegio_anterior` IS NULL) OR (`colegio_anterior` = @p58)) AND ((@p59 = 1 AND `curso_anterior` IS NULL) OR (`curso_anterior` = @p60)) AND ((@p61 = 1 AND `modalidad_anterior` IS NULL) OR (`modalidad_anterior` = @p62)) AND ((@p63 = 1 AND `anio_anterior` IS NULL) OR (`anio_anterior` = @p64)) AND ((@p65 = 1 AND `lugar_anterior` IS NULL) OR (`lugar_anterior` = @p66)))",
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
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p21",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p22",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p23",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p24",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p25",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p26",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p27",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p28",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p29",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p30",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p31",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p32",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p33",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p34",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p35",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p36",
				.DbType = DbType.[Date],
				.MySqlDbType = MySqlDbType.[Date],
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p37",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p38",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p39",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p40",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p41",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p42",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p43",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p44",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p45",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p46",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p47",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p48",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p49",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p50",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p51",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p52",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p53",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p54",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p55",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p56",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p57",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p58",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p59",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p60",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p61",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p62",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p63",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p64",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p65",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p66",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.DeleteCommand.Parameters.Add(mySqlParameter)
			Me._adapter.InsertCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "INSERT INTO `matricula2` (`nombre`, `identidad_alumno`, `idp`, `grado`, `profesion`, `padre`, `telefono`, `email`, `codigo`, `direccion`, `lugar_trabajo`, `nombre_padre`, `lugar_trabajo_padre`, `telefono_padre`, `nombre_madre`, `lugar_trabajo_madre`, `telefono_madre`, `fecha_nac`, `edad`, `sexo`, `modalidad`, `nacionalidad`, `emergencia`, `telefono_emergencia`, `depto_nac`, `municipio_nac`, `condicionado`, `repitente`, `colegio_anterior`, `curso_anterior`, `modalidad_anterior`, `anio_anterior`, `lugar_anterior`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33)",
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
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p11",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p12",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p13",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p14",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p15",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p16",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p17",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p18",
				.DbType = DbType.[Date],
				.MySqlDbType = MySqlDbType.[Date],
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p19",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p20",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p21",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p22",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p23",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p24",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p25",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p26",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p27",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p28",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p29",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p30",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p31",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p32",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p33",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.InsertCommand.Parameters.Add(mySqlParameter)
			Me._adapter.UpdateCommand = New MySqlCommand() With
			{
				.Connection = Me.Connection,
				.CommandText = "UPDATE `matricula2` SET `nombre` = @p1, `identidad_alumno` = @p2, `idp` = @p3, `grado` = @p4, `profesion` = @p5, `padre` = @p6, `telefono` = @p7, `email` = @p8, `codigo` = @p9, `direccion` = @p10, `lugar_trabajo` = @p11, `nombre_padre` = @p12, `lugar_trabajo_padre` = @p13, `telefono_padre` = @p14, `nombre_madre` = @p15, `lugar_trabajo_madre` = @p16, `telefono_madre` = @p17, `fecha_nac` = @p18, `edad` = @p19, `sexo` = @p20, `modalidad` = @p21, `nacionalidad` = @p22, `emergencia` = @p23, `telefono_emergencia` = @p24, `depto_nac` = @p25, `municipio_nac` = @p26, `condicionado` = @p27, `repitente` = @p28, `colegio_anterior` = @p29, `curso_anterior` = @p30, `modalidad_anterior` = @p31, `anio_anterior` = @p32, `lugar_anterior` = @p33 WHERE ((`id_matricula` = @p34) AND (`nombre` = @p35) AND ((@p36 = 1 AND `identidad_alumno` IS NULL) OR (`identidad_alumno` = @p37)) AND ((@p38 = 1 AND `idp` IS NULL) OR (`idp` = @p39)) AND ((@p40 = 1 AND `grado` IS NULL) OR (`grado` = @p41)) AND ((@p42 = 1 AND `profesion` IS NULL) OR (`profesion` = @p43)) AND ((@p44 = 1 AND `padre` IS NULL) OR (`padre` = @p45)) AND ((@p46 = 1 AND `telefono` IS NULL) OR (`telefono` = @p47)) AND ((@p48 = 1 AND `email` IS NULL) OR (`email` = @p49)) AND ((@p50 = 1 AND `codigo` IS NULL) OR (`codigo` = @p51)) AND ((@p52 = 1 AND `direccion` IS NULL) OR (`direccion` = @p53)) AND ((@p54 = 1 AND `lugar_trabajo` IS NULL) OR (`lugar_trabajo` = @p55)) AND ((@p56 = 1 AND `nombre_padre` IS NULL) OR (`nombre_padre` = @p57)) AND ((@p58 = 1 AND `lugar_trabajo_padre` IS NULL) OR (`lugar_trabajo_padre` = @p59)) AND ((@p60 = 1 AND `telefono_padre` IS NULL) OR (`telefono_padre` = @p61)) AND ((@p62 = 1 AND `nombre_madre` IS NULL) OR (`nombre_madre` = @p63)) AND ((@p64 = 1 AND `lugar_trabajo_madre` IS NULL) OR (`lugar_trabajo_madre` = @p65)) AND ((@p66 = 1 AND `telefono_madre` IS NULL) OR (`telefono_madre` = @p67)) AND ((@p68 = 1 AND `fecha_nac` IS NULL) OR (`fecha_nac` = @p69)) AND ((@p70 = 1 AND `edad` IS NULL) OR (`edad` = @p71)) AND ((@p72 = 1 AND `sexo` IS NULL) OR (`sexo` = @p73)) AND ((@p74 = 1 AND `modalidad` IS NULL) OR (`modalidad` = @p75)) AND ((@p76 = 1 AND `nacionalidad` IS NULL) OR (`nacionalidad` = @p77)) AND ((@p78 = 1 AND `emergencia` IS NULL) OR (`emergencia` = @p79)) AND ((@p80 = 1 AND `telefono_emergencia` IS NULL) OR (`telefono_emergencia` = @p81)) AND ((@p82 = 1 AND `depto_nac` IS NULL) OR (`depto_nac` = @p83)) AND ((@p84 = 1 AND `municipio_nac` IS NULL) OR (`municipio_nac` = @p85)) AND ((@p86 = 1 AND `condicionado` IS NULL) OR (`condicionado` = @p87)) AND ((@p88 = 1 AND `repitente` IS NULL) OR (`repitente` = @p89)) AND ((@p90 = 1 AND `colegio_anterior` IS NULL) OR (`colegio_anterior` = @p91)) AND ((@p92 = 1 AND `curso_anterior` IS NULL) OR (`curso_anterior` = @p93)) AND ((@p94 = 1 AND `modalidad_anterior` IS NULL) OR (`modalidad_anterior` = @p95)) AND ((@p96 = 1 AND `anio_anterior` IS NULL) OR (`anio_anterior` = @p97)) AND ((@p98 = 1 AND `lugar_anterior` IS NULL) OR (`lugar_anterior` = @p99)))",
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
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p12",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p13",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p14",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p15",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p16",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p17",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p18",
				.DbType = DbType.[Date],
				.MySqlDbType = MySqlDbType.[Date],
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p19",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p20",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p21",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p22",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p23",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p24",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p25",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p26",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p27",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p28",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p29",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p30",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p31",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p32",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p33",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Current
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p34",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "id_matricula",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p35",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p36",
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
				.ParameterName = "@p37",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "identidad_alumno",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p38",
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
				.ParameterName = "@p39",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "idp",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p40",
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
				.ParameterName = "@p41",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "grado",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p42",
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
				.ParameterName = "@p43",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "profesion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p44",
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
				.ParameterName = "@p45",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p46",
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
				.ParameterName = "@p47",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p48",
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
				.ParameterName = "@p49",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "email",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p50",
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
				.ParameterName = "@p51",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "codigo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p52",
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
				.ParameterName = "@p53",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "direccion",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p54",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p55",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p56",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p57",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p58",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p59",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p60",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p61",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_padre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p62",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p63",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nombre_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p64",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p65",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_trabajo_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p66",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p67",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_madre",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p68",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p69",
				.DbType = DbType.[Date],
				.MySqlDbType = MySqlDbType.[Date],
				.IsNullable = True,
				.SourceColumn = "fecha_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p70",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p71",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "edad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p72",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p73",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "sexo",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p74",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p75",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p76",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p77",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "nacionalidad",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p78",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p79",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "emergencia",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p80",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p81",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "telefono_emergencia",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p82",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p83",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "depto_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p84",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p85",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "municipio_nac",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p86",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p87",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "condicionado",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p88",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p89",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "repitente",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p90",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p91",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "colegio_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p92",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p93",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "curso_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p94",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p95",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "modalidad_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p96",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p97",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "anio_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p98",
				.DbType = DbType.Int32,
				.MySqlDbType = MySqlDbType.Int32,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Original,
				.SourceColumnNullMapping = True
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
			mySqlParameter = New MySql.Data.MySqlClient.MySqlParameter() With
			{
				.ParameterName = "@p99",
				.DbType = DbType.[String],
				.MySqlDbType = MySqlDbType.VarChar,
				.IsNullable = True,
				.SourceColumn = "lugar_anterior",
				.SourceVersion = DataRowVersion.Original
			}
			Me._adapter.UpdateCommand.Parameters.Add(mySqlParameter)
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitCommandCollection()
			Me._commandCollection = New MySqlCommand() { New MySqlCommand() }
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT `id_matricula`, `nombre`, `identidad_alumno`, `idp`, `grado`, `profesion`, `padre`, `telefono`, `email`, `codigo`, `direccion`, `lugar_trabajo`, `nombre_padre`, `lugar_trabajo_padre`, `telefono_padre`, `nombre_madre`, `lugar_trabajo_madre`, `telefono_madre`, `fecha_nac`, `edad`, `sexo`, `modalidad`, `nacionalidad`, `emergencia`, `telefono_emergencia`, `depto_nac`, `municipio_nac`, `condicionado`, `repitente`, `colegio_anterior`, `curso_anterior`, `modalidad_anterior`, `anio_anterior`, `lugar_anterior` FROM `matricula2`"
			Me._commandCollection(0).CommandType = CommandType.Text
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitConnection()
            Me._connection = New MySqlConnection() With
            {
                .ConnectionString = My.MySettings.[Default].chrilyhd_matriculaagzConnectionString
            }
        End Sub

		<DataObjectMethod(DataObjectMethodType.Insert, True)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Insert(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String, ByVal p8 As String, ByVal p9 As String, ByVal p10 As String, ByVal p11 As String, ByVal p12 As String, ByVal p13 As String, ByVal p14 As String, ByVal p15 As String, ByVal p16 As String, ByVal p17 As String, ByVal p18 As Nullable(Of DateTime), ByVal p19 As String, ByVal p20 As String, ByVal p21 As String, ByVal p22 As String, ByVal p23 As String, ByVal p24 As String, ByVal p25 As String, ByVal p26 As String, ByVal p27 As String, ByVal p28 As String, ByVal p29 As String, ByVal p30 As String, ByVal p31 As String, ByVal p32 As String, ByVal p33 As String) As Integer
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
			If (p11 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(10).Value = p11
			Else
				Me.Adapter.InsertCommand.Parameters(10).Value = DBNull.Value
			End If
			If (p12 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(11).Value = p12
			Else
				Me.Adapter.InsertCommand.Parameters(11).Value = DBNull.Value
			End If
			If (p13 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(12).Value = p13
			Else
				Me.Adapter.InsertCommand.Parameters(12).Value = DBNull.Value
			End If
			If (p14 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(13).Value = p14
			Else
				Me.Adapter.InsertCommand.Parameters(13).Value = DBNull.Value
			End If
			If (p15 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(14).Value = p15
			Else
				Me.Adapter.InsertCommand.Parameters(14).Value = DBNull.Value
			End If
			If (p16 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(15).Value = p16
			Else
				Me.Adapter.InsertCommand.Parameters(15).Value = DBNull.Value
			End If
			If (p17 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(16).Value = p17
			Else
				Me.Adapter.InsertCommand.Parameters(16).Value = DBNull.Value
			End If
			If (Not p18.HasValue) Then
				Me.Adapter.InsertCommand.Parameters(17).Value = DBNull.Value
			Else
				Me.Adapter.InsertCommand.Parameters(17).Value = p18.Value
			End If
			If (p19 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(18).Value = p19
			Else
				Me.Adapter.InsertCommand.Parameters(18).Value = DBNull.Value
			End If
			If (p20 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(19).Value = p20
			Else
				Me.Adapter.InsertCommand.Parameters(19).Value = DBNull.Value
			End If
			If (p21 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(20).Value = p21
			Else
				Me.Adapter.InsertCommand.Parameters(20).Value = DBNull.Value
			End If
			If (p22 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(21).Value = p22
			Else
				Me.Adapter.InsertCommand.Parameters(21).Value = DBNull.Value
			End If
			If (p23 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(22).Value = p23
			Else
				Me.Adapter.InsertCommand.Parameters(22).Value = DBNull.Value
			End If
			If (p24 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(23).Value = p24
			Else
				Me.Adapter.InsertCommand.Parameters(23).Value = DBNull.Value
			End If
			If (p25 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(24).Value = p25
			Else
				Me.Adapter.InsertCommand.Parameters(24).Value = DBNull.Value
			End If
			If (p26 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(25).Value = p26
			Else
				Me.Adapter.InsertCommand.Parameters(25).Value = DBNull.Value
			End If
			If (p27 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(26).Value = p27
			Else
				Me.Adapter.InsertCommand.Parameters(26).Value = DBNull.Value
			End If
			If (p28 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(27).Value = p28
			Else
				Me.Adapter.InsertCommand.Parameters(27).Value = DBNull.Value
			End If
			If (p29 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(28).Value = p29
			Else
				Me.Adapter.InsertCommand.Parameters(28).Value = DBNull.Value
			End If
			If (p30 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(29).Value = p30
			Else
				Me.Adapter.InsertCommand.Parameters(29).Value = DBNull.Value
			End If
			If (p31 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(30).Value = p31
			Else
				Me.Adapter.InsertCommand.Parameters(30).Value = DBNull.Value
			End If
			If (p32 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(31).Value = p32
			Else
				Me.Adapter.InsertCommand.Parameters(31).Value = DBNull.Value
			End If
			If (p33 IsNot Nothing) Then
				Me.Adapter.InsertCommand.Parameters(32).Value = p33
			Else
				Me.Adapter.InsertCommand.Parameters(32).Value = DBNull.Value
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
		Public Overridable Function Update(ByVal dataTable As chrilyhd_matriculaagzDataSet1.matricula2DataTable) As Integer
			Return Me.Adapter.Update(dataTable)
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		<HelpKeyword("vs.data.TableAdapter")>
		Public Overridable Function Update(ByVal dataSet As chrilyhd_matriculaagzDataSet1) As Integer
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
		Public Overridable Function Update(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String, ByVal p8 As String, ByVal p9 As String, ByVal p10 As String, ByVal p11 As String, ByVal p12 As String, ByVal p13 As String, ByVal p14 As String, ByVal p15 As String, ByVal p16 As String, ByVal p17 As String, ByVal p18 As Nullable(Of DateTime), ByVal p19 As String, ByVal p20 As String, ByVal p21 As String, ByVal p22 As String, ByVal p23 As String, ByVal p24 As String, ByVal p25 As String, ByVal p26 As String, ByVal p27 As String, ByVal p28 As String, ByVal p29 As String, ByVal p30 As String, ByVal p31 As String, ByVal p32 As String, ByVal p33 As String, ByVal p34 As Integer, ByVal p35 As String, ByVal p37 As String, ByVal p39 As String, ByVal p41 As String, ByVal p43 As String, ByVal p45 As String, ByVal p47 As String, ByVal p49 As String, ByVal p51 As String, ByVal p53 As String, ByVal p55 As String, ByVal p57 As String, ByVal p59 As String, ByVal p61 As String, ByVal p63 As String, ByVal p65 As String, ByVal p67 As String, ByVal p69 As Nullable(Of DateTime), ByVal p71 As String, ByVal p73 As String, ByVal p75 As String, ByVal p77 As String, ByVal p79 As String, ByVal p81 As String, ByVal p83 As String, ByVal p85 As String, ByVal p87 As String, ByVal p89 As String, ByVal p91 As String, ByVal p93 As String, ByVal p95 As String, ByVal p97 As String, ByVal p99 As String) As Integer
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
			If (p11 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(10).Value = p11
			Else
				Me.Adapter.UpdateCommand.Parameters(10).Value = DBNull.Value
			End If
			If (p12 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(11).Value = p12
			Else
				Me.Adapter.UpdateCommand.Parameters(11).Value = DBNull.Value
			End If
			If (p13 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(12).Value = p13
			Else
				Me.Adapter.UpdateCommand.Parameters(12).Value = DBNull.Value
			End If
			If (p14 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(13).Value = p14
			Else
				Me.Adapter.UpdateCommand.Parameters(13).Value = DBNull.Value
			End If
			If (p15 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(14).Value = p15
			Else
				Me.Adapter.UpdateCommand.Parameters(14).Value = DBNull.Value
			End If
			If (p16 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(15).Value = p16
			Else
				Me.Adapter.UpdateCommand.Parameters(15).Value = DBNull.Value
			End If
			If (p17 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(16).Value = p17
			Else
				Me.Adapter.UpdateCommand.Parameters(16).Value = DBNull.Value
			End If
			If (Not p18.HasValue) Then
				Me.Adapter.UpdateCommand.Parameters(17).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(17).Value = p18.Value
			End If
			If (p19 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(18).Value = p19
			Else
				Me.Adapter.UpdateCommand.Parameters(18).Value = DBNull.Value
			End If
			If (p20 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(19).Value = p20
			Else
				Me.Adapter.UpdateCommand.Parameters(19).Value = DBNull.Value
			End If
			If (p21 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(20).Value = p21
			Else
				Me.Adapter.UpdateCommand.Parameters(20).Value = DBNull.Value
			End If
			If (p22 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(21).Value = p22
			Else
				Me.Adapter.UpdateCommand.Parameters(21).Value = DBNull.Value
			End If
			If (p23 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(22).Value = p23
			Else
				Me.Adapter.UpdateCommand.Parameters(22).Value = DBNull.Value
			End If
			If (p24 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(23).Value = p24
			Else
				Me.Adapter.UpdateCommand.Parameters(23).Value = DBNull.Value
			End If
			If (p25 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(24).Value = p25
			Else
				Me.Adapter.UpdateCommand.Parameters(24).Value = DBNull.Value
			End If
			If (p26 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(25).Value = p26
			Else
				Me.Adapter.UpdateCommand.Parameters(25).Value = DBNull.Value
			End If
			If (p27 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(26).Value = p27
			Else
				Me.Adapter.UpdateCommand.Parameters(26).Value = DBNull.Value
			End If
			If (p28 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(27).Value = p28
			Else
				Me.Adapter.UpdateCommand.Parameters(27).Value = DBNull.Value
			End If
			If (p29 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(28).Value = p29
			Else
				Me.Adapter.UpdateCommand.Parameters(28).Value = DBNull.Value
			End If
			If (p30 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(29).Value = p30
			Else
				Me.Adapter.UpdateCommand.Parameters(29).Value = DBNull.Value
			End If
			If (p31 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(30).Value = p31
			Else
				Me.Adapter.UpdateCommand.Parameters(30).Value = DBNull.Value
			End If
			If (p32 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(31).Value = p32
			Else
				Me.Adapter.UpdateCommand.Parameters(31).Value = DBNull.Value
			End If
			If (p33 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(32).Value = p33
			Else
				Me.Adapter.UpdateCommand.Parameters(32).Value = DBNull.Value
			End If
			Me.Adapter.UpdateCommand.Parameters(33).Value = p34
			If (p35 Is Nothing) Then
				Throw New ArgumentNullException("p35")
			End If
			Me.Adapter.UpdateCommand.Parameters(34).Value = p35
			If (p37 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(35).Value = 0
				Me.Adapter.UpdateCommand.Parameters(36).Value = p37
			Else
				Me.Adapter.UpdateCommand.Parameters(35).Value = 1
				Me.Adapter.UpdateCommand.Parameters(36).Value = DBNull.Value
			End If
			If (p39 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(37).Value = 0
				Me.Adapter.UpdateCommand.Parameters(38).Value = p39
			Else
				Me.Adapter.UpdateCommand.Parameters(37).Value = 1
				Me.Adapter.UpdateCommand.Parameters(38).Value = DBNull.Value
			End If
			If (p41 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(39).Value = 0
				Me.Adapter.UpdateCommand.Parameters(40).Value = p41
			Else
				Me.Adapter.UpdateCommand.Parameters(39).Value = 1
				Me.Adapter.UpdateCommand.Parameters(40).Value = DBNull.Value
			End If
			If (p43 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(41).Value = 0
				Me.Adapter.UpdateCommand.Parameters(42).Value = p43
			Else
				Me.Adapter.UpdateCommand.Parameters(41).Value = 1
				Me.Adapter.UpdateCommand.Parameters(42).Value = DBNull.Value
			End If
			If (p45 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(43).Value = 0
				Me.Adapter.UpdateCommand.Parameters(44).Value = p45
			Else
				Me.Adapter.UpdateCommand.Parameters(43).Value = 1
				Me.Adapter.UpdateCommand.Parameters(44).Value = DBNull.Value
			End If
			If (p47 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(45).Value = 0
				Me.Adapter.UpdateCommand.Parameters(46).Value = p47
			Else
				Me.Adapter.UpdateCommand.Parameters(45).Value = 1
				Me.Adapter.UpdateCommand.Parameters(46).Value = DBNull.Value
			End If
			If (p49 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(47).Value = 0
				Me.Adapter.UpdateCommand.Parameters(48).Value = p49
			Else
				Me.Adapter.UpdateCommand.Parameters(47).Value = 1
				Me.Adapter.UpdateCommand.Parameters(48).Value = DBNull.Value
			End If
			If (p51 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(49).Value = 0
				Me.Adapter.UpdateCommand.Parameters(50).Value = p51
			Else
				Me.Adapter.UpdateCommand.Parameters(49).Value = 1
				Me.Adapter.UpdateCommand.Parameters(50).Value = DBNull.Value
			End If
			If (p53 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(51).Value = 0
				Me.Adapter.UpdateCommand.Parameters(52).Value = p53
			Else
				Me.Adapter.UpdateCommand.Parameters(51).Value = 1
				Me.Adapter.UpdateCommand.Parameters(52).Value = DBNull.Value
			End If
			If (p55 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(53).Value = 0
				Me.Adapter.UpdateCommand.Parameters(54).Value = p55
			Else
				Me.Adapter.UpdateCommand.Parameters(53).Value = 1
				Me.Adapter.UpdateCommand.Parameters(54).Value = DBNull.Value
			End If
			If (p57 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(55).Value = 0
				Me.Adapter.UpdateCommand.Parameters(56).Value = p57
			Else
				Me.Adapter.UpdateCommand.Parameters(55).Value = 1
				Me.Adapter.UpdateCommand.Parameters(56).Value = DBNull.Value
			End If
			If (p59 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(57).Value = 0
				Me.Adapter.UpdateCommand.Parameters(58).Value = p59
			Else
				Me.Adapter.UpdateCommand.Parameters(57).Value = 1
				Me.Adapter.UpdateCommand.Parameters(58).Value = DBNull.Value
			End If
			If (p61 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(59).Value = 0
				Me.Adapter.UpdateCommand.Parameters(60).Value = p61
			Else
				Me.Adapter.UpdateCommand.Parameters(59).Value = 1
				Me.Adapter.UpdateCommand.Parameters(60).Value = DBNull.Value
			End If
			If (p63 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(61).Value = 0
				Me.Adapter.UpdateCommand.Parameters(62).Value = p63
			Else
				Me.Adapter.UpdateCommand.Parameters(61).Value = 1
				Me.Adapter.UpdateCommand.Parameters(62).Value = DBNull.Value
			End If
			If (p65 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(63).Value = 0
				Me.Adapter.UpdateCommand.Parameters(64).Value = p65
			Else
				Me.Adapter.UpdateCommand.Parameters(63).Value = 1
				Me.Adapter.UpdateCommand.Parameters(64).Value = DBNull.Value
			End If
			If (p67 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(65).Value = 0
				Me.Adapter.UpdateCommand.Parameters(66).Value = p67
			Else
				Me.Adapter.UpdateCommand.Parameters(65).Value = 1
				Me.Adapter.UpdateCommand.Parameters(66).Value = DBNull.Value
			End If
			If (Not p69.HasValue) Then
				Me.Adapter.UpdateCommand.Parameters(67).Value = 1
				Me.Adapter.UpdateCommand.Parameters(68).Value = DBNull.Value
			Else
				Me.Adapter.UpdateCommand.Parameters(67).Value = 0
				Me.Adapter.UpdateCommand.Parameters(68).Value = p69.Value
			End If
			If (p71 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(69).Value = 0
				Me.Adapter.UpdateCommand.Parameters(70).Value = p71
			Else
				Me.Adapter.UpdateCommand.Parameters(69).Value = 1
				Me.Adapter.UpdateCommand.Parameters(70).Value = DBNull.Value
			End If
			If (p73 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(71).Value = 0
				Me.Adapter.UpdateCommand.Parameters(72).Value = p73
			Else
				Me.Adapter.UpdateCommand.Parameters(71).Value = 1
				Me.Adapter.UpdateCommand.Parameters(72).Value = DBNull.Value
			End If
			If (p75 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(73).Value = 0
				Me.Adapter.UpdateCommand.Parameters(74).Value = p75
			Else
				Me.Adapter.UpdateCommand.Parameters(73).Value = 1
				Me.Adapter.UpdateCommand.Parameters(74).Value = DBNull.Value
			End If
			If (p77 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(75).Value = 0
				Me.Adapter.UpdateCommand.Parameters(76).Value = p77
			Else
				Me.Adapter.UpdateCommand.Parameters(75).Value = 1
				Me.Adapter.UpdateCommand.Parameters(76).Value = DBNull.Value
			End If
			If (p79 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(77).Value = 0
				Me.Adapter.UpdateCommand.Parameters(78).Value = p79
			Else
				Me.Adapter.UpdateCommand.Parameters(77).Value = 1
				Me.Adapter.UpdateCommand.Parameters(78).Value = DBNull.Value
			End If
			If (p81 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(79).Value = 0
				Me.Adapter.UpdateCommand.Parameters(80).Value = p81
			Else
				Me.Adapter.UpdateCommand.Parameters(79).Value = 1
				Me.Adapter.UpdateCommand.Parameters(80).Value = DBNull.Value
			End If
			If (p83 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(81).Value = 0
				Me.Adapter.UpdateCommand.Parameters(82).Value = p83
			Else
				Me.Adapter.UpdateCommand.Parameters(81).Value = 1
				Me.Adapter.UpdateCommand.Parameters(82).Value = DBNull.Value
			End If
			If (p85 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(83).Value = 0
				Me.Adapter.UpdateCommand.Parameters(84).Value = p85
			Else
				Me.Adapter.UpdateCommand.Parameters(83).Value = 1
				Me.Adapter.UpdateCommand.Parameters(84).Value = DBNull.Value
			End If
			If (p87 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(85).Value = 0
				Me.Adapter.UpdateCommand.Parameters(86).Value = p87
			Else
				Me.Adapter.UpdateCommand.Parameters(85).Value = 1
				Me.Adapter.UpdateCommand.Parameters(86).Value = DBNull.Value
			End If
			If (p89 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(87).Value = 0
				Me.Adapter.UpdateCommand.Parameters(88).Value = p89
			Else
				Me.Adapter.UpdateCommand.Parameters(87).Value = 1
				Me.Adapter.UpdateCommand.Parameters(88).Value = DBNull.Value
			End If
			If (p91 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(89).Value = 0
				Me.Adapter.UpdateCommand.Parameters(90).Value = p91
			Else
				Me.Adapter.UpdateCommand.Parameters(89).Value = 1
				Me.Adapter.UpdateCommand.Parameters(90).Value = DBNull.Value
			End If
			If (p93 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(91).Value = 0
				Me.Adapter.UpdateCommand.Parameters(92).Value = p93
			Else
				Me.Adapter.UpdateCommand.Parameters(91).Value = 1
				Me.Adapter.UpdateCommand.Parameters(92).Value = DBNull.Value
			End If
			If (p95 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(93).Value = 0
				Me.Adapter.UpdateCommand.Parameters(94).Value = p95
			Else
				Me.Adapter.UpdateCommand.Parameters(93).Value = 1
				Me.Adapter.UpdateCommand.Parameters(94).Value = DBNull.Value
			End If
			If (p97 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(95).Value = 0
				Me.Adapter.UpdateCommand.Parameters(96).Value = p97
			Else
				Me.Adapter.UpdateCommand.Parameters(95).Value = 1
				Me.Adapter.UpdateCommand.Parameters(96).Value = DBNull.Value
			End If
			If (p99 IsNot Nothing) Then
				Me.Adapter.UpdateCommand.Parameters(97).Value = 0
				Me.Adapter.UpdateCommand.Parameters(98).Value = p99
			Else
				Me.Adapter.UpdateCommand.Parameters(97).Value = 1
				Me.Adapter.UpdateCommand.Parameters(98).Value = DBNull.Value
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