Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clrTxt()
    End Sub

    Private Sub clrTxt()
        txtStudentName.Clear()
        txtStudentNumber.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        MsgBox("Student Number: " & txtStudentNumber.Text & vbNewLine & "Student Name: " & txtStudentName.Text)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        FrmDisplay.lblStudentNumber.Text = Me.txtStudentNumber.Text
        FrmDisplay.lblStudentName.Text = Me.txtStudentName.Text
        FrmDisplay.Show()


    End Sub
End Class
