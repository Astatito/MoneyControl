<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaMovimientos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaMovimientos))
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoMovimientoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCategoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcategoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreSubcategoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCuentaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpFiltro = New System.Windows.Forms.GroupBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.cmbCuentas = New System.Windows.Forms.ComboBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.lblEgresos = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtIngresos = New System.Windows.Forms.TextBox()
        Me.txtEgresos = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.fechaColumn, Me.tipoMovimientoColumn, Me.categoriaColumn, Me.nombreCategoriaColumn, Me.subcategoriaColumn, Me.nombreSubcategoriaColumn, Me.montoColumn, Me.cuentaColumn, Me.nombreCuentaColumn, Me.descripcionColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovimientos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMovimientos.Location = New System.Drawing.Point(12, 99)
        Me.dgvMovimientos.MultiSelect = False
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(534, 246)
        Me.dgvMovimientos.TabIndex = 8
        Me.dgvMovimientos.TabStop = False
        '
        'idColumn
        '
        Me.idColumn.HeaderText = "ID"
        Me.idColumn.MaxInputLength = 10
        Me.idColumn.Name = "idColumn"
        Me.idColumn.ReadOnly = True
        Me.idColumn.Visible = False
        '
        'fechaColumn
        '
        Me.fechaColumn.HeaderText = "Fecha"
        Me.fechaColumn.Name = "fechaColumn"
        Me.fechaColumn.ReadOnly = True
        '
        'tipoMovimientoColumn
        '
        Me.tipoMovimientoColumn.HeaderText = "Tipo de Movimiento"
        Me.tipoMovimientoColumn.Name = "tipoMovimientoColumn"
        Me.tipoMovimientoColumn.ReadOnly = True
        '
        'categoriaColumn
        '
        Me.categoriaColumn.HeaderText = "ID Categoría"
        Me.categoriaColumn.Name = "categoriaColumn"
        Me.categoriaColumn.ReadOnly = True
        Me.categoriaColumn.Visible = False
        '
        'nombreCategoriaColumn
        '
        Me.nombreCategoriaColumn.HeaderText = "Categoría"
        Me.nombreCategoriaColumn.Name = "nombreCategoriaColumn"
        Me.nombreCategoriaColumn.ReadOnly = True
        '
        'subcategoriaColumn
        '
        Me.subcategoriaColumn.HeaderText = "ID Subcategoría"
        Me.subcategoriaColumn.Name = "subcategoriaColumn"
        Me.subcategoriaColumn.ReadOnly = True
        Me.subcategoriaColumn.Visible = False
        '
        'nombreSubcategoriaColumn
        '
        Me.nombreSubcategoriaColumn.HeaderText = "Subcategoría"
        Me.nombreSubcategoriaColumn.Name = "nombreSubcategoriaColumn"
        Me.nombreSubcategoriaColumn.ReadOnly = True
        '
        'montoColumn
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.montoColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.montoColumn.HeaderText = "Monto"
        Me.montoColumn.Name = "montoColumn"
        Me.montoColumn.ReadOnly = True
        '
        'cuentaColumn
        '
        Me.cuentaColumn.HeaderText = "ID Cuenta"
        Me.cuentaColumn.Name = "cuentaColumn"
        Me.cuentaColumn.ReadOnly = True
        Me.cuentaColumn.Visible = False
        '
        'nombreCuentaColumn
        '
        Me.nombreCuentaColumn.HeaderText = "Cuenta"
        Me.nombreCuentaColumn.Name = "nombreCuentaColumn"
        Me.nombreCuentaColumn.ReadOnly = True
        '
        'descripcionColumn
        '
        Me.descripcionColumn.HeaderText = "Descripción"
        Me.descripcionColumn.Name = "descripcionColumn"
        Me.descripcionColumn.ReadOnly = True
        Me.descripcionColumn.Visible = False
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.lblDesde)
        Me.grpFiltro.Controls.Add(Me.lblHasta)
        Me.grpFiltro.Controls.Add(Me.btnBuscar)
        Me.grpFiltro.Controls.Add(Me.dtpHasta)
        Me.grpFiltro.Controls.Add(Me.dtpDesde)
        Me.grpFiltro.Controls.Add(Me.cmbCuentas)
        Me.grpFiltro.Controls.Add(Me.lblCuenta)
        Me.grpFiltro.Location = New System.Drawing.Point(12, 12)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(621, 65)
        Me.grpFiltro.TabIndex = 7
        Me.grpFiltro.TabStop = False
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(191, 16)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 6
        Me.lblDesde.Text = "Desde:"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(354, 16)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 5
        Me.lblHasta.Text = "Hasta:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(540, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "&Buscar"
        Me.toolTip.SetToolTip(Me.btnBuscar, "Buscar todos los movimientos de la cuenta seleccionada entre dos fechas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo:" &
        " Ctrl + B, Enter)")
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(357, 33)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(118, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(194, 33)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(118, 20)
        Me.dtpDesde.TabIndex = 2
        '
        'cmbCuentas
        '
        Me.cmbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentas.FormattingEnabled = True
        Me.cmbCuentas.Location = New System.Drawing.Point(9, 32)
        Me.cmbCuentas.Name = "cmbCuentas"
        Me.cmbCuentas.Size = New System.Drawing.Size(121, 21)
        Me.cmbCuentas.TabIndex = 1
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(6, 16)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "Cuenta"
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.Location = New System.Drawing.Point(558, 128)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "E&liminar"
        Me.toolTip.SetToolTip(Me.btnEliminar, "Eliminar el movimiento seleccionado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Supr)")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(558, 99)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "E&ditar"
        Me.toolTip.SetToolTip(Me.btnEditar, "Modificar el movimiento seleccionado." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + D)")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(558, 157)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "&Exportar"
        Me.toolTip.SetToolTip(Me.btnExportar, "Exportar datos a Excel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + E)")
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'lblIngresos
        '
        Me.lblIngresos.AutoSize = True
        Me.lblIngresos.Location = New System.Drawing.Point(22, 359)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(47, 13)
        Me.lblIngresos.TabIndex = 9
        Me.lblIngresos.Text = "Ingresos"
        '
        'lblEgresos
        '
        Me.lblEgresos.AutoSize = True
        Me.lblEgresos.Location = New System.Drawing.Point(157, 359)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(45, 13)
        Me.lblEgresos.TabIndex = 10
        Me.lblEgresos.Text = "Egresos"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(294, 359)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(46, 13)
        Me.lblBalance.TabIndex = 11
        Me.lblBalance.Text = "Balance"
        '
        'txtIngresos
        '
        Me.txtIngresos.BackColor = System.Drawing.Color.LightGray
        Me.txtIngresos.Enabled = False
        Me.txtIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIngresos.Location = New System.Drawing.Point(21, 375)
        Me.txtIngresos.Name = "txtIngresos"
        Me.txtIngresos.Size = New System.Drawing.Size(100, 21)
        Me.txtIngresos.TabIndex = 12
        '
        'txtEgresos
        '
        Me.txtEgresos.BackColor = System.Drawing.Color.LightGray
        Me.txtEgresos.Enabled = False
        Me.txtEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtEgresos.Location = New System.Drawing.Point(160, 375)
        Me.txtEgresos.Name = "txtEgresos"
        Me.txtEgresos.Size = New System.Drawing.Size(100, 21)
        Me.txtEgresos.TabIndex = 13
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.LightGray
        Me.txtBalance.Enabled = False
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBalance.Location = New System.Drawing.Point(297, 375)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 21)
        Me.txtBalance.TabIndex = 14
        '
        'frmConsultaMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 404)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtEgresos)
        Me.Controls.Add(Me.txtIngresos)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblEgresos)
        Me.Controls.Add(Me.lblIngresos)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.grpFiltro)
        Me.Controls.Add(Me.dgvMovimientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmConsultaMovimientos"
        Me.Tag = "Movimientos"
        Me.Text = "Consultar movimientos"
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents grpFiltro As GroupBox
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents cmbCuentas As ComboBox
    Friend WithEvents lblCuenta As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaColumn As DataGridViewTextBoxColumn
    Friend WithEvents tipoMovimientoColumn As DataGridViewTextBoxColumn
    Friend WithEvents categoriaColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoriaColumn As DataGridViewTextBoxColumn
    Friend WithEvents subcategoriaColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreSubcategoriaColumn As DataGridViewTextBoxColumn
    Friend WithEvents montoColumn As DataGridViewTextBoxColumn
    Friend WithEvents cuentaColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCuentaColumn As DataGridViewTextBoxColumn
    Friend WithEvents descripcionColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As Button
    Friend WithEvents lblIngresos As Label
    Friend WithEvents lblEgresos As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtIngresos As TextBox
    Friend WithEvents txtEgresos As TextBox
    Friend WithEvents txtBalance As TextBox
End Class
