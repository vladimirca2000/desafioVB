Imports DesafioVB.Entities.DesafioVB.Entities

Namespace Interfaces.Repositories
    Public Interface ITransacaoRepository
        Inherits IRepositoryBase(Of Transacao)

        Function GetByFilters(dataTransacao As Date?, valorTransacao As Decimal?, statusTransacao As StatusTransacaoEnum?, numeroCartao As String, pagina As Integer, quantidade As Integer) As Object
        Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)

    End Interface
End Namespace
