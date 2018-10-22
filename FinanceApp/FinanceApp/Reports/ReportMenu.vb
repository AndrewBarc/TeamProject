Public Class ReportMenu
    Private Sub YearButton_Click(sender As Object, e As EventArgs) Handles YearButton.Click
        YearReport.Show()
    End Sub

    Private Sub MonthButton_Click(sender As Object, e As EventArgs) Handles MonthButton.Click
        MonthReport.Show()
    End Sub

    Private Sub SpecificButton_Click(sender As Object, e As EventArgs) Handles SpecificButton.Click
        SpecificReport.Show()
    End Sub
End Class