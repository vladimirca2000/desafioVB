Imports DesafioVB.Entities.DesafioVB.Entities

Namespace DesafioVB.Common
    Public Class NumeroParaTextEnumStatusTransacao
        Public Function GetStatusTransacaoDescricao(status As StatusTransacaoEnum) As String
            Select Case status
                Case StatusTransacaoEnum.Pendente
                    Return "Pendente"
                Case StatusTransacaoEnum.Aprovada
                    Return "Aprovada"
                Case StatusTransacaoEnum.Cancelada
                    Return "Cancelada"
                Case Else
                    Return String.Empty
            End Select
        End Function
    End Class
End Namespace
