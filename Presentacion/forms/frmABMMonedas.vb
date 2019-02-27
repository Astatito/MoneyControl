Imports Entidades
Imports LogicaNegocio
Imports System.Threading

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
            Dim thr As New Thread(AddressOf cargarDGV)
            thr.Start()

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        End If
    End Sub

    'Evento Click del Botón Nuevo
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim form As New frmMonedas()
        form.ShowDialog()

        CargarDGV()
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvMonedas.SelectedCells.Count <> 0 Then
                CargarMoneda(dgvMonedas.SelectedCells(0).RowIndex)

                Dim form As New frmMonedas(_moneda)
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
            If dgvMonedas.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar esta moneda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim fila As Integer = dgvMonedas.SelectedCells(0).RowIndex
                    Dim idMoneda As Integer = dgvMonedas.Rows(fila).Cells(0).Value

                    If _LNMoneda.SePuedeEliminar(idMoneda) Then
                        Eliminar(idMoneda)
                        CargarDGV()
                    Else
                        MessageBox.Show(_LNMoneda.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
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
        frm.dgvExportar = dgvMonedas
        frm.ShowDialog()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Cargar el DataGridView con las distintas monedas.
    Private Sub CargarDGV()
        Try
            Dim monedas As List(Of EMoneda) = _LNMoneda.ObtenerTodos()

            dgvMonedas.AutoGenerateColumns = False
            dgvMonedas.DataSource = monedas
            dgvMonedas.Columns("idColumn").DataPropertyName = "ID"
            dgvMonedas.Columns("codigoColumn").DataPropertyName = "Codigo"
            dgvMonedas.Columns("descripcionColumn").DataPropertyName = "Descripcion"
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

    'Setear el objeto Moneda con los datos de la fila seleccionada.
    Private Sub CargarMoneda(ByVal fila As Integer)
        _moneda.ID = dgvMonedas.Rows(fila).Cells(0).Value
        _moneda.Codigo = dgvMonedas.Rows(fila).Cells(1).Value
        _moneda.Descripcion = dgvMonedas.Rows(fila).Cells(2).Value
    End Sub

End Class
