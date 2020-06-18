Public Class frmLogin

    Public user As String

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If txtPassword.Text = "hex" Or txtPassword.Text = "AP" Then
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckCredentials()
    End Sub
    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal login As KeyEventArgs) Handles MyBase.KeyDown
        If login.KeyCode = Keys.Enter Then
            CheckCredentials()
        End If
    End Sub

    Public Sub CheckCredentials()
        If txtPassword.Text = "hex" Then
            user = "A/P"
            Me.Hide()
        ElseIf txtPassword.Text = "Managerxz" Then
            user = "Manager"
            Me.Hide()
        ElseIf txtPassword.Text = "AP" Then
            user = "testuser"
            Me.Hide()
        Else
            MessageBox.Show("Password Incorrect",
            "Critical Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)

            txtPassword.Text = ""

        End If
    End Sub
End Class