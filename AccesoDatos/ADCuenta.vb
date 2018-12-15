Imports Entidades
Imports System.Data.SQLite

Public Class ADCuenta

    'Insertar una cuenta en la BD.
    Public Sub Insertar(ByVal cuenta As ECuenta)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "INSERT INTO Cuentas(nombre, tipoCuenta, moneda, saldo, descripcion) VALUES (@nom, @tipo, @mone, @sal, @desc)"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", cuenta.Nombre)
                cmd.Parameters.AddWithValue("@tipo", cuenta.TipoCuenta)
                cmd.Parameters.AddWithValue("@mone", cuenta.Moneda)
                cmd.Parameters.AddWithValue("@sal", cuenta.Saldo)
                cmd.Parameters.AddWithValue("@desc", cuenta.Descripcion)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Modificar una cuenta en la BD.
    Public Sub Actualizar(ByVal cuenta As ECuenta)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "UPDATE Cuentas SET nombre = @nom, tipoCuenta = @tipo, moneda = @mone, saldo = @sal, descripcion = @desc WHERE id = @id "
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                cmd.Parameters.AddWithValue("@nom", cuenta.Nombre)
                cmd.Parameters.AddWithValue("@tipo", cuenta.TipoCuenta)
                cmd.Parameters.AddWithValue("@mone", cuenta.Moneda)
                cmd.Parameters.AddWithValue("@sal", cuenta.Saldo)
                cmd.Parameters.AddWithValue("@desc", cuenta.Descripcion)
                cmd.Parameters.AddWithValue("@id", cuenta.ID)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Eliminar una cuenta de la BD a partir de un ID.
    Public Sub Eliminar(ByVal idCuenta As Integer)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "DELETE FROM Cuentas WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idCuenta)

                cmd.ExecuteNonQuery()
            End Using
            cnx.Close()
        End Using
    End Sub

    'Obtener todas las cuentas de la BD.
    Public Function ObtenerTodos() As List(Of ECuenta)
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas ORDER BY nombre"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToString(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToString(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToString(dr("moneda"))
                    cuenta.Saldo = Convert.ToString(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using

        Return cuentas
    End Function

    Public Function ObtenerTodosFull() As List(Of ECuenta)
        Dim cuentas As New List(Of ECuenta)

        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT c.id AS id, c.nombre AS nombre, c.tipoCuenta AS tipoCuenta, tc.descripcion AS descripcionTipoCuenta, c.moneda AS moneda, m.codigo AS codigoMoneda, c.saldo AS saldo, c.descripcion AS descripcion 
From (Cuentas c join TiposCuenta tc ON c.tipoCuenta = tc.id) JOIN Monedas m ON c.moneda = m.id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToString(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToString(dr("tipoCuenta"))
                    cuenta.DescripcionTipoCuenta = Convert.ToString(dr("descripcionTipoCuenta"))
                    cuenta.Moneda = Convert.ToString(dr("moneda"))
                    cuenta.CodigoMoneda = Convert.ToString(dr("codigoMoneda"))
                    cuenta.Saldo = Convert.ToString(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    cuentas.Add(cuenta)
                End While
            End Using
            cnx.Close()
        End Using

        Return cuentas
    End Function

    'Obtener una cuenta de la BD a partir de un ID.
    Public Function ObtenerPorID(ByVal idCuenta As Integer) As ECuenta
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas WHERE id = @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@id", idCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToString(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToString(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToString(dr("moneda"))
                    cuenta.Saldo = Convert.ToString(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    Return cuenta
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function

    'Obtener una cuenta de la BD a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCuenta As Integer) As ECuenta
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Cuentas WHERE nombre = @nom AND id != @id"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@nom", nombre)
                cmd.Parameters.AddWithValue("@id", idCuenta)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim cuenta As New ECuenta()
                    cuenta.ID = Convert.ToString(dr("id"))
                    cuenta.Nombre = Convert.ToString(dr("nombre"))
                    cuenta.TipoCuenta = Convert.ToString(dr("tipoCuenta"))
                    cuenta.Moneda = Convert.ToString(dr("moneda"))
                    cuenta.Saldo = Convert.ToString(dr("saldo"))
                    cuenta.Descripcion = Convert.ToString(dr("descripcion"))

                    Return cuenta
                End If
            End Using
            cnx.Close()
        End Using

        Return Nothing
    End Function
End Class
