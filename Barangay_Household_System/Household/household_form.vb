Public Class household_form
    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `household`", household_gridlist)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub refresh_household_Click(sender As Object, e As EventArgs) Handles refresh_household.Click
        reload()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub
    Private Sub household_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub delete_household_Click(sender As Object, e As EventArgs) Handles delete_household.Click
        Try
            delete_data("DELETE FROM `household` WHERE `household_number` ='" & household_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub search_household_TextChanged(sender As Object, e As EventArgs) Handles search_household.TextChanged
        search_data("SELECT * FROM `household` WHERE `household_number` LIKE'%" & search_household.Text & "%' OR `household_family` LIKE'%" & search_household.Text & "%' OR `purok_number` LIKE'%" & search_household.Text & "%'", household_gridlist)
    End Sub

    Private Sub edit_household_Click(sender As Object, e As EventArgs) Handles edit_household.Click

        record_household_update.house_number.Text = household_gridlist.CurrentRow.Cells(0).Value.ToString
        record_household_update.house_family.Text = household_gridlist.CurrentRow.Cells(1).Value.ToString
        record_household_update.purok_number.Text = household_gridlist.CurrentRow.Cells(2).Value.ToString
        record_household_update.Show()
    End Sub

    Private Sub add_household_Click(sender As Object, e As EventArgs) Handles add_household.Click
        record_household_add.Show()
    End Sub
End Class