Public Class YearReport
    Dim year As String
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReportMenu.GetYear()
        Close()
    End Sub

    Function get_year()
        year = TextBox1.Text
        Return year
    End Function
End Class