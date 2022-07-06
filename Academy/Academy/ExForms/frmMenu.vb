Public Class frmMenu


    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        ac.login.LogoutAdmin()
    End Sub
End Class
