﻿Imports System.Data.SqlClient

Public Class conn

    Public DBCon As New SqlConnection("Server=172.16.50.5; Database=BCD_TEST_DB; User=sa; Pwd=Bu1ldm0r3.SBO;")
    Public DBCmd As SqlCommand

    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public DBDS As DataSet

    Public Params As New List(Of SqlParameter)

    Public RecordCountDT As Integer = 0
    Public RecordCountDS As Integer = 0
    Public Exception As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Sub ExecQueryDT(ByVal Query As String, Optional ByVal ReturnIdentity As Boolean = False)
        'RESET QUERY STATS
        RecordCountDT = 0
        Exception = ""

        Try
            DBCon.Open()

            'CREATE DATABASE COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAMS
            Params.Clear()

            'EXECUTE COMMAND AND FILL OUR DATA SET
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCountDT = DBDA.Fill(DBDT)

        Catch ex As Exception
            'CAPTURE
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    Public Sub ExecQueryDS(ByVal Query As String, Optional ByVal ReturnIdentity As Boolean = False)
        'RESET QUERY STATS
        RecordCountDS = 0
        Exception = ""

        Try
            DBCon.Open()

            'CREATE DATABASE COMMAND
            DBCmd = New SqlCommand(Query, DBCon)

            'LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'CLEAR PARAMS
            Params.Clear()

            'EXECUTE COMMAND AND FILL OUR DATA SET
            DBDS = New DataSet
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCountDS = DBDA.Fill(DBDS)

        Catch ex As Exception
            'CAPTURE
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    'ADD PARAMS
    Public Sub AddParam(ByVal Name As String, ByVal Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    'ERROR CHECKING
    Public Function HasException(Optional ByVal Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function

End Class