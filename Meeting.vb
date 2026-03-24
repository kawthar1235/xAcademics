Option Strict On
Option Infer On
Namespace KFUPMSchedule
    Public Class Meeting
        Public Property [Day] As DayOfWeekKFUPM
        Public Property Start As TimeSpan
        Public Property [End] As TimeSpan
        Public Property Building As Building
        Public Property Room As String
        Public Property ActivityType As String
        Public Sub New(day As DayOfWeekKFUPM, start As TimeSpan, [end] As TimeSpan,
                       building As Building, room As String, activityType As String)
            Me.Day = day : Me.Start = start : Me.End = [end]
            Me.Building = building : Me.Room = room : Me.ActivityType = activityType
        End Sub
    End Class
End Namespace
