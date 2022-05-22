Public Class Logged_In

    Private Sub Logged_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_form("Home")
    End Sub

    Private Sub log_out_btn_Click(sender As Object, e As EventArgs) Handles log_out_btn.Click
        PanelContainer.Controls.Clear()
        change_form("Home")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub openform(form_open As Form)
        PanelContainer.Controls.Clear()
        form_open.TopLevel = False
        form_open.TopMost = True
        form_open.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(form_open)
        form_open.Show()
    End Sub

    Private Sub change_form(menu As String)
        Select Case menu
            Case "Home"
                openform(home_form)
            Case "Resident"
                openform(resident_form)
            Case "Purok"
                openform(purok_form)
            Case "Household"
                openform(household_form)
            Case "Official"
                openform(official_form)
            Case "Transaction"
                openform(transaction_form)
            Case "Statement"
                openform(about_form)
        End Select
    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        change_form("Home")
    End Sub
    Private Sub resident_btn_Click(sender As Object, e As EventArgs) Handles resident_btn.Click
        change_form("Resident")
    End Sub

    Private Sub purok_btn_Click(sender As Object, e As EventArgs) Handles purok_btn.Click
        change_form("Purok")
    End Sub

    Private Sub household_btn_Click(sender As Object, e As EventArgs) Handles household_btn.Click
        change_form("Household")
    End Sub

    Private Sub official_btn_Click(sender As Object, e As EventArgs) Handles official_btn.Click
        change_form("Official")
    End Sub

    Private Sub transaction_btn_Click(sender As Object, e As EventArgs) Handles transaction_btn.Click
        change_form("Transaction")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        change_form("Statement")
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        user_form.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        PanelContainer.Controls.Clear()
        change_form("Home")
        Form1.Show()
        Me.Close()
    End Sub

End Class