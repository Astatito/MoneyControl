Imports Entidades
Imports AccesoDatos

Public Class LNConfiguracion

    Private _ADConfiguracion As New ADConfiguracion() 'Objeto perteneciente a la capa de Acceso a Datos.

    'Actualizar la configuración.
    Public Sub ActualizarTodo(ByVal newConfig As EConfiguracion, ByVal oldConfig As EConfiguracion)
        _ADConfiguracion.ActualizarTodo(newConfig, oldConfig)
    End Sub

    'Obtener la configuración.
    Public Function ObtenerConfiguracion() As EConfiguracion
        Return _ADConfiguracion.ObtenerConfiguracion()
    End Function

End Class
