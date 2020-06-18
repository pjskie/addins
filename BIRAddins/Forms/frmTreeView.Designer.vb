<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreeView
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cash Receipt Journal")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Check Disbursment Journal")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Memo Register")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debit Memo Register")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General Ledger")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventory Books")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Journal")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Journal")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Book of Accounts", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary List of Sales")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary List of Purchases")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary Alphalist of Withholding Taxes")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary Alphalist of Payees")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Returns", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audit Log")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audit Trail Log", New System.Windows.Forms.TreeNode() {TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Withholding Tax Payable - Form 2307")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Checkwrite")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Forms and Documents", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTreeView))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "CashReceiptJournal"
        TreeNode1.Text = "Cash Receipt Journal"
        TreeNode2.Name = "CheckDisbursmentJournal"
        TreeNode2.Text = "Check Disbursment Journal"
        TreeNode3.Name = "CreditMemoRegister"
        TreeNode3.Text = "Credit Memo Register"
        TreeNode4.Name = "DebitMemoRegister"
        TreeNode4.Text = "Debit Memo Register"
        TreeNode5.Name = "GeneralLedger"
        TreeNode5.Text = "General Ledger"
        TreeNode6.Name = "InventoryBooks"
        TreeNode6.Text = "Inventory Books"
        TreeNode7.Name = "PurchaseJournal"
        TreeNode7.Text = "Purchase Journal"
        TreeNode8.Name = "SalesJournal"
        TreeNode8.Text = "Sales Journal"
        TreeNode9.Name = "BookOfAccounts"
        TreeNode9.Text = "Book of Accounts"
        TreeNode9.ToolTipText = "Book of Accounts"
        TreeNode10.Name = "SummaryListofSales"
        TreeNode10.Text = "Summary List of Sales"
        TreeNode11.Name = "SummaryListofPurchases"
        TreeNode11.Text = "Summary List of Purchases"
        TreeNode12.Name = "SummaryAlphalistofWithholdingTaxes"
        TreeNode12.Text = "Summary Alphalist of Withholding Taxes"
        TreeNode13.Name = "SummaryAlphalistofPayees"
        TreeNode13.Text = "Summary Alphalist of Payees"
        TreeNode14.Name = "TaxReturns"
        TreeNode14.Text = "Tax Returns"
        TreeNode14.ToolTipText = "Tax Returns"
        TreeNode15.Name = "AuditLog"
        TreeNode15.Text = "Audit Log"
        TreeNode16.Name = "AuditTrailLog"
        TreeNode16.Text = "Audit Trail Log"
        TreeNode16.ToolTipText = "Audit Trail Log"
        TreeNode17.Name = "frm2307"
        TreeNode17.Text = "Withholding Tax Payable - Form 2307"
        TreeNode18.Name = "Checkwrite"
        TreeNode18.Text = "Checkwrite"
        TreeNode19.Name = "Otherforms"
        TreeNode19.Text = "Other Forms and Documents"
        TreeNode19.ToolTipText = "Other Forms and Documents"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode14, TreeNode16, TreeNode19})
        Me.TreeView1.Size = New System.Drawing.Size(292, 407)
        Me.TreeView1.TabIndex = 1
        '
        'frmTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 407)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(308, 446)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(308, 446)
        Me.Name = "frmTreeView"
        Me.Text = "BIR Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
