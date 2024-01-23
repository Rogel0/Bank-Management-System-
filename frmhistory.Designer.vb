<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhistory
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
        Me.lblBack = New System.Windows.Forms.LinkLabel()
        Me.lvListOfClients = New System.Windows.Forms.ListView()
        Me.lvlAccountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlTransNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlTransType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlTransAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Location = New System.Drawing.Point(9, 9)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(38, 16)
        Me.lblBack.TabIndex = 47
        Me.lblBack.TabStop = True
        Me.lblBack.Text = "Back"
        '
        'lvListOfClients
        '
        Me.lvListOfClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.lvListOfClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvlAccountNumber, Me.lvlTransNo, Me.lvlTransType, Me.lvlTransAmount, Me.lvlDateTime})
        Me.lvListOfClients.ForeColor = System.Drawing.Color.Black
        Me.lvListOfClients.GridLines = True
        Me.lvListOfClients.HideSelection = False
        Me.lvListOfClients.Location = New System.Drawing.Point(1, 50)
        Me.lvListOfClients.Name = "lvListOfClients"
        Me.lvListOfClients.Size = New System.Drawing.Size(727, 273)
        Me.lvListOfClients.TabIndex = 46
        Me.lvListOfClients.UseCompatibleStateImageBehavior = False
        Me.lvListOfClients.View = System.Windows.Forms.View.Details
        '
        'lvlAccountNumber
        '
        Me.lvlAccountNumber.Text = "AccountNumber"
        Me.lvlAccountNumber.Width = 128
        '
        'lvlTransNo
        '
        Me.lvlTransNo.Text = "Transaction Number"
        Me.lvlTransNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlTransNo.Width = 150
        '
        'lvlTransType
        '
        Me.lvlTransType.Text = "Transaction Type"
        Me.lvlTransType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlTransType.Width = 150
        '
        'lvlTransAmount
        '
        Me.lvlTransAmount.Text = "Transaction Amount"
        Me.lvlTransAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlTransAmount.Width = 130
        '
        'lvlDateTime
        '
        Me.lvlDateTime.Text = "Date & Time"
        Me.lvlDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlDateTime.Width = 150
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(640, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "PRINT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 326)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lvListOfClients)
        Me.Name = "frmhistory"
        Me.Text = "frmhistory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBack As LinkLabel
    Friend WithEvents lvListOfClients As ListView
    Friend WithEvents lvlAccountNumber As ColumnHeader
    Friend WithEvents lvlTransNo As ColumnHeader
    Friend WithEvents lvlTransType As ColumnHeader
    Friend WithEvents lvlTransAmount As ColumnHeader
    Friend WithEvents lvlDateTime As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
