Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNTransferencia

    Private _ADTransferencia As New ADTransferencia() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function ValidarTransferencia(transferencia As ETransferencia)
        sb.Clear()

        If String.IsNullOrEmpty(transferencia.Fecha) Then
            sb.Append("Debe seleccionar una fecha." + Environment.NewLine)
        End If

        If transferencia.CuentaOrigen = 0 Then
            sb.Append("Debe seleccionar una cuenta de origen." + Environment.NewLine)
        End If

        If transferencia.CuentaDestino = 0 Then
            sb.Append("Debe seleccionar una cuenta de origen." + Environment.NewLine)
        End If

        If transferencia.CuentaOrigen = transferencia.CuentaDestino Then
            sb.Append("Las cuentas de origen y destino deben ser distintas." + Environment.NewLine)
        End If

        If transferencia.Monto <= 0 Then
            sb.Append("Debe ingresar el monto de la transferencia." + Environment.NewLine)
        End If

        Return sb.Length = 0
    End Function

End Class
