Public Class UCaddbook

    Dim thisBook As Book

    Private Sub lblAddBookTitle_Click(sender As Object, e As EventArgs) Handles lblAddBookTitle.Click

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Try
            If tbauthor.Text = "" Or tbbookid.Text = "" Or tbdescription.Text = "" Or cbcondition.Text = "" Then
                MessageBox.Show("Please fill required fields.")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        thisBook = New Book(tbtitle.Text, tbauthor.Text)
        thisBook.Isbn = tbisbn.Text
        thisBook.Bookid = tbbookid.Text
        thisBook.Condition = cbcondition.Text
        thisBook.Description = tbdescription.Text
        thisBook.Pages = nudpages.Value




        If (thisBook.SaveBook()) Then
            MessageBox.Show("Book saved successfully!")
            MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")

        Else
            MessageBox.Show("Error: The application could not save the book.")
        End If

    End Sub


    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
