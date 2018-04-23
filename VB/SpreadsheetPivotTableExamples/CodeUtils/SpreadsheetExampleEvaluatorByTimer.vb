Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SpreadsheetPivotTableExamples
    #Region "SpreadsheetExampleEvaluatorByTimer"
    Public Class SpreadsheetExampleEvaluatorByTimer
        Inherits ExampleEvaluatorByTimer

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
            If language = ExampleLanguage.VB Then
                Return New SpreadsheetVbExampleCodeEvaluator()
            End If
            Return New SpreadsheetCSExampleCodeEvaluator()
        End Function
    End Class
    #End Region
End Namespace
