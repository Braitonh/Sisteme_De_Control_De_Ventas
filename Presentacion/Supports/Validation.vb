Imports System.ComponentModel.DataAnnotations

Public Class Validation

    Private context As ValidationContext
    Private result As List(Of ValidationResult)
    Private valid As Boolean
    Private message As String

    Public Sub New(instance As Object)

        context = New ValidationContext(instance)
        result = New List(Of ValidationResult)
        valid = Validator.TryValidateObject(instance, context, result, True)

    End Sub

    Public Function validate() As Boolean

        If valid = False Then

            For Each item As ValidationResult In result

                message += item.ErrorMessage + vbNewLine

            Next
            MessageBox.Show(message)

        End If

        Return valid

    End Function

End Class
