Public Class frmSPasskey

    Private Sub frmSPasskey_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MouseD(Me)
    End Sub

    Private Sub frmSPasskey_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseM(Me)
    End Sub

    Private Sub frmSPasskey_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        MouseU()
    End Sub
End Class