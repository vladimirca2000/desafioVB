Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities

Namespace Interfaces.Services
    Public Interface ITransacaoService
        Function GetByFilters(dataTransacao As Date?, valorTransacao As Decimal?, statusTransacao As StatusTransacaoEnum?, numeroCartao As String, pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)
        Function GetAll() As IEnumerable(Of Transacao)
        Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)
        Function GetById(id As Integer) As RetornoTransacaoDTO
        Sub Add(createTransacao As InputTransacaoDTO)
        Sub Update(transacao As InputTransacaoDTO)
        Sub Delete(id As Integer)
    End Interface
End Namespace
