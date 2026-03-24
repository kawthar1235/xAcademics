Option Strict On
Option Infer On
Namespace KFUPMSchedule
    Public Class Section
        Public Property CRN As String
        Public Property Course As course
        Public Property SectionCode As String
        Public Property Meetings As List(Of Meeting)
        Public Sub New(crn As String, course As course, sectionCode As String)
            Me.CRN = crn : Me.Course = course : Me.SectionCode = sectionCode
            Me.Meetings = New List(Of Meeting)()
        End Sub
    End Class
End Namespace
