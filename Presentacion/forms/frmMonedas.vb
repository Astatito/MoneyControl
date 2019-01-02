Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmMonedas

    Private _moneda As EMoneda 'Objeto perteneciente a la capa de Entidades.
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Me.Text = "Nuevo"

        _moneda = New EMoneda()
    End Sub

    Public Sub New(ByVal moneda As EMoneda)
        InitializeComponent()
        Me.Text = "Modificar"

        _moneda = New EMoneda()
        _moneda = moneda
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtCodigo.Text = _moneda.Codigo
        Me.txtDescripcion.Text = _moneda.Descripcion
    End Sub

    'Evento KeyDown del Form
    Private Sub frmMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.G Then
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
            Me.Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Graba los datos ingresados en la base de datos
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

    'Guarda los datos ingresados en la entidad correspondiente
    Public Sub Actualizar()
        _moneda.Codigo = Me.txtCodigo.Text.ToString.ToUpper.Trim()
        _moneda.Descripcion = StrConv(Me.txtDescripcion.Text.ToString.Trim(), VbStrConv.ProperCase)
    End Sub
End Class