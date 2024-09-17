Imports System.Text.RegularExpressions
Imports System.Data.SqlClient




Public Class Registeration2


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Registration.Show()
        Me.Hide()

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim p As String
        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"


        If ComboBox1.SelectedItem = "" Then
            MsgBox("Please select the gender", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox1.Text = "" Then
            MsgBox("Please enter Marital Status", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please enter nationality", MsgBoxStyle.Critical)
            Return
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please enter Your Mail id", MsgBoxStyle.Critical)
            Return
        Else

            If Regex.IsMatch(TextBox3.Text, p) Then

                regphno.Show()
                Me.Hide()

            Else
                MsgBox("Invalid Email!!", MsgBoxStyle.Critical)
                Return

            End If
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Or Char.IsControl(ch) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        TextBox4.MaxLength = 12
    End Sub

    Private Sub Registeration2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class