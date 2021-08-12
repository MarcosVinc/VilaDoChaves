using Entidade;
using FluentValidation.Results;
using Repositorio;
using Serviços.Validação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VilaDoChaves
{
    public partial class LoginCadastro : Form
    {
        public LoginCadastro()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            var user = new UsuarioUm();
            var repositorio = new RepositorioUsuario();
            user.Nome = txtCadastroNome.Text;
            user.Senha = txtCadastroSenha.Text;
            user.Login = txtCadastroLogin.Text;

            ValidacaoUsuario validacao = new ValidacaoUsuario();
            ValidationResult x = validacao.Validate(user);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {
                    MessageBox.Show($"Mensagem do erro : {failure.ErrorMessage}");

                }
            }
            else
            {
                repositorio.Salvar(user);
                MessageBox.Show(repositorio.mensagem);
                this.Close();
                LoginTela tl = new LoginTela();
                tl.Show();
            }
        }
    }
}
