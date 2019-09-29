using FluentValidation;
using IntranetCPT.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Servicos.Validacoes
{
    public class ManuaisValidation : AbstractValidator<Tb_Manuais>
    {
        public ManuaisValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Titulo é obrigatório.")
                .NotNull().WithMessage("Titulo é obrigatório.");

            RuleFor(c => c.Arquivo)
                .NotEmpty().WithMessage("Arquivo é obrigatório.")
                .NotNull().WithMessage("Arquivo é obrigatório.");
        }
    }
}
