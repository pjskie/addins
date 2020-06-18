Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPurchaseJournal

    Dim cryRpt As New ReportDocument
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

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
            Dim crTableLogoninfos As New TableLogOnInfos
            Dim crTableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo

            cryRpt.Load(My.Application.Info.DirectoryPath + "\Purchase Journal.rpt")
            cryRpt.SetDatabaseLogon("sa", "Bu1ldm0r3.SBO")
            getFilterType()

            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
        Else
            MessageBox.Show("Please Select Branch")
        End If

    End Sub

    Private Sub getFilterType()

        If RadioDocument.Checked = True Then
            Dim DateType As String = "D"

            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldDefinition As ParameterFieldDefinition
            Dim crParameterValues As New ParameterValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = DateType
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateType")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = DDFrom.Text
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateFrom")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = DDTo.Text
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateTo")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            Dim Count As Integer = CheckedListBox1.SelectedItems.Count
            Dim Count2 As Integer = CheckedListBox1.Items.Count
            If CheckedListBox1.CheckedItems.Count > 0 Then

                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Branch")
                For i = 0 To Count - 1
                    If i > 0 Then
                        crParameterDiscreteValue = Nothing
                    End If
                    crParameterDiscreteValue = New ParameterDiscreteValue
                    crParameterDiscreteValue.Value = CheckedListBox1.CheckedItems(i)
                    crParameterValues.Add(crParameterDiscreteValue)
                Next

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            Else
            End If

        Else
            Dim DateType As String = "P"

            Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            Dim crParameterFieldDefinition As ParameterFieldDefinition
            Dim crParameterValues As New ParameterValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = DateType
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateType")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = PDFrom.Text
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateFrom")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = PDTo.Text
            crParameterFieldDefinitions =
            cryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateTo")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            Dim Count As Integer = CheckedListBox1.SelectedItems.Count
            Dim Count2 As Integer = CheckedListBox1.Items.Count
            If CheckedListBox1.CheckedItems.Count > 0 Then


                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item("Branch")
                For i = 0 To Count - 1
                    If i > 0 Then
                        crParameterDiscreteValue = Nothing
                    End If
                    crParameterDiscreteValue = New ParameterDiscreteValue
                    crParameterDiscreteValue.Value = CheckedListBox1.CheckedItems(i)
                    crParameterValues.Add(crParameterDiscreteValue)
                Next

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
            Else
            End If
        End If
    End Sub

    Private Sub frmPurchaseJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class