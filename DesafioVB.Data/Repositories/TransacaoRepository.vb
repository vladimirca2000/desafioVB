Imports Microsoft.Data.SqlClient
Imports Dapper
Imports DesafioVB.Entities
Imports DesafioVB.Entities.DesafioVB.Entities

Public Class TransacaoRepository
    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Function GetAll() As IEnumerable(Of Transacao)
        Using connection As New SqlConnection(_connectionString)
            Return connection.Query(Of Transacao)("SELECT * FROM Transacoes")
        End Using
    End Function

    Public Function GetById(id As Integer) As Transacao
        Using connection As New SqlConnection(_connectionString)
            Return connection.QuerySingleOrDefault(Of Transacao)("SELECT * FROM Transacoes WHERE IdTransacao = @Id", New With {Key .Id = id})
        End Using
    End Function

    Public Sub Add(transacao As Transacao)
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("INSERT INTO Transacoes (NumeroCartao, ValorTransacao, DataTransacao, Descricao, StatusTransacao) VALUES (@NumeroCartao, @ValorTransacao, @DataTransacao, @Descricao, @StatusTransacao)", transacao)
        End Using
    End Sub

    Public Sub Update(transacao As Transacao)
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("UPDATE Transacoes SET NumeroCartao = @NumeroCartao, ValorTransacao = @ValorTransacao, DataTransacao = @DataTransacao, Descricao = @Descricao, StatusTransacao = @StatusTransacao WHERE IdTransacao = @IdTransacao", transacao)
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Using connection As New SqlConnection(_connectionString)
            connection.Execute("DELETE FROM Transacoes WHERE IdTransacao = @Id", New With {Key .Id = id})
        End Using
    End Sub
End Class


