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

    '____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPais.Text = _moneda.Pais
        txtCodigo.Text = _moneda.Codigo
        txtNombre.Text = _moneda.Nombre
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Actualizar()
        GrabarDatos()
        Me.Close()
    End Sub

    '____FUNCIONES/RUTINAS____

    'Graba los datos ingresados en la base de datos
    Public Sub GrabarDatos()
        If _moneda.Id = 0 Then
            _LNMoneda.Insertar(_moneda)
        Else
            _LNMoneda.Actualizar(_moneda)
        End If
    End Sub

    'Guarda los datos ingresados en la entidad correspondiente
    Public Sub Actualizar()
        _moneda.Pais = txtPais.Text.ToString
        _moneda.Codigo = txtCodigo.Text.ToString
        _moneda.Nombre = txtNombre.Text.ToString
    End Sub

End Class