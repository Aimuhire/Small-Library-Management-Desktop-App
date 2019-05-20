Public Class UCAdminPanelForm
    Private Sub UcLoginForm1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        MainForm.HideAllExcept("LibraryApp.UCLoginForm")

    End Sub

    Private Sub lbllogout_Click(sender As Object, e As EventArgs) Handles lbllogout.Click
        btnlogout_Click(sender, e)
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        MainForm.HideAllExcept("LibraryApp.UCaddbook")

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        MainForm.HideAllExcept("LibraryApp.UCBookListForm")

    End Sub

    Private Sub btnbookactions_Click(sender As Object, e As EventArgs) Handles btnbookactions.Click
        MainForm.HideAllExcept("LibraryApp.UCBookActions")
    End Sub



    Private Sub UCAdminPanelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        MainForm.HideAllExcept("LibraryApp.UCSettings")
    End Sub

    Private Sub btnTransfers_Click(sender As Object, e As EventArgs) Handles btnTransfers.Click
        MainForm.HideAllExcept("LibraryApp.UCManageLib")
    End Sub

    Private Sub btnreports_Click(sender As Object, e As EventArgs) Handles btnreports.Click
        MainForm.HideAllExcept("LibraryApp.UCStats")
    End Sub
End Class
