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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void panel7_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            ChatTela ct = new ChatTela();
            ct.Show();
            ct.picCHAT.Image = pictureBox4.Image;
            ct.txtChat.Text = "KIKO o mas lindo de todos chegou!";
        }

    }
}
