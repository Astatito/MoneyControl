Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmABMCategorias

    Private _categoria As New ECategoria() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf Me.CargarDGV)
            thr.Start()

            Dim modiCol As New DataGridViewButtonColumn()
            modiCol.Name = "columnModificar"
            modiCol.HeaderText = ""
            modiCol.ToolTipText = "Modificar."
            Me.dgvCategorias.Columns.Add(modiCol)

            Dim elimCol As New DataGridViewButtonColumn()
            elimCol.Name = "columnEliminar"
            elimCol.HeaderText = ""
            elimCol.ToolTipText = "Eliminar."
            Me.dgvCategorias.Columns.Add(elimCol)

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMCategorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            rbTodos.Checked = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.I Then
            rbIngreso.Checked = True
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            rbEgreso.Checked = True
        End If

    End Sub

    'Evento CellPainting del DataGridView
    Private Sub dgvCategorias_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvCategorias.CellPainting
        If e.ColumnIndex >= 0 AndAlso Me.dgvCategorias.Columns(e.ColumnIndex).Name = "columnModificar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvCategorias.Rows(e.RowIndex).Cells("columnModificar"), DataGridViewButtonCell)
            Dim icoLapiz As Icon = New Icon(Environment.CurrentDirectory + "\img\pencil.ico", 15, 15)

            e.Graphics.DrawIcon(icoLapiz, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvCategorias.Rows(e.RowIndex).Height = icoLapiz.Height + 10
            Me.dgvCategorias.Columns(e.ColumnIndex).Width = icoLapiz.Width + 10
            e.Handled = True
        ElseIf e.ColumnIndex >= 0 AndAlso Me.dgvCategorias.Columns(e.ColumnIndex).Name = "columnEliminar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvCategorias.Rows(e.RowIndex).Cells("columnEliminar"), DataGridViewButtonCell)
            Dim icoTacho As Icon = New Icon(Environment.CurrentDirectory + "\img\trash.ico", 15, 15)

            e.Graphics.DrawIcon(icoTacho, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvCategorias.Rows(e.RowIndex).Height = icoTacho.Height + 10
            Me.dgvCategorias.Columns(e.ColumnIndex).Width = icoTacho.Width + 10
            e.Handled = True
        End If
    End Sub

    'Evento CellClick del DataGridView
    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick
        Dim columna As String = Me.dgvCategorias.Columns(e.ColumnIndex).Name
        Try
            If columna = "columnEliminar" Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim idCategoria As Integer = Me.dgvCategorias.CurrentRow.Cells(0).Value
                    Eliminar(idCategoria)
                    CargarDGV()
                End If
            ElseIf columna = "columnModificar" Then
                CargarCategoria(Me.dgvCategorias.CurrentRow.Index)

                Dim form As New frmCategorias(_categoria)
                form.ShowDialog()

                CargarDGV()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmCategorias()
        form.ShowDialog()

        CargarDGV()
    End Sub

    'Evento CheckedChanged de los RadioButton
    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged, rbEgreso.CheckedChanged, rbIngreso.CheckedChanged
        CargarDGV()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas monedas.
    Private Sub CargarDGV()
        Try
            Dim categorias As List(Of ECategoria) = Nothing

            If Me.rbTodos.Checked Then
                categorias = _LNCategoria.ObtenerTodos()
            ElseIf Me.rbIngreso.Checked Then
                categorias = _LNCategoria.ObtenerIngresos()
            ElseIf Me.rbEgreso.Checked Then
                categorias = _LNCategoria.ObtenerEgresos()
            End If

            Me.dgvCategorias.AutoGenerateColumns = False
            Me.dgvCategorias.DataSource = categorias
            Me.dgvCategorias.Columns("idColumn").DataPropertyName = "ID"
            Me.dgvCategorias.Columns("nombreColumn").DataPropertyName = "Nombre"
            Me.dgvCategorias.Columns("tipoColumn").DataPropertyName = "Tipo"
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar la moneda seleccionada.
    Private Sub Eliminar(idCategoria As Integer)
        Try
            _LNCategoria.Eliminar(idCategoria)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar los datos de la fila seleccionada en una Entidad
    Private Sub CargarCategoria(ByVal fila As Integer)
        _categoria.ID = Me.dgvCategorias.Rows(fila).Cells(0).Value
        _categoria.Nombre = Me.dgvCategorias.Rows(fila).Cells(1).Value
        _categoria.Tipo = Me.dgvCategorias.Rows(fila).Cells(2).Value
    End Sub


End Class