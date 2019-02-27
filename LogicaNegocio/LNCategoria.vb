Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNCategoria

    Private _ADCategoria As New ADCategoria() 'Objeto perteneciente a la capa de Acceso a Datos.
    Private _LNSubCategoria As New LNSubCategoria() 'Objeto perteneciente a la capa de Lógica de Negocios.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function ValidarCategoria(categoria As ECategoria) As Boolean
        sb.Clear()

        If String.IsNullOrEmpty(categoria.Nombre) Then
            sb.Append("Debe ingresar un nombre." + Environment.NewLine)
        ElseIf Not ObtenerPorNombre(categoria.Nombre, categoria.ID) Is Nothing Then
            sb.Append("El nombre ingresado ya existe." + Environment.NewLine)
        End If

        If String.IsNullOrEmpty(categoria.TipoMovimiento) Then
            sb.Append("Debe seleccionar un tipo de categoría." + Environment.NewLine)
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
    Public Sub Eliminar(ByVal idCategoria As Integer, ByVal tipoCategoria As String, ByVal config As EConfiguracion)
        _ADCategoria.Eliminar(idCategoria, tipoCategoria, config)
    End Sub

    'Obtener todas las categorías.
    Public Function ObtenerTodos() As List(Of ECategoria)
        Return _ADCategoria.ObtenerTodos()
    End Function

    'Obtener todas las categorías de ingresos.
    Public Function ObtenerIngresos() As List(Of ECategoria)
        Return _ADCategoria.ObtenerIngresos()
    End Function

    'Obtener todas las categorías de gastos.
    Public Function ObtenerGastos() As List(Of ECategoria)
        Return _ADCategoria.ObtenerGastos()
    End Function

    'Obtener una categoría a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCategoria As Integer) As ECategoria
        Return _ADCategoria.ObtenerPorNombre(nombre, idCategoria)
    End Function

End Class
