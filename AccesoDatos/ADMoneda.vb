Imports Entidades
Imports System.Data.SQLite

Public Class ADMoneda

    'Insertar una moneda en la BD.
    Public Sub Insertar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Monedas(pais, codigo, nombre) VALUES (@pais, @codigo, @nombre)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@pais", moneda.Pais)
                cmd.Parameters.AddWithValue("@codigo", moneda.Codigo)
                cmd.Parameters.AddWithValue("@nombre", moneda.Nombre)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una moneda en la BD.
    Public Sub Actualizar(ByVal moneda As EMoneda)
        Using cnx As New SQLiteConnection(connString)
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
                    moneda.Id = Convert.ToString(dr("id"))
                    moneda.Pais = Convert.ToString(dr("pais"))
                    moneda.Codigo = Convert.ToString(dr("codigo"))
                    moneda.Nombre = Convert.ToString(dr("nombre"))
                    moneda.Favorito = Convert.ToString(dr("favorito"))

                    monedas.Add(moneda)
                End While
            End Using
            cnx.Close()
        End Using

        Return monedas
    End Function

    'Obtener una moneda de la BD a partir de un ID.
    Public Function ObtenerPorId(ByVal idMoneda As Integer) As EMoneda
        Using cnx As New SQLiteConnection(connString)
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
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Obtener una moneda de la BD a partir de un código.
    Public Function ObtenerPorCodigo(ByVal codigo As String) As EMoneda
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas WHERE codigo = @cod"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@cod", codigo)

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
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Obtener moneda por defecto desde la BD.
    Public Function ObtenerMonedaPorDefecto()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Monedas WHERE favorito = TRUE"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

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
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Establecer moneda por defecto en la BD.
    Public Sub DefinirMonedaPorDefecto(ByVal idMoneda As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Using cmd As New SQLiteCommand(cnx)
                    cmd.Transaction = tr

                    Const sqlQuery1 As String = "UPDATE Monedas SET favorito = False WHERE favorito = True"
                    cmd.CommandText = sqlQuery1
                    cmd.ExecuteNonQuery()

                    Const sqlQuery2 = "UPDATE Monedas SET favorito = True WHERE id = @id"
                    cmd.CommandText = sqlQuery2
                    cmd.Parameters.AddWithValue("@id", idMoneda)
                    cmd.ExecuteNonQuery()

                End Using
                tr.Commit()
            End Using
        End Using
    End Sub

End Class
