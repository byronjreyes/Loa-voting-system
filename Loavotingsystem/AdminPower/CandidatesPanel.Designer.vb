<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CandidatesPanel
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonEVPresident = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVFinance = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVActivities = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVComMarketing = New Guna.UI2.WinForms.Guna2Button()
        Me.ButtonVDocumentation = New Guna.UI2.WinForms.Guna2Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnAddCandidates = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panelhider = New System.Windows.Forms.Panel()
        Me.candihider = New System.Windows.Forms.Label()
        Me.btnclose = New Guna.UI2.WinForms.Guna2Button()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.Panelhider.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonPresident)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonEVPresident)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVFinance)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVActivities)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVComMarketing)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonVDocumentation)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(64, 129)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(885, 28)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'ButtonPresident
        '
        Me.ButtonPresident.Animated = True
        Me.ButtonPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonPresident.CheckedState.Parent = Me.ButtonPresident
        Me.ButtonPresident.CustomImages.Parent = Me.ButtonPresident
        Me.ButtonPresident.FillColor = System.Drawing.Color.White
        Me.ButtonPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonPresident.HoverState.Parent = Me.ButtonPresident
        Me.ButtonPresident.Location = New System.Drawing.Point(0, 0)
        Me.ButtonPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPresident.Name = "ButtonPresident"
        Me.ButtonPresident.ShadowDecoration.Parent = Me.ButtonPresident
        Me.ButtonPresident.Size = New System.Drawing.Size(102, 28)
        Me.ButtonPresident.TabIndex = 0
        Me.ButtonPresident.Tag = "1"
        Me.ButtonPresident.Text = "PRESIDENT "
        '
        'ButtonEVPresident
        '
        Me.ButtonEVPresident.Animated = True
        Me.ButtonEVPresident.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonEVPresident.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonEVPresident.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonEVPresident.CheckedState.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.CustomImages.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.FillColor = System.Drawing.Color.White
        Me.ButtonEVPresident.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonEVPresident.ForeColor = System.Drawing.Color.Black
        Me.ButtonEVPresident.HoverState.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.Location = New System.Drawing.Point(102, 0)
        Me.ButtonEVPresident.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonEVPresident.Name = "ButtonEVPresident"
        Me.ButtonEVPresident.ShadowDecoration.Parent = Me.ButtonEVPresident
        Me.ButtonEVPresident.Size = New System.Drawing.Size(157, 28)
        Me.ButtonEVPresident.TabIndex = 0
        Me.ButtonEVPresident.Tag = "2"
        Me.ButtonEVPresident.Text = "EXECUTIVE VICE PRESIDENT "
        '
        'ButtonVFinance
        '
        Me.ButtonVFinance.Animated = True
        Me.ButtonVFinance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVFinance.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVFinance.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVFinance.CheckedState.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.CustomImages.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.FillColor = System.Drawing.Color.White
        Me.ButtonVFinance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVFinance.ForeColor = System.Drawing.Color.Black
        Me.ButtonVFinance.HoverState.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.Location = New System.Drawing.Point(259, 0)
        Me.ButtonVFinance.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVFinance.Name = "ButtonVFinance"
        Me.ButtonVFinance.ShadowDecoration.Parent = Me.ButtonVFinance
        Me.ButtonVFinance.Size = New System.Drawing.Size(102, 28)
        Me.ButtonVFinance.TabIndex = 0
        Me.ButtonVFinance.Tag = "3"
        Me.ButtonVFinance.Text = "VP FINANCE"
        '
        'ButtonVActivities
        '
        Me.ButtonVActivities.Animated = True
        Me.ButtonVActivities.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVActivities.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVActivities.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVActivities.CheckedState.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.CustomImages.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.FillColor = System.Drawing.Color.White
        Me.ButtonVActivities.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVActivities.ForeColor = System.Drawing.Color.Black
        Me.ButtonVActivities.HoverState.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.Location = New System.Drawing.Point(361, 0)
        Me.ButtonVActivities.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVActivities.Name = "ButtonVActivities"
        Me.ButtonVActivities.ShadowDecoration.Parent = Me.ButtonVActivities
        Me.ButtonVActivities.Size = New System.Drawing.Size(102, 28)
        Me.ButtonVActivities.TabIndex = 0
        Me.ButtonVActivities.Tag = "4"
        Me.ButtonVActivities.Text = "VP ACTIVITIES"
        '
        'ButtonVComMarketing
        '
        Me.ButtonVComMarketing.Animated = True
        Me.ButtonVComMarketing.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVComMarketing.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVComMarketing.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVComMarketing.CheckedState.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.CustomImages.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.FillColor = System.Drawing.Color.White
        Me.ButtonVComMarketing.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVComMarketing.ForeColor = System.Drawing.Color.Black
        Me.ButtonVComMarketing.HoverState.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.Location = New System.Drawing.Point(463, 0)
        Me.ButtonVComMarketing.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVComMarketing.Name = "ButtonVComMarketing"
        Me.ButtonVComMarketing.ShadowDecoration.Parent = Me.ButtonVComMarketing
        Me.ButtonVComMarketing.Size = New System.Drawing.Size(233, 28)
        Me.ButtonVComMarketing.TabIndex = 0
        Me.ButtonVComMarketing.Tag = "5"
        Me.ButtonVComMarketing.Text = "VP COMMUNICATION AND MARKETING "
        '
        'ButtonVDocumentation
        '
        Me.ButtonVDocumentation.Animated = True
        Me.ButtonVDocumentation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ButtonVDocumentation.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonVDocumentation.CheckedState.ForeColor = System.Drawing.Color.White
        Me.ButtonVDocumentation.CheckedState.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.CustomImages.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.FillColor = System.Drawing.Color.White
        Me.ButtonVDocumentation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonVDocumentation.ForeColor = System.Drawing.Color.Black
        Me.ButtonVDocumentation.HoverState.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.Location = New System.Drawing.Point(696, 0)
        Me.ButtonVDocumentation.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonVDocumentation.Name = "ButtonVDocumentation"
        Me.ButtonVDocumentation.ShadowDecoration.Parent = Me.ButtonVDocumentation
        Me.ButtonVDocumentation.Size = New System.Drawing.Size(176, 28)
        Me.ButtonVDocumentation.TabIndex = 0
        Me.ButtonVDocumentation.Tag = "6"
        Me.ButtonVDocumentation.Text = "VP DOCUMENTATION"
        '
        'btnAddCandidates
        '
        Me.btnAddCandidates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCandidates.CheckedState.Parent = Me.btnAddCandidates
        Me.btnAddCandidates.CustomImages.Parent = Me.btnAddCandidates
        Me.btnAddCandidates.FillColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAddCandidates.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAddCandidates.ForeColor = System.Drawing.Color.White
        Me.btnAddCandidates.HoverState.Parent = Me.btnAddCandidates
        Me.btnAddCandidates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddCandidates.ImageOffset = New System.Drawing.Point(1, 1)
        Me.btnAddCandidates.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnAddCandidates.Location = New System.Drawing.Point(332, 252)
        Me.btnAddCandidates.Name = "btnAddCandidates"
        Me.btnAddCandidates.ShadowDecoration.Parent = Me.btnAddCandidates
        Me.btnAddCandidates.Size = New System.Drawing.Size(219, 38)
        Me.btnAddCandidates.TabIndex = 6
        Me.btnAddCandidates.Text = "Add Candidate"
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel3.BorderRadius = 21
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.Gainsboro
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(-20, 50)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(366, 47)
        Me.Guna2CustomGradientPanel3.TabIndex = 105
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 37)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Candidate's Information"
        '
        'flpMain
        '
        Me.flpMain.AutoScroll = True
        Me.flpMain.BackColor = System.Drawing.Color.Transparent
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpMain.Location = New System.Drawing.Point(123, 180)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.flpMain.Size = New System.Drawing.Size(760, 414)
        Me.flpMain.TabIndex = 106
        '
        'Panelhider
        '
        Me.Panelhider.Controls.Add(Me.candihider)
        Me.Panelhider.Controls.Add(Me.btnAddCandidates)
        Me.Panelhider.Location = New System.Drawing.Point(64, 129)
        Me.Panelhider.Name = "Panelhider"
        Me.Panelhider.Size = New System.Drawing.Size(885, 465)
        Me.Panelhider.TabIndex = 0
        '
        'candihider
        '
        Me.candihider.AutoSize = True
        Me.candihider.Font = New System.Drawing.Font("Poppins", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.candihider.ForeColor = System.Drawing.SystemColors.Control
        Me.candihider.Location = New System.Drawing.Point(294, 168)
        Me.candihider.Name = "candihider"
        Me.candihider.Size = New System.Drawing.Size(308, 62)
        Me.candihider.TabIndex = 7
        Me.candihider.Text = "No Candidates?"
        '
        'btnclose
        '
        Me.btnclose.Animated = True
        Me.btnclose.CheckedState.Parent = Me.btnclose
        Me.btnclose.CustomImages.Parent = Me.btnclose
        Me.btnclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnclose.HoverState.Parent = Me.btnclose
        Me.btnclose.Location = New System.Drawing.Point(440, 615)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(138, 27)
        Me.btnclose.TabIndex = 107
        Me.btnclose.Text = "Close Window"
        '
        'CandidatesPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 665)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panelhider)
        Me.Controls.Add(Me.flpMain)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CandidatesPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CandidatesPanel"
        Me.TopMost = True
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        Me.Panelhider.ResumeLayout(False)
        Me.Panelhider.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ButtonPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonEVPresident As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVFinance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVActivities As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVComMarketing As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ButtonVDocumentation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAddCandidates As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents Panelhider As Panel
    Friend WithEvents candihider As Label
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2Button
End Class
