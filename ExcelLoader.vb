Imports System.IO
Imports OfficeOpenXml
Imports Microsoft.Office.Interop.Excel

Namespace KFUPMSchedule
    Module ExcelLoader

        Public Function LoadScheduleFromExcel(path As String) As List(Of String)
            Dim result As New List(Of String)

            Try
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial

                If Not File.Exists(path) Then
                    Throw New FileNotFoundException("File not found.")
                End If

                Using package As New ExcelPackage(New FileInfo(path))
                    Dim worksheet = package.Workbook.Worksheets(0)
                    Dim rowCount As Integer = worksheet.Dimension.Rows

                    For row = 2 To rowCount
                        Dim crn = worksheet.Cells(row, 1).Text
                        Dim course = worksheet.Cells(row, 2).Text
                        Dim dept = worksheet.Cells(row, 3).Text
                        Dim sec = worksheet.Cells(row, 4).Text
                        Dim title = worksheet.Cells(row, 5).Text
                        Dim startT = worksheet.Cells(row, 8).Text
                        Dim endT = worksheet.Cells(row, 9).Text

                        result.Add($"CRN: {crn}, Course: {course}, Dept: {dept}, Sec: {sec}, Title: {title}, Start: {startT}, End: {endT}")
                    Next
                End Using

            Catch ex As Exception
                result.Add("Error: " & ex.Message)
            End Try

            Return result
        End Function

    End Module
End Namespace
