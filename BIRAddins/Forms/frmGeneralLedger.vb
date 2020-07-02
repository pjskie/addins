Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmGeneralLedger

    Dim FilterReport As New FilterReport

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Dim connectionString As String = "Server=172.16.50.5;Database=BCD_TEST_DB;User Id=sa;Password=Bu1ldm0r3.SBO"
    Dim connection As New SqlConnection(connectionString)

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
    Private Sub frmGeneralLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'where CurrTotal > 0
            connection.Open()
            Dim command As New SqlCommand("SELECT Levels, AcctName from OACT where CurrTotal > 0 ORDER BY GROUPMASK, GRPLINE ASC", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            Dim index As Integer = 1
            For Each dRow As DataRow In dt.Rows

                'If dRow.Item("Levels") = 1 Then
                '    CheckedListBox1.Items.Add("-" + dRow.Item("AcctName"))
                'Else
                CheckedListBox1.Items.Add(dRow.Item("AcctName"))
                'End If

            Next
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Loading General Ledger" & vbNewLine & vbNewLine & ex.Message)
            btnGenerateReport.Enabled = False
        End Try



    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click


        Try
            Dim reportType As String = "General Journal"

            Dim DateFrom As Date = DDFrom.Text
            Dim DateTo As Date = DDTo.Text
            Dim cryRpt As New ReportDocument

            cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")


            FilterReport.GeneralJournal(DateFrom, DateTo, cryRpt)
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("Error in Generating General Ledger", vbCrLf, ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Try
            CheckedListBox1.Items.Clear()
            'And where CurrTotal > 0
            connection.Open()
            Dim command As New SqlCommand("SELECT AcctName from OACT WHERE ACCTNAME LIKE '%" + txtSearch.Text + "%' And CurrTotal > 0 ORDER BY GROUPMASK, GRPLINE ASC", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            For Each dRow As DataRow In dt.Rows
                CheckedListBox1.Items.Add(dRow.Item("AcctName"))
            Next
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Loading General Ledger" & vbNewLine & vbNewLine & ex.Message)
            btnGenerateReport.Enabled = False
        End Try

    End Sub
End Class