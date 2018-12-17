Imports Entidades
Imports System.Data.SQLite


Public Class ADTipoCategoria

    'Obtener todos los tipos de categorías de la BD.
    Public Function ObtenerTodos() As List(Of ETipoCategoria)
        Dim tiposCategoria As New List(Of ETipoCategoria)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCategoria ORDER BY tipo"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim tipoCategoria As New ETipoCategoria()
                    tipoCategoria.Tipo = Convert.ToString(dr("tipo"))

                    tiposCategoria.Add(tipoCategoria)
                End While
            End Using
            cnx.Close()
        End Using

        Return tiposCategoria
    End Function

    'Obtener un tipo de categoría de la BD a partir de un nombre.
    Public Function ObtenerPorTipo(ByVal tipoCategoria As String) As ETipoCategoria
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCategoria WHERE tipo = @tip"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", tipoCategoria)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim _tipoCategoria As New ETipoCategoria()
                    _tipoCategoria.Tipo = Convert.ToString(dr("tipo"))

                    Return _tipoCategoria
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

End Class
