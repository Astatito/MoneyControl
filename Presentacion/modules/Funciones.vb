Module Funciones

    'Funciones para pasar de tipo Date a String y viceversa en formato ISO 8601 (YYYY-MM-DD).
    Public Function FormatearFechaSQLite(ByVal fecha As Date) As String
        Return fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString()
    End Function

    Public Function FormatearFechaSQLite(ByVal fecha As String) As Date
        Dim fechaFormateada As String() = fecha.Split("-")
        Return New Date(fechaFormateada(0), fechaFormateada(1), fechaFormateada(2))
    End Function

    'Función para obtener el hash de un string
    Public Function SHA1Hash(ByVal texto As String)
        Dim crypter As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(texto)
        ByteString = crypter.ComputeHash(bytestring)

        Dim hash As String = Nothing
        For Each bt As Byte In ByteString
            hash += bt.ToString("x2")
        Next

        Return hash
    End Function
End Module
