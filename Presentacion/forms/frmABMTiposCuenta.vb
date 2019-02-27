Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmABMTiposCuenta

    Private _tipoCuenta As New ETipoCuenta() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNTipoCuenta As New LNTipoCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMTiposCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForIllegalCrossThreadCalls = False
            Dim thr As New Thread(AddressOf cargarDGV)
            thr.Start()

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmTiposCuenta()
        form.ShowDialog()

        cargarDGV()
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvTiposCuenta.SelectedCells.Count <> 0 Then
                CargarTipoCuenta(dgvTiposCuenta.SelectedCells(0).RowIndex)

                Dim form As New frmTiposCuenta(_tipoCuenta)
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
            If dgvTiposCuenta.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este tipo de cuenta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvTiposCuenta.SelectedCells(0).RowIndex
                    Dim idTipoCuenta As Integer = dgvTiposCuenta.Rows(fila).Cells(0).Value

                    If _LNTipoCuenta.SePuedeEliminar(idTipoCuenta) Then
                        Eliminar(idTipoCuenta)
                    Else
                        MessageBox.Show(_LNTipoCuenta.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

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
        frm.dgvExportar = dgvTiposCuenta
        frm.ShowDialog()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMTiposCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    'Cargar el DataGridView con los distintos tipos de cuenta.
    Private Sub CargarDGV()
        Try
            Dim tiposCuenta As List(Of ETipoCuenta) = _LNTipoCuenta.ObtenerTodos()

            dgvTiposCuenta.AutoGenerateColumns = False
            dgvTiposCuenta.DataSource = tiposCuenta
            dgvTiposCuenta.Columns("idColumn").DataPropertyName = "ID"
            dgvTiposCuenta.Columns("descripcionColumn").DataPropertyName = "Descripcion"
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Elimina el tipo de cuenta seleccionado.
    Private Sub Eliminar(idTipoCuenta As Integer)
        Try
            _LNTipoCuenta.Eliminar(idTipoCuenta)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto TipoCuenta con los datos de la fila seleccionada
    Private Sub CargarTipoCuenta(ByVal fila As Integer)
        _tipoCuenta.Id = dgvTiposCuenta.Rows(fila).Cells(0).Value
        _tipoCuenta.Descripcion = dgvTiposCuenta.Rows(fila).Cells(1).Value
    End Sub

End Class