<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YearButton = New System.Windows.Forms.Button()
        Me.MonthButton = New System.Windows.Forms.Button()
        Me.SpecificButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.YearButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SpecificButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.77778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.22222!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.Location = New System.Drawing.Point(536, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 81)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SPECIFIC"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Location = New System.Drawing.Point(269, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 81)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "MONTHLY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 81)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "YEARLY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Location = New System.Drawing.Point(269, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 145)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Receive the specific date range financial history"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Location = New System.Drawing.Point(536, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 145)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Receive the current or specified monthly financial history"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YearButton
        '
        Me.YearButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearButton.Location = New System.Drawing.Point(3, 84)
        Me.YearButton.Name = "YearButton"
        Me.YearButton.Size = New System.Drawing.Size(260, 146)
        Me.YearButton.TabIndex = 0
        Me.YearButton.Text = "Yearly Report"
        Me.YearButton.UseVisualStyleBackColor = True
        '
        'MonthButton
        '
        Me.MonthButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthButton.Location = New System.Drawing.Point(269, 84)
        Me.MonthButton.Name = "MonthButton"
        Me.MonthButton.Size = New System.Drawing.Size(260, 146)
        Me.MonthButton.TabIndex = 3
        Me.MonthButton.Text = "Monthly Report"
        Me.MonthButton.UseVisualStyleBackColor = True
        '
        'SpecificButton
        '
        Me.SpecificButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpecificButton.Location = New System.Drawing.Point(535, 84)
        Me.SpecificButton.Name = "SpecificButton"
        Me.SpecificButton.Size = New System.Drawing.Size(262, 146)
        Me.SpecificButton.TabIndex = 4
        Me.SpecificButton.Text = "Specific Report"
        Me.SpecificButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Location = New System.Drawing.Point(3, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 145)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Receive your current or specified year financial history"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ReportMenu"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents YearButton As Button
    Friend WithEvents MonthButton As Button
    Friend WithEvents SpecificButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
