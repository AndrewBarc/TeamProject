<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YearReport
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
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuildReport = New System.Windows.Forms.Button()
        Me.Report = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Year, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BuildReport, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(333, 88)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Year
        '
        Me.Year.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.Year.Location = New System.Drawing.Point(106, 16)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(121, 21)
        Me.Year.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Select Year"
        '
        'BuildReport
        '
        Me.BuildReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuildReport.Location = New System.Drawing.Point(3, 43)
        Me.BuildReport.Name = "BuildReport"
        Me.BuildReport.Size = New System.Drawing.Size(327, 42)
        Me.BuildReport.TabIndex = 2
        Me.BuildReport.Text = "Build Report"
        Me.BuildReport.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.Report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Report.FormattingEnabled = True
        Me.Report.Location = New System.Drawing.Point(1, 91)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(333, 368)
        Me.Report.TabIndex = 1
        '
        'YearReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 456)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "YearReport"
        Me.Text = "YearReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Year As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BuildReport As Button
    Friend WithEvents Report As ListBox
End Class
