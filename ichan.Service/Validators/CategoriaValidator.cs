using FluentValidation;
using ichan.Domain.Entities;

namespace ichan.Service.Validators
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(45).WithMessage("O nome pode ter no máximo 45 caracteres.");

            RuleFor(c => c.Descricao)
                .MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.");
        }
    }
}
