Imports Entidades
Imports LogicaNegocio

Public Class frmUsuarios

    Private _usuario As New EUsuario() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNUsuario As New LNUsuario() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Text = "Nuevo"

        _usuario = New EUsuario()
        btnCambioPass.Visible = False
    End Sub

    Public Sub New(ByVal usuario As EUsuario)
        InitializeComponent()
        Text = "Modificar"

        _usuario = New EUsuario()
        _usuario = usuario

        lblPassword.Visible = False
        txtPassword.Visible = False
        lblRepetir.Visible = False
        txtRepetir.Visible = False

        grpUsuario.Size = New Size(grpUsuario.Size.Width, 77)
        Me.Size = New Size(Me.Size.Width, 154)
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = _usuario.Usuario
    End Sub

    'Evento TextChanged del TextBox Usuario
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        txtUsuario.Text = UCase(txtUsuario.Text)
        txtUsuario.SelectionStart = txtUsuario.TextLength + 1
    End Sub

    'Evento KeyDown del Form
    Private Sub frmUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.M AndAlso btnCambioPass.Visible = True Then
            btnCambioPass_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Actualizar()

        If _usuario.ID = 0 AndAlso _usuario.Password <> SHA1Hash(txtRepetir.Text) Then
            MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        GrabarDatos()

        If _LNUsuario.sb.Length <> 0 Then
            MessageBox.Show(_LNUsuario.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Close()
        End If
    End Sub

    'Evento Click del Botón CambioPass
    Private Sub btnCambioPass_Click(sender As Object, e As EventArgs) Handles btnCambioPass.Click
        Dim form As New frmCambioPassword(_usuario)
        AddOwnedForm(form)
        form.ShowDialog()

        GrabarDatos()
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos()
        Try
            If _usuario.ID = 0 Then
                _LNUsuario.Insertar(_usuario)
            Else
                _LNUsuario.Actualizar(_usuario)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Usuario según los datos del formulario.
    Public Sub Actualizar()
        _usuario.Usuario = txtUsuario.Text
        If _usuario.ID = 0 Then
            _usuario.Password = SHA1Hash(txtPassword.Text)
        End If
    End Sub

    'Setear contraseña en el objeto Usuario
    Public Sub SetPassword(ByVal password As String)
        _usuario.Password = password
    End Sub

End Class