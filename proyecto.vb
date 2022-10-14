Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "bago@bago.com" And TextBox2.Text = "123" Then
            Form2.Show()
            TextBox1.Text = "" And TextBox2.Text = " "
        Else
            MsgBox("incorrecto :(")


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ("")
        TextBox2.Text = ("")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub
End Class
