Imports System.Data.OleDb

Public Class frmClientChangePass
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPin.Text <> txtReEnterPin.Text Then
            MsgBox("PIN and Re-Enter PIN mismatched", MsgBoxStyle.Critical)
        ElseIf txtPin.Text = GetCurrentPin() Then
            MsgBox("This is your current PIN. Please choose a different PIN.", MsgBoxStyle.Exclamation)
        Else
            Call updatepin()
            MsgBox("Pin Successfully Changed", MsgBoxStyle.Information)
            Call clrtxt()
            LogActivity("Password Changed")
        End If
    End Sub

    Private Function GetCurrentPin() As String
        sql = "Select PIN from tblPin where AcctNo=@AcctNo"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AcctNo", txtAccountNumbers.Text)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Return dr("PIN").ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Sub LogActivity(activityType As String)
        sql = "INSERT INTO tblActivityLog([username], [activityType], [timestamp]) VALUES ([@username], [@activityType], [@timestamp])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@username", frmClientDashBoard.lblAcctNo.Text)
            .Parameters.AddWithValue("@activityType", activityType)
            .Parameters.AddWithValue("@timestamp", Now.ToString)
            .ExecuteNonQuery()
        End With

    End Sub

    Private Sub frmClientChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
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

    Private Sub clrtxt()
        txtPin.Clear()
        txtReEnterPin.Clear()
    End Sub

    Private Sub accountnumber()
        txtAccountNumbers.Text = frmClientDashBoard.lblAcctNo.Text
    End Sub

    Private Sub txtAccountNumbers_TextChanged(sender As Object, e As EventArgs) Handles txtAccountNumbers.TextChanged
        Call accountnumber()
    End Sub
End Class