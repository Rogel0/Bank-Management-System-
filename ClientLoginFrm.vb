Imports System.Data.OleDb

Public Class ClientLoginFrm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        FrmCreateClientAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "Select * from qryAccounts where AcctNo='" & AccountNumber.Text & "' and PIN='" & Pin.Text & "' and AcctStatus = 'Active'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If String.IsNullOrEmpty(AccountNumber.Text) OrElse String.IsNullOrEmpty(Pin.Text) Then
            MsgBox("There is an empty field", MsgBoxStyle.Exclamation, "Please input all fields")
        ElseIf dr.Read = True Then
            Call CheckRole()
        Else
            Call checkifdisabled()
            'LogActivity("Login Failed")
        End If
    End Sub


    Private Sub CheckRole()
        sql = "Select * from qryAccounts where AcctNo='" & AccountNumber.Text & "' and PIN='" & Pin.Text & "' and role = 'Administrator'" & "" & " and AcctStatus = 'Active'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            FrmAdminDashboard.tssUsername.Text = dr("LastName").ToString
            FrmAdminDashboard.tssPosition.Text = dr("role").ToString
            MsgBox("Admin account successfully logged in", MsgBoxStyle.Information)
            Me.Hide()
            FrmAdminDashboard.ShowDialog()
            Me.Close()
            LogActivity("Login Successful - Admin")
        Else
            frmClientDashBoard.lblAcctNo.Text = Me.AccountNumber.Text
            frmClientDashBoard.lblAccountName.Text = lblAcctName.Text
            MsgBox("Client account successfully logged in", MsgBoxStyle.Information)
            Me.Hide()
            frmClientDashBoard.ShowDialog()
            Me.Close()
            LogActivity("Login Successful - Client")
        End If
    End Sub

    Private Sub DisabledAccount()
        sql = "UPDATE tblAccounts SET AcctStatus=@AcctStatus WHERE AcctNo=@AcctNo"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("AcctStatus", "Disable")
            .Parameters.AddWithValue("@AcctNo", AccountNumber.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("This account has been disabled", MsgBoxStyle.Exclamation)
        btnLogin.Enabled = False
        LogActivity("Account Disabled")
    End Sub

    Private Sub checkifdisabled()
        sql = "SELECT AcctStatus FROM qryAccounts WHERE AcctNo='" & AccountNumber.Text & "' and AcctStatus = 'Disable'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            LogActivity("Login Failed (Account Disabled)")
            Call DisabledAccount()

        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
            lblAttemptsNumber.Text = lblAttemptsNumber.Text - 1
            If lblAttemptsNumber.Text = "0" Then
                MsgBox("You reached maximum attempt limits", MsgBoxStyle.Critical)
                Call DisabledAccount()
                LogActivity("Login Failed (Account Disabled)")
            End If
            LogActivity("Login Failed")
        End If
    End Sub

    Private Sub LogActivity(activityType As String)

        ' Log the activity to the tblActivityLog table
        sql = "INSERT INTO tblActivityLog([username], [activityType], [timestamp]) VALUES ([@username], [@activityType], [@timestamp])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@username", frmClientDashBoard.lblAcctNo.Text)
            .Parameters.AddWithValue("@activityType", activityType)
            .Parameters.AddWithValue("@timestamp", Now.ToString)
            .ExecuteNonQuery()
        End With

    End Sub


    Private Sub ClientLoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub txtclr()
        AccountNumber.Clear()
        Pin.Clear()
    End Sub


    Private Sub AccountNumber_TextChanged(sender As Object, e As EventArgs) Handles AccountNumber.TextChanged
        Call connection()
        sql = "SELECT Lastname,Firstname,MI FROM qryAccounts WHERE AcctNo='" & AccountNumber.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblAcctName.Text = dr(0).ToString & " " & dr(1).ToString & " " & dr(2).ToString
        End If
    End Sub

    Private Sub lblRestart_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRestart.LinkClicked
        ' Prompt the user to confirm if they want to restart the application
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to restart the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if the user clicked "Yes"
        If result = DialogResult.Yes Then
            ' Close the current form
            Me.Close()

            ' Restart the application
            Application.Restart()
        End If
    End Sub

    Private Sub lblAcctName_Click(sender As Object, e As EventArgs) Handles lblAcctName.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToString
    End Sub

    Private Sub Pin_TextChanged(sender As Object, e As EventArgs) Handles Pin.TextChanged

    End Sub
End Class