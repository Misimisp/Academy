Public Class frmstaff

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, ovStaff.MouseDown, MSG_lbl.MouseDown
        MouseD(Me)
    End Sub

    Private Sub frmLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, ovStaff.MouseMove, MSG_lbl.MouseMove
        MouseM(Me)
    End Sub

    Private Sub frmLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, ovStaff.MouseUp, MSG_lbl.MouseUp
        MouseU()
    End Sub

End Class