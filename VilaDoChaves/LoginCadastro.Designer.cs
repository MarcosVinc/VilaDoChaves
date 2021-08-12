
namespace VilaDoChaves
{
    partial class LoginCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plCadastro = new System.Windows.Forms.Panel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadastroNome = new System.Windows.Forms.TextBox();
            this.txtCadastroLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastro = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.plCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // plCadastro
            // 
            this.plCadastro.Controls.Add(this.siticoneControlBox1);
            this.plCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.plCadastro.Location = new System.Drawing.Point(0, 0);
            this.plCadastro.Name = "plCadastro";
            this.plCadastro.Size = new System.Drawing.Size(352, 30);
            this.plCadastro.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Green;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(304, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // txtCadastroNome
            // 
            this.txtCadastroNome.Location = new System.Drawing.Point(66, 46);
            this.txtCadastroNome.Name = "txtCadastroNome";
            this.txtCadastroNome.Size = new System.Drawing.Size(264, 20);
            this.txtCadastroNome.TabIndex = 2;
            // 
            // txtCadastroLogin
            // 
            this.txtCadastroLogin.Location = new System.Drawing.Point(66, 80);
            this.txtCadastroLogin.Name = "txtCadastroLogin";
            this.txtCadastroLogin.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOGIN";
            // 
            // btCadastro
            // 
            this.btCadastro.BorderRadius = 12;
            this.btCadastro.CheckedState.Parent = this.btCadastro;
            this.btCadastro.CustomImages.Parent = this.btCadastro;
            this.btCadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCadastro.DisabledState.Parent = this.btCadastro;
            this.btCadastro.FillColor = System.Drawing.Color.Green;
            this.btCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCadastro.ForeColor = System.Drawing.Color.White;
            this.btCadastro.HoverState.Parent = this.btCadastro;
            this.btCadastro.Location = new System.Drawing.Point(216, 129);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.ShadowDecoration.Parent = this.btCadastro;
            this.btCadastro.Size = new System.Drawing.Size(133, 27);
            this.btCadastro.TabIndex = 5;
            this.btCadastro.Text = "CADASTRAR";
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Location = new System.Drawing.Point(230, 80);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroSenha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(177, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SENHA ";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.plCadastro;
            // 
            // LoginCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(352, 168);
            this.Controls.Add(this.txtCadastroSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.txtCadastroLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadastroNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginCadastro";
            this.plCadastro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plCadastro;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCadastroNome;
        private System.Windows.Forms.TextBox txtCadastroLogin;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton btCadastro;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}