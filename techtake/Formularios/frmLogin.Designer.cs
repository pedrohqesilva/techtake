namespace techtake
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnAddNovoUsuario = new System.Windows.Forms.Button();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.btnEntrarEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbLogo.BackgroundImage")));
            this.pcbLogo.Location = new System.Drawing.Point(62, -2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(200, 100);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(34, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(218, 26);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(34, 152);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(218, 26);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.btnAddNovoUsuario);
            this.panel1.Controls.Add(this.lblEsqueciSenha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(18, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 285);
            this.panel1.TabIndex = 6;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(88, 212);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(110, 30);
            this.btnEntrar.TabIndex = 18;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseEnter += new System.EventHandler(this.btnEntrar_MouseEnter);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            // 
            // btnAddNovoUsuario
            // 
            this.btnAddNovoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNovoUsuario.BackgroundImage")));
            this.btnAddNovoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNovoUsuario.FlatAppearance.BorderSize = 0;
            this.btnAddNovoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNovoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNovoUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNovoUsuario.Location = new System.Drawing.Point(259, 257);
            this.btnAddNovoUsuario.Name = "btnAddNovoUsuario";
            this.btnAddNovoUsuario.Size = new System.Drawing.Size(25, 25);
            this.btnAddNovoUsuario.TabIndex = 7;
            this.btnAddNovoUsuario.UseVisualStyleBackColor = true;
            this.btnAddNovoUsuario.Click += new System.EventHandler(this.btnAddNovoUsuario_Click);
            this.btnAddNovoUsuario.MouseEnter += new System.EventHandler(this.btnAddNovoUsuario_MouseEnter);
            this.btnAddNovoUsuario.MouseLeave += new System.EventHandler(this.btnAddNovoUsuario_MouseLeave);
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblEsqueciSenha.Location = new System.Drawing.Point(85, 257);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(116, 15);
            this.lblEsqueciSenha.TabIndex = 6;
            this.lblEsqueciSenha.Text = "Esqueci minha senha";
            this.lblEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEsqueciSenha.Click += new System.EventHandler(this.lblEsqueciSenha_Click);
            this.lblEsqueciSenha.MouseEnter += new System.EventHandler(this.lblEsqueciSenha_MouseEnter);
            this.lblEsqueciSenha.MouseLeave += new System.EventHandler(this.lblEsqueciSenha_MouseLeave);
            // 
            // btnEntrarEnter
            // 
            this.btnEntrarEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrarEnter.BackgroundImage")));
            this.btnEntrarEnter.FlatAppearance.BorderSize = 0;
            this.btnEntrarEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarEnter.Location = new System.Drawing.Point(-5, -4);
            this.btnEntrarEnter.Name = "btnEntrarEnter";
            this.btnEntrarEnter.Size = new System.Drawing.Size(5, 5);
            this.btnEntrarEnter.TabIndex = 9;
            this.btnEntrarEnter.UseVisualStyleBackColor = true;
            this.btnEntrarEnter.Click += new System.EventHandler(this.btnEntrarEnter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-2, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Versão 1.0.5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEntrarEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEntrarEnter);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private System.Windows.Forms.Button btnAddNovoUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEntrarEnter;
        private System.Windows.Forms.Label label3;
    }
}

