Imports Entidades
Imports AccesoDatos
Imports System.Text

Public Class LNMoneda

    Private _ADMoneda As New ADMoneda() 'Objeto perteneciente a la capa de Acceso a Datos.
    Public ReadOnly sb As New StringBuilder() 'Objeto que almacena la cadena de errores.

    'Verifica que los datos ingresados sean correctos.
    Public Function validarMoneda(moneda As EMoneda)
        sb.Clear()

        If String.IsNullOrEmpty(moneda.Pais) Then
            sb.Append("El campo 'Nombre' es obligatorio.")
        End If

        If String.IsNullOrEmpty(moneda.Codigo) Then
            sb.Append(Environment.NewLine + "El campo 'Código' es obligatorio.")
        End If

        If String.IsNullOrEmpty(moneda.Nombre) Then
            sb.Append(Environment.NewLine + "El campo 'Nombre' es obligatorio.")
        End If

        Return sb.Length = 0
    End Function

    'Inserta un registro válido en la tabla Monedas.
    Public Sub Insertar(moneda As EMoneda)
        If validarMoneda(moneda) Then
            _ADMoneda.Insertar(moneda)
        End If
    End Sub

    'Actualiza un registro válido de la tabla Monedas.
    Public Sub Actualizar(moneda As EMoneda)
        If validarMoneda(moneda) Then
            _ADMoneda.Actualizar(moneda)
        End If
    End Sub

    'Elimina un registro de la tabla Monedas
    Public Sub Eliminar(ByVal idMoneda As Integer)
        _ADMoneda.Eliminar(idMoneda)
    End Sub

    'Obtener todos los registros de la tabla Monedas.
    Public Function ObtenerTodos()
        Return _ADMoneda.ObtenerTodos()
    End Function

    'Obtiene un registro de la tabla Monedas a partir de un ID.
    Public Function ObtenerPorID(ByVal idMoneda As Integer)
        Return _ADMoneda.ObtenerPorId(idMoneda)
    End Function

End Class
