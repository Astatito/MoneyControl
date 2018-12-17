<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonedas))
        Me.grpMoneda = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMoneda
        '
        Me.grpMoneda.Controls.Add(Me.txtDescripcion)
        Me.grpMoneda.Controls.Add(Me.txtCodigo)
        Me.grpMoneda.Controls.Add(Me.lblDescripcion)
        Me.grpMoneda.Controls.Add(Me.lblCodigo)
        Me.grpMoneda.Location = New System.Drawing.Point(5, 4)
        Me.grpMoneda.Name = "grpMoneda"
        Me.grpMoneda.Size = New System.Drawing.Size(238, 83)
        Me.grpMoneda.TabIndex = 0
        Me.grpMoneda.TabStop = False
        Me.grpMoneda.Text = "Moneda"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(72, 54)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(72, 26)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 57)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 18
        Me.lblDescripcion.Text = "Descripción"
        Me.toolTip.SetToolTip(Me.lblDescripcion, "Descripción (por ejemplo, Dólar).")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(26, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Código"
        Me.toolTip.SetToolTip(Me.lblCodigo, "Código de la moneda (por ejemplo, USD).")
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(83, 93)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 120)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grpMoneda.ResumeLayout(False)
        Me.grpMoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMoneda As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents btnGuardar As Button
End Class
