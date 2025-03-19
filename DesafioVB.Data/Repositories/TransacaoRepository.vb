Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Options
Imports Dapper
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories
Imports DesafioVB.CossCutting.DesafioVB.Common



Public Class TransacaoRepository
    Implements ITransacaoRepository

    Private ReadOnly _connectionString As String

    Public Sub New(options As IOptions(Of DatabaseSettings))
        _connectionString = options.Value.ConnectionString
    End Sub

    Public Function GetAll() As IEnumerable(Of Transacao) Implements ITransacaoRepository.GetAll
        Using connection As New SqlConnection(_connectionString)
            Return connection.Query(Of Transacao)("SELECT * FROM Transacoes")
        End Using
    End Function

    Public Function GetById(id As Integer) As Transacao Implements ITransacaoRepository.GetById
        Using connection As New SqlConnection(_connectionString)
            Return connection.QuerySingleOrDefault(Of Transacao)("SELECT
                                                                         Id_Transacao as IdTransacao
                                                                        ,Numero_Cartao as NumeroCartao
                                                                        ,Valor_Transacao as ValorTransacao
                                                                        ,Data_Transacao as DataTransacao
                                                                        ,Descricao
                                                                        ,Status_Transacao as StatusTransacao 
                                                                  FROM Transacoes WHERE Id_Transacao = @Id", New With {Key .Id = id})
        End Using
    End Function

    Public Sub Add(transacao As Transacao) Implements ITransacaoRepository.Add

        Dim convert As New NumeroParaTextEnumStatusTransacao
        Dim statusDaTransacao = convert.GetStatusTransacaoDescricao(transacao.StatusTransacao)

        Using connection As New SqlConnection(_connectionString)
            connection.Execute("INSERT INTO Transacoes (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao) VALUES (@NumeroCartao, @ValorTransacao, @DataTransacao, @Descricao, @statusDaTransacao)",
                               New With {
                               transacao.NumeroCartao,
                               transacao.ValorTransacao,
                               transacao.DataTransacao,
                               transacao.Descricao,
                               .statusDaTransacao = statusDaTransacao
                           })
        End Using
    End Sub

    Public Sub Update(transacao As Transacao) Implements ITransacaoRepository.Update
        Dim convert As New NumeroParaTextEnumStatusTransacao
        Dim statusDaTransacao = convert.GetStatusTransacaoDescricao(transacao.StatusTransacao)

        Using connection As New SqlConnection(_connectionString)
            connection.Execute("UPDATE Transacoes SET Numero_Cartao = @NumeroCartao, Valor_Transacao = @ValorTransacao, Data_Transacao = @DataTransacao, Descricao = @Descricao, Status_Transacao = @statusDaTransacao WHERE Id_Transacao = @IdTransacao",
                               New With {
                               transacao.IdTransacao,
                               transacao.NumeroCartao,
                               transacao.ValorTransacao,
                               transacao.DataTransacao,
                               transacao.Descricao,
                               .statusDaTransacao = statusDaTransacao
                           })
        End Using
    End Sub

    Public Sub Delete(id As Integer) Implements ITransacaoRepository.Delete
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("DELETE FROM Transacoes WHERE Id_Transacao = @Id", New With {Key .Id = id})
        End Using
    End Sub

    Public Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao) Implements ITransacaoRepository.GetAllPaginado
        Using connection As New SqlConnection(_connectionString)
            Dim offset = (pagina - 1) * quantidade
            'If offset = 0 Then
            '    offset = quantidade
            'End If
            Dim query = "SELECT 
                             Id_Transacao as IdTransacao
                            ,Numero_Cartao as NumeroCartao
                            ,Valor_Transacao as ValorTransacao
                            ,Data_Transacao as DataTransacao
                            ,Descricao
                            ,Status_Transacao as StatusTransacao
                         FROM Transacoes ORDER BY Id_Transacao OFFSET @Offset ROWS FETCH NEXT @Quantidade ROWS ONLY"
            Return connection.Query(Of Transacao)(query, New With {.Offset = offset, .Quantidade = quantidade})
        End Using
    End Function


End Class