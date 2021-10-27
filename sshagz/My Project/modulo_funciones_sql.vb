Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms

Namespace ssh
	Friend Module modulo_funciones_sql
		Public columna1w As String

		Public tabla1w As String

		Public where As String

		Public data1w As DataGridView

		Sub New()
			modulo_funciones_sql.data1w = New DataGridView()
		End Sub

		Public Sub carga_data()
			Try
				conexionmysql.Abrir_MYBD()
				Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(If(String.Concat(New String() { "SELECT ", modulo_funciones_sql.columna1w, " FROM ", modulo_funciones_sql.tabla1w, " ", modulo_funciones_sql.where }), ""), conexionmysql.myconn)
				Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
				mySqlDataAdapter.Fill(dataTable)
				conexionmysql.Cerrar_MYBD()
				modulo_funciones_sql.data1w.DataSource = dataTable
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error al cargar los registro")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Function conversionImagen(ByVal arregloImagen As Image) As Byte()
			Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
			arregloImagen.Save(memoryStream, ImageFormat.Jpeg)
			Return memoryStream.ToArray()
		End Function
	End Module
End Namespace