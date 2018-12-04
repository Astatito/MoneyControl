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
        Me.SuspendLayout()
        '
        'btnABMMonedas
        '
        Me.btnABMMonedas.Location = New System.Drawing.Point(58, 68)
        Me.btnABMMonedas.Name = "btnABMMonedas"
        Me.btnABMMonedas.Size = New System.Drawing.Size(117, 23)
        Me.btnABMMonedas.TabIndex = 0
        Me.btnABMMonedas.Text = "ABM Monedas"
        Me.btnABMMonedas.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 345)
        Me.Controls.Add(Me.btnABMMonedas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.Text = "MoneyControl v1.0"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnABMMonedas As Button
End Class
