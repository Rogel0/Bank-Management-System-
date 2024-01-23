<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientDashBoard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientDashBoard))
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblAcctNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox9 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox8 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnTransactHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox7 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(478, 286)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(197, 46)
        Me.btnDeposit.TabIndex = 34
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(237, 286)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(197, 46)
        Me.btnWithdraw.TabIndex = 33
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(431, 223)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(31, 16)
        Me.lblBalance.TabIndex = 32
        Me.lblBalance.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Current Balance : "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(431, 146)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(11, 16)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "-"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Location = New System.Drawing.Point(431, 84)
        Me.lblAccountName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(11, 16)
        Me.lblAccountName.TabIndex = 29
        Me.lblAccountName.Text = "-"
        '
        'lblAcctNo
        '
        Me.lblAcctNo.AutoSize = True
        Me.lblAcctNo.Location = New System.Drawing.Point(431, 24)
        Me.lblAcctNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAcctNo.Name = "lblAcctNo"
        Me.lblAcctNo.Size = New System.Drawing.Size(11, 16)
        Me.lblAcctNo.TabIndex = 28
        Me.lblAcctNo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date / Time : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Account Name : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Account Number : "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnLogout)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox8)
        Me.Guna2Panel1.Controls.Add(Me.btnTransactHistory)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(225, 346)
        Me.Guna2Panel1.TabIndex = 39
        '
        'Guna2Button8
        '
        Me.Guna2Button8.Animated = True
        Me.Guna2Button8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.DefaultAutoSize = True
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button8.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button8.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button8.IndicateFocus = True
        Me.Guna2Button8.Location = New System.Drawing.Point(29, 219)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.Size = New System.Drawing.Size(105, 39)
        Me.Guna2Button8.TabIndex = 11
        Me.Guna2Button8.Text = "Settings"
        Me.Guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button8.UseTransparentBackground = True
        '
        'Guna2PictureBox9
        '
        Me.Guna2PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox9.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2PictureBox9.Image = CType(resources.GetObject("Guna2PictureBox9.Image"), System.Drawing.Image)
        Me.Guna2PictureBox9.ImageRotate = 0!
        Me.Guna2PictureBox9.Location = New System.Drawing.Point(2, 219)
        Me.Guna2PictureBox9.Name = "Guna2PictureBox9"
        Me.Guna2PictureBox9.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox9.TabIndex = 10
        Me.Guna2PictureBox9.TabStop = False
        Me.Guna2PictureBox9.UseTransparentBackground = True
        '
        'Guna2PictureBox8
        '
        Me.Guna2PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox8.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2PictureBox8.Image = CType(resources.GetObject("Guna2PictureBox8.Image"), System.Drawing.Image)
        Me.Guna2PictureBox8.ImageRotate = 0!
        Me.Guna2PictureBox8.Location = New System.Drawing.Point(2, 290)
        Me.Guna2PictureBox8.Name = "Guna2PictureBox8"
        Me.Guna2PictureBox8.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox8.TabIndex = 10
        Me.Guna2PictureBox8.TabStop = False
        Me.Guna2PictureBox8.UseTransparentBackground = True
        '
        'btnTransactHistory
        '
        Me.btnTransactHistory.Animated = True
        Me.btnTransactHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnTransactHistory.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransactHistory.DefaultAutoSize = True
        Me.btnTransactHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransactHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransactHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransactHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransactHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnTransactHistory.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.btnTransactHistory.ForeColor = System.Drawing.Color.Black
        Me.btnTransactHistory.IndicateFocus = True
        Me.btnTransactHistory.Location = New System.Drawing.Point(29, 155)
        Me.btnTransactHistory.Name = "btnTransactHistory"
        Me.btnTransactHistory.Size = New System.Drawing.Size(207, 39)
        Me.btnTransactHistory.TabIndex = 14
        Me.btnTransactHistory.Text = "Transaction History"
        Me.btnTransactHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransactHistory.UseTransparentBackground = True
        '
        'Guna2PictureBox7
        '
        Me.Guna2PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox7.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2PictureBox7.Image = CType(resources.GetObject("Guna2PictureBox7.Image"), System.Drawing.Image)
        Me.Guna2PictureBox7.ImageRotate = 0!
        Me.Guna2PictureBox7.Location = New System.Drawing.Point(2, 155)
        Me.Guna2PictureBox7.Name = "Guna2PictureBox7"
        Me.Guna2PictureBox7.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox7.TabIndex = 13
        Me.Guna2PictureBox7.TabStop = False
        Me.Guna2PictureBox7.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DefaultAutoSize = True
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.IndicateFocus = True
        Me.Guna2Button1.Location = New System.Drawing.Point(29, 139)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(26, 10)
        Me.Guna2Button1.TabIndex = 11
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.DefaultAutoSize = True
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.IndicateFocus = True
        Me.Guna2Button3.Location = New System.Drawing.Point(29, 18)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(138, 39)
        Me.Guna2Button3.TabIndex = 10
        Me.Guna2Button3.Text = "Activity Log"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.DefaultAutoSize = True
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.IndicateFocus = True
        Me.Guna2Button5.Location = New System.Drawing.Point(29, 84)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(193, 39)
        Me.Guna2Button5.TabIndex = 3
        Me.Guna2Button5.Text = "Change Password"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.UseTransparentBackground = True
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(2, 21)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox4.TabIndex = 8
        Me.Guna2PictureBox4.TabStop = False
        Me.Guna2PictureBox4.UseTransparentBackground = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(2, 84)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.DefaultAutoSize = True
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.IndicateFocus = True
        Me.btnLogout.Location = New System.Drawing.Point(29, 283)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(97, 39)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.UseTransparentBackground = True
        '
        'frmClientDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 356)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.lblAcctNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientDashBoard"
        Me.Text = "frmClientDashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents lblAcctNo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox9 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox8 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnTransactHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox7 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
End Class
