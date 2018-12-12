<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonedaPorDefecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonedaPorDefecto))
        Me.cmbMonedas = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpMonedaDefecto = New System.Windows.Forms.GroupBox()
        Me.grpMonedaDefecto.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbMonedas
        '
        Me.cmbMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonedas.FormattingEnabled = True
        Me.cmbMonedas.Location = New System.Drawing.Point(10, 19)
        Me.cmbMonedas.Name = "cmbMonedas"
        Me.cmbMonedas.Size = New System.Drawing.Size(238, 21)
        Me.cmbMonedas.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(90, 46)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        Me.toolTip.SetToolTip(Me.btnGuardar, "Registra la moneda seleccionada como favorita." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Atajo: Ctrl + G, Enter)")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'toolTip
        '
        Me.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.toolTip.ToolTipTitle = "Ayuda"
        '
        'grpMonedaDefecto
        '
        Me.grpMonedaDefecto.Controls.Add(Me.btnGuardar)
        Me.grpMonedaDefecto.Controls.Add(Me.cmbMonedas)
        Me.grpMonedaDefecto.Location = New System.Drawing.Point(2, 7)
        Me.grpMonedaDefecto.Name = "grpMonedaDefecto"
        Me.grpMonedaDefecto.Size = New System.Drawing.Size(254, 79)
        Me.grpMonedaDefecto.TabIndex = 2
        Me.grpMonedaDefecto.TabStop = False
        Me.grpMonedaDefecto.Text = "Moneda por defecto"
        '
        'frmMonedaPorDefecto
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 88)
        Me.Controls.Add(Me.grpMonedaDefecto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonedaPorDefecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración - Moneda por Defecto"
        Me.grpMonedaDefecto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbMonedas As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents grpMonedaDefecto As GroupBox
End Class
