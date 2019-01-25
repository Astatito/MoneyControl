Module Functions

    'Función para pasar de formato Date a String y viceversa (formato utilizado: YYYY-MM-DD).
    Public Function FormatearFechaSQLite(ByVal fecha As Date) As String
        Return fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString()
    End Function

    Public Function FormatearFechaSQLite(ByVal fecha As String) As Date
        Dim fechaFormateada As String() = fecha.Split("-")
        Return New Date(fechaFormateada(0), fechaFormateada(1), fechaFormateada(2))
    End Function

    'Función a nivel de presentación para determinar si el valor ingresado es un número valido o no.
    Public Function EsNumero(ByVal numero As String) As Boolean
        Return IsNumeric(numero)
    End Function

End Module
