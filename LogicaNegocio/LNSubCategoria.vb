Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNSubCategoria

    Private _ADSubCategoria As New ADSubCategoria() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function validarSubCategoria(subCategoria As ESubCategoria)
        sb.Clear()

        If String.IsNullOrEmpty(subCategoria.Nombre) Then
            sb.Append(Environment.NewLine + "Debe ingresar un nombre.")
        ElseIf Not ObtenerPorNombre(subCategoria.Nombre, subCategoria.ID) Is Nothing Then
            sb.Append(Environment.NewLine + "El nombre ingresado ya existe.")
        End If

        If subCategoria.Categoria = 0 Then
            sb.Append(Environment.NewLine + "Debe seleccionar una categoría.")
        End If

        Return sb.Length = 0
    End Function

    'Insertar una subcategoría.
    Public Sub Insertar(subCategoria As ESubCategoria)
        If validarSubCategoria(subCategoria) Then
            _ADSubCategoria.Insertar(subCategoria)
        End If
    End Sub

    'Actualizar una subcategoría.
    Public Sub Actualizar(subCategoria As ESubCategoria)
        If validarSubCategoria(subCategoria) Then
            _ADSubCategoria.Actualizar(subCategoria)
        End If
    End Sub

    'Eliminar una subcategoría.
    Public Sub Eliminar(ByVal idCategoria As Integer)
        _ADSubCategoria.Eliminar(idCategoria)
    End Sub

    'Obtener todas las subcategorías.
    Public Function ObtenerTodos()
        Return _ADSubCategoria.ObtenerTodos()
    End Function

    Public Function ObtenerTodosFull()
        Return _ADSubCategoria.ObtenerTodosFull()
    End Function

    'Obtener todas las subcategorías de una categoría.
    Public Function ObtenerPorCategoria(ByVal idCategoria As Integer)
        Return _ADSubCategoria.ObtenerPorCategoria(idCategoria)
    End Function

    Public Function ObtenerPorCategoriaFull(ByVal idCategoria As Integer)
        Return _ADSubCategoria.ObtenerPorCategoriaFull(idCategoria)
    End Function

    'Obtener una subcategoría a partir de un ID.
    Public Function ObtenerPorID(ByVal idCategoria As Integer)
        Return _ADSubCategoria.ObtenerPorID(idCategoria)
    End Function

    'Obtener una subcategorías a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idSubCategoria As Integer)
        Return _ADSubCategoria.ObtenerPorNombre(nombre, idSubCategoria)
    End Function

End Class
