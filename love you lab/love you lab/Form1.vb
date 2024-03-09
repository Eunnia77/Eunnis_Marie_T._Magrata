Public Class Form1
    Private Sub Evaluate_btn_Click(sender As Object, e As EventArgs) Handles Evaluate_btn.Click
        Dim Age As Integer = Convert.ToDecimal(Age_txtbox.Text)
        If Age >= 100 Then
            MsgBox("DINOSAUR Age")
        ElseIf Age >= 90 Then
            MsgBox("Century Age")
        ElseIf Age >= 80 Then
            MsgBox("GrandFather Age")
        ElseIf Age >= 60 Then
            MsgBox("Senior Citizen Age")
        ElseIf Age >= 45 Then
            MsgBox("Middle Age")
        ElseIf Age >= 30 Then
            MsgBox(" Young")
        Else
            MsgBox("Unknown Age")
        End If

    End Sub '    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Private Sub Age_txtbox_TextChanged(sender As Object, e As EventArgs) Handles Age_txtbox.TextChanged

    End Sub '        Dim Victor As String = "Hi"
    '        Dim Age As Integer = 21
    '        Const Maxsize As Integer = 999

    '        Dim StringVar As String
    '        Dim IntVar As Integer
    '        Dim BooleanVar As Boolean
    '        Dim DecimalVar As Decimal

    '        StringVar = "this is string"
    '        IntVar = 708205
    '        BooleanVar = False
    '        DecimalVar = 78.210605


    '        'WRITE COMMENTS USING SINGLE '


    '        'ARITHMETIC OPERATORS
    '        Age = Age + 34
    '        Age = Age = 10
    '        Age = Age / 34
    '        Age = Age * 20


    '        'ASSIGNMENT OPERATORS
    '        Dim Firstname As String
    '        Firstname = "inserting value using Equal (=) assignment operator"
    '        'COMPARISON OPERATORS
    '        ' =
    '        If (1 = 1) Then
    '            MsgBox("TRUE")
    '        End If
    '        ' <> not equal
    '        If (45 <> 78) Then
    '            MsgBox("TRUE")
    '        End If
    '        ' greaterthan
    '        If (100 > 85) Then
    '            MsgBox("TRUE")
    '        End If
    '        'Lessthan
    '        If (35 < 65) Then
    '            MsgBox("TRUE")
    '        End If

    '        'greaterthan equal
    '        If (100 >= 99) Then
    '            MsgBox("TRUE")
    '        End If

    '        'lessthan qual
    '        If (100 <= 101) Then
    '            MsgBox("TRUE")
    '        End If

    '        'logical operator
    '        'AND
    '        Dim price As Integer = 25
    '        If price > 20 And price > 0 Then
    '            MsgBox("TRUE")
    '        End If

    '        'OR
    '        If price < 10 Or price > 0 Then
    '            MsgBox(price < 10 Or price > 0)
    '        End If

    '        Age = 10
    '        If Age = 10 Then
    '            'TRUE
    '            MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")

    '        End If

    '        Age = 10
    '        If Age = 11 Then
    '            'TRUE
    '            MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")
    '        Else
    '            'FALSE
    '            MessageBox.Show("ITS FALSE, AGE IS NOT EQUAL TO 10")
    '        End If

    '        Age = 10
    '        If Age = 10 Then
    '            If Age > 9 Then
    '                'TRUE
    '                MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10 & greaterthan 0")

    '                If Age > 0 Then
    '                    'TRUE
    '                    MessageBox.Show("ITS TRUE age is greatert than 0")
    '                End If
    '            End If
    '        Else
    '            If Age > 11 Then
    '                'FALSE 
    '                MessageBox.Show("ITS FALSE, AGE IS NOT greater than to 11")
    '            End If

    '            Dim grade As Char
    '            grade = "B"
    '            Select Case grade
    '                Case "A"
    '                    MessageBox.Show("Excellent!")
    '                Case "B", "C"
    '                    MessageBox.Show("Well Done")
    '                Case "D"
    '                    MessageBox.Show("You Passed")
    '                Case "F"
    '                    MessageBox.Show("Better Try Again")
    '                Case Else
    '                    MessageBox.Show("Invalid Grade")
    '            End Select
    '    End Sub
End Class
