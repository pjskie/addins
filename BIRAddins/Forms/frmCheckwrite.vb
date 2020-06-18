Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmCheckwrite
    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub txtRefID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRefID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtVendor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVendor.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub

    Private Sub txtdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDate.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub

    Private Sub txtamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub

    Private Sub txtamounttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountTxt.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then e.KeyChar = ""
    End Sub

    Private Sub btnGenerateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateReport.Click
        If txtRefID.Text <> "" And txtVendor.Text <> "" And txtDate.Text <> "" And txtAmount.Text <> "" And txtAmountTxt.Text <> "" Then
            Dim crTableLogoninfos As New TableLogOnInfos
            Dim crTableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo

            cryRpt.Load(My.Application.Info.DirectoryPath + "\Checkwrite.rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")
            GenerateCheck()

            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Else
            MessageBox.Show("Please fill all Fields before Generating Document", _
            "Critical Warning", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub GenerateCheck()

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue


        'Checknumber font size
        crParameterDiscreteValue.Value = txtRefID.Text
        crParameterFieldDefinitions =
        cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
        crParameterFieldDefinitions.Item("Checkey")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)


        'txtVendor font size
        crParameterDiscreteValue.Value = txtVendor.Text
        crParameterFieldDefinitions =
        cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
        crParameterFieldDefinitions.Item("txtVendor")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'txtDate
        crParameterDiscreteValue.Value = txtDate.Text
        crParameterFieldDefinitions =
        cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
        crParameterFieldDefinitions.Item("txtDate")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'txtAmount font size
        crParameterDiscreteValue.Value = txtAmount.Text
        crParameterFieldDefinitions =
        cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
        crParameterFieldDefinitions.Item("txtAmount")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'txtAmountTxt font size
        crParameterDiscreteValue.Value = txtAmountTxt.Text
        crParameterFieldDefinitions =
        cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
        crParameterFieldDefinitions.Item("txtAmountTxt")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    End Sub
End Class