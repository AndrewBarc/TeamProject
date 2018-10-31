Public Class TitlePage

    Dim Money As Transaction = New Transaction()
    Dim count As Integer = 1

    Private Sub TitlePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumnsToGridView()
    End Sub

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
        AddRowToGridView()

        TCollection.Add(Money)
        count = count + 1
        TextBoxTransactionDescription.Clear()
        MaskedTextBoxTransactionDate.Clear()
        TextBoxTransactionAmount.Clear()

    End Sub

    Private Sub TextBoxTransactionDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTransactionDescription.TextChanged
        UpdateTDescription()
    End Sub

    Private Sub TextBoxTransactionAmount_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTransactionAmount.TextChanged
        UpdateTAmount()
    End Sub

    Private Sub RadioButtonIncome_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonExpense.CheckedChanged
        UpdateTAmount()
    End Sub

    Private Sub RadioButtonExpense_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonExpense.CheckedChanged
        UpdateTAmount()
    End Sub

    Private Sub ComboBoxCategories_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxCategories.SelectedValueChanged
        UpdateTCategory()
    End Sub

    Private Sub MaskedTextBoxTransactionDate_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxTransactionDate.TextChanged
        UpdateTDate()
    End Sub

#Region "Array"
    Dim TCollection As New List(Of Transaction)
#End Region

#Region "Data Table"

    Dim dt As New DataTable

    Sub AddColumnsToGridView()

        dt.Columns.Add("ID")
        dt.Columns(0).AutoIncrement = True

        dt.Columns.Add("Date")
        dt.Columns.Add("Description")
        dt.Columns.Add("Category")
        dt.Columns.Add("Amount")

    End Sub

    Sub AddRowToGridView()

        Dim R As DataRow = dt.NewRow

        R("Date") = Money.TDate
        R("Description") = Money.TDescription
        R("Category") = Money.TCategory
        R("Amount") = Money.TAmount

        dt.Rows.Add(R)

        DataTransactionList.DataSource = dt

    End Sub

#End Region

#Region "Updating Transaction Variables"

    Sub UpdateTAmount()
        If TextBoxTransactionAmount.Text = "" Then
            'Do Nothing
        Else
            Dim sign As Integer
            If RadioButtonIncome.Checked Then
                sign = 1
            ElseIf RadioButtonExpense.Checked Then
                sign = -1
            End If
            Money.TAmount = CDbl(TextBoxTransactionAmount.Text) * sign
        End If
    End Sub

    Sub UpdateTDate()
        Money.TDate = MaskedTextBoxTransactionDate.Text
    End Sub

    Sub UpdateTDescription()
        Money.TDescription = TextBoxTransactionDescription.Text
    End Sub

    Sub UpdateTCategory()
        Money.TCategory = ComboBoxCategories.Text
    End Sub

#End Region

End Class
