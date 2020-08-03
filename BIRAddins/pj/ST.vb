Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ST
    Private q As New filterRp
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private quer As New query

    ' Posting Date Paremeter Validations
    Private Sub DDFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDFrom.ValueChanged
        If DDFrom.Value > DDTo.Value Then
            DDTo.Value = DDFrom.Value
        End If
    End Sub

    Private Sub DDTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DDTo.ValueChanged
        If DDFrom.Value > DDTo.Value Then
            DDFrom.Value = DDTo.Value
        End If
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        'Dim cryRpt As New ReportDocument

        ''Dim Count As Integer = clbBranches.CheckedItems.Count
        'Dim brnch(100) As String
        'Dim i As Integer = 0

        'For Each itemChecked In clbBranches.CheckedItems
        '    brnch(i) = itemChecked.ToString
        '    i = i + 1
        'Next

        'Dim reportType As String = "ST"
        'Dim DateFrom As Date = DDFrom.Value
        'Dim DateTo As Date = DDTo.Value
        'cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
        'cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

        'Dim crTableLogoninfos As New TableLogOnInfos
        'Dim crTableLogoninfo As New TableLogOnInfo
        'Dim crConnectionInfo As New ConnectionInfo

        ''q.generateTransactionsRep(DateFrom, DateTo, brnch, cryRpt, i)
        'cr.ReportSource = cryRpt
        'cr.Refresh()
        Dim isChecked As Boolean
        Dim selectedBranch As String = ""
        Dim cryRpt As New ReportDocument
        Dim reportType As String = "ST-L"
        Dim DateFrom As Date = DDFrom.Value
        Dim DateTo As Date = DDTo.Value

        For i As Integer = 0 To clbBranches.Items.Count - 1
            If clbBranches.GetItemChecked(i) = True Then
                isChecked = True
                Exit For
            Else
            End If
        Next

        If isChecked = True Then
            For Each chk As String In clbBranches.CheckedItems
                selectedBranch &= "'" + chk & "', "
            Next
            selectedBranch = selectedBranch.Remove(selectedBranch.Length - 2, 2)
        ElseIf isChecked = False Then

            For Each chk As String In clbBranches.Items
                selectedBranch &= "'" + chk & "', "
            Next
            selectedBranch = selectedBranch.Remove(selectedBranch.Length - 2, 2)
        Else

        End If

        cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
        cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        q.generateTransactionsRep(DateFrom, DateTo, selectedBranch, cryRpt)
        cr.ReportSource = cryRpt
        cr.Refresh()
    End Sub

    Private Sub ST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear list box
        clbBranches.Items.Clear()
        quer.loadBranch(clbBranches)

        'check if branches is null
        If clbBranches.Items.Count > 0 Then
            'do nothing
        Else
            btnGenerateReport.Enabled = False
        End If
    End Sub
End Class