<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMSubCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMSubCategorias))
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.grpSubCategorias = New System.Windows.Forms.GroupBox()
        Me.grpFiltro = New System.Windows.Forms.GroupBox()
        Me.rbSeleccion = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.grpSeleccion = New System.Windows.Forms.GroupBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cmbTiposMovimiento = New System.Windows.Forms.ComboBox()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.dgvSubCategorias = New System.Windows.Forms.DataGridView()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCategoriaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSubCategorias.SuspendLayout()
        Me.grpFiltro.SuspendLayout()
        Me.grpSeleccion.SuspendLayout()
        CType(Me.dgvSubCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.Location = New System.Drawing.Point(497, 31)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        Me.toolTip.SetToolTip(Me.btnNuevo, "Registrar una nueva subcategoría." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + N)")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'grpSubCategorias
        '
        Me.grpSubCategorias.Controls.Add(Me.grpFiltro)
        Me.grpSubCategorias.Controls.Add(Me.dgvSubCategorias)
        Me.grpSubCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSubCategorias.Location = New System.Drawing.Point(12, 12)
        Me.grpSubCategorias.Name = "grpSubCategorias"
        Me.grpSubCategorias.Size = New System.Drawing.Size(447, 271)
        Me.grpSubCategorias.TabIndex = 9
        Me.grpSubCategorias.TabStop = False
        Me.grpSubCategorias.Text = "Subcategorías"
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.rbSeleccion)
        Me.grpFiltro.Controls.Add(Me.rbTodas)
        Me.grpFiltro.Controls.Add(Me.grpSeleccion)
        Me.grpFiltro.Location = New System.Drawing.Point(25, 173)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(399, 92)
        Me.grpFiltro.TabIndex = 6
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Filtrar"
        '
        'rbSeleccion
        '
        Me.rbSeleccion.AutoSize = True
        Me.rbSeleccion.Location = New System.Drawing.Point(54, 53)
        Me.rbSeleccion.Name = "rbSeleccion"
        Me.rbSeleccion.Size = New System.Drawing.Size(72, 17)
        Me.rbSeleccion.TabIndex = 6
        Me.rbSeleccion.Text = "&Selección"
        Me.toolTip.SetToolTip(Me.rbSeleccion, "Mostrar las subcategorías de la categoría seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + S)")
        Me.rbSeleccion.UseVisualStyleBackColor = True
        '
        'rbTodas
        '
        Me.rbTodas.AutoSize = True
        Me.rbTodas.Location = New System.Drawing.Point(54, 28)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbTodas.TabIndex = 5
        Me.rbTodas.Text = "&Todas"
        Me.toolTip.SetToolTip(Me.rbTodas, "Mostrar todas las subcategorías." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + T)")
        Me.rbTodas.UseVisualStyleBackColor = True
        '
        'grpSeleccion
        '
        Me.grpSeleccion.Controls.Add(Me.lblCategoria)
        Me.grpSeleccion.Controls.Add(Me.lblTipo)
        Me.grpSeleccion.Controls.Add(Me.cmbTiposMovimiento)
        Me.grpSeleccion.Controls.Add(Me.cmbCategorias)
        Me.grpSeleccion.Enabled = False
        Me.grpSeleccion.Location = New System.Drawing.Point(173, 12)
        Me.grpSeleccion.Name = "grpSeleccion"
        Me.grpSeleccion.Size = New System.Drawing.Size(200, 69)
        Me.grpSeleccion.TabIndex = 11
        Me.grpSeleccion.TabStop = False
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(6, 43)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(57, 13)
        Me.lblCategoria.TabIndex = 18
        Me.lblCategoria.Text = "Categoría:"
        Me.toolTip.SetToolTip(Me.lblCategoria, "Categorías del tipo de movimiento seleccionado (por ejemplo, Salario).")
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(19, 16)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 17
        Me.lblTipo.Text = "Tipo:"
        Me.toolTip.SetToolTip(Me.lblTipo, "Tipo de movimiento (por ejemplo, Ingreso).")
        '
        'cmbTiposMovimiento
        '
        Me.cmbTiposMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTiposMovimiento.FormattingEnabled = True
        Me.cmbTiposMovimiento.Location = New System.Drawing.Point(67, 15)
        Me.cmbTiposMovimiento.Name = "cmbTiposMovimiento"
        Me.cmbTiposMovimiento.Size = New System.Drawing.Size(124, 21)
        Me.cmbTiposMovimiento.TabIndex = 7
        '
        'cmbCategorias
        '
        Me.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(67, 40)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(124, 21)
        Me.cmbCategorias.TabIndex = 8
        '
        'dgvSubCategorias
        '
        Me.dgvSubCategorias.AllowUserToAddRows = False
        Me.dgvSubCategorias.AllowUserToDeleteRows = False
        Me.dgvSubCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.nombreColumn, Me.categoriaColumn, Me.nombreCategoriaColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubCategorias.Location = New System.Drawing.Point(6, 19)
        Me.dgvSubCategorias.Name = "dgvSubCategorias"
        Me.dgvSubCategorias.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubCategorias.RowHeadersVisible = False
        Me.dgvSubCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvSubCategorias.Size = New System.Drawing.Size(435, 150)
        Me.dgvSubCategorias.TabIndex = 9
        Me.dgvSubCategorias.TabStop = False
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.Location = New System.Drawing.Point(497, 89)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "E&liminar"
        Me.toolTip.SetToolTip(Me.btnEliminar, "Eliminar la subcategoría seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Supr)")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(497, 60)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "E&ditar"
        Me.toolTip.SetToolTip(Me.btnEditar, "Modificar la subcategoría seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + D)")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(497, 118)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "&Exportar"
        Me.toolTip.SetToolTip(Me.btnExportar, "Exportar datos a Excel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + E)")
        Me.btnExportar.UseVisualStyleBackColor = True
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
        Me.nombreColumn.FillWeight = 150.0!
        Me.nombreColumn.HeaderText = "Nombre"
        Me.nombreColumn.MaxInputLength = 50
        Me.nombreColumn.Name = "nombreColumn"
        Me.nombreColumn.ReadOnly = True
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
        'frmABMSubCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 289)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpSubCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMSubCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Subcategorías"
        Me.Text = "Configuración - Subcategorías"
        Me.grpSubCategorias.ResumeLayout(False)
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        Me.grpSeleccion.ResumeLayout(False)
        Me.grpSeleccion.PerformLayout()
        CType(Me.dgvSubCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents grpSubCategorias As GroupBox
    Friend WithEvents dgvSubCategorias As DataGridView
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents grpFiltro As GroupBox
    Friend WithEvents rbSeleccion As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents grpSeleccion As GroupBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents cmbTiposMovimiento As ComboBox
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents categoriaColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreCategoriaColumn As DataGridViewTextBoxColumn
End Class
