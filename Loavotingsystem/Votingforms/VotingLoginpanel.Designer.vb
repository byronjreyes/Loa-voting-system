<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingLoginpanel
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PanelUsernameStatus = New System.Windows.Forms.Panel()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelPasswordStatus = New System.Windows.Forms.Panel()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValidationErrors = New System.Windows.Forms.Label()
        Me.btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblnote = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 21
        '
        'PanelUsernameStatus
        '
        Me.PanelUsernameStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelUsernameStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsernameStatus.Name = "PanelUsernameStatus"
        Me.PanelUsernameStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelUsernameStatus.TabIndex = 1
        '
        'txtusername
        '
        Me.txtusername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(46, 13)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(376, 20)
        Me.txtusername.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtusername, "Enter your Username here")
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PanelUsernameStatus)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(396, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 45)
        Me.Panel2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Panel2, "Enter your Username here")
        '
        'PanelPasswordStatus
        '
        Me.PanelPasswordStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPasswordStatus.Location = New System.Drawing.Point(0, 0)
        Me.PanelPasswordStatus.Name = "PanelPasswordStatus"
        Me.PanelPasswordStatus.Size = New System.Drawing.Size(5, 45)
        Me.PanelPasswordStatus.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(46, 13)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(347, 20)
        Me.txtpassword.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtpassword, "Enter your Password here")
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(514, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Voter's Login"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Guna2Button1)
        Me.Panel3.Controls.Add(Me.PanelPasswordStatus)
        Me.Panel3.Controls.Add(Me.txtpassword)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(396, 256)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 45)
        Me.Panel3.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Panel3, "Enter your Password here")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 555)
        Me.Panel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(32, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Supreme Student Council"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(113, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Voting system"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(172, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "to"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(136, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValidationErrors
        '
        Me.lblValidationErrors.AutoSize = True
        Me.lblValidationErrors.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidationErrors.ForeColor = System.Drawing.Color.Red
        Me.lblValidationErrors.Location = New System.Drawing.Point(407, 304)
        Me.lblValidationErrors.Name = "lblValidationErrors"
        Me.lblValidationErrors.Size = New System.Drawing.Size(0, 23)
        Me.lblValidationErrors.TabIndex = 14
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogin.Animated = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderRadius = 21
        Me.btnlogin.CheckedState.Parent = Me.btnlogin
        Me.btnlogin.CustomImages.Parent = Me.btnlogin
        Me.btnlogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnlogin.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.HoverState.Parent = Me.btnlogin
        Me.btnlogin.Location = New System.Drawing.Point(396, 357)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.ShadowDecoration.Parent = Me.btnlogin
        Me.btnlogin.Size = New System.Drawing.Size(441, 43)
        Me.btnlogin.TabIndex = 13
        Me.btnlogin.Text = "LOGIN"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblnote)
        Me.Panel4.Controls.Add(Me.lblValidationErrors)
        Me.Panel4.Controls.Add(Me.btnlogin)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(870, 555)
        Me.Panel4.TabIndex = 15
        '
        'lblnote
        '
        Me.lblnote.AutoSize = True
        Me.lblnote.BackColor = System.Drawing.Color.Transparent
        Me.lblnote.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnote.ForeColor = System.Drawing.Color.Red
        Me.lblnote.Location = New System.Drawing.Point(391, 410)
        Me.lblnote.Name = "lblnote"
        Me.lblnote.Size = New System.Drawing.Size(0, 26)
        Me.lblnote.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Loavotingsystem.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(836, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Loavotingsystem.My.Resources.Resources.loalogo
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(107, 37)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(164, 163)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 17
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.Loavotingsystem.My.Resources.Resources.show
        Me.Guna2Button1.Location = New System.Drawing.Point(399, 11)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(25, 25)
        Me.Guna2Button1.TabIndex = 13
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Loavotingsystem.My.Resources.Resources.padlock
        Me.PictureBox3.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Loavotingsystem.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(15, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'VotingLoginpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 555)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VotingLoginpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VotingLoginpanel"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelUsernameStatus As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelPasswordStatus As Panel
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValidationErrors As Label
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblnote As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
