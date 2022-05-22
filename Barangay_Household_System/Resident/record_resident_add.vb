Public Class record_resident_add

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

    Private Sub resident_add_Click(sender As Object, e As EventArgs) Handles resident_add.Click
        Try
            create_data("INSERT INTO `resident`(`res_id`, `res_full_name`, `res_age`, `res_gender`, `res_birth_date`, `res_birth_place`, `res_citizenship`, `res_marital_status`, `res_religion`, `job`, `household_number`) VALUES ('" & resident_id.Text & "','" & resident_fullname.Text & "','" & resident_age.Text & "','" & genderbind & "','" & resident_dob.Text & "','" & resident_pob.Text & "','" & resident_citizenship.Text & "','" & maritalbind & "','" & resident_religion.Text & "','" & resident_occupation.Text & "','" & resident_household.Text & "')")
            Me.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub record_resident_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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