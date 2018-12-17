<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentas))
        Me.grpCuenta = New System.Windows.Forms.GroupBox()
        Me.cmbMonedas = New System.Windows.Forms.ComboBox()
        Me.cmbTiposCuenta = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCuenta
        '
        Me.grpCuenta.Controls.Add(Me.cmbMonedas)
        Me.grpCuenta.Controls.Add(Me.cmbTiposCuenta)
        Me.grpCuenta.Controls.Add(Me.lblMoneda)
        Me.grpCuenta.Controls.Add(Me.txtSaldo)
        Me.grpCuenta.Controls.Add(Me.lblSaldo)
        Me.grpCuenta.Controls.Add(Me.lblTipoCuenta)
        Me.grpCuenta.Controls.Add(Me.txtDescripcion)
        Me.grpCuenta.Controls.Add(Me.txtNombre)
        Me.grpCuenta.Controls.Add(Me.lblDescripcion)
        Me.grpCuenta.Controls.Add(Me.lblNombre)
        Me.grpCuenta.Location = New System.Drawing.Point(6, 6)
        Me.grpCuenta.Name = "grpCuenta"
        Me.grpCuenta.Size = New System.Drawing.Size(275, 201)
        Me.grpCuenta.TabIndex = 1
        Me.grpCuenta.TabStop = False
        Me.grpCuenta.Text = "Cuenta"
        '
        'cmbMonedas
        '
        Me.cmbMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonedas.FormattingEnabled = True
        Me.cmbMonedas.Location = New System.Drawing.Point(93, 79)
        Me.cmbMonedas.Name = "cmbMonedas"
        Me.cmbMonedas.Size = New System.Drawing.Size(167, 21)
        Me.cmbMonedas.TabIndex = 3
        '
        'cmbTiposCuenta
        '
        Me.cmbTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTiposCuenta.FormattingEnabled = True
        Me.cmbTiposCuenta.Location = New System.Drawing.Point(93, 52)
        Me.cmbTiposCuenta.Name = "cmbTiposCuenta"
        Me.cmbTiposCuenta.Size = New System.Drawing.Size(167, 21)
        Me.cmbTiposCuenta.TabIndex = 2
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(40, 82)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 22
        Me.lblMoneda.Text = "Moneda"
        Me.toolTip.SetToolTip(Me.lblMoneda, "Moneda o divisa en la que está expresado el saldo de la cuenta.")
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(92, 106)
        Me.txtSaldo.MaxLength = 20
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(168, 20)
        Me.txtSaldo.TabIndex = 4
        Me.toolTip.SetToolTip(Me.txtSaldo, "Utilizar . (punto) como separador decimal.")
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(52, 109)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 21
        Me.lblSaldo.Text = "Saldo"
        Me.toolTip.SetToolTip(Me.lblSaldo, "Cantidad de dinero actual en la cuenta.")
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.Location = New System.Drawing.Point(6, 55)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoCuenta.TabIndex = 19
        Me.lblTipoCuenta.Text = "Tipo de Cuenta"
        Me.toolTip.SetToolTip(Me.lblTipoCuenta, "Tipo de Cuenta (por ejemplo, Efectivo).")
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(103, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 132)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(168, 64)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(93, 26)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 134)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 18
        Me.lblDescripcion.Text = "Descripción"
        Me.toolTip.SetToolTip(Me.lblDescripcion, "Información adicional acerca de la cuenta (CBU, Banco, Titular, etc.).")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(42, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "Nombre"
        Me.toolTip.SetToolTip(Me.lblNombre, "Nombre (por ejemplo, Billetera).")
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'frmCuentas
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 236)
        Me.Controls.Add(Me.grpCuenta)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grpCuenta.ResumeLayout(False)
        Me.grpCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCuenta As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents cmbMonedas As ComboBox
    Friend WithEvents cmbTiposCuenta As ComboBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblTipoCuenta As Label
End Class
