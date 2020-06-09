Imports System.Data.SqlClient

Public Class login
    Private tempUserMail As String
    Private tempUserPassword As String

    Private ReadOnly Property IsMailValid As Boolean
        Get
            If txtMailAddress.Text = "" Then
                MessageBox.Show("Please enter a mail address.")
                Return False
            ElseIf txtMailPassword.Text = "" Then
                MessageBox.Show("Please enter a password.")
                Return False
            Else
                tempUserMail = txtMailAddress.Text
                tempUserPassword = txtMailPassword.Text
                Return True
            End If
        End Get
    End Property

    Private Sub ClearForm()
        txtMailAddress.Clear()
        txtMailPassword.Clear()
        Me.tempUserMail = vbNull
        Me.tempUserPassword = vbNull

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If IsMailValid Then
            Using connection As New SqlConnection(My.Settings.connString)
                Const sql As String = "select AuthorPassword from employee.AuthorData where AuthorMail = @AuthorMail"
                Using SqlCommand As New SqlCommand(sql, connection)
                    SqlCommand.Parameters.Add(New SqlParameter("@AuthorMail", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@AuthorMail").Value = tempUserMail
                    Console.WriteLine(SqlCommand.Parameters("@AuthorMail").Value)

                    Try
                        connection.Open()

                        Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                        While (dataReader.Read())
                            'Console.WriteLine(dataReader(0).ToString())
                            If dataReader(0).ToString() = tempUserPassword Then
                                Dim frm As Form = New main()
                                frm.Show()
                                ClearForm()
                            Else
                                ClearForm()
                            End If
                        End While

                    Catch ex As Exception
                        MessageBox.Show("mail address or password is not correct")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub
End Class