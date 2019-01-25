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
            Dim thr As New Thread(AddressOf Me.CargarComboTiposMovimiento)
            thr.Start()

            Dim modiCol As New DataGridViewButtonColumn()
            modiCol.Name = "columnModificar"
            modiCol.HeaderText = ""
            modiCol.ToolTipText = "Modificar."
            Me.dgvSubCategorias.Columns.Add(modiCol)

            Dim elimCol As New DataGridViewButtonColumn()
            elimCol.Name = "columnEliminar"
            elimCol.HeaderText = ""
            elimCol.ToolTipText = "Eliminar."
            Me.dgvSubCategorias.Columns.Add(elimCol)

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMSubCategorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.T Then
            rbTodas.Checked = True
        ElseIf e.Control And e.KeyCode = Keys.S Then
            rbSeleccion.Checked = True
        End If
    End Sub

    'Evento CellPainting del DataGridView
    Private Sub dgvSubCategorias_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvSubCategorias.CellPainting
        If e.ColumnIndex >= 0 AndAlso Me.dgvSubCategorias.Columns(e.ColumnIndex).Name = "columnModificar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvSubCategorias.Rows(e.RowIndex).Cells("columnModificar"), DataGridViewButtonCell)
            Dim icoLapiz As Icon = New Icon(Environment.CurrentDirectory + "\img\pencil.ico", 15, 15)

            e.Graphics.DrawIcon(icoLapiz, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvSubCategorias.Rows(e.RowIndex).Height = icoLapiz.Height + 10
            Me.dgvSubCategorias.Columns(e.ColumnIndex).Width = icoLapiz.Width + 10
            e.Handled = True
        ElseIf e.ColumnIndex >= 0 AndAlso Me.dgvSubCategorias.Columns(e.ColumnIndex).Name = "columnEliminar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvSubCategorias.Rows(e.RowIndex).Cells("columnEliminar"), DataGridViewButtonCell)
            Dim icoTacho As Icon = New Icon(Environment.CurrentDirectory + "\img\trash.ico", 15, 15)

            e.Graphics.DrawIcon(icoTacho, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvSubCategorias.Rows(e.RowIndex).Height = icoTacho.Height + 10
            Me.dgvSubCategorias.Columns(e.ColumnIndex).Width = icoTacho.Width + 10
            e.Handled = True
        End If
    End Sub

    'Evento CellClick del DataGridView
    Private Sub dgvSubCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCategorias.CellClick
        Dim columna As String = Me.dgvSubCategorias.Columns(e.ColumnIndex).Name
        Try
            If columna = "columnEliminar" Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim idCuenta As Integer = Me.dgvSubCategorias.CurrentRow.Cells(0).Value
                    Eliminar(idCuenta)
                    CargarDGV()
                End If
            ElseIf columna = "columnModificar" Then
                CargarSubCategoria(Me.dgvSubCategorias.CurrentRow.Index)

                Dim form As New frmSubCategorias(_subcategoria)
                form.ShowDialog()

                CargarDGV()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmSubCategorias
        form.ShowDialog()

        CargarDGV()
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

            If Me.rbTodas.Checked Then
                subcategorias = _LNSubCategoria.ObtenerTodosFull()
            ElseIf rbSeleccion.Checked Then
                subcategorias = _LNSubCategoria.ObtenerPorCategoriaFull(cmbCategorias.SelectedValue)
            End If

            Me.dgvSubCategorias.AutoGenerateColumns = False
            Me.dgvSubCategorias.DataSource = subcategorias
            Me.dgvSubCategorias.Columns("idColumn").DataPropertyName = "ID"
            Me.dgvSubCategorias.Columns("nombreColumn").DataPropertyName = "Nombre"
            Me.dgvSubCategorias.Columns("categoriaColumn").DataPropertyName = "Categoria"
            Me.dgvSubCategorias.Columns("nombreCategoriaColumn").DataPropertyName = "NombreCategoria"

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

            Me.cmbCategorias.DataSource = categorias
            Me.cmbCategorias.DisplayMember = "Nombre"
            Me.cmbCategorias.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con los distintos tipos de movimiento.
    Private Sub CargarComboTiposMovimiento()
        Try
            Dim tiposMovimiento As List(Of ETipoMovimiento) = _LNTipoMovimiento.ObtenerTodos()

            Me.cmbTiposMovimiento.DataSource = tiposMovimiento
            Me.cmbTiposMovimiento.DisplayMember = "TipoMovimiento"
            Me.cmbTiposMovimiento.ValueMember = "TipoMovimiento"

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
        _subcategoria.ID = Me.dgvSubCategorias.Rows(fila).Cells(0).Value
        _subcategoria.Nombre = Me.dgvSubCategorias.Rows(fila).Cells(1).Value
        _subcategoria.Categoria = Me.dgvSubCategorias.Rows(fila).Cells(2).Value
        _subcategoria.NombreCategoria = Me.dgvSubCategorias.Rows(fila).Cells(3).Value
    End Sub

End Class