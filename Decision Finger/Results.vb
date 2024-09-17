Imports System.Data.SqlClient






Public Class Results
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

    Dim cmd As SqlCommand
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Dim conn As New SqlConnection

        'con.ConnectionString = ("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

        'conn.Open()





        Dim cmd As New SqlCommand(" select count (valid) from Valid_votes where voted_for='" + Label11.Text + "'  ", con)

        con.Open()

        Label4.Text = cmd.ExecuteScalar().ToString()

        con.Close()


        Dim cmd1 As New SqlCommand(" select count (valid) from Valid_votes where voted_for='" + Label1.Text + "'  ", con)


        con.Open()

        Label5.Text = cmd1.ExecuteScalar().ToString()

        con.Close()

        Dim cmd2 As New SqlCommand(" select count (valid) from Valid_votes where voted_for='" + Label2.Text + "'  ", con)

        con.Open()

        Label6.Text = cmd2.ExecuteScalar().ToString()

        con.Close()

        Dim cmd3 As New SqlCommand(" select count (valid) from Valid_votes where voted_for='" + Label3.Text + "'  ", con)

        con.Open()

        Label7.Text = cmd3.ExecuteScalar().ToString()
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        purpose.Show()
        Me.Hide()
    End Sub
End Class