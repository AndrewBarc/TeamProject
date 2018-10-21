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
        Me.BoxMenu = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonBudgeting = New System.Windows.Forms.Button()
        Me.ButtonCalendar = New System.Windows.Forms.Button()
        Me.ButtonReports = New System.Windows.Forms.Button()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.LowerContainer1.SuspendLayout()
        Me.BoxMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.LowerContainer1.ColumnCount = 3
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.LowerContainer1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.LowerContainer1.Controls.Add(Me.BoxAddTransaction, 0, 0)
        Me.LowerContainer1.Controls.Add(Me.BoxMenu, 2, 0)
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
        Me.BoxAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxAddTransaction.Location = New System.Drawing.Point(3, 3)
        Me.BoxAddTransaction.Name = "BoxAddTransaction"
        Me.BoxAddTransaction.Size = New System.Drawing.Size(255, 337)
        Me.BoxAddTransaction.TabIndex = 0
        Me.BoxAddTransaction.TabStop = False
        Me.BoxAddTransaction.Text = "Create a Transaction"
        '
        'BoxMenu
        '
        Me.BoxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.BoxMenu.Controls.Add(Me.TableLayoutPanel1)
        Me.BoxMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BoxMenu.Location = New System.Drawing.Point(612, 3)
        Me.BoxMenu.Name = "BoxMenu"
        Me.BoxMenu.Size = New System.Drawing.Size(255, 337)
        Me.BoxMenu.TabIndex = 1
        Me.BoxMenu.TabStop = False
        Me.BoxMenu.Text = "Menu"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonHelp, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonReports, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonCalendar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonBudgeting, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 318)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'ButtonReports
        '
        Me.ButtonReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReports.Location = New System.Drawing.Point(10, 168)
        Me.ButtonReports.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(229, 59)
        Me.ButtonReports.TabIndex = 2
        Me.ButtonReports.Text = "Finacial Reports"
        Me.ButtonReports.UseVisualStyleBackColor = True
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
        Me.BoxMenu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpperContainer1 As FlowLayoutPanel
    Friend WithEvents LowerContainer1 As TableLayoutPanel
    Friend WithEvents BoxAddTransaction As GroupBox
    Friend WithEvents BoxMenu As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonHelp As Button
    Friend WithEvents ButtonReports As Button
    Friend WithEvents ButtonCalendar As Button
    Friend WithEvents ButtonBudgeting As Button
End Class
