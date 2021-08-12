using Entidade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.Validação
{
    public class ValidacaoUsuario : AbstractValidator<UsuarioUm>
    {
        public ValidacaoUsuario() 
        {
            RuleFor(x => x.Nome).NotEmpty().MinimumLength(2).MaximumLength(60);
            RuleFor(x => x.Login).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(x => x.Senha).NotEmpty().NotNull().MinimumLength(2).MaximumLength(20);
        }

    }
}
