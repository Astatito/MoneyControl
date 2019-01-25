Public Class frmInicio
    Private Sub btnABMMonedas_Click(sender As Object, e As EventArgs) Handles btnABMMonedas.Click
        Dim frm As New frmABMMonedas()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMTiposCuenta_Click(sender As Object, e As EventArgs) Handles btnABMTiposCuenta.Click
        Dim frm As New frmABMTiposCuenta()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMCuentas_Click(sender As Object, e As EventArgs) Handles btnABMCuentas.Click
        Dim frm As New frmABMCuentas()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMCategorias_Click(sender As Object, e As EventArgs) Handles btnABMCategorias.Click
        Dim frm As New frmABMCategorias()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMSubCategorias_Click(sender As Object, e As EventArgs) Handles btnABMSubCategorias.Click
        Dim frm As New frmABMSubCategorias()
        frm.ShowDialog()
    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        Dim frm As New frmMovimientos("Ingreso")
        frm.ShowDialog()
    End Sub

    Private Sub btnEgreso_Click(sender As Object, e As EventArgs) Handles btnGasto.Click
        Dim frm As New frmMovimientos("Gasto")
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim proc As New Process()
        proc.StartInfo.FileName = "chrome.exe"
        proc.Start()
    End Sub
End Class