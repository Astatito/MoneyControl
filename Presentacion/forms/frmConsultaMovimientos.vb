Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmConsultaMovimientos

    Private _movimiento As New EMovimiento() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNMovimiento As New LNMovimiento() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmConsultaMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thr As New Thread(AddressOf CargarComboCuentas)
        thr.Start()

        dtpDesde.Value = New Date(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpHasta.MinDate = dtpDesde.Value
        dtpHasta.Value = DateTime.Today.Date
    End Sub

    'Evento Leave del DateTimePicker Hasta
    Private Sub dtpDesde_Leave(sender As Object, e As EventArgs) Handles dtpDesde.Leave
        dtpHasta.MinDate = dtpDesde.Value
        If dtpHasta.Value < dtpDesde.Value Then
            dtpHasta.Value = dtpDesde.Value
        End If

        txtBalance.BackColor = Color.LightGray
        txtBalance.Text = ""
        txtEgresos.Text = ""
        txtIngresos.Text = ""
    End Sub

    'Evento Click del Botón Buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cuenta As Integer = cmbCuentas.SelectedValue
        Dim fechaDesde As Date = dtpDesde.Value
        Dim fechaHasta As Date = dtpHasta.Value

        CargarDGV(cuenta, fechaDesde, fechaHasta)
        If dgvMovimientos.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron movimientos que coincidan con los parámetros de búsqueda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ingresos As Double = 0.0
        Dim egresos As Double = 0.0
        Dim total As Double = 0.0

        For Each row As DataGridViewRow In dgvMovimientos.Rows
            If row.Cells(7).Value > 0 Then
                ingresos += row.Cells(7).Value
            Else
                egresos += row.Cells(7).Value
            End If
        Next

        egresos *= -1
        total = ingresos - egresos

        txtIngresos.Text = Format(ingresos, "N2")
        txtEgresos.Text = Format(egresos, "N2")
        txtBalance.Text = Format(total, "N2")
        If total > 0 Then
            txtBalance.BackColor = Color.FromArgb(128, 255, 128)
        ElseIf total < 0 Then
            txtBalance.BackColor = Color.FromArgb(255, 128, 128)
        Else
            txtBalance.BackColor = Color.FromArgb(255, 128, 128)
        End If

    End Sub

    'Evento Enter del Combo y los DateTimePicker
    Private Sub control_Enter(sender As Object, e As EventArgs) Handles cmbCuentas.Enter, dtpDesde.Enter, dtpHasta.Enter
        dgvMovimientos.DataSource = Nothing
        txtBalance.Text = ""
        txtIngresos.Text = ""
        txtEgresos.Text = ""
        txtBalance.BackColor = Color.LightGray
    End Sub

    'Evento Click del Botón Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvMovimientos.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este movimiento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvMovimientos.SelectedCells(0).RowIndex
                    CargarMovimiento(fila)

                    Eliminar(_movimiento)

                    CargarDGV(cmbCuentas.SelectedValue, dtpDesde.Value, dtpHasta.Value)
                End If
            Else
                MessageBox.Show("No hay ninguna fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvMovimientos.SelectedCells.Count <> 0 Then
                Dim fila As Integer = dgvMovimientos.SelectedCells(0).RowIndex
                CargarMovimiento(fila)

                Dim frm As New frmAMMovimientos(_movimiento)
                frm.ShowDialog()

                CargarDGV(cmbCuentas.SelectedValue, dtpDesde.Value, dtpHasta.Value)

            Else
                MessageBox.Show("No hay ninguna fila seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmConsultaMovimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.B Then
            btnBuscar_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnEditar_Click(sender, e)
        ElseIf e.KeyCode = Keys.Delete Then
            btnEliminar_Click(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.E Then
            btnExportar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Exportar
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim frm As New frmExcel(Tag)
        frm.dgvExportar = dgvMovimientos
        frm.ShowDialog()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con los distintos movimientos.
    Private Sub CargarDGV(ByVal cuenta As Integer, ByVal fechaDesde As Date, ByVal fechaHasta As Date)
        Try
            Dim movimientos As List(Of EMovimiento) = _LNMovimiento.ObtenerPorCuentaYFecha(cuenta, fechaDesde, fechaHasta)

            dgvMovimientos.AutoGenerateColumns = False
            dgvMovimientos.DataSource = movimientos
            dgvMovimientos.Columns("idColumn").DataPropertyName = "ID"
            dgvMovimientos.Columns("fechaColumn").DataPropertyName = "Fecha"
            dgvMovimientos.Columns("tipoMovimientoColumn").DataPropertyName = "TipoMovimiento"
            dgvMovimientos.Columns("categoriaColumn").DataPropertyName = "Categoria"
            dgvMovimientos.Columns("nombreCategoriaColumn").DataPropertyName = "NombreCategoria"
            dgvMovimientos.Columns("subcategoriaColumn").DataPropertyName = "Subcategoria"
            dgvMovimientos.Columns("nombreSubcategoriaColumn").DataPropertyName = "NombreSubcategoria"
            dgvMovimientos.Columns("montoColumn").DataPropertyName = "Monto"
            dgvMovimientos.Columns("cuentaColumn").DataPropertyName = "Cuenta"
            dgvMovimientos.Columns("nombreCuentaColumn").DataPropertyName = "NombreCuenta"
            dgvMovimientos.Columns("descripcionColumn").DataPropertyName = "Descripcion"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas cuentas.
    Public Sub CargarComboCuentas()
        Try
            Dim cuentas As List(Of ECuenta) = _LNCuenta.ObtenerTodos()

            cmbCuentas.DataSource = cuentas
            cmbCuentas.DisplayMember = "Nombre"
            cmbCuentas.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar el movimiento seleccionado.
    Private Sub Eliminar(movimiento As EMovimiento)
        Try
            _LNMovimiento.Eliminar(movimiento)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Movimiento con los datos de la fila seleccionada.
    Private Sub CargarMovimiento(ByVal fila As Integer)
        _movimiento.ID = dgvMovimientos.Rows(fila).Cells(0).Value
        _movimiento.Fecha = dgvMovimientos.Rows(fila).Cells(1).Value
        _movimiento.TipoMovimiento = dgvMovimientos.Rows(fila).Cells(2).Value
        _movimiento.Categoria = dgvMovimientos.Rows(fila).Cells(3).Value
        _movimiento.NombreCategoria = dgvMovimientos.Rows(fila).Cells(4).Value
        _movimiento.Subcategoria = dgvMovimientos.Rows(fila).Cells(5).Value
        _movimiento.NombreSubcategoria = dgvMovimientos.Rows(fila).Cells(6).Value
        _movimiento.Monto = dgvMovimientos.Rows(fila).Cells(7).Value
        _movimiento.Cuenta = dgvMovimientos.Rows(fila).Cells(8).Value
        _movimiento.NombreCuenta = dgvMovimientos.Rows(fila).Cells(9).Value
        _movimiento.Descripcion = dgvMovimientos.Rows(fila).Cells(10).Value
    End Sub

End Class