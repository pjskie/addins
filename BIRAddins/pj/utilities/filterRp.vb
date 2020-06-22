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
    Private errMsg As String

    Public Sub generateQuarterlyRep(ByVal y As Date,
                              ByVal q As String,
                              ByVal b() As String,
                              ByVal CryRpt As ReportDocument,
                              ByVal Count As Integer)
        errMsg = ""
        Try
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

            crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions("brnch")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            For i = 0 To Count - 1
                If i > 0 Then
                    crParameterDiscreteValue = Nothing
                End If
                crParameterDiscreteValue = New ParameterDiscreteValue()
                crParameterDiscreteValue.Value = b(i)
                crParameterValues.Add(crParameterDiscreteValue)
            Next
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            crParameterDiscreteValue.Value = q
            crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("qtr")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        Catch ex As Exception
            'CAPTURE
            errMsg = "Error: " & vbNewLine & ex.Message
        End Try

    End Sub

    Public Sub generateTransactionsRep(ByVal str As Date,
                              ByVal stp As Date,
                              ByVal b() As String,
                              ByVal CryRpt As ReportDocument,
                              ByVal Count As Integer)
        errMsg = ""
        Try
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

            crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
            crParameterFieldDefinition = crParameterFieldDefinitions("brnch")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            For i = 0 To Count - 1
                If i > 0 Then
                    crParameterDiscreteValue = Nothing
                End If
                crParameterDiscreteValue = New ParameterDiscreteValue()
                crParameterDiscreteValue.Value = b(i)
                crParameterValues.Add(crParameterDiscreteValue)
            Next
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        Catch ex As Exception
            'CAPTURE
            errMsg = "Error: " & vbNewLine & ex.Message
        End Try

    End Sub

End Class
