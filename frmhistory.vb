Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmhistory

    Public Property AccountNumber As String

    Public Event TransactionCompleted()

    Private Sub LoadAccounts(accountNumber As String)
        Try
            sql = "SELECT * FROM tblTransaction WHERE AcctNo = @AcctNo"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@AcctNo", accountNumber)
            dr = cmd.ExecuteReader
            lvListOfClients.Items.Clear()
            Dim x As New ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr("AcctNo").ToString)
                x.SubItems.Add(dr("TransNo"))
                x.SubItems.Add(dr("TransType"))
                x.SubItems.Add(dr("TransAmount"))
                x.SubItems.Add(dr("DateTime"))
                lvListOfClients.Items.Add(x)
            Loop
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading transaction history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub FrmTransactionHistoryvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call LoadAccounts(AccountNumber)

        AddHandler frmWithdraw.TransactionCompleted, AddressOf HandleTransactionCompleted
        AddHandler frmDeposit.TransactionCompleted, AddressOf HandleTransactionCompleted
    End Sub

    Private Sub HandleTransactionCompleted()
        LoadAccounts(AccountNumber)
    End Sub

    Private Sub lblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblBack.LinkClicked
        Me.Hide()
        frmClientDashBoard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim printPreviewDialog As New PrintPreviewDialog()
        Dim printDocument As New Printing.PrintDocument()
        printPreviewDialog.Document = printDocument
        printDocument.DefaultPageSettings.Landscape = True

        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        DrawListViewContents(lvListOfClients, e.Graphics, e.MarginBounds)
    End Sub

    Private Sub DrawListViewContents(listView As ListView, graphics As Graphics, bounds As Rectangle)
        Dim yPos As Integer = bounds.Top + 20
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim headerBrush As New SolidBrush(Color.Black)
        Dim borderPen As New Pen(Color.Black, 1)

        Dim x As Integer = bounds.Left + 100


        For Each column As ColumnHeader In listView.Columns
            graphics.DrawString(column.Text, headerFont, headerBrush, x, yPos)
            graphics.DrawRectangle(borderPen, x, yPos, 150, 20)
            x += 150
        Next

        yPos += 20

        Dim itemFont As New Font("Arial", 10)
        Dim itemBrush As New SolidBrush(Color.Black)

        For Each item As ListViewItem In listView.Items
            x = bounds.Left + 100

            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                graphics.DrawString(subItem.Text, itemFont, itemBrush, x, yPos)
                graphics.DrawRectangle(borderPen, x, yPos, 150, 20)
                x += 150
            Next

            yPos += 20
        Next
    End Sub

    Private Sub lvListOfClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvListOfClients.SelectedIndexChanged

    End Sub
End Class
