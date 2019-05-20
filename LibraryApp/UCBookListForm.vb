
Public Class UCBookListForm

    Private Sub UCBookListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ev As New LinkLabelLinkClickedEventArgs(New LinkLabel.Link)
            rbtitle.Checked = True
            llblall_LinkClicked(sender, ev)


        Catch ex As Exception
            'MessageBox.Show("Some error")
        End Try

    End Sub

    Private Sub UCBookListForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        UCBookListForm_Load(sender, e)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub tbsearch_TextChanged(sender As Object, e As EventArgs) Handles tbsearch.TextChanged

    End Sub

    Private Sub llblall_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblall.LinkClicked
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetAllBooks()
        PopulateDataGridView(books)

    End Sub

    Private Sub PopulateDataGridView(ByVal books As List(Of Dictionary(Of String, String)))
        Try

            dgvBooks.Rows.Clear()
            dgvBooks.ColumnCount = 12
            dgvBooks.Columns(0).Name = "#"
            dgvBooks.Columns(1).Name = "Title"
            dgvBooks.Columns(2).Name = "Author"
            dgvBooks.Columns(3).Name = "Book ID"
            dgvBooks.Columns(4).Name = "Status"
            dgvBooks.Columns(5).Name = "Description"
            dgvBooks.Columns(6).Name = "Published"
            dgvBooks.Columns(7).Name = "Pages"
            dgvBooks.Columns(8).Name = "ISBN"
            dgvBooks.Columns(9).Name = "Added By"
            dgvBooks.Columns(10).Name = "Added Date"
            dgvBooks.Columns(11).Name = "Condition"

            Dim bookNumber As Integer = 1
            For Each book In books

                Dim row As String() = {
                bookNumber,
                book.Item("title"),
                book.Item("author"),
                book.Item("bookId"),
                book.Item("status"),
                book.Item("description"),
                book.Item("publicationDate"),
                book.Item("pages"),
                book.Item("ISBN"),
                book.Item("addedBy"),
                book.Item("addedDate"),
                book.Item("condition")
                    }
                dgvBooks.Rows.Add(row)
                bookNumber += 1

            Next
        Catch ex As Exception
            MessageBox.Show("Error: Could not load books." & ex.Message)
        End Try
    End Sub


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click


        DbSearcher.FlagTitle = rbtitle.Checked()
        DbSearcher.FlagAuthor = rbauthor.Checked()
        DbSearcher.FlagDescription = rbdescription.Checked()
        DbSearcher.FlagISBN = rbisbn.Checked()
        DbSearcher.FlagBookId = rbbookid.Checked()

        DbSearcher.SearchQuerry = tbsearch.Text
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetSearchResults()

        PopulateDataGridView(books)

    End Sub

    Private Sub llblavailable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblavailable.LinkClicked
        DbSearcher.FlagTitle = False
        DbSearcher.FlagAuthor = False
        DbSearcher.FlagDescription = False
        DbSearcher.FlagISBN = False
        DbSearcher.FlagBookId = False
        DbSearcher.FlagAvailable = True
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetSearchResults()

        PopulateDataGridView(books)
    End Sub

    Private Sub llblborrowed_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblborrowed.LinkClicked
        DbSearcher.FlagTitle = False
        DbSearcher.FlagAuthor = False
        DbSearcher.FlagDescription = False
        DbSearcher.FlagISBN = False
        DbSearcher.FlagBookId = False
        DbSearcher.FlagAvailable = True
        DbSearcher.FlagBorrowed = True
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetSearchResults()

        PopulateDataGridView(books)
    End Sub

    Private Sub llblreturned_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        DbSearcher.FlagReturned = True
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetSearchResults()

        PopulateDataGridView(books)
    End Sub



    Private Sub dgvBooks_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentDoubleClick
        Try

            MainForm.UcBookListForm1.Visible = False
            MainForm.UcManageLib1.Visible = True
            MainForm.UcManageLib1.tbeditdeletetransfer.SelectTab(1)
            MainForm.UcManageLib1.tbsearchid.Text = dgvBooks.Item(3, e.RowIndex).Value.ToString
            MainForm.UcManageLib1.btnsearchid.PerformClick()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

End Class
