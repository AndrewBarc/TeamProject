Imports System.IO
Public Class TitlePage

#Region "Form Events"

    Dim Money As Transaction = New Transaction()

    Private Sub TitlePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumnsToGridView()
        Dim filePath As String
        Dim line As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        If System.IO.File.Exists(filePath) Then
            Dim in_stream As New System.IO.StreamReader(filePath)
            Do While in_stream.Peek() <> -1
                line = in_stream.ReadLine() & vbNewLine
                Money.TDate = line.Substring(0, 10)
                Money.TDescription = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                Money.TCategory = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
                Money.TAmount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            Loop
            in_stream.Close()
            If DataTransactionList.Rows.Count = 0 Then
                ' Do Nothing
            Else
                DataTransactionList.Sort(DataTransactionList.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
            End If
        Else
            Dim input As FileStream = File.Create(filePath)
            MessageBox.Show("File 'data.'txt' created in Documents.")
            input.Close()
        End If
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
        ComboBoxCategories.ResetText()

        DataTransactionList.Sort(DataTransactionList.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)

        SavetoFile()
    End Sub

    Private Sub TextBoxTransactionDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTransactionDescription.TextChanged
        UpdateTDescription()
    End Sub

    Private Sub TextBoxTransactionAmount_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTransactionAmount.TextChanged
        UpdateTAmount()
    End Sub

    Private Sub RadioButtonIncome_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIncome.CheckedChanged
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

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If DataTransactionList.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim DAmount As Double = DataTransactionList.CurrentRow.Cells(3).Value
        If DAmount < 0 Then
            TotalAmount = TotalAmount - DAmount
        Else
            UpdateTotal(DAmount)
        End If
        TextBoxTotal.Text = TotalAmount.ToString()
        DataTransactionList.Rows.Remove(DataTransactionList.CurrentRow)

        SavetoFile()
    End Sub

    Private Sub TitlePage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SavetoFile()
        MessageBox.Show("Data Saved")
    End Sub

    Private Sub ButtonHelp_Click(sender As Object, e As EventArgs) Handles ButtonHelp.Click
        Dim helpvideo As String = "https://drive.google.com/open?id=1D74ad66l9pdkRWIvbFJVCFgYlA6M2Mz4"
        Process.Start(helpvideo)
    End Sub

#End Region

#Region "Data Table"

    Dim dt As New DataTable

    Dim TotalAmount As Double = 0

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
        UpdateTotal(Money.TAmount)
        TextBoxTotal.Text = TotalAmount.ToString()

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

        UpdateButton()
    End Sub

    Sub UpdateTDate()
        Money.TDate = MaskedTextBoxTransactionDate.Text
        UpdateButton()
    End Sub

    Sub UpdateTDescription()
        Money.TDescription = TextBoxTransactionDescription.Text
        UpdateButton()
    End Sub

    Sub UpdateTCategory()
        Money.TCategory = ComboBoxCategories.Text
        UpdateButton()
    End Sub

#End Region

#Region "Functions"

    Sub UpdateTotal(i As Double)
        TotalAmount = TotalAmount + i
    End Sub

    Sub SavetoFile()
        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        My.Computer.FileSystem.DeleteFile(filePath)

        Dim newWriter As New System.IO.StreamWriter(filePath, True)
        For i As Integer = 0 To DataTransactionList.Rows.Count - 2 Step +1
            For j As Integer = 0 To DataTransactionList.Columns.Count - 1 Step +1
                newWriter.Write(DataTransactionList.Rows(i).Cells(j).Value.ToString() & ",")
            Next

            newWriter.Write(vbCrLf)

        Next
        newWriter.Close()
    End Sub

    Sub UpdateButton()
        If TextBoxTransactionAmount.Text = "" Or TextBoxTransactionDescription.Text = "" _
            Or ComboBoxCategories.Text = "" Or MaskedTextBoxTransactionDate.Text = "  /  /    " _
            Or (Not (RadioButtonExpense.Checked) And Not (RadioButtonIncome.Checked)) Then
            ButtonAddTransaction.Enabled = False
        Else
            ButtonAddTransaction.Enabled = True
        End If
    End Sub


    Public Function GetNthIndex(s As String, t As Char, n As Integer) As Integer
        Dim count As Integer = 0
        For i As Integer = 0 To s.Length - 1
            If s(i) = t Then
                count += 1
                If count = n Then
                    Return i
                End If
            End If
        Next
        Return -1
    End Function

#End Region

End Class
