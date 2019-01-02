<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiposCuenta))
        Me.grpMoneda = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMoneda
        '
        Me.grpMoneda.Controls.Add(Me.txtDescripcion)
        Me.grpMoneda.Controls.Add(Me.lblNombre)
        Me.grpMoneda.Location = New System.Drawing.Point(10, 11)
        Me.grpMoneda.Name = "grpMoneda"
        Me.grpMoneda.Size = New System.Drawing.Size(266, 48)
        Me.grpMoneda.TabIndex = 1
        Me.grpMoneda.TabStop = False
        Me.grpMoneda.Text = "Tipo de Cuenta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(77, 19)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(180, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(8, 22)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Descripción"
        Me.toolTip.SetToolTip(Me.lblNombre, "Descripción (por ejemplo, Efectivo).")
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(97, 65)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmTiposCuenta
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 91)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTiposCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grpMoneda.ResumeLayout(False)
        Me.grpMoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMoneda As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents btnGuardar As Button
End Class
