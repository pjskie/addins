Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInventoryBooks

    Dim FilterReport As New FilterReport

    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
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
    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click

        If CheckedListBox1.CheckedItems.Count > 0 Then
            Dim reportType As String = "Inventory Books"

            Dim DateFrom As Date = DDFrom.Text
            Dim DateTo As Date = DDTo.Text

            cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")


            FilterReport.InventoryBooks(DateFrom, DateTo, cryRpt)
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Else
            MessageBox.Show("Please Select Branch")
        End If

    End Sub

    Private Sub frmInventoryBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class