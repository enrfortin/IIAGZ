Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh.chrilyhd_matriculaagzDataSet1TableAdapters
Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Imports DevExpress.Utils.Helpers

Namespace ssh
    <DesignerGenerated>
    Public Class ficha_matricula
        Inherits Form
        Private components As IContainer

        Friend Overridable Property chrilyhd_matriculaagzDataSet1 As ssh.chrilyhd_matriculaagzDataSet1

        Friend Overridable Property DirectoryEntry1 As DirectoryEntry

        Friend Overridable Property matricula2BindingSource As BindingSource

        Friend Overridable Property matricula2TableAdapter As ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matricula2TableAdapter

        Friend Overridable Property ReportViewer1 As ReportViewer

        Public Sub New()
            MyBase.New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.ficha_matricula_Load)
            Me.InitializeComponent()
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

        Private Sub ficha_matricula_Load(ByVal sender As Object, ByVal e As EventArgs)
            conexionmysql.Abrir_MYBD()
            Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter()
            Dim str As String = String.Concat("select * from matricula2 where id_matricula= ", Conversions.ToString(modulo_variables_globales.valor_del_cellclick))
            Try
                Me.chrilyhd_matriculaagzDataSet1.Clear()
                Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(str, conexionmysql.myconn)
                mySqlDataAdapter.SelectCommand = mySqlCommand
                mySqlDataAdapter.Fill(Me.chrilyhd_matriculaagzDataSet1.matricula2)
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

        <DebuggerStepThrough>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim reportDataSource As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
            'Me.DirectoryEntry1 = New DirectoryEntry()
            Me.ReportViewer1 = New ReportViewer()
            Me.chrilyhd_matriculaagzDataSet1 = New ssh.chrilyhd_matriculaagzDataSet1()
            Me.matricula2BindingSource = New BindingSource(Me.components)
            Me.matricula2TableAdapter = New ssh.chrilyhd_matriculaagzDataSet1TableAdapters.matricula2TableAdapter()
            DirectCast(Me.chrilyhd_matriculaagzDataSet1, ISupportInitialize).BeginInit()
            DirectCast(Me.matricula2BindingSource, ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.ReportViewer1.Dock = DockStyle.Fill
            reportDataSource.Name = "DataSet1"
            reportDataSource.Value = Me.matricula2BindingSource
            Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ssh.ficha de matricula.rdlc"
            Me.ReportViewer1.Location = New Point(0, 0)
            Me.ReportViewer1.Name = "ReportViewer1"
            Me.ReportViewer1.Size = New System.Drawing.Size(890, 441)
            Me.ReportViewer1.TabIndex = 0
            Me.chrilyhd_matriculaagzDataSet1.DataSetName = "chrilyhd_matriculaagzDataSet1"
            Me.chrilyhd_matriculaagzDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.matricula2BindingSource.DataMember = "matricula2"
            Me.matricula2BindingSource.DataSource = Me.chrilyhd_matriculaagzDataSet1
            Me.matricula2TableAdapter.ClearBeforeFill = True
            MyBase.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            MyBase.ClientSize = New System.Drawing.Size(890, 441)
            MyBase.Controls.Add(Me.ReportViewer1)
            MyBase.Name = "ficha_matricula"
            MyBase.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "FICHA DE MATRICULA"
            MyBase.WindowState = FormWindowState.Maximized
            DirectCast(Me.chrilyhd_matriculaagzDataSet1, ISupportInitialize).EndInit()
            DirectCast(Me.matricula2BindingSource, ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace