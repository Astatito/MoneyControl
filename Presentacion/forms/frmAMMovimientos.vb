Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmAMMovimientos
    Private _movimiento As New EMovimiento() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNMovimiento As New LNMovimiento() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNSubCategoria As New LNSubCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New(ByVal tipoMovimiento As String)
        InitializeComponent()

        Text = "Nuevo " + tipoMovimiento

        _movimiento = New EMovimiento()
        _movimiento.TipoMovimiento = tipoMovimiento
    End Sub

    Public Sub New(ByVal movimiento As EMovimiento)
        InitializeComponent()
        Text = "Modificar"

        _movimiento = New EMovimiento()
        _movimiento = movimiento
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thrCat As New Thread(AddressOf CargarComboCategorias)
        thrCat.Start()
        Dim thrCue As New Thread(AddressOf CargarComboCuentas)
        thrCue.Start()

        If Text = "Modificar" Then
            dtpFecha.Value = _movimiento.Fecha
            cmbCategorias.SelectedValue = _movimiento.Categoria
            If _movimiento.Subcategoria <> Nothing Then
                cmbSubCategorias.SelectedValue = _movimiento.Subcategoria
            End If
            txtMonto.Text = Format(_movimiento.Monto, "N2")
            cmbCuentas.SelectedValue = _movimiento.Cuenta
            txtDescripcion.Text = _movimiento.Descripcion
        End If

    End Sub

    'Evento SelectionChangeCommited del ComboBox de Categorías
    Private Sub cmbCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategorias.SelectionChangeCommitted
        cmbSubCategorias.DataSource = Nothing
        CargarComboSubCategorias(cmbCategorias.SelectedValue)
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not IsNumeric(txtMonto.Text) Then
            MessageBox.Show("El monto ingresado no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim old_movimiento As New EMovimiento()
        old_movimiento.ID = _movimiento.ID
        old_movimiento.Fecha = _movimiento.Fecha
        old_movimiento.Categoria = _movimiento.Categoria
        old_movimiento.Subcategoria = _movimiento.Subcategoria
        old_movimiento.Monto = _movimiento.Monto
        old_movimiento.Cuenta = _movimiento.Cuenta
        old_movimiento.Descripcion = _movimiento.Descripcion

        Actualizar()
        GrabarDatos(old_movimiento)

        If _LNMovimiento.sb.Length <> 0 Then
            MessageBox.Show(_LNMovimiento.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Close()
        End If
    End Sub

    'Evento Leave del TextBox Monto
    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        If IsNumeric(txtMonto.Text) Then
            txtMonto.Text = Format(Convert.ToDouble(txtMonto.Text), "N2")
        End If
    End Sub

    'Evento KeyDown del Form
    Private Sub frmAMMovimientos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.G Then
            btnGuardar_Click(sender, e)
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos(ByVal old_movimiento As EMovimiento)
        Try
            If _movimiento.ID = 0 Then
                _LNMovimiento.Insertar(_movimiento)
            Else
                _LNMovimiento.Actualizar(old_movimiento, _movimiento)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Movimiento según los datos del formulario.
    Public Sub Actualizar()
        _movimiento.Fecha = dtpFecha.Value
        _movimiento.Categoria = cmbCategorias.SelectedValue
        _movimiento.SubCategoria = cmbSubCategorias.SelectedValue
        If _movimiento.TipoMovimiento = "Ingreso" Then
            _movimiento.Monto = Convert.ToDouble(txtMonto.Text)
        Else
            _movimiento.Monto = Convert.ToDouble("-" + txtMonto.Text)
        End If
        _movimiento.Cuenta = cmbCuentas.SelectedValue
        _movimiento.Descripcion = txtDescripcion.Text.ToString.Trim()
    End Sub

    'Cargar el ComboBox con las distintas categorías.
    Public Sub CargarComboCategorias()
        Try
            Dim categorias As List(Of ECategoria) = Nothing

            If _movimiento.TipoMovimiento = "Ingreso" Then
                categorias = _LNCategoria.ObtenerIngresos()
            ElseIf _movimiento.TipoMovimiento = "Gasto" Then
                categorias = _LNCategoria.ObtenerGastos()
            End If

            cmbCategorias.DataSource = categorias
            cmbCategorias.DisplayMember = "Nombre"
            cmbCategorias.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas subcategorías.
    Public Sub CargarComboSubCategorias(ByVal categoria As Integer)
        Try
            Dim subCategorias As List(Of ESubCategoria) = _LNSubCategoria.ObtenerPorCategoria(categoria)

            If subCategorias.Count = 0 Then
                cmbSubCategorias.Enabled = False
            Else
                cmbSubCategorias.Enabled = True
                cmbSubCategorias.DataSource = subCategorias
                cmbSubCategorias.DisplayMember = "Nombre"
                cmbSubCategorias.ValueMember = "ID"
            End If

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas cuentas.
    Public Sub CargarComboCuentas()
        Try
            Dim cuentas As List(Of ECuenta) = _LNCuenta.ObtenerTodos()

            cmbCuentas.DataSource = cuentas
            cmbCuentas.DisplayMember = "Nombre"
            cmbCuentas.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class