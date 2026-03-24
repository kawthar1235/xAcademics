Option Strict On
Option Infer On
Imports System.Drawing
Namespace KFUPMSchedule
    Public Class Building
        Public Property Code As String
        Public Property MapPosition As PointF
        Public Sub New(code As String, position As PointF)
            Me.Code = code : Me.MapPosition = position
        End Sub
    End Class
End Namespace

