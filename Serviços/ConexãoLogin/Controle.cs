using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.ConexãoLogin
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(string logim, string senha)
        {
            LoginComando logimComando = new LoginComando();
            tem = logimComando.verificarLogin(logim, senha);

            if (!logimComando.mensagem.Equals(""))
            {
                this.mensagem = logimComando.mensagem;

            }
            return tem;
        }

    }
}
