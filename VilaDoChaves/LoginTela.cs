using Entidade;
using Serviços.ConexãoLogin;
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
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginCadastro lg = new LoginCadastro();
            lg.Show();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var usuario = new UsuarioUm();
                    usuario.Login = txtLogin.Text;
                    usuario.Senha = txtSenha.Text;
                    TelaInicial ti = new TelaInicial();
                    this.Hide();
                    ti.Show();
                }
                else
                {
                    MessageBox.Show("Logim ou senha estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
