Public Class record_resident_update

    Dim genderbind As String
    Dim maritalbind As String

    Private Sub gender_male_CheckedChanged(sender As Object, e As EventArgs) Handles gender_male.CheckedChanged
        genderbind = "Male"
    End Sub

    Private Sub gender_female_CheckedChanged(sender As Object, e As EventArgs) Handles gender_female.CheckedChanged
        genderbind = "Male"
    End Sub

    Private Sub marital_single_CheckedChanged_1(sender As Object, e As EventArgs) Handles marital_single.CheckedChanged
        maritalbind = "Single"
        marital_married.CheckState = 0
        marital_widowed.CheckState = 0
        marital_separated.CheckState = 0
    End Sub

    Private Sub marital_married_CheckedChanged_1(sender As Object, e As EventArgs) Handles marital_married.CheckedChanged
        maritalbind = "Married"
        marital_single.CheckState = 0
        marital_widowed.CheckState = 0
        marital_separated.CheckState = 0
    End Sub

    Private Sub marital_widowed_CheckedChanged_1(sender As Object, e As EventArgs) Handles marital_widowed.CheckedChanged
        maritalbind = "Widowed"
        marital_single.CheckState = 0
        marital_married.CheckState = 0
        marital_separated.CheckState = 0
    End Sub

    Private Sub marital_separated_CheckedChanged_1(sender As Object, e As EventArgs) Handles marital_separated.CheckedChanged
        maritalbind = "Separated"
        marital_single.CheckState = 0
        marital_married.CheckState = 0
        marital_widowed.CheckState = 0
    End Sub
    Private Sub resident_update_Click(sender As Object, e As EventArgs) Handles resident_update.Click
        Try
            update_data("UPDATE `resident` SET `res_id`='" & resident_id.Text & "',`res_full_name`='" & resident_fullname.Text & "',`res_age`='" & resident_age.Text & "',`res_gender`='" & genderbind & "',`res_birth_date`='" & resident_dob.Text & "',`res_birth_place`='" & resident_pob.Text & "',`res_citizenship`='" & resident_citizenship.Text & "',`res_marital_status`='" & maritalbind & "',`res_religion`='" & resident_religion.Text & "',`job`='" & resident_occupation.Text & "',`household_number`='" & resident_household.Text & "' WHERE `resident`.`res_id`='" & resident_id.Text & "'")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub record_resident_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            fill_data("SELECT `household_number` FROM `household`", resident_household)
            resident_household.ValueMember = "household_number"
            resident_household.DisplayMember = "household_number"
            connect.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class