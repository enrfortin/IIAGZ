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
	<XmlRoot("chrilyhd_matriculaagzDataSet")>
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	Public Class chrilyhd_matriculaagzDataSet
		Inherits DataSet
		Private tablematricula As chrilyhd_matriculaagzDataSet.matriculaDataTable

		Private tablematricula2 As chrilyhd_matriculaagzDataSet.matricula2DataTable

		Private _schemaSerializationMode As System.Data.SchemaSerializationMode

		<Browsable(False)>
		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public ReadOnly Property matricula As chrilyhd_matriculaagzDataSet.matriculaDataTable
			Get
				Return Me.tablematricula
			End Get
		End Property

		<Browsable(False)>
		<DebuggerNonUserCode>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public ReadOnly Property matricula2 As chrilyhd_matriculaagzDataSet.matricula2DataTable
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
						MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet.matriculaDataTable(dataSet.Tables("matricula")))
					End If
					If (dataSet.Tables("matricula2") IsNot Nothing) Then
						MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet.matricula2DataTable(dataSet.Tables("matricula2")))
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
			Dim schemaSerializationMode As chrilyhd_matriculaagzDataSet = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet)
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
			Dim chrilyhdMatriculaagzDataSet As chrilyhd_matriculaagzDataSet = New chrilyhd_matriculaagzDataSet()
			Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
			Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
			Dim xmlSchemaAny As System.Xml.Schema.XmlSchemaAny = New System.Xml.Schema.XmlSchemaAny() With
			{
				.[Namespace] = chrilyhdMatriculaagzDataSet.[Namespace]
			}
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType1.Particle = xmlSchemaSequence
			Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet.GetSchemaSerializable()
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
			MyBase.DataSetName = "chrilyhd_matriculaagzDataSet"
			MyBase.Prefix = ""
			MyBase.[Namespace] = "http://tempuri.org/chrilyhd_matriculaagzDataSet.xsd"
			MyBase.EnforceConstraints = True
			Me.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			Me.tablematricula = New chrilyhd_matriculaagzDataSet.matriculaDataTable()
			MyBase.Tables.Add(Me.tablematricula)
			Me.tablematricula2 = New chrilyhd_matriculaagzDataSet.matricula2DataTable()
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
			Me.tablematricula = DirectCast(MyBase.Tables("matricula"), chrilyhd_matriculaagzDataSet.matriculaDataTable)
			If (initTable) Then
				If (Me.tablematricula IsNot Nothing) Then
					Me.tablematricula.InitVars()
				End If
			End If
			Me.tablematricula2 = DirectCast(MyBase.Tables("matricula2"), chrilyhd_matriculaagzDataSet.matricula2DataTable)
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
					MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet.matriculaDataTable(dataSet.Tables("matricula")))
				End If
				If (dataSet.Tables("matricula2") IsNot Nothing) Then
					MyBase.Tables.Add(New chrilyhd_matriculaagzDataSet.matricula2DataTable(dataSet.Tables("matricula2")))
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
			Inherits TypedTableBase(Of chrilyhd_matriculaagzDataSet.matricula2Row)
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
			Default Public ReadOnly Property Item(ByVal index As Integer) As chrilyhd_matriculaagzDataSet.matricula2Row
				Get
					Return DirectCast(MyBase.Rows(index), chrilyhd_matriculaagzDataSet.matricula2Row)
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
			Public Sub Addmatricula2Row(ByVal row As chrilyhd_matriculaagzDataSet.matricula2Row)
				MyBase.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Addmatricula2Row(ByVal nombre As String, ByVal identidad_alumno As String, ByVal idp As String, ByVal grado As String, ByVal profesion As String, ByVal padre As String, ByVal telefono As String, ByVal email As String, ByVal codigo As String, ByVal direccion As String) As chrilyhd_matriculaagzDataSet.matricula2Row
				Dim _matricula2Row As chrilyhd_matriculaagzDataSet.matricula2Row = DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet.matricula2Row)
				_matricula2Row.ItemArray = New Object() { Nothing, nombre, identidad_alumno, idp, grado, profesion, padre, telefono, email, codigo, direccion }
				MyBase.Rows.Add(_matricula2Row)
				Return _matricula2Row
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim _matricula2DataTable As chrilyhd_matriculaagzDataSet.matricula2DataTable = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet.matricula2DataTable)
				_matricula2DataTable.InitVars()
				Return _matricula2DataTable
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New chrilyhd_matriculaagzDataSet.matricula2DataTable()
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function FindByid_matricula(ByVal id_matricula As Integer) As chrilyhd_matriculaagzDataSet.matricula2Row
				Return DirectCast(MyBase.Rows.Find(New Object() { id_matricula }), chrilyhd_matriculaagzDataSet.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(chrilyhd_matriculaagzDataSet.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
				Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
				Dim chrilyhdMatriculaagzDataSet As chrilyhd_matriculaagzDataSet = New chrilyhd_matriculaagzDataSet()
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
					.FixedValue = chrilyhdMatriculaagzDataSet.[Namespace]
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "tableTypeName",
					.FixedValue = "matricula2DataTable"
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1)
				xmlSchemaComplexType1.Particle = xmlSchemaSequence
				Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet.GetSchemaSerializable()
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
				Me.columnprofesion.MaxLength = 50
				Me.columnpadre.MaxLength = 100
				Me.columntelefono.MaxLength = 25
				Me.columnemail.MaxLength = 100
				Me.columncodigo.MaxLength = 25
				Me.columndireccion.MaxLength = 200
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
			Public Function Newmatricula2Row() As chrilyhd_matriculaagzDataSet.matricula2Row
				Return DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet.matricula2Row)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New chrilyhd_matriculaagzDataSet.matricula2Row(builder)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matricula2DataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matricula2DataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matricula2DataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matricula2DataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			Public Sub Removematricula2Row(ByVal row As chrilyhd_matriculaagzDataSet.matricula2Row)
				MyBase.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowChanged As chrilyhd_matriculaagzDataSet.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowChanging As chrilyhd_matriculaagzDataSet.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowDeleted As chrilyhd_matriculaagzDataSet.matricula2RowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matricula2RowDeleting As chrilyhd_matriculaagzDataSet.matricula2RowChangeEventHandler
		End Class

		Public Class matricula2Row
			Inherits DataRow
			Private tablematricula2 As chrilyhd_matriculaagzDataSet.matricula2DataTable

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
			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tablematricula2 = DirectCast(MyBase.Table, chrilyhd_matriculaagzDataSet.matricula2DataTable)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IscodigoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.codigoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsdireccionNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.direccionColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function IsemailNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.emailColumn)
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
			Public Function IstelefonoNull() As Boolean
				Return MyBase.IsNull(Me.tablematricula2.telefonoColumn)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetcodigoNull()
				MyBase.Item(Me.tablematricula2.codigoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetdireccionNull()
				MyBase.Item(Me.tablematricula2.direccionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub SetemailNull()
				MyBase.Item(Me.tablematricula2.emailColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
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
			Public Sub SettelefonoNull()
				MyBase.Item(Me.tablematricula2.telefonoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Class matricula2RowChangeEvent
			Inherits EventArgs
			Private eventRow As chrilyhd_matriculaagzDataSet.matricula2Row

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
			Public ReadOnly Property Row As chrilyhd_matriculaagzDataSet.matricula2Row
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New(ByVal row As chrilyhd_matriculaagzDataSet.matricula2Row, ByVal action As DataRowAction)
				MyBase.New()
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Delegate Sub matricula2RowChangeEventHandler(ByVal sender As Object, ByVal e As chrilyhd_matriculaagzDataSet.matricula2RowChangeEvent)

		<Serializable>
		<XmlSchemaProvider("GetTypedTableSchema")>
		Public Class matriculaDataTable
			Inherits TypedTableBase(Of chrilyhd_matriculaagzDataSet.matriculaRow)
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
			Default Public ReadOnly Property Item(ByVal index As Integer) As chrilyhd_matriculaagzDataSet.matriculaRow
				Get
					Return DirectCast(MyBase.Rows(index), chrilyhd_matriculaagzDataSet.matriculaRow)
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
			Public Sub AddmatriculaRow(ByVal row As chrilyhd_matriculaagzDataSet.matriculaRow)
				MyBase.Rows.Add(row)
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function AddmatriculaRow(ByVal nombre As String, ByVal identidad_alumno As String, ByVal idp As String, ByVal grado As String, ByVal profesion As String, ByVal padre As String, ByVal telefono As String, ByVal email As String, ByVal codigo As String, ByVal direccion As String) As chrilyhd_matriculaagzDataSet.matriculaRow
				Dim _matriculaRow As chrilyhd_matriculaagzDataSet.matriculaRow = DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet.matriculaRow)
				_matriculaRow.ItemArray = New Object() { Nothing, nombre, identidad_alumno, idp, grado, profesion, padre, telefono, email, codigo, direccion }
				MyBase.Rows.Add(_matriculaRow)
				Return _matriculaRow
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim _matriculaDataTable As chrilyhd_matriculaagzDataSet.matriculaDataTable = DirectCast(MyBase.Clone(), chrilyhd_matriculaagzDataSet.matriculaDataTable)
				_matriculaDataTable.InitVars()
				Return _matriculaDataTable
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New chrilyhd_matriculaagzDataSet.matriculaDataTable()
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function FindByid_matricula(ByVal id_matricula As Integer) As chrilyhd_matriculaagzDataSet.matriculaRow
				Return DirectCast(MyBase.Rows.Find(New Object() { id_matricula }), chrilyhd_matriculaagzDataSet.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(chrilyhd_matriculaagzDataSet.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType As System.Xml.Schema.XmlSchemaComplexType
				Dim xmlSchemaComplexType1 As System.Xml.Schema.XmlSchemaComplexType = New System.Xml.Schema.XmlSchemaComplexType()
				Dim xmlSchemaSequence As System.Xml.Schema.XmlSchemaSequence = New System.Xml.Schema.XmlSchemaSequence()
				Dim chrilyhdMatriculaagzDataSet As chrilyhd_matriculaagzDataSet = New chrilyhd_matriculaagzDataSet()
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
					.FixedValue = chrilyhdMatriculaagzDataSet.[Namespace]
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute1 As System.Xml.Schema.XmlSchemaAttribute = New System.Xml.Schema.XmlSchemaAttribute() With
				{
					.Name = "tableTypeName",
					.FixedValue = "matriculaDataTable"
				}
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1)
				xmlSchemaComplexType1.Particle = xmlSchemaSequence
				Dim schemaSerializable As System.Xml.Schema.XmlSchema = chrilyhdMatriculaagzDataSet.GetSchemaSerializable()
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
				Me.columnprofesion.MaxLength = 50
				Me.columnpadre.MaxLength = 100
				Me.columntelefono.MaxLength = 25
				Me.columnemail.MaxLength = 100
				Me.columncodigo.MaxLength = 25
				Me.columndireccion.MaxLength = 200
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
			Public Function NewmatriculaRow() As chrilyhd_matriculaagzDataSet.matriculaRow
				Return DirectCast(MyBase.NewRow(), chrilyhd_matriculaagzDataSet.matriculaRow)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New chrilyhd_matriculaagzDataSet.matriculaRow(builder)
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				' 
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matriculaDataTable::OnRowChanged(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matriculaDataTable::OnRowChanging(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matriculaDataTable::OnRowDeleted(System.Data.DataRowChangeEventArgs)
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
				' Current member / type: System.Void ssh.chrilyhd_matriculaagzDataSet/matriculaDataTable::OnRowDeleting(System.Data.DataRowChangeEventArgs)
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
			Public Sub RemovematriculaRow(ByVal row As chrilyhd_matriculaagzDataSet.matriculaRow)
				MyBase.Rows.Remove(row)
			End Sub

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowChanged As chrilyhd_matriculaagzDataSet.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowChanging As chrilyhd_matriculaagzDataSet.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowDeleted As chrilyhd_matriculaagzDataSet.matriculaRowChangeEventHandler

			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Event matriculaRowDeleting As chrilyhd_matriculaagzDataSet.matriculaRowChangeEventHandler
		End Class

		Public Class matriculaRow
			Inherits DataRow
			Private tablematricula As chrilyhd_matriculaagzDataSet.matriculaDataTable

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
				Me.tablematricula = DirectCast(MyBase.Table, chrilyhd_matriculaagzDataSet.matriculaDataTable)
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
			Private eventRow As chrilyhd_matriculaagzDataSet.matriculaRow

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
			Public ReadOnly Property Row As chrilyhd_matriculaagzDataSet.matriculaRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Sub New(ByVal row As chrilyhd_matriculaagzDataSet.matriculaRow, ByVal action As DataRowAction)
				MyBase.New()
				Me.eventRow = row
				Me.eventAction = action
			End Sub
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Delegate Sub matriculaRowChangeEventHandler(ByVal sender As Object, ByVal e As chrilyhd_matriculaagzDataSet.matriculaRowChangeEvent)
	End Class
End Namespace