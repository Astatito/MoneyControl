Imports Entidades
Imports System.Data.SQLite

Public Class ADConfiguracion

    'Modificar la configuración de la BD.
    Public Sub ActualizarTodo(ByVal newConfig As EConfiguracion, ByVal oldConfig As EConfiguracion)
        GC.Collect()
        Using cnx As New SQLiteConnection(connString)
            cnx.Open()

            Using tr As SQLiteTransaction = cnx.BeginTransaction

                Try
                    Using cmd As New SQLiteCommand(cnx)

                        Const sqlQuery1 As String = "UPDATE Movimientos SET categoria = @nueva WHERE categoria = @vieja"
                        cmd.CommandText = sqlQuery1
                        cmd.Parameters.AddWithValue("@nueva", newConfig.CategoriaGastosPorDefecto)
                        cmd.Parameters.AddWithValue("@vieja", oldConfig.CategoriaGastosPorDefecto)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery2 As String = "UPDATE Movimientos SET categoria = @nueva WHERE categoria = @vieja"
                        cmd.CommandText = sqlQuery2
                        cmd.Parameters.AddWithValue("@nueva", newConfig.CategoriaIngresosPorDefecto)
                        cmd.Parameters.AddWithValue("@vieja", oldConfig.CategoriaIngresosPorDefecto)
                        cmd.ExecuteNonQuery()

                        Const sqlQuery3 As String = "UPDATE Configuracion SET categoriaGastosPorDefecto = @gasto, categoriaIngresosPorDefecto = @ingreso, rutaExcelPorDefecto = @ruta"
                        cmd.CommandText = sqlQuery3
                        cmd.Parameters.AddWithValue("@gasto", newConfig.CategoriaGastosPorDefecto)
                        cmd.Parameters.AddWithValue("@ingreso", newConfig.CategoriaIngresosPorDefecto)
                        If newConfig.RutaExcelPorDefecto <> "" Then
                            cmd.Parameters.AddWithValue("@ruta", newConfig.RutaExcelPorDefecto)
                        Else
                            cmd.Parameters.AddWithValue("@ruta", DBNull.Value)
                        End If

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

    'Obtener la configuración de la BD.
    Public Function ObtenerConfiguracion() As EConfiguracion
        GC.Collect()
        Dim configuracion As EConfiguracion = Nothing

        Using cnx As New SQLiteConnection(connStringReadOnly)
            cnx.Open()

            Const sqlQuery As String = "SELECT * FROM Configuracion"
            Using cmd As New SQLiteCommand(sqlQuery, cnx)

                Dim dr As SQLiteDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    configuracion = New EConfiguracion()
                    configuracion.CategoriaGastosPorDefecto = Convert.ToString(dr("categoriaGastosPorDefecto"))
                    configuracion.CategoriaIngresosPorDefecto = Convert.ToString(dr("categoriaIngresosPorDefecto"))
                    configuracion.RutaExcelPorDefecto = Convert.ToString(dr("rutaExcelPorDefecto"))
                End If
            End Using
            cnx.Close()
        End Using
        GC.Collect()

        Return configuracion
    End Function

    End Class
