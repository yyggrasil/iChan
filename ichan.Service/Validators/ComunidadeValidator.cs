using FluentValidation;
using ichan.Domain.Entities;

namespace ichan.Service.Validators
{
    public class ComunidadeValidator : AbstractValidator<Comunidade>
    {
        public ComunidadeValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome da comunidade é obrigatório.")
                .MaximumLength(45).WithMessage("O nome pode ter no máximo 45 caracteres.");

            RuleFor(c => c.Descricao)
                .MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.");

            RuleFor(c => c.DataCriacao)
                .NotEmpty().WithMessage("A data de criação é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data de criação não pode ser no futuro.");
        }
    }
}
