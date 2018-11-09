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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataTransactionList = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.LabelRemove = New System.Windows.Forms.Label()
        Me.UpperContainer1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Title = New System.Windows.Forms.Label()
        Me.MainTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.LowerContainer1.SuspendLayout()
        Me.BoxAddTransaction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BoxMenu.SuspendLayout()
        Me.LayoutPanelMenu.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataTransactionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.UpperContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LowerContainer1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.UpperContainer1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1123, 601)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'LowerContainer1
        '
        Me.LowerContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.LowerContainer1.ColumnCount = 3
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.Controls.Add(Me.BoxAddTransaction, 0, 0)
        Me.LowerContainer1.Controls.Add(Me.BoxMenu, 2, 0)
        Me.LowerContainer1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.LowerContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LowerContainer1.Location = New System.Drawing.Point(3, 92)
        Me.LowerContainer1.Name = "LowerContainer1"
        Me.LowerContainer1.RowCount = 1
        Me.LowerContainer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LowerContainer1.Size = New System.Drawing.Size(1117, 506)
        Me.LowerContainer1.TabIndex = 2
        '
        'BoxAddTransaction
        '
        Me.BoxAddTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BoxAddTransaction.Controls.Add(Me.TableLayoutPanel1)
        Me.BoxAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxAddTransaction.Location = New System.Drawing.Point(3, 3)
        Me.BoxAddTransaction.Name = "BoxAddTransaction"
        Me.BoxAddTransaction.Size = New System.Drawing.Size(329, 500)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(323, 481)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelTransactionAmount
        '
        Me.LabelTransactionAmount.AutoSize = True
        Me.LabelTransactionAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionAmount.Location = New System.Drawing.Point(3, 275)
        Me.LabelTransactionAmount.Name = "LabelTransactionAmount"
        Me.LabelTransactionAmount.Size = New System.Drawing.Size(317, 13)
        Me.LabelTransactionAmount.TabIndex = 13
        Me.LabelTransactionAmount.Text = "Transaction Amount"
        Me.LabelTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButtonExpense)
        Me.Panel1.Controls.Add(Me.RadioButtonIncome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 42)
        Me.Panel1.TabIndex = 12
        '
        'RadioButtonExpense
        '
        Me.RadioButtonExpense.AutoSize = True
        Me.RadioButtonExpense.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadioButtonExpense.Location = New System.Drawing.Point(221, 0)
        Me.RadioButtonExpense.Name = "RadioButtonExpense"
        Me.RadioButtonExpense.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.RadioButtonExpense.Size = New System.Drawing.Size(96, 42)
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
        Me.RadioButtonIncome.Size = New System.Drawing.Size(90, 42)
        Me.RadioButtonIncome.TabIndex = 3
        Me.RadioButtonIncome.TabStop = True
        Me.RadioButtonIncome.Text = "Income"
        Me.RadioButtonIncome.UseVisualStyleBackColor = True
        '
        'LabelTransactionDate
        '
        Me.LabelTransactionDate.AutoSize = True
        Me.LabelTransactionDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDate.Location = New System.Drawing.Point(3, 371)
        Me.LabelTransactionDate.Name = "LabelTransactionDate"
        Me.LabelTransactionDate.Size = New System.Drawing.Size(317, 13)
        Me.LabelTransactionDate.TabIndex = 4
        Me.LabelTransactionDate.Text = "Transaction Date"
        Me.LabelTransactionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxTransactionAmount
        '
        Me.TextBoxTransactionAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionAmount.Location = New System.Drawing.Point(3, 291)
        Me.TextBoxTransactionAmount.Name = "TextBoxTransactionAmount"
        Me.TextBoxTransactionAmount.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxTransactionAmount.TabIndex = 2
        '
        'TextBoxTransactionDescription
        '
        Me.TextBoxTransactionDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionDescription.Location = New System.Drawing.Point(3, 51)
        Me.TextBoxTransactionDescription.MaxLength = 40
        Me.TextBoxTransactionDescription.Name = "TextBoxTransactionDescription"
        Me.TextBoxTransactionDescription.Size = New System.Drawing.Size(317, 20)
        Me.TextBoxTransactionDescription.TabIndex = 0
        '
        'LabelTransactionDescription
        '
        Me.LabelTransactionDescription.AutoSize = True
        Me.LabelTransactionDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDescription.Location = New System.Drawing.Point(3, 35)
        Me.LabelTransactionDescription.Name = "LabelTransactionDescription"
        Me.LabelTransactionDescription.Size = New System.Drawing.Size(317, 13)
        Me.LabelTransactionDescription.TabIndex = 1
        Me.LabelTransactionDescription.Text = "Transaction Description"
        Me.LabelTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(3, 435)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(317, 43)
        Me.ButtonAddTransaction.TabIndex = 6
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxTransactionDate
        '
        Me.MaskedTextBoxTransactionDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaskedTextBoxTransactionDate.Location = New System.Drawing.Point(3, 387)
        Me.MaskedTextBoxTransactionDate.Mask = "00/00/0000"
        Me.MaskedTextBoxTransactionDate.Name = "MaskedTextBoxTransactionDate"
        Me.MaskedTextBoxTransactionDate.Size = New System.Drawing.Size(317, 20)
        Me.MaskedTextBoxTransactionDate.TabIndex = 5
        Me.MaskedTextBoxTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxTransactionDate.ValidatingType = GetType(Date)
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelCategory.Location = New System.Drawing.Point(3, 131)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(317, 13)
        Me.LabelCategory.TabIndex = 9
        Me.LabelCategory.Text = "Transaction Category"
        Me.LabelCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxCategories
        '
        Me.ComboBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCategories.FormattingEnabled = True
        Me.ComboBoxCategories.Items.AddRange(New Object() {"Bills", "Dining", "Education", "Entertainment", "Groceries", "Health Care", "Home", "Office", "Personal Care", "Pets", "Shopping", "Travel", "Job Income"})
        Me.ComboBoxCategories.Location = New System.Drawing.Point(3, 147)
        Me.ComboBoxCategories.Name = "ComboBoxCategories"
        Me.ComboBoxCategories.Size = New System.Drawing.Size(317, 21)
        Me.ComboBoxCategories.TabIndex = 1
        '
        'BoxMenu
        '
        Me.BoxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.BoxMenu.Controls.Add(Me.LayoutPanelMenu)
        Me.BoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxMenu.Location = New System.Drawing.Point(784, 3)
        Me.BoxMenu.Name = "BoxMenu"
        Me.BoxMenu.Size = New System.Drawing.Size(330, 500)
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
        Me.LayoutPanelMenu.Size = New System.Drawing.Size(324, 481)
        Me.LayoutPanelMenu.TabIndex = 0
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonHelp.Location = New System.Drawing.Point(10, 370)
        Me.ButtonHelp.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(304, 101)
        Me.ButtonHelp.TabIndex = 3
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonReports
        '
        Me.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReports.Location = New System.Drawing.Point(10, 250)
        Me.ButtonReports.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(304, 100)
        Me.ButtonReports.TabIndex = 2
        Me.ButtonReports.Text = "Financial Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
        '
        'ButtonCalendar
        '
        Me.ButtonCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalendar.Location = New System.Drawing.Point(10, 130)
        Me.ButtonCalendar.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonCalendar.Name = "ButtonCalendar"
        Me.ButtonCalendar.Size = New System.Drawing.Size(304, 100)
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
        Me.ButtonBudgeting.Size = New System.Drawing.Size(304, 100)
        Me.ButtonBudgeting.TabIndex = 0
        Me.ButtonBudgeting.Text = "Budgeting"
        Me.ButtonBudgeting.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataTransactionList, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(338, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(440, 500)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'DataTransactionList
        '
        Me.DataTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTransactionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTransactionList.Location = New System.Drawing.Point(3, 3)
        Me.DataTransactionList.Name = "DataTransactionList"
        Me.DataTransactionList.Size = New System.Drawing.Size(434, 394)
        Me.DataTransactionList.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LabelTotal, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxTotal, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonRemove, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelRemove, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 403)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(434, 94)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTotal.Location = New System.Drawing.Point(3, 34)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(211, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTotal.Location = New System.Drawing.Point(3, 50)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(211, 20)
        Me.TextBoxTotal.TabIndex = 1
        Me.TextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonRemove.Location = New System.Drawing.Point(220, 50)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(211, 25)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'LabelRemove
        '
        Me.LabelRemove.AutoSize = True
        Me.LabelRemove.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelRemove.Location = New System.Drawing.Point(220, 34)
        Me.LabelRemove.Name = "LabelRemove"
        Me.LabelRemove.Size = New System.Drawing.Size(211, 13)
        Me.LabelRemove.TabIndex = 3
        Me.LabelRemove.Text = "Remove Selected Transaction"
        Me.LabelRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UpperContainer1
        '
        Me.UpperContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UpperContainer1.Controls.Add(Me.Title)
        Me.UpperContainer1.Controls.Add(Me.MainTitle)
        Me.UpperContainer1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.UpperContainer1.Location = New System.Drawing.Point(140, 3)
        Me.UpperContainer1.Name = "UpperContainer1"
        Me.UpperContainer1.Size = New System.Drawing.Size(842, 83)
        Me.UpperContainer1.TabIndex = 1
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(3, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(0, 73)
        Me.Title.TabIndex = 0
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainTitle
        '
        Me.MainTitle.AutoSize = True
        Me.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTitle.Location = New System.Drawing.Point(9, 0)
        Me.MainTitle.Name = "MainTitle"
        Me.MainTitle.Size = New System.Drawing.Size(822, 76)
        Me.MainTitle.TabIndex = 1
        Me.MainTitle.Text = "Budgeting Simulator 2018"
        Me.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitlePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1123, 601)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.MinimumSize = New System.Drawing.Size(683, 383)
        Me.Name = "TitlePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.LowerContainer1.ResumeLayout(False)
        Me.BoxAddTransaction.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BoxMenu.ResumeLayout(False)
        Me.LayoutPanelMenu.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DataTransactionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.UpperContainer1.ResumeLayout(False)
        Me.UpperContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LowerContainer1 As TableLayoutPanel
    Friend WithEvents BoxAddTransaction As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelTransactionAmount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonExpense As RadioButton
    Friend WithEvents RadioButtonIncome As RadioButton
    Friend WithEvents LabelTransactionDate As Label
    Friend WithEvents TextBoxTransactionAmount As TextBox
    Friend WithEvents TextBoxTransactionDescription As TextBox
    Friend WithEvents LabelTransactionDescription As Label
    Friend WithEvents ButtonAddTransaction As Button
    Friend WithEvents MaskedTextBoxTransactionDate As MaskedTextBox
    Friend WithEvents LabelCategory As Label
    Friend WithEvents ComboBoxCategories As ComboBox
    Friend WithEvents BoxMenu As GroupBox
    Friend WithEvents LayoutPanelMenu As TableLayoutPanel
    Friend WithEvents ButtonHelp As Button
    Friend WithEvents ButtonReports As Button
    Friend WithEvents ButtonCalendar As Button
    Friend WithEvents ButtonBudgeting As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataTransactionList As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LabelTotal As Label
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents LabelRemove As Label
    Friend WithEvents UpperContainer1 As FlowLayoutPanel
    Friend WithEvents Title As Label
    Friend WithEvents MainTitle As Label
End Class
