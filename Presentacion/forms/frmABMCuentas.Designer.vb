<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMCuentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMCuentas))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.grpCuentas = New System.Windows.Forms.GroupBox()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCuentaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionTipoCuentaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monedaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoMonedaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCuentas.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.Location = New System.Drawing.Point(191, 196)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&Nuevo"
        Me.toolTip.SetToolTip(Me.btnNuevo, "Registrar una nueva cuenta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + N)")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'grpCuentas
        '
        Me.grpCuentas.Controls.Add(Me.dgvCuentas)
        Me.grpCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCuentas.Location = New System.Drawing.Point(12, 12)
        Me.grpCuentas.Name = "grpCuentas"
        Me.grpCuentas.Size = New System.Drawing.Size(447, 178)
        Me.grpCuentas.TabIndex = 7
        Me.grpCuentas.TabStop = False
        Me.grpCuentas.Text = "Cuentas"
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.nombreColumn, Me.tipoCuentaColumn, Me.descripcionTipoCuentaColumn, Me.monedaColumn, Me.codigoMonedaColumn, Me.saldoColumn, Me.descripcionColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCuentas.Location = New System.Drawing.Point(6, 19)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCuentas.Size = New System.Drawing.Size(435, 150)
        Me.dgvCuentas.TabIndex = 4
        '
        'idColumn
        '
        Me.idColumn.HeaderText = "ID"
        Me.idColumn.MaxInputLength = 10
        Me.idColumn.Name = "idColumn"
        Me.idColumn.ReadOnly = True
        Me.idColumn.Visible = False
        '
        'nombreColumn
        '
        Me.nombreColumn.HeaderText = "Nombre"
        Me.nombreColumn.MaxInputLength = 50
        Me.nombreColumn.Name = "nombreColumn"
        Me.nombreColumn.ReadOnly = True
        Me.nombreColumn.ToolTipText = "Nombre (por ejemplo, Billetera)."
        '
        'tipoCuentaColumn
        '
        Me.tipoCuentaColumn.HeaderText = "ID Tipo de Cuenta"
        Me.tipoCuentaColumn.MaxInputLength = 10
        Me.tipoCuentaColumn.Name = "tipoCuentaColumn"
        Me.tipoCuentaColumn.ReadOnly = True
        Me.tipoCuentaColumn.Visible = False
        '
        'descripcionTipoCuentaColumn
        '
        Me.descripcionTipoCuentaColumn.HeaderText = "Tipo de Cuenta"
        Me.descripcionTipoCuentaColumn.MaxInputLength = 50
        Me.descripcionTipoCuentaColumn.Name = "descripcionTipoCuentaColumn"
        Me.descripcionTipoCuentaColumn.ReadOnly = True
        Me.descripcionTipoCuentaColumn.ToolTipText = "Tipo de Cuenta (por ejemplo, Efectivo)."
        '
        'monedaColumn
        '
        Me.monedaColumn.HeaderText = "ID Moneda"
        Me.monedaColumn.MaxInputLength = 10
        Me.monedaColumn.Name = "monedaColumn"
        Me.monedaColumn.ReadOnly = True
        Me.monedaColumn.Visible = False
        '
        'codigoMonedaColumn
        '
        Me.codigoMonedaColumn.HeaderText = "Moneda"
        Me.codigoMonedaColumn.MaxInputLength = 5
        Me.codigoMonedaColumn.Name = "codigoMonedaColumn"
        Me.codigoMonedaColumn.ReadOnly = True
        Me.codigoMonedaColumn.ToolTipText = "Moneda o divisa en la que está expresado el saldo de la cuenta."
        '
        'saldoColumn
        '
        Me.saldoColumn.HeaderText = "Saldo"
        Me.saldoColumn.MaxInputLength = 20
        Me.saldoColumn.Name = "saldoColumn"
        Me.saldoColumn.ReadOnly = True
        Me.saldoColumn.ToolTipText = "Cantidad de dinero actual en la cuenta."
        '
        'descripcionColumn
        '
        Me.descripcionColumn.HeaderText = "Descripción"
        Me.descripcionColumn.MaxInputLength = 100
        Me.descripcionColumn.Name = "descripcionColumn"
        Me.descripcionColumn.ReadOnly = True
        Me.descripcionColumn.ToolTipText = "Información adicional acerca de la cuenta (CBU, Banco, Titular, etc.)."
        Me.descripcionColumn.Visible = False
        '
        'frmABMCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 222)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpCuentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración - Cuentas"
        Me.grpCuentas.ResumeLayout(False)
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolTip As ToolTip
    Friend WithEvents grpCuentas As GroupBox
    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents tipoCuentaColumn As DataGridViewTextBoxColumn
    Friend WithEvents descripcionTipoCuentaColumn As DataGridViewTextBoxColumn
    Friend WithEvents monedaColumn As DataGridViewTextBoxColumn
    Friend WithEvents codigoMonedaColumn As DataGridViewTextBoxColumn
    Friend WithEvents saldoColumn As DataGridViewTextBoxColumn
    Friend WithEvents descripcionColumn As DataGridViewTextBoxColumn
End Class
