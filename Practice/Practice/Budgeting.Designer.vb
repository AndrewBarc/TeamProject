<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Budgeting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.AddTransaction = New System.Windows.Forms.Button()
        Me.Categories = New System.Windows.Forms.ComboBox()
        Me.TransactionAmount = New System.Windows.Forms.TextBox()
        Me.TransactionList = New System.Windows.Forms.ListView()
        Me.Excel = New System.Windows.Forms.Button()
        Me.OtherList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AddTransaction
        '
        Me.AddTransaction.Location = New System.Drawing.Point(12, 12)
        Me.AddTransaction.Name = "AddTransaction"
        Me.AddTransaction.Size = New System.Drawing.Size(94, 32)
        Me.AddTransaction.TabIndex = 0
        Me.AddTransaction.Text = "Add Transaction"
        Me.AddTransaction.UseVisualStyleBackColor = True
        '
        'Categories
        '
        Me.Categories.FormattingEnabled = True
        Me.Categories.Items.AddRange(New Object() {"Groceries", "Clothes", "Transportation", "School", "Entertainment"})
        Me.Categories.Location = New System.Drawing.Point(113, 22)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(121, 21)
        Me.Categories.TabIndex = 1
        '
        'TransactionAmount
        '
        Me.TransactionAmount.Location = New System.Drawing.Point(241, 24)
        Me.TransactionAmount.Name = "TransactionAmount"
        Me.TransactionAmount.Size = New System.Drawing.Size(86, 20)
        Me.TransactionAmount.TabIndex = 2
        '
        'TransactionList
        '
        Me.TransactionList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TransactionList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.TransactionList.Location = New System.Drawing.Point(13, 51)
        Me.TransactionList.Name = "TransactionList"
        Me.TransactionList.Size = New System.Drawing.Size(314, 107)
        Me.TransactionList.TabIndex = 3
        Me.TransactionList.UseCompatibleStateImageBehavior = False
        '
        'Excel
        '
        Me.Excel.Location = New System.Drawing.Point(13, 346)
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(314, 49)
        Me.Excel.TabIndex = 4
        Me.Excel.Text = "Excel"
        Me.Excel.UseVisualStyleBackColor = True
        '
        'OtherList
        '
        Me.OtherList.ColumnWidth = 50
        Me.OtherList.FormattingEnabled = True
        Me.OtherList.Location = New System.Drawing.Point(13, 165)
        Me.OtherList.Name = "OtherList"
        Me.OtherList.Size = New System.Drawing.Size(314, 173)
        Me.OtherList.TabIndex = 5
        '
        'Budgeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 407)
        Me.Controls.Add(Me.OtherList)
        Me.Controls.Add(Me.Excel)
        Me.Controls.Add(Me.TransactionList)
        Me.Controls.Add(Me.TransactionAmount)
        Me.Controls.Add(Me.Categories)
        Me.Controls.Add(Me.AddTransaction)
        Me.Name = "Budgeting"
        Me.Text = "Budgeting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddTransaction As Button
    Friend WithEvents Categories As ComboBox
    Friend WithEvents TransactionAmount As TextBox
    Friend WithEvents TransactionList As ListView
    Friend WithEvents Excel As Button
    Friend WithEvents OtherList As ListBox
End Class
