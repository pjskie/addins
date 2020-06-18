Public Class frmTreeView

    Public Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick

        If TreeView1.SelectedNode.Text.Equals("Cash Receipt Journal") And frmLogin.user <> "testuser" Then
            frmCashReceiptJournal.MdiParent = frmMain
            frmCashReceiptJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Check Disbursment Journal") And frmLogin.user <> "testuser" Then
            frmCheckDisbursmentJournal.MdiParent = frmMain
            frmCheckDisbursmentJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Credit Memo Register") And frmLogin.user <> "testuser" Then
            frmCreditMemoRegister.MdiParent = frmMain
            frmCreditMemoRegister.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Debit Memo Register") And frmLogin.user <> "testuser" Then
            frmDebitMemoRegsiter.MdiParent = frmMain
            frmDebitMemoRegsiter.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Purchase Journal") And frmLogin.user <> "testuser" Then
            frmPurchaseJournal.MdiParent = frmMain
            frmPurchaseJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Sales Journal") And frmLogin.user <> "testuser" Then
            frmSalesJournal.MdiParent = frmMain
            frmSalesJournal.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Checkwrite") Then
            frmCheckwrite.MdiParent = frmMain
            frmCheckwrite.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Inventory Books") And frmLogin.user <> "testuser" Then
            frmInventoryBooks.MdiParent = frmMain
            frmInventoryBooks.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary Alphalist of Withholding Taxes") And frmLogin.user = "testuser" Then
            SAWT.MdiParent = frmMain
            SAWT.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary Alphalist of Payees") And frmLogin.user = "testuser" Then
            SLS.MdiParent = frmMain
            SLS.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary List of Sales") And frmLogin.user = "testuser" Then
            ST.MdiParent = frmMain
            ST.Show()
        ElseIf TreeView1.SelectedNode.Text.Equals("Summary List of Purchases") And frmLogin.user = "testuser" Then
            PT.MdiParent = frmMain
            PT.Show()
        Else

        End If

    End Sub

End Class