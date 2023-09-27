using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ConsoleApp
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator() 
        {
            RuleFor(cliente => cliente.Nome).NotEmpty().WithName("Nome do Cliente").WithMessage("O {PropertyName} deve ser preenchido");
            RuleFor(cliente => cliente.SobreNome).NotEmpty();
        }
    }
}