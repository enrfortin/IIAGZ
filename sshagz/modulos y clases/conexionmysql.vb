Imports MySql.Data.MySqlClient
Imports Renci.SshNet


Public Class conexionmysql
        Public Shared myconn As New MySql.Data.MySqlClient.MySqlConnection
        Public Shared Function myconectar(ByVal x As String, ByVal db As String, ByVal user As String, ByVal pw As String, ByVal port As String) As Boolean
            Dim cadenaConexion As String = (String.Format("server={0};database={1};user id={2};password={3};port={4};SslMode=none;", x, db, user, pw, port))
            Try
                myconn.ConnectionString = cadenaConexion
                If myconn.State = ConnectionState.Open Then
                    myconectar = True
                Else
                    myconn.Open()
                    myconectar = True
                    MessageBox.Show("Conección Exitosa")
                    'Interaction.MsgBox(conexionmysql.myconn.State.ToString)
                End If
            Catch ex As Exception
                myconectar = False
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al conectar a la BD")
            End Try
        End Function
        Public Shared Sub Cerrar_MYBD()
            If myconn.State = ConnectionState.Closed Then
            Else
                Try
                    myconn.Close()
                Catch
                End Try
            End If
        End Sub
        Public Shared Sub Abrir_MYBD()
            If myconn.State = ConnectionState.Open Then
            Else
                Try
                    myconn.Open()
                Catch
                End Try
            End If
        End Sub


        Public Shared Sub ssh()

            Try
                Using sshClient

                    sshClient.Connect()

                    If sshClient.IsConnected Then
                        sshClient.AddForwardedPort(portForwarded)
                        portForwarded.Start()
                    End If

                    MsgBox(String.Format("Connected:{0} As {1}", sshClient.ConnectionInfo.Host, sshClient.ConnectionInfo.Username))
                    conexionmysql.myconectar("127.0.0.1", "chrilyhd_matriculaagz", "chrilyhd_sifagz", "H7aSK-$6jXKB", "3314")

                End Using
            Catch
            End Try
        End Sub
    End Class
