Imports Entidades
Imports System.Data.SQLite

Public Class ADCuenta

    'Insertar una cuenta en la BD.
    Public Sub Insertar(ByVal cuenta As ECuenta)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Cuentas(nombre, tipoCuenta, moneda, saldo, descripcion) VALUES (@nom, @tipo, @mone, @sal, @desc)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", cuenta.Nombre)
                cmd.Parameters.AddWithValue("@tipo", cuenta.TipoCuenta)
                cmd.Parameters.AddWithValue("@mone", cuenta.Moneda)
                cmd.Parameters.AddWithValue("@sal", cuenta.Saldo)
                If cuenta.Descripcion <> "" Then
                    cmd.Parameters.AddWithValue("@desc", cuenta.Descripcion)
                Else
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                End If

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Modificar una cuenta en la BD.
    Public Sub Actualizar(ByVal cuenta As ECuenta)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Cuentas SET nombre = @nom, tipoCuenta = @tipo, moneda = @mone, saldo = @sal, descripcion = @desc WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", cuenta.Nombre)
                cmd.Parameters.AddWithValue("@tipo", cuenta.TipoCuenta)
                cmd.Parameters.AddWithValue("@mone", cuenta.Moneda)
                cmd.Parameters.AddWithValue("@sal", cuenta.Saldo)
                If cuenta.Descripcion <> "" Then
                    cmd.Parameters.AddWithValue("@desc", cuenta.Descripcion)
                Else
                    cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                End If
                cmd.Parameters.AddWithValue("@id", cuenta.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
        GC.Collect()
    End Sub

    'Eliminar una cuenta de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idCuenta As Integer)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction

                Try
                    Using cmd As New SQLiteCommand(cnx)
                        Const sqlQuery1 As String = "DELETE FROM Movimientos WHERE cuenta = @cuen"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@cuen", idCuenta)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "DELETE FROM Cuentas WHERE id = @id"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@id", idCuenta)
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

    'Obtener todas las cuentas de la BD.
    Public Function ObtenerTodos() As List(Of ECuenta)
        GC.Collect()
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToInt32(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToInt32(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToInt32(dr("moneda"))
                    cuenta.Saldo = Convert.ToDouble(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return cuentas
    End Function

    'Obtener todas las cuentas (incluídos los datos auxiliares) de la BD.
    Public Function ObtenerTodosFull() As List(Of ECuenta)
        GC.Collect()
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT c.id AS id, c.nombre AS nombre, c.tipoCuenta AS tipoCuenta, tc.descripcion AS descripcionTipoCuenta, c.moneda AS moneda, m.codigo AS codigoMoneda, c.saldo AS saldo, c.descripcion AS descripcion FROM (Cuentas c join TiposCuenta tc ON c.tipoCuenta = tc.id) JOIN Monedas m ON c.moneda = m.id ORDER BY c.nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToInt32(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToInt32(dr("tipoCuenta"))
                    cuenta.DescripcionTipoCuenta = Convert.ToString(dr("descripcionTipoCuenta")) 'Auxiliar
                    cuenta.Moneda = Convert.ToInt32(dr("moneda"))
                    cuenta.CodigoMoneda = Convert.ToString(dr("codigoMoneda")) 'Auxiliar
                    cuenta.Saldo = Convert.ToDouble(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return cuentas
    End Function

    'Obtener una cuenta de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCuenta As Integer) As ECuenta
        GC.Collect()
        Dim cuenta As ECuenta = Nothing

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas WHERE nombre = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@id", idCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    cuenta = New ECuenta()
                    cuenta.ID = Convert.ToInt32(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToInt32(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToInt32(dr("moneda"))
                    cuenta.Saldo = Convert.ToDouble(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return cuenta
    End Function

    'Obtener todas las cuentas asociadas a una moneda.
    Public Function ObtenerPorMoneda(ByVal idMoneda As Integer) As List(Of ECuenta)
        GC.Collect()
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas WHERE moneda = @mon"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@mon", idMoneda)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToInt32(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToInt32(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToInt32(dr("moneda"))
                    cuenta.Saldo = Convert.ToDouble(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return cuentas
    End Function

    'Obtener todas las cuentas asociadas a un tipo de cuenta.
    Public Function ObtenerPorTipoDeCuenta(ByVal idTipoCuenta As Integer) As List(Of ECuenta)
        GC.Collect()
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas WHERE tipoCuenta = @tipo"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@tipo", idTipoCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToInt32(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToInt32(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToInt32(dr("moneda"))
                    cuenta.Saldo = Convert.ToDouble(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return cuentas
    End Function

End Class
