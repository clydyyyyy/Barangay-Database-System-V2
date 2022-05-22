Public Class record_official_add

    Dim genderbind As String

    Private Sub gender_male_CheckedChanged(sender As Object, e As EventArgs) Handles gender_male.CheckedChanged
        genderbind = "Male"
    End Sub

    Private Sub gender_female_CheckedChanged(sender As Object, e As EventArgs) Handles gender_female.CheckedChanged
        genderbind = "Male"
    End Sub
    Private Sub add_record_res_db_Click(sender As Object, e As EventArgs) Handles official_add.Click
        Try
            create_data("INSERT INTO `barangay official` (`official_id`, `official_full_name`, `official_contact`, `official_gender`, `official_age`, `official_position`, `term_start`, `term_end`, `household_number`) VALUES ('" & official_id.Text & "', '" & official_full_name.Text & "', '" & official_contact.Text & "', '" & genderbind & "', '" & official_age.Text & "', '" & official_position.Text & "', '" & official_start.Text & "', '" & official_end.Text & "', '" & official_household.Text & "')")
            Me.Hide()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub record_official_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fill_data("SELECT `household_number` FROM `household`", official_household)
            official_household.ValueMember = "household_number"
            official_household.DisplayMember = "household_number"
            connect.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class