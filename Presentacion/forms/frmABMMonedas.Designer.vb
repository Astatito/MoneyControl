<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMMonedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMMonedas))
        Me.grpMonedas = New System.Windows.Forms.GroupBox()
        Me.dgvMonedas = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpMonedas.SuspendLayout()
        CType(Me.dgvMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMonedas
        '
        Me.grpMonedas.Controls.Add(Me.dgvMonedas)
        Me.grpMonedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMonedas.Location = New System.Drawing.Point(12, 12)
        Me.grpMonedas.Name = "grpMonedas"
        Me.grpMonedas.Size = New System.Drawing.Size(412, 178)
        Me.grpMonedas.TabIndex = 6
        Me.grpMonedas.TabStop = False
        Me.grpMonedas.Text = "Monedas"
        '
        'dgvMonedas
        '
        Me.dgvMonedas.AllowUserToAddRows = False
        Me.dgvMonedas.AllowUserToDeleteRows = False
        Me.dgvMonedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonedas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonedas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.codigoColumn, Me.descripcionColumn})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonedas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMonedas.Location = New System.Drawing.Point(6, 19)
        Me.dgvMonedas.Name = "dgvMonedas"
        Me.dgvMonedas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonedas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvMonedas.RowHeadersVisible = False
        Me.dgvMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMonedas.Size = New System.Drawing.Size(397, 150)
        Me.dgvMonedas.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNuevo.Location = New System.Drawing.Point(170, 196)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.toolTip.SetToolTip(Me.btnNuevo, "Registrar una nueva moneda." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + N)")
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
        'codigoColumn
        '
        Me.codigoColumn.FillWeight = 25.0!
        Me.codigoColumn.HeaderText = "Código"
        Me.codigoColumn.MaxInputLength = 5
        Me.codigoColumn.Name = "codigoColumn"
        Me.codigoColumn.ReadOnly = True
        Me.codigoColumn.ToolTipText = "Código de la moneda (por ejemplo, USD)."
        '
        'descripcionColumn
        '
        Me.descripcionColumn.HeaderText = "Descripción"
        Me.descripcionColumn.MaxInputLength = 50
        Me.descripcionColumn.Name = "descripcionColumn"
        Me.descripcionColumn.ReadOnly = True
        Me.descripcionColumn.ToolTipText = "Descripción (por ejemplo, Dólar)."
        '
        'frmABMMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 227)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpMonedas)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMMonedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración - Monedas"
        Me.grpMonedas.ResumeLayout(False)
        CType(Me.dgvMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMonedas As GroupBox
    Friend WithEvents dgvMonedas As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents codigoColumn As DataGridViewTextBoxColumn
    Friend WithEvents descripcionColumn As DataGridViewTextBoxColumn
End Class
