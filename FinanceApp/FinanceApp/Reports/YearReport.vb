Public Class YearReport
    Dim year As String
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub YearComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearComboBox.SelectedIndexChanged
        year = YearComboBox.Text
        MsgBox(year)
    End Sub

    Function get_year()
        Return year
    End Function
End Class