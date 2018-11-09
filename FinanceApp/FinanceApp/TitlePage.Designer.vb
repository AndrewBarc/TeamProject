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
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpperContainer1.SuspendLayout()
        Me.LowerContainer1.SuspendLayout()
        Me.BoxAddTransaction.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BoxMenu.SuspendLayout()
        Me.LayoutPanelMenu.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataTransactionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpperContainer1
        '
        Me.UpperContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UpperContainer1.Controls.Add(Me.Title)
        Me.UpperContainer1.Controls.Add(Me.Label1)
        Me.UpperContainer1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.UpperContainer1.Location = New System.Drawing.Point(123, 12)
        Me.UpperContainer1.Name = "UpperContainer1"
        Me.UpperContainer1.Size = New System.Drawing.Size(842, 83)
        Me.UpperContainer1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(822, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Budgeting Simulator 2018"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.LowerContainer1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.LowerContainer1.Location = New System.Drawing.Point(12, 118)
        Me.LowerContainer1.Name = "LowerContainer1"
        Me.LowerContainer1.RowCount = 1
        Me.LowerContainer1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LowerContainer1.Size = New System.Drawing.Size(1064, 340)
        Me.LowerContainer1.TabIndex = 1
        '
        'BoxAddTransaction
        '
        Me.BoxAddTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BoxAddTransaction.Controls.Add(Me.TableLayoutPanel1)
        Me.BoxAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxAddTransaction.Location = New System.Drawing.Point(3, 3)
        Me.BoxAddTransaction.Name = "BoxAddTransaction"
        Me.BoxAddTransaction.Size = New System.Drawing.Size(313, 334)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(307, 315)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelTransactionAmount
        '
        Me.LabelTransactionAmount.AutoSize = True
        Me.LabelTransactionAmount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionAmount.Location = New System.Drawing.Point(3, 173)
        Me.LabelTransactionAmount.Name = "LabelTransactionAmount"
        Me.LabelTransactionAmount.Size = New System.Drawing.Size(301, 13)
        Me.LabelTransactionAmount.TabIndex = 13
        Me.LabelTransactionAmount.Text = "Transaction Amount"
        Me.LabelTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButtonExpense)
        Me.Panel1.Controls.Add(Me.RadioButtonIncome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 25)
        Me.Panel1.TabIndex = 12
        '
        'RadioButtonExpense
        '
        Me.RadioButtonExpense.AutoSize = True
        Me.RadioButtonExpense.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadioButtonExpense.Location = New System.Drawing.Point(205, 0)
        Me.RadioButtonExpense.Name = "RadioButtonExpense"
        Me.RadioButtonExpense.Padding = New System.Windows.Forms.Padding(0, 0, 30, 0)
        Me.RadioButtonExpense.Size = New System.Drawing.Size(96, 25)
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
        Me.RadioButtonIncome.Size = New System.Drawing.Size(90, 25)
        Me.RadioButtonIncome.TabIndex = 3
        Me.RadioButtonIncome.TabStop = True
        Me.RadioButtonIncome.Text = "Income"
        Me.RadioButtonIncome.UseVisualStyleBackColor = True
        '
        'LabelTransactionDate
        '
        Me.LabelTransactionDate.AutoSize = True
        Me.LabelTransactionDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDate.Location = New System.Drawing.Point(3, 235)
        Me.LabelTransactionDate.Name = "LabelTransactionDate"
        Me.LabelTransactionDate.Size = New System.Drawing.Size(301, 13)
        Me.LabelTransactionDate.TabIndex = 4
        Me.LabelTransactionDate.Text = "Transaction Date"
        Me.LabelTransactionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxTransactionAmount
        '
        Me.TextBoxTransactionAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionAmount.Location = New System.Drawing.Point(3, 189)
        Me.TextBoxTransactionAmount.Name = "TextBoxTransactionAmount"
        Me.TextBoxTransactionAmount.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxTransactionAmount.TabIndex = 2
        '
        'TextBoxTransactionDescription
        '
        Me.TextBoxTransactionDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTransactionDescription.Location = New System.Drawing.Point(3, 34)
        Me.TextBoxTransactionDescription.MaxLength = 40
        Me.TextBoxTransactionDescription.Name = "TextBoxTransactionDescription"
        Me.TextBoxTransactionDescription.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxTransactionDescription.TabIndex = 0
        '
        'LabelTransactionDescription
        '
        Me.LabelTransactionDescription.AutoSize = True
        Me.LabelTransactionDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelTransactionDescription.Location = New System.Drawing.Point(3, 18)
        Me.LabelTransactionDescription.Name = "LabelTransactionDescription"
        Me.LabelTransactionDescription.Size = New System.Drawing.Size(301, 13)
        Me.LabelTransactionDescription.TabIndex = 1
        Me.LabelTransactionDescription.Text = "Transaction Description"
        Me.LabelTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonAddTransaction
        '
        Me.ButtonAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddTransaction.Location = New System.Drawing.Point(3, 282)
        Me.ButtonAddTransaction.Name = "ButtonAddTransaction"
        Me.ButtonAddTransaction.Size = New System.Drawing.Size(301, 30)
        Me.ButtonAddTransaction.TabIndex = 6
        Me.ButtonAddTransaction.Text = "Add Transaction"
        Me.ButtonAddTransaction.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxTransactionDate
        '
        Me.MaskedTextBoxTransactionDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaskedTextBoxTransactionDate.Location = New System.Drawing.Point(3, 251)
        Me.MaskedTextBoxTransactionDate.Mask = "00/00/0000"
        Me.MaskedTextBoxTransactionDate.Name = "MaskedTextBoxTransactionDate"
        Me.MaskedTextBoxTransactionDate.Size = New System.Drawing.Size(301, 20)
        Me.MaskedTextBoxTransactionDate.TabIndex = 5
        Me.MaskedTextBoxTransactionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBoxTransactionDate.ValidatingType = GetType(Date)
        '
        'LabelCategory
        '
        Me.LabelCategory.AutoSize = True
        Me.LabelCategory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelCategory.Location = New System.Drawing.Point(3, 80)
        Me.LabelCategory.Name = "LabelCategory"
        Me.LabelCategory.Size = New System.Drawing.Size(301, 13)
        Me.LabelCategory.TabIndex = 9
        Me.LabelCategory.Text = "Transaction Category"
        Me.LabelCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxCategories
        '
        Me.ComboBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCategories.FormattingEnabled = True
        Me.ComboBoxCategories.Items.AddRange(New Object() {"Bills", "Dining", "Education", "Entertainment", "Groceries", "Health Care", "Home", "Office", "Personal Care", "Pets", "Shopping", "Travel", "Job Income"})
        Me.ComboBoxCategories.Location = New System.Drawing.Point(3, 96)
        Me.ComboBoxCategories.Name = "ComboBoxCategories"
        Me.ComboBoxCategories.Size = New System.Drawing.Size(301, 21)
        Me.ComboBoxCategories.TabIndex = 1
        '
        'BoxMenu
        '
        Me.BoxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.BoxMenu.Controls.Add(Me.LayoutPanelMenu)
        Me.BoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxMenu.Location = New System.Drawing.Point(747, 3)
        Me.BoxMenu.Name = "BoxMenu"
        Me.BoxMenu.Size = New System.Drawing.Size(314, 334)
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
        Me.LayoutPanelMenu.Size = New System.Drawing.Size(308, 315)
        Me.LayoutPanelMenu.TabIndex = 0
        '
        'ButtonHelp
        '
        Me.ButtonHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonHelp.Location = New System.Drawing.Point(10, 244)
        Me.ButtonHelp.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(288, 61)
        Me.ButtonHelp.TabIndex = 3
        Me.ButtonHelp.Text = "Help"
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'ButtonReports
        '
        Me.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReports.Location = New System.Drawing.Point(10, 166)
        Me.ButtonReports.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(288, 58)
        Me.ButtonReports.TabIndex = 2
        Me.ButtonReports.Text = "Financial Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
        '
        'ButtonCalendar
        '
        Me.ButtonCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonCalendar.Location = New System.Drawing.Point(10, 88)
        Me.ButtonCalendar.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonCalendar.Name = "ButtonCalendar"
        Me.ButtonCalendar.Size = New System.Drawing.Size(288, 58)
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
        Me.ButtonBudgeting.Size = New System.Drawing.Size(288, 58)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(322, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(419, 334)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'DataTransactionList
        '
        Me.DataTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTransactionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTransactionList.Location = New System.Drawing.Point(3, 3)
        Me.DataTransactionList.Name = "DataTransactionList"
        Me.DataTransactionList.Size = New System.Drawing.Size(413, 261)
        Me.DataTransactionList.TabIndex = 4
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxTotal, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 270)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(413, 61)
        Me.TableLayoutPanel4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxTotal.Location = New System.Drawing.Point(3, 33)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxTotal.TabIndex = 1
        Me.TextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SaveButton, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 471)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1088, 27)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'SaveButton
        '
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaveButton.Location = New System.Drawing.Point(3, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(1082, 20)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save to file"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(209, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Remove"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(209, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Remove Selected Transaction"
        '
        'TitlePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1088, 498)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.LowerContainer1)
        Me.Controls.Add(Me.UpperContainer1)
        Me.MinimumSize = New System.Drawing.Size(683, 383)
        Me.Name = "TitlePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        Me.UpperContainer1.ResumeLayout(False)
        Me.UpperContainer1.PerformLayout()
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
        Me.TableLayoutPanel2.ResumeLayout(False)
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
    Friend WithEvents LabelCategory As Label
    Friend WithEvents ComboBoxCategories As ComboBox
    Friend WithEvents TextBoxTransactionAmount As TextBox
    Friend WithEvents LabelTransactionAmount As Label
    Friend WithEvents RadioButtonExpense As RadioButton
    Friend WithEvents RadioButtonIncome As RadioButton
    Friend WithEvents MaskedTextBoxTransactionDate As MaskedTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SaveButton As Button
    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataTransactionList As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
