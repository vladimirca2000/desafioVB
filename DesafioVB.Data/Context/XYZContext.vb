Imports Microsoft.EntityFrameworkCore
Imports DesafioVB.Entities
Imports DesafioVB.Entities.DesafioVB.Entities

Namespace DesafioVB.Data.Context

    Public Class XYZContext
        Inherits DbContext

        Public Sub New(options As DbContextOptions(Of XYZContext))
            MyBase.New(options)
        End Sub

        ' Definição das tabelas do banco de dados
        Public Property Transacoes As DbSet(Of Transacao)

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            MyBase.OnModelCreating(modelBuilder)

            ' Aplicar as configurações de mapeamento (caso tenha classes separadas na pasta Mapping)
            modelBuilder.ApplyConfigurationsFromAssembly(GetType(XYZContext).Assembly)
        End Sub
    End Class

End Namespace

