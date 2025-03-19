Imports Microsoft.Data.SqlClient
Imports Microsoft.Extensions.Options
Imports Dapper
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Interfaces.Repositories
Imports DesafioVB.CossCutting.DesafioVB.Common ' Adicionando o namespace correto para DatabaseSettings

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
            Return connection.QuerySingleOrDefault(Of Transacao)("SELECT * FROM Transacoes WHERE IdTransacao = @Id", New With {Key .Id = id})
        End Using
    End Function

    Public Sub Add(transacao As Transacao) Implements ITransacaoRepository.Add
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("INSERT INTO Transacoes (NumeroCartao, ValorTransacao, DataTransacao, Descricao, StatusTransacao) VALUES (@NumeroCartao, @ValorTransacao, @DataTransacao, @Descricao, @StatusTransacao)", transacao)
        End Using
    End Sub

    Public Sub Update(transacao As Transacao) Implements ITransacaoRepository.Update
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("UPDATE Transacoes SET NumeroCartao = @NumeroCartao, ValorTransacao = @ValorTransacao, DataTransacao = @DataTransacao, Descricao = @Descricao, StatusTransacao = @StatusTransacao WHERE IdTransacao = @IdTransacao", transacao)
        End Using
    End Sub

    Public Sub Delete(id As Integer) Implements ITransacaoRepository.Delete
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("DELETE FROM Transacoes WHERE IdTransacao = @Id", New With {Key .Id = id})
        End Using
    End Sub
End Class