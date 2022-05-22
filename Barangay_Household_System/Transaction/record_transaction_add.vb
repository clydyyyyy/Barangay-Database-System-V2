Public Class record_transaction_add
    Private Sub transaction_add_Click(sender As Object, e As EventArgs) Handles transaction_add.Click
        Try

            create_data("INSERT INTO `transaction`(`transaction_number`, `transaction_date`, `purpose_of_use`, `cost`, `res_id`) VALUES ('" & transaction_number.Text & "','" & transaction_date.Text & "','" & transaction_purpose.Text & "','" & transaction_cost.Text & "','" & resident_id.Text & "')")
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