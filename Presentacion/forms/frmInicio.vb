Imports Entidades

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
        Dim frm As New frmAMMovimientos("Ingreso")
        frm.ShowDialog()
    End Sub

    Private Sub btnEgreso_Click(sender As Object, e As EventArgs) Handles btnGasto.Click
        Dim frm As New frmAMMovimientos("Gasto")
        frm.ShowDialog()
    End Sub

    Private Sub frmInicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerConfiguracion()
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        Dim frm As New frmConfiguracion()
        frm.ShowDialog()
    End Sub

    Private Sub btnConsultaMovimientos_Click(sender As Object, e As EventArgs) Handles btnConsultaMovimientos.Click
        Dim frm As New frmConsultaMovimientos()
        frm.ShowDialog()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) 
        Dim frm As New frmUsuarios()
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim user As New EUsuario()
        user.ID = 1
        user.Usuario = "FABIAN"
        user.Password = "hola"

        Dim frm As New frmUsuarios(user)
        frm.Show()
    End Sub

    Private Sub btnABMUsuarios_Click(sender As Object, e As EventArgs) Handles btnABMUsuarios.Click
        Dim frm As New frmABMUsuarios()
        frm.ShowDialog()
    End Sub
End Class