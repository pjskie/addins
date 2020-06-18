Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class PT
    Private q As New filterRp
    Dim cryRpt As New ReportDocument
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
        Dim reportType As String = "PT"
        Dim DateFrom As Date = DDFrom.Value
        Dim DateTo As Date = DDTo.Value
        Dim brnch As String = ""
        cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
        cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        q.generateSalesTrans(DateFrom, DateTo, brnch, cryRpt)
        cr.ReportSource = cryRpt
        cr.Refresh()
    End Sub

    Private Sub PT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear list box
        clbBranches.Items.Clear()
        quer.loadBranch()
    End Sub
End Class