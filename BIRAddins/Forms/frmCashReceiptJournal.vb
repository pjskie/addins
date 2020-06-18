
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmCashReceiptJournal

    Dim FilterReport As New FilterReport

    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub RadioPosting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioDocument.CheckedChanged
        PDFrom.Enabled = False
        PDTo.Enabled = False

        DDFrom.Enabled = True
        DDTo.Enabled = True
    End Sub

    Private Sub RadioDocument_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioPosting.CheckedChanged
        DDFrom.Enabled = False
        DDTo.Enabled = False

        PDFrom.Enabled = True
        PDTo.Enabled = True
    End Sub
    ' Posting Date/Document Date Paremeter Validations
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
    Private Sub PDFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDFrom.ValueChanged
        If PDFrom.Value > PDTo.Value Then
            PDTo.Value = PDFrom.Value
        End If
    End Sub
    Private Sub PDTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDTo.ValueChanged
        If PDFrom.Value > PDTo.Value Then
            PDFrom.Value = PDTo.Value
        End If
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click

        If CheckedListBox1.CheckedItems.Count > 0 Then

            Dim reportType As String = "Cash Receipts Journal"

            Dim DateType As String
            Dim DateFrom As Date
            Dim DateTo As Date
            Dim Branch As String

            If RadioDocument.Checked = True Then
                DateType = "D"
                DateFrom = DDFrom.Text
                DateTo = DDTo.Text
                Branch = "KORONADAL BRANCH"
            Else
                DateType = "P"
                DateFrom = PDFrom.Text
                DateTo = PDTo.Text
                Branch = "KORONADAL BRANCH"
            End If

            cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

            FilterReport.Filter(DateType, DateFrom, DateTo, Branch, reportType, cryRpt)

            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Else
            MessageBox.Show("Please Select Branch")
        End If

    End Sub
End Class