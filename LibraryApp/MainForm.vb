Imports System.Configuration

Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllExcept("LibraryApp.UCLoginForm")
        Me.BackColor = Color.FromArgb(ReadSetting("theme_color"))
    End Sub
    Function ReadSetting(key As String) As String
        Try
            Dim appSettings = ConfigurationManager.AppSettings
            Dim result As String = appSettings(key)
            If IsNothing(result) Then
                result = "Not found"
            End If
            Return result
        Catch e As ConfigurationErrorsException
            ' Console.WriteLine("Error reading app settings")
        End Try
    End Function


    Public Sub HideAllExcept(ByVal ucStr As String)
        For Each cont In Me.Controls

            If ucStr.ToLower = "LibraryApp.UCLoginForm".ToLower And cont.GetType().ToString().ToLower() = "System.Windows.Forms.MenuStrip".ToLower Then
                cont.hide()

            ElseIf cont.GetType().ToString().ToLower() = ucStr.ToLower() Or cont.GetType().ToString().ToLower() = "System.Windows.Forms.MenuStrip".ToLower Then
                cont.show()
            Else
                cont.hide()
            End If
        Next

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCSettings")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        If MsgBox("Are you sure you want exit this Application?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub UcLogsList1_Load(sender As Object, e As EventArgs) Handles UcLogsList1.Load

    End Sub

    Private Sub EditBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditBookToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCManageLib")
        Me.UcManageLib1.tbeditdeletetransfer.SelectTab(1)
    End Sub

    Private Sub DeleteBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteBookToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCManageLib")
        Me.UcManageLib1.tbeditdeletetransfer.SelectTab(2)
    End Sub

    Private Sub TransfersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransfersToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCManageLib")
        Me.UcManageLib1.tbeditdeletetransfer.SelectTab(0)
    End Sub

    Private Sub AddBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBookToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCAddBook")
    End Sub

    Private Sub AdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminPanelToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub BorrowActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowActionToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCBookActions")
        Me.UcBookActions1.tcBookActions.SelectTab(0)
    End Sub

    Private Sub ReturnActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnActionToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCBookActions")
        Me.UcBookActions1.tcBookActions.SelectTab(1)
    End Sub

    Private Sub ManageLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageLibraryToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCManageLib")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCHelpPage")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        HideAllExcept("LibraryApp.UCAboutPage")
    End Sub

    Private Sub SearchBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBooksToolStripMenuItem.Click

        HideAllExcept("LibraryApp.UCBookListForm")
    End Sub
End Class
