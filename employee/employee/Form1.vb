Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim column As New DataGridViewImageColumn()
        Dim fname As String
        column.Name = "Image"
        column.DefaultCellStyle.NullValue = Nothing
        fname = "C:\Users\2015NEC21\Downloads\課題演習\Myportfolio0528ソート修正\Myportfolio\img\logo.jpg"
        column.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridView1.Columns.Add(column)
        DataGridView1.Rows(0).Cells(0).Value = New Bitmap(fname)
    End Sub
End Class