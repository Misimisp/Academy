Imports System.Data.OleDb
Imports System.IO

Module Template

    '=============================================
    '        OPEN AND CLOSE CONNECTION
    '=============================================
    Private ReadOnly Property ConnectDB As OleDbConnection
        Get
            Select Case con Is Nothing
                Case True
                    con = New OleDbConnection(ConnString)
                    con.Open()
                Case Else
                    Select Case con.State <> ConnectionState.Closed
                        Case True
                            con.Close()
                    End Select
                    con.Open()
            End Select
            Return con
        End Get
    End Property

    '=============================================
    '               EXECUTE DATATABLE
    '=============================================
    Public Function ExecuteTable(sSQL As String) As DataTable
        Using da As New OleDbDataAdapter(sSQL, ConnectDB)
            da.Fill(dt)
            Return dt
        End Using
    End Function

    '=============================================
    '               EXECUTE DATAREADER
    '=============================================
    Public Function ExecuteRead(sSQL As String) As OleDbDataReader
        Using cmd As New OleDbCommand(sSQL, ConnectDB)
            ExecuteRead = cmd.ExecuteReader()
            Return ExecuteRead
        End Using
    End Function

    '=============================================
    '               EXECUTE DATA COUNT
    '=============================================
    Public Function EXECUTECOUNT(sSQL As String) As Integer
        Using cmd As New OleDbCommand(sSQL, ConnectDB)
            EXECUTECOUNT = cmd.ExecuteScalar()
            Return EXECUTECOUNT
        End Using
    End Function


    '=============================================
    '          FORM MOVEMENT CONSTRUCTION
    '=============================================
    Public Sub MouseD(fm As Form)
        drag = True
        mousey = Cursor.Position.Y - fm.Top
        mousex = Cursor.Position.X - fm.Left
    End Sub

    Public Sub MouseM(fm As Form)
        If drag Then
            fm.Top = Cursor.Position.Y - mousey
            fm.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Public Sub MouseU()
        drag = False
    End Sub

    '=============================================
    '       GENERATE DATA ID
    '=============================================
    Public Function GenerateID(sa As String, da As String) As Integer
        GenerateID = ExecuteCount("SELECT COUNT(" & sa & ") AS Code FROM " & da)
        GenerateID = If(GenerateID > 0, ExecuteCount("SELECT MAX(" & sa & ") AS Code FROM " & da), GenerateID)
        GenerateID += 1
        Return GenerateID
    End Function

    '============================================
    '           SAVE IMAGE TO DATABASE
    '============================================
    Public Function SaveImage(pc As PictureBox) As Byte()
        Using mStream As New MemoryStream
            pc.Image.Save(mStream, Imaging.ImageFormat.Jpeg)
            SaveImage = mStream.GetBuffer()
            mStream.Close()
            Return SaveImage
        End Using
    End Function

    '============================================
    '         LOAD IMAGE FROM DATABASE
    '============================================
    Public Function LoadSteamImage(strField As String) As Bitmap
        Using stream As New MemoryStream()
            Dim image As Byte() = dr(strField)
            stream.Write(image, 0, image.Length)
            LoadSteamImage = New Bitmap(stream)
            Return LoadSteamImage
        End Using
    End Function

    '============================================
    '           CHHECK FOR ERROR
    '============================================
    Public Function CheckTxTError(txt As TextBox, txt2 As TextBox, message As String, lbl As Label) As Boolean
        CheckTxTError = Trim(txt.Text) = "" OrElse Trim(txt2.Text) = ""
        Select Case CheckTxTError
            Case True
                ShowError(message, lbl)
        End Select
        Return CheckTxTError
    End Function

    Public Function CheckComboError(cmb As ComboBox, message As String, lbl As Label) As Boolean
        CheckComboError = cmb.Text = "" OrElse cmb.Text = "Choose"
        Select Case CheckComboError
            Case True
                ShowError(message, lbl)
        End Select
        Return CheckComboError
    End Function

    '============================================
    '         SUCCESS AND ERROR MESSAGE
    '============================================
    Public Sub ShowSuccess(message As String, lbl As Label)
        lbl.ForeColor = Color.Green
        lbl.Visible = True
        PassLabel(message, lbl)
    End Sub

    Public Sub ShowError(message As String, lbl As Label)
        lbl.ForeColor = Color.Red
        lbl.Visible = True
        PassLabel(message, lbl)
    End Sub

    '=============================================
    '         OBJECT VISIBILITY
    '=============================================
    Public Sub GB_Visible(reset As Boolean, reset1 As Boolean, gb As GroupBox, gb2 As GroupBox)
        gb.BringToFront()
        gb.Visible = reset
        gb2.Visible = reset1
    End Sub

    Public Sub Checkbox_Checked(Reset As Boolean, chk As CheckBox)
        chk.Checked = Reset
    End Sub


    '=============================================
    '           PASS TEXT OBJECT
    '=============================================
    Public Sub PassTextbox(sa As String, txt As TextBox)
        txt.Text = sa
    End Sub

    Public Sub PassGroupbox(sa As String, gb As GroupBox)
        gb.Text = sa
    End Sub

    Public Sub PassLabel(sa As String, lbl As Label)
        lbl.Text = sa
    End Sub

    Public Sub PassImage(img As Image, pc As PictureBox)
        pc.Image = img
    End Sub



    '=============================================
    '         START AND STOP TIMER
    '=============================================
    Public Sub Start_Time(sa As Integer, tmr As Timer)
        tmr.Enabled = False
        tmr.Interval = sa
        tmr.Start()
    End Sub

    Public Sub Stop_Time(tmr As Timer)
        tmr.Enabled = False
        tmr.Stop()
    End Sub

    '=============================================
    '       GENERATE CURRENT TIME
    '=============================================
    Public Function GetCurrentTime() As String
        Return Date.Now.ToString("hh:mm tt")
    End Function


    '==================================== 
    '       HIDE AND SHOW PASSWORD
    '===================================== 
    Public Sub ShowPwd(txt As TextBox, chk As CheckBox)
        Select Case chk.Checked
            Case True
                txt.PasswordChar = ""
            Case Else
                txt.PasswordChar = "*"
        End Select
    End Sub

    '==================================== 
    '       HIDE AND SHOW FORM
    '===================================== 
    Public Sub FormShowShow(fm As Form, fm2 As Form)
        fm.Hide()
        fm2.Show()
    End Sub

    Public Sub FormShowShowDialogue(fm As Form, fm2 As Form)
        fm.Hide()
        fm2.ShowDialog()
    End Sub
End Module
