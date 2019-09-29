using FluentValidation;
using IntranetCPT.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Servicos.Validacoes
{
    public class RamaisValidation : AbstractValidator<Tb_Ramais>
    {
        public RamaisValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Setor)
                .NotEmpty().WithMessage("Setor é obrigatório.")
                .NotNull().WithMessage("Setor é obrigatório.");

            RuleFor(c => c.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório.")
                .NotNull().WithMessage("Telefone é obrigatório.");
        }
    }
}
