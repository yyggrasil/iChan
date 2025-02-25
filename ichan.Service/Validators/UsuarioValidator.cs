using FluentValidation;
using ichan.Domain.Entities;

namespace ichan.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("E-mail inválido.");

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(4).WithMessage("A senha deve ter pelo menos 4 caracteres.");

            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(45).WithMessage("O nome pode ter no máximo 45 caracteres.");

            RuleFor(u => u.Bios)
                .MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.");
        }

    }
}
