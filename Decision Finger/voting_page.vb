Imports System.Data.SqlClient



Public Class voting_page


    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        cmd = New SqlCommand("insert into valid_votes values ('" & Votingverification.TextBox1.Text & "' , '" & Label11.Text & "')", con)
        Dim b As Integer = cmd.ExecuteNonQuery()
        If b = 0 Then
            MsgBox("ERROR")
        Else
            MsgBox("Successfully Voted to Anita", MsgBoxStyle.Information)
            Thanksforvoting.Show()
            Me.Close()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        cmd = New SqlCommand("insert into valid_votes values ('" & Votingverification.TextBox1.Text & "' , '" & Label1.Text & "')", con)
        Dim b As Integer = cmd.ExecuteNonQuery()
        If b = 0 Then
            MsgBox("ERROR")
        Else
            MsgBox("Successfully Voted to Roseline", MsgBoxStyle.Information)
            Thanksforvoting.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        cmd = New SqlCommand("insert into valid_votes values ('" & Votingverification.TextBox1.Text & "' , '" & Label2.Text & "')", con)
        Dim b As Integer = cmd.ExecuteNonQuery()
        If b = 0 Then
            MsgBox("ERROR")
        Else
            MsgBox("Successfully Voted to Veena", MsgBoxStyle.Information)
            Thanksforvoting.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        cmd = New SqlCommand("insert into valid_votes values ('" & Votingverification.TextBox1.Text & "' , '" & Label3.Text & "')", con)
        Dim b As Integer = cmd.ExecuteNonQuery()
        If b = 0 Then
            MsgBox("ERROR")
        Else
            MsgBox("Successfully Voted to Jeelan", MsgBoxStyle.Information)
            Thanksforvoting.Show()
            Me.Close()
        End If
    End Sub
End Class