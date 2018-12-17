Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNCategoria

    Private _ADCategoria As New ADCategoria() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function validarCategoria(categoria As ECategoria)
        sb.Clear()

        If String.IsNullOrEmpty(categoria.Nombre) Then
            sb.Append(Environment.NewLine + "Debe ingresar un nombre.")
        ElseIf Not ObtenerPorNombre(categoria) Is Nothing Then
            sb.Append(Environment.NewLine + "El nombre ingresado ya existe para ese tipo de categoría.")
        End If

        If String.IsNullOrEmpty(categoria.Tipo) Then
            sb.Append(Environment.NewLine + "Debe seleccionar un tipo de categoría.")
        End If

        Return sb.Length = 0
    End Function

    'Insertar una categoría.
    Public Sub Insertar(categoria As ECategoria)
        If validarCategoria(categoria) Then
            _ADCategoria.Insertar(categoria)
        End If
    End Sub

    'Actualizar una categoría.
    Public Sub Actualizar(categoria As ECategoria)
        If validarCategoria(categoria) Then
            _ADCategoria.Actualizar(categoria)
        End If
    End Sub

    'Eliminar una categoría.
    Public Sub Eliminar(ByVal idCategoria As Integer)
        _ADCategoria.Eliminar(idCategoria)
    End Sub

    'Obtener todas las categorías.
    Public Function ObtenerTodos()
        Return _ADCategoria.ObtenerTodos()
    End Function

    'Obtener todas las categorías de ingresos.
    Public Function ObtenerIngresos()
        Return _ADCategoria.ObtenerIngresos()
    End Function

    'Obtener todas las categorías de egresos.
    Public Function ObtenerEgresos()
        Return _ADCategoria.ObtenerEgresos()
    End Function

    'Obtener una categoría a partir de un ID.
    Public Function ObtenerPorID(ByVal idCategoria As Integer)
        Return _ADCategoria.ObtenerPorID(idCategoria)
    End Function

    'Obtener una categoría a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal categoria As ECategoria)
        Return _ADCategoria.ObtenerPorNombre(categoria)
    End Function

End Class
