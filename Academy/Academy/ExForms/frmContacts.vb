Public Class frmContacts

    Private Sub frmContacts_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MouseD(Me)
    End Sub

    Private Sub frmContacts_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseM(Me)
    End Sub

    Private Sub frmContacts_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        MouseU()
    End Sub

    'Private Sub CLOSE_btn_MouseHover(sender As Object, e As MouseEventArgs) Handles btnClose.MouseHover
    '    btnClose.BackColor = Color.Red
    'End Sub

    'Private Sub CLOSE_btn_MouseLeave(sender As Object, e As MouseEventArgs) Handles btnClose.MouseLeave
    '    btnClose.BackColor = Color.White
    'End Sub

    Private Sub frmContacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGConfigFour("Code", "Last Name", "First Name", "Mid Name", dgVIEW)
    End Sub

    Private Sub btnClose_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnClose.ClickButtonArea
        Me.Close()
    End Sub
End Class