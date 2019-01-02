Imports Entidades
Imports System.Data.SQLite


Public Class ADTipoMovimiento

    'Obtener todos los tipos de movimientos de la BD.
    Public Function ObtenerTodos() As List(Of ETipoMovimiento)
        Dim tiposMovimiento As New List(Of ETipoMovimiento)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposMovimiento ORDER BY tipoMovimiento"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim tipoMovimiento As New ETipoMovimiento()
                    tipoMovimiento.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                    tiposMovimiento.Add(tipoMovimiento)
                End While
            End Using
            cnx.Close()
        End Using

        Return tiposMovimiento
    End Function

    'Obtener un tipo de movimiento de la BD a partir de un nombre.
    Public Function ObtenerPorTipo(ByVal tipo As String) As ETipoMovimiento
        Dim tipoMovimiento As ETipoMovimiento = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposMovimiento WHERE tipoMovimiento = @tip"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tip", tipo)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tipoMovimiento = New ETipoMovimiento()
                    tipoMovimiento.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))

                End If
            End Using
            cnx.Close()
        End Using

        Return tipoMovimiento
    End Function

End Class
