<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAWT
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxQuarter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxYear = New System.Windows.Forms.ComboBox()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.cr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnGenerateReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 614)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search: Quarterly Summary ALphalist of Wittholding Taxed"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(6, 301)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(402, 149)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Branch:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbxQuarter)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbxYear)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 269)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Year and Quarter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Select Quarter:"
        '
        'cbxQuarter
        '
        Me.cbxQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQuarter.FormattingEnabled = True
        Me.cbxQuarter.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cbxQuarter.Location = New System.Drawing.Point(164, 147)
        Me.cbxQuarter.Name = "cbxQuarter"
        Me.cbxQuarter.Size = New System.Drawing.Size(168, 27)
        Me.cbxQuarter.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select Year:"
        '
        'cbxYear
        '
        Me.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Location = New System.Drawing.Point(164, 80)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(168, 27)
        Me.cbxYear.TabIndex = 13
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateReport.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnGenerateReport.Location = New System.Drawing.Point(6, 456)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(402, 152)
        Me.btnGenerateReport.TabIndex = 12
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'cr
        '
        Me.cr.ActiveViewIndex = -1
        Me.cr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cr.Location = New System.Drawing.Point(442, 12)
        Me.cr.Name = "cr"
        Me.cr.ShowCloseButton = False
        Me.cr.ShowGroupTreeButton = False
        Me.cr.ShowParameterPanelButton = False
        Me.cr.ShowRefreshButton = False
        Me.cr.Size = New System.Drawing.Size(960, 612)
        Me.cr.TabIndex = 15
        Me.cr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SAWT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1414, 636)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SAWT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOA - Summary Alphalist of Withholding Taxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents cr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxYear As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxQuarter As ComboBox
End Class
