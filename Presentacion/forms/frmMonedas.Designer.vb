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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMoneda
        '
        Me.grpMoneda.Controls.Add(Me.btnGuardar)
        Me.grpMoneda.Controls.Add(Me.txtNombre)
        Me.grpMoneda.Controls.Add(Me.txtCodigo)
        Me.grpMoneda.Controls.Add(Me.txtPais)
        Me.grpMoneda.Controls.Add(Me.lblNombre)
        Me.grpMoneda.Controls.Add(Me.lblCodigo)
        Me.grpMoneda.Controls.Add(Me.lblPais)
        Me.grpMoneda.Location = New System.Drawing.Point(5, 4)
        Me.grpMoneda.Name = "grpMoneda"
        Me.grpMoneda.Size = New System.Drawing.Size(206, 134)
        Me.grpMoneda.TabIndex = 0
        Me.grpMoneda.TabStop = False
        Me.grpMoneda.Text = "Moneda"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(72, 102)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior.")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(61, 70)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(61, 44)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(61, 18)
        Me.txtPais.MaxLength = 50
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(142, 20)
        Me.txtPais.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(11, 73)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        Me.toolTip.SetToolTip(Me.lblNombre, "Nombre o descripción (por ejemplo, Dólar).")
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(15, 47)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Código"
        Me.toolTip.SetToolTip(Me.lblCodigo, "Código de la moneda (por ejemplo, ARS o USS).")
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(26, 21)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(29, 13)
        Me.lblPais.TabIndex = 16
        Me.lblPais.Text = "País"
        Me.toolTip.SetToolTip(Me.lblPais, "País o Región de la moneda.")
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'frmMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 139)
        Me.Controls.Add(Me.grpMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonedas"
        Me.grpMoneda.ResumeLayout(False)
        Me.grpMoneda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMoneda As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents toolTip As ToolTip
End Class
