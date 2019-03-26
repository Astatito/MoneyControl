Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNUsuario

    Private _ADUsuario As New ADUsuario() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function ValidarUsuario(ByVal usuario As EUsuario) As Boolean
        sb.Clear()

        If String.IsNullOrEmpty(usuario.Usuario) Then
            sb.Append("Debe ingresar un usuario." + Environment.NewLine)
        ElseIf Not ObtenerPorNombre(usuario.Usuario, usuario.ID) Is Nothing Then
            sb.Append("El usuario ingresado ya existe." + Environment.NewLine)
        End If

        If String.IsNullOrEmpty(usuario.Password) Then
            sb.Append("Debe ingresar una contraseña." + Environment.NewLine)
        End If

        Return sb.Length = 0
    End Function

    'Insertar un usuario.
    Public Sub Insertar(ByVal usuario As EUsuario)
        If ValidarUsuario(usuario) Then
            _ADUsuario.Insertar(usuario)
        End If
    End Sub

    'Modificar un usuario.
    Public Sub Actualizar(ByVal usuario As EUsuario)
        If ValidarUsuario(usuario) Then
            _ADUsuario.Actualizar(usuario)
        End If
    End Sub

    'Eliminar un usuario.
    Public Sub Eliminar(ByVal idUsuario As Integer)
        _ADUsuario.Eliminar(idUsuario)
    End Sub

    'Obtener todos los usuarios.
    Public Function ObtenerTodos() As List(Of EUsuario)
        Return _ADUsuario.ObtenerTodos()
    End Function

    'Obtener un usuario a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombreUsuario As String, ByVal idUsuario As Integer)
        Return _ADUsuario.ObtenerPorUsuario(nombreUsuario, idUsuario)
    End Function

    'Verificar el usuario y la contraseña.
    Public Function ValidarUsuarioPassword(ByVal usuario As String, ByVal password As String) As Boolean
        Return _ADUsuario.ValidarUsuarioPassword(usuario, password)
    End Function

End Class
