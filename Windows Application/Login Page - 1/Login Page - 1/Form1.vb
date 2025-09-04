Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If (username.Equals("Gaurav") And password.Equals("Gaurav")) Then
            MsgBox("You are Login Successfully!!!")
        Else
            MsgBox("You are Login fail!!!")
        End If
    End Sub
End Class
