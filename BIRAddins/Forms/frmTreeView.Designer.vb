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
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cash Disbursment Journal")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credit Memo Register")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debit Memo Register")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General Ledger")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventory Books")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Purchase Journal")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales Journal")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Book of Accounts", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary List of Sales")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary List of Purchases")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary Alphalist of Withholding Taxes")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Summary Alphalist of Payees")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tax Returns", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audit Log")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audit Trail Log", New System.Windows.Forms.TreeNode() {TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Withholding Tax Payable - Form 2307")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Checkwrite")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Other Forms and Documents", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19})
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
        TreeNode3.Name = "CashDisbursmentJournal"
        TreeNode3.Text = "Cash Disbursment Journal"
        TreeNode4.Name = "CreditMemoRegister"
        TreeNode4.Text = "Credit Memo Register"
        TreeNode5.Name = "DebitMemoRegister"
        TreeNode5.Text = "Debit Memo Register"
        TreeNode6.Name = "GeneralLedger"
        TreeNode6.Text = "General Ledger"
        TreeNode7.Name = "InventoryBooks"
        TreeNode7.Text = "Inventory Books"
        TreeNode8.Name = "PurchaseJournal"
        TreeNode8.Text = "Purchase Journal"
        TreeNode9.Name = "SalesJournal"
        TreeNode9.Text = "Sales Journal"
        TreeNode10.Name = "BookOfAccounts"
        TreeNode10.Text = "Book of Accounts"
        TreeNode10.ToolTipText = "Book of Accounts"
        TreeNode11.Name = "SummaryListofSales"
        TreeNode11.Text = "Summary List of Sales"
        TreeNode12.Name = "SummaryListofPurchases"
        TreeNode12.Text = "Summary List of Purchases"
        TreeNode13.Name = "SummaryAlphalistofWithholdingTaxes"
        TreeNode13.Text = "Summary Alphalist of Withholding Taxes"
        TreeNode14.Name = "SummaryAlphalistofPayees"
        TreeNode14.Text = "Summary Alphalist of Payees"
        TreeNode15.Name = "TaxReturns"
        TreeNode15.Text = "Tax Returns"
        TreeNode15.ToolTipText = "Tax Returns"
        TreeNode16.Name = "AuditLog"
        TreeNode16.Text = "Audit Log"
        TreeNode17.Name = "AuditTrailLog"
        TreeNode17.Text = "Audit Trail Log"
        TreeNode17.ToolTipText = "Audit Trail Log"
        TreeNode18.Name = "frm2307"
        TreeNode18.Text = "Withholding Tax Payable - Form 2307"
        TreeNode19.Name = "Checkwrite"
        TreeNode19.Text = "Checkwrite"
        TreeNode20.Name = "Otherforms"
        TreeNode20.Text = "Other Forms and Documents"
        TreeNode20.ToolTipText = "Other Forms and Documents"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode15, TreeNode17, TreeNode20})
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
