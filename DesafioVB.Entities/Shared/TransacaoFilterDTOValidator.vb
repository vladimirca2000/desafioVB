Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.Entities.Notifications
Imports FluentValidation
Imports FluentValidation.Results
Imports Microsoft.Extensions.Logging
Imports DesafioVB.Entities.DesafioVB.DTOs

Public Class TransacaoFilterDTOValidator
    Inherits AbstractValidator(Of TransacaoFilterDTO)

    Private ReadOnly _logger As ILogger(Of TransacaoFilterDTOValidator)
    Private ReadOnly _notification As INotification

    Public Sub New()
        RuleFor(Function(x) x.DataTransacao).Must(AddressOf BeAValidDate).WithMessage("Data inválida.")
        RuleFor(Function(x) x.NumeroCartao).NotEmpty().WithMessage("O número do cartão é obrigatório.")
        RuleFor(Function(x) x.NumeroCartao).Length(16).WithMessage("O número do cartão deve ter 16 dígitos.")
        RuleFor(Function(x) x.NumeroCartao).Matches("^[0-9]*$").WithMessage("O número do cartão deve conter apenas números.")
        RuleFor(Function(x) x.ValorTransacao).NotEmpty().WithMessage("O valor da transação é obrigatório.")
        RuleFor(Function(x) x.ValorTransacao).GreaterThan(0).WithMessage("O valor da transação deve ser positivo.")
        RuleFor(Function(x) x.DataTransacao).NotEmpty().WithMessage("A data da transação é obrigatória.")
        RuleFor(Function(x) x.StatusTransacao).IsInEnum().WithMessage("O status da transação é obrigatório.")
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

        If String.IsNullOrEmpty(data) OrElse Not DateTime.TryParse(data, dataTransacao) Then
            dataTransacao = DateTime.MinValue
        End If

        If Not Decimal.TryParse(valor, valorTransacao) OrElse valorTransacao <= 0 Then
            valorTransacao = 0
        End If

        If [Enum].IsDefined(GetType(StatusTransacaoEnum), status) Then
            statusTransacao = CType([Enum].Parse(GetType(StatusTransacaoEnum), status), StatusTransacaoEnum)
        Else
            statusTransacao = Nothing
        End If

        If dataTransacao = DateTime.MinValue AndAlso valorTransacao <= 0 AndAlso String.IsNullOrEmpty(status) AndAlso numeroCartaoLimpo.Length <> 16 Then
            Return Nothing
        End If

        Return New TransacaoFilterDTO With {
            .DataTransacao = If(dataTransacao = DateTime.MinValue, Nothing, dataTransacao),
            .ValorTransacao = valorTransacao,
            .StatusTransacao = If(statusTransacao.HasValue, statusTransacao.Value, Nothing),
            .NumeroCartao = numeroCartaoLimpo
        }
    End Function

    Public Overloads Function Validate(createTransacao As InputTransacaoDTO) As ValidationResult
        Dim validator = New InputTransacaoDTOValidator()
        Return validator.Validate(createTransacao)
    End Function
End Class