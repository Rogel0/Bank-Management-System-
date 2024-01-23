<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientLoginFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientLoginFrm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRestart = New System.Windows.Forms.LinkLabel()
        Me.lblAttemptsNumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCreateAccount = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Pin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AccountNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAcctName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(484, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 37)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "CLIENT LOGIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Attempts:"
        '
        'lblRestart
        '
        Me.lblRestart.AutoSize = True
        Me.lblRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRestart.LinkColor = System.Drawing.Color.Black
        Me.lblRestart.Location = New System.Drawing.Point(368, 6)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(50, 16)
        Me.lblRestart.TabIndex = 17
        Me.lblRestart.TabStop = True
        Me.lblRestart.Text = "Restart"
        Me.lblRestart.UseMnemonic = False
        '
        'lblAttemptsNumber
        '
        Me.lblAttemptsNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblAttemptsNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttemptsNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAttemptsNumber.Location = New System.Drawing.Point(609, 266)
        Me.lblAttemptsNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblAttemptsNumber.Name = "lblAttemptsNumber"
        Me.lblAttemptsNumber.Size = New System.Drawing.Size(11, 18)
        Me.lblAttemptsNumber.TabIndex = 25
        Me.lblAttemptsNumber.Text = "3"
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.LinkColor = System.Drawing.Color.Black
        Me.lblCreateAccount.Location = New System.Drawing.Point(552, 389)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(98, 16)
        Me.lblCreateAccount.TabIndex = 24
        Me.lblCreateAccount.TabStop = True
        Me.lblCreateAccount.Text = "Create Account"
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 5
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Black
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(429, 326)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(336, 46)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "Login"
        '
        'Pin
        '
        Me.Pin.BorderRadius = 5
        Me.Pin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Pin.DefaultText = ""
        Me.Pin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Pin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Pin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Pin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Pin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Pin.Location = New System.Drawing.Point(438, 210)
        Me.Pin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pin.Name = "Pin"
        Me.Pin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pin.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.Pin.PlaceholderText = "Enter Pin"
        Me.Pin.SelectedText = ""
        Me.Pin.Size = New System.Drawing.Size(336, 38)
        Me.Pin.TabIndex = 22
        '
        'AccountNumber
        '
        Me.AccountNumber.BorderRadius = 5
        Me.AccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AccountNumber.DefaultText = ""
        Me.AccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AccountNumber.ForeColor = System.Drawing.Color.Gray
        Me.AccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountNumber.Location = New System.Drawing.Point(438, 134)
        Me.AccountNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AccountNumber.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.AccountNumber.PlaceholderText = "Enter Account Number"
        Me.AccountNumber.SelectedText = ""
        Me.AccountNumber.Size = New System.Drawing.Size(336, 38)
        Me.AccountNumber.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(398, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(393, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(757, 6)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnClose.Size = New System.Drawing.Size(32, 25)
        Me.btnClose.TabIndex = 20
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
        Me.btnMinimize.Location = New System.Drawing.Point(710, 6)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnMinimize.Size = New System.Drawing.Size(41, 25)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.lblDate)
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(361, 450)
        Me.Guna2Panel1.TabIndex = 18
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(271, 425)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(11, 16)
        Me.lblDate.TabIndex = 31
        Me.lblDate.Text = "-"
        '
        'lblAcctName
        '
        Me.lblAcctName.AutoSize = True
        Me.lblAcctName.Location = New System.Drawing.Point(701, 275)
        Me.lblAcctName.Name = "lblAcctName"
        Me.lblAcctName.Size = New System.Drawing.Size(11, 16)
        Me.lblAcctName.TabIndex = 30
        Me.lblAcctName.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ClientLoginFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAcctName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRestart)
        Me.Controls.Add(Me.lblAttemptsNumber)
        Me.Controls.Add(Me.lblCreateAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Pin)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientLoginFrm"
        Me.Text = "ClientLoginFrm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRestart As LinkLabel
    Friend WithEvents lblAttemptsNumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCreateAccount As LinkLabel
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Pin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AccountNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAcctName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
End Class
