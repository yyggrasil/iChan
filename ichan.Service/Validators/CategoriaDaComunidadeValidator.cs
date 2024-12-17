using FluentValidation;
using ichan.Domain.Entities;

namespace ichan.Service.Validators
{
    public class CategoriaDaComunidadeValidator : AbstractValidator<CategoriaDaComunidade>
    {
        public CategoriaDaComunidadeValidator()
        {
            RuleFor(c => c.Categoria)
                .NotEmpty().WithMessage("A categoria é obrigatório.");

            RuleFor(c => c.Comunidade)
                .NotEmpty().WithMessage("A comunidade é obrigatório.");
        }
    }
}
