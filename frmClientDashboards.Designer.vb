<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientDashboards
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
        Me.Timers1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDeposits = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.lblBalances = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblAcctNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabels1 = New System.Windows.Forms.LinkLabel()
        Me.lblTransachistoryy = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Timers1
        '
        Me.Timers1.Enabled = True
        Me.Timers1.Interval = 1000
        '
        'btnDeposits
        '
        Me.btnDeposits.Location = New System.Drawing.Point(70, 344)
        Me.btnDeposits.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeposits.Name = "btnDeposits"
        Me.btnDeposits.Size = New System.Drawing.Size(197, 46)
        Me.btnDeposits.TabIndex = 34
        Me.btnDeposits.Text = "Deposit"
        Me.btnDeposits.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(70, 291)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(197, 46)
        Me.btnWithdraw.TabIndex = 33
        Me.btnWithdraw.Text = "Withdraws"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'lblBalances
        '
        Me.lblBalances.AutoSize = True
        Me.lblBalances.Location = New System.Drawing.Point(246, 249)
        Me.lblBalances.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalances.Name = "lblBalances"
        Me.lblBalances.Size = New System.Drawing.Size(31, 16)
        Me.lblBalances.TabIndex = 32
        Me.lblBalances.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Current Balance : "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(246, 172)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(11, 16)
        Me.lblDate.TabIndex = 30
        Me.lblDate.Text = "-"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Location = New System.Drawing.Point(246, 110)
        Me.lblAccountName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(11, 16)
        Me.lblAccountName.TabIndex = 29
        Me.lblAccountName.Text = "-"
        '
        'lblAcctNo
        '
        Me.lblAcctNo.AutoSize = True
        Me.lblAcctNo.Location = New System.Drawing.Point(246, 50)
        Me.lblAcctNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAcctNo.Name = "lblAcctNo"
        Me.lblAcctNo.Size = New System.Drawing.Size(11, 16)
        Me.lblAcctNo.TabIndex = 28
        Me.lblAcctNo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Date / Time : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Account Name : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Account Number : "
        '
        'LinkLabels1
        '
        Me.LinkLabels1.AutoSize = True
        Me.LinkLabels1.Location = New System.Drawing.Point(737, 9)
        Me.LinkLabels1.Name = "LinkLabels1"
        Me.LinkLabels1.Size = New System.Drawing.Size(51, 16)
        Me.LinkLabels1.TabIndex = 35
        Me.LinkLabels1.TabStop = True
        Me.LinkLabels1.Text = "Log out"
        '
        'lblTransachistoryy
        '
        Me.lblTransachistoryy.AutoSize = True
        Me.lblTransachistoryy.Location = New System.Drawing.Point(608, 9)
        Me.lblTransachistoryy.Name = "lblTransachistoryy"
        Me.lblTransachistoryy.Size = New System.Drawing.Size(123, 16)
        Me.lblTransachistoryy.TabIndex = 36
        Me.lblTransachistoryy.TabStop = True
        Me.lblTransachistoryy.Text = "Transaction History"
        '
        'frmClientDashboards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTransachistoryy)
        Me.Controls.Add(Me.LinkLabels1)
        Me.Controls.Add(Me.btnDeposits)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.lblBalances)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.lblAcctNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientDashboards"
        Me.Text = "frmClientDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timers1 As Timer
    Friend WithEvents btnDeposits As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents lblBalances As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents lblAcctNo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabels1 As LinkLabel
    Friend WithEvents lblTransachistoryy As LinkLabel
End Class
