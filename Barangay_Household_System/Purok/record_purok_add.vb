Public Class record_purok_add

    Private Sub log_btn_Click(sender As Object, e As EventArgs) Handles purok_add.Click
        Try

            create_data("INSERT INTO `purok`(`purok_number`, `street_name`) VALUES ('" & purok_number.Text & "','" & street_name.Text & "')")
            Me.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
End Class