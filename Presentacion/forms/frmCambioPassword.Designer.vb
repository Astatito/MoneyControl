<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambioPassword))
        Me.grpCambioPass = New System.Windows.Forms.GroupBox()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblNueva = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.lblRepetir = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCambioPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCambioPass
        '
        Me.grpCambioPass.Controls.Add(Me.txtNueva)
        Me.grpCambioPass.Controls.Add(Me.lblPass)
        Me.grpCambioPass.Controls.Add(Me.lblNueva)
        Me.grpCambioPass.Controls.Add(Me.txtPass)
        Me.grpCambioPass.Controls.Add(Me.txtRepetir)
        Me.grpCambioPass.Controls.Add(Me.lblRepetir)
        Me.grpCambioPass.Location = New System.Drawing.Point(12, 12)
        Me.grpCambioPass.Name = "grpCambioPass"
        Me.grpCambioPass.Size = New System.Drawing.Size(299, 100)
        Me.grpCambioPass.TabIndex = 0
        Me.grpCambioPass.TabStop = False
        Me.grpCambioPass.Text = "Contraseña"
        '
        'txtNueva
        '
        Me.txtNueva.Location = New System.Drawing.Point(120, 45)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.Size = New System.Drawing.Size(166, 20)
        Me.txtNueva.TabIndex = 2
        Me.txtNueva.UseSystemPasswordChar = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(21, 22)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(93, 13)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Contraseña actual"
        Me.toolTip.SetToolTip(Me.lblPass, "Contraseña actual del usuario.")
        '
        'lblNueva
        '
        Me.lblNueva.AutoSize = True
        Me.lblNueva.Location = New System.Drawing.Point(21, 48)
        Me.lblNueva.Name = "lblNueva"
        Me.lblNueva.Size = New System.Drawing.Size(95, 13)
        Me.lblNueva.TabIndex = 10
        Me.lblNueva.Text = "Nueva contraseña"
        Me.toolTip.SetToolTip(Me.lblNueva, "Nueva contraseña (máx. 20 caracteres).")
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(120, 19)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(166, 20)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtRepetir
        '
        Me.txtRepetir.Location = New System.Drawing.Point(120, 71)
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.Size = New System.Drawing.Size(166, 20)
        Me.txtRepetir.TabIndex = 3
        Me.txtRepetir.UseSystemPasswordChar = True
        '
        'lblRepetir
        '
        Me.lblRepetir.AutoSize = True
        Me.lblRepetir.Location = New System.Drawing.Point(21, 74)
        Me.lblRepetir.Name = "lblRepetir"
        Me.lblRepetir.Size = New System.Drawing.Size(97, 13)
        Me.lblRepetir.TabIndex = 8
        Me.lblRepetir.Text = "Repetir contraseña"
        Me.toolTip.SetToolTip(Me.lblRepetir, "Repetir nueva contraseña (máx. 20 caracteres).")
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Location = New System.Drawing.Point(118, 118)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'frmCambioPassword
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 144)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpCambioPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioPassword"
        Me.Text = "Configuración - Modificar contraseña"
        Me.grpCambioPass.ResumeLayout(False)
        Me.grpCambioPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCambioPass As GroupBox
    Friend WithEvents txtNueva As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblNueva As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtRepetir As TextBox
    Friend WithEvents lblRepetir As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents toolTip As ToolTip
End Class
