Module modTimeFunction
    Public Function NumberOfMinutes(ByVal Time1 As Date, ByVal Time2 As Date) As Integer
        Dim HoursDiff As Integer
        Dim MinutesDiff As Integer
        HoursDiff = Time1.Hour - Time2.Hour
        MinutesDiff = Time1.Minute - Time2.Minute
        Return (HoursDiff * 60) + MinutesDiff
    End Function

    Public Function ShortenTime(ByVal Fulltime As String) As String
        'Removes the seconds from the value and returns the hours and minutes
        'Fulltime is a string in the format 19:42:54 or 19.42.54
        Return Fulltime.Substring(0, 5)
    End Function
End Module
