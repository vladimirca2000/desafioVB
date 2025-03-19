Imports Mapster
Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.CossCutting
Imports DesafioVB.CossCutting.DesafioVB.DTOs
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories

Namespace Services
    Public Class TransacaoService
        Implements ITransacaoService

        Private ReadOnly _transacaoRepository As ITransacaoRepository
        Public Sub New(transacaoRepository As ITransacaoRepository)
            _transacaoRepository = transacaoRepository
        End Sub

        Public Function GetAll() As IEnumerable(Of Transacao) Implements ITransacaoService.GetAll
            Try
                ' Buscar todas as transações
                Dim transacoes = _transacaoRepository.GetAll()

                ' Retornar a lista de transações
                Return transacoes
            Catch ex As Exception
                ' Tratar exceções e lançar uma exceção personalizada
                Throw New Exception("Erro ao buscar transações: " & ex.Message)
            End Try
        End Function

        Public Function GetById(id As Integer) As RetornoTransacaoDTO Implements ITransacaoService.GetById
            ' Verificar se o ID é válido
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

            Return retorno
        End Function

        Public Sub Add(createTransacao As CreateTransacaoDTO) Implements ITransacaoService.Add
            ' Verificar se a transação é válida
            If createTransacao Is Nothing Then
                Throw New ArgumentNullException(NameOf(createTransacao), "A transação não pode ser nula.")
            End If

            Dim transacao = createTransacao.Adapt(Of Transacao)()

            _transacaoRepository.Add(transacao)
        End Sub


        Public Sub Update(updateTransacao As UpdateTransacaoDTO) Implements ITransacaoService.Update
            ' Buscar a transação existente para verificar o status atual
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
        End Sub


        Public Sub Delete(id As Integer) Implements ITransacaoService.Delete
            ' Buscar a transação existente para verificar o status atual
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
        End Sub

        Public Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao) Implements ITransacaoService.GetAllPaginado
            Try
                ' Buscar todas as transações
                Dim transacoes = _transacaoRepository.GetAllPaginado(pagina, quantidade)

                ' Retornar a lista de transações
                Return transacoes
            Catch ex As Exception
                ' Tratar exceções e lançar uma exceção personalizada
                Throw New Exception("Erro ao buscar transações: " & ex.Message)
            End Try
        End Function
    End Class
End Namespace
