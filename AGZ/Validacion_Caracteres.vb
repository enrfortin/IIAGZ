Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace ssh
	Friend Module Validacion_Caracteres
		Public Function EliminarCaracteresRepetidos(ByVal cadena As String) As String
			Dim str As String
			Dim num As Integer = 0
			Dim enumerator As IEnumerator = Nothing
			Dim enumerator1 As IEnumerator = Nothing
			Try
				Dim matchCollections As MatchCollection = Regex.Matches(cadena, "[a]{3,}|[b]{3,}|[c]{3,}|[d]{3,}|[e]{3,}|[f]{3,}|[g]{3,}|[h]{3,}|[i]{3,}|[j]{3,}|[k]{3,}|[l]{3,}|[m]{3,}|[n]{3,}|[ñ]{3,}|[o]{3,}|[p]{3,}|[q]{3,}|[r]{3,}|[s]{3,}|[t]{3,}|[u]{3,}|[v]{3,}|[w]{3,}|[x]{3,}|[y]{3,}|[z]{3,}|[-]{3,}|[_]{3,}|[@]{1,}|[#]{1,}|[.]{1,}", RegexOptions.IgnoreCase)
				Dim index(matchCollections.Count - 1 + 1 - 1) As Integer
				Dim length(matchCollections.Count - 1 + 1 - 1) As Integer
				Try
					enumerator = matchCollections.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As Match = DirectCast(enumerator.Current, Match)
						Try
							enumerator1 = current.Groups.GetEnumerator()
							While enumerator1.MoveNext()
								Dim group As System.Text.RegularExpressions.Group = DirectCast(enumerator1.Current, System.Text.RegularExpressions.Group)
								index(num) = group.Index
								length(num) = group.Length
								num = num + 1
							End While
						Finally
							If (TypeOf enumerator1 Is IDisposable) Then
								TryCast(enumerator1, IDisposable).Dispose()
							End If
						End Try
					End While
				Finally
					If (TypeOf enumerator Is IDisposable) Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				For i As Integer = CInt(index.Length) - 1 To 0 Step -1
					Interaction.MsgBox("Error de Escritura", MsgBoxStyle.Information, Nothing)
					cadena = cadena.Remove(index(i), length(i) - 0)
					cadena = Nothing
				Next

				str = cadena
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Throw
			End Try
			Return str
		End Function

		Public Sub Validacion_Alfabetica(ByVal sender As Object, ByRef e As KeyPressEventArgs)
			Dim textBox As System.Windows.Forms.TextBox = DirectCast(sender, System.Windows.Forms.TextBox)
			If (Char.IsLetter(e.KeyChar)) Then
				e.Handled = False
			ElseIf (Not Char.IsControl(e.KeyChar)) Then
				e.Handled = True
			Else
				e.Handled = False
			End If
		End Sub

		Public Sub Validacion_numerica(ByVal sender As Object, ByRef e As KeyPressEventArgs)
			Dim textBox As System.Windows.Forms.TextBox = DirectCast(sender, System.Windows.Forms.TextBox)
			If (Char.IsNumber(e.KeyChar)) Then
				e.Handled = False
			ElseIf (Not Char.IsControl(e.KeyChar)) Then
				e.Handled = True
			Else
				e.Handled = False
			End If
		End Sub

		Friend Sub Validacion_numerica(ByVal textTratamiento As TextBox)
			Throw New NotImplementedException()
		End Sub
	End Module
End Namespace