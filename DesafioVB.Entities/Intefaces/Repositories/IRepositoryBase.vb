Namespace Interfaces.Repositories
    Public Interface IRepositoryBase(Of TEntity)
        Function GetAll() As IEnumerable(Of TEntity)
        Function GetById(id As Integer) As TEntity
        Sub Add(entity As TEntity)
        Sub Update(entity As TEntity)
        Sub Delete(id As Integer)
    End Interface
End Namespace



