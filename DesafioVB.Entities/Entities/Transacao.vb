Imports System.ComponentModel.DataAnnotations

Namespace DesafioVB.Entities

    Public Class Transacao
        <Key>
        Public Property IdTransacao As Integer

        <Required(ErrorMessage:="O campo NumeroCartao é obrigatório")>
        <StringLength(16, ErrorMessage:="O campo NumeroCartao deve ter 16 caracteres")>
        <RegularExpression("^[0-9]*$", ErrorMessage:="O número do cartão deve conter apenas números.")>
        Public Property NumeroCartao As String

        <Required(ErrorMessage:="O campo ValorTransacao é obrigatório")>
        <Range(0, Double.MaxValue, ErrorMessage:="O campo ValorTransacao deve ser maior que zero")>
        Public Property ValorTransacao As Decimal

        <Required(ErrorMessage:="O campo DataTransacao é obrigatório")>
        Public Property DataTransacao As DateTime

        <StringLength(255, ErrorMessage:="O campo Descricao deve ter no máximo 255 caracteres")>
        Public Property Descricao As String

        <Required(ErrorMessage:="O campo StatusTransacao é obrigatório")>
        Public Property StatusTransacao As StatusTransacaoEnum
    End Class

End Namespace
