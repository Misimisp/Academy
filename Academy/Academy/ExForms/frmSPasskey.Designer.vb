<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSPasskey
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
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSPasskey))
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.PASSKEY_tb = New System.Windows.Forms.TextBox()
        Me.MSG_lbl = New System.Windows.Forms.Label()
        Me.GLabel1 = New gLabel.gLabel()
        Me.btnBack = New CButtonLib.CButton()
        Me.btnContinue = New CButtonLib.CButton()
        Me.GLabel2 = New gLabel.gLabel()
        Me.SuspendLayout()
        '
        'PASSKEY_tb
        '
        Me.PASSKEY_tb.BackColor = System.Drawing.Color.White
        Me.PASSKEY_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSKEY_tb.ForeColor = System.Drawing.Color.Blue
        Me.PASSKEY_tb.Location = New System.Drawing.Point(103, 118)
        Me.PASSKEY_tb.Name = "PASSKEY_tb"
        Me.PASSKEY_tb.Size = New System.Drawing.Size(206, 23)
        Me.PASSKEY_tb.TabIndex = 2
        '
        'MSG_lbl
        '
        Me.MSG_lbl.Location = New System.Drawing.Point(34, 78)
        Me.MSG_lbl.Name = "MSG_lbl"
        Me.MSG_lbl.Size = New System.Drawing.Size(343, 23)
        Me.MSG_lbl.TabIndex = 3
        Me.MSG_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GLabel1
        '
        Me.GLabel1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.GLabel1.ForeColorBlend = CBlendItems1
        Me.GLabel1.Glow = 15
        Me.GLabel1.GlowColor = System.Drawing.Color.Blue
        Me.GLabel1.Location = New System.Drawing.Point(56, 196)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(299, 21)
        Me.GLabel1.TabIndex = 13
        Me.GLabel1.Text = "Enter your passkey and press continue"
        '
        'btnBack
        '
        Me.btnBack.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Cyan, System.Drawing.Color.Blue}
        CBlendItems2.iPoint = New Single() {0.0!, 0.1111111!, 0.5!, 1.0!}
        Me.btnBack.ColorFillBlend = CBlendItems2
        Me.btnBack.Corners.All = 17
        Me.btnBack.Corners.LowerLeft = 17
        Me.btnBack.Corners.LowerRight = 17
        Me.btnBack.Corners.UpperLeft = 17
        Me.btnBack.Corners.UpperRight = 17
        Me.btnBack.DesignerSelected = False
        Me.btnBack.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnBack.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.ImageIndex = 0
        Me.btnBack.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnBack.Location = New System.Drawing.Point(103, 150)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 35)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        '
        'btnContinue
        '
        Me.btnContinue.BorderColor = System.Drawing.Color.LightBlue
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Cyan, System.Drawing.Color.Blue}
        CBlendItems3.iPoint = New Single() {0.0!, 0.1203704!, 0.5!, 1.0!}
        Me.btnContinue.ColorFillBlend = CBlendItems3
        Me.btnContinue.Corners.All = 17
        Me.btnContinue.Corners.LowerLeft = 17
        Me.btnContinue.Corners.LowerRight = 17
        Me.btnContinue.Corners.UpperLeft = 17
        Me.btnContinue.Corners.UpperRight = 17
        Me.btnContinue.DesignerSelected = False
        Me.btnContinue.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnContinue.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.btnContinue.Image = CType(resources.GetObject("btnContinue.Image"), System.Drawing.Image)
        Me.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinue.ImageIndex = 0
        Me.btnContinue.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnContinue.Location = New System.Drawing.Point(209, 150)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 35)
        Me.btnContinue.TabIndex = 15
        Me.btnContinue.Text = "Continue"
        '
        'GLabel2
        '
        Me.GLabel2.BackColor = System.Drawing.Color.White
        Me.GLabel2.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 20
        Me.GLabel2.GlowColor = System.Drawing.Color.DodgerBlue
        Me.GLabel2.Location = New System.Drawing.Point(106, 26)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(198, 41)
        Me.GLabel2.TabIndex = 16
        Me.GLabel2.Text = "SMPTech Acadamy"
        '
        'frmSPasskey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 271)
        Me.Controls.Add(Me.GLabel2)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GLabel1)
        Me.Controls.Add(Me.MSG_lbl)
        Me.Controls.Add(Me.PASSKEY_tb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSPasskey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSPasskey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PASSKEY_tb As System.Windows.Forms.TextBox
    Friend WithEvents MSG_lbl As System.Windows.Forms.Label
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents btnBack As CButtonLib.CButton
    Friend WithEvents btnContinue As CButtonLib.CButton
    Friend WithEvents GLabel2 As gLabel.gLabel
End Class
