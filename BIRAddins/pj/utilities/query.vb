Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Image

Public Class query
    Public SQL As New conn

    Public Sub loadBranch(cbl As CheckedListBox)

        'Query for the branches
        SQL.ExecQueryDT("SELECT * from OBPL 
                        WHERE MAINBPL = 'N' AND DISABLED = 'N'
                        ORDER BY BPLID ASC;")

        ''REPORT & ABORT SUB ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        cbl.DisplayMember = "BPLName"
        cbl.ValueMember = "BPLid"

        For Each r As DataRow In SQL.DBDT.Rows
            cbl.Items.Add(r.Item("BPLName"))
        Next

    End Sub
End Class
