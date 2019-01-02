Imports Entidades
Imports System.Data.SQLite

Public Class ADSubCategoria

    'Insertar una subcategoría en la BD.
    Public Sub Insertar(ByVal subcategoria As ESubCategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO SubCategorias(categoria, nombre) VALUES (@cate, @nom)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", subcategoria.Nombre)
                cmd.Parameters.AddWithValue("@cate", subcategoria.Categoria)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una subcategoría en la BD.
    Public Sub Actualizar(ByVal subcategoria As ESubCategoria)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE SubCategorias SET nombre = @nom, categoria = @cate WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", subcategoria.Nombre)
                cmd.Parameters.AddWithValue("@cate", subcategoria.Categoria)
                cmd.Parameters.AddWithValue("@id", subcategoria.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Eliminar una subcategoría de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idSubCategoria As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM SubCategorias WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idSubCategoria)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Obtener todas las subcategorías de la BD.
    Public Function ObtenerTodos() As List(Of ESubCategoria)
        Dim subcategorias As New List(Of ESubCategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM SubCategorias ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim subcategoria As New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))

                    subcategorias.Add(subcategoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return subcategorias
    End Function

    'Obtener todas las subcategorías de una categoría de la BD.
    Public Function ObtenerPorCategoria(ByVal idCategoria As Integer) As List(Of ESubCategoria)
        Dim subcategorias As New List(Of ESubCategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM SubCategorias WHERE categoria = @cate ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@cate", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim subcategoria As New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))

                    subcategorias.Add(subcategoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return subcategorias
    End Function

    'Obtener todas las subcategorías (incluídos los datos auxiliares) de la BD.
    Public Function ObtenerTodosFull() As List(Of ESubCategoria)
        Dim subcategorias As New List(Of ESubCategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT sc.id AS id, sc.categoria AS categoria, c.nombre as nombreCategoria, sc.nombre as nombre FROM SubCategorias sc JOIN Categorias c ON sc.categoria = c.id ORDER BY sc.nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim subcategoria As New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))
                    subcategoria.NombreCategoria = Convert.ToString(dr("nombreCategoria")) 'Auxiliar

                    subcategorias.Add(subcategoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return subcategorias
    End Function

    'Obtener todas las subcategorías de una categoría (incluídos los datos auxiliares) de la BD.
    Public Function ObtenerPorCategoriaFull(ByVal idCategoria As Integer) As List(Of ESubCategoria)
        Dim subcategorias As New List(Of ESubCategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT sc.id AS id, sc.categoria AS categoria, c.nombre as nombreCategoria, sc.nombre as nombre FROM SubCategorias sc JOIN Categorias c ON sc.categoria = c.id WHERE sc.categoria = @cate ORDER BY sc.nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@cate", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim subcategoria As New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))
                    subcategoria.NombreCategoria = Convert.ToString(dr("nombreCategoria")) 'Auxiliar

                    subcategorias.Add(subcategoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return subcategorias
    End Function

    'Obtener una subcategoría de la BD a partir de un ID.
    Public Function ObtenerPorID(ByVal idSubCategoria As Integer) As ESubCategoria
        Dim subcategoria As ESubCategoria = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM SubCategorias WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idSubCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    subcategoria = New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))

                End If
            End Using
            cnx.Close()
        End Using

        Return subcategoria
    End Function

    'Obtener una subcategoría de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idSubCategoria As Integer) As ESubCategoria
        Dim subcategoria As ESubCategoria = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM SubCategorias WHERE nombre = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@id", idSubCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    subcategoria = New ESubCategoria()
                    subcategoria.ID = Convert.ToString(dr("id"))
                    subcategoria.Nombre = Convert.ToString(dr("nombre"))
                    subcategoria.Categoria = Convert.ToString(dr("categoria"))

                End If
            End Using
            cnx.Close()
        End Using

        Return subcategoria
    End Function

End Class
