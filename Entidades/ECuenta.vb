Public Class ECuenta

    Public Property ID() As Integer 'ID numérico.
    Public Property Nombre() As String 'Nombre o descripción de la cuenta
    Public Property TipoCuenta() As Integer 'Referencia al ID del tipo de cuenta.
    Public Property DescripcionTipoCuenta() As String 'Descripción del tipo de cuenta. *
    Public Property Moneda() As Integer 'Referencia al ID de la moneda.
    Public Property CodigoMoneda() As String 'Código de la moneda. **
    Public Property Saldo() As Double 'Saldo de la cuenta.
    Public Property Descripcion() As String 'Descripcion o comentarios acerca de la cuenta.

    '* Campo auxiliar, perteneciente a la tabla TiposCuenta.
    '** Campo auxiliar, perteneciente a la tabla Monedas.

End Class
