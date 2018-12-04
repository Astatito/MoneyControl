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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMMonedas))
        Me.grpMonedas = New System.Windows.Forms.GroupBox()
        Me.dgvMonedas = New System.Windows.Forms.DataGridView()
        Me.idColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paisColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.favoritoColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonedas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonedas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idColumn, Me.paisColumn, Me.codigoColumn, Me.nombreColumn, Me.favoritoColumn})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMonedas.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvMonedas.Location = New System.Drawing.Point(6, 19)
        Me.dgvMonedas.Name = "dgvMonedas"
        Me.dgvMonedas.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMonedas.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvMonedas.RowHeadersVisible = False
        Me.dgvMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvMonedas.Size = New System.Drawing.Size(397, 150)
        Me.dgvMonedas.TabIndex = 4
        '
        'idColumn
        '
        Me.idColumn.HeaderText = "ID"
        Me.idColumn.MaxInputLength = 10
        Me.idColumn.Name = "idColumn"
        Me.idColumn.ReadOnly = True
        Me.idColumn.Visible = False
        '
        'paisColumn
        '
        Me.paisColumn.HeaderText = "País"
        Me.paisColumn.MaxInputLength = 50
        Me.paisColumn.Name = "paisColumn"
        Me.paisColumn.ReadOnly = True
        '
        'codigoColumn
        '
        Me.codigoColumn.HeaderText = "Código"
        Me.codigoColumn.MaxInputLength = 5
        Me.codigoColumn.Name = "codigoColumn"
        Me.codigoColumn.ReadOnly = True
        '
        'nombreColumn
        '
        Me.nombreColumn.HeaderText = "Nombre"
        Me.nombreColumn.MaxInputLength = 50
        Me.nombreColumn.Name = "nombreColumn"
        Me.nombreColumn.ReadOnly = True
        '
        'favoritoColumn
        '
        Me.favoritoColumn.HeaderText = "Favorito"
        Me.favoritoColumn.Name = "favoritoColumn"
        Me.favoritoColumn.ReadOnly = True
        Me.favoritoColumn.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(184, 196)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmABMMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 227)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.grpMonedas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMMonedas"
        Me.Text = "Configuración - Monedas"
        Me.grpMonedas.ResumeLayout(False)
        CType(Me.dgvMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMonedas As GroupBox
    Friend WithEvents dgvMonedas As DataGridView
    Friend WithEvents idColumn As DataGridViewTextBoxColumn
    Friend WithEvents paisColumn As DataGridViewTextBoxColumn
    Friend WithEvents codigoColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents favoritoColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btnNuevo As Button
End Class
