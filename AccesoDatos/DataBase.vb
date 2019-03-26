Imports System.Configuration

Module DataBase
    Public ReadOnly connString As String = ConfigurationManager.ConnectionStrings("cnnString").ToString() 'Cadena de conexión
    Public ReadOnly connStringReadOnly As String = ConfigurationManager.ConnectionStrings("cnnStringReadOnly").ToString() 'Cadena de conexión de sólo lectura
End Module
