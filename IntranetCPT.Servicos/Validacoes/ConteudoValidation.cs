using FluentValidation;
using IntranetCPT.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntranetCPT.Servicos.Validacoes
{
    public class ConteudoValidation : AbstractValidator<Tb_Conteudo>
    {
        public ConteudoValidation()
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

            RuleFor(c => c.Introducao)
                .NotEmpty().WithMessage("Introducao é obrigatório.")
                .NotNull().WithMessage("Introducao é obrigatório.");

            RuleFor(c => c.Conteudo)
                .NotEmpty().WithMessage("Conteudo é obrigatório.")
                .NotNull().WithMessage("Conteudo é obrigatório.");
        }
    }
}
