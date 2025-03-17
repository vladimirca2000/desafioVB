Imports System
Imports System.ComponentModel.DataAnnotations

Namespace DesafioVB.Entities.DTOs

    Public Class UpdateTransacaoDTO

        <Required(ErrorMessage:="O ID da transação é obrigatório.")>
        Public Property IdTransacao As Integer

        <Required(ErrorMessage:="O número do cartão é obrigatório.")>
        <StringLength(16, MinimumLength:=16, ErrorMessage:="O número do cartão deve ter 16 dígitos.")>
        Public Property NumeroCartao As String

        <Required(ErrorMessage:="O valor da transação é obrigatório.")>
        <Range(0.01, Double.MaxValue, ErrorMessage:="O valor da transação deve ser positivo.")>
        Public Property ValorTransacao As Decimal

        <Required(ErrorMessage:="A data da transação é obrigatória.")>
        Public Property DataTransacao As DateTime

        <StringLength(255, ErrorMessage:="A descrição pode ter no máximo 255 caracteres.")>
        Public Property Descricao As String

        <Required(ErrorMessage:="O status da transação é obrigatório.")>
        Public Property StatusTransacao As String

    End Class

End Namespace
