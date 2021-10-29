Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Module modulo_variables_globales


    Public usuario As String = ""

    Public usuario_verificar As String = ""

    Public valor_del_cellclick As Integer

    Public validar As String = "0"

    Public aniomatricula As String

    Public edad As String


    Public Function Buscar(id As String) As datat
        Dim dt As New DataTable()
        conexionmysql.Abrir_MYBD()
        Dim comando As New MySqlCommand("SELECT * FROM matricula WHERE identidad_alumno=@ida", conexionmysql.myconn)
        comando.Parameters.AddWithValue("@ida", modulo_variables_globales.usuario)
        Dim adap As New MySqlDataAdapter(comando)
        Try
            adap.Fill(dt)
        Catch exception As System.Exception
        Finally
            conexionmysql.Cerrar_MYBD()

        End Try
        Return dt
    End Function

    Public Function Buscar2(id As String) As DataTable
        Dim dt As New DataTable()
        conexionmysql.Abrir_MYBD()
        Dim comando As New MySqlCommand("SELECT * FROM matricula2 WHERE identidad_alumno=@ida", conexionmysql.myconn)
        comando.Parameters.AddWithValue("@ida", modulo_variables_globales.usuario)
        Dim adap As New MySqlDataAdapter(comando)
        Try
            MessageBox.Show(conexionmysql.myconn.State.ToString)
            adap.Fill(dt)
            MessageBox.Show(conexionmysql.myconn.State.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message + ex.ToString)
        End Try
        Return dt
    End Function

    Public Function letra_cap(ByVal loquesea As String) As String
        Return Strings.StrConv(loquesea, VbStrConv.ProperCase, 0)
    End Function

    Public Function validar_email(ByVal smail As String) As Boolean
        Return Regex.IsMatch(smail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

End Module
