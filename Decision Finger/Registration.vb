Public Class Registration
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Please enter the name", MsgBoxStyle.Critical)
            Return
        ElseIf DateTimePicker1.text = "" Then
            MsgBox("Please select the Date of Birth", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter Father's name ", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please enter Mother's name", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox4.Text = "" Then
            MsgBox("Please enter door number", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox5.Text = "" Then
            MsgBox("Please enter Street", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox6.Text = "" Then
            MsgBox("Please enter area", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox7.Text = "" Then
            MsgBox("Please enter Pincode", MsgBoxStyle.Critical)
            Return
        Else
            Registeration2.Show()
            Me.Hide()
        End If
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        Else
            If Len(TextBox1.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        Else
            If Len(TextBox2.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        Else
            If Len(TextBox3.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        Else
            If Len(TextBox6.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Or Char.IsControl(ch) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        TextBox7.MaxLength = 6
    End Sub



    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Or Char.IsControl(ch) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        TextBox4.MaxLength = 3
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        purpose.Show()
        Me.Hide()
    End Sub
End Class