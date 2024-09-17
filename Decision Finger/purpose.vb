Public Class purpose
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registration.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 
        Results.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Validation.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        signup.Show()
        Me.Hide()
    End Sub
End Class