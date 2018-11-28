Public Class ReportMenu
    Dim year As String
    Dim month As String
    Dim day As String
    Dim TotalAmount As Double = 0

    Private Sub ReportMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumnsToGridView()
    End Sub

#Region "Data Table"

    Dim dt As New DataTable
    Dim in_Date As String
    Dim in_Description As String
    Dim in_Category As String
    Dim in_Amount As String

    Sub AddColumnsToGridView()

        dt.Columns.Add("Date")
        dt.Columns.Add("Description")
        dt.Columns.Add("Category")
        dt.Columns.Add("Amount")

    End Sub

    Sub UpdateTotal(i As Double)
        TotalAmount = TotalAmount + i
    End Sub

    Sub AddRowToGridView()

        Dim R As DataRow = dt.NewRow

        R("Date") = in_Date
        R("Description") = in_Description
        R("Category") = in_Category
        R("Amount") = in_Amount

        dt.Rows.Add(R)

        reportData.DataSource = dt
        UpdateTotal(in_Amount)
        TextBoxTotalSorted.Text = TotalAmount.ToString()

    End Sub

#End Region

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

    Private Sub YearButton_Click(sender As Object, e As EventArgs) Handles YearButton.Click
        YearReport.Show()
    End Sub

    Private Sub MonthButton_Click(sender As Object, e As EventArgs) Handles MonthButton.Click
        MonthReport.Show()
    End Sub

    Sub GetYear()
        dt.Clear()
        TotalAmount = 0
        TextBoxTotalSorted.Text = TotalAmount.ToString()
        year = YearReport.get_year() 'year input from user
        Dim filePath As String
        Dim line As String
        Dim date_year As String

        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        Dim in_stream As New System.IO.StreamReader(filePath)
        Do While in_stream.Peek() <> -1
            line = in_stream.ReadLine() & vbNewLine
            date_year = line.Substring(GetNthIndex(line, "/", 2) + 1, 4)
            in_Date = line.Substring(0, 10)
            If date_year = year Then
                in_Description = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                in_Category = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
                in_Amount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            End If
        Loop
        If IsDataGridViewEmpty(reportData) = True Then
            MessageBox.Show("No transactions from selected year.")

        Else
        reportData.Sort(reportData.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
        End If
        in_stream.Close()

    End Sub

    Sub GetMonth()
        dt.Clear()
        TotalAmount = 0
        TextBoxTotalSorted.Text = TotalAmount.ToString()
        year = MonthReport.get_year()
        month = MonthReport.get_month()
        Dim filePath As String
        Dim line As String
        Dim date_year As String
        Dim date_month As String

        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        Dim in_stream As New System.IO.StreamReader(filePath)
        Do While in_stream.Peek() <> -1
            line = in_stream.ReadLine() & vbNewLine
            date_month = line.Substring(0, 2)
            date_year = line.Substring(GetNthIndex(line, "/", 2) + 1, 4)
            in_Date = line.Substring(0, 10)
            If date_month = month And date_year = year Then
                in_Description = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                in_Category = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
                in_Amount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            End If
        Loop
        If IsDataGridViewEmpty(reportData) = True Then
            MessageBox.Show("No transactions from selected date.")
            If month > 12 Or month < 1 Then
                MessageBox.Show("Incorrect month number")
            End If
        Else
            reportData.Sort(reportData.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
        End If
        in_stream.Close()

    End Sub

    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function
End Class