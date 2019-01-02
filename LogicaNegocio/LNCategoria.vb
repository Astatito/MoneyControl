﻿Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNCategoria

    Private _ADCategoria As New ADCategoria() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function validarCategoria(categoria As ECategoria)
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

    'Obtener una categoría a partir de un nombre y un tipo.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCategoria As Integer)
        Return _ADCategoria.ObtenerPorNombre(nombre, idCategoria)
    End Function

End Class
