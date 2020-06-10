Imports System.Data.SqlClient
Public Class update
    Private getId As Integer

    'check the input is not null
    Private ReadOnly Property isUpdValid As Boolean
        Get
            If txtUpdName.Text = "" Then
                MessageBox.Show("please enter a name.")
                Return False
            ElseIf txtUpdKata.Text = "" Then
                MessageBox.Show("please enter カタカナ.")
                Return False
            ElseIf chkUpdFemale.Checked = False And chkUpdMale.Checked = False Then
                MessageBox.Show("please check gender.")
                Return False
            ElseIf cmbUpdDepart.SelectedItem = "" Then
                MessageBox.Show("please select department.")
                Return False
            ElseIf txtUpdMail.Text = "" Then
                MessageBox.Show("please enter a mail address.")
                Return False
            ElseIf txtUpdTele.Text = "" Then
                MessageBox.Show("please enter a telephone number.")
                Return False
            ElseIf txtUpdAddress.Text = "" Then
                MessageBox.Show("please enter a address.")
                Return False
            ElseIf txtUpdEdu.Text = "" Then
                MessageBox.Show("please enter last education.")
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'main form のtxtID.textの値を取得
        Dim UpdateId As Integer = CType(Me.Owner, main).IdText
        txtShowId.Text = UpdateId
        getId = UpdateId
        'output the data from ID
        Using connection As New SqlConnection(My.Settings.connString)
            Const sql As String = "select UserFullName,UserKataName,UserGender,UserDepart,UserBirth,UserMail,UserTele,UserAddress,UserEdu,UserSpecial from employee.UsersData where UserID=@UpdateId"
            Using SqlCommand As New SqlCommand(sql, connection)
                SqlCommand.Parameters.Add(New SqlParameter("@UpdateId", SqlDbType.Int))
                SqlCommand.Parameters("@UpdateId").Value = UpdateId

                Try
                    connection.Open()
                    Dim dataReaders As SqlDataReader = SqlCommand.ExecuteReader()

                    'output the data of datareaders to txtbox
                    While dataReaders.Read()
                        'MessageBox.Show("correct")
                        txtUpdName.Text = dataReaders(0).ToString
                        txtUpdKata.Text = dataReaders(1).ToString
                        If dataReaders(2).ToString = "男性" Then
                            chkUpdMale.Checked = True
                        Else
                            chkUpdFemale.Checked = True
                        End If
                        cmbUpdDepart.SelectedItem = dataReaders(3).ToString
                        dtpUpdBirth.Value = dataReaders(4).ToString
                        txtUpdMail.Text = dataReaders(5).ToString
                        txtUpdTele.Text = dataReaders(6).ToString
                        txtUpdAddress.Text = dataReaders(7).ToString
                        txtUpdEdu.Text = dataReaders(8).ToString
                        txtUpdSpecial.Text = dataReaders(9).ToString

                    End While
                    dataReaders.Close()
                Catch ex As Exception
                    MessageBox.Show("error to load data")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using

    End Sub

    Private Sub btnUpdCancel_Click(sender As Object, e As EventArgs) Handles btnUpdCancel.Click
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isUpdValid Then
            Using connection As New SqlConnection(My.Settings.connString)
                Using sqlcommand As New SqlCommand("employee.uspUpdateEmployee", connection)
                    sqlcommand.CommandType = CommandType.StoredProcedure

                    sqlcommand.Parameters.Add(New SqlParameter("@UserFullname", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserFullName").Value = txtUpdName.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserKataname", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserKataName").Value = txtUpdKata.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserGender", SqlDbType.NVarChar, 4))
                    If chkUpdFemale.Checked = True Then
                        sqlcommand.Parameters("@UserGender").Value = "女性"
                    Else
                        sqlcommand.Parameters("@UserGender").Value = "男性"
                    End If

                    sqlcommand.Parameters.Add(New SqlParameter("@UserDepart", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserDepart").Value = cmbUpdDepart.SelectedItem

                    sqlcommand.Parameters.Add(New SqlParameter("@UserBirth", SqlDbType.Date, 8))
                    sqlcommand.Parameters("@UserBirth").Value = dtpUpdBirth.Value

                    sqlcommand.Parameters.Add(New SqlParameter("@UserMail", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserMail").Value = txtUpdMail.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserTele", SqlDbType.Char, 13))
                    sqlcommand.Parameters("@UserTele").Value = txtUpdTele.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserAddress", SqlDbType.NVarChar, 50))
                    sqlcommand.Parameters("@UserAddress").Value = txtUpdAddress.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserEdu", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserEdu").Value = txtUpdEdu.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserSpecial", SqlDbType.NVarChar, 40))
                    sqlcommand.Parameters("@UserSpecial").Value = txtUpdSpecial.Text

                    sqlcommand.Parameters.Add(New SqlParameter("@UserID", SqlDbType.Int))
                    sqlcommand.Parameters("@UserID").Value = getId

                    Try
                        connection.Open()
                        sqlcommand.ExecuteNonQuery()
                        MessageBox.Show("Update the data successfully")
                    Catch ex As Exception
                        MessageBox.Show("fail to update")
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub chkUpdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdFemale.CheckedChanged
        chkUpdMale.Checked = False
    End Sub

    Private Sub chkUpdMale_CheckedChanged(sender As Object, e As EventArgs) Handles chkUpdMale.CheckedChanged
        chkUpdFemale.Checked = False
    End Sub
End Class