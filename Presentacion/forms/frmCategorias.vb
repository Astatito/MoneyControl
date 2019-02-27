Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmCategorias

    Private _categoria As New ECategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNTipoMovimiento As New LNTipoMovimiento() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Text = "Nuevo"

        _categoria = New ECategoria()
    End Sub

    Public Sub New(ByVal categoria As ECategoria)
        InitializeComponent()
        Text = "Modificar"

        _categoria = New ECategoria()
        _categoria = categoria
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf CargarComboTiposMovimiento)
        thr.Start()

        txtNombre.Text = _categoria.Nombre
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

        If _LNCategoria.sb.Length <> 0 Then
            MessageBox.Show(_LNCategoria.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos
    Public Sub GrabarDatos()
        Try
            If _categoria.ID = 0 Then
                _LNCategoria.Insertar(_categoria)
            Else
                _LNCategoria.Actualizar(_categoria)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Categoría segun los datos del formulario.
    Public Sub Actualizar()
        _categoria.Nombre = txtNombre.Text.ToString.Trim()
        _categoria.TipoMovimiento = cmbTiposMovimiento.SelectedValue
    End Sub

    'Cargar el ComboBox con los distintos tipos de movimiento.
    Public Sub CargarComboTiposMovimiento()
        Try
            Dim tiposMovimiento As List(Of ETipoMovimiento) = _LNTipoMovimiento.ObtenerTodos()

            cmbTiposMovimiento.DataSource = tiposMovimiento
            cmbTiposMovimiento.DisplayMember = "TipoMovimiento"
            cmbTiposMovimiento.ValueMember = "TipoMovimiento"

            If _categoria.TipoMovimiento <> "" Then
                cmbTiposMovimiento.SelectedValue = _categoria.TipoMovimiento
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class