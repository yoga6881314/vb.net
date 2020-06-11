Imports System.Data.SqlClient
Public Class newemployee
    'select a picture
    Private ImageName As String = ""
    Private Sub btnImagePick_Click(sender As Object, e As EventArgs) Handles btnImagePick.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            'get the image file name and copy to another folder
            Dim path As String = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            Dim newpath As String = "C:\images\" + path
            Try
                System.IO.File.Copy(OpenFileDialog1.FileName, newpath)
            Catch ex As Exception
                MessageBox.Show("image name is already exist")
            End Try

            'copy path to imageName for upload to DB
            ImageName = newpath
            'Console.WriteLine(OpenFileDialog1.FileName)
        End If
    End Sub

    'cancel the seleced picture
    Private Sub btnImageCancel_Click(sender As Object, e As EventArgs) Handles btnImageCancel.Click
        PictureBox1.Image = Nothing
        ImageName = ""   'clear uploaded file name
    End Sub

    'check input data is not empty
    Private ReadOnly Property isNewValid As Boolean
        Get
            If txtNewName.Text = "" Then
                MessageBox.Show("please enter a name.")
                Return False
            ElseIf txtNewKata.Text = "" Then
                MessageBox.Show("please enter カタカナ.")
                Return False
            ElseIf chkNewFemale.Checked = False And chkNewMale.Checked = False Then
                MessageBox.Show("please check gender.")
                Return False
            ElseIf cmbNewDepart.SelectedItem = "" Then
                MessageBox.Show("please select department.")
                Return False
            ElseIf txtNewMail.Text = "" Then
                MessageBox.Show("please enter a mail address.")
                Return False
            ElseIf txtNewTele.Text = "" Then
                MessageBox.Show("please enter a telephone number.")
                Return False
            ElseIf txtNewAddress.Text = "" Then
                MessageBox.Show("please enter a address.")
                Return False
            ElseIf txtNewEdu.Text = "" Then
                MessageBox.Show("please enter last education.")
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Private Sub clearForm()
        txtNewName.Clear()
        txtNewKata.Clear()
        chkNewFemale.Checked = False
        chkNewMale.Checked = False
        cmbNewDepart.SelectedItem = Nothing
        txtNewMail.Clear()
        txtNewTele.Clear()
        txtNewAddress.Clear()
        txtNewEdu.Clear()
        txtNewSpecial.Clear()
    End Sub

    Private Sub btnNewSubmit_Click(sender As Object, e As EventArgs) Handles btnNewSubmit.Click
        If isNewValid Then
            Using connection As New SqlConnection(My.Settings.connString)
                Using SqlCommand As New SqlCommand("employee.uspNewEmployee", connection)
                    SqlCommand.CommandType = CommandType.StoredProcedure

                    'add parameters into procedure
                    SqlCommand.Parameters.Add(New SqlParameter("@UserFullName", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserFullName").Value = txtNewName.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserFullName").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserKataName", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserKataName").Value = txtNewKata.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserKataName").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserGender", SqlDbType.NVarChar, 4))
                    If chkNewFemale.Checked = True Then
                        SqlCommand.Parameters("@UserGender").Value = "女性"
                    ElseIf chkNewMale.Checked = True Then
                        SqlCommand.Parameters("@UserGender").Value = "男性"
                    End If
                    Console.WriteLine(SqlCommand.Parameters("@UserGender").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserDepart", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserDepart").Value = cmbNewDepart.SelectedItem
                    Console.WriteLine(SqlCommand.Parameters("@UserDepart").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserBirth", SqlDbType.Date, 8))
                    SqlCommand.Parameters("@UserBirth").Value = dtpNewBirth.Value
                    Console.WriteLine(SqlCommand.Parameters("@UserBirth").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserMail", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserMail").Value = txtNewMail.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserMail").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserTele", SqlDbType.Char, 13))
                    SqlCommand.Parameters("@UserTele").Value = txtNewTele.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserTele").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserAddress", SqlDbType.NVarChar, 50))
                    SqlCommand.Parameters("@UserAddress").Value = txtNewAddress.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserAddress").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserEdu", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserEdu").Value = txtNewEdu.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserEdu").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserSpecial", SqlDbType.NVarChar, 40))
                    SqlCommand.Parameters("@UserSpecial").Value = txtNewSpecial.Text
                    Console.WriteLine(SqlCommand.Parameters("@UserSpecial").Value)

                    SqlCommand.Parameters.Add(New SqlParameter("@UserImage", SqlDbType.NVarChar, 100))
                    SqlCommand.Parameters("@UserImage").Value = ImageName


                    Try
                        connection.Open()
                        SqlCommand.ExecuteNonQuery()
                        MessageBox.Show("succeed to build a data")
                    Catch ex As Exception
                        MessageBox.Show("data can not be build.")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
            clearForm()
        End If
    End Sub

    Private Sub btnNewCancel_Click(sender As Object, e As EventArgs) Handles btnNewCancel.Click
        clearForm()
    End Sub
End Class