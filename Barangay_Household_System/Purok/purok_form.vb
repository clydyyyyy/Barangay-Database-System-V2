Public Class purok_form
    Private Sub refresh_purok_Click(sender As Object, e As EventArgs) Handles refresh_purok.Click
        reload()
    End Sub

    Private Sub purok_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub

    Private Sub edit_purok_Click(sender As Object, e As EventArgs) Handles edit_purok.Click
        record_purok_update.purok_tb.Text = purok_gridlist.CurrentRow.Cells(0).Value.ToString
        record_purok_update.street_tb.Text = purok_gridlist.CurrentRow.Cells(1).Value.ToString
        record_purok_update.Show()
    End Sub

    Private Sub search_purok_TextChanged(sender As Object, e As EventArgs) Handles search_purok.TextChanged
        search_data("SELECT * FROM `purok` WHERE `purok_number` LIKE'%" & search_purok.Text & "%' OR `street_name` LIKE'%" & search_purok.Text & "%'", purok_gridlist)

    End Sub

    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `purok`", purok_gridlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub delete_purok_Click(sender As Object, e As EventArgs) Handles delete_purok.Click
        Try
            delete_data("DELETE FROM `purok` WHERE `purok_number` ='" & purok_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub add_purok_Click(sender As Object, e As EventArgs) Handles add_purok.Click
        record_purok_add.Show()
    End Sub

End Class