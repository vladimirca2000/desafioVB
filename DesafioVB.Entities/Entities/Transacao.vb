Namespace DesafioVB.Entities

    Public Class Transacao
        Public Property IdTransacao As Integer

        ' Número do cartão composto por 16 dígitos
        Public Property NumeroCartao As String

        ' Valor da transação (deve ser positivo)
        Public Property ValorTransacao As Decimal

        ' Data e hora do registro da transação
        Public Property DataTransacao As DateTime

        ' Descrição com até 255 caracteres
        Public Property Descricao As String

        ' Status da transação (Aprovada, Pendente, Cancelada)
        Public Property StatusTransacao As StatusTransacaoEnum
    End Class

    Public Enum StatusTransacaoEnum
        Aprovada
        Pendente
        Cancelada
    End Enum

End Namespace
