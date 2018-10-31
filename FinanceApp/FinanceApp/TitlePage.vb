Imports System.IO
Public Class TitlePage

    Dim Money As Transaction = New Transaction()

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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)
        WritetoFile()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        SavetoFile()
    End Sub

#Region "Data Table"

    Dim dt As New DataTable

    Sub AddColumnsToGridView()

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

#Region "Functions"
    Sub WritetoFile()

        Dim writefile As String = "C:\Users\Public\Documents/data.txt"

        If System.IO.File.Exists("C:\Users\Public\Documents/data.txt") = True Then
            Dim newWriter As New System.IO.StreamWriter(writefile, True)
            For i As Integer = 0 To DataTransactionList.Rows.Count - 2 Step +1
                For j As Integer = 0 To DataTransactionList.Columns.Count - 1 Step +1
                    newWriter.Write(DataTransactionList.Rows(i).Cells(j).Value.ToString() & ",")
                Next

                newWriter.Write(vbCrLf)

            Next
            newWriter.Close()
            MessageBox.Show("Data Saved")
        Else
            Dim write As TextWriter = New StreamWriter("C:\Users\Public\Documents/data.txt")
            For i As Integer = 0 To DataTransactionList.Rows.Count - 2 Step +1
                For j As Integer = 0 To DataTransactionList.Columns.Count - 1 Step +1
                    write.Write(DataTransactionList.Rows(i).Cells(j).Value.ToString() & ",")
                Next

                write.Write(vbCrLf)

            Next
            write.Close()
            MessageBox.Show("Data Saved")
        End If
    End Sub

    Sub SavetoFile()
        Dim writefile As String = "C:\Users\Public\Documents/data.txt"

        If System.IO.File.Exists("C:\Users\Public\Documents/data.txt") = True Then
            Dim newWriter As New System.IO.StreamWriter(writefile, True)
            For i As Integer = 0 To DataTransactionList.Rows.Count - 2 Step +1
                For j As Integer = 0 To DataTransactionList.Columns.Count - 1 Step +1
                    newWriter.Write(DataTransactionList.Rows(i).Cells(j).Value.ToString() & ",")
                Next

                newWriter.Write(vbCrLf)

            Next
            newWriter.Close()
            MessageBox.Show("Data Saved")
        Else
            Dim write As TextWriter = New StreamWriter("C:\Users\Public\Documents/data.txt")
            For i As Integer = 0 To DataTransactionList.Rows.Count - 2 Step +1
                For j As Integer = 0 To DataTransactionList.Columns.Count - 1 Step +1
                    write.Write(DataTransactionList.Rows(i).Cells(j).Value.ToString() & ",")
                Next

                write.Write(vbCrLf)

            Next
            write.Close()
            MessageBox.Show("Data Saved")
        End If
    End Sub
#End Region
End Class
