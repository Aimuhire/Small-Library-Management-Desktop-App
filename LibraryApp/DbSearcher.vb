Imports System.Data.OleDb
Module DbSearcher


    Private _searchQuerry As String
    Private _flagAvailable,
            _flagBorrowed,
            _flagReturned,
            _flagISBN,
            _flagBookId,
            _flagAuthor,
            _flagDescription,
            _flagTitle,
            _flagRegNumber As Boolean


    Public Property SearchQuerry As String
        Get
            Return _searchQuerry
        End Get
        Set(value As String)
            _searchQuerry = value
        End Set
    End Property

    Public Property FlagAvailable As Boolean
        Get
            Return _flagAvailable
        End Get
        Set(value As Boolean)
            _flagAvailable = value
        End Set
    End Property

    Public Property FlagBorrowed As Boolean
        Get
            Return _flagBorrowed
        End Get
        Set(value As Boolean)
            _flagBorrowed = value
        End Set
    End Property

    Public Property FlagReturned As Boolean
        Get
            Return _flagReturned
        End Get
        Set(value As Boolean)
            _flagReturned = value
        End Set
    End Property

    Public Property FlagISBN As Boolean
        Get
            Return _flagISBN
        End Get
        Set(value As Boolean)
            _flagISBN = value
        End Set
    End Property

    Public Property FlagAuthor As Boolean
        Get
            Return _flagAuthor
        End Get
        Set(value As Boolean)
            _flagAuthor = value
        End Set
    End Property

    Public Property FlagDescription As Boolean
        Get
            Return _flagDescription
        End Get
        Set(value As Boolean)
            _flagDescription = value
        End Set
    End Property

    Public Property FlagTitle As Boolean
        Get
            Return _flagTitle
        End Get
        Set(value As Boolean)
            _flagTitle = value
        End Set
    End Property

    Public Property FlagBookId As Boolean
        Get
            Return _flagBookId
        End Get
        Set(value As Boolean)
            _flagBookId = value
        End Set
    End Property

    Public Property FlagRegNumber As Boolean
        Get
            Return _flagRegNumber
        End Get
        Set(value As Boolean)
            _flagRegNumber = value
        End Set
    End Property

    '''<summary>
    '''Returns list of books in the library as dictionaries
    ''' </summary> 
    Public Function GetAllBooks() As List(Of Dictionary(Of String, String))

        Dim books As New List(Of Dictionary(Of String, String))()
        Dim conn As New OleDbConnection()
        conn.ConnectionString = My.Settings.LocalLibdbConnectionString
        conn.Open()
        Dim qstr As String
        qstr = "SELECT * FROM Books"
        Dim cmd As New OleDbCommand(qstr, conn)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim i As Integer = 0
        While reader.Read()
            Dim book As New Dictionary(Of String, String) From {
                {"ID", reader.GetValue(0).ToString()},
                {"title", reader.GetValue(1).ToString()},
                {"author", reader.GetValue(2).ToString()},
                {"bookId", reader.GetValue(3).ToString()},
                {"status", reader.GetValue(4).ToString()},
                {"description", reader.GetValue(5).ToString()},
                {"addedBy", reader.GetValue(6).ToString()},
                {"addedDate", reader.GetValue(7).ToString()},
                {"publicationDate", reader.GetValue(8).ToString()},
                {"pages", reader.GetValue(9).ToString()},
                 {"ISBN", reader.GetValue(10).ToString()},
                {"condition", reader.GetValue(11).ToString()}
            }
            books.Add(book)
        End While

        Return books
        ' MessageBox.Show(books(1).Item("ID") + ", " + books(1).Item("title") + ", " + books(1).Item("author") + ", " + books(1).Item("description") + ", " + books(1).Item("addedBy") + ", " + books(1).Item("addedDate") + books(1).Item("publicationDate") + books(1).Item("pages") + books(1).Item("ISBN"))
        ' always call Close when done reading.
        reader.Close()

    End Function

    Public Function GetBookById(ByVal bookid As String) As Dictionary(Of String, String)
        Try

            Dim books As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM Books where book_id=?"
            Dim cmd As New OleDbCommand(qstr, conn)
            cmd.Parameters.AddWithValue("@p1", bookid)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()


            reader.Read()
            Dim book As New Dictionary(Of String, String) From {
                    {"ID", reader.GetValue(0).ToString()},
                    {"title", reader.GetValue(1).ToString()},
                    {"author", reader.GetValue(2).ToString()},
                    {"bookId", reader.GetValue(3).ToString()},
                    {"status", reader.GetValue(4).ToString()},
                    {"description", reader.GetValue(5).ToString()},
                    {"addedBy", reader.GetValue(6).ToString()},
                    {"addedDate", reader.GetValue(7).ToString()},
                    {"publicationDate", reader.GetValue(8).ToString()},
                    {"pages", reader.GetValue(9).ToString()},
                     {"ISBN", reader.GetValue(10).ToString()},
                    {"condition", reader.GetValue(11).ToString()}
                }

            Return book
            reader.Close()
        Catch ex As Exception
            '     MessageBox.Show(ex.ToString)
            Return New Dictionary(Of String, String)
        End Try

    End Function

    Public Function GetAllTransfers() As List(Of Dictionary(Of String, String))
        Try
            Dim transfers As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM book_transfers"
            Dim cmd As New OleDbCommand(qstr, conn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()



            While reader.Read()
                Dim tr As New Dictionary(Of String, String) From {
                    {"ID", reader.GetValue(0).ToString()},
                    {"bookId", reader.GetValue(1).ToString()},
                    {"regNumber", reader.GetValue(2).ToString()},
                    {"status", reader.GetValue(3).ToString()},
                    {"statusChangeDate", reader.GetValue(4).ToString()},
                    {"borrowDate", reader.GetValue(5).ToString()},
                    {"returnBfrDate", reader.GetValue(6).ToString()},
                    {"condition", reader.GetValue(7).ToString()},
                    {"academicYear", reader.GetValue(8).ToString()},
                    {"statusChangeBy", reader.GetValue(9).ToString()}
                }
                transfers.Add(tr)
            End While

            Return transfers
            ' MessageBox.Show(books(1).Item("ID") + ", " + books(1).Item("title") + ", " + books(1).Item("author") + ", " + books(1).Item("description") + ", " + books(1).Item("addedBy") + ", " + books(1).Item("addedDate") + books(1).Item("publicationDate") + books(1).Item("pages") + books(1).Item("ISBN"))
            ' always call Close when done reading.
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving book transfers." & ex.StackTrace)
            Return New List(Of Dictionary(Of String, String))

        End Try


    End Function




    Public Function GetAllLogs() As List(Of Dictionary(Of String, String))
        Try
            Dim logs As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String
            qstr = "SELECT * FROM activity_log"
            Dim cmd As New OleDbCommand(qstr, conn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()



            While reader.Read()
                Dim log As New Dictionary(Of String, String) From {
                    {"ID", reader.GetValue(0).ToString()},
                    {"action", reader.GetValue(1).ToString()},
                    {"bookId", reader.GetValue(2).ToString()},
                    {"regNumber", reader.GetValue(3).ToString()},
                    {"actionDate", reader.GetValue(4).ToString()},
                    {"actionBy", reader.GetValue(5).ToString()},
                    {"oldData", reader.GetValue(6).ToString()},
                    {"newData", reader.GetValue(7).ToString()}
                }
                logs.Add(log)
            End While

            Return logs
            ' MessageBox.Show(books(1).Item("ID") + ", " + books(1).Item("title") + ", " + books(1).Item("author") + ", " + books(1).Item("description") + ", " + books(1).Item("addedBy") + ", " + books(1).Item("addedDate") + books(1).Item("publicationDate") + books(1).Item("pages") + books(1).Item("ISBN"))
            ' always call Close when done reading.
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving  logs.")
            Return New List(Of Dictionary(Of String, String))

        End Try


    End Function

    'Select Case*
    'From testing
    'Where 'foo' in (col1, col2, col3, . . . );

    Public Function GetSearchResults() As List(Of Dictionary(Of String, String))
        Try
            Dim books As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String

            Dim cmd As New OleDbCommand()
            qstr = ""

            Select Case True

                Case _flagTitle
                    qstr = "SELECT * FROM Books WHERE title LIKE ?"
                    cmd.Parameters.AddWithValue("@p5", "%" + _searchQuerry + "%")


                Case _flagAuthor
                    qstr = "SELECT * FROM Books WHERE author LIKE ?"
                    cmd.Parameters.AddWithValue("@p5", "%" + _searchQuerry + "%")

                Case _flagDescription
                    qstr = "SELECT * FROM Books WHERE description LIKE ?"
                    cmd.Parameters.AddWithValue("@p5", "%" + _searchQuerry + "%")

                Case _flagISBN
                    qstr = "SELECT * FROM Books WHERE ISBN LIKE ?"
                    cmd.Parameters.AddWithValue("@p5", "%" + _searchQuerry + "%")
                Case _flagBookId
                    qstr = "SELECT * FROM Books WHERE book_id = ?"
                    cmd.Parameters.AddWithValue("@p5", _searchQuerry)
                Case _flagAvailable
                    qstr = "SELECT * FROM Books WHERE status=""available"""
                Case _flagBorrowed
                    qstr = "SELECT * FROM Books WHERE status=""borrowed"""
                Case _flagReturned
                    qstr = "SELECT * FROM Books WHERE status=""returned"""
                Case Else
                    qstr = "SELECT * FROM Books"


            End Select





            cmd.CommandText = qstr
            cmd.Connection = conn

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim i As Integer = 0
            While reader.Read()
                Dim book As New Dictionary(Of String, String) From {
                        {"ID", reader.GetValue(0).ToString()},
                        {"title", reader.GetValue(1).ToString()},
                        {"author", reader.GetValue(2).ToString()},
                        {"bookId", reader.GetValue(3).ToString()},
                        {"status", reader.GetValue(4).ToString()},
                        {"description", reader.GetValue(5).ToString()},
                        {"addedBy", reader.GetValue(6).ToString()},
                        {"addedDate", reader.GetValue(7).ToString()},
                        {"publicationDate", reader.GetValue(8).ToString()},
                        {"pages", reader.GetValue(9).ToString()},
                         {"ISBN", reader.GetValue(10).ToString()},
                        {"condition", reader.GetValue(11).ToString()}
                    }
                books.Add(book)
            End While

            Return books
            ' MessageBox.Show(books(1).Item("ID") + ", " + books(1).Item("title") + ", " + books(1).Item("author") + ", " + books(1).Item("description") + ", " + books(1).Item("addedBy") + ", " + books(1).Item("addedDate") + books(1).Item("publicationDate") + books(1).Item("pages") + books(1).Item("ISBN"))
            ' always call Close when done reading.
            reader.Close()
        Catch ex As Exception
            ' MessageBox.Show("Could not find results.")
            MessageBox.Show(ex.ToString)
            Return New List(Of Dictionary(Of String, String))
        End Try

    End Function
    Public Function GetTransferSearchResults() As List(Of Dictionary(Of String, String))
        Try
            Dim transfers As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String

            Dim cmd As New OleDbCommand()
            qstr = ""

            Select Case True
                Case FlagRegNumber
                    qstr = "SELECT * FROM book_transfers WHERE reg_number = ?"
                    cmd.Parameters.AddWithValue("@p5", _searchQuerry)

                Case _flagBookId
                    qstr = "SELECT * FROM book_transfers WHERE book_id = ?"
                    cmd.Parameters.AddWithValue("@p5", _searchQuerry)
                Case _flagAvailable
                    qstr = "SELECT * FROM book_transfers WHERE status=""available"""
                Case _flagBorrowed
                    qstr = "SELECT * FROM book_transfers WHERE status=""borrowed"""
                Case _flagReturned
                    qstr = "SELECT * FROM book_transfers WHERE status=""returned"""
                Case Else
                    qstr = "SELECT * FROM Books"


            End Select





            cmd.CommandText = qstr
            cmd.Connection = conn

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim i As Integer = 0
            While reader.Read()
                Dim tr As New Dictionary(Of String, String) From {
                    {"ID", reader.GetValue(0).ToString()},
                    {"bookId", reader.GetValue(1).ToString()},
                    {"regNumber", reader.GetValue(2).ToString()},
                    {"status", reader.GetValue(3).ToString()},
                    {"statusChangeDate", reader.GetValue(4).ToString()},
                    {"borrowDate", reader.GetValue(5).ToString()},
                    {"returnBfrDate", reader.GetValue(6).ToString()},
                    {"condition", reader.GetValue(7).ToString()},
                    {"academicYear", reader.GetValue(8).ToString()},
                    {"statusChangeBy", reader.GetValue(9).ToString()}
                    }
                transfers.Add(tr)
            End While

            Return transfers
            ' MessageBox.Show(books(1).Item("ID") + ", " + books(1).Item("title") + ", " + books(1).Item("author") + ", " + books(1).Item("description") + ", " + books(1).Item("addedBy") + ", " + books(1).Item("addedDate") + books(1).Item("publicationDate") + books(1).Item("pages") + books(1).Item("ISBN"))
            ' always call Close when done reading.
            reader.Close()
        Catch ex As Exception
            ' MessageBox.Show("Could not find results.")
            MessageBox.Show(ex.ToString)
            Return New List(Of Dictionary(Of String, String))
        End Try

    End Function

    Public Function GetBookStats() As Dictionary(Of String, Integer)

        Dim stats As New Dictionary(Of String, Integer)

        Try

            Dim transfers As New List(Of Dictionary(Of String, String))()
            Dim conn As New OleDbConnection()
            conn.ConnectionString = My.Settings.LocalLibdbConnectionString
            conn.Open()
            Dim qstr As String
            qstr = "select count(*) from books "
            Dim cmd1 As New OleDbCommand(qstr, conn)

            Dim reader As OleDbDataReader = cmd1.ExecuteReader()
            reader.Read()

            stats.Add("totalBooks", reader.GetInt32(0))


            reader.Close()

            qstr = "select count(*) from books where status=""borrowed"" "
            Dim cmd2 As New OleDbCommand(qstr, conn)

            reader = cmd2.ExecuteReader()
            reader.Read()

            stats.Add("borrowed", reader.GetInt32(0))

            reader.Close()


            qstr = "select count(*) from book_transfers where status=""borrowed"" and return_bfr_date < ?"
            Dim cmd3 As New OleDbCommand(qstr, conn)
            cmd3.Parameters.AddWithValue("@d", Date.Now().ToShortDateString)
            reader = cmd3.ExecuteReader()
            reader.Read()
            stats.Add("lateReturns", reader.GetInt32(0))


            reader.Close()



            'Dim today = DateTime.Now
            'Dim w1start As String = today.ToShortDateString
            'Dim w1end As String = today.AddDays(-7).ToShortDateString
            'getRangeStatCount(w1start, w1end, "action", "Borrowed Book")
            'Dim w2start As String = today.AddDays(-7).ToShortDateString
            'Dim w2end As String = today.AddDays(-7).ToShortDateString

            'Dim w3start As String = today.AddDays(-7).ToShortDateString
            'Dim w3end As String = today.AddDays(-7).ToShortDateString

            'Dim w4start As String = today.AddDays(-7).ToShortDateString
            'Dim w4end As String = today.AddDays(-7).ToShortDateString

            'Dim w5start As String = today.AddDays(-7).ToShortDateString
            'Dim w5end As String = today.AddDays(-7).ToShortDateString

            'Dim w6start As String = today.AddDays(-7).ToShortDateString
            'Dim w6end As String = today.AddDays(-7).ToShortDateString

            'Dim w7start As String = today.AddDays(-7).ToShortDateString
            'Dim w7end As String = today.AddDays(-7).ToShortDateString

            'qstr = "select count(*) from book_transfers where status=""borrowed"" and borrow_date > ?"
            'Dim cmd4 As New OleDbCommand(qstr, conn)
            'cmd4.Parameters.AddWithValue("@d", Date.Now().ToShortDateString)
            'reader = cmd4.ExecuteReader()
            'reader.Read()
            'stats.Add("Borrowed", reader.GetInt32(0))
            'reader.Close()



            Return stats

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return stats

        End Try


    End Function

    Function getRangeStatCount(ByVal _start As String, ByVal _end As String, ByVal col As String, ByVal key As String) As Integer
        Dim conn As New OleDbConnection()
        conn.ConnectionString = My.Settings.LocalLibdbConnectionString
        conn.Open()
        Dim qstr As String
        qstr = "select count(*) from activity_log WHERE ? = ? action_date >= ? AND action_date <= ? "
        Dim cmd As New OleDbCommand(qstr, conn)

        cmd.Parameters.AddWithValue("col", col)

        cmd.Parameters.AddWithValue("key", key)
        cmd.Parameters.AddWithValue("start", _start)
        cmd.Parameters.AddWithValue("end", _end)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        reader.Read()

        Return reader.GetInt32(0)
    End Function



End Module