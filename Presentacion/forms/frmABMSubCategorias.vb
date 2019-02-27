Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmABMSubCategorias

    Private _subcategoria As New ESubCategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNSubCategoria As New LNSubCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNTipoMovimiento As New LNTipoMovimiento() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMSubCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf CargarComboTiposMovimiento)
            thr.Start()

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMSubCategorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnEditar_Click(sender, e)
        ElseIf e.KeyCode = Keys.Delete Then
            btnEliminar_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnExportar_Click(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.T Then
            rbTodas.Checked = True
        ElseIf e.Control And e.KeyCode = Keys.S Then
            rbSeleccion.Checked = True
        End If
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmSubCategorias
        form.ShowDialog()

        CargarDGV()
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvSubCategorias.SelectedCells.Count <> 0 Then
                CargarSubCategoria(dgvSubCategorias.SelectedCells(0).RowIndex)

                Dim form As New frmSubCategorias(_subcategoria)
                form.ShowDialog()

                CargarDGV()
            Else
                MessageBox.Show("No hay ninguna fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvSubCategorias.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar esta subcategoría?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvSubCategorias.SelectedCells(0).RowIndex
                    Dim idCuenta As Integer = dgvSubCategorias.Rows(fila).Cells(0).Value
                    Eliminar(idCuenta)
                    CargarDGV()
                End If
            Else
                MessageBox.Show("No hay ninguna fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Exportar
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim frm As New frmExcel(Tag)
        frm.dgvExportar = dgvSubCategorias
        frm.ShowDialog()
    End Sub

    'Evento CheckedChanged de los RadioButton
    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged, rbSeleccion.CheckedChanged
        grpSeleccion.Enabled = rbSeleccion.Checked

        CargarDGV()
    End Sub

    'Evento SelectionChangeCommited del ComboBox de Tipos de Categoría
    Private Sub cmbTiposCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTiposMovimiento.SelectionChangeCommitted
        cmbCategorias.DataSource = Nothing
        CargarComboCategorias()
    End Sub

    'Evento SelectionChangeCommited del ComboBox de Categorías
    Private Sub cmbCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategorias.SelectionChangeCommitted
        CargarDGV()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas subcategorías.
    Private Sub CargarDGV()
        Try
            Dim subcategorias As List(Of ESubCategoria) = Nothing

            If rbTodas.Checked Then
                subcategorias = _LNSubCategoria.ObtenerTodosFull()
            ElseIf rbSeleccion.Checked Then
                subcategorias = _LNSubCategoria.ObtenerPorCategoriaFull(cmbCategorias.SelectedValue)
            End If

            dgvSubCategorias.AutoGenerateColumns = False
            dgvSubCategorias.DataSource = subcategorias
            dgvSubCategorias.Columns("idColumn").DataPropertyName = "ID"
            dgvSubCategorias.Columns("nombreColumn").DataPropertyName = "Nombre"
            dgvSubCategorias.Columns("categoriaColumn").DataPropertyName = "Categoria"
            dgvSubCategorias.Columns("nombreCategoriaColumn").DataPropertyName = "NombreCategoria"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas categorías.
    Private Sub CargarComboCategorias()
        Try
            Dim categorias As List(Of ECategoria) = Nothing

            If cmbTiposMovimiento.SelectedValue = "Ingreso" Then
                categorias = _LNCategoria.ObtenerIngresos()
            ElseIf cmbTiposMovimiento.SelectedValue = "Gasto" Then
                categorias = _LNCategoria.ObtenerGastos()
            End If

            cmbCategorias.DataSource = categorias
            cmbCategorias.DisplayMember = "Nombre"
            cmbCategorias.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con los distintos tipos de movimiento.
    Private Sub CargarComboTiposMovimiento()
        Try
            Dim tiposMovimiento As List(Of ETipoMovimiento) = _LNTipoMovimiento.ObtenerTodos()

            cmbTiposMovimiento.DataSource = tiposMovimiento
            cmbTiposMovimiento.DisplayMember = "TipoMovimiento"
            cmbTiposMovimiento.ValueMember = "TipoMovimiento"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar la subcategoría seleccionada.
    Private Sub Eliminar(idSubCategoria As Integer)
        Try
            _LNSubCategoria.Eliminar(idSubCategoria)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Subcategoría con los datos de la fila seleccionada.
    Private Sub CargarSubCategoria(ByVal fila As Integer)
        _subcategoria.ID = dgvSubCategorias.Rows(fila).Cells(0).Value
        _subcategoria.Nombre = dgvSubCategorias.Rows(fila).Cells(1).Value
        _subcategoria.Categoria = dgvSubCategorias.Rows(fila).Cells(2).Value
        _subcategoria.NombreCategoria = dgvSubCategorias.Rows(fila).Cells(3).Value
    End Sub

End Class