﻿Public Class frmInicio
    Private Sub btnABMMonedas_Click(sender As Object, e As EventArgs) Handles btnABMMonedas.Click
        Dim frm As New frmABMMonedas()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMTiposCuenta_Click(sender As Object, e As EventArgs) Handles btnABMTiposCuenta.Click
        Dim frm As New frmABMTiposCuenta()
        frm.ShowDialog()
    End Sub

    Private Sub btnMonedaPorDefecto_Click(sender As Object, e As EventArgs) Handles btnMonedaPorDefecto.Click
        Dim frm As New frmMonedaPorDefecto()
        frm.ShowDialog()
    End Sub

    Private Sub btnABMCuentas_Click(sender As Object, e As EventArgs) Handles btnABMCuentas.Click
        Dim frm As New frmABMCuentas()
        frm.showDialog()
    End Sub
End Class