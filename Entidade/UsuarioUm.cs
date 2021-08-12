using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class UsuarioUm
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public UsuarioUm(string nome, string senha, string login) 
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }
        public UsuarioUm() 
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
