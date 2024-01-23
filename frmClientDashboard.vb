Imports System.Data.OleDb

Public Class frmClientDashBoard

    Public Property AccountNumber As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToString
    End Sub

    Private Sub frmClientDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        AddHandler frmDeposit.TransactionCompleted, AddressOf UpdateBalance
        AddHandler frmWithdraw.TransactionCompleted, AddressOf UpdateBalance
        Call UpdateBalance()
    End Sub

    Private Sub UpdateBalance()
        lblBalance.Text = getWithdraw().ToString()
    End Sub

    Private Function getWithdraw() As Decimal
        Dim balance As Decimal = 0
        sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", lblAcctNo.Text)
        cmd.Parameters.AddWithValue("@TransType", "Deposit")
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim oldBalance As Decimal = If(Convert.IsDBNull(dr(0)), 0, Convert.ToDecimal(dr(0)))
            Debug.WriteLine("Deposit amount: " & oldBalance)

            sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AcctNo", lblAcctNo.Text)
            cmd.Parameters.AddWithValue("@TransType", "Withdraw")
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim withdrawalAmount As Decimal = If(Convert.IsDBNull(dr(0)), 0, Convert.ToDecimal(dr(0)))
                Debug.WriteLine("Withdraw amount: " & withdrawalAmount)
                balance = oldBalance - withdrawalAmount
            End If
        End If
        Debug.WriteLine("Calculated balance: " & balance)
        Return balance
    End Function

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        frmDeposit.ShowDialog()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        frmWithdraw.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmhistory.Show()
    End Sub

    Private Sub lblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LogActivity(activityType As String)

        ' Log the activity to the tblActivityLog table
        sql = "INSERT INTO tblActivityLog([username], [activityType], [timestamp]) VALUES ([@username], [@activityType], [@timestamp])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@username", lblAcctNo.Text)
            .Parameters.AddWithValue("@activityType", activityType)
            .Parameters.AddWithValue("@timestamp", Now.ToString)
            .ExecuteNonQuery()
        End With

    End Sub

    Private Sub lblActivityLog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmActivityLog.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        frmClientChangePass.Show()
    End Sub

    Public Overloads Sub Show(accountNumber As String)
        Me.AccountNumber = accountNumber
        MyBase.Show()
    End Sub

    Private Sub btnTransactHistory_Click(sender As Object, e As EventArgs) Handles btnTransactHistory.Click
        frmhistory.AccountNumber = lblAcctNo.Text
        frmhistory.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        frmClientChangePass.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        frmActivityLog.AccountNumber = lblAcctNo.Text
        frmActivityLog.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ClientLoginFrm.Show()
        Call clrtxt()
        LogActivity("Logout")
    End Sub

    Private Sub clrtxt()
        ClientLoginFrm.AccountNumber.Text = ""
        ClientLoginFrm.Pin.Text = ""
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        ClientLoginFrm.Show()
        Call clrtxt()
        LogActivity("Logout")
    End Sub
End Class