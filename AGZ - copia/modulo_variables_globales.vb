Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Text.RegularExpressions


Friend Module modulo_variables_globales
		Public usuario As String

		Public usuario_verificar As String

		Public valor_del_cellclick As Integer

		Public validar As String

		Public aniomatricula As String

		Public edad As String

		Sub New()
			modulo_variables_globales.validar = "0"
		End Sub

		Public Function Buscar(ByVal id As String) As System.Data.DataTable
			Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
			conexionmysql.Abrir_MYBD()
			Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM matricula WHERE identidad_alumno=@ida", conexionmysql.myconn)
			mySqlCommand.Parameters.AddWithValue("@ida", modulo_variables_globales.usuario)
			Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(mySqlCommand)
            Try
                mySqlDataAdapter.Fill(dataTable)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()

            End Try
			Return dataTable
		End Function

		Public Function Buscar2(ByVal id As String) As System.Data.DataTable
			Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
			conexionmysql.Abrir_MYBD()
			Dim mySqlCommand As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM matricula2 WHERE identidad_alumno=@ida", conexionmysql.myconn)
			mySqlCommand.Parameters.AddWithValue("@ida", modulo_variables_globales.usuario)
			Dim mySqlDataAdapter As MySql.Data.MySqlClient.MySqlDataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(mySqlCommand)
            Try
                mySqlDataAdapter.Fill(dataTable)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                ProjectData.ClearProjectError()

            End Try
			Return dataTable
		End Function

		Public Function letra_cap(ByVal loquesea As String) As String
			Return Strings.StrConv(loquesea, VbStrConv.ProperCase, 0)
		End Function

		Public Function validar_email(ByVal smail As String) As Boolean
			Return Regex.IsMatch(smail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
		End Function
	End Module
