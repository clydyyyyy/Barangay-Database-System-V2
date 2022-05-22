Imports MySql.Data.MySqlClient
Public Class login_form

    Dim dadapt As MySqlDataAdapter


    Private Sub log_btn_Click(sender As Object, e As EventArgs) Handles log_btn.Click

        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `user` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Caesar_Cipher(user_tb.Text, 2, True)
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Caesar_Cipher(pass_tb.Text, 2, True)
        'command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user_tb.Text
        'command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass_tb.Text


        Dim dadapt As New MySqlDataAdapter(command)
        Dim dtable As New DataTable()

        dadapt.Fill(dtable)
        If dtable.Rows.Count = 0 Then
            MessageBox.Show("Invalid log in")
        Else
            Form1.Hide()
            Me.Close()
            Logged_In.Show()
        End If
        connection.Close()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class