Public Class official_form

    Dim gender As String
    Private Sub search_official_TextChanged(sender As Object, e As EventArgs) Handles search_official.TextChanged
        search_data("SELECT * FROM `barangay official` WHERE `official_id` LIKE'%" & search_official.Text & "%' OR `official_full_name` LIKE'%" & search_official.Text & "%'
                    OR `official_contact` LIKE'%" & search_official.Text & "%' OR `official_gender` LIKE'%" & search_official.Text & "%'
                    OR `official_age` LIKE'%" & search_official.Text & "%' OR `official_position` LIKE'%" & search_official.Text & "%'
                    OR `term_start` LIKE'%" & search_official.Text & "%' OR `term_end` LIKE'%" & search_official.Text & "%'
                    OR `household_number` LIKE'%" & search_official.Text & "%'", official_gridlist)
    End Sub

    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `barangay official`", official_gridlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub official_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub

    Private Sub refresh_official_Click(sender As Object, e As EventArgs) Handles refresh_official.Click
        reload()
    End Sub

    Private Sub delete_official_Click(sender As Object, e As EventArgs) Handles delete_official.Click
        Try
            delete_data("DELETE FROM `barangay official` WHERE `official_id` ='" & official_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub edit_official_Click(sender As Object, e As EventArgs) Handles edit_official.Click
        record_official_update.official_id.Text = official_gridlist.CurrentRow.Cells(0).Value.ToString
        record_official_update.official_full_name.Text = official_gridlist.CurrentRow.Cells(1).Value.ToString
        record_official_update.official_contact.Text = official_gridlist.CurrentRow.Cells(2).Value.ToString


        gender = official_gridlist.CurrentRow.Cells(3).Value.ToString
        If gender = "Male" Then
            record_official_update.gender_male.Checked = True
            record_official_update.gender_female.Checked = False
        ElseIf gender = "Female" Then
            record_official_update.gender_male.Checked = False
            record_official_update.gender_female.Checked = True
        End If
        record_official_update.official_age.Text = official_gridlist.CurrentRow.Cells(4).Value.ToString
        record_official_update.official_position.Text = official_gridlist.CurrentRow.Cells(5).Value.ToString
        record_official_update.official_start.Text = official_gridlist.CurrentRow.Cells(6).Value.ToString
        record_official_update.official_end.Text = official_gridlist.CurrentRow.Cells(7).Value.ToString
        record_official_update.official_household.Text = official_gridlist.CurrentRow.Cells(8).Value.ToString

        record_official_update.Show()

    End Sub

    Private Sub add_official_Click(sender As Object, e As EventArgs) Handles add_official.Click
        record_official_add.Show()

    End Sub
End Class