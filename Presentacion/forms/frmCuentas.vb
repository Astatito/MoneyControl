Imports Entidades
Imports LogicaNegocio
Imports System.Threading
Imports System.Windows.Forms

Public Class frmCuentas
    Private _cuenta As New ECuenta() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNTipoCuenta As New LNTipoCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Me.Text = "Nuevo"

        _cuenta = New ECuenta()
    End Sub

    Public Sub New(ByVal cuenta As ECuenta)
        InitializeComponent()
        Me.Text = "Modificar"

        _cuenta = New ECuenta()
        _cuenta = cuenta
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thrM As New Thread(AddressOf CargarComboMonedas)
        thrM.Start()
        Dim thrTC As New Thread(AddressOf CargarComboTiposCuenta)
        thrTC.Start()

        Me.txtNombre.Text = _cuenta.Nombre
        Me.txtSaldo.Text = _cuenta.Saldo
        Me.txtDescripcion.Text = _cuenta.Descripcion
    End Sub

    'Evento KeyDown del Form
    Private Sub frmMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Actualizar()
        GrabarDatos()

        If _LNCuenta.sb.Length <> 0 Then
            MessageBox.Show(_LNCuenta.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    'Evento KeyPress del TextBox Saldo
    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        e.Handled = Not (IsNumeric(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar))
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Graba los datos ingresados en la base de datos
    Public Sub GrabarDatos()
        Try
            If _cuenta.ID = 0 Then
                _LNCuenta.Insertar(_cuenta)
            Else
                _LNCuenta.Actualizar(_cuenta)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Guarda los datos ingresados en la entidad correspondiente
    Public Sub Actualizar()
        _cuenta.Nombre = StrConv(Me.txtNombre.Text.ToString.Trim(), VbStrConv.ProperCase)
        _cuenta.TipoCuenta = Me.cmbTiposCuenta.SelectedValue
        _cuenta.Moneda = Me.cmbMonedas.SelectedValue
        _cuenta.Saldo = Convert.ToDouble(Me.txtSaldo.Text)
        _cuenta.Descripcion = Me.txtDescripcion.Text.ToString.Trim()
    End Sub

    'Cargar el ComboBox con las distintas monedas.
    Public Sub CargarComboMonedas()
        Try
            Dim monedas As List(Of EMoneda) = _LNMoneda.ObtenerTodos()

            Me.cmbMonedas.DataSource = monedas
            Me.cmbMonedas.DisplayMember = "Codigo"
            Me.cmbMonedas.ValueMember = "ID"

            Me.cmbMonedas.SelectedValue = _cuenta.Moneda
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con los distintos tipos de Cuenta.
    Public Sub CargarComboTiposCuenta()
        Try
            Dim tiposCuenta As List(Of ETipoCuenta) = _LNTipoCuenta.ObtenerTodos()

            Me.cmbTiposCuenta.DataSource = tiposCuenta
            Me.cmbTiposCuenta.DisplayMember = "Descripcion"
            Me.cmbTiposCuenta.ValueMember = "ID"

            Me.cmbTiposCuenta.SelectedValue = _cuenta.TipoCuenta
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class