Public Class frmTreeView

    Public Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick

        If TreeView1.SelectedNode.Text.Equals("Cash Receipt Journal") Then
            frmCashReceiptJournal.MdiParent = frmMain
            frmCashReceiptJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Check Disbursment Journal") Then
            frmCheckDisbursmentJournal.MdiParent = frmMain
            frmCheckDisbursmentJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Credit Memo Register") Then
            frmCreditMemoRegister.MdiParent = frmMain
            frmCreditMemoRegister.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Debit Memo Register") Then
            frmDebitMemoRegsiter.MdiParent = frmMain
            frmDebitMemoRegsiter.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Purchase Journal") Then
            frmPurchaseJournal.MdiParent = frmMain
            frmPurchaseJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Sales Journal") Then
            frmSalesJournal.MdiParent = frmMain
            frmSalesJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Checkwrite") Then
            frmCheckwrite.MdiParent = frmMain
            frmCheckwrite.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Inventory Books") Then
            frmInventoryBooks.MdiParent = frmMain
            frmInventoryBooks.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary Alphalist of Withholding Taxes") Then
            SAWT.MdiParent = frmMain
            SAWT.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("General Ledger") Then
            frmGeneralLedger.MdiParent = frmMain
            frmGeneralLedger.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary Alphalist of Payees") Then
            SLS.MdiParent = frmMain
            SLS.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary List of Sales") Then
            ST.MdiParent = frmMain
            ST.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary List of Purchases") Then
            PT.MdiParent = frmMain
            PT.Show()
        Else

        End If

    End Sub

    Private Sub frmTreeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class