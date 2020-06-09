Imports System.Data.SqlClient
Public Class main
    'Private TempImage As String
    'Private TempSql As String

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(My.Settings.connString)
            Const sql As String = "select * from employee.UsersData"
            Using SqlCommand As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(dataReader)
                    Me.dgvUserdata.DataSource = dataTable
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("No data to show")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
    Private Sub reset()
        Using connection As New SqlConnection(My.Settings.connString)
            Const sql As String = "select * from employee.UsersData"
            Using SqlCommand As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(dataReader)
                    Me.dgvUserdata.DataSource = dataTable
                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("No data to show")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Function temptext(ByRef txt As String, ByRef i As Integer) As String
        Dim TempSqlTxt() As String = {"UserFullName like N'%", "UserKataName like N'%", "UserGender like N'%", "UserDepart like N'%", "UserBirth like '%",
            "UserMail like '%", "UserTele like '%", "UserAddress like N'%", "UserEdu like N'%", " UserSpecial like N'%"}
        Dim Sqltxt As String

        If txt <> "" Then
            Sqltxt = TempSqlTxt(i) + txt + "%' and "
            Console.WriteLine("t" + Sqltxt)
            Return Sqltxt
        Else
            Return ""
        End If
    End Function

    Private Function sqlcatch() As String
        Dim gender As String = ""
        If chkSerFemale.Checked = True Then
            gender = "女性"
        ElseIf chkSerMale.Checked = True Then
            gender = "男性"
        End If
        Dim tempSql As String = ""
        tempSql += temptext(txtSerFullName.Text, 0)
        tempSql += temptext(txtSerKaName.Text, 1)
        If gender <> "" Then
            tempSql += "UserGender like N'%" + gender + "%' and "
        End If
        tempSql += temptext(txtSerDepart.Text, 3)
        tempSql += temptext(txtSerBirth.Text, 4)
        tempSql += temptext(txtSerMail.Text, 5)
        tempSql += temptext(txtSerTele.Text, 6)
        tempSql += temptext(txtSerAddress.Text, 7)
        tempSql += temptext(txtSerEdu.Text, 8)
        tempSql += temptext(txtSerSpecial.Text, 9)

        Return tempSql.Substring(0, tempSql.Length - 5)
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If sqlcatch() <> "" Then
            Dim sqltxt As String = "select * from employee.UsersData where " + sqlcatch()
            Using connection As New SqlConnection(My.Settings.connString)
                Dim sql1 As String = sqltxt
                Console.WriteLine(sql1)
                Using SqlCommand As New SqlCommand(sql1, connection)
                    Try
                        connection.Open()
                        Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(dataReader)
                        Me.dgvUserdata.DataSource = dataTable
                        dataReader.Close()
                    Catch ex As Exception
                        MessageBox.Show("No data to show")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub btnSerReset_Click(sender As Object, e As EventArgs) Handles btnSerReset.Click
        txtSerFullName.Clear()
        txtSerKaName.Clear()
        chkSerMale.Checked = False
        chkSerFemale.Checked = False
        txtSerDepart.Clear()
        txtSerBirth.Clear()
        txtSerTele.Clear()
        txtSerMail.Clear()
        txtSerTele.Clear()
        txtSerAddress.Clear()
        txtSerEdu.Clear()
        txtSerSpecial.Clear()
        reset()
    End Sub

    Private Sub btnNewEpl_Click(sender As Object, e As EventArgs) Handles btnNewEpl.Click
        Dim frm As Form = New newemployee()
        frm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub
End Class
