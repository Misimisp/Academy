<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResult))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CLOSE_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SEARCH_tb = New System.Windows.Forms.TextBox()
        Me.dgVIEW = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTS_lbl = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SUBJECT_cmb = New System.Windows.Forms.ComboBox()
        Me.GLabel4 = New gLabel.gLabel()
        Me.GLabel1 = New gLabel.gLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLOSE_btn
        '
        Me.CLOSE_btn.BackColor = System.Drawing.Color.White
        Me.CLOSE_btn.FlatAppearance.BorderSize = 0
        Me.CLOSE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLOSE_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSE_btn.Location = New System.Drawing.Point(542, 0)
        Me.CLOSE_btn.Name = "CLOSE_btn"
        Me.CLOSE_btn.Size = New System.Drawing.Size(53, 29)
        Me.CLOSE_btn.TabIndex = 6
        Me.CLOSE_btn.Text = "X"
        Me.CLOSE_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.SEARCH_tb)
        Me.Panel1.Location = New System.Drawing.Point(334, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 22)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(187, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SEARCH_tb
        '
        Me.SEARCH_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SEARCH_tb.ForeColor = System.Drawing.Color.Blue
        Me.SEARCH_tb.Location = New System.Drawing.Point(3, 4)
        Me.SEARCH_tb.Name = "SEARCH_tb"
        Me.SEARCH_tb.Size = New System.Drawing.Size(180, 11)
        Me.SEARCH_tb.TabIndex = 0
        '
        'dgVIEW
        '
        Me.dgVIEW.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVIEW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVIEW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVIEW.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgVIEW.EnableHeadersVisualStyles = False
        Me.dgVIEW.GridColor = System.Drawing.Color.White
        Me.dgVIEW.Location = New System.Drawing.Point(41, 144)
        Me.dgVIEW.Name = "dgVIEW"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVIEW.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgVIEW.RowHeadersVisible = False
        Me.dgVIEW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgVIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVIEW.Size = New System.Drawing.Size(515, 304)
        Me.dgVIEW.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
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
        Me.CONTACTS_lbl.Location = New System.Drawing.Point(127, 71)
        Me.CONTACTS_lbl.Name = "CONTACTS_lbl"
        Me.CONTACTS_lbl.Size = New System.Drawing.Size(340, 18)
        Me.CONTACTS_lbl.TabIndex = 8
        Me.CONTACTS_lbl.Text = "Contacts"
        Me.CONTACTS_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 452)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(594, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SUBJECT_cmb
        '
        Me.SUBJECT_cmb.BackColor = System.Drawing.Color.White
        Me.SUBJECT_cmb.FormattingEnabled = True
        Me.SUBJECT_cmb.Location = New System.Drawing.Point(41, 111)
        Me.SUBJECT_cmb.Name = "SUBJECT_cmb"
        Me.SUBJECT_cmb.Size = New System.Drawing.Size(244, 20)
        Me.SUBJECT_cmb.TabIndex = 0
        '
        'GLabel4
        '
        Me.GLabel4.BackColor = System.Drawing.Color.White
        Me.GLabel4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GLabel4.ForeColor = System.Drawing.Color.White
        Me.GLabel4.Glow = 20
        Me.GLabel4.GlowColor = System.Drawing.Color.DodgerBlue
        Me.GLabel4.Location = New System.Drawing.Point(198, 22)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(198, 41)
        Me.GLabel4.TabIndex = 12
        Me.GLabel4.Text = "SMPTech Acadamy"
        '
        'GLabel1
        '
        Me.GLabel1.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 12
        Me.GLabel1.GlowColor = System.Drawing.Color.Blue
        Me.GLabel1.Location = New System.Drawing.Point(38, 87)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(75, 21)
        Me.GLabel1.TabIndex = 13
        Me.GLabel1.Text = "Subject:"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(594, 474)
        Me.Controls.Add(Me.GLabel1)
        Me.Controls.Add(Me.SUBJECT_cmb)
        Me.Controls.Add(Me.GLabel4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgVIEW)
        Me.Controls.Add(Me.CONTACTS_lbl)
        Me.Controls.Add(Me.CLOSE_btn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResultBroadsheet"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CLOSE_btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SEARCH_tb As System.Windows.Forms.TextBox
    Friend WithEvents dgVIEW As System.Windows.Forms.DataGridView
    Friend WithEvents CONTACTS_lbl As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SUBJECT_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLabel4 As gLabel.gLabel
    Friend WithEvents GLabel1 As gLabel.gLabel
End Class
