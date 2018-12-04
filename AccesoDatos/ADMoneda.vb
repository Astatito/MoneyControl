Imports Entidades
Imports System.Data.SQLite
Imports System.Configuration


Public Class ADMoneda
    Dim connstring As String = ConfigurationManager.ConnectionStrings("cnnString").ToString()

    'Insertar un registro en la tabla Monedas.
    Public Sub Insertar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connstring)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Monedas(pais, codigo, nombre) VALUES (@pais, @codigo, @nombre)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@pais", moneda.Pais)
                cmd.Parameters.AddWithValue("@codigo", moneda.Codigo)
                cmd.Parameters.AddWithValue("@nombre", moneda.Nombre)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Modificar un registro de la tabla Monedas.
    Public Sub Actualizar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connstring)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Monedas SET pais = @pai, codigo = @cod, nombre = @nom, favorito = @fav WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@pai", moneda.Pais)
                cmd.Parameters.AddWithValue("@cod", moneda.Codigo)
                cmd.Parameters.AddWithValue("@nom", moneda.Nombre)
                cmd.Parameters.AddWithValue("@fav", moneda.Favorito)
                cmd.Parameters.AddWithValue("@id", moneda.Id)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Eliminar un registro de la tabla Monedas a partir de un ID.
    Public Sub Eliminar(ByVal idMoneda As Integer)
        Using cnx As New SQLiteConnection(connstring)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM Monedas WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@id", idMoneda)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Obtener todos los registros de la tabla Monedas.
    Public Function ObtenerTodos() As List(Of EMoneda)
        Dim monedas As New List(Of EMoneda)

        Using cnx As New SQLiteConnection(connstring)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas ORDER BY codigo DESC"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim moneda As New EMoneda()
                    moneda.Id = Convert.ToString(dr("id"))
                    moneda.Pais = Convert.ToString(dr("pais"))
                    moneda.Codigo = Convert.ToString(dr("codigo"))
                    moneda.Nombre = Convert.ToString(dr("nombre"))
                    moneda.Favorito = Convert.ToString(dr("favorito"))

                    monedas.Add(moneda)
                End While
            End Using
        End Using

        Return monedas
    End Function

    'Obtener un registro de la tabla Monedas a partir de un ID.
    Public Function ObtenerPorId(ByVal idMoneda As Integer) As EMoneda
        Using cnx As New SQLiteConnection(connstring)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idMoneda)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim moneda As New EMoneda()
                    moneda.Id = Convert.ToString(dr("id"))
                    moneda.Pais = Convert.ToString(dr("pais"))
                    moneda.Codigo = Convert.ToString(dr("codigo"))
                    moneda.Nombre = Convert.ToString(dr("nombre"))
                    moneda.Favorito = Convert.ToString(dr("favorito"))

                    Return moneda
                End If
            End Using
        End Using

        Return Nothing
    End Function

End Class
