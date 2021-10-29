Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics

Namespace ssh.chrilyhd_matriculaagzDataSet1TableAdapters
	<Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
	<DesignerCategory("code")>
	<HelpKeyword("vs.data.TableAdapterManager")>
	<ToolboxItem(True)>
	Public Class TableAdapterManager
		Inherits Component
		Private _updateOrder As TableAdapterManager.UpdateOrderOption

		Private _matriculaTableAdapter As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matriculaTableAdapter

		Private _matricula2TableAdapter As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matricula2TableAdapter

		Private _backupDataSetBeforeUpdate As Boolean

		Private _connection As IDbConnection

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property BackupDataSetBeforeUpdate As Boolean
			Get
				Return Me._backupDataSetBeforeUpdate
			End Get
			Set(ByVal value As Boolean)
				Me._backupDataSetBeforeUpdate = value
			End Set
		End Property

		<Browsable(False)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property Connection As IDbConnection
			Get
				Dim dbConnection As IDbConnection
				If (Me._connection IsNot Nothing) Then
					dbConnection = Me._connection
				ElseIf (If(Me._matriculaTableAdapter Is Nothing, False, Me._matriculaTableAdapter.Connection IsNot Nothing)) Then
					dbConnection = Me._matriculaTableAdapter.Connection
				ElseIf (If(Me._matricula2TableAdapter Is Nothing, True, Me._matricula2TableAdapter.Connection Is Nothing)) Then
					dbConnection = Nothing
				Else
					dbConnection = Me._matricula2TableAdapter.Connection
				End If
				Return dbConnection
			End Get
			Set(ByVal value As IDbConnection)
				Me._connection = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property matricula2TableAdapter As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matricula2TableAdapter
			Get
				Return Me._matricula2TableAdapter
			End Get
			Set(ByVal value As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matricula2TableAdapter)
				Me._matricula2TableAdapter = value
			End Set
		End Property

		<DebuggerNonUserCode>
		<Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property matriculaTableAdapter As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matriculaTableAdapter
			Get
				Return Me._matriculaTableAdapter
			End Get
			Set(ByVal value As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matriculaTableAdapter)
				Me._matriculaTableAdapter = value
			End Set
		End Property

		<Browsable(False)>
		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public ReadOnly Property TableAdapterInstanceCount As Integer
			Get
				Dim num As Integer = 0
				If (Me._matriculaTableAdapter IsNot Nothing) Then
					num = num + 1
				End If
				If (Me._matricula2TableAdapter IsNot Nothing) Then
					num = num + 1
				End If
				Return num
			End Get
		End Property

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Property UpdateOrder As TableAdapterManager.UpdateOrderOption
			Get
				Return Me._updateOrder
			End Get
			Set(ByVal value As TableAdapterManager.UpdateOrderOption)
				Me._updateOrder = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function GetRealUpdatedRows(ByVal updatedRows As System.Data.DataRow(), ByVal allAddedRows As List(Of System.Data.DataRow)) As System.Data.DataRow()
			Dim array As System.Data.DataRow()
			If (If(updatedRows Is Nothing, True, CInt(updatedRows.Length) < 1)) Then
				array = updatedRows
			ElseIf (If(allAddedRows Is Nothing, False, allAddedRows.Count >= 1)) Then
				Dim dataRows As List(Of System.Data.DataRow) = New List(Of System.Data.DataRow)()
				Dim num As Integer = 0
				While num < CInt(updatedRows.Length)
					Dim dataRow As System.Data.DataRow = updatedRows(num)
					If (Not allAddedRows.Contains(dataRow)) Then
						dataRows.Add(dataRow)
					End If
					num = num + 1
				End While
				array = dataRows.ToArray()
			Else
				array = updatedRows
			End If
			Return array
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overridable Function MatchTableAdapterConnection(ByVal inputConnection As IDbConnection) As Boolean
			Dim flag As Boolean
			If (Me._connection IsNot Nothing) Then
				flag = True
			ElseIf (If(Me.Connection Is Nothing, False, inputConnection IsNot Nothing)) Then
				flag = If(Not String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal), False, True)
			Else
				flag = True
			End If
			Return flag
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Protected Overridable Sub SortSelfReferenceRows(ByVal rows As DataRow(), ByVal relation As DataRelation, ByVal childFirst As Boolean)
			Array.Sort(Of DataRow)(rows, New TableAdapterManager.SelfReferenceComparer(relation, childFirst))
		End Sub

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Overridable Function UpdateAll(ByVal dataSet As chrilyhd_matriculaagzDataSet1) As Integer
			Dim num As Integer
			If (dataSet Is Nothing) Then
				Throw New ArgumentNullException("dataSet")
			End If
			If (dataSet.HasChanges()) Then
				If (If(Me._matriculaTableAdapter Is Nothing, False, Not Me.MatchTableAdapterConnection(Me._matriculaTableAdapter.Connection))) Then
					Throw New ArgumentException("Todos los TableAdapters administrados por un TableAdapterManager deben usar la misma cadena de conexión.")
				End If
				If (If(Me._matricula2TableAdapter Is Nothing, False, Not Me.MatchTableAdapterConnection(Me._matricula2TableAdapter.Connection))) Then
					Throw New ArgumentException("Todos los TableAdapters administrados por un TableAdapterManager deben usar la misma cadena de conexión.")
				End If
				Dim connection As IDbConnection = Me.Connection
				If (connection Is Nothing) Then
					Throw New ApplicationException("TableAdapterManager no contiene información de conexión. Establezca cada propiedad TableAdapterManager TableAdapter en una instancia TableAdapter válida.")
				End If
				Dim flag As Boolean = False
				If ((connection.State And ConnectionState.Broken) = ConnectionState.Broken) Then
					connection.Close()
				End If
				If (connection.State = ConnectionState.Closed) Then
					connection.Open()
					flag = True
				End If
				Dim dbTransaction As IDbTransaction = connection.BeginTransaction()
				If (dbTransaction Is Nothing) Then
					Throw New ApplicationException("La transacción no puede comenzar. La conexión de datos actual no es compatible con las transacciones o el estado actual no permite que comience la transacción.")
				End If
				Dim dataRows As List(Of System.Data.DataRow) = New List(Of System.Data.DataRow)()
				Dim dataRows1 As List(Of System.Data.DataRow) = New List(Of System.Data.DataRow)()
				Dim dataAdapters As List(Of DataAdapter) = New List(Of DataAdapter)()
				Dim objs As Dictionary(Of Object, IDbConnection) = New Dictionary(Of Object, IDbConnection)()
				Dim num1 As Integer = 0
				Dim dataSet1 As System.Data.DataSet = Nothing
				If (Me.BackupDataSetBeforeUpdate) Then
					dataSet1 = New System.Data.DataSet()
					dataSet1.Merge(dataSet)
				End If
				Try
					Try
						If (Me._matriculaTableAdapter IsNot Nothing) Then
							objs.Add(Me._matriculaTableAdapter, Me._matriculaTableAdapter.Connection)
							Me._matriculaTableAdapter.Connection = DirectCast(connection, MySqlConnection)
							Me._matriculaTableAdapter.Transaction = DirectCast(dbTransaction, MySqlTransaction)
							If (Me._matriculaTableAdapter.Adapter.AcceptChangesDuringUpdate) Then
								Me._matriculaTableAdapter.Adapter.AcceptChangesDuringUpdate = False
								dataAdapters.Add(Me._matriculaTableAdapter.Adapter)
							End If
						End If
						If (Me._matricula2TableAdapter IsNot Nothing) Then
							objs.Add(Me._matricula2TableAdapter, Me._matricula2TableAdapter.Connection)
							Me._matricula2TableAdapter.Connection = DirectCast(connection, MySqlConnection)
							Me._matricula2TableAdapter.Transaction = DirectCast(dbTransaction, MySqlTransaction)
							If (Me._matricula2TableAdapter.Adapter.AcceptChangesDuringUpdate) Then
								Me._matricula2TableAdapter.Adapter.AcceptChangesDuringUpdate = False
								dataAdapters.Add(Me._matricula2TableAdapter.Adapter)
							End If
						End If
						If (Me.UpdateOrder <> TableAdapterManager.UpdateOrderOption.UpdateInsertDelete) Then
							num1 = num1 + Me.UpdateInsertedRows(dataSet, dataRows1)
							num1 = num1 + Me.UpdateUpdatedRows(dataSet, dataRows, dataRows1)
						Else
							num1 = num1 + Me.UpdateUpdatedRows(dataSet, dataRows, dataRows1)
							num1 = num1 + Me.UpdateInsertedRows(dataSet, dataRows1)
						End If
						num1 = num1 + Me.UpdateDeletedRows(dataSet, dataRows)
						dbTransaction.Commit()
						If (0 < dataRows1.Count) Then
							Dim dataRowArray(dataRows1.Count - 1 + 1 - 1) As System.Data.DataRow
							dataRows1.CopyTo(dataRowArray)
							Dim num2 As Integer = 0
							While num2 < CInt(dataRowArray.Length)
								dataRowArray(num2).AcceptChanges()
								num2 = num2 + 1
							End While
						End If
						If (0 < dataRows.Count) Then
							Dim dataRowArray1(dataRows.Count - 1 + 1 - 1) As System.Data.DataRow
							dataRows.CopyTo(dataRowArray1)
							Dim num3 As Integer = 0
							While num3 < CInt(dataRowArray1.Length)
								dataRowArray1(num3).AcceptChanges()
								num3 = num3 + 1
							End While
						End If
					Catch exception1 As System.Exception
						ProjectData.SetProjectError(exception1)
						Dim exception As System.Exception = exception1
						dbTransaction.Rollback()
						If (Me.BackupDataSetBeforeUpdate) Then
							Debug.Assert(dataSet1 IsNot Nothing)
							dataSet.Clear()
							dataSet.Merge(dataSet1)
						ElseIf (0 < dataRows1.Count) Then
							Dim dataRowArray2(dataRows1.Count - 1 + 1 - 1) As System.Data.DataRow
							dataRows1.CopyTo(dataRowArray2)
							Dim num4 As Integer = 0
							While num4 < CInt(dataRowArray2.Length)
								Dim dataRow As System.Data.DataRow = dataRowArray2(num4)
								dataRow.AcceptChanges()
								dataRow.SetAdded()
								num4 = num4 + 1
							End While
						End If
						Throw exception
					End Try
				Finally
					If (flag) Then
						connection.Close()
					End If
					If (Me._matriculaTableAdapter IsNot Nothing) Then
						Me._matriculaTableAdapter.Connection = DirectCast(objs(Me._matriculaTableAdapter), MySqlConnection)
						Me._matriculaTableAdapter.Transaction = Nothing
					End If
					If (Me._matricula2TableAdapter IsNot Nothing) Then
						Me._matricula2TableAdapter.Connection = DirectCast(objs(Me._matricula2TableAdapter), MySqlConnection)
						Me._matricula2TableAdapter.Transaction = Nothing
					End If
					If (0 < dataAdapters.Count) Then
						Dim dataAdapterArray(dataAdapters.Count - 1 + 1 - 1) As DataAdapter
						dataAdapters.CopyTo(dataAdapterArray)
						Dim num5 As Integer = 0
						While num5 < CInt(dataAdapterArray.Length)
							dataAdapterArray(num5).AcceptChangesDuringUpdate = True
							num5 = num5 + 1
						End While
					End If
				End Try
				num = num1
			Else
				num = 0
			End If
			Return num
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function UpdateDeletedRows(ByVal dataSet As chrilyhd_matriculaagzDataSet1, ByVal allChangedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			If (Me._matricula2TableAdapter IsNot Nothing) Then
				Dim dataRowArray As DataRow() = dataSet.matricula2.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				If (If(dataRowArray Is Nothing, False, 0 < CInt(dataRowArray.Length))) Then
					num = num + Me._matricula2TableAdapter.Update(dataRowArray)
					allChangedRows.AddRange(dataRowArray)
				End If
			End If
			If (Me._matriculaTableAdapter IsNot Nothing) Then
				Dim dataRowArray1 As DataRow() = dataSet.matricula.[Select](Nothing, Nothing, DataViewRowState.Deleted)
				If (If(dataRowArray1 Is Nothing, False, 0 < CInt(dataRowArray1.Length))) Then
					num = num + Me._matriculaTableAdapter.Update(dataRowArray1)
					allChangedRows.AddRange(dataRowArray1)
				End If
			End If
			Return num
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function UpdateInsertedRows(ByVal dataSet As chrilyhd_matriculaagzDataSet1, ByVal allAddedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			If (Me._matriculaTableAdapter IsNot Nothing) Then
				Dim dataRowArray As DataRow() = dataSet.matricula.[Select](Nothing, Nothing, DataViewRowState.Added)
				If (If(dataRowArray Is Nothing, False, 0 < CInt(dataRowArray.Length))) Then
					num = num + Me._matriculaTableAdapter.Update(dataRowArray)
					allAddedRows.AddRange(dataRowArray)
				End If
			End If
			If (Me._matricula2TableAdapter IsNot Nothing) Then
				Dim dataRowArray1 As DataRow() = dataSet.matricula2.[Select](Nothing, Nothing, DataViewRowState.Added)
				If (If(dataRowArray1 Is Nothing, False, 0 < CInt(dataRowArray1.Length))) Then
					num = num + Me._matricula2TableAdapter.Update(dataRowArray1)
					allAddedRows.AddRange(dataRowArray1)
				End If
			End If
			Return num
		End Function

		<DebuggerNonUserCode>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Function UpdateUpdatedRows(ByVal dataSet As chrilyhd_matriculaagzDataSet1, ByVal allChangedRows As List(Of DataRow), ByVal allAddedRows As List(Of DataRow)) As Integer
			Dim num As Integer = 0
			If (Me._matriculaTableAdapter IsNot Nothing) Then
				Dim realUpdatedRows As DataRow() = dataSet.matricula.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				realUpdatedRows = Me.GetRealUpdatedRows(realUpdatedRows, allAddedRows)
				If (If(realUpdatedRows Is Nothing, False, 0 < CInt(realUpdatedRows.Length))) Then
					num = num + Me._matriculaTableAdapter.Update(realUpdatedRows)
					allChangedRows.AddRange(realUpdatedRows)
				End If
			End If
			If (Me._matricula2TableAdapter IsNot Nothing) Then
				Dim dataRowArray As DataRow() = dataSet.matricula2.[Select](Nothing, Nothing, DataViewRowState.ModifiedCurrent)
				dataRowArray = Me.GetRealUpdatedRows(dataRowArray, allAddedRows)
				If (If(dataRowArray Is Nothing, False, 0 < CInt(dataRowArray.Length))) Then
					num = num + Me._matricula2TableAdapter.Update(dataRowArray)
					allChangedRows.AddRange(dataRowArray)
				End If
			End If
			Return num
		End Function

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Private Class SelfReferenceComparer
			Implements IComparer(Of DataRow)
			Private _relation As DataRelation

			Private _childFirst As Integer

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Friend Sub New(ByVal relation As DataRelation, ByVal childFirst As Boolean)
				MyBase.New()
				Me._relation = relation
				If (Not childFirst) Then
					Me._childFirst = 1
				Else
					Me._childFirst = -1
				End If
			End Sub

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Public Function Compare(ByVal row1 As System.Data.DataRow, ByVal row2 As System.Data.DataRow) As Integer Implements IComparer(Of System.Data.DataRow).Compare
				Dim num As Integer
				If (Object.ReferenceEquals(row1, row2)) Then
					num = 0
				ElseIf (row1 Is Nothing) Then
					num = -1
				ElseIf (row2 IsNot Nothing) Then
					Dim num1 As Integer = 0
					Dim root As System.Data.DataRow = Me.GetRoot(row1, num1)
					Dim num2 As Integer = 0
					Dim dataRow As System.Data.DataRow = Me.GetRoot(row2, num2)
					If (Not Object.ReferenceEquals(root, dataRow)) Then
						Debug.Assert(If(root.Table Is Nothing, False, dataRow.Table IsNot Nothing))
						num = If(root.Table.Rows.IndexOf(root) >= dataRow.Table.Rows.IndexOf(dataRow), 1, -1)
					Else
						num = Me._childFirst * num1.CompareTo(num2)
					End If
				Else
					num = 1
				End If
				Return num
			End Function

			<DebuggerNonUserCode>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
			Private Function GetRoot(ByVal row As System.Data.DataRow, ByRef distance As Integer) As System.Data.DataRow
				Debug.Assert(row IsNot Nothing)
				Dim dataRow As System.Data.DataRow = row
				distance = 0
				Dim dataRows As IDictionary(Of System.Data.DataRow, System.Data.DataRow) = New Dictionary(Of System.Data.DataRow, System.Data.DataRow)()
				dataRows(row) = row
				Dim parentRow As System.Data.DataRow = row.GetParentRow(Me._relation, DataRowVersion.[Default])
				While True
					If (If(parentRow Is Nothing, True, dataRows.ContainsKey(parentRow))) Then
						Exit While
					End If
					distance = distance + 1
					dataRow = parentRow
					dataRows(parentRow) = parentRow
					parentRow = parentRow.GetParentRow(Me._relation, DataRowVersion.[Default])
				End While
				If (distance = 0) Then
					dataRows.Clear()
					dataRows(row) = row
					parentRow = row.GetParentRow(Me._relation, DataRowVersion.Original)
					While True
						If (If(parentRow Is Nothing, True, dataRows.ContainsKey(parentRow))) Then
							Exit While
						End If
						distance = distance + 1
						dataRow = parentRow
						dataRows(parentRow) = parentRow
						parentRow = parentRow.GetParentRow(Me._relation, DataRowVersion.Original)
					End While
				End If
				Return dataRow
			End Function
		End Class

		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")>
		Public Enum UpdateOrderOption
			InsertUpdateDelete
			UpdateInsertDelete
		End Enum
	End Class
End Namespace