Imports DesafioVB.Entities.DesafioVB.Entities

Namespace Interfaces.Repositories
    Public Interface ITransacaoRepository
        Inherits IRepositoryBase(Of Transacao)

        Function GetAllPaginado(pagina As Integer, quantidade As Integer) As IEnumerable(Of Transacao)

        ' Adicione métodos específicos para Transacao, se necessário
    End Interface
End Namespace
