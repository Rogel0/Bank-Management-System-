Imports System.Data.OleDb

Public Class frmClientDashboards
    Private Sub btnWithdraws_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        frmWithdraw.Show()
        Call getWithdrawalBalances()
    End Sub

    Private Sub frmClientDashboards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getWithdrawalBalances()
        'AddHandler frmWithdraw.TransactionCompleted, AddressOf getWithdrawalBalance
    End Sub



    Private Sub getWithdrawalBalances()
        ' Retrieve the user's account number from the form or wherever it is stored
        Dim accountNumber As String = lblAcctNo.Text

        ' Calculate total deposit amount for the account
        sql = "Select SUM(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", accountNumber)
        cmd.Parameters.AddWithValue("@TransType", "Deposit")
        dr = cmd.ExecuteReader

        If dr.Read = True AndAlso Not IsDBNull(dr(0)) Then
            Dim depositAmount As Decimal = Convert.ToDecimal(dr(0))

            ' Calculate total withdrawal amount for the account
            sql = "SELECT SUM(TransAmount) FROM tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AcctNo", accountNumber)
            cmd.Parameters.AddWithValue("@TransType", "Withdraw")
            dr = cmd.ExecuteReader

            If dr.Read = True AndAlso Not IsDBNull(dr(0)) Then
                Dim withdrawAmount As Decimal = Convert.ToDecimal(dr(0))
                lblBalances.Text = (depositAmount - withdrawAmount).ToString()
            Else
                ' If there are no withdrawal transactions, set the balance to the total deposit amount
                lblBalances.Text = depositAmount.ToString()
            End If
        Else
            ' If there are no deposit transactions, set the balance to "0.00"
            lblBalances.Text = "0.00"
        End If

        ' Close the DataReader
        dr.Close()
    End Sub




    Private Sub btnDeposits_Click(sender As Object, e As EventArgs) Handles btnDeposits.Click
        frmDeposit.Show()
        Call getWithdrawalBalances()
    End Sub

    Private Sub Timers1_Tick(sender As Object, e As EventArgs) Handles Timers1.Tick
        lblDate.Text = Now.ToString
    End Sub

    Private Sub LinkLabels1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabels1.LinkClicked
        Me.Hide()
        ClientLoginFrm.Show()
    End Sub

    Private Sub lblBalances_Click(sender As Object, e As EventArgs) Handles lblBalances.Click

    End Sub

    Private Sub lblTransachistoryy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblTransachistoryy.LinkClicked
        frmhistory.Show()
    End Sub
End Class