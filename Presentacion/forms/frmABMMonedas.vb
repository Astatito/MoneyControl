Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmABMMonedas

    Private _moneda As New EMoneda() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf Me.cargarDGV)
            thr.Start()

            Dim modiCol As New DataGridViewButtonColumn()
            modiCol.Name = "columnModificar"
            modiCol.HeaderText = ""
            modiCol.ToolTipText = "Modificar."
            dgvMonedas.Columns.Add(modiCol)

            Dim elimCol As New DataGridViewButtonColumn()
            elimCol.Name = "columnEliminar"
            elimCol.HeaderText = ""
            elimCol.ToolTipText = "Eliminar."
            dgvMonedas.Columns.Add(elimCol)

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        End If

    End Sub

    'Evento CellPainting del DataGridView
    Private Sub dgvMonedas_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvMonedas.CellPainting
        If e.ColumnIndex >= 0 AndAlso Me.dgvMonedas.Columns(e.ColumnIndex).Name = "columnModificar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvMonedas.Rows(e.RowIndex).Cells("columnModificar"), DataGridViewButtonCell)
            Dim icoLapiz As Icon = New Icon(Environment.CurrentDirectory + "\img\pencil.ico", 15, 15)

            e.Graphics.DrawIcon(icoLapiz, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvMonedas.Rows(e.RowIndex).Height = icoLapiz.Height + 10
            Me.dgvMonedas.Columns(e.ColumnIndex).Width = icoLapiz.Width + 10
            e.Handled = True
        ElseIf e.ColumnIndex >= 0 AndAlso Me.dgvMonedas.Columns(e.ColumnIndex).Name = "columnEliminar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvMonedas.Rows(e.RowIndex).Cells("columnEliminar"), DataGridViewButtonCell)
            Dim icoTacho As Icon = New Icon(Environment.CurrentDirectory + "\img\trash.ico", 15, 15)

            e.Graphics.DrawIcon(icoTacho, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvMonedas.Rows(e.RowIndex).Height = icoTacho.Height + 10
            Me.dgvMonedas.Columns(e.ColumnIndex).Width = icoTacho.Width + 10
            e.Handled = True
        End If
    End Sub

    'Evento CellClick del DataGridView
    Private Sub dgvMonedas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMonedas.CellClick
        Dim columna As String = Me.dgvMonedas.Columns(e.ColumnIndex).Name
        Try
            If columna = "columnEliminar" Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim idMoneda As Integer = Me.dgvMonedas.CurrentRow.Cells(0).Value
                    Eliminar(idMoneda)
                    cargarDGV()
                End If
            ElseIf columna = "columnModificar" Then
                cargarMoneda(Me.dgvMonedas.CurrentRow.Index)
                Dim form As New frmMonedas(_moneda)
                form.ShowDialog()
                cargarDGV()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmMonedas()
        form.ShowDialog()

        CargarDGV()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas monedas.
    Private Sub CargarDGV()
        Try
            Dim monedas As List(Of EMoneda) = _LNMoneda.ObtenerTodos()

            Me.dgvMonedas.AutoGenerateColumns = False
            Me.dgvMonedas.DataSource = monedas
            Me.dgvMonedas.Columns("idColumn").DataPropertyName = "ID"
            Me.dgvMonedas.Columns("codigoColumn").DataPropertyName = "Codigo"
            Me.dgvMonedas.Columns("descripcionColumn").DataPropertyName = "Descripcion"
            Me.dgvMonedas.Columns("porDefectoColumn").DataPropertyName = "PorDefecto"
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar la moneda seleccionada.
    Private Sub Eliminar(idMoneda As Integer)
        Try
            _LNMoneda.Eliminar(idMoneda)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar los datos de la fila seleccionada en una Entidad
    Private Sub CargarMoneda(ByVal fila As Integer)
        _moneda.ID = Me.dgvMonedas.Rows(fila).Cells(0).Value
        _moneda.Codigo = Me.dgvMonedas.Rows(fila).Cells(1).Value
        _moneda.Descripcion = Me.dgvMonedas.Rows(fila).Cells(2).Value
        _moneda.PorDefecto = Me.dgvMonedas.Rows(fila).Cells(3).Value
    End Sub

End Class
