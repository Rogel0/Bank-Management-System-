Imports System.Data.OleDb

Public Class frmWithdraw

    Public Event TransactionCompleted()
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Call SaveWithdraw()
    End Sub

    Private Sub SaveWithdraw()
        Dim currentBalance As Decimal = getWithdraw()
        Dim withdrawalAmount As Decimal = Convert.ToDecimal(txtAmount.Text)

        If currentBalance <= 0 OrElse withdrawalAmount > currentBalance Then
            MsgBox("Insufficient balance. You cannot withdraw.", MsgBoxStyle.Exclamation, "Insufficient Balance")
            Return
        End If

        sql = "Insert into tblTransaction([AcctNo],[TransNo],[TransType],[TransAmount],[DateTime])values([@AcctNo],[@TransNo],[@TransType],[@TransAmount],[@DateTime])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
            .Parameters.AddWithValue("@TransNo", "1")
            .Parameters.AddWithValue("@TransType", "Withdraw")
            .Parameters.AddWithValue("@TransAmount", txtAmount.Text)
            .Parameters.AddWithValue("@DateTime", Now.ToString)
            .ExecuteNonQuery()
        End With
        MsgBox("Transaction Complete", MsgBoxStyle.Information, "Successful")
        frmClientDashBoard.lblBalance.Text = getWithdraw().ToString()
        RaiseEvent TransactionCompleted()
    End Sub

    Private Function getWithdraw() As Decimal
        Dim balance As Decimal = 0
        sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
        cmd.Parameters.AddWithValue("@TransType", "Deposit")
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim oldBalance As Decimal = If(Convert.IsDBNull(dr(0)), 0, Convert.ToDecimal(dr(0)))
            Debug.WriteLine("Deposit amount: " & oldBalance)

            sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
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

    Private Sub frmWithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class