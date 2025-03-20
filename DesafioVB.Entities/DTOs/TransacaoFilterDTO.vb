Imports System

Namespace DesafioVB.DTOs

    Public Class TransacaoFilterDTO

        Public Property NumeroCartao As String
        Public Property DataTransacao As Nullable(Of DateTime)
        Public Property ValorTransacao As Nullable(Of Decimal)
        Public Property StatusTransacao As String

    End Class

End Namespace
