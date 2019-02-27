<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.grpCategorias = New System.Windows.Forms.GroupBox()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.cmbIngresos = New System.Windows.Forms.ComboBox()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.cmbGastos = New System.Windows.Forms.ComboBox()
        Me.lblGastos = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grpRutaExcel = New System.Windows.Forms.GroupBox()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.fbDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.grpCategorias.SuspendLayout()
        Me.grpRutaExcel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCategorias
        '
        Me.grpCategorias.Controls.Add(Me.lblCategorias)
        Me.grpCategorias.Controls.Add(Me.cmbIngresos)
        Me.grpCategorias.Controls.Add(Me.lblIngresos)
        Me.grpCategorias.Controls.Add(Me.cmbGastos)
        Me.grpCategorias.Controls.Add(Me.lblGastos)
        Me.grpCategorias.Location = New System.Drawing.Point(12, 12)
        Me.grpCategorias.Name = "grpCategorias"
        Me.grpCategorias.Size = New System.Drawing.Size(484, 108)
        Me.grpCategorias.TabIndex = 0
        Me.grpCategorias.TabStop = False
        Me.grpCategorias.Text = "Categorías por defecto"
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Location = New System.Drawing.Point(17, 20)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(458, 39)
        Me.lblCategorias.TabIndex = 5
        Me.lblCategorias.Text = resources.GetString("lblCategorias.Text")
        '
        'cmbIngresos
        '
        Me.cmbIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIngresos.FormattingEnabled = True
        Me.cmbIngresos.Location = New System.Drawing.Point(316, 72)
        Me.cmbIngresos.Name = "cmbIngresos"
        Me.cmbIngresos.Size = New System.Drawing.Size(121, 21)
        Me.cmbIngresos.TabIndex = 4
        '
        'lblIngresos
        '
        Me.lblIngresos.AutoSize = True
        Me.lblIngresos.Location = New System.Drawing.Point(263, 75)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(47, 13)
        Me.lblIngresos.TabIndex = 3
        Me.lblIngresos.Text = "Ingresos"
        '
        'cmbGastos
        '
        Me.cmbGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGastos.FormattingEnabled = True
        Me.cmbGastos.Location = New System.Drawing.Point(87, 72)
        Me.cmbGastos.Name = "cmbGastos"
        Me.cmbGastos.Size = New System.Drawing.Size(121, 21)
        Me.cmbGastos.TabIndex = 2
        '
        'lblGastos
        '
        Me.lblGastos.AutoSize = True
        Me.lblGastos.Location = New System.Drawing.Point(41, 75)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(40, 13)
        Me.lblGastos.TabIndex = 1
        Me.lblGastos.Text = "Gastos"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(145, 275)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(241, 275)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grpRutaExcel
        '
        Me.grpRutaExcel.Controls.Add(Me.btnBuscar)
        Me.grpRutaExcel.Controls.Add(Me.txtRuta)
        Me.grpRutaExcel.Controls.Add(Me.lblRuta)
        Me.grpRutaExcel.Location = New System.Drawing.Point(12, 126)
        Me.grpRutaExcel.Name = "grpRutaExcel"
        Me.grpRutaExcel.Size = New System.Drawing.Size(484, 100)
        Me.grpRutaExcel.TabIndex = 3
        Me.grpRutaExcel.TabStop = False
        Me.grpRutaExcel.Text = "Ruta por defecto"
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(17, 21)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(411, 13)
        Me.lblRuta.TabIndex = 0
        Me.lblRuta.Text = "Esta es la ruta por defecto en la que se almacenarán los archivos exportados a Ex" &
    "cel."
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(447, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(6, 47)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(431, 20)
        Me.txtRuta.TabIndex = 5
        '
        'frmConfiguracion
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(503, 309)
        Me.Controls.Add(Me.grpRutaExcel)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grpCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuración"
        Me.grpCategorias.ResumeLayout(False)
        Me.grpCategorias.PerformLayout()
        Me.grpRutaExcel.ResumeLayout(False)
        Me.grpRutaExcel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCategorias As GroupBox
    Friend WithEvents cmbIngresos As ComboBox
    Friend WithEvents lblIngresos As Label
    Friend WithEvents cmbGastos As ComboBox
    Friend WithEvents lblGastos As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCategorias As Label
    Friend WithEvents grpRutaExcel As GroupBox
    Friend WithEvents lblRuta As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents fbDialog As FolderBrowserDialog
End Class
