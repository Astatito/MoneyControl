Module Funciones

    'Funciones para pasar de tipo Date a String y viceversa en formato ISO 8601 (YYYY-MM-DD).
    Public Function FormatearFechaSQLite(ByVal fecha As Date) As String
        Return fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString()
    End Function

    Public Function FormatearFechaSQLite(ByVal fecha As String) As Date
        Dim fechaFormateada As String() = fecha.Split("-")
        Return New Date(fechaFormateada(0), fechaFormateada(1), fechaFormateada(2))
    End Function
End Module
