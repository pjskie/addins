﻿Imports System.Data.SqlClient
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
    Private errMsg As String
    Private ifErr As Boolean = False

    Private Sub SLS_Load(sender As Object, e As EventArgs) Handles Me.Load
        'year
        cbxYear.Text = Date.Now.Year
        For i As Integer = 0 To 9
            cbxYear.Items.Add(Date.Now.Year - i)
        Next
        cbxYear.SelectedIndex = -1

        'Clear list box
        clbBranches.Items.Clear()
        quer.loadBranch(clbBranches)

        If clbBranches.Items.Count > 0 Then
            'do nothing
        Else
            btnGenerateReport.Enabled = False
        End If

    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        'Dim Count As Integer = clbBranches.CheckedItems.Count
        Dim brnch(100) As String
        Dim i As Integer = 0

        For Each itemChecked In clbBranches.CheckedItems
            brnch(i) = itemChecked.ToString
            i = i + 1
        Next

        If cbxYear.SelectedIndex = -1 And cbxQuarter.SelectedIndex = -1 Then
            MsgBox("Please select Year/Quarter", vbCritical, "Error")
            cbxYear.Select()
            Exit Sub
        Else
            If cbxYear.SelectedIndex = -1 Then
                MsgBox("Please select Year", vbCritical, "Error")
                cbxYear.Select()
            ElseIf cbxQuarter.SelectedIndex = -1 Then
                MsgBox("Please select Quarter", vbCritical, "Error")
                cbxQuarter.Select()
            Else

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

            End If
        End If
    End Sub
End Class