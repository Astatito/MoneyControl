Imports Entidades
Imports System.Data.SQLite

Public Class ADTransferencia

    'Insertar una transferencia en la BD.
    Public Sub Insertar(ByVal transferencia As ETransferencia)
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "INSERT INTO Transferencias (fecha, cuentaOrigen, cuentaDestino, monto, tipoCambio) VALUES (@fec, @cuenOri, @cuenDest, @mon, @tipCamb)"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@fec", transferencia.Fecha)
                        cmd.Parameters.AddWithValue("@cuenOri", transferencia.CuentaOrigen)
                        cmd.Parameters.AddWithValue("@cuenDest", transferencia.CuentaDestino)
                        cmd.Parameters.AddWithValue("@mon", transferencia.Monto)
                        cmd.Parameters.AddWithValue("@tipCamb", transferencia.TipoCambio)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "UPDATE Cuentas SET saldo = saldo - @mon WHERE id = @id"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@mon", transferencia.Monto)
                        cmd.Parameters.AddWithValue("@id", transferencia.CuentaOrigen)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery3 As String = "UPDATE Cuentas SET saldo = saldo + (@mon * @tipCamb) WHERE id = @id"
                        cmd.CommandText = sqlQuery3
                        cmd.Parameters.AddWithValue("@mon", transferencia.Monto)
                        cmd.Parameters.AddWithValue("@id", transferencia.CuentaDestino)
                        cmd.Parameters.AddWithValue("@tipCamb", transferencia.TipoCambio)
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
