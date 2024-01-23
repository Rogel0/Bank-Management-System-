Imports Guna.UI2.WinForms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreateAccount
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAccount))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnExit = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.chckBox2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.chckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.UserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignup = New Guna.UI2.WinForms.Guna2Button()
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.role = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = Global.IPT_31A1_GERODIAZ.My.Resources.Resources.undraw_Authentication_re_svpt
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Guna2ImageButton1)
        Me.Guna2Panel1.Controls.Add(Me.btnExit)
        Me.Guna2Panel1.Controls.Add(Me.chckBox2)
        Me.Guna2Panel1.Controls.Add(Me.chckBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(494, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(393, 453)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(313, 13)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(35, 31)
        Me.Guna2ImageButton1.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnExit.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnExit.ImageRotate = 0!
        Me.btnExit.Location = New System.Drawing.Point(354, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnExit.Size = New System.Drawing.Size(27, 23)
        Me.btnExit.TabIndex = 0
        '
        'chckBox2
        '
        Me.chckBox2.AutoSize = True
        Me.chckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckBox2.CheckedState.BorderRadius = 0
        Me.chckBox2.CheckedState.BorderThickness = 0
        Me.chckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.chckBox2.Location = New System.Drawing.Point(-122, 205)
        Me.chckBox2.Name = "chckBox2"
        Me.chckBox2.Size = New System.Drawing.Size(62, 20)
        Me.chckBox2.TabIndex = 6
        Me.chckBox2.Text = "Show"
        Me.chckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckBox2.UncheckedState.BorderRadius = 0
        Me.chckBox2.UncheckedState.BorderThickness = 0
        Me.chckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'chckBox1
        '
        Me.chckBox1.AutoSize = True
        Me.chckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckBox1.CheckedState.BorderRadius = 0
        Me.chckBox1.CheckedState.BorderThickness = 0
        Me.chckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.chckBox1.Location = New System.Drawing.Point(-122, 130)
        Me.chckBox1.Name = "chckBox1"
        Me.chckBox1.Size = New System.Drawing.Size(62, 20)
        Me.chckBox1.TabIndex = 5
        Me.chckBox1.Text = "Show"
        Me.chckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckBox1.UncheckedState.BorderRadius = 0
        Me.chckBox1.UncheckedState.BorderThickness = 0
        Me.chckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'UserName
        '
        Me.UserName.BorderRadius = 10
        Me.UserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserName.DefaultText = ""
        Me.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserName.ForeColor = System.Drawing.Color.Black
        Me.UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.Location = New System.Drawing.Point(119, 74)
        Me.UserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UserName.Name = "UserName"
        Me.UserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserName.PlaceholderForeColor = System.Drawing.Color.Maroon
        Me.UserName.PlaceholderText = "Username"
        Me.UserName.SelectedText = ""
        Me.UserName.Size = New System.Drawing.Size(250, 32)
        Me.UserName.TabIndex = 2
        '
        'Password
        '
        Me.Password.BorderRadius = 10
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Location = New System.Drawing.Point(119, 133)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.PlaceholderForeColor = System.Drawing.Color.Maroon
        Me.Password.PlaceholderText = "Password"
        Me.Password.SelectedText = ""
        Me.Password.Size = New System.Drawing.Size(250, 32)
        Me.Password.TabIndex = 3
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.BorderRadius = 10
        Me.ConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPassword.DefaultText = ""
        Me.ConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.ConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassword.Location = New System.Drawing.Point(119, 207)
        Me.ConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Maroon
        Me.ConfirmPassword.PlaceholderText = "Confirm Password"
        Me.ConfirmPassword.SelectedText = ""
        Me.ConfirmPassword.Size = New System.Drawing.Size(250, 32)
        Me.ConfirmPassword.TabIndex = 4
        '
        'btnSignup
        '
        Me.btnSignup.BorderRadius = 2
        Me.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignup.FillColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSignup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSignup.Location = New System.Drawing.Point(175, 374)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(134, 45)
        Me.btnSignup.TabIndex = 7
        Me.btnSignup.Text = "Signup"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.LinkColor = System.Drawing.Color.Black
        Me.lblBack.Location = New System.Drawing.Point(22, 19)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(38, 16)
        Me.lblBack.TabIndex = 8
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(887, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'role
        '
        Me.role.BackColor = System.Drawing.Color.Transparent
        Me.role.BorderRadius = 5
        Me.role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.role.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.role.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.role.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.role.ItemHeight = 30
        Me.role.Items.AddRange(New Object() {"Admin", "Client"})
        Me.role.Location = New System.Drawing.Point(119, 272)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(250, 36)
        Me.role.TabIndex = 10
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 454)
        Me.Controls.Add(Me.role)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateAccount"
        Me.Text = "frmCreateAccount"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub







    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents chckBox2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblBack As LinkLabel
    Friend WithEvents btnExit As Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna2ImageButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents role As Guna2ComboBox
End Class
