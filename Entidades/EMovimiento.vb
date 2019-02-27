Public Class EMovimiento

    Public Property ID() As Integer 'ID numérico.
    Public Property Fecha() As Date 'Fecha del movimiento.
    Public Property TipoMovimiento() As String 'Tipo de movimiento.
    Public Property Categoria() As Integer 'Referencia al ID de la categoría del movimiento.
    Public Property NombreCategoria() As String 'Nombre de la categoría. *
    Public Property Subcategoria() As Integer 'Referencia al ID de la subcategoría del movimiento.
    Public Property NombreSubcategoria() As String 'Nombre de la subcategoría. **
    Public Property Monto() As Double 'Monto del movimiento.
    Public Property Cuenta() As Integer 'Referencia al ID de la cuenta asociada al movimiento.
    Public Property NombreCuenta() As String 'Nombre de la cuenta. ***
    Public Property Descripcion() As String 'Descripción o comentarios acerca del movimiento.

    '* Campo auxiliar, perteneciente a la tabla Categorías.
    '** Campo auxiliar, perteneciente a la tabla Subcategorías.
    '*** Campo auxiliar, perteneciente a la tabla Cuentas.

End Class
