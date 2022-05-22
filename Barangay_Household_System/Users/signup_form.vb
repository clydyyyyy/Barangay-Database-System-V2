
Public Class signup_form

    Private Sub log_btn_Click(sender As Object, e As EventArgs) Handles log_btn.Click
        Try

            'create_data("INSERT INTO `user`(`official_id`, `username`, `password`) VALUES ('" & user_brgy_id.Text & "','" & user_tb.Text & "','" & pass_tb.Text & "')")
            create_data("INSERT INTO `user`(`username`, `password`) VALUES ('" & Caesar_Cipher(user_tb.Text, 2, True) & "','" & Caesar_Cipher(pass_tb.Text, 2, True) & "')")

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class