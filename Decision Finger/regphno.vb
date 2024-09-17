Imports System.Data.SqlClient





Public Class regphno


    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registeration2.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter the phone number", MsgBoxStyle.Critical)
        Else




            If con.State = ConnectionState.Open Then con.Close()

            con.Open()
            Dim query As String = "select mobile_no from Voter_info where mobile_no = '" & TextBox1.Text & "' "
            Dim cmd1 As New SqlCommand(query, con)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader
            myreader.Read()
            If myreader.HasRows Then
                MsgBox("Mobile number Already Taken!!", MsgBoxStyle.Critical)
                TextBox1.Text = ""
                myreader.Close()
                con.Close()
            Else
                myreader.Close()

                cmd = New SqlCommand("insert into Voter_info values ('" & Registration.TextBox1.Text & "' , '" & Registration.DateTimePicker1.Value & "','" & Registration.TextBox2.Text & "','" & Registration.TextBox3.Text & "','" & Registration.TextBox4.Text & "','" & Registration.TextBox5.Text & "' , '" & Registration.TextBox6.Text & "','" & Registration.TextBox7.Text & "','" & Registeration2.ComboBox1.SelectedItem & "','" & Registeration2.TextBox1.Text & "','" & Registeration2.TextBox2.Text & "','" & Registration.TextBox3.Text & "','" & Registration.TextBox4.Text & "','" & TextBox1.Text & "')", con)

                Dim a As Integer = cmd.ExecuteNonQuery()
                If a = 0 Then
                    MsgBox("ERROR")
                Else
                    MsgBox("Registered successfully...", MsgBoxStyle.Information)
                    signup.Show()
                    Me.Hide()
                End If
                con.Close()


            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Or Char.IsControl(ch) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        TextBox1.MaxLength = 10
    End Sub

    Private Sub regphno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class