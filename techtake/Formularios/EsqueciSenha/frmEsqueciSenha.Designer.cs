namespace techtake
{
    partial class frmEsqueciSenha_pt1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueciSenha_pt1));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.pcbRecuperarSenha = new System.Windows.Forms.PictureBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pcbErrado2 = new System.Windows.Forms.PictureBox();
            this.pcbCerto2 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecuperarSenha)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbErrado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.txtCpf);
            this.pnl1.Controls.Add(this.pictureBox2);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.txtUsuario);
            this.pnl1.Location = new System.Drawing.Point(12, 33);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(250, 288);
            this.pnl1.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCpf.Location = new System.Drawing.Point(19, 240);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(210, 26);
            this.txtCpf.TabIndex = 9;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 15);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 76);
            this.label3.TabIndex = 8;
            this.label3.Text = "Por favor,\r\ninsira os dados a seguir\r\npara prosseguir com\r\na troca de senha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(19, 176);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 26);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Transparent;
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.label4);
            this.pnl2.Controls.Add(this.panel1);
            this.pnl2.Controls.Add(this.pictureBox1);
            this.pnl2.Controls.Add(this.label5);
            this.pnl2.Controls.Add(this.txtResposta);
            this.pnl2.Controls.Add(this.txtResp);
            this.pnl2.Location = new System.Drawing.Point(12, 33);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(250, 320);
            this.pnl2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resposta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPergunta);
            this.panel1.Location = new System.Drawing.Point(19, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 86);
            this.panel1.TabIndex = 11;
            // 
            // lblPergunta
            // 
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.White;
            this.lblPergunta.Location = new System.Drawing.Point(3, 4);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(202, 82);
            this.lblPergunta.TabIndex = 10;
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 76);
            this.label5.TabIndex = 8;
            this.label5.Text = "Responda corretamente,\r\na pergunta de segurança,\r\npara realizar a troca\r\nde senha" +
    ":\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(0, 0);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 23);
            this.txtResposta.TabIndex = 12;
            // 
            // txtResp
            // 
            this.txtResp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp.Location = new System.Drawing.Point(19, 272);
            this.txtResp.Multiline = true;
            this.txtResp.Name = "txtResp";
            this.txtResp.PasswordChar = '*';
            this.txtResp.Size = new System.Drawing.Size(210, 30);
            this.txtResp.TabIndex = 7;
            this.txtResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResp.TextChanged += new System.EventHandler(this.txtResp_TextChanged);
            // 
            // pcbRecuperarSenha
            // 
            this.pcbRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.pcbRecuperarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbRecuperarSenha.BackgroundImage")));
            this.pcbRecuperarSenha.Location = new System.Drawing.Point(37, 9);
            this.pcbRecuperarSenha.Name = "pcbRecuperarSenha";
            this.pcbRecuperarSenha.Size = new System.Drawing.Size(200, 50);
            this.pcbRecuperarSenha.TabIndex = 10;
            this.pcbRecuperarSenha.TabStop = false;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.pcbErrado2);
            this.pnl3.Controls.Add(this.pcbCerto2);
            this.pnl3.Controls.Add(this.btnSalvar);
            this.pnl3.Controls.Add(this.pictureBox4);
            this.pnl3.Controls.Add(this.label6);
            this.pnl3.Controls.Add(this.txtSenha2);
            this.pnl3.Controls.Add(this.pictureBox5);
            this.pnl3.Controls.Add(this.label7);
            this.pnl3.Controls.Add(this.label8);
            this.pnl3.Controls.Add(this.txtSenha);
            this.pnl3.Location = new System.Drawing.Point(12, 33);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(250, 288);
            this.pnl3.TabIndex = 7;
            // 
            // pcbErrado2
            // 
            this.pcbErrado2.BackColor = System.Drawing.SystemColors.Window;
            this.pcbErrado2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbErrado2.BackgroundImage")));
            this.pcbErrado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbErrado2.Location = new System.Drawing.Point(206, 184);
            this.pcbErrado2.Name = "pcbErrado2";
            this.pcbErrado2.Size = new System.Drawing.Size(18, 18);
            this.pcbErrado2.TabIndex = 22;
            this.pcbErrado2.TabStop = false;
            this.pcbErrado2.Visible = false;
            // 
            // pcbCerto2
            // 
            this.pcbCerto2.BackColor = System.Drawing.SystemColors.Window;
            this.pcbCerto2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCerto2.BackgroundImage")));
            this.pcbCerto2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCerto2.Location = new System.Drawing.Point(206, 184);
            this.pcbCerto2.Name = "pcbCerto2";
            this.pcbCerto2.Size = new System.Drawing.Size(18, 18);
            this.pcbCerto2.TabIndex = 21;
            this.pcbCerto2.TabStop = false;
            this.pcbCerto2.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(69, 234);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 30);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(24, -25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 50);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repita a Senha:";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.Location = new System.Drawing.Point(19, 180);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(210, 26);
            this.txtSenha2.TabIndex = 12;
            this.txtSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha2.TextChanged += new System.EventHandler(this.txtSenha2_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(30, 58);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(188, 15);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Insira a nova senha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(93, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(19, 120);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(210, 26);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEsqueciSenha_pt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 365);
            this.Controls.Add(this.pcbRecuperarSenha);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEsqueciSenha_pt1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRecuperarSenha)).EndInit();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbErrado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtResposta;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.PictureBox pcbRecuperarSenha;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pcbErrado2;
        private System.Windows.Forms.PictureBox pcbCerto2;
    }
}