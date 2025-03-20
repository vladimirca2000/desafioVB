Imports Mapster
Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories
Imports Microsoft.Extensions.Logging
Imports DesafioVB.Entities.Notifications
Imports DesafioVB.Entities

Namespace Services
    Public Class TransacaoService
        Implements ITransacaoService

        Private ReadOnly _transacaoRepository As ITransacaoRepository
        Private ReadOnly _logger As ILogger(Of TransacaoService)
        Private ReadOnly _notification As INotification

        Public Sub New(transacaoRepository As ITransacaoRepository, logger As ILogger(Of TransacaoService), notification As INotification)
            _transacaoRepository = transacaoRepository
            _logger = logger
            _notification = notification
        End Sub

        Public Function GetAll() As IEnumerable(Of Transacao) Implements ITransacaoService.GetAll
            Try
                _logger.LogInformation("Iniciando a busca de todas as transações.")
                ' Buscar todas as transações
                Dim transacoes = _transacaoRepository.GetAll()
                _logger.LogInformation("Busca de todas as transações concluída com sucesso.")

                ' Retornar a lista de transações
                Return transacoes
            Catch ex As Exception
                _logger.LogError(ex, "Erro ao buscar todas as transações.")
                _notification.Notify("Erro ao buscar todas as transações.")
                Throw
            End Try
        End Function

        Public Function GetById(id As Integer) As RetornoTransacaoDTO Implements ITransacaoService.GetById
            Try
                _logger.LogInformation($"Iniciando a busca da transação com ID {id}.", id)
                If id <= 0 Then
                    _logger.LogInformation("O ID da transação deve ser maior que zero.")
                    _notification.Notify("O ID da transação deve ser maior que zero.")
                    Return Nothing
                End If

                ' Buscar a transação pelo ID
                Dim transacao = _transacaoRepository.GetById(id)

                ' Se a transação não for encontrada, lança uma exceção
                If transacao Is Nothing Then
                    _logger.LogInformation("Transação não encontrada.")
                    _notification.Notify("Transação não encontrada.")
                    Return Nothing
                End If

                Dim retorno = transacao.Adapt(Of RetornoTransacaoDTO)()
                _logger.LogInformation($"Busca da transação com ID {id} concluída com sucesso.", id)
                Return retorno
            Catch ex As Exception
                _logger.LogError(ex, $"Erro ao buscar a transação com ID {id}.", id)
                _notification.Notify($"Erro ao buscar a transação com ID {id}.")
                Throw
            End Try
        End Function

        Public Sub Add(createTransacao As InputTransacaoDTO) Implements ITransacaoService.Add
            Try
                _logger.LogInformation("Iniciando a adição de uma nova transação.")
                If createTransacao Is Nothing Then
                    _logger.LogInformation("A transação não pode ser nula.")
                    _notification.Notify("A transação não pode ser nula.")
                    Exit Sub
                End If

                Dim transacao = createTransacao.Adapt(Of Transacao)()

                _transacaoRepository.Add(transacao)
                _logger.LogInformation("Adição de nova transação concluída com sucesso.")
                _notification.Notify("Adição de nova transação concluída com sucesso.")
            Catch ex As Exception
                _logger.LogError(ex, "Erro ao adicionar uma nova transação.")
                _notification.Notify("Erro ao adicionar uma nova transação.")
                Throw
            End Try
        End Sub

        Public Sub Update(updateTransacao As InputTransacaoDTO) Implements ITransacaoService.Update
            Try
                _logger.LogInformation($"Iniciando a atualização da transação com ID {updateTransacao.IdTransacao}.", updateTransacao.IdTransacao)
                Dim transacaoExistente = _transacaoRepository.GetById(updateTransacao.IdTransacao)

                ' Se a transação não for encontrada, lança uma exceção
                If transacaoExistente Is Nothing Then
                    _logger.LogInformation("Transação não encontrada.")
                    _notification.Notify("Transação não encontrada.")
                    Exit Sub
                End If

                ' Se a transação já estiver aprovada, impede a edição
                If transacaoExistente.StatusTransacao = StatusTransacaoEnum.Aprovada Then
                    _logger.LogInformation("Transações aprovadas não podem ser editadas.")
                    _notification.Notify("Transações aprovadas não podem ser editadas.")
                    Exit Sub
                End If

                Dim transacao = updateTransacao.Adapt(Of Transacao)()

                ' Chama o repositório para atualizar a transação
                _transacaoRepository.Update(transacao)
                _logger.LogInformation($"Atualização da transação com ID {updateTransacao.IdTransacao} concluída com sucesso.", updateTransacao.IdTransacao)
                _notification.Notify($"Atualização da transação com ID {updateTransacao.IdTransacao} concluída com sucesso.")
            Catch ex As Exception
                _logger.LogError(ex, $"Erro ao atualizar a transação com ID {updateTransacao.IdTransacao}.", updateTransacao.IdTransacao)
                _notification.Notify($"Erro ao atualizar a transação com ID {updateTransacao.IdTransacao}.")
                Throw
            End Try
        End Sub


        Public Sub Delete(id As Integer) Implements ITransacaoService.Delete
            Try
                _logger.LogInformation($"Iniciando a exclusão da transação com ID {id}.", id)
                Dim transacaoExistente = _transacaoRepository.GetById(id)

                ' Se a transação não for encontrada, lança uma exceção
                If transacaoExistente Is Nothing Then
                    _logger.LogInformation("Transação não encontrada.")
                    _notification.Notify("Transação não encontrada.")
                    Exit Sub
                End If

                ' Se a transação já estiver aprovada, impede a exclusão
                If transacaoExistente.StatusTransacao = StatusTransacaoEnum.Aprovada Then
                    _logger.LogInformation("Transações aprovadas não podem ser excluídas.")
                    _notification.Notify("Transações aprovadas não podem ser excluídas.")
                    Exit Sub
                End If

                ' Chama o repositório para deletar a transação
                _transacaoRepository.Delete(id)
                _logger.LogInformation($"Exclusão da transação com ID {id} concluída com sucesso.", id)
                _logger.LogInformation($"Exclusão da transação com ID {id} concluída com sucesso.")
            Catch ex As Exception
                _logger.LogError(ex, $"Erro ao excluir a transação com ID {id}.", id)
                _notification.Notify($"Erro ao excluir a transação com ID {id}.")
                Throw
            End Try
        End Sub

        Public Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao) Implements ITransacaoService.GetAllPaginado
            Try
                _logger.LogInformation($"Iniciando a busca de transações paginadas. Página: {pagina}, Quantidade: {quantidade}.", pagina, quantidade)
                Dim transacoes = _transacaoRepository.GetAllPaginado(pagina, quantidade)

                _logger.LogInformation($"Busca de transações paginadas concluída com sucesso. Página: {pagina}, Quantidade: {quantidade}.", pagina, quantidade)
                Return transacoes
            Catch ex As Exception
                _logger.LogError(ex, $"Erro ao buscar transações paginadas. Página: {pagina}, Quantidade: {quantidade}.", pagina, quantidade)
                _notification.Notify($"Erro ao buscar transações paginadas. Página: {pagina}, Quantidade: {quantidade}.")
                Throw
            End Try
        End Function
    End Class
End Namespace
