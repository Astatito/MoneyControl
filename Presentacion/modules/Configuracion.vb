Imports Entidades
Imports LogicaNegocio

Module Configuracion

    Public Config As New EConfiguracion

    Public Sub ObtenerConfiguracion()
        Dim _LNConfiguracion As New LNConfiguracion()
        Config = _LNConfiguracion.ObtenerConfiguracion()
    End Sub

End Module
