Public Class Form1
    Dim firstval As Double
    Dim secondval As Double
    Dim [Operator] As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        Dim firstVal = Val(txt_total.Text)
        [Operator] = "-"
        txt_total.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub ass_btn_Click(sender As Object, e As EventArgs) Handles ass_btn.Click
        firstval = Val(txt_total.Text)
        [Operator] = "+"
        txt_total.Text = ""
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        txt_total.Text = ""
    End Sub

    Private Sub product_btn_Click(sender As Object, e As EventArgs) Handles product_btn.Click
        firstval = Val(txt_total.Text)
        [Operator] = "*"
        txt_total.Text = ""
    End Sub

    Private Sub divide_btn_Click(sender As Object, e As EventArgs) Handles divide_btn.Click
        firstval = Val(txt_total.Text)
        [Operator] = "/"
        txt_total.Text = ""
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub equal_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + secondval
                txt_total.Text = Result.ToString()
            Case = "-"
                Result = firstval - secondval
                txt_total.Text = Result.ToString()
            Case = "*"
                Result = firstval * secondval
                txt_total.Text = Result.ToString()
            Case = "/"
                Result = firstval / secondval
                txt_total.Text = Result.ToString
        End Select
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.text
    End Sub
End Class
