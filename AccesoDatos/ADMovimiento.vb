Imports Entidades
Imports System.Data.SQLite

Public Class ADMovimiento

    'Insertar un movimiento en la BD.
    Public Sub Insertar(ByVal movimiento As EMovimiento)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "INSERT INTO Movimientos(fecha, tipoMovimiento, categoria, subCategoria, monto, cuenta, descripcion) VALUES (@fec, @tipo, @cate, @subcate, @mon, @cuen, @desc)"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@fec", movimiento.Fecha)
                        cmd.Parameters.AddWithValue("@tipo", movimiento.TipoMovimiento)
                        cmd.Parameters.AddWithValue("@cate", movimiento.Categoria)
                        If movimiento.SubCategoria <> 0 Then
                            cmd.Parameters.AddWithValue("@subcate", movimiento.SubCategoria)
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

End Class
