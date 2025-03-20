Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities

Namespace Interfaces.Services
    Public Interface ITransacaoService
        Function GetAll() As IEnumerable(Of Transacao)
        Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)
        Function GetById(id As Integer) As RetornoTransacaoDTO
        Sub Add(createTransacao As InputTransacaoDTO)
        Sub Update(transacao As InputTransacaoDTO)
        Sub Delete(id As Integer)
    End Interface
End Namespace
