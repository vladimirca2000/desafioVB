Imports FluentValidation
Imports FluentValidation.Results

Friend Class InputTransacaoDTOValidator
    Inherits AbstractValidator(Of InputTransacaoDTO)

    Public Sub New()
        RuleFor(Function(x) x.NumeroCartao).NotEmpty().WithMessage("O número do cartão é obrigatório.")
        RuleFor(Function(x) x.NumeroCartao).Length(16).WithMessage("O número do cartão deve ter 16 dígitos.")
        RuleFor(Function(x) x.NumeroCartao).Matches("^[0-9]*$").WithMessage("O número do cartão deve conter apenas números.")
        RuleFor(Function(x) x.ValorTransacao).GreaterThan(0).WithMessage("O valor da transação deve ser positivo.")
        RuleFor(Function(x) x.ValorTransacao).GreaterThan(0).WithMessage("O valor da transação deve ser maior que zero.")
        RuleFor(Function(x) x.DataTransacao).NotEmpty().WithMessage("A data da transação é obrigatória.")
        RuleFor(Function(x) x.Descricao).NotEmpty().WithMessage("A descrição é obrigatória.")
        RuleFor(Function(x) x.Descricao).MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.")
        RuleFor(Function(x) x.StatusTransacao).IsInEnum().WithMessage("O status da transação é obrigatório.")
    End Sub

    Friend Overloads Function Validate(createTransacao As InputTransacaoDTO) As ValidationResult
        Return MyBase.Validate(createTransacao)
    End Function
End Class
