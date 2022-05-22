Public Class record_household_add
    Private Sub household_add_Click(sender As Object, e As EventArgs) Handles household_add.Click

        Try
            create_data("INSERT INTO `household` (`household_number`, `household_family`, `purok_number`) VALUES ('" & house_number.Text & "', '" & house_family.Text & "', '" & purok_number.Text & "');")
            Me.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub record_household_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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