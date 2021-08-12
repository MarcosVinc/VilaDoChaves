
namespace VilaDoChaves
{
    partial class ChatTela
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
            this.picCHAT = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCHAT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCHAT
            // 
            this.picCHAT.Location = new System.Drawing.Point(22, 14);
            this.picCHAT.Name = "picCHAT";
            this.picCHAT.Size = new System.Drawing.Size(100, 104);
            this.picCHAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCHAT.TabIndex = 0;
            this.picCHAT.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtChat);
            this.panel1.Location = new System.Drawing.Point(184, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 198);
            this.panel1.TabIndex = 1;
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.Window;
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChat.Location = new System.Drawing.Point(0, 0);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtChat.Size = new System.Drawing.Size(587, 198);
            this.txtChat.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.picCHAT);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 126);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.picUser);
            this.panel3.Location = new System.Drawing.Point(629, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 126);
            this.panel3.TabIndex = 3;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(22, 14);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 104);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUser);
            this.panel4.Location = new System.Drawing.Point(12, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(587, 198);
            this.panel4.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Location = new System.Drawing.Point(0, 0);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(587, 198);
            this.txtUser.TabIndex = 0;
            // 
            // ChatTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 487);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChatTela";
            this.Text = "ChatTela";
            ((System.ComponentModel.ISupportInitialize)(this.picCHAT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picCHAT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtChat;
    }
}