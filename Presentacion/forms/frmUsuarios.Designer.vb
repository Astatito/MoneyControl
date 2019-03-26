<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.grpUsuario = New System.Windows.Forms.GroupBox()
        Me.btnCambioPass = New System.Windows.Forms.Button()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.lblRepetir = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUsuario
        '
        Me.grpUsuario.Controls.Add(Me.btnCambioPass)
        Me.grpUsuario.Controls.Add(Me.txtRepetir)
        Me.grpUsuario.Controls.Add(Me.lblRepetir)
        Me.grpUsuario.Controls.Add(Me.txtPassword)
        Me.grpUsuario.Controls.Add(Me.lblPassword)
        Me.grpUsuario.Controls.Add(Me.txtUsuario)
        Me.grpUsuario.Controls.Add(Me.lblUsuario)
        Me.grpUsuario.Location = New System.Drawing.Point(5, 5)
        Me.grpUsuario.Name = "grpUsuario"
        Me.grpUsuario.Size = New System.Drawing.Size(253, 109)
        Me.grpUsuario.TabIndex = 2
        Me.grpUsuario.TabStop = False
        Me.grpUsuario.Text = "Usuario"
        '
        'btnCambioPass
        '
        Me.btnCambioPass.Location = New System.Drawing.Point(7, 46)
        Me.btnCambioPass.Name = "btnCambioPass"
        Me.btnCambioPass.Size = New System.Drawing.Size(239, 23)
        Me.btnCambioPass.TabIndex = 24
        Me.btnCambioPass.Text = "&Modificar contraseña"
        Me.toolTip.SetToolTip(Me.btnCambioPass, "Cambiar la contraseña del usuario." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + M)")
        Me.btnCambioPass.UseVisualStyleBackColor = True
        '
        'txtRepetir
        '
        Me.txtRepetir.Location = New System.Drawing.Point(77, 78)
        Me.txtRepetir.MaxLength = 20
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.Size = New System.Drawing.Size(168, 20)
        Me.txtRepetir.TabIndex = 22
        Me.toolTip.SetToolTip(Me.txtRepetir, "Máximo 20 caracteres.")
        Me.txtRepetir.UseSystemPasswordChar = True
        '
        'lblRepetir
        '
        Me.lblRepetir.AutoSize = True
        Me.lblRepetir.Location = New System.Drawing.Point(8, 75)
        Me.lblRepetir.Name = "lblRepetir"
        Me.lblRepetir.Size = New System.Drawing.Size(60, 26)
        Me.lblRepetir.TabIndex = 23
        Me.lblRepetir.Text = "Repetir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña"
        Me.toolTip.SetToolTip(Me.lblRepetir, "Ingresar nuevamente la contraseña.")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(77, 48)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(168, 20)
        Me.txtPassword.TabIndex = 4
        Me.toolTip.SetToolTip(Me.txtPassword, "Contraseña (máx. 20 caracteres).")
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(8, 51)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 21
        Me.lblPassword.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(77, 22)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(26, 25)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 17
        Me.lblUsuario.Text = "Usuario"
        Me.toolTip.SetToolTip(Me.lblUsuario, "Nombre de usuario (máx. 20 caracteres).")
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Location = New System.Drawing.Point(86, 116)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Graba los datos y vuelve a la ventana anterior." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'frmUsuarios
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 143)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.grpUsuario.ResumeLayout(False)
        Me.grpUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUsuario As GroupBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents txtRepetir As TextBox
    Friend WithEvents lblRepetir As Label
    Friend WithEvents btnCambioPass As Button
End Class
