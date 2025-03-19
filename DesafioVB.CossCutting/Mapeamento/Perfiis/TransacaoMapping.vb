Imports Mapster
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.CossCutting.DesafioVB.DTOs

Public Class TransacaoMapping
    Public Shared Sub Configurar()
        ' Configuração do mapeamento de Transacao para CreateTransacaoDTO
        TypeAdapterConfig(Of Transacao, CreateTransacaoDTO) _
            .NewConfig() _
            .Map(Function(dest) dest.IdTransacao, Function(src) src.IdTransacao) _
            .Map(Function(dest) dest.ValorTransacao, Function(src) src.ValorTransacao) _
            .Map(Function(dest) dest.DataTransacao, Function(src) src.DataTransacao) _
            .Map(Function(dest) dest.Descricao, Function(src) src.Descricao) _
            .Map(Function(dest) dest.StatusTransacao, Function(src) src.StatusTransacao)

        ' Configuração inversa (CreateTransacaoDTO para Transacao)
        TypeAdapterConfig(Of CreateTransacaoDTO, Transacao) _
            .NewConfig() _
            .Map(Function(dest) dest.IdTransacao, Function(src) src.IdTransacao) _
            .Map(Function(dest) dest.NumeroCartao, Function(src) src.NumeroCartao) _
            .Map(Function(dest) dest.ValorTransacao, Function(src) src.ValorTransacao) _
            .Map(Function(dest) dest.DataTransacao, Function(src) src.DataTransacao) _
            .Map(Function(dest) dest.Descricao, Function(src) src.Descricao) _
            .Map(Function(dest) dest.StatusTransacao, Function(src) CType(src.StatusTransacao, StatusTransacaoEnum))
    End Sub
End Class
