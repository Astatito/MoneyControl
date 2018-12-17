Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmTiposCuenta


    Private _tipoCuenta As ETipoCuenta 'Objeto perteneciente a la capa de Entidades.
    Private ReadOnly _LNTipoCuenta As New LNTipoCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Me.Text = "Nuevo"

        _tipoCuenta = New ETipoCuenta()
    End Sub

    Public Sub New(ByVal tipoCuenta As ETipoCuenta)
        InitializeComponent()
        Me.Text = "Modificar"

        _tipoCuenta = New ETipoCuenta()
        _tipoCuenta = tipoCuenta
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmTiposCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDescripcion.Text = _tipoCuenta.Descripcion
    End Sub

    'Evento KeyDown del Form
    Private Sub frmTiposCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        Actualizar()
        GrabarDatos()

        If _LNTipoCuenta.sb.Length <> 0 Then
            MessageBox.Show(_LNTipoCuenta.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Graba los datos ingresados en la base de datos
    Public Sub GrabarDatos()
        Try
            If _tipoCuenta.Id = 0 Then
                _LNTipoCuenta.Insertar(_tipoCuenta)
            Else
                _LNTipoCuenta.Actualizar(_tipoCuenta)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Guarda los datos ingresados en la entidad correspondiente
    Public Sub Actualizar()
        _tipoCuenta.Descripcion = StrConv(Me.txtDescripcion.Text.ToString.Trim(), VbStrConv.ProperCase)
    End Sub

End Class