Public Class Form1

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text = "You are Favorite Language: " + Button10.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = "You are Favorite Language:" + Button6.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text = "You are Favorite Language:" + Button7.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = "You are Favorite Language: " + Button8.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text = "You are Favorite Language:" + Button9.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = "You are Favorite Language: " + Button11.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "You are Favorite Colour:" + RadioButton1.Text
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Text = "You are Favorite Colour: " + RadioButton4.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Text = "You are Favorite Colour:" + RadioButton2.Text
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.Text = "You are Favorite Colour: " + RadioButton5.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Text = "You are Favorite Colour: " + RadioButton3.Text
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.Text = "You are Favorite Colour: " + RadioButton6.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = "Branch: " + Button1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = "Branch: " + Button2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = "Branch: " + Button3.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = "Branch: " + Button4.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = "Branch: " + Button5.Text
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox3.Text = "Branch: " + Button12.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox1.Image = Image.FromFile("C:\Personal File\Photos\Edit Photo\IMG_20230922_001128_0569.jpg")
    End Sub
End Class
