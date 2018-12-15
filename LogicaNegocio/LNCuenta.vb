Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNCuenta

    Private _ADCuenta As New ADCuenta() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verificar que los datos ingresados sean válidos.
    Public Function validarCuenta(cuenta As ECuenta)
        sb.Clear()

        If String.IsNullOrEmpty(cuenta.Nombre) Then
            sb.Append(Environment.NewLine + "Debe ingresar un nombre.")
        ElseIf Not ObtenerPorNombre(cuenta.Nombre, cuenta.ID) Is Nothing Then
            sb.Append(Environment.NewLine + "El nombre ingresado ya existe.")
        End If

        If cuenta.TipoCuenta = 0 Then
            sb.Append(Environment.NewLine + "Debe seleccionar un tipo de cuenta.")
        End If

        If cuenta.Moneda = 0 Then
            sb.Append(Environment.NewLine + "Debe seleccionar una moneda.")
        End If

        Return sb.Length = 0
    End Function

    'Insertar una cuenta.
    Public Sub Insertar(cuenta As ECuenta)
        If validarCuenta(cuenta) Then
            _ADCuenta.Insertar(cuenta)
        End If
    End Sub

    'Actualizar una cuenta.
    Public Sub Actualizar(cuenta As ECuenta)
        If validarCuenta(cuenta) Then
            _ADCuenta.Actualizar(cuenta)
        End If
    End Sub

    'Eliminar una cuenta.
    Public Sub Eliminar(ByVal idCuenta As Integer)
        _ADCuenta.Eliminar(idCuenta)
    End Sub

    'Obtener todas las cuentas.
    Public Function ObtenerTodos()
        Return _ADCuenta.ObtenerTodos()
    End Function

    Public Function ObtenerTodosFull()
        Return _ADCuenta.ObtenerTodosFull()
    End Function

    'Obtener una cuenta a partir de un ID.
    Public Function ObtenerPorID(ByVal idCuenta As Integer)
        Return _ADCuenta.ObtenerPorId(idCuenta)
    End Function

    'Obtener una cuenta a partir de un nombre.
    Public Function ObtenerPorNombre(ByVal nombre As String, ByVal idCuenta As Integer)
        Return _ADCuenta.ObtenerPorNombre(nombre, idCuenta)
    End Function
End Class
