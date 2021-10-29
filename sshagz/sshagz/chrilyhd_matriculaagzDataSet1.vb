Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Threading
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Namespace ssh
	<DesignerCategory("code")>
	<HelpKeyword("vs.data.DataSet")>
	<Serializable>
	<ToolboxItem(True)>
	<XmlRoot("chrilyhd_matriculaagzDataSet1")>
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	Public Class chrilyhd_matriculaagzDataSet1
		Inherits DataSet
		Private tablematricula As chrilyhd_matriculaagzDataSet1.matriculaDataTable

		Private tablematricula2 As chrilyhd_matriculaagzDataSet1.matricula2DataTable

		Private _schemaSerializationMode As System.Data.SchemaSerializationMode

		<Browsable(False)>
		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public ReadOnly Property matricula As chrilyhd_matriculaagzDataSet1.matriculaDataTable
			Get
				Return Me.tablematricula
			End Get
		End Property

		<Browsable(False)>
		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public ReadOnly Property matricula2 As chrilyhd_matriculaagzDataSet1.matricula2DataTable
			Get
				Return Me.tablematricula2
			End Get
		End Property

		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Shadows ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<Browsable(True)>
		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Overrides Property SchemaSerializationMode As System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Shadows ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Sub New()
			MyBase.New()
			Me._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			MyBase.BeginInit()
			Me.InitClass()
			Dim collectionChangeEventHandler As System.ComponentModel.CollectionChangeEventHandler = New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged,  collectionChangeEventHandler
			AddHandler MyBase.Relations.CollectionChanged,  collectionChangeEventHandler
			MyBase.EndInit()
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context, False)
			Me._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			If (Not MyBase.IsBinarySerialized(info, context)) Then
				Dim str As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
				If (MyBase.DetermineSchemaSerializationMode(info, context) <> System.Data.SchemaSerializationMode.IncludeSchema) Then
					MyBase.ReadXmlSchema(New XmlTextReader(New StringReader(str)))
				Else
					Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
					dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(str)))
					If (dataSet.Tables("matricula") IsNot Nothing) Then
						MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet1.matriculaDataTable(dataSet.Tables("matricula")))
					End If
					If (dataSet.Tables("matricula2") IsNot Nothing) Then
						MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet1.matricula2DataTable(dataSet.Tables("matricula2")))
					End If
					MyBase.DataSetName = dataSet.DataSetName
					MyBase.Prefix = dataSet.Prefix
					MyBase.[Namespace] = dataSet.[Namespace]
					MyBase.Locale = dataSet.Locale
					MyBase.CaseSensitive = dataSet.CaseSensitive
					MyBase.EnforceConstraints = dataSet.EnforceConstraints
					MyBase.Merge(dataSet, False, MissingSchemaAction.Add)
					Me.InitVars()
				End If
				MyBase.GetSerializationData(info, context)
				Dim collectionChangeEventHandler As System.ComponentModel.CollectionChangeEventHandler = New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler MyBase.Tables.CollectionChanged,  collectionChangeEventHandler
				AddHandler Me.Relations.CollectionChanged,  collectionChangeEventHandler
			Else
				Me.InitVars(False)
				Dim collectionChangeEventHandler1 As System.ComponentModel.CollectionChangeEventHandler = New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged,  collectionChangeEventHandler1
				AddHandler Me.Relations.CollectionChanged,  collectionChangeEventHandler1
			End If
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Overrides Function Clone() As DataSet
			Dim schemaSerializationMode As chrilyhd_matriculaagzDataSet1 = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet1)
			schemaSerializationMode.InitVars()
			schemaSerializationMode.SchemaSerializationMode = Me.SchemaSerializationMode
			Return schemaSerializationMode
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
			Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
			MyBase.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = CLng(0)
			Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Shared Function GetTypedDataSetSchema(ByVal xs As XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
			Dim xmlSchemaComplexType As System.Xml.Schema.XmlSchemaComplexType
			Dim chrilyhdMatriculaagzDataSet1 As chrilyhd_matriculaagzDataSet1 = New chrilyhd_matriculaagzDataSet1()
			Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
			Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
			Dim xmlSchemaAny As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
			{
				.[Namespace] = chrilyhdMatriculaagzDataSet1.[Namespace]
			}
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType1.Particle = xmlSchemaSequence
			Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet1.GetSchemaSerializable()
			If (xs.Contains(schemaSerializable.TargetNamespace)) Then
				Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
				Dim memoryStream1 As System.IO.MemoryStream = New System.IO.MemoryStream()
				Try
					Dim current As System.Xml.Schema.XmlSchema = Nothing
					schemaSerializable.Write(memoryStream)
					Dim enumerator As IEnumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator()
					While enumerator.MoveNext()
						current = DirectCast(enumerator.Current, System.Xml.Schema.XmlSchema)
						memoryStream1.SetLength(CLng(0))
						current.Write(memoryStream1)
						If (memoryStream.Length = memoryStream1.Length) Then
							memoryStream.Position = CLng(0)
							memoryStream1.Position = CLng(0)
							While True
								If (If(memoryStream.Position = memoryStream.Length, True, memoryStream.ReadByte() <> memoryStream1.ReadByte())) Then
									Exit While
								End If
							End While
							If (memoryStream.Position = memoryStream.Length) Then
								xmlSchemaComplexType = xmlSchemaComplexType1
								Return xmlSchemaComplexType
							End If
						End If
					End While
				Finally
					If (memoryStream IsNot Nothing) Then
						memoryStream.Close()
					End If
					If (memoryStream1 IsNot Nothing) Then
						memoryStream1.Close()
					End If
				End Try
			End If
			xs.Add(schemaSerializable)
			xmlSchemaComplexType = xmlSchemaComplexType1
			Return xmlSchemaComplexType
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub InitClass()
			MyBase.DataSetName = "chrilyhd_matriculaagzDataSet1"
			MyBase.Prefix = ""
			MyBase.[Namespace] = "http://tempuri.org/chrilyhd_matriculaagzDataSet1.xsd"
			MyBase.EnforceConstraints = True
			Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			Me.tablematricula = New chrilyhd_matriculaagzDataSet1.matriculaDataTable()
			MyBase.Tables.Add(Me.tablematricula)
			Me.tablematricula2 = New chrilyhd_matriculaagzDataSet1.matricula2DataTable()
			MyBase.Tables.Add(Me.tablematricula2)
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overrides Sub InitializeDerivedDataSet()
			MyBase.BeginInit()
			Me.InitClass()
			MyBase.EndInit()
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tablematricula = DirectCast(MyBase.Tables("matricula"), chrilyhd_matriculaagzDataSet1.matriculaDataTable)
			If (initTable) Then
				If (Me.tablematricula IsNot Nothing) Then
					Me.tablematricula.InitVars()
				End If
			End If
			Me.tablematricula2 = DirectCast(MyBase.Tables("matricula2"), chrilyhd_matriculaagzDataSet1.matricula2DataTable)
			If (initTable) Then
				If (Me.tablematricula2 IsNot Nothing) Then
					Me.tablematricula2.InitVars()
				End If
			End If
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
			If (MyBase.DetermineSchemaSerializationMode(reader) <> System.Data.SchemaSerializationMode.IncludeSchema) Then
				MyBase.ReadXml(reader)
				Me.InitVars()
			Else
				Me.Reset()
				Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
				dataSet.ReadXml(reader)
				If (dataSet.Tables("matricula") IsNot Nothing) Then
					MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet1.matriculaDataTable(dataSet.Tables("matricula")))
				End If
				If (dataSet.Tables("matricula2") IsNot Nothing) Then
					MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet1.matricula2DataTable(dataSet.Tables("matricula2")))
				End If
				MyBase.DataSetName = dataSet.DataSetName
				MyBase.Prefix = dataSet.Prefix
				MyBase.[Namespace] = dataSet.[Namespace]
				MyBase.Locale = dataSet.Locale
				MyBase.CaseSensitive = dataSet.CaseSensitive
				MyBase.EnforceConstraints = dataSet.EnforceConstraints
				MyBase.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
			If (e.Action = CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function ShouldSerializematricula() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function ShouldSerializematricula2() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<Serializable>
		<XmlSchemaProvider("GetTypedTableSchema")>
		Public Class matricula2DataTable
			Inherits TypedTableBase(Of chrilyhd_matriculaagzDataSet1.matricula2Row)
			Private columnid_matricula As DataColumn

			Private columnnombre As DataColumn

			Private columnidentidad_alumno As DataColumn

			Private columnidp As DataColumn

			Private columngrado As DataColumn

			Private columnprofesion As DataColumn

			Private columnpadre As DataColumn

			Private columntelefono As DataColumn

			Private columnemail As DataColumn

			Private columncodigo As DataColumn

			Private columndireccion As DataColumn

			Private columnlugar_trabajo As DataColumn

			Private columnnombre_padre As DataColumn

			Private columnlugar_trabajo_padre As DataColumn

			Private columntelefono_padre As DataColumn

			Private columnnombre_madre As DataColumn

			Private columnlugar_trabajo_madre As DataColumn

			Private columntelefono_madre As DataColumn

			Private columnfecha_nac As DataColumn

			Private columnedad As DataColumn

			Private columnsexo As DataColumn

			Private columnmodalidad As DataColumn

			Private columnnacionalidad As DataColumn

			Private columnemergencia As DataColumn

			Private columntelefono_emergencia As DataColumn

			Private columndepto_nac As DataColumn

			Private columnmunicipio_nac As DataColumn

			Private columncondicionado As DataColumn

			Private columnrepitente As DataColumn

			Private columncolegio_anterior As DataColumn

			Private columncurso_anterior As DataColumn

			Private columnmodalidad_anterior As DataColumn

			Private columnanio_anterior As DataColumn

			Private columnlugar_anterior As DataColumn

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property anio_anteriorColumn As DataColumn
				Get
					Return Me.columnanio_anterior
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property codigoColumn As DataColumn
				Get
					Return Me.columncodigo
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property colegio_anteriorColumn As DataColumn
				Get
					Return Me.columncolegio_anterior
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property condicionadoColumn As DataColumn
				Get
					Return Me.columncondicionado
				End Get
			End Property

			<Browsable(False)>
			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property curso_anteriorColumn As DataColumn
				Get
					Return Me.columncurso_anterior
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property depto_nacColumn As DataColumn
				Get
					Return Me.columndepto_nac
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property direccionColumn As DataColumn
				Get
					Return Me.columndireccion
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property edadColumn As DataColumn
				Get
					Return Me.columnedad
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property emailColumn As DataColumn
				Get
					Return Me.columnemail
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property emergenciaColumn As DataColumn
				Get
					Return Me.columnemergencia
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property fecha_nacColumn As DataColumn
				Get
					Return Me.columnfecha_nac
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property gradoColumn As DataColumn
				Get
					Return Me.columngrado
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property id_matriculaColumn As DataColumn
				Get
					Return Me.columnid_matricula
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property identidad_alumnoColumn As DataColumn
				Get
					Return Me.columnidentidad_alumno
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property idpColumn As DataColumn
				Get
					Return Me.columnidp
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Default Public ReadOnly Property Item(ByVal index As Integer) As chrilyhd_matriculaagzDataSet1.matricula2Row
				Get
					Return DirectCast(MyBase.Rows(index), chrilyhd_matriculaagzDataSet1.matricula2Row)
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property lugar_anteriorColumn As DataColumn
				Get
					Return Me.columnlugar_anterior
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property lugar_trabajo_madreColumn As DataColumn
				Get
					Return Me.columnlugar_trabajo_madre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property lugar_trabajo_padreColumn As DataColumn
				Get
					Return Me.columnlugar_trabajo_padre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property lugar_trabajoColumn As DataColumn
				Get
					Return Me.columnlugar_trabajo
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property modalidad_anteriorColumn As DataColumn
				Get
					Return Me.columnmodalidad_anterior
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property modalidadColumn As DataColumn
				Get
					Return Me.columnmodalidad
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property municipio_nacColumn As DataColumn
				Get
					Return Me.columnmunicipio_nac
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property nacionalidadColumn As DataColumn
				Get
					Return Me.columnnacionalidad
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property nombre_madreColumn As DataColumn
				Get
					Return Me.columnnombre_madre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property nombre_padreColumn As DataColumn
				Get
					Return Me.columnnombre_padre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property nombreColumn As DataColumn
				Get
					Return Me.columnnombre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property padreColumn As DataColumn
				Get
					Return Me.columnpadre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property profesionColumn As DataColumn
				Get
					Return Me.columnprofesion
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property repitenteColumn As DataColumn
				Get
					Return Me.columnrepitente
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property sexoColumn As DataColumn
				Get
					Return Me.columnsexo
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property telefono_emergenciaColumn As DataColumn
				Get
					Return Me.columntelefono_emergencia
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property telefono_madreColumn As DataColumn
				Get
					Return Me.columntelefono_madre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property telefono_padreColumn As DataColumn
				Get
					Return Me.columntelefono_padre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property telefonoColumn As DataColumn
				Get
					Return Me.columntelefono
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New()
				MyBase.New()
				MyBase.TableName = "matricula2"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub New(ByVal table As DataTable)
				MyBase.New()
				MyBase.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0) Then
					MyBase.Locale = table.Locale
				End If
				If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0) Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Addmatricula2Row(ByVal row As chrilyhd_matriculaagzDataSet1.matricula2Row)
				MyBase.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Addmatricula2Row(ByVal nombre As String, ByVal identidad_alumno As String, ByVal idp As String, ByVal grado As String, ByVal profesion As String, ByVal padre As String, ByVal telefono As String, ByVal email As String, ByVal codigo As String, ByVal direccion As String, ByVal lugar_trabajo As String, ByVal nombre_padre As String, ByVal lugar_trabajo_padre As String, ByVal telefono_padre As String, ByVal nombre_madre As String, ByVal lugar_trabajo_madre As String, ByVal telefono_madre As String, ByVal fecha_nac As DateTime, ByVal edad As String, ByVal sexo As String, ByVal modalidad As String, ByVal nacionalidad As String, ByVal emergencia As String, ByVal telefono_emergencia As String, ByVal depto_nac As String, ByVal municipio_nac As String, ByVal condicionado As String, ByVal repitente As String, ByVal colegio_anterior As String, ByVal curso_anterior As String, ByVal modalidad_anterior As String, ByVal anio_anterior As String, ByVal lugar_anterior As String) As chrilyhd_matriculaagzDataSet1.matricula2Row
				Dim _matricula2Row As chrilyhd_matriculaagzDataSet1.matricula2Row = DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet1.matricula2Row)
				_matricula2Row.ItemArray = New Object() { Nothing, nombre, identidad_alumno, idp, grado, profesion, padre, telefono, email, codigo, direccion, lugar_trabajo, nombre_padre, lugar_trabajo_padre, telefono_padre, nombre_madre, lugar_trabajo_madre, telefono_madre, fecha_nac, edad, sexo, modalidad, nacionalidad, emergencia, telefono_emergencia, depto_nac, municipio_nac, condicionado, repitente, colegio_anterior, curso_anterior, modalidad_anterior, anio_anterior, lugar_anterior }
				MyBase.Rows.Add(_matricula2Row)
				Return _matricula2Row
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim _matricula2DataTable As chrilyhd_matriculaagzDataSet1.matricula2DataTable = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet1.matricula2DataTable)
				_matricula2DataTable.InitVars()
				Return _matricula2DataTable
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New chrilyhd_matriculaagzDataSet1.matricula2DataTable()
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function FindByid_matricula(ByVal id_matricula As Integer) As chrilyhd_matriculaagzDataSet1.matricula2Row
				Return DirectCast(MyBase.Rows.Find(New Object() { id_matricula }), chrilyhd_matriculaagzDataSet1.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(chrilyhd_matriculaagzDataSet1.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
				Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
				Dim chrilyhdMatriculaagzDataSet1 As chrilyhd_matriculaagzDataSet1 = New chrilyhd_matriculaagzDataSet1()
				Dim xmlSchemaAny As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
				{
					.[Namespace] = "http://www.w3.org/2001/XMLSchema",
					.MinOccurs = New Decimal(0),
					.MaxOccurs = New Decimal(-1, -1, -1, False, 0),
					.ProcessContents = XmlSchemaContentProcessing.Lax
				}
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
				{
					.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1",
					.MinOccurs = New Decimal(1),
					.ProcessContents = XmlSchemaContentProcessing.Lax
				}
				xmlSchemaSequence.Items.Add(xmlSchemaAny1)
				Dim xmlSchemaAttribute As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "namespace",
					.FixedValue = chrilyhdMatriculaagzDataSet1.[Namespace]
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "tableTypeName",
					.FixedValue = "matricula2DataTable"
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1)
				xmlSchemaComplexType1.Particle = xmlSchemaSequence
				Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet1.GetSchemaSerializable()
				If (xs.Contains(schemaSerializable.TargetNamespace)) Then
					Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
					Dim memoryStream1 As System.IO.MemoryStream = New System.IO.MemoryStream()
					Try
						Dim current As System.Xml.Schema.XmlSchema = Nothing
						schemaSerializable.Write(memoryStream)
						Dim enumerator As IEnumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator()
						While enumerator.MoveNext()
							current = DirectCast(enumerator.Current, System.Xml.Schema.XmlSchema)
							memoryStream1.SetLength(CLng(0))
							current.Write(memoryStream1)
							If (memoryStream.Length = memoryStream1.Length) Then
								memoryStream.Position = CLng(0)
								memoryStream1.Position = CLng(0)
								While True
									If (If(memoryStream.Position = memoryStream.Length, True, memoryStream.ReadByte() <> memoryStream1.ReadByte())) Then
										Exit While
									End If
								End While
								If (memoryStream.Position = memoryStream.Length) Then
									xmlSchemaComplexType = xmlSchemaComplexType1
									Return xmlSchemaComplexType
								End If
							End If
						End While
					Finally
						If (memoryStream IsNot Nothing) Then
							memoryStream.Close()
						End If
						If (memoryStream1 IsNot Nothing) Then
							memoryStream1.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				xmlSchemaComplexType = xmlSchemaComplexType1
				Return xmlSchemaComplexType
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Private Sub InitClass()
				Me.columnid_matricula = New DataColumn("id_matricula", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid_matricula)
				Me.columnnombre = New DataColumn("nombre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnombre)
				Me.columnidentidad_alumno = New DataColumn("identidad_alumno", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnidentidad_alumno)
				Me.columnidp = New DataColumn("idp", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnidp)
				Me.columngrado = New DataColumn("grado", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columngrado)
				Me.columnprofesion = New DataColumn("profesion", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnprofesion)
				Me.columnpadre = New DataColumn("padre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnpadre)
				Me.columntelefono = New DataColumn("telefono", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntelefono)
				Me.columnemail = New DataColumn("email", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnemail)
				Me.columncodigo = New DataColumn("codigo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncodigo)
				Me.columndireccion = New DataColumn("direccion", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndireccion)
				Me.columnlugar_trabajo = New DataColumn("lugar_trabajo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlugar_trabajo)
				Me.columnnombre_padre = New DataColumn("nombre_padre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnombre_padre)
				Me.columnlugar_trabajo_padre = New DataColumn("lugar_trabajo_padre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlugar_trabajo_padre)
				Me.columntelefono_padre = New DataColumn("telefono_padre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntelefono_padre)
				Me.columnnombre_madre = New DataColumn("nombre_madre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnombre_madre)
				Me.columnlugar_trabajo_madre = New DataColumn("lugar_trabajo_madre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlugar_trabajo_madre)
				Me.columntelefono_madre = New DataColumn("telefono_madre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntelefono_madre)
				Me.columnfecha_nac = New DataColumn("fecha_nac", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnfecha_nac)
				Me.columnedad = New DataColumn("edad", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnedad)
				Me.columnsexo = New DataColumn("sexo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnsexo)
				Me.columnmodalidad = New DataColumn("modalidad", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmodalidad)
				Me.columnnacionalidad = New DataColumn("nacionalidad", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnacionalidad)
				Me.columnemergencia = New DataColumn("emergencia", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnemergencia)
				Me.columntelefono_emergencia = New DataColumn("telefono_emergencia", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntelefono_emergencia)
				Me.columndepto_nac = New DataColumn("depto_nac", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndepto_nac)
				Me.columnmunicipio_nac = New DataColumn("municipio_nac", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmunicipio_nac)
				Me.columncondicionado = New DataColumn("condicionado", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncondicionado)
				Me.columnrepitente = New DataColumn("repitente", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnrepitente)
				Me.columncolegio_anterior = New DataColumn("colegio_anterior", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncolegio_anterior)
				Me.columncurso_anterior = New DataColumn("curso_anterior", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncurso_anterior)
				Me.columnmodalidad_anterior = New DataColumn("modalidad_anterior", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnmodalidad_anterior)
				Me.columnanio_anterior = New DataColumn("anio_anterior", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnanio_anterior)
				Me.columnlugar_anterior = New DataColumn("lugar_anterior", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnlugar_anterior)
				MyBase.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() { Me.columnid_matricula }, True))
				Me.columnid_matricula.AutoIncrement = True
				Me.columnid_matricula.AutoIncrementSeed = CLng(-1)
				Me.columnid_matricula.AutoIncrementStep = CLng(-1)
				Me.columnid_matricula.AllowDBNull = False
				Me.columnid_matricula.Unique = True
				Me.columnnombre.AllowDBNull = False
				Me.columnnombre.MaxLength = 100
				Me.columnidentidad_alumno.MaxLength = 50
				Me.columnidp.MaxLength = 50
				Me.columngrado.MaxLength = 15
				Me.columnprofesion.MaxLength = 300
				Me.columnpadre.MaxLength = 100
				Me.columntelefono.MaxLength = 100
				Me.columnemail.MaxLength = 100
				Me.columncodigo.MaxLength = 25
				Me.columndireccion.MaxLength = 500
				Me.columnlugar_trabajo.MaxLength = 100
				Me.columnnombre_padre.MaxLength = 100
				Me.columnlugar_trabajo_padre.MaxLength = 100
				Me.columntelefono_padre.MaxLength = 100
				Me.columnnombre_madre.MaxLength = 100
				Me.columnlugar_trabajo_madre.MaxLength = 100
				Me.columntelefono_madre.MaxLength = 100
				Me.columnedad.MaxLength = 5
				Me.columnsexo.MaxLength = 15
				Me.columnmodalidad.MaxLength = 25
				Me.columnnacionalidad.MaxLength = 100
				Me.columnemergencia.MaxLength = 100
				Me.columntelefono_emergencia.MaxLength = 100
				Me.columndepto_nac.MaxLength = 100
				Me.columnmunicipio_nac.MaxLength = 100
				Me.columncondicionado.MaxLength = 2
				Me.columnrepitente.MaxLength = 2
				Me.columncolegio_anterior.MaxLength = 100
				Me.columncurso_anterior.MaxLength = 50
				Me.columnmodalidad_anterior.MaxLength = 25
				Me.columnanio_anterior.MaxLength = 4
				Me.columnlugar_anterior.MaxLength = 100
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub InitVars()
				Me.columnid_matricula = MyBase.Columns("id_matricula")
				Me.columnnombre = MyBase.Columns("nombre")
				Me.columnidentidad_alumno = MyBase.Columns("identidad_alumno")
				Me.columnidp = MyBase.Columns("idp")
				Me.columngrado = MyBase.Columns("grado")
				Me.columnprofesion = MyBase.Columns("profesion")
				Me.columnpadre = MyBase.Columns("padre")
				Me.columntelefono = MyBase.Columns("telefono")
				Me.columnemail = MyBase.Columns("email")
				Me.columncodigo = MyBase.Columns("codigo")
				Me.columndireccion = MyBase.Columns("direccion")
				Me.columnlugar_trabajo = MyBase.Columns("lugar_trabajo")
				Me.columnnombre_padre = MyBase.Columns("nombre_padre")
				Me.columnlugar_trabajo_padre = MyBase.Columns("lugar_trabajo_padre")
				Me.columntelefono_padre = MyBase.Columns("telefono_padre")
				Me.columnnombre_madre = MyBase.Columns("nombre_madre")
				Me.columnlugar_trabajo_madre = MyBase.Columns("lugar_trabajo_madre")
				Me.columntelefono_madre = MyBase.Columns("telefono_madre")
				Me.columnfecha_nac = MyBase.Columns("fecha_nac")
				Me.columnedad = MyBase.Columns("edad")
				Me.columnsexo = MyBase.Columns("sexo")
				Me.columnmodalidad = MyBase.Columns("modalidad")
				Me.columnnacionalidad = MyBase.Columns("nacionalidad")
				Me.columnemergencia = MyBase.Columns("emergencia")
				Me.columntelefono_emergencia = MyBase.Columns("telefono_emergencia")
				Me.columndepto_nac = MyBase.Columns("depto_nac")
				Me.columnmunicipio_nac = MyBase.Columns("municipio_nac")
				Me.columncondicionado = MyBase.Columns("condicionado")
				Me.columnrepitente = MyBase.Columns("repitente")
				Me.columncolegio_anterior = MyBase.Columns("colegio_anterior")
				Me.columncurso_anterior = MyBase.Columns("curso_anterior")
				Me.columnmodalidad_anterior = MyBase.Columns("modalidad_anterior")
				Me.columnanio_anterior = MyBase.Columns("anio_anterior")
				Me.columnlugar_anterior = MyBase.Columns("lugar_anterior")
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Newmatricula2Row() As chrilyhd_matriculaagzDataSet1.matricula2Row
				Return DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet1.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New chrilyhd_matriculaagzDataSet1.matricula2Row(builder)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matricula2DataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowChanged(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matricula2DataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowChanging(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matricula2DataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matricula2DataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Removematricula2Row(ByVal row As chrilyhd_matriculaagzDataSet1.matricula2Row)
				MyBase.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowChanged As chrilyhd_matriculaagzDataSet1.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowChanging As chrilyhd_matriculaagzDataSet1.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowDeleted As chrilyhd_matriculaagzDataSet1.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowDeleting As chrilyhd_matriculaagzDataSet1.matricula2RowChangeEventHandler
		End Class

		Public Class matricula2Row
			Inherits DataRow
			Private tablematricula2 As chrilyhd_matriculaagzDataSet1.matricula2DataTable

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property anio_anterior As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.anio_anteriorColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'anio_anterior' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.anio_anteriorColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property codigo As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.codigoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'codigo' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.codigoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property colegio_anterior As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.colegio_anteriorColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'colegio_anterior' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.colegio_anteriorColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property condicionado As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.condicionadoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'condicionado' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.condicionadoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property curso_anterior As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.curso_anteriorColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'curso_anterior' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.curso_anteriorColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property depto_nac As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.depto_nacColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'depto_nac' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.depto_nacColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property direccion As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.direccionColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'direccion' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.direccionColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property edad As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.edadColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'edad' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.edadColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property email As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.emailColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'email' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.emailColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property emergencia As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.emergenciaColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'emergencia' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.emergenciaColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property fecha_nac As DateTime
				Get
					Dim [date] As DateTime
					Try
						[date] = Conversions.ToDate(MyBase.Item(Me.tablematricula2.fecha_nacColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'fecha_nac' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return [date]
				End Get
				Set(ByVal value As DateTime)
					MyBase.Item(Me.tablematricula2.fecha_nacColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property grado As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.gradoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'grado' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.gradoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property id_matricula As Integer
				Get
					Return Conversions.ToInteger(MyBase.Item(Me.tablematricula2.id_matriculaColumn))
				End Get
				Set(ByVal value As Integer)
					MyBase.Item(Me.tablematricula2.id_matriculaColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property identidad_alumno As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.identidad_alumnoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'identidad_alumno' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.identidad_alumnoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property idp As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.idpColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'idp' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.idpColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property lugar_anterior As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.lugar_anteriorColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'lugar_anterior' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.lugar_anteriorColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property lugar_trabajo As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.lugar_trabajoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'lugar_trabajo' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.lugar_trabajoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property lugar_trabajo_madre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.lugar_trabajo_madreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'lugar_trabajo_madre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.lugar_trabajo_madreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property lugar_trabajo_padre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.lugar_trabajo_padreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'lugar_trabajo_padre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.lugar_trabajo_padreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property modalidad As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.modalidadColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'modalidad' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.modalidadColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property modalidad_anterior As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.modalidad_anteriorColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'modalidad_anterior' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.modalidad_anteriorColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property municipio_nac As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.municipio_nacColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'municipio_nac' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.municipio_nacColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property nacionalidad As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.nacionalidadColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'nacionalidad' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.nacionalidadColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property nombre As String
				Get
					Return Conversions.ToString(MyBase.Item(Me.tablematricula2.nombreColumn))
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.nombreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property nombre_madre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.nombre_madreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'nombre_madre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.nombre_madreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property nombre_padre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.nombre_padreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'nombre_padre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.nombre_padreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property padre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.padreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'padre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.padreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property profesion As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.profesionColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'profesion' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.profesionColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property repitente As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.repitenteColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'repitente' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.repitenteColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property sexo As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.sexoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'sexo' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.sexoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property telefono As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.telefonoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'telefono' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.telefonoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property telefono_emergencia As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.telefono_emergenciaColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'telefono_emergencia' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.telefono_emergenciaColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property telefono_madre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.telefono_madreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'telefono_madre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.telefono_madreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property telefono_padre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula2.telefono_padreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'telefono_padre' de la tabla 'matricula2' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula2.telefono_padreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tablematricula2 = DirectCast(MyBase.Table, chrilyhd_matriculaagzDataSet1.matricula2DataTable)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isanio_anteriorNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.anio_anteriorColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IscodigoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.codigoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Iscolegio_anteriorNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.colegio_anteriorColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IscondicionadoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.condicionadoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Iscurso_anteriorNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.curso_anteriorColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isdepto_nacNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.depto_nacColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsdireccionNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.direccionColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsedadNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.edadColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsemailNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.emailColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsemergenciaNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.emergenciaColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isfecha_nacNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.fecha_nacColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsgradoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.gradoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isidentidad_alumnoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.identidad_alumnoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsidpNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.idpColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Islugar_anteriorNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.lugar_anteriorColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Islugar_trabajo_madreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.lugar_trabajo_madreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Islugar_trabajo_padreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.lugar_trabajo_padreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Islugar_trabajoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.lugar_trabajoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Ismodalidad_anteriorNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.modalidad_anteriorColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsmodalidadNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.modalidadColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Ismunicipio_nacNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.municipio_nacColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsnacionalidadNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.nacionalidadColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isnombre_madreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.nombre_madreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isnombre_padreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.nombre_padreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IspadreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.padreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsprofesionNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.profesionColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsrepitenteNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.repitenteColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IssexoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.sexoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Istelefono_emergenciaNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.telefono_emergenciaColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Istelefono_madreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.telefono_madreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Istelefono_padreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.telefono_padreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IstelefonoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.telefonoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setanio_anteriorNull()
				MyBase.Item(Me.tablematricula2.anio_anteriorColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetcodigoNull()
				MyBase.Item(Me.tablematricula2.codigoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setcolegio_anteriorNull()
				MyBase.Item(Me.tablematricula2.colegio_anteriorColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetcondicionadoNull()
				MyBase.Item(Me.tablematricula2.condicionadoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setcurso_anteriorNull()
				MyBase.Item(Me.tablematricula2.curso_anteriorColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setdepto_nacNull()
				MyBase.Item(Me.tablematricula2.depto_nacColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetdireccionNull()
				MyBase.Item(Me.tablematricula2.direccionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetedadNull()
				MyBase.Item(Me.tablematricula2.edadColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetemailNull()
				MyBase.Item(Me.tablematricula2.emailColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetemergenciaNull()
				MyBase.Item(Me.tablematricula2.emergenciaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setfecha_nacNull()
				MyBase.Item(Me.tablematricula2.fecha_nacColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetgradoNull()
				MyBase.Item(Me.tablematricula2.gradoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setidentidad_alumnoNull()
				MyBase.Item(Me.tablematricula2.identidad_alumnoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetidpNull()
				MyBase.Item(Me.tablematricula2.idpColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setlugar_anteriorNull()
				MyBase.Item(Me.tablematricula2.lugar_anteriorColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setlugar_trabajo_madreNull()
				MyBase.Item(Me.tablematricula2.lugar_trabajo_madreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setlugar_trabajo_padreNull()
				MyBase.Item(Me.tablematricula2.lugar_trabajo_padreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setlugar_trabajoNull()
				MyBase.Item(Me.tablematricula2.lugar_trabajoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setmodalidad_anteriorNull()
				MyBase.Item(Me.tablematricula2.modalidad_anteriorColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetmodalidadNull()
				MyBase.Item(Me.tablematricula2.modalidadColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setmunicipio_nacNull()
				MyBase.Item(Me.tablematricula2.municipio_nacColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetnacionalidadNull()
				MyBase.Item(Me.tablematricula2.nacionalidadColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setnombre_madreNull()
				MyBase.Item(Me.tablematricula2.nombre_madreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setnombre_padreNull()
				MyBase.Item(Me.tablematricula2.nombre_padreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetpadreNull()
				MyBase.Item(Me.tablematricula2.padreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetprofesionNull()
				MyBase.Item(Me.tablematricula2.profesionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetrepitenteNull()
				MyBase.Item(Me.tablematricula2.repitenteColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetsexoNull()
				MyBase.Item(Me.tablematricula2.sexoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Settelefono_emergenciaNull()
				MyBase.Item(Me.tablematricula2.telefono_emergenciaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Settelefono_madreNull()
				MyBase.Item(Me.tablematricula2.telefono_madreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Settelefono_padreNull()
				MyBase.Item(Me.tablematricula2.telefono_padreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SettelefonoNull()
				MyBase.Item(Me.tablematricula2.telefonoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Class matricula2RowChangeEvent
			Inherits EventArgs
			Private eventRow As chrilyhd_matriculaagzDataSet1.matricula2Row

			Private eventAction As DataRowAction

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Row As chrilyhd_matriculaagzDataSet1.matricula2Row
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New(ByVal row As chrilyhd_matriculaagzDataSet1.matricula2Row, ByVal action As DataRowAction)
				MyBase.New()
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Delegate Sub matricula2RowChangeEventHandler(ByVal sender As Object, ByVal e As chrilyhd_matriculaagzDataSet1.matricula2RowChangeEvent)

		<Serializable>
		<XmlSchemaProvider("GetTypedTableSchema")>
		Public Class matriculaDataTable
			Inherits TypedTableBase(Of chrilyhd_matriculaagzDataSet1.matriculaRow)
			Private columnid_matricula As DataColumn

			Private columnnombre As DataColumn

			Private columnidentidad_alumno As DataColumn

			Private columnidp As DataColumn

			Private columngrado As DataColumn

			Private columnprofesion As DataColumn

			Private columnpadre As DataColumn

			Private columntelefono As DataColumn

			Private columnemail As DataColumn

			Private columncodigo As DataColumn

			Private columndireccion As DataColumn

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property codigoColumn As DataColumn
				Get
					Return Me.columncodigo
				End Get
			End Property

			<Browsable(False)>
			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property direccionColumn As DataColumn
				Get
					Return Me.columndireccion
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property emailColumn As DataColumn
				Get
					Return Me.columnemail
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property gradoColumn As DataColumn
				Get
					Return Me.columngrado
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property id_matriculaColumn As DataColumn
				Get
					Return Me.columnid_matricula
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property identidad_alumnoColumn As DataColumn
				Get
					Return Me.columnidentidad_alumno
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property idpColumn As DataColumn
				Get
					Return Me.columnidp
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Default Public ReadOnly Property Item(ByVal index As Integer) As chrilyhd_matriculaagzDataSet1.matriculaRow
				Get
					Return DirectCast(MyBase.Rows(index), chrilyhd_matriculaagzDataSet1.matriculaRow)
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property nombreColumn As DataColumn
				Get
					Return Me.columnnombre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property padreColumn As DataColumn
				Get
					Return Me.columnpadre
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property profesionColumn As DataColumn
				Get
					Return Me.columnprofesion
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property telefonoColumn As DataColumn
				Get
					Return Me.columntelefono
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New()
				MyBase.New()
				MyBase.TableName = "matricula"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub New(ByVal table As DataTable)
				MyBase.New()
				MyBase.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0) Then
					MyBase.Locale = table.Locale
				End If
				If (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0) Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub AddmatriculaRow(ByVal row As chrilyhd_matriculaagzDataSet1.matriculaRow)
				MyBase.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function AddmatriculaRow(ByVal nombre As String, ByVal identidad_alumno As String, ByVal idp As String, ByVal grado As String, ByVal profesion As String, ByVal padre As String, ByVal telefono As String, ByVal email As String, ByVal codigo As String, ByVal direccion As String) As chrilyhd_matriculaagzDataSet1.matriculaRow
				Dim _matriculaRow As chrilyhd_matriculaagzDataSet1.matriculaRow = DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet1.matriculaRow)
				_matriculaRow.ItemArray = New Object() { Nothing, nombre, identidad_alumno, idp, grado, profesion, padre, telefono, email, codigo, direccion }
				MyBase.Rows.Add(_matriculaRow)
				Return _matriculaRow
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim _matriculaDataTable As chrilyhd_matriculaagzDataSet1.matriculaDataTable = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet1.matriculaDataTable)
				_matriculaDataTable.InitVars()
				Return _matriculaDataTable
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New chrilyhd_matriculaagzDataSet1.matriculaDataTable()
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function FindByid_matricula(ByVal id_matricula As Integer) As chrilyhd_matriculaagzDataSet1.matriculaRow
				Return DirectCast(MyBase.Rows.Find(New Object() { id_matricula }), chrilyhd_matriculaagzDataSet1.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(chrilyhd_matriculaagzDataSet1.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
				Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
				Dim chrilyhdMatriculaagzDataSet1 As chrilyhd_matriculaagzDataSet1 = New chrilyhd_matriculaagzDataSet1()
				Dim xmlSchemaAny As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
				{
					.[Namespace] = "http://www.w3.org/2001/XMLSchema",
					.MinOccurs = New Decimal(0),
					.MaxOccurs = New Decimal(-1, -1, -1, False, 0),
					.ProcessContents = XmlSchemaContentProcessing.Lax
				}
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny1 As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
				{
					.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1",
					.MinOccurs = New Decimal(1),
					.ProcessContents = XmlSchemaContentProcessing.Lax
				}
				xmlSchemaSequence.Items.Add(xmlSchemaAny1)
				Dim xmlSchemaAttribute As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "namespace",
					.FixedValue = chrilyhdMatriculaagzDataSet1.[Namespace]
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "tableTypeName",
					.FixedValue = "matriculaDataTable"
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1)
				xmlSchemaComplexType1.Particle = xmlSchemaSequence
				Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet1.GetSchemaSerializable()
				If (xs.Contains(schemaSerializable.TargetNamespace)) Then
					Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
					Dim memoryStream1 As System.IO.MemoryStream = New System.IO.MemoryStream()
					Try
						Dim current As System.Xml.Schema.XmlSchema = Nothing
						schemaSerializable.Write(memoryStream)
						Dim enumerator As IEnumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator()
						While enumerator.MoveNext()
							current = DirectCast(enumerator.Current, System.Xml.Schema.XmlSchema)
							memoryStream1.SetLength(CLng(0))
							current.Write(memoryStream1)
							If (memoryStream.Length = memoryStream1.Length) Then
								memoryStream.Position = CLng(0)
								memoryStream1.Position = CLng(0)
								While True
									If (If(memoryStream.Position = memoryStream.Length, True, memoryStream.ReadByte() <> memoryStream1.ReadByte())) Then
										Exit While
									End If
								End While
								If (memoryStream.Position = memoryStream.Length) Then
									xmlSchemaComplexType = xmlSchemaComplexType1
									Return xmlSchemaComplexType
								End If
							End If
						End While
					Finally
						If (memoryStream IsNot Nothing) Then
							memoryStream.Close()
						End If
						If (memoryStream1 IsNot Nothing) Then
							memoryStream1.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				xmlSchemaComplexType = xmlSchemaComplexType1
				Return xmlSchemaComplexType
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Private Sub InitClass()
				Me.columnid_matricula = New DataColumn("id_matricula", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnid_matricula)
				Me.columnnombre = New DataColumn("nombre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnnombre)
				Me.columnidentidad_alumno = New DataColumn("identidad_alumno", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnidentidad_alumno)
				Me.columnidp = New DataColumn("idp", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnidp)
				Me.columngrado = New DataColumn("grado", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columngrado)
				Me.columnprofesion = New DataColumn("profesion", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnprofesion)
				Me.columnpadre = New DataColumn("padre", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnpadre)
				Me.columntelefono = New DataColumn("telefono", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columntelefono)
				Me.columnemail = New DataColumn("email", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnemail)
				Me.columncodigo = New DataColumn("codigo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columncodigo)
				Me.columndireccion = New DataColumn("direccion", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columndireccion)
				MyBase.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() { Me.columnid_matricula }, True))
				Me.columnid_matricula.AutoIncrement = True
				Me.columnid_matricula.AutoIncrementSeed = CLng(-1)
				Me.columnid_matricula.AutoIncrementStep = CLng(-1)
				Me.columnid_matricula.AllowDBNull = False
				Me.columnid_matricula.Unique = True
				Me.columnnombre.AllowDBNull = False
				Me.columnnombre.MaxLength = 100
				Me.columnidentidad_alumno.MaxLength = 50
				Me.columnidp.MaxLength = 50
				Me.columngrado.MaxLength = 15
				Me.columnprofesion.MaxLength = 300
				Me.columnpadre.MaxLength = 100
				Me.columntelefono.MaxLength = 150
				Me.columnemail.MaxLength = 100
				Me.columncodigo.MaxLength = 25
				Me.columndireccion.MaxLength = 500
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub InitVars()
				Me.columnid_matricula = MyBase.Columns("id_matricula")
				Me.columnnombre = MyBase.Columns("nombre")
				Me.columnidentidad_alumno = MyBase.Columns("identidad_alumno")
				Me.columnidp = MyBase.Columns("idp")
				Me.columngrado = MyBase.Columns("grado")
				Me.columnprofesion = MyBase.Columns("profesion")
				Me.columnpadre = MyBase.Columns("padre")
				Me.columntelefono = MyBase.Columns("telefono")
				Me.columnemail = MyBase.Columns("email")
				Me.columncodigo = MyBase.Columns("codigo")
				Me.columndireccion = MyBase.Columns("direccion")
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function NewmatriculaRow() As chrilyhd_matriculaagzDataSet1.matriculaRow
				Return DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet1.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New chrilyhd_matriculaagzDataSet1.matriculaRow(builder)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matriculaDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowChanged(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matriculaDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowChanging(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matriculaDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowDeleted(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet1/matriculaDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
				' File path: C:\Program Files (x86)\Soluciones Informáticas Fortin\InstaladorSistemaMatriculaAGZ\ssh.exe
				' 
				' Product version: 2019.1.118.0
				' Exception in: System.Void OnRowDeleting(System.Data.DataRowChangeEventArgs)
				' 
				' Visual Basic does not support this type of event usage. Please, try using other language.
				'    en ...( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 101
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 213
				'    en ..(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 546
				'    en ...(BinaryExpression ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 96
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 141
				'    en ..(IfStatement ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 407
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 78
				'    en ..Visit(IEnumerable ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 383
				'    en ..( ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 388
				'    en ..Visit(ICodeNode ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:línea 69
				'    en ..(DecompilationContext ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:línea 25
				'    en ..(MethodBody ,  , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 88
				'    en ..(MethodBody , ILanguage ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:línea 70
				'    en Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 95
				'    en Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:línea 58
				'    en ..(ILanguage , MethodDefinition ,  ) en C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:línea 117
				' 
				' mailto: JustDecompilePublicFeedback@telerik.com

			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub RemovematriculaRow(ByVal row As chrilyhd_matriculaagzDataSet1.matriculaRow)
				MyBase.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowChanged As chrilyhd_matriculaagzDataSet1.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowChanging As chrilyhd_matriculaagzDataSet1.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowDeleted As chrilyhd_matriculaagzDataSet1.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowDeleting As chrilyhd_matriculaagzDataSet1.matriculaRowChangeEventHandler
		End Class

		Public Class matriculaRow
			Inherits DataRow
			Private tablematricula As chrilyhd_matriculaagzDataSet1.matriculaDataTable

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property codigo As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.codigoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'codigo' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.codigoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property direccion As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.direccionColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'direccion' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.direccionColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property email As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.emailColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'email' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.emailColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property grado As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.gradoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'grado' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.gradoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property id_matricula As Integer
				Get
					Return Conversions.ToInteger(MyBase.Item(Me.tablematricula.id_matriculaColumn))
				End Get
				Set(ByVal value As Integer)
					MyBase.Item(Me.tablematricula.id_matriculaColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property identidad_alumno As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.identidad_alumnoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'identidad_alumno' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.identidad_alumnoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property idp As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.idpColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'idp' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.idpColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property nombre As String
				Get
					Return Conversions.ToString(MyBase.Item(Me.tablematricula.nombreColumn))
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.nombreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property padre As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.padreColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'padre' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.padreColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property profesion As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.profesionColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'profesion' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.profesionColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Property telefono As String
				Get
					Dim str As String
					Try
						str = Conversions.ToString(MyBase.Item(Me.tablematricula.telefonoColumn))
					Catch invalidCastException As System.InvalidCastException
						ProjectData.SetProjectError(invalidCastException)
						Throw New StrongTypingException("El valor de la columna 'telefono' de la tabla 'matricula' es DBNull.", invalidCastException)
					End Try
					Return str
				End Get
				Set(ByVal value As String)
					MyBase.Item(Me.tablematricula.telefonoColumn) = value
				End Set
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tablematricula = DirectCast(MyBase.Table, chrilyhd_matriculaagzDataSet1.matriculaDataTable)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IscodigoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.codigoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsdireccionNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.direccionColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsemailNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.emailColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsgradoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.gradoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Isidentidad_alumnoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.identidad_alumnoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsidpNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.idpColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IspadreNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.padreColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsprofesionNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.profesionColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IstelefonoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula.telefonoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetcodigoNull()
				MyBase.Item(Me.tablematricula.codigoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetdireccionNull()
				MyBase.Item(Me.tablematricula.direccionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetemailNull()
				MyBase.Item(Me.tablematricula.emailColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetgradoNull()
				MyBase.Item(Me.tablematricula.gradoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub Setidentidad_alumnoNull()
				MyBase.Item(Me.tablematricula.identidad_alumnoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetidpNull()
				MyBase.Item(Me.tablematricula.idpColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetpadreNull()
				MyBase.Item(Me.tablematricula.padreColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetprofesionNull()
				MyBase.Item(Me.tablematricula.profesionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SettelefonoNull()
				MyBase.Item(Me.tablematricula.telefonoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Class matriculaRowChangeEvent
			Inherits EventArgs
			Private eventRow As chrilyhd_matriculaagzDataSet1.matriculaRow

			Private eventAction As DataRowAction

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public ReadOnly Property Row As chrilyhd_matriculaagzDataSet1.matriculaRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New(ByVal row As chrilyhd_matriculaagzDataSet1.matriculaRow, ByVal action As DataRowAction)
				MyBase.New()
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Delegate Sub matriculaRowChangeEventHandler(ByVal sender As Object, ByVal e As chrilyhd_matriculaagzDataSet1.matriculaRowChangeEvent)
	End Class
End Namespace