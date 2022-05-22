Public Class record_official_update

    Dim genderbind As String

    Private Sub gender_male_CheckedChanged(sender As Object, e As EventArgs) Handles gender_male.CheckedChanged
        genderbind = "Male"
    End Sub

    Private Sub gender_female_CheckedChanged(sender As Object, e As EventArgs) Handles gender_female.CheckedChanged
        genderbind = "Male"
    End Sub

    Private Sub official_update_Click(sender As Object, e As EventArgs) Handles official_update.Click
        Try
            update_data("UPDATE `barangay official` SET `official_full_name` = '" & official_full_name.Text & "', `official_contact` = '" & official_contact.Text & "', `official_gender` = '" & genderbind & "', `official_age` = '" & official_age.Text & "', `official_position` = '" & official_position.Text & "', `term_start` = '" & official_start.Text & "', `term_end` = '" & official_end.Text & "', `household_number` = '" & official_household.Text & "' WHERE `barangay official`.`official_id` = '" & official_id.Text & "';")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub record_official_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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