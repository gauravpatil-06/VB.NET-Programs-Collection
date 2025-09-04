Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox1.Text = ListBox1.SelectedIndex
        TextBox2.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = ListBox1.Items.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer
        x = TextBox4.Text
        ListBox1.Items.RemoveAt(x)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String
        str = TextBox5.Text
        ListBox1.Items.Add(str)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox6.Text = "Your Favorite Language: " + ComboBox1.SelectedItem
    End Sub
End Class
