Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.CossCutting.DesafioVB.DTOs

Namespace Interfaces.Services
    Public Interface ITransacaoService
        Function GetAll() As IEnumerable(Of Transacao)
        Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)
        Function GetById(id As Integer) As RetornoTransacaoDTO
        Sub Add(createTransacao As CreateTransacaoDTO)
        Sub Update(transacao As UpdateTransacaoDTO)
        Sub Delete(id As Integer)
    End Interface
End Namespace
