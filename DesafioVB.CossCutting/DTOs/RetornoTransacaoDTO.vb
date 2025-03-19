﻿Imports System.ComponentModel.DataAnnotations
Imports DesafioVB.Entities.DesafioVB.Entities

Namespace DesafioVB.DTOs
    Public Class RetornoTransacaoDTO
        Public Property IdTransacao As Integer
        Public Property NumeroCartao As String
        Public Property ValorTransacao As Decimal
        Public Property DataTransacao As DateTime
        Public Property Descricao As String
        Public Property StatusTransacao As String
    End Class
End Namespace
