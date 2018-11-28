<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthReport
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MonthBox = New System.Windows.Forms.TextBox()
        Me.YearBox = New System.Windows.Forms.TextBox()
        Me.MonthButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please Select Month (e.g 05)"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Select Year (e.g 2015)"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthBox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.YearBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MonthButton, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(241, 208)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'MonthBox
        '
        Me.MonthBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthBox.Location = New System.Drawing.Point(54, 132)
        Me.MonthBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MonthBox.Name = "MonthBox"
        Me.MonthBox.Size = New System.Drawing.Size(132, 22)
        Me.MonthBox.TabIndex = 7
        '
        'YearBox
        '
        Me.YearBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.YearBox.Location = New System.Drawing.Point(54, 50)
        Me.YearBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.YearBox.Name = "YearBox"
        Me.YearBox.Size = New System.Drawing.Size(132, 22)
        Me.YearBox.TabIndex = 6
        '
        'MonthButton
        '
        Me.MonthButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthButton.Location = New System.Drawing.Point(4, 168)
        Me.MonthButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MonthButton.Name = "MonthButton"
        Me.MonthButton.Size = New System.Drawing.Size(233, 36)
        Me.MonthButton.TabIndex = 8
        Me.MonthButton.Text = "Search"
        Me.MonthButton.UseVisualStyleBackColor = True
        '
        'MonthReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 206)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MonthReport"
        Me.Text = "MonthReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MonthBox As TextBox
    Friend WithEvents YearBox As TextBox
    Friend WithEvents MonthButton As Button
End Class
