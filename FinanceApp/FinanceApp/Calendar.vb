Imports System.IO
Public Class Calendar

#Region "Form Events"

    Dim TotalAmount As Double = 0

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddColumnsToGridView()
        Dim filePath As String
        Dim line As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        Dim in_stream As New System.IO.StreamReader(filePath)
        Dim currentDate As String = DateTime.Now.ToString("MM/dd/yyyy")

        Do While in_stream.Peek() <> -1
            line = in_stream.ReadLine() & vbNewLine
            in_Date = line.Substring(0, 10)
            If in_Date = currentDate Then
                in_Description = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                in_Category = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
                in_Amount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            End If
        Loop
        ' DataGridView1.Sort(DataGridView1.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
        in_stream.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dt.Rows.Clear()
        Dim filePath As String
        Dim line As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        Dim in_stream As New System.IO.StreamReader(filePath)
        Do While in_stream.Peek() <> -1
            line = in_stream.ReadLine() & vbNewLine
            in_Category = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
            If in_Category = ComboBox1.Text Then
                in_Date = line.Substring(0, 10)
                in_Description = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                in_Amount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            End If
        Loop
        DataGridView1.Sort(DataGridView1.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
        in_stream.Close()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        dt.Clear()
        Dim filePath As String
        Dim line As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "data.txt")
        Dim in_stream As New System.IO.StreamReader(filePath)
        Do While in_stream.Peek() <> -1
            line = in_stream.ReadLine() & vbNewLine
            in_Date = line.Substring(0, 10)
            If in_Date = MaskedTextBox1.Text Then
                in_Description = line.Substring(GetNthIndex(line, ",", 1) + 1, (GetNthIndex(line, ",", 2) - GetNthIndex(line, ",", 1)) - 1)
                in_Category = line.Substring(GetNthIndex(line, ",", 2) + 1, GetNthIndex(line, ",", 3) - (GetNthIndex(line, ",", 2)) - 1)
                in_Amount = line.Substring(GetNthIndex(line, ",", 3) + 1, GetNthIndex(line, ",", 4) - (GetNthIndex(line, ",", 3)) - 1)
                AddRowToGridView()
            End If
        Loop
        DataGridView1.Sort(DataGridView1.Columns("Date"), System.ComponentModel.ListSortDirection.Descending)
        in_stream.Close()
    End Sub

#End Region

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

    Sub AddRowToGridView()

        Dim R As DataRow = dt.NewRow

        R("Date") = in_Date
        R("Description") = in_Description
        R("Category") = in_Category
        R("Amount") = in_Amount

        dt.Rows.Add(R)

        DataGridView1.DataSource = dt
        UpdateTotal(in_Amount)
        TextBox1.Text = TotalAmount.ToString()

    End Sub

#End Region

#Region "Functions"

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

    Sub UpdateTotal(i As Double)
        TotalAmount = TotalAmount + i
    End Sub

#End Region

End Class