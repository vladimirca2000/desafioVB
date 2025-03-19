Imports Mapster
Imports DesafioVB.CossCutting.DesafioVB.DTOs
Imports DesafioVB.Entities.DesafioVB.Entities

Public Module ExtensoesMapeamento


    ''' <summary>
    ''' Converte um objeto para outro tipo usando o Mapster.
    ''' </summary>
    <System.Runtime.CompilerServices.Extension>
    Public Function Para(Of Destino)(origem As Object) As Destino
        Return origem.Adapt(Of Destino)()
    End Function
End Module
