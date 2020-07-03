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
                      ByVal reportType As String,
                      ByVal CryRpt As ReportDocument,
                      ByVal Branches() As String,
                      ByVal Count As Integer)

        ' Cash Receipts Journal
        ' Check Disbursment Journal
        ' Cash Disbursment Journal
        ' Credit Memo Register
        ' Debit Memo Register
        ' Purchase Journal
        ' Sales Journalx

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue
        Dim SSPO = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

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

        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions("Branch")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        For i = 0 To Count - 1
            If i > 0 Then
                crParameterDiscreteValue = Nothing
            End If
            crParameterDiscreteValue = New ParameterDiscreteValue()
            crParameterDiscreteValue.Value = Branches(i)
            crParameterValues.Add(crParameterDiscreteValue)
        Next
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)


    End Sub

    Public Sub InventoryBooks(ByVal DateFrom As Date,
                              ByVal DateTo As Date,
                              ByVal CryRpt As ReportDocument,
                              ByVal Branches() As String)

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        Dim Count As Integer = frmInventoryBooks.CheckedListBox1.CheckedItems.Count
        Dim AllWhse As String

        If Count > 0 Then
            AllWhse = "N"
        Else
            AllWhse = "Y"
        End If

        'crParameterDiscreteValue.Value = AllWhse
        'crParameterFieldDefinitions =
        '    CryRpt.DataDefinition.ParameterFields
        'crParameterFieldDefinition =
        '    crParameterFieldDefinitions.Item("AllWhse")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

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

        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions("Warehouse")
        crParameterValues = crParameterFieldDefinition.CurrentValues



        For i = 0 To Count - 1
            If i > 0 Then
                crParameterDiscreteValue = Nothing
            End If
            crParameterDiscreteValue = New ParameterDiscreteValue()
            'MessageBox.Show(Branches(i))
            crParameterDiscreteValue.Value = Branches(i)
            crParameterValues.Add(crParameterDiscreteValue)
        Next
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    End Sub

    Public Sub GeneralJournal(ByVal DateFrom As Date,
                          ByVal DateTo As Date,
                          ByVal CryRpt As ReportDocument)

        Dim crTableLogoninfos As New TableLogOnInfos
        Dim crTableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue
        Dim SSPO = New CrystalDecisions.CrystalReports.Engine.ReportDocument()

        frmGeneralLedger.CrystalReportViewer1.ReportSource = Nothing
        frmGeneralLedger.CrystalReportViewer1.Refresh()

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

        crParameterFieldDefinitions = CryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions("AccountName")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        Dim Count As Integer = frmGeneralLedger.CheckedListBox1.CheckedItems.Count

        For i = 0 To Count - 1
            If i > 0 Then
                crParameterDiscreteValue = Nothing
            End If
            crParameterDiscreteValue = New ParameterDiscreteValue()
            crParameterDiscreteValue.Value = frmGeneralLedger.CheckedListBox1.CheckedItems(i)
            crParameterValues.Add(crParameterDiscreteValue)
        Next
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    End Sub

End Class
