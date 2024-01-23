Imports System.Data.OleDb
Public Class frmDeposit

    Public Event TransactionCompleted()
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        If Val(txtAmount.Text) < 50 Then
            MsgBox("The minimum deposit for this transaction is 50.00", MsgBoxStyle.Exclamation)
        Else
            Call SaveDeposit()
        End If
    End Sub
    Private Sub SaveDeposit()
        Call connection()
        sql = "Insert into tblTransaction([AcctNo],[TransNo],[TransType],[TransAmount],[DateTime])values([@AcctNo],[@TransNo],[@TransType],[@TransAmount],[@DateTime])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
            .Parameters.AddWithValue("@TransNo", "1")
            .Parameters.AddWithValue("@TransType", "Deposit")
            .Parameters.AddWithValue("@TransAmount", txtAmount.Text)
            .Parameters.AddWithValue("@DateTime", Now.ToString)
            .ExecuteNonQuery()
        End With
        MsgBox("Transaction Complete", MsgBoxStyle.Information, "Successful")
        frmClientDashBoard.lblBalance.Text = getDeposit().ToString()
        RaiseEvent TransactionCompleted()
    End Sub


    Private Function getDeposit() As Decimal
        Dim balance As Decimal = 0
        sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
        cmd.Parameters.AddWithValue("@TransType", "Deposit")
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Dim oldBalance As Decimal = If(Convert.IsDBNull(dr(0)), 0, Convert.ToDecimal(dr(0)))
            Debug.WriteLine("Deposit amount: " & dr(0))

            sql = "Select sum(TransAmount) from tblTransaction where AcctNo=@AcctNo and TransType=@TransType"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AcctNo", frmClientDashBoard.lblAcctNo.Text)
            cmd.Parameters.AddWithValue("@TransType", "Withdraw")
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim withdrawalAmount As Decimal = If(Convert.IsDBNull(dr(0)), 0, Convert.ToDecimal(dr(0)))
                Debug.WriteLine("Withdraw amount: " & dr(0))
                balance = oldBalance - withdrawalAmount
            End If
        End If
        Debug.WriteLine("Calculated balance: " & balance)
        Return balance
    End Function
    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
End Class