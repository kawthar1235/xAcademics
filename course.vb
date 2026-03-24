Option Strict On
Option Infer On
Namespace KFUPMSchedule
    Public Class Course
        Public Property Dep As String
        Public Property Number As String
        Public Property Title As String
        Public Sub New(dep As String, number As String, title As String)
            Me.Dep = dep : Me.Number = number : Me.Title = title
        End Sub
        Public Overrides Function ToString() As String
            Return $"{Dep} {Number} - {Title}"
        End Function
    End Class
End Namespace
