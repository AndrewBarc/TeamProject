Public Class TitlePage

    Dim Money As Transaction = New Transaction()

    Private Sub ButtonBudgeting_Click(sender As Object, e As EventArgs) Handles ButtonBudgeting.Click
        Budgeting.Show()
    End Sub

    Private Sub ButtonCalendar_Click(sender As Object, e As EventArgs) Handles ButtonCalendar.Click
        Calendar.Show()
    End Sub

    Private Sub ButtonReports_Click(sender As Object, e As EventArgs) Handles ButtonReports.Click
        ReportMenu.Show()
    End Sub

    Private Sub ButtonAddTransaction_Click(sender As Object, e As EventArgs) Handles ButtonAddTransaction.Click
        TCollection.Add(Money)
        MsgBox(Money.TDescription)
        'DataTransactionList.Columns.Add(MaskedTextBoxTransactionDate.Text)
    End Sub

    Private Sub TextBoxTransactionDescription_Leave(sender As Object, e As EventArgs) Handles TextBoxTransactionDescription.Leave
        Money.TDescription = TextBoxTransactionDescription.Text
    End Sub

#Region "Array"
    Dim TCollection As New List(Of Transaction)
#End Region

#Region "Functions"

    'Dim dt As New DataTable

    'Sub AddRowToGridView()

    'Dim R As DataRow = dt.NewRow

    '   R("Date") = Money.TDate
    '  R("Description") = Money.TDescription
    ' R("Amount") = Money.TAmount

    'dt.Rows.Add(R)

    'End Sub
#End Region

End Class
