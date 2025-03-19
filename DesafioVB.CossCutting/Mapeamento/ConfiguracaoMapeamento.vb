Imports Mapster

Public Class ConfiguracaoMapeamento
    Public Shared Sub RegistrarMapeamentos()
        ' Registra todos os mapeamentos
        TransacaoMapping.Configurar()
        RetornoTransacaoMapping.Configurar()
        ' Adicione outros mapeamentos aqui (ex: ProdutoMapping, ClienteMapping)
    End Sub
End Class
