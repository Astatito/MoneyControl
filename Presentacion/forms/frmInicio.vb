Public Class frmInicio
    Private Sub btnABMMonedas_Click(sender As Object, e As EventArgs) Handles btnABMMonedas.Click
        Dim frm As New frmABMMonedas()
        frm.ShowDialog()
    End Sub
End Class