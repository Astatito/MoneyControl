Imports Entidades
Imports LogicaNegocio

Public Class frmABMCategorias

    Private _categoria As New ECategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmCategorias()
        form.ShowDialog()

        CargarDGV()
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvCategorias.SelectedCells.Count <> 0 Then
                CargarCategoria(dgvCategorias.SelectedCells(0).RowIndex)

                Dim form As New frmCategorias(_categoria)
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
            If dgvCategorias.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar esta categoría? También se eliminarán las subcategorías correspondientes.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvCategorias.SelectedCells(0).RowIndex
                    Dim idCategoria As Integer = dgvCategorias.Rows(fila).Cells(0).Value
                    Dim tipoCategoria As String = dgvCategorias.Rows(fila).Cells(2).Value
                    Eliminar(idCategoria, tipoCategoria)
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
        frm.dgvExportar = dgvCategorias
        frm.ShowDialog()
    End Sub

    'Evento CheckedChanged de los RadioButton
    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodas.CheckedChanged, rbGasto.CheckedChanged, rbIngreso.CheckedChanged
        CargarDGV()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMCategorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            rbTodas.Checked = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.I Then
            rbIngreso.Checked = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            rbGasto.Checked = True
        End If

    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas categorías.
    Private Sub CargarDGV()
        Try
            Dim categorias As List(Of ECategoria) = Nothing

            If rbTodas.Checked Then
                categorias = _LNCategoria.ObtenerTodos()
            ElseIf rbIngreso.Checked Then
                categorias = _LNCategoria.ObtenerIngresos()
            ElseIf rbGasto.Checked Then
                categorias = _LNCategoria.ObtenerGastos()
            End If

            dgvCategorias.AutoGenerateColumns = False
            dgvCategorias.DataSource = categorias
            dgvCategorias.Columns("idColumn").DataPropertyName = "ID"
            dgvCategorias.Columns("nombreColumn").DataPropertyName = "Nombre"
            dgvCategorias.Columns("tipoMovimientoColumn").DataPropertyName = "TipoMovimiento"
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar la categoría seleccionada.
    Private Sub Eliminar(ByVal idCategoria As Integer, ByVal tipoCategoria As String)
        If idCategoria = Config.CategoriaGastosPorDefecto OrElse idCategoria = Config.CategoriaIngresosPorDefecto Then
            MessageBox.Show("La categoría ingresada es una categoría por defecto. Para eliminarla, primero debe definir una nueva categoría por defecto en el menú de Configuración.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            _LNCategoria.Eliminar(idCategoria, tipoCategoria, Config)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Categoría con los datos de la fila seleccionada.
    Private Sub CargarCategoria(ByVal fila As Integer)
        _categoria.ID = dgvCategorias.Rows(fila).Cells(0).Value
        _categoria.Nombre = dgvCategorias.Rows(fila).Cells(1).Value
        _categoria.TipoMovimiento = dgvCategorias.Rows(fila).Cells(2).Value
    End Sub

End Class