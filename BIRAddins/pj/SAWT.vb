Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.ComponentModel

Public Class SAWT

    Private q As New filterRp
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private quer As New query
    Private errMsg As String

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        errMsg = ""
        Try
            Dim cryRpt As New ReportDocument

            'Dim Count As Integer = clbBranches.CheckedItems.Count
            Dim brnch(100) As String
            Dim i As Integer = 0

            For Each itemChecked In clbBranches.CheckedItems
                brnch(i) = itemChecked.ToString
                i = i + 1
            Next

            If cbxYear.SelectedIndex = -1 And cbxQuarter.SelectedIndex = -1 Then
                MsgBox("Please select Year/Quarter", vbCritical, "Info")
                cbxYear.Select()
                Exit Sub
            Else
                If cbxYear.SelectedIndex = -1 Then
                    MsgBox("Please select Year", vbCritical, "Info")
                    cbxYear.Select()
                ElseIf cbxQuarter.SelectedIndex = -1 Then
                    MsgBox("Please select Quarter", vbCritical, "Info")
                    cbxQuarter.Select()
                Else

                    Dim reportType As String = "QSAWT"
                    Dim year As Date = cbxYear.SelectedItem.ToString() + "-01-01".ToString()
                    Dim qtr As String = cbxQuarter.SelectedItem.ToString()
                    cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
                    cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

                    Dim crTableLogoninfos As New TableLogOnInfos
                    Dim crTableLogoninfo As New TableLogOnInfo
                    Dim crConnectionInfo As New ConnectionInfo

                    q.generateQuarterlyRep(year, qtr, brnch, cryRpt, i)
                    cr.ReportSource = cryRpt
                    cr.Refresh()

                End If
            End If
        Catch ex As Exception
            'CAPTURE
            errMsg = "Error: " & vbNewLine & ex.Message
        Finally
            Me.Hide()
        End Try
    End Sub

    Private Sub SAWT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear list box
        clbBranches.Items.Clear()
        quer.loadBranch(clbBranches)

        cbxYear.Text = Date.Now.Year
        For i As Integer = 0 To 9
            cbxYear.Items.Add(Date.Now.Year - i)
        Next
        cbxYear.SelectedIndex = -1

        'check if branches is null
        If clbBranches.Items.Count > 0 Then
            'do nothing
        Else
            btnGenerateReport.Enabled = False
        End If
    End Sub
End Class