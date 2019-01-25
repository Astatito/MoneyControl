Imports Entidades
Imports System.Data.SQLite

Public Class ADMoneda

    'Insertar una moneda en la BD.
    Public Sub Insertar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Monedas(codigo, descripcion) VALUES (@cod, @desc)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@cod", moneda.Codigo)
                cmd.Parameters.AddWithValue("@desc", moneda.Descripcion)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una moneda en la BD.
    Public Sub Actualizar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Monedas SET codigo = @cod, descripcion = @desc WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@cod", moneda.Codigo)
                cmd.Parameters.AddWithValue("@desc", moneda.Descripcion)
                cmd.Parameters.AddWithValue("@id", moneda.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Eliminar una moneda de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idMoneda As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM Monedas WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idMoneda)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Obtener todos las monedas de la BD.
    Public Function ObtenerTodos() As List(Of EMoneda)
        Dim monedas As New List(Of EMoneda)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas ORDER BY codigo"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim moneda As New EMoneda()
                    moneda.ID = Convert.ToString(dr("id"))
                    moneda.Codigo = Convert.ToString(dr("codigo"))
                    moneda.Descripcion = Convert.ToString(dr("descripcion"))

                    monedas.Add(moneda)
                End While
            End Using
            cnx.Close()
        End Using

        Return monedas
    End Function

    'Obtener una moneda de la BD a partir de un código.
    Public Function ObtenerPorCodigo(ByVal codigo As String, ByVal idMoneda As Integer) As EMoneda
        Dim moneda As EMoneda = Nothing

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas WHERE codigo = @cod AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@cod", codigo)
                cmd.Parameters.AddWithValue("@id", idMoneda)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    moneda = New EMoneda()
                    moneda.ID = Convert.ToString(dr("id"))
                    moneda.Codigo = Convert.ToString(dr("codigo"))
                    moneda.Descripcion = Convert.ToString(dr("descripcion"))

                End If
            End Using
            cnx.Close()
        End Using

        Return moneda
    End Function

End Class
