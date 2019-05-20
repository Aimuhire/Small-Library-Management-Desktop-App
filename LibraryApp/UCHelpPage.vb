Public Class UCHelpPage
    Private Sub llbladd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbladd.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCAddBook")
    End Sub

    Private Sub llbltransfers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbltransfers.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCManageLib")
    End Sub

    Private Sub llbledit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbledit.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCManageLib")
        MainForm.UcBookActions1.tcBookActions.SelectTab(1)
    End Sub

    Private Sub llbldelete_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbldelete.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCManageLib")
        MainForm.UcManageLib1.tbeditdeletetransfer.SelectTab(2)
    End Sub

    Private Sub llblsearch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblsearch.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCBookListForm")
    End Sub

    Private Sub llbllogs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbllogs.LinkClicked
        MainForm.HideAllExcept("LibraryApp.UCLogsList")
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub
End Class
