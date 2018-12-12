Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmABMTiposCuenta

    Private _tipoCuenta As New ETipoCuenta() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNTipoCuenta As New LNTipoCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMTiposCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf cargarDGV)
            thr.Start()

            Dim modiCol As New DataGridViewButtonColumn()
            modiCol.Name = "columnModificar"
            modiCol.HeaderText = ""
            modiCol.ToolTipText = "Modificar."
            dgvTiposCuenta.Columns.Add(modiCol)

            Dim elimCol As New DataGridViewButtonColumn()
            elimCol.Name = "columnEliminar"
            elimCol.HeaderText = ""
            elimCol.ToolTipText = "Eliminar."
            dgvTiposCuenta.Columns.Add(elimCol)

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento CellPainting del DataGridView
    Private Sub dgvTiposCuenta_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvTiposCuenta.CellPainting
        If e.ColumnIndex >= 0 AndAlso Me.dgvTiposCuenta.Columns(e.ColumnIndex).Name = "columnModificar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvTiposCuenta.Rows(e.RowIndex).Cells("columnModificar"), DataGridViewButtonCell)
            Dim icoLapiz As Icon = New Icon(Environment.CurrentDirectory + "\img\pencil.ico", 15, 15)

            e.Graphics.DrawIcon(icoLapiz, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvTiposCuenta.Rows(e.RowIndex).Height = icoLapiz.Height + 10
            Me.dgvTiposCuenta.Columns(e.ColumnIndex).Width = icoLapiz.Width + 10
            e.Handled = True
        ElseIf e.ColumnIndex >= 0 AndAlso Me.dgvTiposCuenta.Columns(e.ColumnIndex).Name = "columnEliminar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvTiposCuenta.Rows(e.RowIndex).Cells("columnEliminar"), DataGridViewButtonCell)
            Dim icoTacho As Icon = New Icon(Environment.CurrentDirectory + "\img\trash.ico", 15, 15)

            e.Graphics.DrawIcon(icoTacho, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvTiposCuenta.Rows(e.RowIndex).Height = icoTacho.Height + 10
            Me.dgvTiposCuenta.Columns(e.ColumnIndex).Width = icoTacho.Width + 10
            e.Handled = True
        End If
    End Sub

    'Evento CellClick del DataGridView
    Private Sub dgvTiposCuenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiposCuenta.CellClick
        Dim columna As String = Me.dgvTiposCuenta.Columns(e.ColumnIndex).Name

        If columna = "columnEliminar" Then
            If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim idTipoCuenta As Integer = Me.dgvTiposCuenta.CurrentRow.Cells(0).Value
                Eliminar(idTipoCuenta)
                cargarDGV()
            End If
        ElseIf columna = "columnModificar" Then
            cargarTipoCuenta(Me.dgvTiposCuenta.CurrentRow.Index)
            Dim form As New frmTiposCuenta(_tipoCuenta)
            form.ShowDialog()
            cargarDGV()
        End If
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMTiposCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmTiposCuenta()
        form.ShowDialog()

        cargarDGV()
    End Sub

    '____FUNCIONES/RUTINAS____

    'Carga el DGV con los registros de la tabla TiposCuenta.
    Private Sub CargarDGV()
        Try
            Dim tiposCuenta As List(Of ETipoCuenta) = _LNTipoCuenta.ObtenerTodos()

            Me.dgvTiposCuenta.AutoGenerateColumns = False
            Me.dgvTiposCuenta.DataSource = tiposCuenta
            Me.dgvTiposCuenta.Columns("idColumn").DataPropertyName = "id"
            Me.dgvTiposCuenta.Columns("nombreColumn").DataPropertyName = "nombre"
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Elimina el registro seleccionado de la tabla TiposCuenta.
    Private Sub Eliminar(idTipoCuenta As Integer)
        Try
            _LNTipoCuenta.Eliminar(idTipoCuenta)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Carga los datos de la fila seleccionada en una Entidad
    Private Sub CargarTipoCuenta(ByVal fila As Integer)
        _tipoCuenta.Id = Me.dgvTiposCuenta.Rows(fila).Cells(0).Value
        _tipoCuenta.Nombre = Me.dgvTiposCuenta.Rows(fila).Cells(1).Value
    End Sub

End Class