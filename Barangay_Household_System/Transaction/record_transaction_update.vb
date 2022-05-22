Public Class record_transaction_update
    Private Sub transaction_update_Click(sender As Object, e As EventArgs) Handles transaction_update.Click
        Try
            'update_data("UPDATE `transaction` SET `transaction_number`='" & transaction_number.Text & "',`transaction_date`='" & transaction_date.Text & "',`purpose_of_use`='" & transaction_purpose.Text & "',`cost`='" & transaction_cost.Text & "',`res_id`='" & resident_id.Text & "' WHERE `transaction_number`='" & transaction_number.Text & "")
            update_data("UPDATE `transaction` SET `transaction_number`='" & transaction_number.Text & "',`transaction_date`='" & transaction_date.Text & "',`purpose_of_use`='" & transaction_purpose.Text & "',`cost`='" & transaction_cost.Text & "',`res_id`='" & resident_id.Text & "' WHERE `transaction_number`='" & transaction_number.Text & "'")
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