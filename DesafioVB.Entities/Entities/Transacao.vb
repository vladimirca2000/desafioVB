Imports System.ComponentModel.DataAnnotations

Namespace DesafioVB.Entities

    Public Class Transacao
        ' Identificador da transação
        <Key>
        Public Property IdTransacao As Integer

        ' Número do cartão composto por 16 dígitos
        <Required(ErrorMessage:="O campo NumeroCartao é obrigatório")>
        <StringLength(16, ErrorMessage:="O campo NumeroCartao deve ter 16 caracteres")>
        <RegularExpression("^[0-9]*$", ErrorMessage:="O número do cartão deve conter apenas números.")>
        Public Property NumeroCartao As String

        ' Valor da transação (deve ser positivo)
        <Required(ErrorMessage:="O campo ValorTransacao é obrigatório")>
        <Range(0, Double.MaxValue, ErrorMessage:="O campo ValorTransacao deve ser maior que zero")>
        Public Property ValorTransacao As Decimal

        ' Data e hora do registro da transação
        <Required(ErrorMessage:="O campo DataTransacao é obrigatório")>
        Public Property DataTransacao As DateTime

        ' Descrição com até 255 caracteres
        <StringLength(255, ErrorMessage:="O campo Descricao deve ter no máximo 255 caracteres")>
        Public Property Descricao As String

        ' Status da transação (Aprovada, Pendente, Cancelada)
        <Required(ErrorMessage:="O campo StatusTransacao é obrigatório")>
        Public Property StatusTransacao As StatusTransacaoEnum
    End Class

    Public Enum StatusTransacaoEnum
        Aprovada
        Pendente
        Cancelada
    End Enum

End Namespace
