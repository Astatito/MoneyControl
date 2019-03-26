Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmABMUsuarios

    Private _usuario As New EUsuario() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNUsuario As New LNUsuario() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmABMUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim form As New frmUsuarios()
        form.ShowDialog()

        CargarDGV()
    End Sub

    'Evento Click del Botón Editar
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgvUsuarios.SelectedCells.Count <> 0 Then
                CargarUsuario(dgvUsuarios.SelectedCells(0).RowIndex)

                Dim form As New frmUsuarios(_usuario)
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
            If dgvUsuarios.SelectedCells.Count <> 0 Then
                If MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If dgvUsuarios.Rows.Count() <= 1 Then
                        MessageBox.Show("No se puede eliminar; debe existir al menos un usuario en la base de datos. Por favor, cree un nuevo usuario e intente nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    Dim fila As Integer = dgvUsuarios.SelectedCells(0).RowIndex
                    Dim idUsuario As Integer = dgvUsuarios.Rows(fila).Cells(0).Value
                    Eliminar(idUsuario)
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
        frm.dgvExportar = dgvUsuarios
        frm.ShowDialog()
    End Sub

    'Evento KeyDown del Form
    Private Sub frmABMUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    'Cargar el DataGridView con los distintos usuarios.
    Private Sub CargarDGV()
        Try
            Dim usuarios As List(Of EUsuario) = _LNUsuario.ObtenerTodos()

            dgvUsuarios.AutoGenerateColumns = False
            dgvUsuarios.DataSource = usuarios
            dgvUsuarios.Columns("idColumn").DataPropertyName = "ID"
            dgvUsuarios.Columns("usuarioColumn").DataPropertyName = "Usuario"
            dgvUsuarios.Columns("passwordColumn").DataPropertyName = "Password"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Eliminar el usuario seleccionado.
    Private Sub Eliminar(idUsuario As Integer)
        Try
            _LNUsuario.Eliminar(idUsuario)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el objeto Cuenta con los datos de la fila seleccionada.
    Private Sub CargarUsuario(ByVal fila As Integer)
        _usuario.ID = dgvUsuarios.Rows(fila).Cells(0).Value
        _usuario.Usuario = dgvUsuarios.Rows(fila).Cells(1).Value
        _usuario.Password = dgvUsuarios.Rows(fila).Cells(2).Value
    End Sub

End Class