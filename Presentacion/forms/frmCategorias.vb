Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmCategorias

    Private _categoria As New ECategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNTipoCategoria As New LNTipoCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.


    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Me.Text = "Nuevo"

        _categoria = New ECategoria()
    End Sub

    Public Sub New(ByVal categoria As ECategoria)
        InitializeComponent()
        Me.Text = "Modificar"

        _categoria = New ECategoria()
        _categoria = categoria
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf CargarComboTiposCategoria)
        thr.Start()

        Me.txtNombre.Text = _categoria.Nombre
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

        If _LNCategoria.sb.Length <> 0 Then
            MessageBox.Show(_LNCategoria.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Graba los datos ingresados en la base de datos
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

    'Guarda los datos ingresados en la entidad correspondiente
    Public Sub Actualizar()
        _categoria.Nombre = StrConv(Me.txtNombre.Text.ToString.Trim(), VbStrConv.ProperCase)
        _categoria.Tipo = Me.cmbTiposCategoria.SelectedItem
    End Sub

    'Cargar el ComboBox con los distintos tipos de Categorías.
    Public Sub CargarComboTiposCategoria()
        Try
            Dim tiposCategoria As List(Of ETipoCategoria) = _LNTipoCategoria.ObtenerTodos()

            Me.cmbTiposCategoria.DataSource = tiposCategoria
            Me.cmbTiposCategoria.DisplayMember = "Tipo"
            Me.cmbTiposCategoria.ValueMember = "Tipo"

            If _categoria.Tipo <> "" Then
                Me.cmbTiposCategoria.SelectedValue = _categoria.Tipo
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class