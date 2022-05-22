Public Class Form1
    Private Sub log_in_btn_Click(sender As Object, e As EventArgs) Handles log_in_btn.Click

        login_form.Show()
        'Logged_In.Show()
        Me.Hide()

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        user_form.Show()
    End Sub

    Private Sub CloseProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseProgramToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
