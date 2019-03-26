Imports Entidades
Imports LogicaNegocio

Public Class frmLogin

    Private _usuario As New EUsuario() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNUsuario As New LNUsuario() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()

        _usuario = New EUsuario()
    End Sub

    '                                   ____EVENTOS____

    'Evento TextChanged del TextBox Usuario
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.Text = UCase(txtUsuario.Text)
        txtUsuario.SelectionStart = txtUsuario.TextLength + 1
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Cursor.Current = Cursors.WaitCursor

        Actualizar()

        If _LNUsuario.ValidarUsuarioPassword(_usuario.Usuario, _usuario.Password) = True Then
            Dim form As New frmInicio
            form.Show()
            Me.Close()
        Else
            MessageBox.Show("El usuario y/o la contraseña ingresados no son correctos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Setear el objeto Usuario según los datos del formulario.
    Public Sub Actualizar()
        _usuario.Usuario = txtUsuario.Text
        _usuario.Password = SHA1Hash(txtPassword.Text)
    End Sub

End Class