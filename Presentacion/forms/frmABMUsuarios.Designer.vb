<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMUsuarios))
        Me.grpUsuarios = New System.Windows.Forms.GroupBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passwordColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpUsuarios.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUsuarios
        '
        Me.grpUsuarios.Controls.Add(Me.dgvUsuarios)
        Me.grpUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.grpUsuarios.Name = "grpUsuarios"
        Me.grpUsuarios.Size = New System.Drawing.Size(160, 212)
        Me.grpUsuarios.TabIndex = 8
        Me.grpUsuarios.TabStop = False
        Me.grpUsuarios.Text = "Usuarios"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.usuarioColumn, Me.passwordColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 19)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(143, 187)
        Me.dgvUsuarios.TabIndex = 5
        Me.dgvUsuarios.TabStop = False
        '
        'idColumn
        '
        Me.idColumn.HeaderText = "ID"
        Me.idColumn.MaxInputLength = 10
        Me.idColumn.Name = "idColumn"
        Me.idColumn.ReadOnly = True
        Me.idColumn.Visible = False
        '
        'usuarioColumn
        '
        Me.usuarioColumn.HeaderText = "Usuario"
        Me.usuarioColumn.MaxInputLength = 20
        Me.usuarioColumn.Name = "usuarioColumn"
        Me.usuarioColumn.ReadOnly = True
        '
        'passwordColumn
        '
        Me.passwordColumn.HeaderText = "Password"
        Me.passwordColumn.MaxInputLength = 100
        Me.passwordColumn.Name = "passwordColumn"
        Me.passwordColumn.ReadOnly = True
        Me.passwordColumn.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.Location = New System.Drawing.Point(188, 89)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.toolTip.SetToolTip(Me.btnEliminar, "Eliminar la cuenta seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Supr)")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(188, 60)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "E&ditar"
        Me.toolTip.SetToolTip(Me.btnEditar, "Modificar la cuenta seleccionada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + D)")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(188, 118)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "&Exportar"
        Me.toolTip.SetToolTip(Me.btnExportar, "Exportar datos a Excel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + E)")
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.Location = New System.Drawing.Point(188, 31)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "&Nuevo"
        Me.toolTip.SetToolTip(Me.btnNuevo, "Agregar una nueva cuenta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + N)")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'frmABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 229)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.grpUsuarios)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnExportar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Usuarios"
        Me.Text = "Configuración - Usuarios"
        Me.grpUsuarios.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUsuarios As GroupBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents usuarioColumn As DataGridViewTextBoxColumn
    Friend WithEvents passwordColumn As DataGridViewTextBoxColumn
    Friend WithEvents toolTip As ToolTip
End Class
