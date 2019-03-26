Imports Entidades
Imports System.Data.SQLite

Public Class ADCategoria

    'Insertar una categoría en la BD.
    Public Sub Insertar(ByVal categoria As ECategoria)
        GC.Collect()
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
        GC.Collect()
    End Sub

    'Modificar una categoría en la BD.
    Public Sub Actualizar(ByVal categoria As ECategoria)
        GC.Collect()
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
        GC.Collect()
    End Sub

    'Eliminar una categoría de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idCategoria As Integer, ByVal tipoCategoria As String, ByVal config As EConfiguracion)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()

                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "DELETE FROM SubCategorias WHERE categoria = @cate"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@cate", idCategoria)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "UPDATE Movimientos SET categoria = @nueva WHERE categoria = @vieja"
                        cmd.CommandText = sqlQuery2
                        If tipoCategoria = "Ingreso" Then
                            cmd.Parameters.AddWithValue("@nueva", config.CategoriaIngresosPorDefecto)
                        Else
                            cmd.Parameters.AddWithValue("@nueva", config.CategoriaGastosPorDefecto)
                        End If
                        cmd.Parameters.AddWithValue("@vieja", idCategoria)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery3 As String = "DELETE FROM Categorias WHERE id = @id"
                        cmd.CommandText = sqlQuery3
                        cmd.Parameters.AddWithValue("@id", idCategoria)
                        cmd.ExecuteNonQuery()

                        cmd.Transaction = tr
                        cmd.Dispose()
                    End Using
                    GC.Collect()

                    tr.Commit()
                Catch ex As Exception
                    tr.Rollback()
                End Try
                tr.Dispose()
            End Using
            GC.Collect()

            cnx.Close()
            cnx.Dispose()
        End Using
        GC.Collect()
    End Sub

    'Obtener todas las categorías de la BD.
    Public Function ObtenerTodos() As List(Of ECategoria)
        GC.Collect()
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToInt32(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return categorias
    End Function

    'Obtener todas las categorías de ingresos de la BD.
    Public Function ObtenerIngresos() As List(Of ECategoria)
        GC.Collect()
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipoMovimiento = @tip ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Ingreso")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToInt32(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return categorias
    End Function

    'Obtener todas las categorías de gastos de la BD.
    Public Function ObtenerGastos() As List(Of ECategoria)
        GC.Collect()
        Dim categorias As New List(Of ECategoria)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE tipoMovimiento = @tip ORDER BY nombre "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", "Gasto")

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim categoria As New ECategoria()
                    categoria.ID = Convert.ToInt32(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    categorias.Add(categoria)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return categorias
    End Function

    'Obtener una categoría de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCategoria As Integer) As ECategoria
        GC.Collect()
        Dim categoria As ECategoria = Nothing

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Categorias WHERE nombre = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@id", idCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    categoria = New ECategoria()
                    categoria.ID = Convert.ToInt32(dr("id"))
                    categoria.Nombre = Convert.ToString(dr("nombre"))
                    categoria.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return categoria
    End Function

End Class
