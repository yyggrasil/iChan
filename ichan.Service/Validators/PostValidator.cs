using FluentValidation;
using ichan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichan.Service.Validators
{
    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(p => p.Titulo)
                .NotEmpty().WithMessage("O título do post é obrigatório.")
                .MaximumLength(45).WithMessage("O título pode ter no máximo 45 caracteres.");

            RuleFor(p => p.Texto)
                .MaximumLength(255).WithMessage("A descrição pode ter no máximo 255 caracteres.");

            RuleFor(p => p.DataPost)
                .NotEmpty().WithMessage("A data do post é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data do post não pode ser no futuro.");

            RuleFor(p => p.Usuario)
                .NotEmpty().WithMessage("O  autor é obrigatório.");

            RuleFor(p => p.Comunidade)
                .NotEmpty().WithMessage("A comunidade é obrigatório.");
        }
    }
}
