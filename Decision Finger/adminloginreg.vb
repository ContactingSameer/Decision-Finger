Imports System.Data.SqlClient






Public Class adminloginreg

    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-67H8D8M7\SQLEXPRESS;Initial Catalog=Decision_finger;Integrated Security=True")

    Dim cmd As SqlCommand



    Private Sub TextBoxpassusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxadminusername.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True

        Else
            If Len(TextBoxadminusername.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        With CheckBox1

            If .Checked Then
                TextBoxadminpassword.UseSystemPasswordChar = False
            Else
                TextBoxadminpassword.UseSystemPasswordChar = True
            End If

        End With
    End Sub

    Private Sub Buttonpasslogin_Click(sender As Object, e As EventArgs) Handles Buttonadminlogin.Click

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()

        If TextBoxadminusername.Text = "" Then
            MsgBox("Please Enter Admin name..", MsgBoxStyle.Critical)
        ElseIf TextBoxadminpassword.Text = "" Then
            MsgBox("Please Enter password..", MsgBoxStyle.Critical)
        Else
            Dim query As String
            query = "select * from admin_info  where admin_name ='" + TextBoxadminusername.Text + "' and password ='" + TextBoxadminpassword.Text + "'"
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer

            a = ds.Tables(0).Rows.Count 'check if record is empty

            If a = 0 Then
                MsgBox("Login failed!! Enter valid admin name & password", MsgBoxStyle.Critical)
            Else
                purpose.Show()
                Me.Hide()


            End If


        End If


    End Sub

    Private Sub Buttoncancel_Click(sender As Object, e As EventArgs) Handles Buttoncancel.Click
        signup.Show()
        Me.Hide()

    End Sub

    Private Sub adminloginreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class