Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNTipoCuenta

    Private _ADTipoCuenta As New ADTipoCuenta() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean correctos.
    Public Function ValidarTipoCuenta(tipoCuenta As ETipoCuenta) As Boolean
        sb.Clear()

        If String.IsNullOrEmpty(tipoCuenta.Descripcion) Then
            sb.Append("Debe ingresar una descripción." + Environment.NewLine)
        ElseIf Not ObtenerPorDescripcion(tipoCuenta.Descripcion, tipoCuenta.ID) Is Nothing Then
            sb.Append("La descripción ingresada ya existe." + Environment.NewLine)
        End If

        Return sb.Length = 0
    End Function

    'Insertar un tipo de cuenta.
    Public Sub Insertar(tipoCuenta As ETipoCuenta)
        If validarTipoCuenta(tipoCuenta) Then
            _ADTipoCuenta.Insertar(tipoCuenta)
        End If
    End Sub

    'Actualizar un tipo de cuenta.
    Public Sub Actualizar(tipoCuenta As ETipoCuenta)
        If validarTipoCuenta(tipoCuenta) Then
            _ADTipoCuenta.Actualizar(tipoCuenta)
        End If
    End Sub

    'Eliminar un tipo de cuenta.
    Public Sub Eliminar(ByVal idTipoCuenta As Integer)
        _ADTipoCuenta.Eliminar(idTipoCuenta)
    End Sub

    'Obtener todos los tipos de cuenta.
    Public Function ObtenerTodos() As List(Of ETipoCuenta)
        Return _ADTipoCuenta.ObtenerTodos()
    End Function

    'Obtener un tipo de cuenta a partir de una descripción.
    Public Function ObtenerPorDescripcion(ByVal descripcion As String, ByVal idTipoCuenta As Integer) As ETipoCuenta
        Return _ADTipoCuenta.ObtenerPorDescripcion(descripcion, idTipoCuenta)
    End Function

End Class
