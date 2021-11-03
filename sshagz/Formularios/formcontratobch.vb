Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports ssh.chrilyhd_matriculaagzDataSetTableAdapters
Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


<DesignerGenerated>
Public Class formcontratobch
    Inherits Form

    Friend WithEvents ReportViewer1 As ReportViewer
    Private components As IContainer



    Public Sub New()
        MyBase.New()
        AddHandler MyBase.Load, New EventHandler(AddressOf Me.Formcontratobch_Load)
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

    Private Sub Formcontratobch_Load(ByVal sender As Object, ByVal e As EventArgs)
        conexionmysql.Abrir_MYBD()
        Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Dim str As String = String.Concat("select * from matricula2 where id_matricula= ", Conversions.ToString(modulo_variables_globales.valor_del_cellclick))
        Try
            'Me.chrilyhd_matriculaagzDataSet1.Clear()

            Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(str, conexionmysql.myconn)
            mySqlDataAdapter.SelectCommand = mySqlCommand
            ' mySqlDataAdapter.Fill(Me.chrilyhd_matriculaagzDataSet1.matricula2)
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sshagz.ssh.BCH.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(890, 441)
        Me.ReportViewer1.TabIndex = 0
        '
        'formcontratobch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 441)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "formcontratobch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTRATO DE SERVICIO PROFESIONAL EDUCATIVO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Private Sub formcontratobch_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
