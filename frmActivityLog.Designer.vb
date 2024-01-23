<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivityLog
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
        Me.lvListOfClients = New System.Windows.Forms.ListView()
        Me.lvlUsername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlActivityType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvlTimeStamp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvListOfClients
        '
        Me.lvListOfClients.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.lvListOfClients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvlUsername, Me.lvlActivityType, Me.lvlTimeStamp})
        Me.lvListOfClients.ForeColor = System.Drawing.Color.Black
        Me.lvListOfClients.GridLines = True
        Me.lvListOfClients.HideSelection = False
        Me.lvListOfClients.Location = New System.Drawing.Point(12, 31)
        Me.lvListOfClients.Name = "lvListOfClients"
        Me.lvListOfClients.Size = New System.Drawing.Size(508, 273)
        Me.lvListOfClients.TabIndex = 47
        Me.lvListOfClients.UseCompatibleStateImageBehavior = False
        Me.lvListOfClients.View = System.Windows.Forms.View.Details
        '
        'lvlUsername
        '
        Me.lvlUsername.Text = "Username"
        Me.lvlUsername.Width = 128
        '
        'lvlActivityType
        '
        Me.lvlActivityType.Text = "Activity Type"
        Me.lvlActivityType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlActivityType.Width = 150
        '
        'lvlTimeStamp
        '
        Me.lvlTimeStamp.Text = "Timestamp"
        Me.lvlTimeStamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lvlTimeStamp.Width = 150
        '
        'frmActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 316)
        Me.Controls.Add(Me.lvListOfClients)
        Me.Name = "frmActivityLog"
        Me.Text = "frmActivityLog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvListOfClients As ListView
    Friend WithEvents lvlUsername As ColumnHeader
    Friend WithEvents lvlActivityType As ColumnHeader
    Friend WithEvents lvlTimeStamp As ColumnHeader
End Class
