Imports Mapster
Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.CossCutting
Imports DesafioVB.CossCutting.DesafioVB.DTOs
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories
Imports Microsoft.Extensions.Logging

Namespace Services
    Public Class TransacaoService
        Implements ITransacaoService

        Private ReadOnly _transacaoRepository As ITransacaoRepository
        Private ReadOnly _logger As ILogger(Of TransacaoService)
        Public Sub New(transacaoRepository As ITransacaoRepository, logger As ILogger(Of TransacaoService))
            _transacaoRepository = transacaoRepository
            _logger = logger
        End Sub

        Public Function GetAll() As IEnumerable(Of Transacao) Implements ITransacaoService.GetAll

            _logger.LogInformation("Iniciando a busca de todas as transações.")
                ' Buscar todas as transações
                Dim transacoes = _transacaoRepository.GetAll()
                _logger.LogInformation("Busca de todas as transações concluída com sucesso.")

                ' Retornar a lista de transações
                Return transacoes

        End Function

        Public Function GetById(id As Integer) As RetornoTransacaoDTO Implements ITransacaoService.GetById

            _logger.LogInformation("Iniciando a busca da transação com ID {Id}.", id)
                If id <= 0 Then
                    Throw New ArgumentException("O ID da transação deve ser maior que zero.")
                End If

                ' Buscar a transação pelo ID
                Dim transacao = _transacaoRepository.GetById(id)

                ' Se a transação não for encontrada, lança uma exceção
                If transacao Is Nothing Then
                    Throw New Exception("Transação não encontrada.")
                End If

                Dim retorno = transacao.Adapt(Of RetornoTransacaoDTO)()
                _logger.LogInformation("Busca da transação com ID {Id} concluída com sucesso.", id)
                Return retorno

        End Function

        Public Sub Add(createTransacao As CreateTransacaoDTO) Implements ITransacaoService.Add

            _logger.LogInformation("Iniciando a adição de uma nova transação.")
                If createTransacao Is Nothing Then
                    Throw New ArgumentNullException(NameOf(createTransacao), "A transação não pode ser nula.")
                End If

                Dim transacao = createTransacao.Adapt(Of Transacao)()

                _transacaoRepository.Add(transacao)
                _logger.LogInformation("Adição de nova transação concluída com sucesso.")

        End Sub

        Public Sub Update(updateTransacao As UpdateTransacaoDTO) Implements ITransacaoService.Update

            _logger.LogInformation("Iniciando a atualização da transação com ID {Id}.", updateTransacao.IdTransacao)
                Dim transacaoExistente = _transacaoRepository.GetById(updateTransacao.IdTransacao)

                ' Se a transação não for encontrada, lança uma exceção
                If transacaoExistente Is Nothing Then
                    Throw New Exception("Transação não encontrada.")
                End If

                ' Se a transação já estiver aprovada, impede a edição
                If transacaoExistente.StatusTransacao = StatusTransacaoEnum.Aprovada Then
                    Throw New Exception("Transações aprovadas não podem ser editadas.")
                End If

                Dim transacao = updateTransacao.Adapt(Of Transacao)()

                ' Chama o repositório para atualizar a transação
                _transacaoRepository.Update(transacao)
                _logger.LogInformation("Atualização da transação com ID {Id} concluída com sucesso.", updateTransacao.IdTransacao)

        End Sub


        Public Sub Delete(id As Integer) Implements ITransacaoService.Delete

            _logger.LogInformation("Iniciando a exclusão da transação com ID {Id}.", id)
                Dim transacaoExistente = _transacaoRepository.GetById(id)

                ' Se a transação não for encontrada, lança uma exceção
                If transacaoExistente Is Nothing Then
                    Throw New Exception("Transação não encontrada.")
                End If

                ' Se a transação já estiver aprovada, impede a exclusão
                If transacaoExistente.StatusTransacao = StatusTransacaoEnum.Aprovada Then
                    Throw New Exception("Transações aprovadas não podem ser excluídas.")
                End If

                ' Chama o repositório para deletar a transação
                _transacaoRepository.Delete(id)
                _logger.LogInformation("Exclusão da transação com ID {Id} concluída com sucesso.", id)

        End Sub

        Public Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao) Implements ITransacaoService.GetAllPaginado

            _logger.LogInformation("Iniciando a busca de transações paginadas. Página: {Pagina}, Quantidade: {Quantidade}.", pagina, quantidade)
                Dim transacoes = _transacaoRepository.GetAllPaginado(pagina, quantidade)

                _logger.LogInformation("Busca de transações paginadas concluída com sucesso. Página: {Pagina}, Quantidade: {Quantidade}.", pagina, quantidade)
                Return transacoes

        End Function
    End Class
End Namespace
