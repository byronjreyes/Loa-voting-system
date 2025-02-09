<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exitpassword
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
        Me.btnsubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ButtonDiscard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        Me.btnsubmit.Animated = True
        Me.btnsubmit.CheckedState.Parent = Me.btnsubmit
        Me.btnsubmit.CustomImages.Parent = Me.btnsubmit
        Me.btnsubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnsubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnsubmit.ForeColor = System.Drawing.Color.White
        Me.btnsubmit.HoverState.Parent = Me.btnsubmit
        Me.btnsubmit.Location = New System.Drawing.Point(188, 149)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.ShadowDecoration.Parent = Me.btnsubmit
        Me.btnsubmit.Size = New System.Drawing.Size(132, 37)
        Me.btnsubmit.TabIndex = 53
        Me.btnsubmit.Text = "Confirm"
        '
        'txtpassword
        '
        Me.txtpassword.BorderRadius = 5
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.Parent = Me.txtpassword
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedState.Parent = Me.txtpassword
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.HoverState.Parent = Me.txtpassword
        Me.txtpassword.Location = New System.Drawing.Point(42, 72)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.PlaceholderText = ""
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.Parent = Me.txtpassword
        Me.txtpassword.Size = New System.Drawing.Size(278, 32)
        Me.txtpassword.TabIndex = 54
        '
        'ButtonDiscard
        '
        Me.ButtonDiscard.Animated = True
        Me.ButtonDiscard.CheckedState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.CustomImages.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.FillColor = System.Drawing.SystemColors.Control
        Me.ButtonDiscard.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonDiscard.ForeColor = System.Drawing.Color.Gray
        Me.ButtonDiscard.HoverState.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Location = New System.Drawing.Point(42, 149)
        Me.ButtonDiscard.Name = "ButtonDiscard"
        Me.ButtonDiscard.ShadowDecoration.Parent = Me.ButtonDiscard
        Me.ButtonDiscard.Size = New System.Drawing.Size(125, 37)
        Me.ButtonDiscard.TabIndex = 55
        Me.ButtonDiscard.Text = "Discard"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(42, 19)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(147, 27)
        Me.Guna2HtmlLabel2.TabIndex = 56
        Me.Guna2HtmlLabel2.Text = "Enter a password"
        '
        'exitpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 228)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.ButtonDiscard)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "exitpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "exitpassword"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ButtonDiscard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
