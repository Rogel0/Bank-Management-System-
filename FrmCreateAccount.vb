Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmCreateAccount
    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If UserName.Text = "" Or Password.Text = "" Or ConfirmPassword.Text = "" Then
            MsgBox("Please Input Information", MsgBoxStyle.Critical)
        ElseIf Password.Text <> ConfirmPassword.Text Then
            MsgBox("Password and Confirmed Password Mismatch", MsgBoxStyle.Critical)
        ElseIf Password.TextLength < 6 And ConfirmPassword.TextLength < 6 Then
            MsgBox("Password is less than 6 characters", MsgBoxStyle.Critical)
        Else
            Call checkifExist()
        End If
    End Sub

    Private Sub SaveData()
        sql = "INSERT INTO tblUsers([username],[password],[role])values([@role],[@username],[@password])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@username]", UserName.Text)
            .Parameters.AddWithValue("[@password]", Password.Text)
            .Parameters.AddWithValue("[@role]", role.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("New Record Successfully Save", MsgBoxStyle.Information, "Save Data")

    End Sub

    Private Sub checkifExist()
        sql = "SELECT username FROM tblUsers WHERE username ='" & UserName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            MsgBox("Username is already Exist", MsgBoxStyle.Exclamation, "Duplicate Records")
        Else
            Call SaveData()
            Call clrtxt()
        End If
    End Sub

    Private Sub clrtxt()
        'role.Clear()
        UserName.Clear()
        Password.Clear()
        ConfirmPassword.Clear()
    End Sub

    Private Sub lblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        'clrtxt()
        FrmLogin.Show()
    End Sub

    Private Sub chckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chckBox1.CheckedChanged
        If chckBox1.Checked Then
            Password.PasswordChar = ControlChars.NullChar
        Else
            Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub chckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chckBox2.CheckedChanged
        If chckBox2.Checked Then
            ConfirmPassword.PasswordChar = ControlChars.NullChar
        Else
            ConfirmPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class