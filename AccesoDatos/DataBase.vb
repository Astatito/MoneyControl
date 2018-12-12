Imports System.Configuration

Module DataBase
    Public ReadOnly connString As String = ConfigurationManager.ConnectionStrings("cnnString").ToString() 'Cadena de conexión
End Module
