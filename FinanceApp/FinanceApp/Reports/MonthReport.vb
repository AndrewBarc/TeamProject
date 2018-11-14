Public Class MonthReport
    Dim year As String
    Dim month As String

    Public Sub MonthButton_Click(sender As Object, e As EventArgs) Handles MonthButton.Click
        ReportMenu.GetMonth()
        Close()
    End Sub

    Function get_year()
        year = YearBox.Text
        Return year
    End Function

    Function get_month()
        month = MonthBox.Text
        Return month
    End Function
End Class