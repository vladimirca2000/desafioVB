Imports Mapster

Public Class ConfiguracaoMapeamento
    Public Shared Sub RegistrarMapeamentos()
        TransacaoMapping.Configurar()
        RetornoTransacaoMapping.Configurar()
    End Sub
End Class
