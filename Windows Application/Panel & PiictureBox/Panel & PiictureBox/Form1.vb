Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("You have clicked Submit Button")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("You have clicked Cancel Button")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = Image.FromFile("C:\Personal File\Photos\Edit Photo\IMG_20230922_001128_0569.jpg")
    End Sub
End Class
