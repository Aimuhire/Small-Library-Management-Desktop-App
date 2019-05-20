
Imports System.Configuration
Imports System.Data.OleDb

Public Class Book
    Private _title, _author, _description, _publicationDate, _isbn, _bookid, _oldBookid, _condition As String
    Private _action, _action_date, _actionBy, _editColumn, _initialValue, _updatedValue, _table As String

    Private _pages As Integer
    Private conn As New OleDbConnection


    Public Sub New(title As String, author As String)
        Me._title = title
        Me._author = author
        conn.ConnectionString = My.Settings.LocalLibdbConnectionString
    End Sub

    Public Sub New()

    End Sub

    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property



    Friend Function SaveBook() As Boolean
        Try
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()




            Dim qstr, findBookStr As String
            findBookStr = "SELECT * FROM Books WHERE book_id=?"
            Dim findcmd As New OleDbCommand(findBookStr, conn)
            findcmd.Parameters.Add(New OleDbParameter("book_id", Me._bookid))
            Dim count As Integer = findcmd.ExecuteNonQuery()

            Dim rowCount As Integer = findcmd.ExecuteScalar()

            If (rowCount > 0) Then
                MessageBox.Show("The book with " & Me._bookid & " already exists in the database.")
                Return False
            End If

            qstr = "Insert into books (title,author,description,added_by,publication_date,added_date,isbn,pages,book_id,condition) values(?,?,?,?,?,?,?,?,?,?)"
            Dim trans As OleDbTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

            Dim cmd As New OleDbCommand(qstr, conn, trans)
            cmd.Parameters.AddWithValue("@title", Me._title)
            cmd.Parameters.AddWithValue("@author", Me._author)
            cmd.Parameters.AddWithValue("@description", Me._description)
            cmd.Parameters.AddWithValue("@added_by", "admin")
            cmd.Parameters.AddWithValue("@publication_date", Date.Now().ToString())
            cmd.Parameters.AddWithValue("@added_date", Date.Now().ToString())
            cmd.Parameters.AddWithValue("@isbn", Me._isbn)
            cmd.Parameters.AddWithValue("@pages", Me._pages)
            cmd.Parameters.AddWithValue("@bookid", Me._bookid)
            cmd.Parameters.AddWithValue("@condition", Me._condition)


            cmd.ExecuteNonQuery()

            Dim cmd3 As New OleDbCommand("INSERT INTO activity_log ([action],book_id,action_date,action_by) values(?,?,?,?)", conn, trans)
            cmd3.Parameters.AddWithValue("@p1", "Inserted Book")
            cmd3.Parameters.AddWithValue("@p2", Me._bookid)
            cmd3.Parameters.AddWithValue("@p4", DateTime.Now().ToString)
            cmd3.Parameters.AddWithValue("@p5", "admin")
            cmd3.ExecuteNonQuery()

            trans.Commit()

            cmd.Dispose()
            conn.Close()

            Return True


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function

    Friend Function SaveBookChanges(ByVal oldData As String) As Boolean
        Try
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()

            Dim findStatus As String
            findStatus = "SELECT status FROM Books WHERE book_id=?"
            Dim findcmd As New OleDbCommand(findStatus, conn)
            findcmd.Parameters.Add(New OleDbParameter("book_id", Me._oldBookid))
            Dim reader As OleDbDataReader

            reader = findcmd.ExecuteReader()
            reader.Read()

            If reader.GetValue(0).ToString = "Borrowed" Then
                MessageBox.Show("Error: The book cannot be edited when it is not in the library. Please return it first.")
                Return False

            End If

            reader.Close()


            If Me._bookid <> Me._oldBookid Then
                Try
                    Dim findBookid As String
                    findBookid = "SELECT book_id FROM Books WHERE book_id=?"
                    Dim findcmd2 As New OleDbCommand(findBookid, conn)
                    findcmd2.Parameters.Add(New OleDbParameter("book_id", Me._bookid))

                    reader = findcmd2.ExecuteReader()
                    reader.Read()

                    MessageBox.Show("wait: " + reader.GetValue(0).ToString)
                    If reader.GetValue(0).ToString Then
                        MessageBox.Show("Error: There is another book with this book ID.")
                        Return False

                    End If
                    reader.Close()


                Catch ex As Exception

                End Try

            End If







            Dim qstr As String


            qstr = "UPDATE Books SET title=?,author=?,description=?,publication_date=?,isbn=?,pages=?,book_id=?,condition=? WHERE book_id=?"
            Dim trans As OleDbTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

            Dim cmd As New OleDbCommand(qstr, conn, trans)
            cmd.Parameters.AddWithValue("@title", Me._title)
            cmd.Parameters.AddWithValue("@author", Me._author)
            cmd.Parameters.AddWithValue("@description", Me._description)
            cmd.Parameters.AddWithValue("@publication_date", Me._publicationDate)
            cmd.Parameters.AddWithValue("@isbn", Me._isbn)
            cmd.Parameters.AddWithValue("@pages", Me._pages)
            cmd.Parameters.AddWithValue("@bookid", Me._bookid)
            cmd.Parameters.AddWithValue("@condition", Me._condition)
            cmd.Parameters.AddWithValue("@bookid", Me._oldBookid)
            cmd.ExecuteNonQuery()
            Dim newData As String = "{""title"":""" + Me._title + """
                                ""author"":""" + Me._author + """
                                ""description"":""" + Me._description + """
                                ""publication_date"":""" + Me._publicationDate + """
                                ""ISBN"":""" + Me._isbn + """
                                ""pages"":""" + Me._pages.ToString + """
                                ""book_id"":""" + Me._bookid + """
                                ""condition"":""" + Me._condition + """}"


            Dim cmd2 As New OleDbCommand("INSERT INTO activity_log ([action],book_id,action_date,action_by,old_data,new_data) values(?,?,?,?,?,?)", conn, trans)
            cmd2.Parameters.AddWithValue("@p1", "Edited Book")
            cmd2.Parameters.AddWithValue("@p2", Me._bookid)
            cmd2.Parameters.AddWithValue("@p4", DateTime.Now().ToString)
            cmd2.Parameters.AddWithValue("@p5", "admin")
            cmd2.Parameters.AddWithValue("@p6", oldData)
            cmd2.Parameters.AddWithValue("@p7", newData)

            cmd2.ExecuteNonQuery()

            trans.Commit()

            cmd.Dispose()
            conn.Close()

            Return True


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function

    Friend Function DeleteBookById(ByVal oldData As String) As Boolean
        Try
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()

            Dim findStatus As String
            findStatus = "SELECT status FROM Books WHERE book_id=?"
            Dim findcmd As New OleDbCommand(findStatus, conn)
            findcmd.Parameters.Add(New OleDbParameter("book_id", Me._bookid))
            Dim reader As OleDbDataReader

            reader = findcmd.ExecuteReader()
            reader.Read()

            If reader.GetValue(0).ToString = "Borrowed" Then
                MessageBox.Show("Error: The book cannot be deleted when it is not in the library. Please return it first.")
                Return False

            End If

            reader.Close()

            Dim qstr As String

            qstr = "DELETE FROM Books WHERE book_id=?"
            Dim trans As OleDbTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

            Dim cmd As New OleDbCommand(qstr, conn, trans)
            cmd.Parameters.AddWithValue("@bookid", Me._bookid)
            cmd.ExecuteNonQuery()

            Dim cmd2 As New OleDbCommand("INSERT INTO activity_log ([action],book_id,action_date,action_by,old_data) values(?,?,?,?,?)", conn, trans)
            cmd2.Parameters.AddWithValue("@p1", "Deleted Book")
            cmd2.Parameters.AddWithValue("@p2", Me._bookid)
            cmd2.Parameters.AddWithValue("@p4", DateTime.Now().ToString)
            cmd2.Parameters.AddWithValue("@p5", "admin")
            cmd2.Parameters.AddWithValue("@p6", oldData)

            cmd2.ExecuteNonQuery()

            trans.Commit()

            cmd.Dispose()
            conn.Close()

            Return True


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function


    Friend Function BorrowBook(ByVal regno As String, ByVal academicYear As Integer) As Boolean
        Try

            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()

            Dim qstr As String
            qstr = "SELECT status FROM books WHERE book_id=@bookid"

            Dim findcmd As New OleDbCommand(qstr, conn)
            findcmd.Parameters.Add(New OleDbParameter("@book_id", Me._bookid))

            Dim reader As OleDbDataReader = findcmd.ExecuteReader()
            reader.Read()
            Dim state As String = reader.GetString(0)
            If Not state.ToLower = "available" Then
                MessageBox.Show("The requested book is not available. Status: " & state)
                Return False

            End If
            reader.Close()




            qstr = "SELECT * FROM book_transfers WHERE book_id=@bookid"
            Dim findcmd2 As New OleDbCommand(qstr, conn)

            findcmd2.Parameters.Add(New OleDbParameter("@book_id", Me._bookid))

            Dim rowCount As Integer = findcmd2.ExecuteScalar()


            Dim trans As OleDbTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)


            If rowCount > 0 Then
                Dim cmdupdate As New OleDbCommand("UPDATE book_transfers SET status=@status,reg_number=@regno, condition=@condition, academic_year=@academicYear WHERE book_id=@bookid ", conn, trans)
                cmdupdate.Parameters.Add(New OleDbParameter("@status", "Borrowed"))
                cmdupdate.Parameters.Add(New OleDbParameter("@regno", regno))
                cmdupdate.Parameters.Add(New OleDbParameter("@condition", Me._condition))
                cmdupdate.Parameters.Add(New OleDbParameter("@academicYear", academicYear))
                cmdupdate.Parameters.Add(New OleDbParameter("@bookid", Me._bookid))
                cmdupdate.ExecuteNonQuery()
            Else


                Dim cmd1 As New OleDbCommand("
                Insert into book_transfers
                (book_id,reg_number,borrow_date,status_change_date,return_bfr_date,status,condition,academic_year)
                values (?,?,?,?,?,?,?,?)", conn, trans)

                cmd1.Parameters.Add(New OleDbParameter("book_id", Me._bookid))
                cmd1.Parameters.Add(New OleDbParameter("reg_number", regno))
                cmd1.Parameters.Add(New OleDbParameter("borrow_date", Date.Now().ToShortDateString))
                cmd1.Parameters.Add(New OleDbParameter("status_change_date", Date.Now().ToShortDateString))
                Dim days As Integer
                If (Not Integer.TryParse(ReadSetting("max_borrow_days"), days)) Then
                    MessageBox.Show("Please set the maximum borrow days in your Settings at the Admin Panel Page.")
                    Return False
                End If

                cmd1.Parameters.Add(New OleDbParameter("return_bfr_date", Date.Now().AddDays(days).ToShortDateString))
                cmd1.Parameters.Add(New OleDbParameter("status", "Borrowed"))
                    cmd1.Parameters.Add(New OleDbParameter("condition", Me._condition))
                    cmd1.Parameters.Add(New OleDbParameter("academic_year", academicYear))
                    cmd1.ExecuteNonQuery()
                End If


                Dim cmd2 As New OleDbCommand("UPDATE books SET status=@status, condition=@condition WHERE book_id=@bookid ", conn, trans)
            cmd2.Parameters.Add(New OleDbParameter("@status", "Borrowed"))
            cmd2.Parameters.Add(New OleDbParameter("@condition", Me._condition))
            cmd2.Parameters.Add(New OleDbParameter("@bookid", Me._bookid))
            cmd2.ExecuteNonQuery()



            Dim cmd3 As New OleDbCommand("INSERT INTO activity_log ([action],book_id,reg_number,action_date,action_by) values(?,?,?,?,?)", conn, trans)
            cmd3.Parameters.AddWithValue("@p1", "Borrowed")
            cmd3.Parameters.AddWithValue("@p2", Me._bookid)
            cmd3.Parameters.AddWithValue("@p3", regno)
            cmd3.Parameters.AddWithValue("@p4", DateTime.Now().ToString)
            cmd3.Parameters.AddWithValue("@p5", "admin")
            cmd3.ExecuteNonQuery()

            trans.Commit()
            conn.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
            Return False
        End Try

    End Function

    Friend Function ReturnBook()
        Try
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()

            Dim trans As OleDbTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

            Dim cmd1 As New OleDbCommand("UPDATE Books SET status=?,condition=? WHERE book_id=?", conn, trans)
            cmd1.Parameters.Add(New OleDbParameter("@status", "Available"))
            cmd1.Parameters.Add(New OleDbParameter("@condition", Me._condition))
            cmd1.Parameters.Add(New OleDbParameter("@bookid", Me._bookid))
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New OleDbCommand("UPDATE book_transfers SET status=?, condition=?, status_change_date=?, status_change_by=? WHERE book_id=?", conn, trans)
            cmd2.Parameters.Add(New OleDbParameter("@status", "Returned"))
            cmd2.Parameters.Add(New OleDbParameter("@condition", Me._condition))
            cmd2.Parameters.Add(New OleDbParameter("@status_change_date", Date.Now().ToString()))
            cmd2.Parameters.Add(New OleDbParameter("@status_change_by", "admin"))
            cmd2.Parameters.Add(New OleDbParameter("@bookid", Me._bookid))
            cmd2.ExecuteNonQuery()

            Dim cmd3 As New OleDbCommand("INSERT INTO activity_log ([action],book_id,action_date,action_by) values(?,?,?,?)", conn, trans)
            cmd3.Parameters.AddWithValue("@p1", "Returned")
            cmd3.Parameters.AddWithValue("@p2", Me._bookid)
            cmd3.Parameters.AddWithValue("@p4", DateTime.Now().ToString)
            cmd3.Parameters.AddWithValue("@p5", "admin")
            cmd3.ExecuteNonQuery()
            trans.Commit()


            conn.Close()
            Return True





        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.Source)
            MessageBox.Show(ex.StackTrace)


            Return False
        End Try

    End Function


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
            Return "Not found"
        End Try
    End Function
    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            _author = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Isbn As String
        Get
            Return _isbn
        End Get
        Set(value As String)
            _isbn = value
        End Set
    End Property

    Public Property Pages As Integer
        Get
            Return _pages
        End Get
        Set(value As Integer)
            _pages = value
        End Set
    End Property

    Public Property Bookid As String
        Get
            Return _bookid
        End Get
        Set(value As String)
            _bookid = value
        End Set
    End Property

    Public Property Condition As String
        Get
            Return _condition
        End Get
        Set(value As String)
            _condition = value
        End Set
    End Property

    Public Property Action As String
        Get
            Return _action
        End Get
        Set(value As String)
            _action = value
        End Set
    End Property

    Public Property Action_date As String
        Get
            Return _action_date
        End Get
        Set(value As String)
            _action_date = value
        End Set
    End Property

    Public Property ActionBy As String
        Get
            Return _actionBy
        End Get
        Set(value As String)
            _actionBy = value
        End Set
    End Property

    Public Property EditColumn As String
        Get
            Return _editColumn
        End Get
        Set(value As String)
            _editColumn = value
        End Set
    End Property

    Public Property InitialValue As String
        Get
            Return _initialValue
        End Get
        Set(value As String)
            _initialValue = value
        End Set
    End Property

    Public Property UpdatedValue As String
        Get
            Return _updatedValue
        End Get
        Set(value As String)
            _updatedValue = value
        End Set
    End Property

    Public Property Table As String
        Get
            Return _table
        End Get
        Set(value As String)
            _table = value
        End Set
    End Property

    Public Property PublicationDate As String
        Get
            Return _publicationDate
        End Get
        Set(value As String)
            _publicationDate = value
        End Set
    End Property

    Public Property OldBookid As String
        Get
            Return _oldBookid
        End Get
        Set(value As String)
            _oldBookid = value
        End Set
    End Property
End Class
