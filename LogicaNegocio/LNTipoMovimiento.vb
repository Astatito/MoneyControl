Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNTipoMovimiento

    Private _ADTipoMovimiento As New ADTipoMovimiento() 'Objeto perteneciente a la capa de Acceso a Datos.

    'Obtener todos los tipos de movimientos.
    Public Function ObtenerTodos()
        Return _ADTipoMovimiento.ObtenerTodos()
    End Function

    'Obtener un tipo de movimiento de la BD a partir de un tipo.
    Public Function ObtenerPorTipo(ByVal tipoMovimiento As String)
        Return _ADTipoMovimiento.ObtenerPorTipo(tipoMovimiento)
    End Function

End Class
