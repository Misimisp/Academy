<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems7 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Me.ovLogin = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.btnForgetPwd = New CButtonLib.CButton()
        Me.GLabel2 = New gLabel.gLabel()
        Me.GLabel1 = New gLabel.gLabel()
        Me.btnCancel = New CButtonLib.CButton()
        Me.btnLogin = New CButtonLib.CButton()
        Me.SPASS_chk = New System.Windows.Forms.CheckBox()
        Me.pcImage = New System.Windows.Forms.PictureBox()
        Me.PASS_tb = New System.Windows.Forms.TextBox()
        Me.USER_tb = New System.Windows.Forms.TextBox()
        Me.MSG_lbl = New System.Windows.Forms.Label()
        Me.gbLoginType = New System.Windows.Forms.GroupBox()
        Me.btnExit = New CButtonLib.CButton()
        Me.btnExam_Hall = New CButtonLib.CButton()
        Me.btnAdmin = New CButtonLib.CButton()
        Me.GLabel3 = New gLabel.gLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TIME_lbl = New gLabel.gLabel()
        Me.GLabel4 = New gLabel.gLabel()
        Me.gbLogin.SuspendLayout()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLoginType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ovLogin
        '
        Me.ovLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ovLogin.BackColor = System.Drawing.Color.White
        Me.ovLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ovLogin.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ovLogin.BorderColor = System.Drawing.Color.White
        Me.ovLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ovLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ovLogin.FillColor = System.Drawing.Color.White
        Me.ovLogin.FillGradientColor = System.Drawing.Color.White
        Me.ovLogin.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.ovLogin.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.ovLogin.Location = New System.Drawing.Point(24, 32)
        Me.ovLogin.Name = "ovLogin"
        Me.ovLogin.Size = New System.Drawing.Size(524, 476)
        '
        'gbLogin
        '
        Me.gbLogin.BackColor = System.Drawing.Color.White
        Me.gbLogin.Controls.Add(Me.btnForgetPwd)
        Me.gbLogin.Controls.Add(Me.GLabel2)
        Me.gbLogin.Controls.Add(Me.GLabel1)
        Me.gbLogin.Controls.Add(Me.btnCancel)
        Me.gbLogin.Controls.Add(Me.btnLogin)
        Me.gbLogin.Controls.Add(Me.SPASS_chk)
        Me.gbLogin.Controls.Add(Me.pcImage)
        Me.gbLogin.Controls.Add(Me.PASS_tb)
        Me.gbLogin.Controls.Add(Me.USER_tb)
        Me.gbLogin.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogin.ForeColor = System.Drawing.Color.Blue
        Me.gbLogin.Location = New System.Drawing.Point(102, 160)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(369, 174)
        Me.gbLogin.TabIndex = 3
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = "Login Details"
        '
        'btnForgetPwd
        '
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.btnForgetPwd.ColorFillBlend = CBlendItems1
        Me.btnForgetPwd.Corners.LowerLeft = 12
        Me.btnForgetPwd.Corners.UpperLeft = 11
        Me.btnForgetPwd.Corners.UpperRight = 12
        Me.btnForgetPwd.DesignerSelected = False
        Me.btnForgetPwd.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnForgetPwd.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgetPwd.ImageIndex = 0
        Me.btnForgetPwd.Location = New System.Drawing.Point(16, 139)
        Me.btnForgetPwd.Name = "btnForgetPwd"
        Me.btnForgetPwd.Size = New System.Drawing.Size(124, 25)
        Me.btnForgetPwd.TabIndex = 11
        Me.btnForgetPwd.Text = "Forget password ?"
        '
        'GLabel2
        '
        Me.GLabel2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 15
        Me.GLabel2.GlowColor = System.Drawing.Color.Blue
        Me.GLabel2.Location = New System.Drawing.Point(170, 64)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(75, 21)
        Me.GLabel2.TabIndex = 10
        Me.GLabel2.Text = "Password :"
        '
        'GLabel1
        '
        Me.GLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 15
        Me.GLabel1.GlowColor = System.Drawing.Color.Blue
        Me.GLabel1.Location = New System.Drawing.Point(170, 17)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(75, 21)
        Me.GLabel1.TabIndex = 10
        Me.GLabel1.Text = "Username :"
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Blue, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.1459627!, 1.0!}
        Me.btnCancel.ColorFillBlend = CBlendItems2
        Me.btnCancel.Corners.All = 12
        Me.btnCancel.Corners.LowerLeft = 12
        Me.btnCancel.Corners.LowerRight = 12
        Me.btnCancel.Corners.UpperLeft = 12
        Me.btnCancel.Corners.UpperRight = 12
        Me.btnCancel.DesignerSelected = False
        Me.btnCancel.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 0
        Me.btnCancel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancel.Location = New System.Drawing.Point(158, 139)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 25)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Back"
        '
        'btnLogin
        '
        Me.btnLogin.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Blue, System.Drawing.Color.Green}
        CBlendItems3.iPoint = New Single() {0.0!, 0.1459627!, 1.0!}
        Me.btnLogin.ColorFillBlend = CBlendItems3
        Me.btnLogin.Corners.All = 12
        Me.btnLogin.Corners.LowerLeft = 12
        Me.btnLogin.Corners.LowerRight = 12
        Me.btnLogin.Corners.UpperLeft = 12
        Me.btnLogin.Corners.UpperRight = 12
        Me.btnLogin.DesignerSelected = True
        Me.btnLogin.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnLogin.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.ImageIndex = 0
        Me.btnLogin.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLogin.Location = New System.Drawing.Point(254, 139)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 25)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        '
        'SPASS_chk
        '
        Me.SPASS_chk.AutoSize = True
        Me.SPASS_chk.Location = New System.Drawing.Point(173, 112)
        Me.SPASS_chk.Name = "SPASS_chk"
        Me.SPASS_chk.Size = New System.Drawing.Size(89, 17)
        Me.SPASS_chk.TabIndex = 3
        Me.SPASS_chk.Text = "Show password"
        Me.SPASS_chk.UseVisualStyleBackColor = True
        '
        'pcImage
        '
        Me.pcImage.Image = Global.Academy.My.Resources.Resources.student
        Me.pcImage.Location = New System.Drawing.Point(38, 26)
        Me.pcImage.Name = "pcImage"
        Me.pcImage.Size = New System.Drawing.Size(102, 98)
        Me.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcImage.TabIndex = 3
        Me.pcImage.TabStop = False
        '
        'PASS_tb
        '
        Me.PASS_tb.ForeColor = System.Drawing.Color.Blue
        Me.PASS_tb.Location = New System.Drawing.Point(173, 87)
        Me.PASS_tb.Name = "PASS_tb"
        Me.PASS_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASS_tb.Size = New System.Drawing.Size(147, 20)
        Me.PASS_tb.TabIndex = 2
        '
        'USER_tb
        '
        Me.USER_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USER_tb.ForeColor = System.Drawing.Color.Blue
        Me.USER_tb.Location = New System.Drawing.Point(173, 41)
        Me.USER_tb.Name = "USER_tb"
        Me.USER_tb.Size = New System.Drawing.Size(147, 23)
        Me.USER_tb.TabIndex = 1
        '
        'MSG_lbl
        '
        Me.MSG_lbl.BackColor = System.Drawing.Color.White
        Me.MSG_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSG_lbl.ForeColor = System.Drawing.Color.Blue
        Me.MSG_lbl.Location = New System.Drawing.Point(107, 109)
        Me.MSG_lbl.Name = "MSG_lbl"
        Me.MSG_lbl.Size = New System.Drawing.Size(359, 23)
        Me.MSG_lbl.TabIndex = 3
        Me.MSG_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbLoginType
        '
        Me.gbLoginType.BackColor = System.Drawing.Color.White
        Me.gbLoginType.Controls.Add(Me.btnExit)
        Me.gbLoginType.Controls.Add(Me.btnExam_Hall)
        Me.gbLoginType.Controls.Add(Me.btnAdmin)
        Me.gbLoginType.Controls.Add(Me.GLabel3)
        Me.gbLoginType.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLoginType.ForeColor = System.Drawing.Color.Blue
        Me.gbLoginType.Location = New System.Drawing.Point(112, 137)
        Me.gbLoginType.Name = "gbLoginType"
        Me.gbLoginType.Size = New System.Drawing.Size(359, 215)
        Me.gbLoginType.TabIndex = 4
        Me.gbLoginType.TabStop = False
        Me.gbLoginType.Text = "Login Type"
        '
        'btnExit
        '
        Me.btnExit.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Cyan, System.Drawing.Color.Blue}
        CBlendItems4.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnExit.ColorFillBlend = CBlendItems4
        Me.btnExit.Corners.All = 17
        Me.btnExit.Corners.LowerLeft = 17
        Me.btnExit.Corners.LowerRight = 17
        Me.btnExit.Corners.UpperLeft = 17
        Me.btnExit.Corners.UpperRight = 17
        Me.btnExit.DesignerSelected = False
        Me.btnExit.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnExit.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageIndex = 0
        Me.btnExit.Location = New System.Drawing.Point(63, 158)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(232, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "End"
        '
        'btnExam_Hall
        '
        Me.btnExam_Hall.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Cyan, System.Drawing.Color.Blue}
        CBlendItems5.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnExam_Hall.ColorFillBlend = CBlendItems5
        Me.btnExam_Hall.Corners.LowerLeft = 14
        Me.btnExam_Hall.Corners.LowerRight = 14
        Me.btnExam_Hall.DesignerSelected = False
        Me.btnExam_Hall.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnExam_Hall.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExam_Hall.ImageIndex = 0
        Me.btnExam_Hall.Location = New System.Drawing.Point(182, 29)
        Me.btnExam_Hall.Name = "btnExam_Hall"
        Me.btnExam_Hall.Size = New System.Drawing.Size(124, 29)
        Me.btnExam_Hall.TabIndex = 6
        Me.btnExam_Hall.Text = "Examination Hall"
        '
        'btnAdmin
        '
        Me.btnAdmin.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.Cyan, System.Drawing.Color.Blue}
        CBlendItems6.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnAdmin.ColorFillBlend = CBlendItems6
        Me.btnAdmin.Corners.LowerLeft = 14
        Me.btnAdmin.Corners.LowerRight = 14
        Me.btnAdmin.DesignerSelected = False
        Me.btnAdmin.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnAdmin.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAdmin.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnAdmin.ImageIndex = 0
        Me.btnAdmin.Location = New System.Drawing.Point(52, 29)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(124, 29)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "Admin"
        '
        'GLabel3
        '
        Me.GLabel3.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.GLabel3.ForeColor = System.Drawing.Color.Blue
        Me.GLabel3.Glow = 5
        Me.GLabel3.GlowColor = System.Drawing.Color.Gold
        Me.GLabel3.Location = New System.Drawing.Point(37, 79)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(273, 68)
        Me.GLabel3.TabIndex = 4
        Me.GLabel3.Text = "Select the hall you want to login into." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student should login with their MATRIC N" & _
    "UMBER and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Administration, please contact the management for the login detai" & _
    "ls." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ovLogin})
        Me.ShapeContainer1.Size = New System.Drawing.Size(573, 539)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Timer1
        '
        '
        'TIME_lbl
        '
        Me.TIME_lbl.BackColor = System.Drawing.Color.White
        Me.TIME_lbl.BorderColor = System.Drawing.Color.White
        Me.TIME_lbl.FillType = gLabel.gLabel.eFillType.GradientLinear
        Me.TIME_lbl.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TIME_lbl.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold)
        CBlendItems7.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer)), System.Drawing.Color.Navy}
        CBlendItems7.iPoint = New Single() {0.0!, 0.4382716!, 0.5802469!, 1.0!}
        Me.TIME_lbl.ForeColorBlend = CBlendItems7
        Me.TIME_lbl.Glow = 15
        Me.TIME_lbl.Location = New System.Drawing.Point(183, 381)
        Me.TIME_lbl.Name = "TIME_lbl"
        Me.TIME_lbl.Pulse = True
        Me.TIME_lbl.Size = New System.Drawing.Size(206, 63)
        Me.TIME_lbl.TabIndex = 10
        Me.TIME_lbl.Text = "Password "
        '
        'GLabel4
        '
        Me.GLabel4.BackColor = System.Drawing.Color.White
        Me.GLabel4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel4.ForeColor = System.Drawing.Color.White
        Me.GLabel4.Glow = 20
        Me.GLabel4.GlowColor = System.Drawing.Color.DodgerBlue
        Me.GLabel4.Location = New System.Drawing.Point(191, 68)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(198, 41)
        Me.GLabel4.TabIndex = 11
        Me.GLabel4.Text = "SMPTech Acadamy"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(573, 539)
        Me.Controls.Add(Me.gbLogin)
        Me.Controls.Add(Me.gbLoginType)
        Me.Controls.Add(Me.GLabel4)
        Me.Controls.Add(Me.TIME_lbl)
        Me.Controls.Add(Me.MSG_lbl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLoginType.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ovLogin As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents gbLogin As System.Windows.Forms.GroupBox
    Friend WithEvents SPASS_chk As System.Windows.Forms.CheckBox
    Friend WithEvents pcImage As System.Windows.Forms.PictureBox
    Friend WithEvents PASS_tb As System.Windows.Forms.TextBox
    Friend WithEvents USER_tb As System.Windows.Forms.TextBox
    Friend WithEvents MSG_lbl As System.Windows.Forms.Label
    Friend WithEvents gbLoginType As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnLogin As CButtonLib.CButton
    Friend WithEvents btnCancel As CButtonLib.CButton
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents btnForgetPwd As CButtonLib.CButton
    Friend WithEvents TIME_lbl As gLabel.gLabel
    Friend WithEvents btnExam_Hall As CButtonLib.CButton
    Friend WithEvents btnAdmin As CButtonLib.CButton
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents btnExit As CButtonLib.CButton
    Friend WithEvents GLabel4 As gLabel.gLabel
End Class
