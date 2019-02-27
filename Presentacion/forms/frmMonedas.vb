Imports Entidades
Imports LogicaNegocio

Public Class frmMonedas

    Private _moneda As EMoneda 'Objeto perteneciente a la capa de Entidades.
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Text = "Nuevo"

        _moneda = New EMoneda()
    End Sub

    Public Sub New(ByVal moneda As EMoneda)
        InitializeComponent()
        Text = "Modificar"

        _moneda = New EMoneda()
        _moneda = moneda
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCodigo.Text = _moneda.Codigo
        txtDescripcion.Text = _moneda.Descripcion
    End Sub

    'Evento KeyDown del Form
    Private Sub frmMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Actualizar()
        GrabarDatos()

        If _LNMoneda.sb.Length <> 0 Then
            MessageBox.Show(_LNMoneda.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos()
        Try
            If _moneda.ID = 0 Then
                _LNMoneda.Insertar(_moneda)
            Else
                _LNMoneda.Actualizar(_moneda)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Actualizar el objeto Moneda con los datos del formulario.
    Public Sub Actualizar()
        _moneda.Codigo = txtCodigo.Text.ToString.ToUpper.Trim()
        _moneda.Descripcion = txtDescripcion.Text.ToString.Trim()
    End Sub

End Class