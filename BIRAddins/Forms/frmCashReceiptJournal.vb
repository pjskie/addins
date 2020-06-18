﻿Imports System.Data
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

    Dim connectionString As String = "Server=172.16.50.5;Database=BUILDMORE_MAIN_DB;User Id=sa;Password=Bu1ldm0r3.SBO"
    Dim connection As New SqlConnection(connectionString)

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
            Dim form As Form = Me

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

    Private Sub frmCashReceiptJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()
        Dim command As New SqlCommand("SELECT BPLNAME from OBPL 
        WHERE MAINBPL = 'N' AND DISABLED = 'N'
        ORDER BY BPLID ASC", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim dt As New DataTable()
        dt.Load(reader)
        Dim index As Integer = 1
        For Each dRow As DataRow In dt.Rows

            'If dRow.Item("Levels") = 1 Then
            '    CheckedListBox1.Items.Add("-" + dRow.Item("AcctName"))
            'Else
            CheckedListBox1.Items.Add(dRow.Item("BPLName"))
            'End If

        Next
        connection.Close()

    End Sub
End Class