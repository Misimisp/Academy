﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstaff
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
        Dim CBlendItems2 As gLabel.cBlendItems = New gLabel.cBlendItems()
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstaff))
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ovStaff = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.MSG_lbl = New System.Windows.Forms.Label()
        Me.SHOWIMAGE_chk = New System.Windows.Forms.CheckBox()
        Me.PHONE_tb = New System.Windows.Forms.TextBox()
        Me.F_NAME_tb = New System.Windows.Forms.TextBox()
        Me.ADMISSION_tb = New System.Windows.Forms.TextBox()
        Me.L_NAME_tb = New System.Windows.Forms.TextBox()
        Me.STAFF_pc = New System.Windows.Forms.PictureBox()
        Me.GLabel4 = New gLabel.gLabel()
        Me.HEADER_lbl = New gLabel.gLabel()
        Me.GLabel1 = New gLabel.gLabel()
        Me.GLabel2 = New gLabel.gLabel()
        Me.GLabel3 = New gLabel.gLabel()
        Me.GLabel5 = New gLabel.gLabel()
        Me.P_Code_lbl = New gLabel.gLabel()
        Me.btnBrowse = New CButtonLib.CButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GLabel6 = New gLabel.gLabel()
        Me.btnSave = New CButtonLib.CButton()
        Me.btnDelete = New CButtonLib.CButton()
        Me.btnCancel = New CButtonLib.CButton()
        CType(Me.STAFF_pc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ovStaff})
        Me.ShapeContainer1.Size = New System.Drawing.Size(745, 621)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'ovStaff
        '
        Me.ovStaff.BackColor = System.Drawing.Color.Blue
        Me.ovStaff.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.ovStaff.BorderColor = System.Drawing.Color.Blue
        Me.ovStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ovStaff.FillColor = System.Drawing.Color.Blue
        Me.ovStaff.FillGradientColor = System.Drawing.Color.Blue
        Me.ovStaff.Location = New System.Drawing.Point(53, 23)
        Me.ovStaff.Name = "ovStaff"
        Me.ovStaff.Size = New System.Drawing.Size(638, 575)
        '
        'MSG_lbl
        '
        Me.MSG_lbl.BackColor = System.Drawing.Color.Blue
        Me.MSG_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MSG_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MSG_lbl.Location = New System.Drawing.Point(118, 153)
        Me.MSG_lbl.Name = "MSG_lbl"
        Me.MSG_lbl.Size = New System.Drawing.Size(509, 252)
        Me.MSG_lbl.TabIndex = 12
        Me.MSG_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SHOWIMAGE_chk
        '
        Me.SHOWIMAGE_chk.AutoSize = True
        Me.SHOWIMAGE_chk.BackColor = System.Drawing.Color.Blue
        Me.SHOWIMAGE_chk.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHOWIMAGE_chk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SHOWIMAGE_chk.Location = New System.Drawing.Point(453, 351)
        Me.SHOWIMAGE_chk.Name = "SHOWIMAGE_chk"
        Me.SHOWIMAGE_chk.Size = New System.Drawing.Size(80, 19)
        Me.SHOWIMAGE_chk.TabIndex = 5
        Me.SHOWIMAGE_chk.Text = "Edit image"
        Me.SHOWIMAGE_chk.UseVisualStyleBackColor = False
        '
        'PHONE_tb
        '
        Me.PHONE_tb.BackColor = System.Drawing.Color.Blue
        Me.PHONE_tb.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE_tb.ForeColor = System.Drawing.Color.White
        Me.PHONE_tb.Location = New System.Drawing.Point(238, 336)
        Me.PHONE_tb.Name = "PHONE_tb"
        Me.PHONE_tb.Size = New System.Drawing.Size(192, 24)
        Me.PHONE_tb.TabIndex = 4
        '
        'F_NAME_tb
        '
        Me.F_NAME_tb.BackColor = System.Drawing.Color.Blue
        Me.F_NAME_tb.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_NAME_tb.ForeColor = System.Drawing.Color.White
        Me.F_NAME_tb.Location = New System.Drawing.Point(238, 222)
        Me.F_NAME_tb.Name = "F_NAME_tb"
        Me.F_NAME_tb.Size = New System.Drawing.Size(192, 24)
        Me.F_NAME_tb.TabIndex = 1
        '
        'ADMISSION_tb
        '
        Me.ADMISSION_tb.BackColor = System.Drawing.Color.Blue
        Me.ADMISSION_tb.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADMISSION_tb.ForeColor = System.Drawing.Color.White
        Me.ADMISSION_tb.Location = New System.Drawing.Point(238, 298)
        Me.ADMISSION_tb.Name = "ADMISSION_tb"
        Me.ADMISSION_tb.Size = New System.Drawing.Size(192, 24)
        Me.ADMISSION_tb.TabIndex = 3
        '
        'L_NAME_tb
        '
        Me.L_NAME_tb.BackColor = System.Drawing.Color.Blue
        Me.L_NAME_tb.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NAME_tb.ForeColor = System.Drawing.Color.White
        Me.L_NAME_tb.Location = New System.Drawing.Point(238, 260)
        Me.L_NAME_tb.Name = "L_NAME_tb"
        Me.L_NAME_tb.Size = New System.Drawing.Size(192, 24)
        Me.L_NAME_tb.TabIndex = 2
        '
        'STAFF_pc
        '
        Me.STAFF_pc.BackColor = System.Drawing.Color.White
        Me.STAFF_pc.Image = Global.Academy.My.Resources.Resources.Photo
        Me.STAFF_pc.Location = New System.Drawing.Point(453, 222)
        Me.STAFF_pc.Name = "STAFF_pc"
        Me.STAFF_pc.Size = New System.Drawing.Size(126, 125)
        Me.STAFF_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.STAFF_pc.TabIndex = 23
        Me.STAFF_pc.TabStop = False
        '
        'GLabel4
        '
        Me.GLabel4.BackColor = System.Drawing.Color.Blue
        Me.GLabel4.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel4.ForeColor = System.Drawing.Color.Blue
        Me.GLabel4.Glow = 15
        Me.GLabel4.GlowColor = System.Drawing.Color.White
        Me.GLabel4.Location = New System.Drawing.Point(257, 58)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(231, 47)
        Me.GLabel4.TabIndex = 24
        Me.GLabel4.Text = "SMPTech Acadamy"
        '
        'HEADER_lbl
        '
        Me.HEADER_lbl.BackColor = System.Drawing.Color.Blue
        Me.HEADER_lbl.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HEADER_lbl.ForeColor = System.Drawing.Color.White
        Me.HEADER_lbl.Glow = 3
        Me.HEADER_lbl.GlowColor = System.Drawing.Color.White
        Me.HEADER_lbl.Location = New System.Drawing.Point(257, 107)
        Me.HEADER_lbl.Name = "HEADER_lbl"
        Me.HEADER_lbl.Size = New System.Drawing.Size(231, 38)
        Me.HEADER_lbl.TabIndex = 25
        Me.HEADER_lbl.Text = "Staff Registration"
        '
        'GLabel1
        '
        Me.GLabel1.BackColor = System.Drawing.Color.Blue
        Me.GLabel1.FillType = gLabel.gLabel.eFillType.GradientLinear
        Me.GLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 15
        Me.GLabel1.GlowColor = System.Drawing.Color.White
        Me.GLabel1.Location = New System.Drawing.Point(134, 222)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(94, 23)
        Me.GLabel1.TabIndex = 26
        Me.GLabel1.Text = "First Name :"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GLabel2
        '
        Me.GLabel2.BackColor = System.Drawing.Color.Blue
        Me.GLabel2.FillType = gLabel.gLabel.eFillType.GradientLinear
        Me.GLabel2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 15
        Me.GLabel2.GlowColor = System.Drawing.Color.White
        Me.GLabel2.Location = New System.Drawing.Point(134, 258)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(94, 23)
        Me.GLabel2.TabIndex = 26
        Me.GLabel2.Text = "Last Name :"
        Me.GLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GLabel3
        '
        Me.GLabel3.BackColor = System.Drawing.Color.Blue
        Me.GLabel3.FillType = gLabel.gLabel.eFillType.GradientLinear
        Me.GLabel3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel3.ForeColor = System.Drawing.Color.White
        Me.GLabel3.Glow = 15
        Me.GLabel3.GlowColor = System.Drawing.Color.White
        Me.GLabel3.Location = New System.Drawing.Point(123, 297)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(106, 23)
        Me.GLabel3.TabIndex = 26
        Me.GLabel3.Text = "Admission date :"
        Me.GLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GLabel5
        '
        Me.GLabel5.BackColor = System.Drawing.Color.Blue
        Me.GLabel5.FillType = gLabel.gLabel.eFillType.GradientLinear
        Me.GLabel5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel5.ForeColor = System.Drawing.Color.White
        Me.GLabel5.Glow = 15
        Me.GLabel5.GlowColor = System.Drawing.Color.White
        Me.GLabel5.Location = New System.Drawing.Point(123, 335)
        Me.GLabel5.Name = "GLabel5"
        Me.GLabel5.Size = New System.Drawing.Size(106, 23)
        Me.GLabel5.TabIndex = 26
        Me.GLabel5.Text = "Phone :"
        Me.GLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'P_Code_lbl
        '
        Me.P_Code_lbl.BackColor = System.Drawing.Color.Blue
        Me.P_Code_lbl.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.P_Code_lbl.ForeColor = System.Drawing.Color.White
        Me.P_Code_lbl.Glow = 3
        Me.P_Code_lbl.GlowColor = System.Drawing.Color.White
        Me.P_Code_lbl.Location = New System.Drawing.Point(234, 188)
        Me.P_Code_lbl.Name = "P_Code_lbl"
        Me.P_Code_lbl.Size = New System.Drawing.Size(201, 23)
        Me.P_Code_lbl.TabIndex = 26
        Me.P_Code_lbl.Text = "POL/05/108"
        Me.P_Code_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Blue
        Me.btnBrowse.BorderColor = System.Drawing.Color.White
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnBrowse.ColorFillBlend = CBlendItems1
        Me.btnBrowse.Corners.All = 12
        Me.btnBrowse.Corners.LowerLeft = 12
        Me.btnBrowse.Corners.LowerRight = 12
        Me.btnBrowse.Corners.UpperLeft = 12
        Me.btnBrowse.Corners.UpperRight = 12
        Me.btnBrowse.DesignerSelected = False
        Me.btnBrowse.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnBrowse.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ImageIndex = 0
        Me.btnBrowse.Location = New System.Drawing.Point(453, 377)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(126, 29)
        Me.btnBrowse.TabIndex = 27
        Me.btnBrowse.Text = "Browse"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GLabel6
        '
        Me.GLabel6.BackColor = System.Drawing.Color.Blue
        Me.GLabel6.BorderColor = System.Drawing.Color.Blue
        Me.GLabel6.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.GLabel6.ForeColor = System.Drawing.Color.White
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Navy}
        CBlendItems2.iPoint = New Single() {0.0!, 0.5!, 0.5432099!, 0.8240741!, 1.0!}
        Me.GLabel6.ForeColorBlend = CBlendItems2
        Me.GLabel6.Glow = 2
        Me.GLabel6.Location = New System.Drawing.Point(197, 474)
        Me.GLabel6.Name = "GLabel6"
        Me.GLabel6.Size = New System.Drawing.Size(358, 53)
        Me.GLabel6.TabIndex = 31
        Me.GLabel6.Text = "Tick the checkbox to edit your profile picture" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N.B:      Make sure you change th" & _
    "e picture f you tick edit image"
        Me.GLabel6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.BorderColor = System.Drawing.Color.White
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Blue}
        CBlendItems3.iPoint = New Single() {0.0!, 0.1141975!, 0.5432099!, 1.0!}
        Me.btnSave.ColorFillBlend = CBlendItems3
        Me.btnSave.Corners.All = 12
        Me.btnSave.Corners.LowerLeft = 12
        Me.btnSave.Corners.LowerRight = 12
        Me.btnSave.Corners.UpperLeft = 12
        Me.btnSave.Corners.UpperRight = 12
        Me.btnSave.DesignerSelected = False
        Me.btnSave.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnSave.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 0
        Me.btnSave.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnSave.Location = New System.Drawing.Point(447, 421)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 29)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "Save"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Blue
        Me.btnDelete.BorderColor = System.Drawing.Color.White
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Blue}
        CBlendItems4.iPoint = New Single() {0.0!, 0.1141975!, 0.5432099!, 1.0!}
        Me.btnDelete.ColorFillBlend = CBlendItems4
        Me.btnDelete.Corners.All = 12
        Me.btnDelete.Corners.LowerLeft = 12
        Me.btnDelete.Corners.LowerRight = 12
        Me.btnDelete.Corners.UpperLeft = 12
        Me.btnDelete.Corners.UpperRight = 12
        Me.btnDelete.DesignerSelected = False
        Me.btnDelete.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 0
        Me.btnDelete.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnDelete.Location = New System.Drawing.Point(309, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 29)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Blue
        Me.btnCancel.BorderColor = System.Drawing.Color.White
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0.0!, 0.5!, 1.0!}
        Me.btnCancel.ColorFillBlend = CBlendItems5
        Me.btnCancel.Corners.LowerRight = 12
        Me.btnCancel.Corners.UpperLeft = 12
        Me.btnCancel.Corners.UpperRight = 12
        Me.btnCancel.DesignerSelected = False
        Me.btnCancel.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.ImageIndex = 0
        Me.btnCancel.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnCancel.Location = New System.Drawing.Point(171, 424)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 29)
        Me.btnCancel.TabIndex = 62
        Me.btnCancel.Text = "Cancel"
        '
        'frmstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(745, 621)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GLabel6)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.P_Code_lbl)
        Me.Controls.Add(Me.GLabel5)
        Me.Controls.Add(Me.GLabel3)
        Me.Controls.Add(Me.GLabel2)
        Me.Controls.Add(Me.GLabel1)
        Me.Controls.Add(Me.HEADER_lbl)
        Me.Controls.Add(Me.GLabel4)
        Me.Controls.Add(Me.SHOWIMAGE_chk)
        Me.Controls.Add(Me.STAFF_pc)
        Me.Controls.Add(Me.PHONE_tb)
        Me.Controls.Add(Me.F_NAME_tb)
        Me.Controls.Add(Me.ADMISSION_tb)
        Me.Controls.Add(Me.L_NAME_tb)
        Me.Controls.Add(Me.MSG_lbl)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmstaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Registration"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.STAFF_pc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovStaff As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents MSG_lbl As System.Windows.Forms.Label
    Friend WithEvents SHOWIMAGE_chk As System.Windows.Forms.CheckBox
    Friend WithEvents STAFF_pc As System.Windows.Forms.PictureBox
    Friend WithEvents PHONE_tb As System.Windows.Forms.TextBox
    Friend WithEvents F_NAME_tb As System.Windows.Forms.TextBox
    Friend WithEvents ADMISSION_tb As System.Windows.Forms.TextBox
    Friend WithEvents L_NAME_tb As System.Windows.Forms.TextBox
    Friend WithEvents GLabel4 As gLabel.gLabel
    Friend WithEvents HEADER_lbl As gLabel.gLabel
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents GLabel5 As gLabel.gLabel
    Friend WithEvents P_Code_lbl As gLabel.gLabel
    Friend WithEvents btnBrowse As CButtonLib.CButton
    Friend WithEvents GLabel6 As gLabel.gLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As CButtonLib.CButton
    Friend WithEvents btnDelete As CButtonLib.CButton
    Friend WithEvents btnCancel As CButtonLib.CButton
End Class
