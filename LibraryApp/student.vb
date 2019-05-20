Imports System.Data.OleDb

Public Class Student

    Private _regno As String
    Private conn As New OleDbConnection
    Public Sub New(ByVal regNo As String)
        Me._regno = regNo
    End Sub
    Public Property Regno As String
        Get
            Return _regno
        End Get
        Set(value As String)
            _regno = value
        End Set
    End Property


End Class
