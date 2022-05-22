Public Class record_household_update
    Private Sub household_update_Click(sender As Object, e As EventArgs) Handles household_update.Click
        Try
            update_data("UPDATE `household` SET `household_number`='" & house_number.Text & "',`household_family`='" & house_family.Text & "',`purok_number`='" & purok_number.Text & "' WHERE `household_number`='" & house_number.Text & "' OR `household_family`='" & house_family.Text & "' OR `purok_number`='" & purok_number.Text & "'")
            Me.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub record_household_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fill_data("SELECT `purok_number` FROM `purok`", purok_number)
            purok_number.ValueMember = "purok_number"
            purok_number.DisplayMember = "purok_number"
            connect.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
End Class