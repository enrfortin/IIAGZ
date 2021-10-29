Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh.chrilyhd_matriculaagzDataSetTableAdapters
Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel



<DesignerGenerated>
	Public Class Cyf3
		Inherits Form
		Private components As IContainer

		Friend Overridable Property chrilyhd_matriculaagzDataSet As ssh.chrilyhd_matriculaagzDataSet

		Friend Overridable Property matricula2BindingSource As BindingSource

		Friend Overridable Property matricula2TableAdapter As ssh.chrilyhd_matriculaagzDataSetTableAdapters.matricula2TableAdapter

		Friend Overridable Property ReportViewer1 As ReportViewer

		Public Sub New()
			MyBase.New()
			AddHandler MyBase.Load,  New EventHandler(AddressOf Me.Cyf3_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Cyf3_Load(ByVal sender As Object, ByVal e As EventArgs)
			conexionmysql.Abrir_MYBD()
			Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter()
			Dim str As String = String.Concat("select * from matricula2 where id_matricula= ", Conversions.ToString(modulo_variables_globales.valor_del_cellclick))
			Try
				Me.chrilyhd_matriculaagzDataSet.Clear()
				Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(str, conexionmysql.myconn)
				mySqlDataAdapter.SelectCommand = mySqlCommand
				mySqlDataAdapter.Fill(Me.chrilyhd_matriculaagzDataSet.matricula2)
				mySqlCommand.Dispose()
				mySqlDataAdapter.Dispose()
				conexionmysql.Cerrar_MYBD()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				conexionmysql.Cerrar_MYBD()
				ProjectData.ClearProjectError()
			End Try
			Me.ReportViewer1.RefreshReport()
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
			Me.components = New System.ComponentModel.Container()
			Dim reportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
			Me.ReportViewer1 = New ReportViewer()
			Me.chrilyhd_matriculaagzDataSet = New ssh.chrilyhd_matriculaagzDataSet()
			Me.matricula2BindingSource = New BindingSource(Me.components)
			Me.matricula2TableAdapter = New ssh.chrilyhd_matriculaagzDataSetTableAdapters.matricula2TableAdapter()
			DirectCast(Me.chrilyhd_matriculaagzDataSet, ISupportInitialize).BeginInit()
			DirectCast(Me.matricula2BindingSource, ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.ReportViewer1.Dock = DockStyle.Fill
			reportDataSource.Name = "DataSet1"
			reportDataSource.Value = Me.matricula2BindingSource
			Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
			Me.ReportViewer1.LocalReport.DisplayName = "CONTRATO DE SERVICIO PROFESIONAL EDUCATIVO"
			Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ssh.cyf3.rdlc"
			Me.ReportViewer1.Location = New Point(0, 0)
			Me.ReportViewer1.Name = "ReportViewer1"
			Me.ReportViewer1.Size = New System.Drawing.Size(890, 441)
			Me.ReportViewer1.TabIndex = 0
			Me.chrilyhd_matriculaagzDataSet.DataSetName = "chrilyhd_matriculaagzDataSet"
			Me.chrilyhd_matriculaagzDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.matricula2BindingSource.DataMember = "matricula2"
			Me.matricula2BindingSource.DataSource = Me.chrilyhd_matriculaagzDataSet
			Me.matricula2TableAdapter.ClearBeforeFill = True
			MyBase.AutoScaleDimensions = New SizeF(6!, 13!)
			MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New System.Drawing.Size(890, 441)
			MyBase.Controls.Add(Me.ReportViewer1)
			MyBase.Name = "cyf3"
			Me.Text = "CONTRATO DE SERVICIO PROFESIONAL EDUCATIVO"
			DirectCast(Me.chrilyhd_matriculaagzDataSet, ISupportInitialize).EndInit()
			DirectCast(Me.matricula2BindingSource, ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub
	End Class
