Public Class fxLogin

    Public Sub FMLoad()
        With frmLogin
            ClearLogintxt()
            Start_Time(100, .Timer1)
            Checkbox_Checked(False, .SPASS_chk)
            GB_Visible(True, False, .gbLoginType, .gbLogin)
        End With
    End Sub

    Public Sub Admin_Log_Hall()
        With frmLogin
            ClearLogintxt()
            PassTextbox("Admin", .USER_tb)
            PassImage(photo.tAdmin, .pcImage)
            PassGroupbox(.btnAdmin.Text, .gbLogin)
            GB_Visible(True, False, .gbLogin, .gbLoginType)
        End With
    End Sub

    Public Sub Examination_Log_Hall()
        With frmLogin
            ClearLogintxt()
            PassTextbox("Student", .USER_tb)
            PassImage(photo.student, .pcImage)
            PassGroupbox(.btnExam_Hall.Text, .gbLogin)
            GB_Visible(True, False, .gbLogin, .gbLoginType)
        End With
    End Sub

    Public Sub loginDetails()
        With frmLogin
            Try
                If CheckTxTError(.USER_tb, .PASS_tb, "Passkey can not be blank", .MSG_lbl) = True Then Return
                Select Case .USER_tb.Text
                    Case "Admin"
                        LoginAdmin()
                    Case "Student"
                        LoginStudent()
                End Select
            Catch ex As Exception
                .MSG_lbl.Text = ex.Message
            End Try
        End With
    End Sub

    Private Sub LoginAdmin()
        With frmLogin
            dr = ExecuteRead(LoginLoginA(.USER_tb, .PASS_tb))
            Select Case dr.Read
                Case True
                    username = dr("Username")
                    passkey = dr("Password")
            End Select
            dr.Close()
            Select Case .USER_tb.Text = username And .PASS_tb.Text = passkey
                Case True
                    FormShowShow(frmLogin, frmMenu)
                Case Else
                    ShowError("Invalid login details, please try again", .MSG_lbl)
            End Select
        End With
    End Sub

    Private Sub LoginStudent()
        With frmLogin
            dr = ExecuteRead(LoginLoginS(.PASS_tb))
            Select Case dr.Read
                Case True
                    idIndex = dr("StudentID")
                    passkey = dr("S_Code")
                    fname = dr("F_Name")
                    mname = dr("M_Name")
                    lname = dr("L_Name")
                    Dim pc As PictureBox = New PictureBox
                    pc.Image = LoadSteamImage("Photo")
            End Select
            dr.Close()
            Select Case .PASS_tb.Text = passkey
                Case True
                    frmSPasskey.PASSKEY_tb.Clear()
                    frmSPasskey.ShowDialog()
                Case Else
                    ShowError("Invalid login details, please try again", .MSG_lbl)
            End Select
        End With
    End Sub

    Public Sub LogoutAdmin()
        With frmLogin
            Admin_Log_Hall()
            FormShowShow(frmMenu, frmLogin)
            ShowSuccess("Successfully Logout", .MSG_lbl)
        End With
    End Sub

    Private Sub ClearLogintxt()
        With frmLogin
            PassLabel("", .MSG_lbl)
            PassTextbox("", .USER_tb)
            PassTextbox("", .PASS_tb)
        End With
    End Sub
End Class
