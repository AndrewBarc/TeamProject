<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TitlePage
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
        Me.UpperContainer1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LowerContainer1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BoxAddTransaction = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTransactionAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonExpense = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIncome = New System.Windows.Forms.RadioButton()
        Me.LabelTransactionDate = New System.Windows.Forms.Label()
        Me.TextBoxTransactionAmount = New System.Windows.Forms.TextBox()
        Me.TextBoxTransactionDescription = New System.Windows.Forms.TextBox()
        Me.LabelTransactionDescription = New System.Windows.Forms.Label()
        Me.ButtonAddTransaction = New System.Windows.Forms.Button()
        Me.MaskedTextBoxTransactionDate = New System.Windows.Forms.MaskedTextBox()
        Me.LabelCategory = New System.Windows.Forms.Label()
        Me.ComboBoxCategories = New System.Windows.Forms.ComboBox()
        Me.BoxMenu = New System.Windows.Forms.GroupBox()
        Me.LayoutPanelMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonReports = New System.Windows.Forms.Button()
        Me.ButtonCalendar = New System.Windows.Forms.Button()
        Me.ButtonBudgeting = New System.Windows.Forms.Button()
        Me.DataTransactionList = New System.Windows.Forms.DataGridView()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LowerContainer1.SuspendLayout()
        Me.BoxAddTransaction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BoxMenu.SuspendLayout()
        Me.LayoutPanelMenu.SuspendLayout()
        CType(Me.DataTransactionList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LowerContainer1.Controls.Add(Me.DataTransactionList, 1, 0)
        Me.LowerContainer1.Location = New System.Drawing.Point(12, 118)
        Me.LowerContainer1.Name = "LowerContainer1"
        Me.LowerContainer1.RowCount = 1
        Me.LowerContainer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LowerContainer1.Size = New System.Drawing.Size(870, 322)
        Me.LowerContainer1.TabIndex = 1
        '
        'BoxAddTransaction
        '
        Me.BoxAddTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BoxAddTransaction.Controls.Add(Me.TableLayoutPanel1)
        Me.BoxAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxAddTransaction.Location = New System.Drawing.Point(3, 3)
        Me.BoxAddTransaction.Name = "BoxAddTransaction"
        Me.BoxAddTransaction.Size = New System.Drawing.Size(255, 316)
        Me.BoxAddTransaction.TabIndex = 0
        Me.BoxAddTransaction.TabStop = False
        Me.BoxAddTransaction.Text = "Create a Transaction"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionAmount, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionDate, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTransactionAmount, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxTransactionDescription, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTransactionDescription, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAddTransaction, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBoxTransactionDate, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelCategory, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxCategories, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 297)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelTransactionAmount
        '
        Me.LabelTransactionAmount.AutoSize = True
        Me.LabelTransactionAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionAmount.Location = New System.Drawing.Point(3, 161)
        Me.LabelTransactionAmount.Name = "LabelTransactionAmount"
        Me.LabelTransactionAmount.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionAmount.TabIndex = 13
        Me.LabelTransactionAmount.Text = "Transaction Amount"
        Me.LabelTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButtonExpense)
        Me.Panel1.Controls.Add(Me.RadioButtonIncome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 23)
        Me.Panel1.TabIndex = 12
        '
        'RadioButtonExpense
        '
        Me.RadioButtonExpense.AutoSize = True
        Me.RadioButtonExpense.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadioButtonExpense.Location = New System.Drawing.Point(147, 0)
        Me.RadioButtonExpense.Name = "RadioButtonExpense"
        Me.RadioButtonExpense.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.RadioButtonExpense.Size = New System.Drawing.Size(96, 23)
        Me.RadioButtonExpense.TabIndex = 4
        Me.RadioButtonExpense.TabStop = True
        Me.RadioButtonExpense.Text = "Expense"
        Me.RadioButtonExpense.UseVisualStyleBackColor = True
        '
        'RadioButtonIncome
        '
        Me.RadioButtonIncome.AutoSize = True
        Me.RadioButtonIncome.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadioButtonIncome.Location = New System.Drawing.Point(0, 0)
        Me.RadioButtonIncome.Name = "RadioButtonIncome"
        Me.RadioButtonIncome.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.RadioButtonIncome.Size = New System.Drawing.Size(90, 23)
        Me.RadioButtonIncome.TabIndex = 3
        Me.RadioButtonIncome.TabStop = True
        Me.RadioButtonIncome.Text = "Income"
        Me.RadioButtonIncome.UseVisualStyleBackColor = True
        '
        'LabelTransactionDate
        '
        Me.LabelTransactionDate.AutoSize = True
        Me.LabelTransactionDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDate.Location = New System.Drawing.Point(3, 219)
        Me.LabelTransactionDate.Name = "LabelTransactionDate"
        Me.LabelTransactionDate.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionDate.TabIndex = 4
        Me.LabelTransactionDate.Text = "Transaction Date"
        Me.LabelTransactionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxTransactionAmount
        '
        Me.TextBoxTransactionAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionAmount.Location = New System.Drawing.Point(3, 177)
        Me.TextBoxTransactionAmount.Name = "TextBoxTransactionAmount"
        Me.TextBoxTransactionAmount.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxTransactionAmount.TabIndex = 2
        '
        'TextBoxTransactionDescription
        '
        Me.TextBoxTransactionDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionDescription.Location = New System.Drawing.Point(3, 32)
        Me.TextBoxTransactionDescription.MaxLength = 40
        Me.TextBoxTransactionDescription.Name = "TextBoxTransactionDescription"
        Me.TextBoxTransactionDescription.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxTransactionDescription.TabIndex = 0
        '
        'LabelTransactionDescription
        '
        Me.LabelTransactionDescription.AutoSize = True
        Me.LabelTransactionDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDescription.Location = New System.Drawing.Point(3, 16)
        Me.LabelTransactionDescription.Name = "LabelTransactionDescription"
        Me.LabelTransactionDescription.Size = New System.Drawing.Size(243, 13)
        Me.LabelTransactionDescription.TabIndex = 1
        Me.LabelTransactionDescription.Text = "Transaction Description"
        Me.LabelTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(3, 264)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(243, 30)
        Me.ButtonAddTransaction.TabIndex = 6
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxTransactionDate
        '
        Me.MaskedTextBoxTransactionDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaskedTextBoxTransactionDate.Location = New System.Drawing.Point(3, 235)
        Me.MaskedTextBoxTransactionDate.Mask = "00/00/0000"
        Me.MaskedTextBoxTransactionDate.Name = "MaskedTextBoxTransactionDate"
        Me.MaskedTextBoxTransactionDate.Size = New System.Drawing.Size(243, 20)
        Me.MaskedTextBoxTransactionDate.TabIndex = 5
        Me.MaskedTextBoxTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxTransactionDate.ValidatingType = GetType(Date)
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelCategory.Location = New System.Drawing.Point(3, 74)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(243, 13)
        Me.LabelCategory.TabIndex = 9
        Me.LabelCategory.Text = "Transaction Category"
        Me.LabelCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxCategories
        '
        Me.ComboBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCategories.FormattingEnabled = True
        Me.ComboBoxCategories.Items.AddRange(New Object() {"Bills", "Dining", "Education", "Entertainment", "Groceries", "Health Care", "Home", "Office", "Personal Care", "Pets", "Shopping", "Travel", "Job Income"})
        Me.ComboBoxCategories.Location = New System.Drawing.Point(3, 90)
        Me.ComboBoxCategories.Name = "ComboBoxCategories"
        Me.ComboBoxCategories.Size = New System.Drawing.Size(243, 21)
        Me.ComboBoxCategories.TabIndex = 1
        '
        'BoxMenu
        '
        Me.BoxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.BoxMenu.Controls.Add(Me.LayoutPanelMenu)
        Me.BoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxMenu.Location = New System.Drawing.Point(612, 3)
        Me.BoxMenu.Name = "BoxMenu"
        Me.BoxMenu.Size = New System.Drawing.Size(255, 316)
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
        Me.LayoutPanelMenu.Size = New System.Drawing.Size(249, 297)
        Me.LayoutPanelMenu.TabIndex = 0
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonHelp.Location = New System.Drawing.Point(10, 232)
        Me.ButtonHelp.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(229, 55)
        Me.ButtonHelp.TabIndex = 3
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonReports
        '
        Me.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReports.Location = New System.Drawing.Point(10, 158)
        Me.ButtonReports.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(229, 54)
        Me.ButtonReports.TabIndex = 2
        Me.ButtonReports.Text = "Financial Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
        '
        'ButtonCalendar
        '
        Me.ButtonCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalendar.Location = New System.Drawing.Point(10, 84)
        Me.ButtonCalendar.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonCalendar.Name = "ButtonCalendar"
        Me.ButtonCalendar.Size = New System.Drawing.Size(229, 54)
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
        Me.ButtonBudgeting.Size = New System.Drawing.Size(229, 54)
        Me.ButtonBudgeting.TabIndex = 0
        Me.ButtonBudgeting.Text = "Budgeting"
        Me.ButtonBudgeting.UseVisualStyleBackColor = True
        '
        'DataTransactionList
        '
        Me.DataTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTransactionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTransactionList.Location = New System.Drawing.Point(264, 3)
        Me.DataTransactionList.Name = "DataTransactionList"
        Me.DataTransactionList.Size = New System.Drawing.Size(342, 316)
        Me.DataTransactionList.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(408, 446)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(78, 22)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save to file"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TitlePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(894, 480)
        Me.Controls.Add(Me.SaveButton)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BoxMenu.ResumeLayout(False)
        Me.LayoutPanelMenu.ResumeLayout(False)
        CType(Me.DataTransactionList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBoxTransactionDescription As TextBox
    Friend WithEvents LabelTransactionDescription As Label
    Friend WithEvents LabelTransactionDate As Label
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents DataTransactionList As DataGridView
    Friend WithEvents LabelCategory As Label
    Friend WithEvents ComboBoxCategories As ComboBox
    Friend WithEvents TextBoxTransactionAmount As TextBox
    Friend WithEvents LabelTransactionAmount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonExpense As RadioButton
    Friend WithEvents RadioButtonIncome As RadioButton
    Friend WithEvents MaskedTextBoxTransactionDate As MaskedTextBox
    Friend WithEvents SaveButton As Button
End Class
