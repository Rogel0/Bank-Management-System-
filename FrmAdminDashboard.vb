

Public Class FrmAdminDashboard

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub ClientsAccountToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        ClientLoginFrm.Show()
    End Sub

    Private Sub Guna2PictureBox8_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox8.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        ClientsAccountFrm.Show()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tssDate.Text = Now.ToLongDateString & " " & Now.ToLongDateString
    End Sub
End Class