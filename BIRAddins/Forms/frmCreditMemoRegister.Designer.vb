<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditMemoRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditMemoRegister))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.RadioDocument = New System.Windows.Forms.RadioButton()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.RadioPosting = New System.Windows.Forms.RadioButton()
        Me.DDFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DDTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PDFrom = New System.Windows.Forms.DateTimePicker()
        Me.PDTo = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.RadioDocument)
        Me.GroupBox1.Controls.Add(Me.btnGenerateReport)
        Me.GroupBox1.Controls.Add(Me.RadioPosting)
        Me.GroupBox1.Controls.Add(Me.DDFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DDTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PDFrom)
        Me.GroupBox1.Controls.Add(Me.PDTo)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 114)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search: Credit Memo Register"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Branch:"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"KORONADAL BRANCH", "GENSAN BRANCH", "POLOMOLOK BRANCH"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(460, 36)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(280, 67)
        Me.CheckedListBox1.TabIndex = 10
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'RadioDocument
        '
        Me.RadioDocument.AutoSize = True
        Me.RadioDocument.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDocument.Location = New System.Drawing.Point(11, 36)
        Me.RadioDocument.Name = "RadioDocument"
        Me.RadioDocument.Size = New System.Drawing.Size(126, 22)
        Me.RadioDocument.TabIndex = 1
        Me.RadioDocument.TabStop = True
        Me.RadioDocument.Text = "Document Date:"
        Me.RadioDocument.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerateReport.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnGenerateReport.Location = New System.Drawing.Point(746, 36)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(198, 67)
        Me.btnGenerateReport.TabIndex = 12
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'RadioPosting
        '
        Me.RadioPosting.AutoSize = True
        Me.RadioPosting.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPosting.Location = New System.Drawing.Point(11, 68)
        Me.RadioPosting.Name = "RadioPosting"
        Me.RadioPosting.Size = New System.Drawing.Size(107, 22)
        Me.RadioPosting.TabIndex = 2
        Me.RadioPosting.TabStop = True
        Me.RadioPosting.Text = "Posting Date:"
        Me.RadioPosting.UseVisualStyleBackColor = True
        '
        'DDFrom
        '
        Me.DDFrom.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDFrom.CustomFormat = "MM/dd/yyyy"
        Me.DDFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDFrom.Location = New System.Drawing.Point(143, 36)
        Me.DDFrom.Name = "DDFrom"
        Me.DDFrom.Size = New System.Drawing.Size(110, 26)
        Me.DDFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "to"
        '
        'DDTo
        '
        Me.DDTo.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDTo.CustomFormat = "MM/dd/yyyy"
        Me.DDTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDTo.Location = New System.Drawing.Point(284, 36)
        Me.DDTo.Name = "DDTo"
        Me.DDTo.Size = New System.Drawing.Size(110, 26)
        Me.DDTo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "to"
        '
        'PDFrom
        '
        Me.PDFrom.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDFrom.CustomFormat = "MM/dd/yyyy"
        Me.PDFrom.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PDFrom.Location = New System.Drawing.Point(143, 68)
        Me.PDFrom.Name = "PDFrom"
        Me.PDFrom.Size = New System.Drawing.Size(110, 26)
        Me.PDFrom.TabIndex = 5
        '
        'PDTo
        '
        Me.PDTo.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDTo.CustomFormat = "MM/dd/yyyy"
        Me.PDTo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PDTo.Location = New System.Drawing.Point(284, 68)
        Me.PDTo.Name = "PDTo"
        Me.PDTo.Size = New System.Drawing.Size(110, 26)
        Me.PDTo.TabIndex = 6
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 132)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(950, 248)
        Me.CrystalReportViewer1.TabIndex = 16
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmCreditMemoRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCreditMemoRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOA - Credit Memo Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents RadioDocument As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents RadioPosting As System.Windows.Forms.RadioButton
    Friend WithEvents DDFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DDTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PDFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents PDTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
