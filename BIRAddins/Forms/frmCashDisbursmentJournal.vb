﻿Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmCashDisbursmentJournal
    Dim FilterReport As New FilterReport

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private quer As New query

    'Dim connectionString As String = "Server=172.16.50.5;Database=BUILDMORE_MAIN_DB;User Id=sa;Password=Bu1ldm0r3.SBO"
    'Dim connection As New SqlConnection(dbConn.DBCon)

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

        Try
            Dim cryRpt As New ReportDocument
            Dim reportType As String = "Cash Disbursment Journal"
            Dim DateType As String
            Dim DateFrom As Date
            Dim DateTo As Date
            Dim Count As Integer = CheckedListBox1.CheckedItems.Count
            Dim Branches(100) As String
            Dim i As Integer = 0


            For Each itemChecked In CheckedListBox1.CheckedItems
                Branches(i) = itemChecked.ToString
                i = i + 1
            Next

            If RadioDocument.Checked = True Then
                DateType = "D"
                DateFrom = DDFrom.Text
                DateTo = DDTo.Text
            Else
                DateType = "P"
                DateFrom = PDFrom.Text
                DateTo = PDTo.Text
            End If

            cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

            FilterReport.Filter(DateType, DateFrom, DateTo, reportType, cryRpt, Branches, i)

            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("Error in Generating Cash Disbursment Journal", vbCrLf, ex.Message)
        End Try



    End Sub

    Private Sub frmCashDisbursmentJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim message As String = ""

        Try
            'connection.Open()
            'Dim command As New SqlCommand("SELECT BPLNAME from OBPL 
            'WHERE MAINBPL = 'N' AND DISABLED = 'N'
            'ORDER BY BPLID ASC", connection)

            'Dim reader As SqlDataReader = command.ExecuteReader()
            'Dim dt As New DataTable()
            'dt.Load(reader)
            'Dim index As Integer = 1

            'For Each dRow As DataRow In dt.Rows

            '    CheckedListBox1.Items.Add(dRow.Item("BPLName"))

            'Next

            'connection.Close()

            CheckedListBox1.Items.Clear()
            quer.loadBranch(CheckedListBox1)

        Catch ex As Exception
            MessageBox.Show("Error in Loading Cash Disbursment Journal" & vbNewLine & vbNewLine & ex.Message)
            btnGenerateReport.Enabled = False
        End Try


    End Sub
End Class