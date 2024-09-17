Imports System.Data.SqlClient



Public Class Votingverification

    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

    Dim cmd As SqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        If TextBox1.Text = "" Then
            MsgBox("Please Enter Registered Phone number", MsgBoxStyle.Critical)

        Else
            Dim query As String
            query = "select * from Voter_info  where mobile_no ='" + TextBox1.Text + "' "
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer

            a = ds.Tables(0).Rows.Count 'check if record is empty

            If a = 0 Then
                MsgBox("Given phone number is not registered or Invalid!!", MsgBoxStyle.Critical)

                cmd = New SqlCommand("insert into invalid_votes values ('" & TextBox1.Text & "' )", con)
                Dim b As Integer = cmd.ExecuteNonQuery()
                If b = 0 Then
                    MsgBox("ERROR")
                Else
                    MsgBox("Given phone number is not registered or Invalid!!", MsgBoxStyle.Critical)
                End If
            Else

                voting_page.Show()
                Me.Hide()


            End If
        End If

    End Sub
End Class