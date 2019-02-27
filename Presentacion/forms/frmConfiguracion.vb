Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmConfiguracion

    Private _configuracion As New EConfiguracion() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNConfiguracion As New LNConfiguracion() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()

        txtRuta.Text = Config.RutaExcelPorDefecto
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thrG As New Thread(AddressOf CargarComboGastos)
        thrG.Start()
        Dim thrI As New Thread(AddressOf CargarComboIngresos)
        thrI.Start()
    End Sub

    'Evento Click del Botón Aceptar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Actualizar()
        GrabarDatos()

        Close()
    End Sub

    'Evento Click del Botón Cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmConfiguracion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control And e.KeyCode = Keys.A Then
            btnAceptar_Click(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.C Then
            btnCancelar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        fbDialog.ShowDialog()
        If fbDialog.SelectedPath <> "" Then
            txtRuta.Text = fbDialog.SelectedPath
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos()
        Try
            _LNConfiguracion.ActualizarTodo(_configuracion, Config)
            MessageBox.Show("La configuración se actualizó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Config = _configuracion
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Configuracion según los datos del formulario.
    Public Sub Actualizar()
        _configuracion.CategoriaGastosPorDefecto = cmbGastos.SelectedValue
        _configuracion.CategoriaIngresosPorDefecto = cmbIngresos.SelectedValue
        _configuracion.RutaExcelPorDefecto = txtRuta.Text
    End Sub

    'Cargar el ComboBox con las categorías de Gastos.
    Public Sub CargarComboGastos()
        Try
            Dim categorias As List(Of ECategoria) = _LNCategoria.ObtenerGastos()

            cmbGastos.DataSource = categorias
            cmbGastos.DisplayMember = "Nombre"
            cmbGastos.ValueMember = "ID"

            cmbGastos.SelectedValue = Config.CategoriaGastosPorDefecto
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las categorías de Ingresos.
    Public Sub CargarComboIngresos()
        Try
            Dim categorias As List(Of ECategoria) = _LNCategoria.ObtenerIngresos()

            cmbIngresos.DataSource = categorias
            cmbIngresos.DisplayMember = "Nombre"
            cmbIngresos.ValueMember = "ID"

            cmbIngresos.SelectedValue = Config.CategoriaIngresosPorDefecto
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class