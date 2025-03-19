Imports DesafioVB.CossCutting.DesafioVB.DTOs
Imports DesafioVB.Entities.DesafioVB.Entities
Imports FluentValidation

Public Class TransacaoFilterDTOValidator
    Inherits AbstractValidator(Of TransacaoFilterDTO)

    Public Sub New()
        RuleFor(Function(x) x.DataTransacao).Must(AddressOf BeAValidDate).WithMessage("Data inválida.")
    End Sub

    Public Function BeAValidDate(data As DateTime?) As Boolean
        If Not data.HasValue OrElse data.Value = DateTime.MinValue Then
            Return True
        End If
        Return data.Value <> DateTime.MinValue
    End Function

    Public Function LimparEValidarNumeroCartao(numeroCartao As String) As String
        ' Remover espaços
        Dim numeroCartaoSemEspacos = numeroCartao.Replace(" ", "")

        ' Remover caracteres não numéricos
        Dim numeroCartaoLimpo = New String(numeroCartaoSemEspacos.Where(Function(c) Char.IsDigit(c)).ToArray())

        Return numeroCartaoLimpo
    End Function

    Public Function ValidarFiltros(data As String, valor As String, status As String, cartao As String) As TransacaoFilterDTO
        Dim dataTransacao As DateTime
        Dim valorTransacao As Decimal
        Dim statusTransacao As StatusTransacaoEnum?
        Dim numeroCartaoLimpo = LimparEValidarNumeroCartao(cartao)

        ' Validar e converter a data
        If String.IsNullOrEmpty(data) OrElse Not DateTime.TryParse(data, dataTransacao) Then
            dataTransacao = DateTime.MinValue
        End If

        ' Validar e converter o valor
        If Not Decimal.TryParse(valor, valorTransacao) OrElse valorTransacao <= 0 Then
            valorTransacao = 0
        End If

        ' Validar o status
        If [Enum].IsDefined(GetType(StatusTransacaoEnum), status) Then
            statusTransacao = CType([Enum].Parse(GetType(StatusTransacaoEnum), status), StatusTransacaoEnum)
        Else
            statusTransacao = Nothing
        End If

        ' Verificar se todos os filtros são inválidos
        If dataTransacao = DateTime.MinValue AndAlso valorTransacao <= 0 AndAlso String.IsNullOrEmpty(status) AndAlso numeroCartaoLimpo.Length <> 16 Then
            Return Nothing
        End If

        ' Retornar o TransacaoFilterDTO
        Return New TransacaoFilterDTO With {
        .DataTransacao = If(dataTransacao = DateTime.MinValue, Nothing, dataTransacao),
        .ValorTransacao = valorTransacao,
        .StatusTransacao = statusTransacao,
        .NumeroCartao = numeroCartaoLimpo
    }
    End Function

End Class