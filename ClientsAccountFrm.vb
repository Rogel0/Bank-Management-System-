Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ClientsAccountFrm
    Private Sub ClientsAccountFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccounts()
        Call randomAccountNumber()
    End Sub

    Private Sub randomAccountNumber()
        Dim AccountNum As New Random
        txtAccountNumbers.Text = AccountNum.Next(0, 1000000000)
    End Sub

    Private Sub LoadAccounts()
        sql = "SELECT * FROM qryAccounts"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        lvListOfClients.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("AcctNo").ToString)
            x.SubItems.Add(dr("Lastname").ToString & " " & dr("Firstname").ToString)
            x.SubItems.Add(dr("Address"))
            x.SubItems.Add(dr("Contact"))
            x.SubItems.Add(dr("Email"))
            x.SubItems.Add(dr("Bdate"))
            x.SubItems.Add(dr("Age"))
            x.SubItems.Add(dr("Sex"))
            x.SubItems.Add(dr("PIN"))
            x.SubItems.Add(dr("AcctStatus"))
            lvListOfClients.Items.Add(x)
        Loop
    End Sub

    Private Sub lvListOfClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListOfClients.SelectedIndexChanged
        If lvListOfClients.SelectedItems.Count > 0 Then
            txtAccountNumbers.Text = lvListOfClients.SelectedItems(0).SubItems(0).Text
        End If
    End Sub

    Private Sub txtAccountNumbers_TextChanged(sender As Object, e As EventArgs) Handles txtAccountNumbers.TextChanged
        Call connection()
        sql = "SELECT Lastname,Firstname,MI,Address,Contact,Email,Bdate,Age,Sex,PIN,AcctStatus FROM qryAccounts WHERE AcctNo='" & txtAccountNumbers.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtLastName.Text = dr("Lastname").ToString
            txtFirstName.Text = dr("Firstname").ToString
            txtMiddleName.Text = dr("MI").ToString
            txtAddresss.Text = dr("Address").ToString
            txtContactNo.Text = dr("Contact").ToString
            txtEmail.Text = dr("Email").ToString
            txtBirthdate.Value = dr("Bdate").ToString
            txtAge.Text = dr("Age").ToString
            txtSex.Text = dr("Sex").ToString
            txtPin.Text = dr("PIN").ToString
            cbStatus.Text = dr("AcctStatus").ToString
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("PIN and Re-Enter PIN mismatched", MsgBoxStyle.Critical)
            'ElseIf txtPin.TextLength < 6 Or txtReEnterPin.Text < 6 Then
            'MsgBox("Pin must be atleast 8 characters", MsgBoxStyle.Exclamation)
        Else
            Call updatedata()
        End If
    End Sub

    Private Sub updatedata()
        sql = "Update tblaccounts set Lastname=@Lastname,Firstname=@Firstname,MI=@MI,Address=@Address,Contact=@Contact,Email=@Email,Age=@Age,Bdate=@Bdate,Sex=@Sex,AcctStatus=@AcctStatus where AcctNo=@AcctNo"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@Lastname", txtLastName.Text)
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@MI", txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", txtAddresss.Text)
            .Parameters.AddWithValue("@Contact", txtContactNo.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@Bdate", txtBirthdate.Text)
            .Parameters.AddWithValue("@Sex", txtSex.Text)
            .Parameters.AddWithValue("@AcctStatus", cbStatus.Text)
            .Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
            .ExecuteNonQuery()
        End With
        updatepin()
        MsgBox("Client Record Successfully Updated", MsgBoxStyle.Information)
        Call LoadAccounts()
    End Sub

    Private Sub checkAccounts()
        sql = "SELECT AcctNo FROM tblAccounts WHERE AcctNo=@AcctNo"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            MsgBox("Account is already exist", MsgBoxStyle.Exclamation)
        Else
            'SavePin()
            'Call clrtxt()
            Call SaveData()
            Call clrtxt()
            Call LoadAccounts()

        End If
        dr.Close()
    End Sub

    Private Sub updatepin()
        sql = "Update tblPin set PIN=@PIN where AcctNo=@AcctNo"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@PIN", txtPin.Text)
            .Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
            .ExecuteNonQuery()
        End With
    End Sub

    Private Sub SaveData()
        sql = "INSERT INTO tblAccounts([AcctNo],[Lastname],[Firstname],[MI],[Address],[Contact],[Email],[Age],[Bdate],[Sex],[AcctStatus]) VALUES ([@AcctNo],[@Lastname],[@Firstname],[@MI],[@Address],[@Contact],[@Email],[@Age],[@Bdate],[@Sex],[@AcctStatus])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
            .Parameters.AddWithValue("@Lastname", txtLastName.Text)
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@MI", txtMiddleName.Text)
            .Parameters.AddWithValue("@Address", txtAddresss.Text)
            .Parameters.AddWithValue("@Contact", txtContactNo.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
            .Parameters.AddWithValue("@Age", txtAge.Text)
            .Parameters.AddWithValue("@Bdate", txtBirthdate.Text)
            .Parameters.AddWithValue("@Sex", txtSex.Text)
            .Parameters.AddWithValue("@AcctStatus", cbStatus.Text)
            .ExecuteNonQuery()
        End With
        SavePin()
        MsgBox("New Account Created", MsgBoxStyle.Information, "Client Account")
    End Sub

    Private Sub SavePin()
        If txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("PIN mismatch!", MsgBoxStyle.Critical)
        Else
            sql = "INSERT INTO tblPin([AcctNo],[PIN]) VALUES ([@AcctNo],[@PIN])"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
                .Parameters.AddWithValue("@PIN", txtPin.Text)
                .ExecuteNonQuery()
            End With
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call clrtxt()
        Call randomAccountNumber()
    End Sub

    Private Sub clrtxt()
        'txtAccountNumbers.Clear()
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





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Call checkAccounts()
        'Call SaveData()
        'Call clrtxt()
        'Call LoadAccounts()
        If txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("Pin and Re-enter Pin Mismatch", MsgBoxStyle.Critical)
        Else
                Call checkAccounts()
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        FrmAdminDashboard.Show()
    End Sub
End Class