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
            Dim thr As New Thread(AddressOf CargarDGV)
            thr.Start()

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

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvCuentas.SelectedCells.Count <> 0 Then
                CargarCuenta(dgvCuentas.SelectedCells(0).RowIndex)

                Dim form As New frmCuentas(_cuenta)
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
            If dgvCuentas.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar esta cuenta? También se eliminarán todos los movimientos y las transferencias asociados a esta cuenta.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvCuentas.SelectedCells(0).RowIndex
                    Dim idCuenta As Integer = dgvCuentas.Rows(fila).Cells(0).Value
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
        frm.dgvExportar = dgvCuentas
        frm.ShowDialog()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMCuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNuevo_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnEditar_Click(sender, e)
        ElseIf e.KeyCode = Keys.Delete Then
            btnEliminar_Click(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.E Then
            btnExportar_Click(sender, e)
        End If
    End Sub


    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas cuentas.
    Private Sub CargarDGV()
        Try
            Dim cuentas As List(Of ECuenta) = _LNCuenta.ObtenerTodosFull()

            dgvCuentas.AutoGenerateColumns = False
            dgvCuentas.DataSource = cuentas
            dgvCuentas.Columns("idColumn").DataPropertyName = "ID"
            dgvCuentas.Columns("nombreColumn").DataPropertyName = "Nombre"
            dgvCuentas.Columns("tipoCuentaColumn").DataPropertyName = "TipoCuenta"
            dgvCuentas.Columns("descripcionTipoCuentaColumn").DataPropertyName = "DescripcionTipoCuenta"
            dgvCuentas.Columns("monedaColumn").DataPropertyName = "Moneda"
            dgvCuentas.Columns("codigoMonedaColumn").DataPropertyName = "CodigoMoneda"
            dgvCuentas.Columns("saldoColumn").DataPropertyName = "Saldo"
            dgvCuentas.Columns("descripcionColumn").DataPropertyName = "Descripcion"

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
        _cuenta.ID = dgvCuentas.Rows(fila).Cells(0).Value
        _cuenta.Nombre = dgvCuentas.Rows(fila).Cells(1).Value
        _cuenta.TipoCuenta = dgvCuentas.Rows(fila).Cells(2).Value
        _cuenta.DescripcionTipoCuenta = dgvCuentas.Rows(fila).Cells(3).Value
        _cuenta.Moneda = dgvCuentas.Rows(fila).Cells(4).Value
        _cuenta.CodigoMoneda = dgvCuentas.Rows(fila).Cells(5).Value
        _cuenta.Saldo = dgvCuentas.Rows(fila).Cells(6).Value
        _cuenta.Descripcion = dgvCuentas.Rows(fila).Cells(7).Value
    End Sub

End Class