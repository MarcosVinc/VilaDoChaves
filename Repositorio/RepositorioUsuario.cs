using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioUsuario
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";
        public void Salvar(UsuarioUm usuario)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Usuario values(@ID, @Nome,@Logim,@Senha)";
            //parametros
            cmd.Parameters.AddWithValue("@ID", usuario.ID);
            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Logim", usuario.Login);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Usuario Cadastrado!";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
    }
    
}
