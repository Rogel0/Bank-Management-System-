Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmCreateClientAccount
    Private Sub FrmCreateClientAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call randomnumber()
    End Sub

    Private Sub randomnumber()
        Dim AccountNum As New Random
        txtAccountNumber.Text = AccountNum.Next(0, 1000000000)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtAccountNumber.Text = "" Or txtPin.Text = "" Or txtReEnterPin.Text = "" Then
            MsgBox("Put information", MsgBoxStyle.Critical)
        ElseIf txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("Pin and Re-enter Pin Mismatch", MsgBoxStyle.Critical)
            'ElseIf txtAccountNumber.TextLength < 10 Then
            'MsgBox("Account Number is less than 10 characters", MsgBoxStyle.Critical)
        ElseIf txtPin.TextLength < 8 And txtReEnterPin.TextLength < 8 Then
            MsgBox("Pin is less than 6 characters", MsgBoxStyle.Critical)
        ElseIf Not Regex.IsMatch(txtPin.Text, "^(?=.*[A-Za-z])(?=.*\d).+$") Then
            MsgBox("Pin must contain at least one letter and one number", MsgBoxStyle.Critical)
        Else
            Call checkAccounts()
        End If
    End Sub

    Private Sub SaveData()
        sql = "INSERT INTO tblAccounts([AccountNumber],[Lastname],[Firstname],[MiddleName],[Address],[ContactNumber],[Email],[Age],[BirthDate],[Sex],[AccountStatus]) VALUES ([@AccountNumber],[@Lastname],[@Firstname],[@MiddleName],[@Address],[@ContactNumber],[@Email],[@Age],[@BirthDate],[@Sex],[@AccountStatus])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text)
            .Parameters.AddWithValue("@Lastname", txtLastName.Text)
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", txtAddresss.Text)
            .Parameters.AddWithValue("@ContactNumber", txtContactNo.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@BirthDate", txtBirthdate.Text)
            .Parameters.AddWithValue("@Sex", txtSex.Text)
            .Parameters.AddWithValue("@AccountStatus", "Active")
            .ExecuteNonQuery()
        End With
        MsgBox("New Account Created", MsgBoxStyle.Information, "Client Account")
    End Sub

    Private Sub SavePin()
        If txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("PIN mismatch!", MsgBoxStyle.Critical)
        Else
            sql = "INSERT INTO tblPin([AccountNumber],[PIN]) VALUES ([@AccountNumber],[@PIN])"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text)
                .Parameters.AddWithValue("@PIN", txtPin.Text)
                .ExecuteNonQuery()
            End With
        End If
        SaveData()
    End Sub

    Private Sub checkAccounts()
        sql = "SELECT AccountNumber FROM tblAccounts WHERE AccountNumber=@AccountNumber"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            MsgBox("Account is already exist", MsgBoxStyle.Exclamation)
        Else
            SavePin()
            Call clrtxt()
        End If
        dr.Close()
    End Sub

    Private Function checkIfAllInfoFields() As Boolean
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtMiddleName.Text = "" Or txtAddresss.Text = "" Or txtContactNo.Text = "" Or txtEmail.Text = "" Or txtAge.Text = "" Or txtSex.Text = "" Or txtBirthdate.Text = "" Or txtPin.Text = "" Or txtAccountNumber.Text = "" Or txtReEnterPin.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub clrtxt()
        txtAccountNumber.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtAddresss.Clear()
        txtContactNo.Clear()
        txtEmail.Clear()
        txtAge.Clear()
        txtPin.Clear()
        txtReEnterPin.Clear()
        txtSex.SelectedIndex = -1
    End Sub

    Private Sub lblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        ClientLoginFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
