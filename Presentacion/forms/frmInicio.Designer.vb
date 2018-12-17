<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnABMMonedas = New System.Windows.Forms.Button()
        Me.btnABMTiposCuenta = New System.Windows.Forms.Button()
        Me.btnMonedaPorDefecto = New System.Windows.Forms.Button()
        Me.btnABMCuentas = New System.Windows.Forms.Button()
        Me.btnABMCategorias = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnABMMonedas
        '
        Me.btnABMMonedas.Location = New System.Drawing.Point(12, 12)
        Me.btnABMMonedas.Name = "btnABMMonedas"
        Me.btnABMMonedas.Size = New System.Drawing.Size(117, 40)
        Me.btnABMMonedas.TabIndex = 0
        Me.btnABMMonedas.Text = "ABM Monedas"
        Me.btnABMMonedas.UseVisualStyleBackColor = True
        '
        'btnABMTiposCuenta
        '
        Me.btnABMTiposCuenta.Location = New System.Drawing.Point(12, 58)
        Me.btnABMTiposCuenta.Name = "btnABMTiposCuenta"
        Me.btnABMTiposCuenta.Size = New System.Drawing.Size(117, 40)
        Me.btnABMTiposCuenta.TabIndex = 1
        Me.btnABMTiposCuenta.Text = "ABM Tipos de Cuenta"
        Me.btnABMTiposCuenta.UseVisualStyleBackColor = True
        '
        'btnMonedaPorDefecto
        '
        Me.btnMonedaPorDefecto.Location = New System.Drawing.Point(12, 104)
        Me.btnMonedaPorDefecto.Name = "btnMonedaPorDefecto"
        Me.btnMonedaPorDefecto.Size = New System.Drawing.Size(117, 40)
        Me.btnMonedaPorDefecto.TabIndex = 2
        Me.btnMonedaPorDefecto.Text = "Moneda por Defecto"
        Me.btnMonedaPorDefecto.UseVisualStyleBackColor = True
        '
        'btnABMCuentas
        '
        Me.btnABMCuentas.Location = New System.Drawing.Point(12, 150)
        Me.btnABMCuentas.Name = "btnABMCuentas"
        Me.btnABMCuentas.Size = New System.Drawing.Size(117, 40)
        Me.btnABMCuentas.TabIndex = 3
        Me.btnABMCuentas.Text = "ABM Cuentas"
        Me.btnABMCuentas.UseVisualStyleBackColor = True
        '
        'btnABMCategorias
        '
        Me.btnABMCategorias.Location = New System.Drawing.Point(12, 196)
        Me.btnABMCategorias.Name = "btnABMCategorias"
        Me.btnABMCategorias.Size = New System.Drawing.Size(117, 40)
        Me.btnABMCategorias.TabIndex = 4
        Me.btnABMCategorias.Text = "ABM Categorias"
        Me.btnABMCategorias.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 345)
        Me.Controls.Add(Me.btnABMCategorias)
        Me.Controls.Add(Me.btnABMCuentas)
        Me.Controls.Add(Me.btnMonedaPorDefecto)
        Me.Controls.Add(Me.btnABMTiposCuenta)
        Me.Controls.Add(Me.btnABMMonedas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.Text = "MoneyControl v1.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnABMMonedas As Button
    Friend WithEvents btnABMTiposCuenta As Button
    Friend WithEvents btnMonedaPorDefecto As Button
    Friend WithEvents btnABMCuentas As Button
    Friend WithEvents btnABMCategorias As Button
End Class
