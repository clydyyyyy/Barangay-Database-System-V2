Public Class transaction_form
    Public Sub reload()
        Try
            display_to_table("SELECT * FROM `transaction`", transaction_gridlist)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub refresh_transaction_Click(sender As Object, e As EventArgs) Handles refresh_transaction.Click
        reload()
    End Sub

    Private Sub transaction_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload()
    End Sub

    Private Sub delete_transaction_Click(sender As Object, e As EventArgs) Handles delete_transaction.Click
        Try
            delete_data("DELETE FROM `transaction` WHERE `transaction_number` ='" & transaction_gridlist.CurrentRow.Cells(0).Value.ToString & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub search_transaction_TextChanged(sender As Object, e As EventArgs) Handles search_transaction.TextChanged
        search_data("SELECT * FROM `transaction` WHERE `transaction_number` LIKE'%" & search_transaction.Text & "%' OR `transaction_date` LIKE'%" & search_transaction.Text & "%'
        OR `purpose_of_use` LIKE'%" & search_transaction.Text & "% OR `cost` LIKE'%" & search_transaction.Text & "%'
        OR `res_id` LIKE'%" & search_transaction.Text & "%''", transaction_gridlist)
    End Sub

    Private Sub edit_transaction_Click(sender As Object, e As EventArgs) Handles edit_transaction.Click
        record_transaction_update.transaction_number.Text = transaction_gridlist.CurrentRow.Cells(0).Value.ToString
        record_transaction_update.transaction_purpose.Text = transaction_gridlist.CurrentRow.Cells(2).Value.ToString
        record_transaction_update.transaction_cost.Text = transaction_gridlist.CurrentRow.Cells(3).Value.ToString
        record_transaction_update.transaction_date.Text = transaction_gridlist.CurrentRow.Cells(1).Value.ToString
        record_transaction_update.resident_id.Text = transaction_gridlist.CurrentRow.Cells(4).Value.ToString
        record_transaction_update.Show()
    End Sub

    Private Sub add_transaction_Click(sender As Object, e As EventArgs) Handles add_transaction.Click
        record_transaction_add.Show()
    End Sub

    Private Sub print_transaction_Click(sender As Object, e As EventArgs) Handles print_transaction.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim gm As New Bitmap(Me.transaction_gridlist.Width, Me.transaction_gridlist.Height)
        Dim pm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(pm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        transaction_gridlist.DrawToBitmap(gm, New Rectangle(10, 10, Me.transaction_gridlist.Width, Me.transaction_gridlist.Height))
        e.Graphics.DrawImage(gm, 0, 60)
        e.Graphics.DrawImage(pm, 0, 0)
    End Sub

End Class