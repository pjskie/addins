Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInventoryBooks

    Dim FilterReport As New FilterReport

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Dim WhsCodeNumber(100) As Integer
    Dim WhsCode(100) As String

    Dim connectionString As String = "Server=172.16.50.5;Database=BUILDMORE_MAIN_DB;User Id=sa;Password=Bu1ldm0r3.SBO"
    Dim connection As New SqlConnection(connectionString)

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
    Public Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click

        Try
            Dim cryRpt As New ReportDocument
            Dim Branches(100) As String
            Dim x As Integer = 0

            For Each itemChecked In CheckedListBox1.CheckedItems
                'MessageBox.Show(WhsCode(CheckedListBox1.Items.IndexOf(itemChecked.ToString)))
                Branches(x) = WhsCode(CheckedListBox1.Items.IndexOf(itemChecked.ToString))
                x = x + 1
            Next

            Dim reportType As String = "Inventory Books"

            'If Audit.Checked = True Then
            '    reportType = "Inventory Books - InvntryAudit"
            'Else
            '    reportType = "Inventory Books - InvntryPosting"
            'End If

            Dim DateFrom As Date = DDFrom.Text
            Dim DateTo As Date = DDTo.Text

            cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

            FilterReport.InventoryBooks(DateFrom, DateTo, cryRpt, Branches)
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("Error in Generating Inventory Books", vbCrLf, ex.Message)
        End Try

    End Sub

    Public Sub frmInventoryBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim i As Integer = 0

            connection.Open()
            'Dim command As New SqlCommand("SELECT DISTINCT LOCCODE from OIVL
            'ORDER BY LOCCODE ASC", connection)
            Dim command As New SqlCommand("SELECT WhsCode, WhsName from OWHS
            WHERE DropShip <> 'y'
            ORDER BY WhsCode ASC", connection)
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            Dim index As Integer = 1

            For Each dRow As DataRow In dt.Rows

                CheckedListBox1.Items.Add(dRow.Item("WhsName"))
                WhsCode(i) = dRow.Item("WhsCode")
                WhsCodeNumber(i) = i
                i = i + 1

            Next
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error in Loading Inventory Books" & vbNewLine & vbNewLine & ex.Message)
            btnGenerateReport.Enabled = False
        End Try



    End Sub
End Class