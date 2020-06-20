Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.ComponentModel

Public Class SLS
    Dim q As New filterRp
    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private quer As New query

    Private Sub SLS_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbxYear.Text = Date.Now.Year
        For i As Integer = 0 To 9
            cbxYear.Items.Add(Date.Now.Year - i)
        Next
        cbxYear.SelectedIndex = -1

        'Clear list box
        clbBranches.Items.Clear()
        quer.loadBranch(clbBranches)
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
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
                MsgBox("Please select Year", vbInformation, "Info")
                cbxYear.Select()
            ElseIf cbxQuarter.SelectedIndex = -1 Then
                MsgBox("Please select Quarter", vbInformation, "Info")
                cbxQuarter.Select()
            Else
                If clbBranches.CheckedItems.Count > 0 Then
                    Dim reportType As String = "QAP"
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
                Else
                    MsgBox("Please select Branch", vbInformation, "Info")
                    cbxQuarter.Select()
                End If
            End If
        End If
    End Sub
End Class