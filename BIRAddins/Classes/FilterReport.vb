Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FilterReport

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub Filter(ByVal DateType As String,
                      ByVal DateFrom As Date,
                      ByVal DateTo As Date,
                      ByVal Branch As String,
                      ByVal reportType As String,
                      ByVal CryRpt As ReportDocument)

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = DateType
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateType")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = DateFrom
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateFrom")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = DateTo
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateTo")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'Dim Count As Integer = CheckedListBox1.SelectedItems.Count
        'Dim Count2 As Integer = CheckedListBox1.Items.Count
        'If CheckedListBox1.CheckedItems.Count > 0 Then

        '    crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        '    crParameterFieldDefinition = crParameterFieldDefinitions.Item("Branch")
        '    For i = 0 To Count - 1
        '        If i > 0 Then
        '            crParameterDiscreteValue = Nothing
        '        End If
        '        crParameterDiscreteValue = New ParameterDiscreteValue
        '        crParameterDiscreteValue.Value = CheckedListBox1.CheckedItems(i)
        '        crParameterValues.Add(crParameterDiscreteValue)
        '    Next

        crParameterDiscreteValue.Value = Branch
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("Branch")
        crParameterValues = crParameterFieldDefinition.CurrentValues


        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        'Else
        'End If

    End Sub

    Public Sub InventoryBooks(ByVal DateFrom As Date,
                              ByVal DateTo As Date,
                              ByVal CryRpt As ReportDocument)

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = DateFrom
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateFrom")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = DateTo
        crParameterFieldDefinitions =
            CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition =
            crParameterFieldDefinitions.Item("DateTo")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    End Sub


End Class
