Imports Entidades
Imports LogicaNegocio
Imports System.Threading

Public Class frmMovimientos
    Private _movimiento As New EMovimiento() 'Objeto perteneciente a la capa de Entidades
    Private ReadOnly _LNMovimiento As New LNMovimiento() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCategoria As New LNCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNSubCategoria As New LNSubCategoria() 'Objeto perteneciente a la capa de Lógica de Negocio.
    Private ReadOnly _LNCuenta As New LNCuenta() 'Objeto perteneciente a la capa de Lógica de Negocio.

    'Creación de una nueva instancia del formulario 
    Public Sub New(ByVal tipoMovimiento As String)
        InitializeComponent()

        Me.Text = "Nuevo " + tipoMovimiento

        _movimiento = New EMovimiento()
        _movimiento.TipoMovimiento = tipoMovimiento
    End Sub

    '                                   ____EVENTOS____

    'Evento Load del Form
    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thrCat As New Thread(AddressOf CargarComboCategorias)
        thrCat.Start()
        Dim thrCue As New Thread(AddressOf CargarComboCuentas)
        thrCue.Start()
    End Sub

    'Evento SelectionChangeCommited del ComboBox de Categorías
    Private Sub cmbCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategorias.SelectionChangeCommitted
        cmbSubCategorias.DataSource = Nothing
        CargarComboSubCategorias(cmbCategorias.SelectedValue)
    End Sub

    'Evento Click del Botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not EsNumero(Me.txtMonto.Text) Then
            MessageBox.Show("El monto ingresado no es válido.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Actualizar()
        GrabarDatos()

        If _LNMovimiento.sb.Length <> 0 Then
            MessageBox.Show(_LNMovimiento.sb.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    '                               ____FUNCIONES/RUTINAS____

    'Grabar los datos ingresados en la base de datos.
    Public Sub GrabarDatos()
        Try
            If _movimiento.ID = 0 Then
                _LNMovimiento.Insertar(_movimiento)
                'Else
                '   _LNMovimiento.Actualizar(_cuenta)
            End If
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Setear el objeto Movimiento según los datos del formulario.
    Public Sub Actualizar()
        _movimiento.Fecha = FormatearFechaSQLite(Me.dtpFecha.Value)
        _movimiento.Categoria = Me.cmbCategorias.SelectedValue
        _movimiento.SubCategoria = Me.cmbSubCategorias.SelectedValue
        If _movimiento.TipoMovimiento = "Ingreso" Then
            _movimiento.Monto = Convert.ToDouble(Me.txtMonto.Text)
        Else
            _movimiento.Monto = Convert.ToDouble("-" + Me.txtMonto.Text)
        End If
        _movimiento.Cuenta = Me.cmbCuentas.SelectedValue
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

            Me.cmbCategorias.DataSource = categorias
            Me.cmbCategorias.DisplayMember = "Nombre"
            Me.cmbCategorias.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas subcategorías.
    Public Sub CargarComboSubCategorias(ByVal categoria As Integer)
        Try
            Dim subCategorias As List(Of ESubCategoria) = _LNSubCategoria.ObtenerPorCategoria(categoria)

            If subCategorias.Count = 0 Then
                Me.cmbSubCategorias.Enabled = False
            Else
                Me.cmbSubCategorias.Enabled = True
                Me.cmbSubCategorias.DataSource = subCategorias
                Me.cmbSubCategorias.DisplayMember = "Nombre"
                Me.cmbSubCategorias.ValueMember = "ID"
            End If

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cargar el ComboBox con las distintas cuentas.
    Public Sub CargarComboCuentas()
        Try
            Dim cuentas As List(Of ECuenta) = _LNCuenta.ObtenerTodos()

            Me.cmbCuentas.DataSource = cuentas
            Me.cmbCuentas.DisplayMember = "Nombre"
            Me.cmbCuentas.ValueMember = "ID"

        Catch ex As Exception
            MessageBox.Show("Error inesperado: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class