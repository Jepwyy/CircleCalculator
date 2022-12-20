Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn1.FlatStyle = FlatStyle.Flat
        Btn1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txtD.Text = Val(txtR.Text) * 2
        txtC.Text = 2 * 3.142 * Val(txtR.Text)
        txtA.Text = 3.142 * Val(txtR.Text) ^ 2
    End Sub
End Class
