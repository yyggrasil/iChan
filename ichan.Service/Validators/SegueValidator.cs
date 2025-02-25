using FluentValidation;
using ichan.Domain.Entities;

namespace ichan.Service.Validators
{
    public class SegueValidator : AbstractValidator<Segue>
    {
        public SegueValidator()
        {
            RuleFor(s => s.Usuario)
                .NotEmpty().WithMessage("O ID do usuário é obrigatório.");

            RuleFor(s => s.Comunidade)
                .NotEmpty().WithMessage("O ID da comunidade é obrigatório.");

            RuleFor(s => s.DataSeguida)
                .NotEmpty().WithMessage("A data em que começou a seguir é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data em que começou a seguir não pode ser no futuro.");
        }
    }
}
