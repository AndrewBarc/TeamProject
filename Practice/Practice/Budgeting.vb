Public Class Budgeting
    Private Sub AddTransaction_Click(sender As Object, e As EventArgs) Handles AddTransaction.Click
        TransactionList.Items.Add(TransactionAmount.Text + " " + Categories.Text)
        OtherList.Items.Add(TransactionAmount.Text + " " + Categories.Text)
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
        Dim test As String = "C:\Windows\Temp\test.csv"

        If System.IO.File.Exists(test) = True Then
            Process.Start(test)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub
End Class