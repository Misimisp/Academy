Public Class frmResult

    Private Sub frmContacts_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MouseD(Me)
    End Sub

    Private Sub frmContacts_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseM(Me)
    End Sub

    Private Sub frmContacts_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        MouseU()
    End Sub

    Private Sub CLOSE_btn_Click(sender As Object, e As EventArgs) Handles CLOSE_btn.Click
        Me.Close()
    End Sub

    Private Sub CLOSE_btn_MouseHover(sender As Object, e As EventArgs) Handles CLOSE_btn.MouseHover
        CLOSE_btn.BackColor = Color.Red
    End Sub

    Private Sub CLOSE_btn_MouseLeave(sender As Object, e As EventArgs) Handles CLOSE_btn.MouseLeave
        CLOSE_btn.BackColor = Color.White
    End Sub

    Private Sub frmResultBroadsheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FillDGConfigThree("Code", "Last Name", "First Name", "Mid Name", dgVIEW)
    End Sub
End Class