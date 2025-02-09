<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrepass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtnewpass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtcurrent = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtusername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.lblRePassValidation = New System.Windows.Forms.Label()
        Me.lblNewPassValidation = New System.Windows.Forms.Label()
        Me.lblCurrentPassValidation = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 21
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-20, 50)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(366, 47)
        Me.Guna2CustomGradientPanel1.TabIndex = 108
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 37)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Manage Account"
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.Color.Transparent
        Me.ButtonDiscard.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.FillColor = System.Drawing.Color.Silver
        Me.ButtonDiscard.HoverState.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscard.HoverState.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(256, 490)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(169, 38)
        Me.ButtonDiscard.TabIndex = 107
        Me.ButtonDiscard.Text = "Discard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(164, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 23)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Retype-Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(164, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "New Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(164, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 23)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Current Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(164, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Username:"
        '
        'txtrepass
        '
        Me.txtrepass.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtrepass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrepass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtrepass.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepass.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtrepass.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtrepass.LineSize = 2
        Me.txtrepass.Location = New System.Drawing.Point(168, 366)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrepass.SelectedText = ""
        Me.txtrepass.Size = New System.Drawing.Size(344, 30)
        Me.txtrepass.TabIndex = 99
        Me.txtrepass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnewpass
        '
        Me.txtnewpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnewpass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtnewpass.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpass.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtnewpass.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtnewpass.LineSize = 2
        Me.txtnewpass.Location = New System.Drawing.Point(168, 287)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnewpass.SelectedText = ""
        Me.txtnewpass.Size = New System.Drawing.Size(344, 30)
        Me.txtnewpass.TabIndex = 100
        Me.txtnewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcurrent
        '
        Me.txtcurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtcurrent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrent.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtcurrent.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrent.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtcurrent.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtcurrent.LineSize = 2
        Me.txtcurrent.Location = New System.Drawing.Point(168, 208)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcurrent.SelectedText = ""
        Me.txtcurrent.Size = New System.Drawing.Size(344, 30)
        Me.txtcurrent.TabIndex = 101
        Me.txtcurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtusername.LineColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.LineSize = 2
        Me.txtusername.Location = New System.Drawing.Point(168, 129)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(344, 30)
        Me.txtusername.TabIndex = 102
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnLogin.BorderSize = 2
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Transparent
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(227, 438)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogin.OnPressedDepth = 25
        Me.btnLogin.Radius = 21
        Me.btnLogin.Size = New System.Drawing.Size(226, 46)
        Me.btnLogin.TabIndex = 98
        Me.btnLogin.Text = "Update"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRePassValidation
        '
        Me.lblRePassValidation.AutoSize = True
        Me.lblRePassValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRePassValidation.ForeColor = System.Drawing.Color.Red
        Me.lblRePassValidation.Location = New System.Drawing.Point(164, 399)
        Me.lblRePassValidation.Name = "lblRePassValidation"
        Me.lblRePassValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblRePassValidation.TabIndex = 109
        '
        'lblNewPassValidation
        '
        Me.lblNewPassValidation.AutoSize = True
        Me.lblNewPassValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassValidation.ForeColor = System.Drawing.Color.Red
        Me.lblNewPassValidation.Location = New System.Drawing.Point(164, 320)
        Me.lblNewPassValidation.Name = "lblNewPassValidation"
        Me.lblNewPassValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblNewPassValidation.TabIndex = 110
        '
        'lblCurrentPassValidation
        '
        Me.lblCurrentPassValidation.AutoSize = True
        Me.lblCurrentPassValidation.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassValidation.ForeColor = System.Drawing.Color.Red
        Me.lblCurrentPassValidation.Location = New System.Drawing.Point(164, 241)
        Me.lblCurrentPassValidation.Name = "lblCurrentPassValidation"
        Me.lblCurrentPassValidation.Size = New System.Drawing.Size(0, 23)
        Me.lblCurrentPassValidation.TabIndex = 111
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 543)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrepass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.txtcurrent)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblRePassValidation)
        Me.Controls.Add(Me.lblNewPassValidation)
        Me.Controls.Add(Me.lblCurrentPassValidation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changepass"
        Me.TopMost = True
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrepass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtnewpass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtcurrent As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblRePassValidation As Label
    Friend WithEvents lblNewPassValidation As Label
    Friend WithEvents lblCurrentPassValidation As Label
End Class
