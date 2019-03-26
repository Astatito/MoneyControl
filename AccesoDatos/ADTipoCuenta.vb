Imports Entidades
Imports System.Data.SQLite

Public Class ADTipoCuenta

    'Insertar un tipo de cuenta en la BD.
    Public Sub Insertar(ByVal tipoCuenta As ETipoCuenta)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO TiposCuenta(descripcion) VALUES (@desc)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                If tipoCuenta.Descripcion <> "" Then
                    cmd.Parameters.AddWithValue("@desc", tipoCuenta.Descripcion)
                Else
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                End If
                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Modificar un tipo de cuenta en la BD.
    Public Sub Actualizar(ByVal tipoCuenta As ETipoCuenta)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE TiposCuenta SET descripcion = @desc WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                If tipoCuenta.Descripcion <> "" Then
                    cmd.Parameters.AddWithValue("@desc", tipoCuenta.Descripcion)
                Else
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                End If
                cmd.Parameters.AddWithValue("@id", tipoCuenta.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Eliminar un tipo de cuenta de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idTipoCuenta As Integer)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM TiposCuenta WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@id", idTipoCuenta)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Obtener todos los tipos de cuenta de la BD.
    Public Function ObtenerTodos() As List(Of ETipoCuenta)
        GC.Collect()
        Dim tiposCuenta As New List(Of ETipoCuenta)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCuenta ORDER BY descripcion"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim tipoCuenta As New ETipoCuenta()
                    tipoCuenta.ID = Convert.ToInt32(dr("id"))
                    tipoCuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    tiposCuenta.Add(tipoCuenta)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return tiposCuenta
    End Function

    'Obtener un tipo de cuenta de la BD a partir de una descripción.
    Public Function ObtenerPorDescripcion(ByVal descripcion As String, ByVal idTipoCuenta As Integer) As ETipoCuenta
        GC.Collect()
        Dim tipoCuenta As ETipoCuenta = Nothing

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM TiposCuenta WHERE descripcion = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", descripcion)
                cmd.Parameters.AddWithValue("@id", idTipoCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    tipoCuenta = New ETipoCuenta()
                    tipoCuenta.ID = Convert.ToInt32(dr("id"))
                    tipoCuenta.Descripcion = Convert.ToString(dr("descripcion"))

                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return tipoCuenta
    End Function

End Class
