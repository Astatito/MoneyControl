<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategorias))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpCategoria = New System.Windows.Forms.GroupBox()
        Me.cmbTiposMovimiento = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.grpCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(31, 55)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 19
        Me.lblTipo.Text = "Tipo"
        Me.toolTip.SetToolTip(Me.lblTipo, "Tipo de movimiento (por ejemplo, Ingreso).")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(15, 33)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "Nombre"
        Me.toolTip.SetToolTip(Me.lblNombre, "Nombre (por ejemplo, Salario).")
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(101, 93)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grpCategoria
        '
        Me.grpCategoria.Controls.Add(Me.cmbTiposMovimiento)
        Me.grpCategoria.Controls.Add(Me.lblTipo)
        Me.grpCategoria.Controls.Add(Me.txtNombre)
        Me.grpCategoria.Controls.Add(Me.lblNombre)
        Me.grpCategoria.Location = New System.Drawing.Point(6, 4)
        Me.grpCategoria.Name = "grpCategoria"
        Me.grpCategoria.Size = New System.Drawing.Size(275, 83)
        Me.grpCategoria.TabIndex = 7
        Me.grpCategoria.TabStop = False
        Me.grpCategoria.Text = "Categoría"
        '
        'cmbTiposMovimiento
        '
        Me.cmbTiposMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTiposMovimiento.FormattingEnabled = True
        Me.cmbTiposMovimiento.Location = New System.Drawing.Point(75, 52)
        Me.cmbTiposMovimiento.Name = "cmbTiposMovimiento"
        Me.cmbTiposMovimiento.Size = New System.Drawing.Size(167, 21)
        Me.cmbTiposMovimiento.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 26)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 20)
        Me.txtNombre.TabIndex = 1
        '
        'frmCategorias
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 120)
        Me.Controls.Add(Me.grpCategoria)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grpCategoria.ResumeLayout(False)
        Me.grpCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toolTip As ToolTip
    Friend WithEvents grpCategoria As GroupBox
    Friend WithEvents cmbTiposMovimiento As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnGuardar As Button
End Class
