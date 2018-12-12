Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmMonedaPorDefecto

    Private _moneda As New EMoneda() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
    End Sub

    '____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedaPorDefecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf cargarCombo)
        thr.Start()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmMonedaPorDefecto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    'Evento Click del botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        _LNMoneda.DefinirMonedaPorDefecto(cmbMonedas.SelectedValue)
        Me.Close()
    End Sub

    '____FUNCIONES/RUTINAS____

    'Cargar combo
    Public Sub CargarCombo()
        Try
            Dim monedas As List(Of EMoneda) = _LNMoneda.ObtenerTodos()

            Me.cmbMonedas.DataSource = monedas
            Me.cmbMonedas.DisplayMember = "Nombre"
            Me.cmbMonedas.ValueMember = "Id"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


End Class