Imports Entidades
Imports LogicaNegocio

Public Class frmCambioPassword

    Private _usuario As New EUsuario() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNUsuario As New LNUsuario() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New(ByVal usuario As EUsuario)
        InitializeComponent()

        _usuario = New EUsuario()
        _usuario = usuario

    End Sub

    '                                   ____EVENTOS____

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If SHA1Hash(txtPass.Text) = _usuario.Password Then
                If txtNueva.Text = txtRepetir.Text Then

                    Dim frmPadre As frmUsuarios = CType(Owner, frmUsuarios)
                    frmPadre.SetPassword(SHA1Hash(txtNueva.Text))

                    Close()
                Else
                    MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("La contraseña actual ingresada es incorrecta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Evento KeyDown del Form
    Private Sub frmCambioPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

End Class