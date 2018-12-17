Imports Entidades
Imports System.Data.SQLite

Public Class ADCategoria

    'Insertar una categoría en la BD.
    Public Sub Insertar(ByVal categoria As ECategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Categorias(nombre, tipo) VALUES (@nom, @tip)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", categoria.Nombre)
                cmd.Parameters.AddWithValue("@tip", categoria.Tipo)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una categoría en la BD.
    Public Sub Actualizar(ByVal categoria As ECategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Categorias SET nombre = @nom, tipo = @tip WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", categoria.Nombre)
                cmd.Parameters.AddWithValue("@tip", categoria.Tipo)
                cmd.Parameters.AddWithValue("@id", categoria.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Eliminar una categoría de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idCategoria As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM Categorias WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idCategoria)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Obtener todos las categorías de la BD.
    Public Function ObtenerTodos() As List(Of ECategoria)
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.Tipo = Convert.ToString(dr("tipo"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener todos las categorías de ingresos de la BD.
    Public Function ObtenerIngresos() As List(Of ECategoria)
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipo = @tip ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Ingreso")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.Tipo = Convert.ToString(dr("tipo"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener todos las categorías de egresos de la BD.
    Public Function ObtenerEgresos() As List(Of ECategoria)
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipo = @tip ORDER BY nombre "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Egreso")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.Tipo = Convert.ToString(dr("tipo"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener una categoría de la BD a partir de un ID.
    Public Function ObtenerPorID(ByVal idCategoria As Integer) As ECategoria
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.Tipo = Convert.ToString(dr("tipo"))

                    Return categoria
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Obtener una categoría de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal categoria As ECategoria) As ECategoria
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE nombre = @nom AND tipo != @tip AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", categoria.Nombre)
                cmd.Parameters.AddWithValue("@tip", categoria.Tipo)
                cmd.Parameters.AddWithValue("@id", categoria.ID)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim _categoria As New ECategoria()
                    _categoria.ID = Convert.ToString(dr("id"))
                    _categoria.Nombre = Convert.ToString(dr("nombre"))
                    _categoria.Tipo = Convert.ToString(dr("tipo"))

                    Return _categoria
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

End Class
