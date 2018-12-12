Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNMoneda

    Private _ADMoneda As New ADMoneda() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verifica que los datos ingresados sean válidos.
    Public Function validarMoneda(moneda As EMoneda)
        sb.Clear()

        If String.IsNullOrEmpty(moneda.Pais) Then
            sb.Append("Debe ingresar un país o región.")
        End If

        If String.IsNullOrEmpty(moneda.Codigo) Then
            sb.Append(Environment.NewLine + "Debe ingresar un código.")
        ElseIf Not ObtenerPorCodigo(moneda.Codigo) Is Nothing Then
            sb.Append(Environment.NewLine + "El código ingresado ya existe.")
        End If

        If String.IsNullOrEmpty(moneda.Nombre) Then
            sb.Append(Environment.NewLine + "Debe ingresar un nombre.")
        End If

        Return sb.Length = 0
    End Function

    'Insertar una moneda.
    Public Sub Insertar(moneda As EMoneda)
        If validarMoneda(moneda) Then
            _ADMoneda.Insertar(moneda)
        End If
    End Sub

    'Actualizar una moneda.
    Public Sub Actualizar(moneda As EMoneda)
        If validarMoneda(moneda) Then
            _ADMoneda.Actualizar(moneda)
        End If
    End Sub

    'Eliminar una moneda.
    Public Sub Eliminar(ByVal idMoneda As Integer)
        _ADMoneda.Eliminar(idMoneda)
    End Sub

    'Obtener todas las monedas.
    Public Function ObtenerTodos()
        Return _ADMoneda.ObtenerTodos()
    End Function

    'Obtener una moneda a partir de un ID.
    Public Function ObtenerPorID(ByVal idMoneda As Integer)
        Return _ADMoneda.ObtenerPorId(idMoneda)
    End Function

    'Obtener una moneda a partir de un código.
    Public Function ObtenerPorCodigo(ByVal codigo As String)
        Return _ADMoneda.ObtenerPorCodigo(codigo)
    End Function

    'Obtener la moneda por defecto.
    Public Function ObtenerMonedaPorDefecto()
        Return _ADMoneda.ObtenerMonedaPorDefecto()
    End Function

    'Establecer la moneda por defecto.
    Public Sub DefinirMonedaPorDefecto(ByVal idMoneda As Integer)
        _ADMoneda.DefinirMonedaPorDefecto(idMoneda)
    End Sub

End Class
