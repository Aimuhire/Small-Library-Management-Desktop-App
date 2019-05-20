
Public Class UCManageLib
    Private oldData, oldBookid As String
    Private Sub llblall_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblall.LinkClicked
        Dim transfers As List(Of Dictionary(Of String, String)) = DbSearcher.GetAllTransfers()
        PopulateDataGridView(transfers)
    End Sub

    Private Sub PopulateDataGridView(ByVal transfers As List(Of Dictionary(Of String, String)))
        Try

            dgvTransfers.Rows.Clear()
            dgvTransfers.ColumnCount = 10
            dgvTransfers.Columns(0).Name = "#"
            dgvTransfers.Columns(1).Name = "Book ID"
            dgvTransfers.Columns(2).Name = "Reg Number"
            dgvTransfers.Columns(3).Name = "Status"
            dgvTransfers.Columns(4).Name = "Status Changed"
            dgvTransfers.Columns(5).Name = "Borrow Date"
            dgvTransfers.Columns(6).Name = "Return Date"
            dgvTransfers.Columns(7).Name = "Condition"
            dgvTransfers.Columns(8).Name = "Academic Year"
            dgvTransfers.Columns(9).Name = "Change By"

            Dim transferNumber As Integer = 1
            For Each transfer In transfers

                Dim row As String() = {
                transferNumber,
                transfer.Item("bookId"),
                transfer.Item("regNumber"),
                transfer.Item("status"),
                transfer.Item("statusChangeDate"),
                transfer.Item("borrowDate"),
                transfer.Item("returnBfrDate"),
                transfer.Item("condition"),
                transfer.Item("academicYear"),
                transfer.Item("statusChangeBy")
                    }
                dgvTransfers.Rows.Add(row)
                transferNumber += 1

            Next
        Catch ex As Exception
            MessageBox.Show("Error: Could not load transfers.")
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        MainForm.HideAllExcept("LibraryApp.UCAdminPanelForm")
    End Sub

    Private Sub llblborrowed_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblborrowed.LinkClicked

        DbSearcher.FlagBorrowed = True
        Dim transfers As List(Of Dictionary(Of String, String)) = DbSearcher.GetTransferSearchResults()

        PopulateDataGridView(transfers)
    End Sub

    Private Sub llblreturned_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblreturned.LinkClicked

        DbSearcher.FlagReturned = True
        Dim transfers As List(Of Dictionary(Of String, String)) = DbSearcher.GetTransferSearchResults()

        PopulateDataGridView(transfers)
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            If tbsearch.Text = "" Then
                MessageBox.Show("Please fill required field.")
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        DbSearcher.FlagRegNumber = rbregnumber.Checked()
        DbSearcher.FlagBookId = rbbookid.Checked()

        DbSearcher.SearchQuerry = tbsearch.Text
        Dim books As List(Of Dictionary(Of String, String)) = DbSearcher.GetTransferSearchResults()

        PopulateDataGridView(books)

    End Sub

    Private Sub UCUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ev As New LinkLabelLinkClickedEventArgs(New LinkLabel.Link)
            rbbookid.Checked = True
            llblall_LinkClicked(sender, ev)
        Catch ex As Exception
            'MessageBox.Show("Some error")
        End Try
    End Sub

    Private Sub btnsearchid_Click(sender As Object, e As EventArgs) Handles btnsearchid.Click





        Dim bookid As String = tbsearchid.Text
        Me.oldBookid = bookid
        Dim book As Dictionary(Of String, String) = DbSearcher.GetBookById(bookid)
        Try

            If book.Item("bookId") Then
                PopulateEditForm(book)

                If (book.Item("status") = "borrowed") Then
                    MessageBox.Show("Status: ""Borrowed"" You cannot edit a book outside the library. The book must first be returned.")
                End If



                Me.oldData = "{""title"":""" + book.Item("title") + """
                                ""author"":""" + book.Item("author") + """
                                ""description"":""" + book.Item("description") + """
                                ""publication_date"":""" + book.Item("publicationDate") + """
                                ""ISBN"":""" + book.Item("ISBN") + """
                                ""pages"":""" + book.Item("pages").ToString + """
                                ""book_id"":""" + book.Item("bookId") + """
                                 ""condition"":""" + book.Item("condition") + """ }"

            End If
        Catch ex As Exception

            vsearchbyid.Show()
            MessageBox.Show("Error: Book Not Found!")


        End Try



    End Sub

    Private Sub PopulateEditForm(ByVal book As Dictionary(Of String, String))
        vsearchbyid.Hide()
        tbtitle.Text = book.Item("title")
        tbauthor.Text = book.Item("author")
        tbbookid.Text = book.Item("bookId")
        tbdescription.Text = book.Item("description")
        cbcondition.Text = book.Item("condition")
        dtpPublicationDate.Text = book.Item("publicationDate")
        tbisbn.Text = book.Item("ISBN")
        nudpages.Text = book.Item("pages")


    End Sub

    Private Sub PopulateDeleteForm(ByVal book As Dictionary(Of String, String))
        vdsearchid.Hide()
        lbldtitle.Text = book.Item("title")
        lbldauthor.Text = book.Item("author")
        lbldbookid.Text = book.Item("bookId")
        lblddescr.Text = book.Item("description")
        lbldcondition.Text = book.Item("condition")
        lbldpubdate.Text = book.Item("publicationDate")
        lbldisbn.Text = book.Item("ISBN")
        lbldpages.Text = book.Item("pages")
    End Sub

    Private Sub btndsearch_Click(sender As Object, e As EventArgs) Handles btndsearch.Click


        Dim bookid As String = tbdsearchid.Text
        Me.oldBookid = bookid
        Dim book As Dictionary(Of String, String) = DbSearcher.GetBookById(bookid)
        Try

            If book.Item("bookId") Then
                PopulateDeleteForm(book)

                If (book.Item("status") = "borrowed") Then
                    MessageBox.Show("Status: ""Borrowed"" You cannot edit a book outside the library. The book must first be returned.")
                End If



                Me.oldData = "{""title"":""" + book.Item("title") + """
                                ""author"":""" + book.Item("author") + """
                                ""description"":""" + book.Item("description") + """
                                ""publication_date"":""" + book.Item("publicationDate") + """
                                ""ISBN"":""" + book.Item("ISBN") + """
                                ""pages"":""" + book.Item("pages").ToString + """
                                ""book_id"":""" + book.Item("bookId") + """
                                 ""condition"":""" + book.Item("condition") + """ }"

            End If
        Catch ex As Exception

            vdsearchid.Show()
            MessageBox.Show("Error: Book Not Found!")


        End Try


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim thisBook As New Book
        thisBook.Bookid = lbldbookid.Text

        If MsgBox("Are you sure you want to delete the book with id: " + thisBook.Bookid + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If thisBook.DeleteBookById(Me.oldData) Then
                MessageBox.Show("Book with id: " + lbldbookid.Text + " Deleted successfully.")
                vdsearchid.Show()
            Else
                MessageBox.Show("Error: Could not delete book with id: " + lbldbookid.Text)
                vdsearchid.Hide()
            End If
        Else
            vdsearchid.Show()
        End If

    End Sub



    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim thisBook As New Book()
        thisBook = New Book(tbtitle.Text, tbauthor.Text)
        thisBook.Isbn = tbisbn.Text
        thisBook.Bookid = tbbookid.Text
        thisBook.PublicationDate = Date.Now().ToShortDateString
        thisBook.Description = tbdescription.Text
        thisBook.Condition = cbcondition.Text
        thisBook.Pages = nudpages.Value
        thisBook.OldBookid = Me.oldBookid
        If (thisBook.SaveBookChanges(Me.oldData)) Then
            MessageBox.Show("Book edited successfully!")

            vsearchbyid.Show()
        Else
            MessageBox.Show("Error editing book.")
            vsearchbyid.Show()
        End If






    End Sub
End Class
