Imports System.Data.SQLite

Public Class SQLiteUtil

    Shared Sub New()
        initConnection()
    End Sub

    Private Shared Sub initConnection()
        conn = New SQLiteConnection
        conn.ConnectionString = "Version=3;Data Source=DankaRelation.db;New=False;Compress=True;"
    End Sub

    Private Shared conn As SQLiteConnection

    Public Shared Function getConnection() As SQLiteConnection
        Return conn
    End Function

    Private Shared Function getSingletonConnection() As SQLiteConnection
        If conn Is Nothing Then
            Call initConnection()
        End If
        Return conn
    End Function
End Class
