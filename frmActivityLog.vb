Imports System.Data.OleDb

Public Class frmActivityLog

    Public Property AccountNumber As String


    Private Sub lvListOfClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListOfClients.SelectedIndexChanged

    End Sub

    Private Sub LoadAccounts()
        sql = "SELECT * FROM tblActivityLog WHERE username = @username"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.AddWithValue("@username", AccountNumber)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        lvListOfClients.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr("username").ToString)
            x.SubItems.Add(dr("activityType").ToString)
            x.SubItems.Add(dr("timestamp").ToString)
            lvListOfClients.Items.Add(x)
        Loop
    End Sub

    Private Sub frmActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccounts()
    End Sub
End Class