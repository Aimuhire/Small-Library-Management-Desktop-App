Public Class UCBookActions

    Private Sub btnborrow_Click(sender As Object, e As EventArgs) Handles btnborrow.Click
        Dim academicYear As Integer
        Integer.TryParse(nudAcademicYear.Value, academicYear)
        Dim thisBook As New Book()
        thisBook.Condition = cbborrowcondition.Text
        thisBook.Bookid = tbborrowBookId.Text

        If Not thisBook.BorrowBook(tbregno.Text, academicYear) Then
            MessageBox.Show(" Action failed. Please try again later. ")
            Exit Sub
        End If
        MessageBox.Show("Book with id: " & tbborrowBookId.Text & " Borrowed to student with registration number: " & tbregno.Text)
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")


    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")

    End Sub

    Private Sub UCBookActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click


        Dim thisBook As New Book()
        thisBook.Condition = cbreturncondition.Text
        thisBook.Bookid = tbreturnbookid.Text

        If Not thisBook.ReturnBook() Then
            MessageBox.Show(" Action failed. Please try again later. ")
            Exit Sub
        End If
        MessageBox.Show("Book with id: " & tbreturnbookid.Text & " Returned.")
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub tpBorrowBook_Click(sender As Object, e As EventArgs) Handles tpBorrowBook.Click

    End Sub
End Class
