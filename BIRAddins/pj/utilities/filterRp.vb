Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Data.OleDb
Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class filterRp
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Sub generateSAWT(ByVal y As Date,
                              ByVal q As String,
                              ByVal b As String,
                              ByVal CryRpt As ReportDocument)


        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = y
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("year")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = b
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("brnch")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = q
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("qtr")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
    End Sub

    Public Sub generateSalesTrans(ByVal str As Date,
                              ByVal stp As Date,
                              ByVal b As String,
                              ByVal CryRpt As ReportDocument)
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = str
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("strDate")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = stp
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("stpDate")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crParameterDiscreteValue.Value = b
        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("brnch")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
    End Sub

End Class
