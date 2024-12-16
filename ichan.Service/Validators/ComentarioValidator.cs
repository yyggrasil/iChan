using FluentValidation;
using ichan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichan.Service.Validators
{
    public class ComentarioValidator : AbstractValidator<Comentario>
    {
        public ComentarioValidator()
        {
            RuleFor(c => c.Texto)
                .NotEmpty().WithMessage("O texto do comentário é obrigatório.")
                .MaximumLength(255).WithMessage("O texto pode ter no máximo 255 caracteres.");

            RuleFor(c => c.DateComentario)
                .NotEmpty().WithMessage("A data do comentário é obrigatória.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("A data do comentário não pode ser no futuro.");

            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("O autor é obrigatório.");

            RuleFor(c => c.Post)
                .NotEmpty().WithMessage("O post é obrigatório.");
        }
    }
}
