Public Class User

    Dim _fname, _lname, _phone, _email, _username, _newpassword, _password As String
    Dim conn As New OleDb.OleDbConnection

    Public Sub New()
        conn.ConnectionString = My.Settings.LocalLibdbConnectionString

    End Sub

    Public Sub New(fname As String, lname As String, phone As String, email As String, password As String)
        Me.Fname = fname
        Me.Lname = lname
        Me.Phone = phone
        Me.Email = email
        Me.Password = password
        conn.ConnectionString = My.Settings.LocalLibdbConnectionString

    End Sub

    Public Function login() As Boolean
        Try
            Dim qpass As String = GetUserPassword(Me._username)

            If (Me._password = qpass) Then

                Return True
            End If
            Return False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try


    End Function

    Public Function UpdatePassword() As Boolean
        Try



            If (GetUserPassword(Me._username) <> Me._password) Then
                Return False
            End If
            Dim cmd As New OleDb.OleDbCommand()
            conn.Open()

            'must also use session data to get username and use it here
            cmd.CommandText = "UPDATE users SET [password] = ? WHERE username = ?"
            cmd.Parameters.Add("@p2", OleDb.OleDbType.VarChar).Value = Me._newpassword
            cmd.Parameters.Add("@p3", OleDb.OleDbType.VarChar).Value = Me._username

            cmd.Connection = conn

            Dim upcount As Integer = cmd.ExecuteNonQuery()
            If upcount > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.Source)
            MessageBox.Show(ex.StackTrace)
            Return False
        End Try


    End Function

    Public Function GetUserPassword(ByVal username) As String
        Try
            Dim cmd As New OleDb.OleDbCommand()
            conn.Open()
            cmd.CommandText = "SELECT password FROM users WHERE username=@username"
            cmd.Connection = conn
            cmd.Parameters.Add(New OleDb.OleDbParameter("@username", username))
            Dim reader As OleDb.OleDbDataReader
            reader = cmd.ExecuteReader()
            reader.Read()

            Dim q As String = reader.GetString(0)
            conn.Close()
            Return q
        Catch ex As Exception
            Return "ERROR_LOADING_PASSWORD"
        End Try

    End Function
    Public Property Fname As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Newpassword As String
        Get
            Return _newpassword
        End Get
        Set(value As String)
            _newpassword = value
        End Set
    End Property
End Class
