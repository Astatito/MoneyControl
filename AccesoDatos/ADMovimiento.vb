Imports Entidades
Imports System.Data.SQLite

Public Class ADMovimiento

    'Insertar un movimiento en la BD.
    Public Sub Insertar(ByVal movimiento As EMovimiento)
        Using cnx As New SQLiteConnection(connString)
            GC.Collect()
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "INSERT INTO Movimientos(fecha, tipoMovimiento, categoria, subCategoria, monto, cuenta, descripcion) VALUES (@fec, @tipo, @cate, @subcate, @mon, @cuen, @desc)"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@fec", movimiento.Fecha.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@tipo", movimiento.TipoMovimiento)
                        cmd.Parameters.AddWithValue("@cate", movimiento.Categoria)
                        If movimiento.Subcategoria <> 0 Then
                            cmd.Parameters.AddWithValue("@subcate", movimiento.Subcategoria)
                        Else
                            cmd.Parameters.AddWithValue("@subcate", DBNull.Value)
                        End If
                        cmd.Parameters.AddWithValue("@mon", movimiento.Monto)
                        cmd.Parameters.AddWithValue("@cuen", movimiento.Cuenta)
                        If movimiento.Descripcion <> "" Then
                            cmd.Parameters.AddWithValue("@desc", movimiento.Descripcion)
                        Else
                            cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                        End If
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "UPDATE Cuentas SET saldo = saldo + @mon WHERE id = @id"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@mon", movimiento.Monto)
                        cmd.Parameters.AddWithValue("@id", movimiento.Cuenta)
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

    'Actualizar un movimiento en la BD.
    Public Sub Actualizar(ByVal old_movimiento As EMovimiento, ByVal movimiento As EMovimiento)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "UPDATE Cuentas SET saldo = saldo - @mon WHERE id = @id"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@mon", old_movimiento.Monto)
                        cmd.Parameters.AddWithValue("@id", old_movimiento.Cuenta)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "DELETE FROM Movimientos WHERE id = @id"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@id", old_movimiento.ID)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery3 As String = "INSERT INTO Movimientos(fecha, tipoMovimiento, categoria, subCategoria, monto, cuenta, descripcion) VALUES (@fec, @tipo, @cate, @subcate, @mon, @cuen, @desc)"
                        cmd.CommandText = sqlQuery3
                        cmd.Parameters.AddWithValue("@fec", movimiento.Fecha.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@tipo", movimiento.TipoMovimiento)
                        cmd.Parameters.AddWithValue("@cate", movimiento.Categoria)
                        If movimiento.Subcategoria <> 0 Then
                            cmd.Parameters.AddWithValue("@subcate", movimiento.Subcategoria)
                        Else
                            cmd.Parameters.AddWithValue("@subcate", DBNull.Value)
                        End If
                        cmd.Parameters.AddWithValue("@mon", movimiento.Monto)
                        cmd.Parameters.AddWithValue("@cuen", movimiento.Cuenta)
                        If movimiento.Descripcion <> "" Then
                            cmd.Parameters.AddWithValue("@desc", movimiento.Descripcion)
                        Else
                            cmd.Parameters.AddWithValue("@desc", DBNull.Value)
                        End If
                        cmd.ExecuteNonQuery()

                        Const sqlQuery4 As String = "UPDATE Cuentas SET saldo = saldo + @mon WHERE id = @id"
                        cmd.CommandText = sqlQuery4
                        cmd.Parameters.AddWithValue("@mon", movimiento.Monto)
                        cmd.Parameters.AddWithValue("@id", movimiento.Cuenta)
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

    'Eliminar un movimiento de la BD a partir de un ID.
    Public Sub Eliminar(ByVal movimiento As EMovimiento)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "UPDATE Cuentas SET saldo = saldo - @mon WHERE id = @id"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@mon", movimiento.Monto)
                        cmd.Parameters.AddWithValue("@id", movimiento.Cuenta)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "DELETE FROM Movimientos WHERE id = @id"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@id", movimiento.ID)
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

    'Obtener los movimientos de la BD asociados a una cuenta entre dos fechas.
    Public Function ObtenerPorCuentaYFecha(ByVal idCuenta As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date) As List(Of EMovimiento)
        GC.Collect()
        Dim movimientos As New List(Of EMovimiento)

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT m.id AS id, m.fecha AS fecha, m.tipoMovimiento AS tipoMovimiento, m.categoria AS categoria, ca.nombre AS nombreCategoria, m.subcategoria AS subcategoria, s.nombre AS nombreSubcategoria, m.monto AS monto, m.cuenta AS cuenta, cu.nombre AS nombreCuenta, m.descripcion AS descripcion FROM (((Movimientos m JOIN Categorias ca ON m.categoria = ca.id) LEFT JOIN Subcategorias s ON m.subcategoria = s.id) JOIN Cuentas cu ON m.cuenta = cu.id) WHERE m.cuenta = @cuen AND m.fecha >= @fecDesde AND m.fecha <= @fecHasta ORDER BY m.fecha"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)
                cmd.Parameters.AddWithValue("@cuen", idCuenta)
                cmd.Parameters.AddWithValue("@fecDesde", fechaDesde.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@fecHasta", fechaHasta.ToString("yyyy-MM-dd"))

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                While dr.Read()
                    Dim movimiento As New EMovimiento()
                    movimiento.ID = Convert.ToInt32(dr("id"))
                    movimiento.Fecha = Convert.ToString(dr("fecha"))
                    movimiento.TipoMovimiento = Convert.ToString(dr("tipoMovimiento"))
                    movimiento.Categoria = Convert.ToInt32(dr("categoria"))
                    movimiento.NombreCategoria = Convert.ToString(dr("nombreCategoria"))
                    If Not IsDBNull(dr("subcategoria")) Then
                        movimiento.Subcategoria = Convert.ToInt32(dr("subcategoria"))
                    End If
                    movimiento.NombreSubcategoria = Convert.ToString(dr("nombreSubcategoria"))
                    movimiento.Monto = Convert.ToDouble(dr("monto"))
                    movimiento.Cuenta = Convert.ToInt32(dr("cuenta"))
                    movimiento.NombreCuenta = Convert.ToString(dr("nombreCuenta"))
                    movimiento.Descripcion = Convert.ToString(dr("descripcion"))

                    movimientos.Add(movimiento)
                End While
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return movimientos
    End Function

End Class
