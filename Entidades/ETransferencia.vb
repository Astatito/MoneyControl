Public Class ETransferencia

    Public Property ID() As Integer 'ID numérico.
    Public Property Fecha() As String 'Fecha de la transferencia.
    Public Property CuentaOrigen() As Integer 'Referencia al ID de la cuenta de origen de la transferencia.
    Public Property NombreCuentaOrigen() As String 'Nombre de la cuenta de origen. *
    Public Property CuentaDestino() As Integer 'Referencia al ID de la cuenta de destino de la transferencia.
    Public Property NombreCuentaDestino() As String 'Nombre de la cuenta de destino. **
    Public Property Monto() As Double 'Monto de la transferencia (de la cuenta de origen).
    'Public Property MontoOrigen() As Double 'Monto de la transferencia (de la cuenta de origen).

    Public Property TipoCambio() As Double 'Relación entre la moneda de origen y la de destino.

    '* Campo auxiliar, perteneciente a la tabla Cuentas.
    '** Campo auxiliar, perteneciente a la tabla Cuentas.

End Class
