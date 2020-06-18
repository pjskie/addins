Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Image

Public Class query
    Public SQL As New conn

    Public Sub loadBranch()


        'Query for the branches
        SQL.ExecQueryDT("SELECT * FROM OBPL WHERE BPLId NOT IN (1,2);")

        ''REPORT & ABORT SUB ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        PT.clbBranches.DisplayMember = "BPLName"
        PT.clbBranches.ValueMember = "BPLName"

        For Each r As DataRow In SQL.DBDT.Rows
            PT.clbBranches.Items.Add(r(1))
        Next

    End Sub
End Class
