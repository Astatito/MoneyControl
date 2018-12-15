<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMTiposCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMTiposCuenta))
        Me.grpTiposCuenta = New System.Windows.Forms.GroupBox()
        Me.dgvTiposCuenta = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTiposCuenta.SuspendLayout()
        CType(Me.dgvTiposCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTiposCuenta
        '
        Me.grpTiposCuenta.Controls.Add(Me.dgvTiposCuenta)
        Me.grpTiposCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTiposCuenta.Location = New System.Drawing.Point(12, 12)
        Me.grpTiposCuenta.Name = "grpTiposCuenta"
        Me.grpTiposCuenta.Size = New System.Drawing.Size(215, 183)
        Me.grpTiposCuenta.TabIndex = 7
        Me.grpTiposCuenta.TabStop = False
        Me.grpTiposCuenta.Text = "Tipos de Cuenta"
        '
        'dgvTiposCuenta
        '
        Me.dgvTiposCuenta.AllowUserToAddRows = False
        Me.dgvTiposCuenta.AllowUserToDeleteRows = False
        Me.dgvTiposCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTiposCuenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTiposCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiposCuenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.descripcionColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTiposCuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTiposCuenta.Location = New System.Drawing.Point(6, 19)
        Me.dgvTiposCuenta.Name = "dgvTiposCuenta"
        Me.dgvTiposCuenta.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTiposCuenta.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTiposCuenta.RowHeadersVisible = False
        Me.dgvTiposCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTiposCuenta.Size = New System.Drawing.Size(203, 153)
        Me.dgvTiposCuenta.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(81, 201)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&Nuevo"
        Me.toolTip.SetToolTip(Me.btnNuevo, "Registrar un nuevo tipo de cuenta." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + N)")
        Me.btnNuevo.UseVisualStyleBackColor = True
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
        'descripcionColumn
        '
        Me.descripcionColumn.HeaderText = "Descripción"
        Me.descripcionColumn.MaxInputLength = 50
        Me.descripcionColumn.Name = "descripcionColumn"
        Me.descripcionColumn.ReadOnly = True
        Me.descripcionColumn.ToolTipText = "Descripción (por ejemplo, Efectivo)."
        '
        'frmABMTiposCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 232)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpTiposCuenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMTiposCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración - Tipos de Cuenta"
        Me.grpTiposCuenta.ResumeLayout(False)
        CType(Me.dgvTiposCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTiposCuenta As GroupBox
    Friend WithEvents dgvTiposCuenta As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents descripcionColumn As DataGridViewTextBoxColumn
End Class
