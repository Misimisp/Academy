<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadsheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBroadsheet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.YEAR_cmb = New System.Windows.Forms.ComboBox()
        Me.CLASS_cmb = New System.Windows.Forms.ComboBox()
        Me.SUBJECT_cmb = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CButton1 = New CButtonLib.CButton()
        Me.SEARCH_tb = New System.Windows.Forms.TextBox()
        Me.dgVIEW = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTS_lbl = New System.Windows.Forms.Label()
        Me.CLOSE_btn = New System.Windows.Forms.Button()
        Me.MSG_lbl = New System.Windows.Forms.Label()
        Me.btnOk = New CButtonLib.CButton()
        Me.GLabel4 = New gLabel.gLabel()
        Me.GLabel1 = New gLabel.gLabel()
        Me.GLabel2 = New gLabel.gLabel()
        Me.GLabel3 = New gLabel.gLabel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GLabel3)
        Me.GroupBox1.Controls.Add(Me.GLabel2)
        Me.GroupBox1.Controls.Add(Me.GLabel1)
        Me.GroupBox1.Controls.Add(Me.YEAR_cmb)
        Me.GroupBox1.Controls.Add(Me.CLASS_cmb)
        Me.GroupBox1.Controls.Add(Me.SUBJECT_cmb)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(39, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 67)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Broadsheet details"
        '
        'YEAR_cmb
        '
        Me.YEAR_cmb.BackColor = System.Drawing.Color.White
        Me.YEAR_cmb.ForeColor = System.Drawing.Color.Blue
        Me.YEAR_cmb.FormattingEnabled = True
        Me.YEAR_cmb.Location = New System.Drawing.Point(311, 38)
        Me.YEAR_cmb.Name = "YEAR_cmb"
        Me.YEAR_cmb.Size = New System.Drawing.Size(85, 20)
        Me.YEAR_cmb.TabIndex = 0
        '
        'CLASS_cmb
        '
        Me.CLASS_cmb.BackColor = System.Drawing.Color.White
        Me.CLASS_cmb.ForeColor = System.Drawing.Color.Blue
        Me.CLASS_cmb.FormattingEnabled = True
        Me.CLASS_cmb.Location = New System.Drawing.Point(220, 38)
        Me.CLASS_cmb.Name = "CLASS_cmb"
        Me.CLASS_cmb.Size = New System.Drawing.Size(85, 20)
        Me.CLASS_cmb.TabIndex = 0
        '
        'SUBJECT_cmb
        '
        Me.SUBJECT_cmb.BackColor = System.Drawing.Color.White
        Me.SUBJECT_cmb.ForeColor = System.Drawing.Color.Blue
        Me.SUBJECT_cmb.FormattingEnabled = True
        Me.SUBJECT_cmb.Location = New System.Drawing.Point(15, 38)
        Me.SUBJECT_cmb.Name = "SUBJECT_cmb"
        Me.SUBJECT_cmb.Size = New System.Drawing.Size(199, 20)
        Me.SUBJECT_cmb.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CButton1)
        Me.Panel1.Controls.Add(Me.SEARCH_tb)
        Me.Panel1.Location = New System.Drawing.Point(41, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 22)
        Me.Panel1.TabIndex = 17
        '
        'CButton1
        '
        Me.CButton1.BorderColor = System.Drawing.Color.Gray
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.CButton1.ColorFillBlend = CBlendItems1
        Me.CButton1.ColorFillSolid = System.Drawing.Color.White
        Me.CButton1.DesignerSelected = False
        Me.CButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.CButton1.Image = CType(resources.GetObject("CButton1.Image"), System.Drawing.Image)
        Me.CButton1.ImageIndex = 0
        Me.CButton1.Location = New System.Drawing.Point(288, 0)
        Me.CButton1.Name = "CButton1"
        Me.CButton1.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CButton1.Size = New System.Drawing.Size(26, 18)
        Me.CButton1.TabIndex = 25
        Me.CButton1.Text = ""
        Me.CButton1.TextShadow = System.Drawing.Color.White
        '
        'SEARCH_tb
        '
        Me.SEARCH_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SEARCH_tb.ForeColor = System.Drawing.Color.Blue
        Me.SEARCH_tb.Location = New System.Drawing.Point(3, 4)
        Me.SEARCH_tb.Name = "SEARCH_tb"
        Me.SEARCH_tb.Size = New System.Drawing.Size(279, 11)
        Me.SEARCH_tb.TabIndex = 0
        '
        'dgVIEW
        '
        Me.dgVIEW.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVIEW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVIEW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVIEW.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgVIEW.EnableHeadersVisualStyles = False
        Me.dgVIEW.GridColor = System.Drawing.Color.White
        Me.dgVIEW.Location = New System.Drawing.Point(41, 228)
        Me.dgVIEW.Name = "dgVIEW"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVIEW.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgVIEW.RowHeadersVisible = False
        Me.dgVIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVIEW.Size = New System.Drawing.Size(512, 221)
        Me.dgVIEW.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "S/N"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Matric No"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Score"
        Me.Column4.Name = "Column4"
        '
        'CONTACTS_lbl
        '
        Me.CONTACTS_lbl.ForeColor = System.Drawing.Color.Blue
        Me.CONTACTS_lbl.Location = New System.Drawing.Point(127, 62)
        Me.CONTACTS_lbl.Name = "CONTACTS_lbl"
        Me.CONTACTS_lbl.Size = New System.Drawing.Size(340, 12)
        Me.CONTACTS_lbl.TabIndex = 15
        Me.CONTACTS_lbl.Text = "Contacts"
        Me.CONTACTS_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CLOSE_btn
        '
        Me.CLOSE_btn.BackColor = System.Drawing.Color.White
        Me.CLOSE_btn.FlatAppearance.BorderSize = 0
        Me.CLOSE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLOSE_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSE_btn.Location = New System.Drawing.Point(543, 0)
        Me.CLOSE_btn.Name = "CLOSE_btn"
        Me.CLOSE_btn.Size = New System.Drawing.Size(53, 29)
        Me.CLOSE_btn.TabIndex = 13
        Me.CLOSE_btn.Text = "X"
        Me.CLOSE_btn.UseVisualStyleBackColor = False
        '
        'MSG_lbl
        '
        Me.MSG_lbl.BackColor = System.Drawing.Color.White
        Me.MSG_lbl.ForeColor = System.Drawing.Color.Blue
        Me.MSG_lbl.Location = New System.Drawing.Point(89, 81)
        Me.MSG_lbl.Name = "MSG_lbl"
        Me.MSG_lbl.Size = New System.Drawing.Size(417, 21)
        Me.MSG_lbl.TabIndex = 22
        Me.MSG_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.AliceBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.Cyan}
        CBlendItems2.iPoint = New Single() {0.0!, 0.257764!, 1.0!}
        Me.btnOk.ColorFillBlend = CBlendItems2
        Me.btnOk.DesignerSelected = False
        Me.btnOk.FillType = CButtonLib.CButton.eFillType.GradientPath
        Me.btnOk.ImageIndex = 0
        Me.btnOk.Location = New System.Drawing.Point(454, 125)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(99, 62)
        Me.btnOk.TabIndex = 24
        Me.btnOk.Text = "Broadsheet"
        '
        'GLabel4
        '
        Me.GLabel4.BackColor = System.Drawing.Color.White
        Me.GLabel4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel4.ForeColor = System.Drawing.Color.White
        Me.GLabel4.Glow = 20
        Me.GLabel4.GlowColor = System.Drawing.Color.DodgerBlue
        Me.GLabel4.Location = New System.Drawing.Point(198, 14)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(198, 41)
        Me.GLabel4.TabIndex = 25
        Me.GLabel4.Text = "SMPTech Acadamy"
        '
        'GLabel1
        '
        Me.GLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 12
        Me.GLabel1.GlowColor = System.Drawing.Color.Blue
        Me.GLabel1.Location = New System.Drawing.Point(12, 16)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(60, 21)
        Me.GLabel1.TabIndex = 24
        Me.GLabel1.Text = "Subject:"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLabel2
        '
        Me.GLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 12
        Me.GLabel2.GlowColor = System.Drawing.Color.Blue
        Me.GLabel2.Location = New System.Drawing.Point(217, 14)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(52, 21)
        Me.GLabel2.TabIndex = 25
        Me.GLabel2.Text = "Class:"
        Me.GLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GLabel3
        '
        Me.GLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GLabel3.ForeColor = System.Drawing.Color.White
        Me.GLabel3.Glow = 12
        Me.GLabel3.GlowColor = System.Drawing.Color.Blue
        Me.GLabel3.Location = New System.Drawing.Point(308, 14)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(59, 21)
        Me.GLabel3.TabIndex = 26
        Me.GLabel3.Text = "Year:"
        Me.GLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBroadsheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 474)
        Me.Controls.Add(Me.GLabel4)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.MSG_lbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgVIEW)
        Me.Controls.Add(Me.CONTACTS_lbl)
        Me.Controls.Add(Me.CLOSE_btn)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBroadsheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBroadsheet"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SUBJECT_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SEARCH_tb As System.Windows.Forms.TextBox
    Friend WithEvents dgVIEW As System.Windows.Forms.DataGridView
    Friend WithEvents CONTACTS_lbl As System.Windows.Forms.Label
    Friend WithEvents CLOSE_btn As System.Windows.Forms.Button
    Friend WithEvents YEAR_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents CLASS_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents MSG_lbl As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOk As CButtonLib.CButton
    Friend WithEvents CButton1 As CButtonLib.CButton
    Friend WithEvents GLabel4 As gLabel.gLabel
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents GLabel1 As gLabel.gLabel
End Class
