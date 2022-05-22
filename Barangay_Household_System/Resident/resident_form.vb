Public Class resident_form

    Dim gender As String
    Dim marital_status As String
    Private Sub add_resident_Click(sender As Object, e As EventArgs) Handles add_resident.Click
        record_resident_add.Show()
    End Sub

    Private Sub edit_resident_Click(sender As Object, e As EventArgs) Handles edit_resident.Click
        record_resident_update.resident_id.Text = resident_gridlist.CurrentRow.Cells(0).Value.ToString
        record_resident_update.resident_fullname.Text = resident_gridlist.CurrentRow.Cells(1).Value.ToString
        record_resident_update.resident_age.Text = resident_gridlist.CurrentRow.Cells(2).Value.ToString

        gender = resident_gridlist.CurrentRow.Cells(3).Value.ToString
        If gender = "Male" Then
            record_resident_update.gender_male.Checked = True
            record_resident_update.gender_female.Checked = False
        ElseIf gender = "Female" Then
            record_resident_update.gender_male.Checked = False
            record_resident_update.gender_female.Checked = True
        End If
        record_resident_update.resident_dob.Text = resident_gridlist.CurrentRow.Cells(4).Value.ToString
        record_resident_update.resident_pob.Text = resident_gridlist.CurrentRow.Cells(5).Value.ToString
        record_resident_update.resident_citizenship.Text = resident_gridlist.CurrentRow.Cells(6).Value.ToString

        marital_status = resident_gridlist.CurrentRow.Cells(7).Value.ToString
        If marital_status = "Single" Then
            record_resident_update.marital_single.Checked = True
            record_resident_update.marital_married.Checked = False
            record_resident_update.marital_widowed.Checked = False
            record_resident_update.marital_separated.Checked = False
        ElseIf marital_status = "Married" Then
            record_resident_update.marital_single.Checked = False
            record_resident_update.marital_married.Checked = True
            record_resident_update.marital_widowed.Checked = False
            record_resident_update.marital_separated.Checked = False
        ElseIf marital_status = "Widowed" Then
            record_resident_update.marital_single.Checked = False
            record_resident_update.marital_married.Checked = False
            record_resident_update.marital_widowed.Checked = True
            record_resident_update.marital_separated.Checked = False
        ElseIf marital_status = "Separated" Then
            record_resident_update.marital_single.Checked = False
            record_resident_update.marital_married.Checked = False
            record_resident_update.marital_widowed.Checked = False
            record_resident_update.marital_separated.Checked = True
        End If

        record_resident_update.resident_religion.Text = resident_gridlist.CurrentRow.Cells(8).Value.ToString
        record_resident_update.resident_occupation.Text = resident_gridlist.CurrentRow.Cells(9).Value.ToString
        record_resident_update.resident_household.Text = resident_gridlist.CurrentRow.Cells(10).Value.ToString

        record_resident_update.Show()
    End Sub

    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `resident`", resident_gridlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub resident_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub refresh_resident_Click(sender As Object, e As EventArgs) Handles refresh_resident.Click
        reload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub

    Private Sub delete_resident_Click(sender As Object, e As EventArgs) Handles delete_resident.Click
        Try
            delete_data("DELETE FROM `resident` WHERE `res_id` ='" & resident_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub search_resident_TextChanged(sender As Object, e As EventArgs) Handles search_resident.TextChanged
        search_data("SELECT * FROM `resident` WHERE `res_id` LIKE'%" & search_resident.Text & "%' OR `res_full_name` LIKE'%" & search_resident.Text & "%'
                    OR `res_age` LIKE'%" & search_resident.Text & "%' OR `res_gender` LIKE'%" & search_resident.Text & "%'
                    OR `res_birth_date` LIKE'%" & search_resident.Text & "%' OR `res_birth_place` LIKE'%" & search_resident.Text & "%'
                    OR `res_citizenship` LIKE'%" & search_resident.Text & "%' OR `res_marital_status` LIKE'%" & search_resident.Text & "%'
                    OR `res_religion` LIKE'%" & search_resident.Text & "%' OR `job` LIKE'%" & search_resident.Text & "%'
                    OR `household_number` LIKE'%" & search_resident.Text & "%'", resident_gridlist)
    End Sub
End Class