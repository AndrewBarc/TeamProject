Public Class YearReport
    Private Sub BuildReport_Click(sender As Object, e As EventArgs) Handles BuildReport.Click
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\TestFolder\test.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        Report.Items.Add(currentField)
                        MsgBox(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line" & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

    End Sub
End Class