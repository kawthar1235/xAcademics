Option Strict On
Option Infer On
Imports System.Linq
Namespace KFUPMSchedule
    Public Class RouteResult
        Public Property [Day] As DayOfWeekKFUPM
        Public Property OrderedSectionsOfDay As List(Of Section)
        Public Property CourseCount As Integer
        Public Property DistinctBuildings As Integer
        Public Property DistinctBuildingsMeters As Double
        Public Property CourseNames As List(Of String)

        Public Sub New(day As DayOfWeekKFUPM, secs As IEnumerable(Of Section))
            Me.Day = day
            ' رتب حسب وقت البداية لأول ميتنق في ذلك اليوم
            OrderedSectionsOfDay = (From s In secs
                                    Let todays = s.Meetings.Where(Function(m) m.Day = day)
                                    Where todays.Any()
                                    Order By todays.Min(Function(m) m.Start)
                                    Select s).ToList()

            CourseCount = OrderedSectionsOfDay.Count
            CourseNames = OrderedSectionsOfDay.Select(Function(s) s.Course.ToString()).ToList()

            Dim seqBuildings = OrderedSectionsOfDay.
                Select(Function(s) s.Meetings.
                    Where(Function(m) m.Day = day).
                    OrderBy(Function(m) m.Start).
                    Select(Function(m) m.Building)).
                SelectMany(Function(x) x).
                ToList()

            DistinctBuildings = seqBuildings.Select(Function(b) b.Code).Distinct(StringComparer.OrdinalIgnoreCase).Count()
            Dim last As Building = Nothing
            Dim meters As Double = 0
            For Each b In seqBuildings
                If last IsNot Nothing AndAlso Not String.Equals(last.Code, b.Code, StringComparison.OrdinalIgnoreCase) Then
                    meters += Distance(last, b)
                End If
                last = b
            Next
            DistinctBuildingsMeters = meters
        End Sub

        Private Shared Function Distance(a As Building, b As Building) As Double
            Dim dx = CDbl(a.MapPosition.X - b.MapPosition.X)
            Dim dy = CDbl(a.MapPosition.Y - b.MapPosition.Y)
            Return Math.Sqrt(dx * dx + dy * dy)
        End Function
    End Class
End Namespace
