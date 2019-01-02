Imports Entidades
Imports System.Data.SQLite

Public Class ADCategoria

    'Insertar una categoría en la BD.
    Public Sub Insertar(ByVal categoria As ECategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Categorias(nombre, tipoMovimiento) VALUES (@nom, @tip)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", categoria.Nombre)
                cmd.Parameters.AddWithValue("@tip", categoria.TipoMovimiento)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una categoría en la BD.
    Public Sub Actualizar(ByVal categoria As ECategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Categorias SET nombre = @nom, tipoMovimiento = @tip WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", categoria.Nombre)
                cmd.Parameters.AddWithValue("@tip", categoria.TipoMovimiento)
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

    'Obtener todas las categorías de la BD.
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
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener todas las categorías de ingresos de la BD.
    Public Function ObtenerIngresos() As List(Of ECategoria)
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipoMovimiento = @tip ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Ingreso")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener todas las categorías de egresos de la BD.
    Public Function ObtenerEgresos() As List(Of ECategoria)
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipoMovimiento = @tip ORDER BY nombre "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Egreso")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return categorias
    End Function

    'Obtener una categoría de la BD a partir de un ID.
    Public Function ObtenerPorID(ByVal idCategoria As Integer) As ECategoria
        Dim categoria As ECategoria = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    categoria = New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                End If
            End Using
            cnx.Close()
        End Using

        Return categoria
    End Function

    'Obtener una categoría de la BD a partir de un nombre y un tipo.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCategoria As Integer) As ECategoria
        Dim categoria As ECategoria = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE nombre = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@id", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    categoria = New ECategoria()
                    categoria.ID = Convert.ToString(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                End If
            End Using
            cnx.Close()
        End Using

        Return categoria
    End Function

End Class
