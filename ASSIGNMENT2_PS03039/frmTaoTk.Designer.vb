<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtaotk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtaotk))
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpwdagain = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncheck = New System.Windows.Forms.Button()
        Me.lbltk = New System.Windows.Forms.Label()
        Me.pbcheckx = New System.Windows.Forms.PictureBox()
        Me.pbpwd = New System.Windows.Forms.PictureBox()
        Me.pbemail = New System.Windows.Forms.PictureBox()
        CType(Me.pbcheckx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbpwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbemail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncreate
        '
        Me.btncreate.Location = New System.Drawing.Point(129, 192)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(91, 41)
        Me.btncreate.TabIndex = 6
        Me.btncreate.Text = "Tạo tạo khoản"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(227, 192)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(91, 41)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Hủy"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(129, 36)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(187, 22)
        Me.txtuser.TabIndex = 1
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(129, 64)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(187, 22)
        Me.txtpwd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tài khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(14, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(14, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nhập lại mật khẩu"
        '
        'txtpwdagain
        '
        Me.txtpwdagain.Location = New System.Drawing.Point(129, 92)
        Me.txtpwdagain.Name = "txtpwdagain"
        Me.txtpwdagain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwdagain.Size = New System.Drawing.Size(187, 22)
        Me.txtpwdagain.TabIndex = 3
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(129, 120)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(187, 22)
        Me.txtemail.TabIndex = 4
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(129, 8)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(187, 22)
        Me.txtten.TabIndex = 0
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(129, 148)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(187, 22)
        Me.txtsdt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(14, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(14, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Họ và Tên"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(14, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "SĐT"
        '
        'btncheck
        '
        Me.btncheck.Location = New System.Drawing.Point(320, 33)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(68, 24)
        Me.btncheck.TabIndex = 15
        Me.btncheck.Text = "Check"
        Me.btncheck.UseVisualStyleBackColor = True
        '
        'lbltk
        '
        Me.lbltk.AutoSize = True
        Me.lbltk.BackColor = System.Drawing.Color.Transparent
        Me.lbltk.ForeColor = System.Drawing.Color.Transparent
        Me.lbltk.Location = New System.Drawing.Point(128, 62)
        Me.lbltk.Name = "lbltk"
        Me.lbltk.Size = New System.Drawing.Size(0, 14)
        Me.lbltk.TabIndex = 16
        '
        'pbcheckx
        '
        Me.pbcheckx.BackColor = System.Drawing.Color.Transparent
        Me.pbcheckx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbcheckx.Location = New System.Drawing.Point(320, 36)
        Me.pbcheckx.Name = "pbcheckx"
        Me.pbcheckx.Size = New System.Drawing.Size(23, 22)
        Me.pbcheckx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcheckx.TabIndex = 17
        Me.pbcheckx.TabStop = False
        Me.pbcheckx.Visible = False
        '
        'pbpwd
        '
        Me.pbpwd.BackColor = System.Drawing.Color.Transparent
        Me.pbpwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbpwd.Location = New System.Drawing.Point(320, 92)
        Me.pbpwd.Name = "pbpwd"
        Me.pbpwd.Size = New System.Drawing.Size(23, 22)
        Me.pbpwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbpwd.TabIndex = 18
        Me.pbpwd.TabStop = False
        Me.pbpwd.Visible = False
        '
        'pbemail
        '
        Me.pbemail.BackColor = System.Drawing.Color.Transparent
        Me.pbemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbemail.Location = New System.Drawing.Point(320, 120)
        Me.pbemail.Name = "pbemail"
        Me.pbemail.Size = New System.Drawing.Size(23, 22)
        Me.pbemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbemail.TabIndex = 19
        Me.pbemail.TabStop = False
        Me.pbemail.Visible = False
        '
        'frmtaotk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.ASSIGNMENT2_PS03039.My.Resources.Resources.graphite_gradient_2_by_msketchley_d3hxab0
        Me.ClientSize = New System.Drawing.Size(425, 262)
        Me.Controls.Add(Me.pbemail)
        Me.Controls.Add(Me.pbpwd)
        Me.Controls.Add(Me.pbcheckx)
        Me.Controls.Add(Me.lbltk)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpwdagain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btncreate)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmtaotk"
        Me.Text = "Đăng ký tài khoản"
        CType(Me.pbcheckx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbpwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbemail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpwdagain As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncheck As System.Windows.Forms.Button
    Friend WithEvents lbltk As System.Windows.Forms.Label
    Friend WithEvents pbcheckx As System.Windows.Forms.PictureBox
    Friend WithEvents pbpwd As System.Windows.Forms.PictureBox
    Friend WithEvents pbemail As System.Windows.Forms.PictureBox
End Class
