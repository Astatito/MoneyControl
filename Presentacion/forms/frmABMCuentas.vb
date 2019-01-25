Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmABMCuentas

    Private _cuenta As New ECuenta() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf Me.CargarDGV)
            thr.Start()

            Dim modiCol As New DataGridViewButtonColumn()
            modiCol.Name = "columnModificar"
            modiCol.HeaderText = ""
            modiCol.ToolTipText = "Modificar."
            Me.dgvCuentas.Columns.Add(modiCol)

            Dim elimCol As New DataGridViewButtonColumn()
            elimCol.Name = "columnEliminar"
            elimCol.HeaderText = ""
            elimCol.ToolTipText = "Eliminar."
            Me.dgvCuentas.Columns.Add(elimCol)

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMCuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        End If
    End Sub

    'Evento CellPainting del DataGridView
    Private Sub dgvCuentas_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvCuentas.CellPainting
        If e.ColumnIndex >= 0 AndAlso Me.dgvCuentas.Columns(e.ColumnIndex).Name = "columnModificar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvCuentas.Rows(e.RowIndex).Cells("columnModificar"), DataGridViewButtonCell)
            Dim icoLapiz As Icon = New Icon(Environment.CurrentDirectory + "\img\pencil.ico", 15, 15)

            e.Graphics.DrawIcon(icoLapiz, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvCuentas.Rows(e.RowIndex).Height = icoLapiz.Height + 10
            Me.dgvCuentas.Columns(e.ColumnIndex).Width = icoLapiz.Width + 10
            e.Handled = True
        ElseIf e.ColumnIndex >= 0 AndAlso Me.dgvCuentas.Columns(e.ColumnIndex).Name = "columnEliminar" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = TryCast(Me.dgvCuentas.Rows(e.RowIndex).Cells("columnEliminar"), DataGridViewButtonCell)
            Dim icoTacho As Icon = New Icon(Environment.CurrentDirectory + "\img\trash.ico", 15, 15)

            e.Graphics.DrawIcon(icoTacho, e.CellBounds.Left + 5, e.CellBounds.Top + 5)
            Me.dgvCuentas.Rows(e.RowIndex).Height = icoTacho.Height + 10
            Me.dgvCuentas.Columns(e.ColumnIndex).Width = icoTacho.Width + 10
            e.Handled = True
        End If
    End Sub

    'Evento CellClick del DataGridView
    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        Dim columna As String = Me.dgvCuentas.Columns(e.ColumnIndex).Name
        Try
            If columna = "columnEliminar" Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim idCuenta As Integer = Me.dgvCuentas.CurrentRow.Cells(0).Value
                    Eliminar(idCuenta)
                    CargarDGV()
                End If
            ElseIf columna = "columnModificar" Then
                CargarCuenta(Me.dgvCuentas.CurrentRow.Index)

                Dim form As New frmCuentas(_cuenta)
                form.ShowDialog()

                CargarDGV()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmCuentas
        form.ShowDialog()

        CargarDGV()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas cuentas.
    Private Sub CargarDGV()
        Try
            Dim cuentas As List(Of ECuenta) = _LNCuenta.ObtenerTodosFull()

            Me.dgvCuentas.AutoGenerateColumns = False
            Me.dgvCuentas.DataSource = cuentas
            Me.dgvCuentas.Columns("idColumn").DataPropertyName = "ID"
            Me.dgvCuentas.Columns("nombreColumn").DataPropertyName = "Nombre"
            Me.dgvCuentas.Columns("tipoCuentaColumn").DataPropertyName = "TipoCuenta"
            Me.dgvCuentas.Columns("descripcionTipoCuentaColumn").DataPropertyName = "DescripcionTipoCuenta"
            Me.dgvCuentas.Columns("monedaColumn").DataPropertyName = "Moneda"
            Me.dgvCuentas.Columns("codigoMonedaColumn").DataPropertyName = "CodigoMoneda"
            Me.dgvCuentas.Columns("saldoColumn").DataPropertyName = "Saldo"
            Me.dgvCuentas.Columns("descripcionColumn").DataPropertyName = "Descripcion"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar la cuenta seleccionada.
    Private Sub Eliminar(idCuenta As Integer)
        Try
            _LNCuenta.Eliminar(idCuenta)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el objeto Cuenta con los datos de la fila seleccionada.
    Private Sub CargarCuenta(ByVal fila As Integer)
        _cuenta.ID = Me.dgvCuentas.Rows(fila).Cells(0).Value
        _cuenta.Nombre = Me.dgvCuentas.Rows(fila).Cells(1).Value
        _cuenta.TipoCuenta = Me.dgvCuentas.Rows(fila).Cells(2).Value
        _cuenta.DescripcionTipoCuenta = Me.dgvCuentas.Rows(fila).Cells(3).Value
        _cuenta.Moneda = Me.dgvCuentas.Rows(fila).Cells(4).Value
        _cuenta.CodigoMoneda = Me.dgvCuentas.Rows(fila).Cells(5).Value
        _cuenta.Saldo = Me.dgvCuentas.Rows(fila).Cells(6).Value
        _cuenta.Descripcion = Me.dgvCuentas.Rows(fila).Cells(7).Value

    End Sub

End Class