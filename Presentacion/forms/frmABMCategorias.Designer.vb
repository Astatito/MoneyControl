<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMCategorias))
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.grpCategorias = New System.Windows.Forms.GroupBox()
        Me.grpFiltro = New System.Windows.Forms.GroupBox()
        Me.rbEgreso = New System.Windows.Forms.RadioButton()
        Me.rbIngreso = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.dgvCategorias = New System.Windows.Forms.DataGridView()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoMovimientoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpCategorias.SuspendLayout()
        Me.grpFiltro.SuspendLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.Location = New System.Drawing.Point(157, 244)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'grpCategorias
        '
        Me.grpCategorias.Controls.Add(Me.grpFiltro)
        Me.grpCategorias.Controls.Add(Me.dgvCategorias)
        Me.grpCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCategorias.Location = New System.Drawing.Point(12, 12)
        Me.grpCategorias.Name = "grpCategorias"
        Me.grpCategorias.Size = New System.Drawing.Size(412, 229)
        Me.grpCategorias.TabIndex = 8
        Me.grpCategorias.TabStop = False
        Me.grpCategorias.Text = "Categorías"
        '
        'grpFiltro
        '
        Me.grpFiltro.Controls.Add(Me.rbEgreso)
        Me.grpFiltro.Controls.Add(Me.rbIngreso)
        Me.grpFiltro.Controls.Add(Me.rbTodas)
        Me.grpFiltro.Location = New System.Drawing.Point(31, 176)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(340, 47)
        Me.grpFiltro.TabIndex = 5
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Filtrar"
        '
        'rbEgreso
        '
        Me.rbEgreso.AutoSize = True
        Me.rbEgreso.Location = New System.Drawing.Point(221, 19)
        Me.rbEgreso.Name = "rbEgreso"
        Me.rbEgreso.Size = New System.Drawing.Size(58, 17)
        Me.rbEgreso.TabIndex = 3
        Me.rbEgreso.Text = "&Egreso"
        Me.toolTip.SetToolTip(Me.rbEgreso, "Mostrar sólo las categorías de Egreso." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + E)")
        Me.rbEgreso.UseVisualStyleBackColor = True
        '
        'rbIngreso
        '
        Me.rbIngreso.AutoSize = True
        Me.rbIngreso.Location = New System.Drawing.Point(122, 19)
        Me.rbIngreso.Name = "rbIngreso"
        Me.rbIngreso.Size = New System.Drawing.Size(60, 17)
        Me.rbIngreso.TabIndex = 2
        Me.rbIngreso.Text = "&Ingreso"
        Me.toolTip.SetToolTip(Me.rbIngreso, "Mostrar sólo las categorías de Ingreso." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + I)")
        Me.rbIngreso.UseVisualStyleBackColor = True
        '
        'rbTodas
        '
        Me.rbTodas.AutoSize = True
        Me.rbTodas.Location = New System.Drawing.Point(35, 19)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbTodas.TabIndex = 1
        Me.rbTodas.Text = "&Todas"
        Me.toolTip.SetToolTip(Me.rbTodas, "Mostrar todas las categorías." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + T)")
        Me.rbTodas.UseVisualStyleBackColor = True
        '
        'dgvCategorias
        '
        Me.dgvCategorias.AllowUserToAddRows = False
        Me.dgvCategorias.AllowUserToDeleteRows = False
        Me.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.nombreColumn, Me.tipoMovimientoColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategorias.Location = New System.Drawing.Point(6, 19)
        Me.dgvCategorias.Name = "dgvCategorias"
        Me.dgvCategorias.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCategorias.RowHeadersVisible = False
        Me.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCategorias.Size = New System.Drawing.Size(397, 150)
        Me.dgvCategorias.TabIndex = 4
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
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
        Me.nombreColumn.Name = "nombreColumn"
        Me.nombreColumn.ReadOnly = True
        Me.nombreColumn.ToolTipText = "Nombre (por ejemplo, Salario)."
        '
        'tipoMovimientoColumn
        '
        Me.tipoMovimientoColumn.FillWeight = 35.0!
        Me.tipoMovimientoColumn.HeaderText = "Tipo de Movimiento"
        Me.tipoMovimientoColumn.Name = "tipoMovimientoColumn"
        Me.tipoMovimientoColumn.ReadOnly = True
        Me.tipoMovimientoColumn.ToolTipText = "Tipo de movimiento (por ejemplo, Ingreso)."
        '
        'frmABMCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 272)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración - Categorías"
        Me.grpCategorias.ResumeLayout(False)
        Me.grpFiltro.ResumeLayout(False)
        Me.grpFiltro.PerformLayout()
        CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents grpCategorias As GroupBox
    Friend WithEvents dgvCategorias As DataGridView
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents grpFiltro As GroupBox
    Friend WithEvents rbEgreso As RadioButton
    Friend WithEvents rbIngreso As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents tipoMovimientoColumn As DataGridViewTextBoxColumn
End Class
