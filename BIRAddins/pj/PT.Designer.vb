<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PT
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
        Me.cr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DDFrom = New System.Windows.Forms.DateTimePicker()
        Me.DDTo = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cr
        '
        Me.cr.ActiveViewIndex = -1
        Me.cr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cr.Location = New System.Drawing.Point(432, 11)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(970, 614)
        Me.cr.TabIndex = 20
        Me.cr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnGenerateReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 614)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search: Purhcase Transactions"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(6, 301)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(402, 149)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Branch:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DDFrom)
        Me.GroupBox2.Controls.Add(Me.DDTo)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 269)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Posting Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Date From:"
        '
        'DDFrom
        '
        Me.DDFrom.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDFrom.CustomFormat = "MM/dd/yyyy"
        Me.DDFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDFrom.Location = New System.Drawing.Point(148, 97)
        Me.DDFrom.Name = "DDFrom"
        Me.DDFrom.Size = New System.Drawing.Size(175, 26)
        Me.DDFrom.TabIndex = 5
        '
        'DDTo
        '
        Me.DDTo.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDTo.CustomFormat = "MM/dd/yyyy"
        Me.DDTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDTo.Location = New System.Drawing.Point(148, 129)
        Me.DDTo.Name = "DDTo"
        Me.DDTo.Size = New System.Drawing.Size(175, 26)
        Me.DDTo.TabIndex = 6
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
        'PT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1414, 636)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Transactions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DDFrom As DateTimePicker
    Friend WithEvents DDTo As DateTimePicker
    Friend WithEvents btnGenerateReport As Button
End Class
