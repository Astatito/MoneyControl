Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmCuentas

    Private _cuenta As New ECuenta() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNTipoCuenta As New LNTipoCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNMoneda As New LNMoneda() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario
    Public Sub New()
        InitializeComponent()
        Text = "Nuevo"

        _cuenta = New ECuenta()
    End Sub

    Public Sub New(ByVal cuenta As ECuenta)
        InitializeComponent()
        Text = "Modificar"

        _cuenta = New ECuenta()
        _cuenta = cuenta
        txtSaldo.Enabled = False
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thrM As New Thread(AddressOf CargarComboMonedas)
        thrM.Start()
        Dim thrTC As New Thread(AddressOf CargarComboTiposCuenta)
        thrTC.Start()

        txtNombre.Text = _cuenta.Nombre
        txtSaldo.Text = Format(_cuenta.Saldo, "N2")
        txtDescripcion.Text = _cuenta.Descripcion
    End Sub

    'Evento KeyDown del Form
    Private Sub frmMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not IsNumeric(txtSaldo.Text) Then
            MessageBox.Show("El saldo ingresado no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Actualizar()
        GrabarDatos()

        If _LNCuenta.sb.Length <> 0 Then
            MessageBox.Show(_LNCuenta.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Close()
        End If
    End Sub

    'Evento Leave del TextBox Saldo
    Private Sub txtSaldo_Leave(sender As Object, e As EventArgs) Handles txtSaldo.Leave
        If IsNumeric(txtSaldo.Text) Then
            txtSaldo.Text = Format(Convert.ToDouble(txtSaldo.Text), "N2")
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
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

    'Setear el objeto Cuenta según los datos del formulario.
    Public Sub Actualizar()
        _cuenta.Nombre = txtNombre.Text.ToString.Trim()
        _cuenta.TipoCuenta = cmbTiposCuenta.SelectedValue
        _cuenta.Moneda = cmbMonedas.SelectedValue
        _cuenta.Saldo = Convert.ToDouble(txtSaldo.Text)
        _cuenta.Descripcion = txtDescripcion.Text.ToString.Trim()
    End Sub

    'Cargar el ComboBox con las distintas monedas.
    Public Sub CargarComboMonedas()
        Try
            Dim monedas As List(Of EMoneda) = _LNMoneda.ObtenerTodos()

            cmbMonedas.DataSource = monedas
            cmbMonedas.DisplayMember = "Codigo"
            cmbMonedas.ValueMember = "ID"

            cmbMonedas.SelectedValue = _cuenta.Moneda
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con los distintos tipos de cuenta.
    Public Sub CargarComboTiposCuenta()
        Try
            Dim tiposCuenta As List(Of ETipoCuenta) = _LNTipoCuenta.ObtenerTodos()

            cmbTiposCuenta.DataSource = tiposCuenta
            cmbTiposCuenta.DisplayMember = "Descripcion"
            cmbTiposCuenta.ValueMember = "ID"

            cmbTiposCuenta.SelectedValue = _cuenta.TipoCuenta
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class