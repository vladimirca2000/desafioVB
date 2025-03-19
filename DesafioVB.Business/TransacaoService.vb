Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories
Imports DesafioVB.Entities.Interfaces.Services

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

        Public Function GetById(id As Integer) As Transacao Implements ITransacaoService.GetById
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

            Return transacao
        End Function

        Public Sub Add(transacao As Transacao) Implements ITransacaoService.Add
            ' Verificar se a transação é válida
            If transacao Is Nothing Then
                Throw New ArgumentNullException(NameOf(transacao), "A transação não pode ser nula.")
            End If

            ' Verificar se os campos obrigatórios estão preenchidos
            If String.IsNullOrEmpty(transacao.Descricao) Then
                Throw New ArgumentException("A descrição da transação é obrigatória.")
            End If

            If transacao.ValorTransacao <= 0 Then
                Throw New ArgumentException("O valor da transação deve ser maior que zero.")
            End If

            ' Verificar se a transação já existe (baseado em algum critério, por exemplo, ID ou outro campo único)
            Dim transacaoExistente = _transacaoRepository.GetById(transacao.IdTransacao)
            If transacaoExistente IsNot Nothing Then
                Throw New Exception("Uma transação com o mesmo ID já existe.")
            End If

            ' Chama o repositório para adicionar a transação
            _transacaoRepository.Add(transacao)
        End Sub


        Public Sub Update(transacao As Transacao) Implements ITransacaoService.Update
            ' Buscar a transação existente para verificar o status atual
            Dim transacaoExistente = _transacaoRepository.GetById(transacao.IdTransacao)

            ' Se a transação não for encontrada, lança uma exceção
            If transacaoExistente Is Nothing Then
                Throw New Exception("Transação não encontrada.")
            End If

            ' Se a transação já estiver aprovada, impede a edição
            If transacaoExistente.StatusTransacao = StatusTransacaoEnum.Aprovada Then
                Throw New Exception("Transações aprovadas não podem ser editadas.")
            End If

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

    End Class
End Namespace
