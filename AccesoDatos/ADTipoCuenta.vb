Imports Entidades
Imports System.Data.SQLite

Public Class ADTipoCuenta

    'Insertar un tipo de cuenta en la BD.
    Public Sub Insertar(ByVal tipoCuenta As ETipoCuenta)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO TiposCuenta(nombre) VALUES (@nombre)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nombre", tipoCuenta.Nombre)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar un tipo de cuenta en la BD.
    Public Sub Actualizar(ByVal tipoCuenta As ETipoCuenta)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE TiposCuenta SET nombre = @nom WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", tipoCuenta.Nombre)
                cmd.Parameters.AddWithValue("@id", tipoCuenta.Id)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Eliminar un tipo de cuenta de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idTipoCuenta As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM TiposCuenta WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@id", idTipoCuenta)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Obtener todos los tipos de cuenta de la BD.
    Public Function ObtenerTodos() As List(Of ETipoCuenta)
        Dim tiposCuenta As New List(Of ETipoCuenta)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCuenta ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim tipoCuenta As New ETipoCuenta()
                    tipoCuenta.Id = Convert.ToString(dr("id"))
                    tipoCuenta.Nombre = Convert.ToString(dr("nombre"))

                    tiposCuenta.Add(tipoCuenta)
                End While
            End Using
            cnx.Close()
        End Using

        Return tiposCuenta
    End Function

    'Obtener un tipo de cuenta de la BD a partir de un ID.
    Public Function ObtenerPorId(ByVal idTipoCuenta As Integer) As ETipoCuenta
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCuenta WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idTipoCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim tipoCuenta As New ETipoCuenta()
                    tipoCuenta.Id = Convert.ToString(dr("id"))
                    tipoCuenta.Nombre = Convert.ToString(dr("nombre"))

                    Return tipoCuenta
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Obtener un tipo de cuenta de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String) As ETipoCuenta
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCuenta WHERE nombre = @nom"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim tipoCuenta As New ETipoCuenta()
                    tipoCuenta.Id = Convert.ToString(dr("id"))
                    tipoCuenta.Nombre = Convert.ToString(dr("nombre"))

                    Return tipoCuenta
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

End Class
