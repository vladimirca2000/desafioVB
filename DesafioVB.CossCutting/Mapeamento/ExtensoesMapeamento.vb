Imports Mapster
Imports DesafioVB.Entities.DesafioVB.Entities

Public Module ExtensoesMapeamento
    <System.Runtime.CompilerServices.Extension>
    Public Function Para(Of Destino)(origem As Object) As Destino
        Return origem.Adapt(Of Destino)()
    End Function
End Module
