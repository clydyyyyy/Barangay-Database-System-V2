Public Class user_form
    Private Sub user_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub

    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `user`", user_gridlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub edit_resident_Click(sender As Object, e As EventArgs) Handles edit_resident.Click
        'user_info_edit.user_brgy_id.Text = user_gridlist.CurrentRow.Cells(0).Value.ToString
        'user_info_edit.user_tb.Text = user_gridlist.CurrentRow.Cells(1).Value.ToString
        'user_info_edit.pass_tb.Text = user_gridlist.CurrentRow.Cells(2).Value.ToString

        user_info_edit.user_tb.Text = Caesar_Cipher(user_gridlist.CurrentRow.Cells(0).Value.ToString, 2, False)
        user_info_edit.pass_tb.Text = Caesar_Cipher(user_gridlist.CurrentRow.Cells(1).Value.ToString, 2, False)
        user_info_edit.Show()

    End Sub

    Private Sub add_resident_Click(sender As Object, e As EventArgs) Handles add_resident.Click
        signup_form.Show()

    End Sub

    Private Sub delete_resident_Click(sender As Object, e As EventArgs) Handles delete_resident.Click
        Try
            'delete_data("DELETE FROM `user` WHERE `username` ='" & user_gridlist.CurrentRow.Cells(1).Value.ToString & "'")
            delete_data("DELETE FROM `user` WHERE `username` ='" & user_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub refresh_resident_Click(sender As Object, e As EventArgs) Handles refresh_resident.Click
        reload()
    End Sub

    Private Sub search_user_TextChanged(sender As Object, e As EventArgs) Handles search_user.TextChanged
        'search_data("SELECT * FROM `user` WHERE `official_id` LIKE'%" & search_user.Text & "%' OR `username` LIKE'%" & search_user.Text & "%' OR `password` LIKE'%" & search_user.Text & "%'", user_gridlist)
        search_data("SELECT * FROM `user` WHERE `username` LIKE'%" & search_user.Text & "%' OR `password` LIKE'%" & search_user.Text & "%'", user_gridlist)
    End Sub
End Class