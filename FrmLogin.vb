Imports System.Data.OleDb

Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "SELECT * FROM tblUsers WHERE username= '" & Username.Text & "' and password='" & Password.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblSuccessfull.Text = "Login Successfull"
            FrmAdminDashboard.tssUsername.Text = Username.Text
            FrmAdminDashboard.tssPosition.Text = lblPosition.Text
            Call cleartxt()
            Me.Hide()
            FrmAdminDashboard.Show()
            lblSuccessfull.Text = ""
            lblFailed.Text = ""
        Else
            lblFailed.Text = "Login Failed"
            'MsgBox("Login Failed", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub lblLoginAccountTxt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cleartxt()
        Username.Clear()
        Password.Clear()
    End Sub

    Private Sub chckShow_CheckedChanged(sender As Object, e As EventArgs) Handles chckShow.CheckedChanged
        If chckShow.Checked Then
            Password.PasswordChar = ControlChars.NullChar
        Else
            Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub lblCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        Me.Hide()
        FrmCreateAccount.Show()

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged
        Call connection()
        sql = "SELECT [position] FROM tblUsers WHERE username='" & Username.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblPosition.Text = dr(0).ToString
        End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class