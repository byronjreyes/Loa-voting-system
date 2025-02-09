<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartNewElection
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorPassword = New System.Windows.Forms.Label()
        Me.ErrorName = New System.Windows.Forms.Label()
        Me.ButtonCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonStart = New Guna.UI2.WinForms.Guna2Button()
        Me.TextPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2RadioButton1for7ammoring = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton3for6pmevening = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton2for12pmafternoon = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TextName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorPassword
        '
        Me.ErrorPassword.AutoSize = True
        Me.ErrorPassword.BackColor = System.Drawing.Color.Transparent
        Me.ErrorPassword.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorPassword.ForeColor = System.Drawing.Color.Red
        Me.ErrorPassword.Location = New System.Drawing.Point(38, 390)
        Me.ErrorPassword.Name = "ErrorPassword"
        Me.ErrorPassword.Size = New System.Drawing.Size(0, 13)
        Me.ErrorPassword.TabIndex = 34
        '
        'ErrorName
        '
        Me.ErrorName.AutoSize = True
        Me.ErrorName.BackColor = System.Drawing.Color.Transparent
        Me.ErrorName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ErrorName.ForeColor = System.Drawing.Color.Red
        Me.ErrorName.Location = New System.Drawing.Point(34, 137)
        Me.ErrorName.Name = "ErrorName"
        Me.ErrorName.Size = New System.Drawing.Size(0, 13)
        Me.ErrorName.TabIndex = 33
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Animated = True
        Me.ButtonCancel.BorderColor = System.Drawing.Color.LightGray
        Me.ButtonCancel.CheckedState.Parent = Me.ButtonCancel
        Me.ButtonCancel.CustomImages.Parent = Me.ButtonCancel
        Me.ButtonCancel.FillColor = System.Drawing.Color.White
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Gray
        Me.ButtonCancel.HoverState.Parent = Me.ButtonCancel
        Me.ButtonCancel.Location = New System.Drawing.Point(254, 444)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.ShadowDecoration.Parent = Me.ButtonCancel
        Me.ButtonCancel.Size = New System.Drawing.Size(106, 23)
        Me.ButtonCancel.TabIndex = 31
        Me.ButtonCancel.Text = "CANCEL"
        '
        'ButtonStart
        '
        Me.ButtonStart.Animated = True
        Me.ButtonStart.CheckedState.Parent = Me.ButtonStart
        Me.ButtonStart.CustomImages.Parent = Me.ButtonStart
        Me.ButtonStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonStart.ForeColor = System.Drawing.Color.White
        Me.ButtonStart.HoverState.Parent = Me.ButtonStart
        Me.ButtonStart.Location = New System.Drawing.Point(366, 434)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.ShadowDecoration.Parent = Me.ButtonStart
        Me.ButtonStart.Size = New System.Drawing.Size(118, 37)
        Me.ButtonStart.TabIndex = 32
        Me.ButtonStart.Text = "START ELECTION"
        '
        'TextPassword
        '
        Me.TextPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextPassword.DefaultText = ""
        Me.TextPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPassword.DisabledState.Parent = Me.TextPassword
        Me.TextPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextPassword.FocusedState.Parent = Me.TextPassword
        Me.TextPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextPassword.HoverState.Parent = Me.TextPassword
        Me.TextPassword.Location = New System.Drawing.Point(38, 344)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextPassword.PlaceholderText = "For Security Reason"
        Me.TextPassword.SelectedText = ""
        Me.TextPassword.ShadowDecoration.Parent = Me.TextPassword
        Me.TextPassword.Size = New System.Drawing.Size(446, 54)
        Me.TextPassword.TabIndex = 30
        Me.TextPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Guna2RadioButton1for7ammoring)
        Me.Panel2.Controls.Add(Me.Guna2RadioButton3for6pmevening)
        Me.Panel2.Controls.Add(Me.Guna2RadioButton2for12pmafternoon)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(38, 225)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 79)
        Me.Panel2.TabIndex = 28
        '
        'Guna2RadioButton1for7ammoring
        '
        Me.Guna2RadioButton1for7ammoring.AutoSize = True
        Me.Guna2RadioButton1for7ammoring.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1for7ammoring.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1for7ammoring.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1for7ammoring.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1for7ammoring.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1for7ammoring.Location = New System.Drawing.Point(3, 3)
        Me.Guna2RadioButton1for7ammoring.Name = "Guna2RadioButton1for7ammoring"
        Me.Guna2RadioButton1for7ammoring.Size = New System.Drawing.Size(116, 17)
        Me.Guna2RadioButton1for7ammoring.TabIndex = 6
        Me.Guna2RadioButton1for7ammoring.Text = "07:00 am (Morning)"
        Me.Guna2RadioButton1for7ammoring.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1for7ammoring.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1for7ammoring.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1for7ammoring.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1for7ammoring.UseVisualStyleBackColor = True
        '
        'Guna2RadioButton3for6pmevening
        '
        Me.Guna2RadioButton3for6pmevening.AutoSize = True
        Me.Guna2RadioButton3for6pmevening.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3for6pmevening.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton3for6pmevening.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3for6pmevening.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton3for6pmevening.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton3for6pmevening.Location = New System.Drawing.Point(3, 51)
        Me.Guna2RadioButton3for6pmevening.Name = "Guna2RadioButton3for6pmevening"
        Me.Guna2RadioButton3for6pmevening.Size = New System.Drawing.Size(117, 17)
        Me.Guna2RadioButton3for6pmevening.TabIndex = 6
        Me.Guna2RadioButton3for6pmevening.Text = "06:00 pm (Evening)"
        Me.Guna2RadioButton3for6pmevening.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton3for6pmevening.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton3for6pmevening.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3for6pmevening.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3for6pmevening.UseVisualStyleBackColor = True
        '
        'Guna2RadioButton2for12pmafternoon
        '
        Me.Guna2RadioButton2for12pmafternoon.AutoSize = True
        Me.Guna2RadioButton2for12pmafternoon.Checked = True
        Me.Guna2RadioButton2for12pmafternoon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2for12pmafternoon.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2for12pmafternoon.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2for12pmafternoon.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2for12pmafternoon.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2for12pmafternoon.Location = New System.Drawing.Point(3, 27)
        Me.Guna2RadioButton2for12pmafternoon.Name = "Guna2RadioButton2for12pmafternoon"
        Me.Guna2RadioButton2for12pmafternoon.Size = New System.Drawing.Size(124, 17)
        Me.Guna2RadioButton2for12pmafternoon.TabIndex = 6
        Me.Guna2RadioButton2for12pmafternoon.TabStop = True
        Me.Guna2RadioButton2for12pmafternoon.Text = "12:00 pm (Afternoon)"
        Me.Guna2RadioButton2for12pmafternoon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2for12pmafternoon.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2for12pmafternoon.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2for12pmafternoon.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2for12pmafternoon.UseVisualStyleBackColor = True
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2DateTimePicker1.BorderThickness = 1
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(38, 182)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(446, 37)
        Me.Guna2DateTimePicker1.TabIndex = 27
        Me.Guna2DateTimePicker1.Value = New Date(2020, 12, 4, 13, 44, 45, 554)
        '
        'TextName
        '
        Me.TextName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextName.DefaultText = ""
        Me.TextName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextName.DisabledState.Parent = Me.TextName
        Me.TextName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextName.FocusedState.Parent = Me.TextName
        Me.TextName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextName.HoverState.Parent = Me.TextName
        Me.TextName.Location = New System.Drawing.Point(38, 100)
        Me.TextName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextName.Name = "TextName"
        Me.TextName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextName.PlaceholderText = ""
        Me.TextName.SelectedText = ""
        Me.TextName.ShadowDecoration.Parent = Me.TextName
        Me.TextName.Size = New System.Drawing.Size(446, 50)
        Me.TextName.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(34, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "End Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(110, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Note: You Can not manually Stop the Election"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Election Name"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(518, 66)
        Me.Guna2GradientPanel1.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 56)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Create Election"
        '
        'StartNewElection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 586)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.ErrorPassword)
        Me.Controls.Add(Me.ErrorName)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartNewElection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartNewElection"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ErrorPassword As Label
    Friend WithEvents ErrorName As Label
    Friend WithEvents ButtonCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2RadioButton1for7ammoring As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton3for6pmevening As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2for12pmafternoon As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TextName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label5 As Label
End Class
