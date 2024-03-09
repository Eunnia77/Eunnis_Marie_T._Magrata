Public Class Form1
    Dim firstval As Double
    Dim secondval As Double
    Dim [Operator] As String
    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.Text

    End Sub

    Private Sub equal_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        txt_total.Text = ""
        txt_total.Focus()
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "+"
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub minus_btn_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "-"
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub divide_btn_Click(sender As Object, e As EventArgs) Handles divide_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "/"
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub times_btn_Click(sender As Object, e As EventArgs) Handles times_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "*"
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub clear_tab_Click(sender As Object, e As EventArgs) Handles clear_tab.Click
        txt_total.Text ""
        txt_total.Focus()
    End Sub
End Class
