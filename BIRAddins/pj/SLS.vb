Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.ComponentModel

Public Class SLS
    Dim FilterReport As New filterRp
    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub SLS_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbxYear.Text = Date.Now.Year
        For i As Integer = 0 To 9
            cbxYear.Items.Add(Date.Now.Year - i)
        Next
        cbxYear.SelectedIndex = -1
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        If cbxYear.SelectedIndex = -1 And cbxQuarter.SelectedIndex = -1 Then
            MsgBox("Select Valid Data!")
            cbxYear.Select()
        Else
            If cbxYear.SelectedIndex = -1 Then
                MsgBox("Select Valid Data!")
                cbxYear.Select()
            ElseIf cbxQuarter.SelectedIndex = -1 Then
                MsgBox("Select Valid Data!")
                cbxQuarter.Select()
            Else


                Dim reportType As String = "QAP"
                Dim year As Date = cbxYear.SelectedItem.ToString() + "-01-01".ToString()
                Dim qtr As String = cbxQuarter.SelectedItem.ToString()
                Dim brnch As String = ""

                cryRpt.Load(My.Application.Info.DirectoryPath + "\" + reportType + ".rpt")
                cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")

                Dim crTableLogoninfos As New TableLogOnInfos
                Dim crTableLogoninfo As New TableLogOnInfo
                Dim crConnectionInfo As New ConnectionInfo

                FilterReport.generateSAWT(year, qtr, brnch, cryRpt)
                cr.ReportSource = cryRpt
                cr.Refresh()
            End If
        End If
    End Sub
End Class