Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNTipoCategoria

    Private _ADTipoCategoria As New ADTipoCategoria() 'Objeto perteneciente a la capa de Acceso a Datos.

    'Obtener todos los tipos de categorías.
    Public Function ObtenerTodos()
        Return _ADTipoCategoria.ObtenerTodos()
    End Function

    'Obtener un tipo de categoría de la BD a partir de un nombre
    Public Function ObtenerPorTipo(ByVal tipoCategoria As String)
        Return _ADTipoCategoria.ObtenerPorTipo(tipoCategoria)
    End Function

End Class
