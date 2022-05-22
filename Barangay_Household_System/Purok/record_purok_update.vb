Public Class record_purok_update
    Private Sub purok_update_Click(sender As Object, e As EventArgs) Handles purok_update.Click
        Try
            update_data("UPDATE `purok` SET `purok_number`='" & purok_tb.Text & "',`street_name`='" & street_tb.Text & "' WHERE `purok_number`='" & purok_tb.Text & "' OR `street_name`='" & street_tb.Text & "'")
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