<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCreateAccount = New System.Windows.Forms.LinkLabel()
        Me.chckShow = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lblLoginSuccessfull = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblLoginFailed = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSuccessfull = New System.Windows.Forms.Label()
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.LightGray
        Me.Username.BorderColor = System.Drawing.Color.LightGray
        Me.Username.BorderThickness = 0
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FillColor = System.Drawing.Color.LightGray
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Username.ForeColor = System.Drawing.Color.Black
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.Location = New System.Drawing.Point(575, 146)
        Me.Username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Username.Name = "Username"
        Me.Username.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Username.PlaceholderText = "Username"
        Me.Username.SelectedText = ""
        Me.Username.Size = New System.Drawing.Size(258, 35)
        Me.Username.TabIndex = 1
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.LightGray
        Me.Password.BorderColor = System.Drawing.Color.Transparent
        Me.Password.BorderRadius = 15
        Me.Password.BorderThickness = 0
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FillColor = System.Drawing.Color.LightGray
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Password.ForeColor = System.Drawing.Color.Black
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(575, 212)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.Password.PlaceholderText = "Password"
        Me.Password.SelectedText = ""
        Me.Password.Size = New System.Drawing.Size(258, 35)
        Me.Password.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnLogin.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Font = New System.Drawing.Font("Sitka Banner Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(604, 354)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(194, 43)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.LinkColor = System.Drawing.Color.Black
        Me.lblCreateAccount.Location = New System.Drawing.Point(656, 409)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(98, 16)
        Me.lblCreateAccount.TabIndex = 4
        Me.lblCreateAccount.TabStop = True
        Me.lblCreateAccount.Text = "Create Account"
        '
        'chckShow
        '
        Me.chckShow.AutoSize = True
        Me.chckShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckShow.CheckedState.BorderRadius = 0
        Me.chckShow.CheckedState.BorderThickness = 0
        Me.chckShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.chckShow.Location = New System.Drawing.Point(575, 254)
        Me.chckShow.Name = "chckShow"
        Me.chckShow.Size = New System.Drawing.Size(62, 20)
        Me.chckShow.TabIndex = 0
        Me.chckShow.Text = "Show"
        Me.chckShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckShow.UncheckedState.BorderRadius = 0
        Me.chckShow.UncheckedState.BorderThickness = 0
        Me.chckShow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'lblLoginSuccessfull
        '
        Me.lblLoginSuccessfull.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginSuccessfull.Font = New System.Drawing.Font("MingLiU-ExtB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginSuccessfull.ForeColor = System.Drawing.Color.Green
        Me.lblLoginSuccessfull.Location = New System.Drawing.Point(115, 27)
        Me.lblLoginSuccessfull.Name = "lblLoginSuccessfull"
        Me.lblLoginSuccessfull.Size = New System.Drawing.Size(3, 2)
        Me.lblLoginSuccessfull.TabIndex = 5
        Me.lblLoginSuccessfull.Text = Nothing
        '
        'lblLoginFailed
        '
        Me.lblLoginFailed.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginFailed.Font = New System.Drawing.Font("MingLiU-ExtB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginFailed.ForeColor = System.Drawing.Color.Red
        Me.lblLoginFailed.Location = New System.Drawing.Point(142, 27)
        Me.lblLoginFailed.Name = "lblLoginFailed"
        Me.lblLoginFailed.Size = New System.Drawing.Size(3, 2)
        Me.lblLoginFailed.TabIndex = 6
        Me.lblLoginFailed.Text = Nothing
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe Fluent Icons", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(115, 98)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(142, 22)
        Me.Guna2HtmlLabel1.TabIndex = 7
        Me.Guna2HtmlLabel1.Text = "LOGIN ACCOUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(621, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOGIN ACCOUNT"
        '
        'lblSuccessfull
        '
        Me.lblSuccessfull.AutoSize = True
        Me.lblSuccessfull.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSuccessfull.Location = New System.Drawing.Point(644, 23)
        Me.lblSuccessfull.Name = "lblSuccessfull"
        Me.lblSuccessfull.Size = New System.Drawing.Size(0, 16)
        Me.lblSuccessfull.TabIndex = 6
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.ForeColor = System.Drawing.Color.Red
        Me.lblFailed.Location = New System.Drawing.Point(668, 23)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(0, 16)
        Me.lblFailed.TabIndex = 7
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel2.BackgroundImage = CType(resources.GetObject("Guna2Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-4, -4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(521, 459)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = Global.IPT_31A1_GERODIAZ.My.Resources.Resources.undraw_welcome_cats_thqn
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(91, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(266, 96)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnClose.ImageRotate = 0!
        Me.btnClose.ImageSize = New System.Drawing.Size(44, 44)
        Me.btnClose.IndicateFocus = True
        Me.btnClose.Location = New System.Drawing.Point(855, -1)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.Size = New System.Drawing.Size(32, 25)
        Me.btnClose.TabIndex = 28
        Me.btnClose.UseTransparentBackground = True
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMinimize.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnMinimize.ImageRotate = 0!
        Me.btnMinimize.ImageSize = New System.Drawing.Size(44, 44)
        Me.btnMinimize.IndicateFocus = True
        Me.btnMinimize.Location = New System.Drawing.Point(808, -1)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMinimize.Size = New System.Drawing.Size(41, 25)
        Me.btnMinimize.TabIndex = 29
        Me.btnMinimize.UseTransparentBackground = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(621, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Position:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ForeColor = System.Drawing.Color.Red
        Me.lblPosition.Location = New System.Drawing.Point(695, 291)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(0, 16)
        Me.lblPosition.TabIndex = 31
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 454)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSuccessfull)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chckShow)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.lblCreateAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = " "
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCreateAccount As LinkLabel
    Friend WithEvents chckShow As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblLoginSuccessfull As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLoginFailed As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSuccessfull As Label
    Friend WithEvents lblFailed As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPosition As Label
End Class
