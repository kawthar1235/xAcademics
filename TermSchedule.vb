Option Strict On
Option Infer On
Imports System.Linq
Namespace KFUPMSchedule
    Public Class TermSchedule
        Public Property Sections As List(Of Section) = New List(Of Section)()

        Public Function FindSectionByCRN(crn As String) As Section
            Return Sections.FirstOrDefault(Function(s) String.Equals(s.CRN, crn, StringComparison.OrdinalIgnoreCase))
        End Function

        Public Shared Function MeetingsForDay(secs As IEnumerable(Of Section),
                                              day As DayOfWeekKFUPM) As IEnumerable(Of Meeting)
            Return From s In secs From m In s.Meetings
                   Where m.Day = day Select m
        End Function
    End Class
End Namespace
