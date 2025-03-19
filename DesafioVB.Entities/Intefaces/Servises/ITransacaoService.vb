Imports DesafioVB.Entities.DesafioVB.Entities

Namespace Interfaces.Services
    Public Interface ITransacaoService
        Function GetAll() As IEnumerable(Of Transacao)
        Function GetById(id As Integer) As Transacao
        Sub Add(transacao As Transacao)
        Sub Update(transacao As Transacao)
        Sub Delete(id As Integer)
    End Interface
End Namespace
