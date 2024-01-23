Imports System.Data.OleDb
Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\gerod\Desktop\IPT-31A1-GERODIAZ\bin\Debug\Gerodiaz_IPT-31A1-DATABASE.accdb"
        cn.Open()
        'MsgBox("Connection Success", MsgBoxStyle.Information, "Database Connection")
    End Sub
End Module