Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmSubCategorias

    Private _subCategoria As New ESubCategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNSubCategoria As New LNSubCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Me.Text = "Nuevo"

        _subCategoria = New ESubCategoria()
    End Sub

    Public Sub New(ByVal subCategoria As ESubCategoria)
        InitializeComponent()
        Me.Text = "Modificar"

        _subCategoria = New ESubCategoria()
        _subCategoria = subCategoria
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmSubCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf CargarComboCategorias)
        thr.Start()

        Me.txtNombre.Text = _subCategoria.Nombre
    End Sub

    'Evento KeyDown del Form
    Private Sub frmSubCategorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

        If _LNSubCategoria.sb.Length <> 0 Then
            MessageBox.Show(_LNSubCategoria.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos()
        Try
            If _subCategoria.ID = 0 Then
                _LNSubCategoria.Insertar(_subCategoria)
            Else
                _LNSubCategoria.Actualizar(_subCategoria)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Subcategoría con los datos del formulario.
    Public Sub Actualizar()
        _subCategoria.Nombre = Me.txtNombre.Text.ToString.Trim()
        _subCategoria.Categoria = Me.cmbCategorias.SelectedValue
    End Sub

    'Cargar el ComboBox con las distintas Categorías.
    Public Sub CargarComboCategorias()
        Try
            Dim categorias As List(Of ECategoria) = _LNCategoria.ObtenerTodos()

            Me.cmbCategorias.DataSource = categorias
            Me.cmbCategorias.DisplayMember = "Nombre"
            Me.cmbCategorias.ValueMember = "ID"

            If _subCategoria.Categoria <> 0 Then
                Me.cmbCategorias.SelectedValue = _subCategoria.Categoria
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class