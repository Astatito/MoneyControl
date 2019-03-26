Imports Entidades
Imports System.Data.SQLite

Public Class ADUsuario

    'Insertar un usuario en la BD.
    Public Sub Insertar(ByVal usuario As EUsuario)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Usuarios(usuario, password) VALUES (@usu, @pass)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@usu", usuario.Usuario)
                cmd.Parameters.AddWithValue("@pass", usuario.Password)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Modificar un usuario en la BD.
    Public Sub Actualizar(ByVal usuario As EUsuario)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Usuarios SET usuario = @usu, password = @pass WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@usu", usuario.Usuario)
                cmd.Parameters.AddWithValue("@pass", usuario.Password)
                cmd.Parameters.AddWithValue("@id", usuario.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Eliminar un usuario de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idUsuario As Integer)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM Usuarios WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idUsuario)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Obtener todos los usuarios de la BD.
    Public Function ObtenerTodos() As List(Of EUsuario)
        GC.Collect()
        Dim usuarios As New List(Of EUsuario)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Usuarios ORDER BY usuario"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim usuario As New EUsuario()
                    usuario.ID = Convert.ToInt32(dr("id"))
                    usuario.Usuario = Convert.ToString(dr("usuario"))
                    usuario.Password = Convert.ToString(dr("password"))

                    usuarios.Add(usuario)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return usuarios
    End Function

    'Obtener un usuario de la BD a partir de un nombre de usuario.
    Public Function ObtenerPorUsuario(ByVal nombreUsuario As String, ByVal idUsuario As Integer) As EUsuario
        GC.Collect()
        Dim usuario As EUsuario = Nothing

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Usuarios WHERE usuario = @usu AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@usu", nombreUsuario)
                cmd.Parameters.AddWithValue("@id", idUsuario)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    usuario = New EUsuario()
                    usuario.ID = Convert.ToInt32(dr("id"))
                    usuario.Usuario = Convert.ToString(dr("usuario"))
                    usuario.Password = Convert.ToString(dr("password"))

                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return usuario
    End Function

    'Verificar si el usuario y la contraseña existen en la BD.
    Public Function ValidarUsuarioPassword(ByVal usuario As String, ByVal password As String) As Boolean
        GC.Collect()

        Dim esValido As Boolean = False

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Usuarios WHERE usuario = @usu AND password = @pass"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@usu", usuario)
                cmd.Parameters.AddWithValue("@pass", password)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    esValido = True
                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return esValido
    End Function

End Class
