Imports System.Data.SqlClient



Public Class Validation



    Private Sub Validation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim conn As New SqlConnection

        conn.ConnectionString = ("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")



        Dim cmd As New SqlCommand(" select count (valid) from Valid_votes ", conn)

        conn.Open()

        Label3.Text = cmd.ExecuteScalar().ToString()

        conn.Close()

        Dim cmd1 As New SqlCommand(" select count (invalid) from invalid_votes  ", conn)

        conn.Open()

        Label4.Text = cmd1.ExecuteScalar().ToString()

        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        purpose.Show()
        Me.Hide()
    End Sub
End Class