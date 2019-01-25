Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNMovimiento

    Private _ADMovimiento As New ADMovimiento() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function ValidarMovimiento(movimiento As EMovimiento)
        sb.Clear()

        If String.IsNullOrEmpty(movimiento.Fecha) Then
            sb.Append("Debe seleccionar una fecha." + Environment.NewLine)
        End If

        If String.IsNullOrEmpty(movimiento.TipoMovimiento) Then
            sb.Append("Debe seleccionar un tipo de movimiento." + Environment.NewLine)
        End If

        If movimiento.Categoria = 0 Then
            sb.Append("Debe seleccionar una categoría." + Environment.NewLine)
        End If

        If movimiento.Cuenta = 0 Then
            sb.Append("Debe seleccionar una cuenta." + Environment.NewLine)
        End If

        Return sb.Length = 0
    End Function

    'Insertar un movimiento.
    Public Sub Insertar(movimiento As EMovimiento)
        If validarMovimiento(movimiento) Then
            _ADMovimiento.Insertar(movimiento)
        End If
    End Sub

End Class
