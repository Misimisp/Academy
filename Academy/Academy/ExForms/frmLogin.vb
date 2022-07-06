Public Class frmLogin

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MSG_lbl.MouseDown, ovLogin.MouseDown
        MouseD(Me)
    End Sub

    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MSG_lbl.MouseMove, ovLogin.MouseMove
        MouseM(Me)
    End Sub

    Private Sub frmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles MSG_lbl.MouseUp, ovLogin.MouseUp
        MouseU()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ac.login.FMLoad()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PassLabel(GetCurrentTime, TIME_lbl)
    End Sub

    Private Sub SPASS_chk_CheckedChanged(sender As Object, e As EventArgs) Handles SPASS_chk.CheckedChanged
        ShowPwd(PASS_tb, SPASS_chk)
    End Sub

    Private Sub btnLogin_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnLogin.ClickButtonArea
        ac.login.loginDetails()
    End Sub

    Private Sub btnCancel_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnCancel.ClickButtonArea
        PassLabel("", MSG_lbl)
        Checkbox_Checked(False, SPASS_chk)
        GB_Visible(True, False, gbLoginType, gbLogin)
    End Sub

    Private Sub btnAdmin_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnAdmin.ClickButtonArea
        ac.login.Admin_Log_Hall()
    End Sub

    Private Sub btnExam_Hall_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnExam_Hall.ClickButtonArea
        ac.login.Examination_Log_Hall()
    End Sub

    Private Sub btnExit_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnExit.ClickButtonArea
        End
    End Sub
End Class