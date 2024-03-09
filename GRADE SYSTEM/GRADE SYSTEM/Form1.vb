Public Class Form1
    Private Sub Evaluate_tbn_Click(sender As Object, e As EventArgs) Handles Evaluate_tbn.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim Grade As Double

        math = Val(Mathtxtbox_tbn.Text)
        science = Val(Sciencetxtbox_tbn.Text)
        english = Val(Englishtxtbox_tbn.Text)

        Grade = (math + science + english)
        Grade = Grade / 3

        If Grade >= 90 Then
            MsgBox("A+")
        ElseIf Grade >= 80 Then
            MsgBox("B+")
        ElseIf Grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("Failed")
        End If
    End Sub
End Class
