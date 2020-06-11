Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class main
    'Private TempImage As String
    Private TempID As Integer
    'mainオブジェクトを保持するためのフィールド
    Private Shared _mainInstance As main

    'mainオブジェクトを取得、設定するためのプロパティ
    Public Shared Property MainInstance() As main
        Get
            Return _mainInstance
        End Get
        Set(ByVal Value As main)
            _mainInstance = Value
        End Set
    End Property

    'txtID.textからIDを取得、設定するためのプロパティ
    Public Property IdText() As Integer
        Get
            Return txtID.Text
        End Get
        Set(ByVal Value As Integer)
            txtID.Text = Value
        End Set
    End Property

    'the time open main, load DB data
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'main.MainInstance = Me
        Using connection As New SqlConnection(My.Settings.connString)
            Const sql As String = "select * from employee.UsersData"
            Using SqlCommand As New SqlCommand(sql, connection)
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(dataReader)
                    Me.dgvUserdata.DataSource = dataTable

                    Me.BindingSource1.DataSource = dataTable
                    Me.BindingNavigator1.BindingSource = Me.BindingSource1

                    'show image
                    Dim ImageReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim column As New DataGridViewImageColumn()
                    column.Name = "Image"
                    column.DefaultCellStyle.NullValue = Nothing
                    column.ImageLayout = DataGridViewImageCellLayout.Zoom
                    dgvUserdata.Columns.Insert(0, column)

                    Dim i As Integer
                    If ImageReader.HasRows Then
                        While ImageReader.Read()
                            If ImageReader(11).ToString <> "" Then
                                dgvUserdata.Rows(i).Cells(0).Value = New Bitmap(ImageReader(11).ToString)
                                i += 1
                            End If
                        End While
                    End If
                    ImageReader.Close()

                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("error to load data")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    ' show all datas's function
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

                    Me.BindingSource1.DataSource = dataTable
                    Me.BindingNavigator1.BindingSource = Me.BindingSource1

                    'show image
                    Dim ImageReader As SqlDataReader = SqlCommand.ExecuteReader()
                    Dim i As Integer
                    If ImageReader.HasRows Then
                        While ImageReader.Read()
                            If ImageReader(11).ToString <> "" Then
                                dgvUserdata.Rows(i).Cells(0).Value = New Bitmap(ImageReader(11).ToString)
                                i += 1
                            End If
                        End While
                    End If
                    ImageReader.Close()

                    dataReader.Close()
                Catch ex As Exception
                    MessageBox.Show("No data to show")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    'set the research funciton's SQL Query
    Private Function temptext(ByRef txt As String, ByRef i As Integer) As String
        Dim TempSqlTxt() As String = {"UserFullName like N'%", "UserKataName like N'%", "UserGender like N'%", "UserDepart like N'%", "UserBirth like '%",
            "UserMail like '%", "UserTele like '%", "UserAddress like N'%", "UserEdu like N'%", " UserSpecial like N'%"}
        Dim Sqltxt As String

        If txt <> "" Then
            Sqltxt = TempSqlTxt(i) + txt + "%' and "
            Return Sqltxt
        Else
            Return ""
        End If
    End Function

    'get the research funciton's SQL Query
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

        'delete the end 5 chars-'and' of the query
        If tempSql <> "" Then
            Return tempSql.Substring(0, tempSql.Length - 5)
        Else
            Return tempSql
        End If

    End Function

    'research function
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

                        Me.BindingSource1.DataSource = dataTable
                        Me.BindingNavigator1.BindingSource = Me.BindingSource1

                        'show image
                        Dim ImageReader As SqlDataReader = SqlCommand.ExecuteReader()
                        Dim i As Integer
                        If ImageReader.HasRows Then
                            While ImageReader.Read()
                                If ImageReader(11).ToString <> "" Then
                                    dgvUserdata.Rows(i).Cells(0).Value = New Bitmap(ImageReader(11).ToString)
                                    i += 1
                                End If
                            End While
                        End If
                        ImageReader.Close()

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

    'clear the input research txtbox
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

    'run new employee form
    Private Sub btnNewEpl_Click(sender As Object, e As EventArgs) Handles btnNewEpl.Click
        Dim frm As Form = New newemployee()
        frm.Show()
    End Sub

    'logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
    End Sub

    'check the ID which wanted to update or delete
    Private Function isIdValid() As Boolean
        If txtID.Text = "" Then
            Return False
        ElseIf Regex.IsMatch(txtID.Text, "^\D*$") Then
            txtID.Clear()
            Return False
        Else
            TempID = Int32.Parse(txtID.Text)
            Return True
        End If
    End Function

    'delete data from ID
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If isIdValid() Then
            Using connection As New SqlConnection(My.Settings.connString)
                Const sql2 As String = "delete from employee.UsersData where UserID=@UserID"
                Using SqlCommand As New SqlCommand(sql2, connection)
                    SqlCommand.Parameters.Add(New SqlParameter("@UserID", SqlDbType.Int))
                    SqlCommand.Parameters("@UserID").Value = TempID

                    Try
                        connection.Open()
                        SqlCommand.ExecuteNonQuery()
                        MessageBox.Show("delete the data sucessfully")
                        reset()
                    Catch ex As Exception
                        MessageBox.Show("the selected data can not be canceled")
                    Finally
                        connection.Close()
                    End Try
                End Using
            End Using
        End If
    End Sub

    'show all datas
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        reset()
    End Sub

    'update data from ID
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isIdValid() Then
            'updateがmainに所有されていれば、updateからmainはOwnerプロパティで取得できます.
            Dim frm As Form = New update()
            frm.ShowDialog(Me)
            frm.Dispose()
        End If
    End Sub

    Private Sub chkSerMale_CheckedChanged(sender As Object, e As EventArgs) Handles chkSerMale.CheckedChanged
        chkSerFemale.Checked = False
    End Sub

    Private Sub chkSerFemale_CheckedChanged(sender As Object, e As EventArgs) Handles chkSerFemale.CheckedChanged
        chkSerMale.Checked = False
    End Sub
End Class
