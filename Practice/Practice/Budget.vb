Public Class Budgeting
    Private Sub AddTransaction_Click(sender As Object, e As EventArgs) Handles AddTransaction.Click
        'TransactionList.GetItemAt(x TransactionAmount.ToString(), y Categories.ToString())
    End Sub

    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click
        Dim textFileStream As New IO.FileStream("C:\Windows\Temp\test.csv", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        Dim intCounter As Integer
        For intCounter = 0 To 10
            myFileWriter.WriteLine(CStr(intCounter) & ",")
        Next intCounter
        myFileWriter.Close()
        textFileStream.Close()
    End Sub
End Class