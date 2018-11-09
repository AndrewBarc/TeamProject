Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.35404!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.64596!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 486)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MonthCalendar1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.52381!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.47619!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(237, 301)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 53)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a date to view transactions from that date"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.MaskedTextBox1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 310)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4386!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.5614!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(237, 173)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskedTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(231, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.SearchButton, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ComboBox1, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 0, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(231, 123)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'SearchButton
        '
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchButton.Location = New System.Drawing.Point(3, 3)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(225, 23)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search By Date"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bills", "Dining", "Education", "Entertainment", "Groceries", "Health Care", "Home", "Job Income", "Office", "Personal Care", "Pets", "Shopping", "Travel"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a Category to Search all Transactions by"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(3, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search By Category"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(243, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(306, 486)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(300, 480)
        Me.DataGridView1.TabIndex = 0
        '
        'Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(549, 486)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Finance - Calendar"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel

    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Sub AddRowToGridView()

        Dim R As DataRow = dt.NewRow

        R("Date") = in_Date
        R("Description") = in_Description
        R("Category") = in_Category
        R("Amount") = in_Amount

        dt.Rows.Add(R)

        DataGridView1.DataSource = dt

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

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView


    Friend WithEvents MaskedTextBox1 As MaskedTextBox

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents SearchButton As Button

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
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
        in_stream.Close()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        in_stream.Close()
    End Sub
End Class