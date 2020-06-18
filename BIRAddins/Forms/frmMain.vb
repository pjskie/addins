Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        frmTreeView.MdiParent = Me
        frmTreeView.Show()
    End Sub
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            frmTreeView.MdiParent = Me
            frmTreeView.Show()
        End If
    End Sub

End Class
