Public Class ReportMenu
    Dim year As String
    Dim month As String
    Dim day As String

    Private Sub YearButton_Click(sender As Object, e As EventArgs) Handles YearButton.Click
        YearReport.Show()
        year = YearReport.get_year()


    End Sub
    ' write more functions and less whatever subs are
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Items.Add(year)
    End Sub

    Private Sub MonthButton_Click(sender As Object, e As EventArgs) Handles MonthButton.Click
        MsgBox(year)
    End Sub
End Class