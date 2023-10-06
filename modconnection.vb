Imports System.Data.OleDb

Module ModConnection
    Public cur As Form
    Public dt As DataTable
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public sqL As String
    Public Sub ConnDB()
        Try
            'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & System.Environment.CurrentDirectory & "\beer.mdb")
            conn = New OleDbConnection(My.Settings.atmConnectionString)
            ' conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database\phone.mdb;Jet OLEDB:Database Password = escobar;")
            conn.Open()
        Catch ex As Exception
            MsgBox("Failed in Connecting to database, Please check your database path directory! The database is inside")
        End Try
    End Sub
    Public Function getDataTable(ByVal SQL As String) As DataTable
        ConnDB()
        Dim cmd As New OleDbCommand(SQL, conn)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Module
