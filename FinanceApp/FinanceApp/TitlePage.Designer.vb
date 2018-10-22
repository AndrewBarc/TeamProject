<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitlePage
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
        Me.UpperContainer1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LowerContainer1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BoxAddTransaction = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTransactionDate = New System.Windows.Forms.Label()
        Me.TextBoxTransactionAmount = New System.Windows.Forms.TextBox()
        Me.LabelTransactionAmount = New System.Windows.Forms.Label()
        Me.TextBoxTransactionDescription = New System.Windows.Forms.TextBox()
        Me.LabelTransactionDescription = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButtonIncome = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOutcome = New System.Windows.Forms.RadioButton()
        Me.ButtonAddTransaction = New System.Windows.Forms.Button()
        Me.MaskedTextBoxTransactionDate = New System.Windows.Forms.MaskedTextBox()
        Me.BoxMenu = New System.Windows.Forms.GroupBox()
        Me.LayoutPanelMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonReports = New System.Windows.Forms.Button()
        Me.ButtonCalendar = New System.Windows.Forms.Button()
        Me.ButtonBudgeting = New System.Windows.Forms.Button()
        Me.ListBoxTransactions = New System.Windows.Forms.ListBox()
        Me.LowerContainer1.SuspendLayout()
        Me.BoxAddTransaction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.BoxMenu.SuspendLayout()
        Me.LayoutPanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpperContainer1
        '
        Me.UpperContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpperContainer1.Location = New System.Drawing.Point(12, 12)
        Me.UpperContainer1.Name = "UpperContainer1"
        Me.UpperContainer1.Size = New System.Drawing.Size(870, 100)
        Me.UpperContainer1.TabIndex = 0
        '
        'LowerContainer1
        '
        Me.LowerContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LowerContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.LowerContainer1.ColumnCount = 3
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.Controls.Add(Me.BoxAddTransaction, 0, 0)
        Me.LowerContainer1.Controls.Add(Me.BoxMenu, 2, 0)
        Me.LowerContainer1.Controls.Add(Me.ListBoxTransactions, 1, 0)
        Me.LowerContainer1.Location = New System.Drawing.Point(12, 118)
        Me.LowerContainer1.Name = "LowerContainer1"
        Me.LowerContainer1.RowCount = 1
        Me.LowerContainer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LowerContainer1.Size = New System.Drawing.Size(870, 343)
        Me.LowerContainer1.TabIndex = 1
        '
        'BoxAddTransaction
        '
        Me.BoxAddTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BoxAddTransaction.Controls.Add(Me.TableLayoutPanel1)
        Me.BoxAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxAddTransaction.Location = New System.Drawing.Point(3, 3)
        Me.BoxAddTransaction.Name = "BoxAddTransaction"
        Me.BoxAddTransaction.Size = New System.Drawing.Size(255, 337)
        Me.BoxAddTransaction.TabIndex = 0
        Me.BoxAddTransaction.TabStop = False
        Me.BoxAddTransaction.Text = "Create a Transaction"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionDate, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTransactionAmount, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionAmount, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTransactionDescription, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionDescription, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAddTransaction, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBoxTransactionDate, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 318)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelTransactionDate
        '
        Me.LabelTransactionDate.AutoSize = True
        Me.LabelTransactionDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDate.Location = New System.Drawing.Point(3, 197)
        Me.LabelTransactionDate.Name = "LabelTransactionDate"
        Me.LabelTransactionDate.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionDate.TabIndex = 4
        Me.LabelTransactionDate.Text = "Transaction Date"
        Me.LabelTransactionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxTransactionAmount
        '
        Me.TextBoxTransactionAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionAmount.Location = New System.Drawing.Point(3, 108)
        Me.TextBoxTransactionAmount.Name = "TextBoxTransactionAmount"
        Me.TextBoxTransactionAmount.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxTransactionAmount.TabIndex = 3
        '
        'LabelTransactionAmount
        '
        Me.LabelTransactionAmount.AutoSize = True
        Me.LabelTransactionAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionAmount.Location = New System.Drawing.Point(3, 92)
        Me.LabelTransactionAmount.Name = "LabelTransactionAmount"
        Me.LabelTransactionAmount.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionAmount.TabIndex = 2
        Me.LabelTransactionAmount.Text = "Transaction Amount"
        Me.LabelTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxTransactionDescription
        '
        Me.TextBoxTransactionDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionDescription.Location = New System.Drawing.Point(3, 38)
        Me.TextBoxTransactionDescription.Name = "TextBoxTransactionDescription"
        Me.TextBoxTransactionDescription.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxTransactionDescription.TabIndex = 0
        '
        'LabelTransactionDescription
        '
        Me.LabelTransactionDescription.AutoSize = True
        Me.LabelTransactionDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDescription.Location = New System.Drawing.Point(3, 22)
        Me.LabelTransactionDescription.Name = "LabelTransactionDescription"
        Me.LabelTransactionDescription.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionDescription.TabIndex = 1
        Me.LabelTransactionDescription.Text = "Transaction Description"
        Me.LabelTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonIncome, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButtonOutcome, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 143)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(243, 29)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'RadioButtonIncome
        '
        Me.RadioButtonIncome.AutoSize = True
        Me.RadioButtonIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButtonIncome.Location = New System.Drawing.Point(3, 3)
        Me.RadioButtonIncome.Name = "RadioButtonIncome"
        Me.RadioButtonIncome.Size = New System.Drawing.Size(115, 23)
        Me.RadioButtonIncome.TabIndex = 0
        Me.RadioButtonIncome.TabStop = True
        Me.RadioButtonIncome.Text = "Income"
        Me.RadioButtonIncome.UseVisualStyleBackColor = True
        '
        'RadioButtonOutcome
        '
        Me.RadioButtonOutcome.AutoSize = True
        Me.RadioButtonOutcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButtonOutcome.Location = New System.Drawing.Point(124, 3)
        Me.RadioButtonOutcome.Name = "RadioButtonOutcome"
        Me.RadioButtonOutcome.Size = New System.Drawing.Size(116, 23)
        Me.RadioButtonOutcome.TabIndex = 1
        Me.RadioButtonOutcome.TabStop = True
        Me.RadioButtonOutcome.Text = "Outcome"
        Me.RadioButtonOutcome.UseVisualStyleBackColor = True
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(3, 248)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(243, 67)
        Me.ButtonAddTransaction.TabIndex = 7
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxTransactionDate
        '
        Me.MaskedTextBoxTransactionDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaskedTextBoxTransactionDate.Location = New System.Drawing.Point(3, 213)
        Me.MaskedTextBoxTransactionDate.Mask = "00/00/0000"
        Me.MaskedTextBoxTransactionDate.Name = "MaskedTextBoxTransactionDate"
        Me.MaskedTextBoxTransactionDate.Size = New System.Drawing.Size(243, 20)
        Me.MaskedTextBoxTransactionDate.TabIndex = 8
        Me.MaskedTextBoxTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxTransactionDate.ValidatingType = GetType(Date)
        '
        'BoxMenu
        '
        Me.BoxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.BoxMenu.Controls.Add(Me.LayoutPanelMenu)
        Me.BoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxMenu.Location = New System.Drawing.Point(612, 3)
        Me.BoxMenu.Name = "BoxMenu"
        Me.BoxMenu.Size = New System.Drawing.Size(255, 337)
        Me.BoxMenu.TabIndex = 1
        Me.BoxMenu.TabStop = False
        Me.BoxMenu.Text = "Menu"
        '
        'LayoutPanelMenu
        '
        Me.LayoutPanelMenu.ColumnCount = 1
        Me.LayoutPanelMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LayoutPanelMenu.Controls.Add(Me.ButtonHelp, 0, 3)
        Me.LayoutPanelMenu.Controls.Add(Me.ButtonReports, 0, 2)
        Me.LayoutPanelMenu.Controls.Add(Me.ButtonCalendar, 0, 1)
        Me.LayoutPanelMenu.Controls.Add(Me.ButtonBudgeting, 0, 0)
        Me.LayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutPanelMenu.Location = New System.Drawing.Point(3, 16)
        Me.LayoutPanelMenu.Name = "LayoutPanelMenu"
        Me.LayoutPanelMenu.RowCount = 4
        Me.LayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LayoutPanelMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LayoutPanelMenu.Size = New System.Drawing.Size(249, 318)
        Me.LayoutPanelMenu.TabIndex = 0
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonHelp.Location = New System.Drawing.Point(10, 247)
        Me.ButtonHelp.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(229, 61)
        Me.ButtonHelp.TabIndex = 3
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonReports
        '
        Me.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReports.Location = New System.Drawing.Point(10, 168)
        Me.ButtonReports.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(229, 59)
        Me.ButtonReports.TabIndex = 2
        Me.ButtonReports.Text = "Financial Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
        '
        'ButtonCalendar
        '
        Me.ButtonCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalendar.Location = New System.Drawing.Point(10, 89)
        Me.ButtonCalendar.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonCalendar.Name = "ButtonCalendar"
        Me.ButtonCalendar.Size = New System.Drawing.Size(229, 59)
        Me.ButtonCalendar.TabIndex = 1
        Me.ButtonCalendar.Text = "Calendar"
        Me.ButtonCalendar.UseVisualStyleBackColor = True
        '
        'ButtonBudgeting
        '
        Me.ButtonBudgeting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBudgeting.Location = New System.Drawing.Point(10, 10)
        Me.ButtonBudgeting.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonBudgeting.Name = "ButtonBudgeting"
        Me.ButtonBudgeting.Size = New System.Drawing.Size(229, 59)
        Me.ButtonBudgeting.TabIndex = 0
        Me.ButtonBudgeting.Text = "Budgeting"
        Me.ButtonBudgeting.UseVisualStyleBackColor = True
        '
        'ListBoxTransactions
        '
        Me.ListBoxTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxTransactions.FormattingEnabled = True
        Me.ListBoxTransactions.Location = New System.Drawing.Point(264, 3)
        Me.ListBoxTransactions.MultiColumn = True
        Me.ListBoxTransactions.Name = "ListBoxTransactions"
        Me.ListBoxTransactions.Size = New System.Drawing.Size(342, 337)
        Me.ListBoxTransactions.Sorted = True
        Me.ListBoxTransactions.TabIndex = 2
        '
        'TitlePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(894, 473)
        Me.Controls.Add(Me.LowerContainer1)
        Me.Controls.Add(Me.UpperContainer1)
        Me.MinimumSize = New System.Drawing.Size(683, 384)
        Me.Name = "TitlePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        Me.LowerContainer1.ResumeLayout(False)
        Me.BoxAddTransaction.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.BoxMenu.ResumeLayout(False)
        Me.LayoutPanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpperContainer1 As FlowLayoutPanel
    Friend WithEvents LowerContainer1 As TableLayoutPanel
    Friend WithEvents BoxAddTransaction As GroupBox
    Friend WithEvents BoxMenu As GroupBox
    Friend WithEvents LayoutPanelMenu As TableLayoutPanel
    Friend WithEvents ButtonHelp As Button
    Friend WithEvents ButtonReports As Button
    Friend WithEvents ButtonCalendar As Button
    Friend WithEvents ButtonBudgeting As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelTransactionAmount As Label
    Friend WithEvents TextBoxTransactionDescription As TextBox
    Friend WithEvents LabelTransactionDescription As Label
    Friend WithEvents LabelTransactionDate As Label
    Friend WithEvents TextBoxTransactionAmount As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RadioButtonIncome As RadioButton
    Friend WithEvents RadioButtonOutcome As RadioButton
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents ListBoxTransactions As ListBox
    Friend WithEvents MaskedTextBoxTransactionDate As MaskedTextBox
End Class
