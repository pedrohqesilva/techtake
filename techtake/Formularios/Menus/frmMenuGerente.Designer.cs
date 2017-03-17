namespace techtake
{
    partial class frmMenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuGerente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnAddInstrutor = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbLogo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 352);
            this.panel1.TabIndex = 1;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogout.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Transparent;
            this.lblLogout.Location = new System.Drawing.Point(533, 3);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(54, 23);
            this.lblLogout.TabIndex = 7;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegistros);
            this.panel2.Controls.Add(this.btnRelatorios);
            this.panel2.Controls.Add(this.btnAddInstrutor);
            this.panel2.Location = new System.Drawing.Point(16, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 195);
            this.panel2.TabIndex = 6;
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistros.BackgroundImage")));
            this.btnRegistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Location = new System.Drawing.Point(380, 10);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(175, 175);
            this.btnRegistros.TabIndex = 3;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            this.btnRegistros.MouseEnter += new System.EventHandler(this.btnRegistros_MouseEnter);
            this.btnRegistros.MouseLeave += new System.EventHandler(this.btnRegistros_MouseLeave);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.BackgroundImage")));
            this.btnRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Location = new System.Drawing.Point(194, 10);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(175, 175);
            this.btnRelatorios.TabIndex = 2;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            this.btnRelatorios.MouseEnter += new System.EventHandler(this.btnRelatorios_MouseEnter);
            this.btnRelatorios.MouseLeave += new System.EventHandler(this.btnRelatorios_MouseLeave);
            // 
            // btnAddInstrutor
            // 
            this.btnAddInstrutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddInstrutor.BackgroundImage")));
            this.btnAddInstrutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddInstrutor.FlatAppearance.BorderSize = 0;
            this.btnAddInstrutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstrutor.Location = new System.Drawing.Point(9, 10);
            this.btnAddInstrutor.Name = "btnAddInstrutor";
            this.btnAddInstrutor.Size = new System.Drawing.Size(175, 175);
            this.btnAddInstrutor.TabIndex = 1;
            this.btnAddInstrutor.UseVisualStyleBackColor = true;
            this.btnAddInstrutor.Click += new System.EventHandler(this.btnAddInstrutor_Click);
            this.btnAddInstrutor.MouseEnter += new System.EventHandler(this.btnAddInstrutor_MouseEnter);
            this.btnAddInstrutor.MouseLeave += new System.EventHandler(this.btnAddInstrutor_MouseLeave);
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(0, 326);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(593, 22);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "teste";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbLogo.BackgroundImage")));
            this.pcbLogo.Location = new System.Drawing.Point(196, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(200, 100);
            this.pcbLogo.TabIndex = 7;
            this.pcbLogo.TabStop = false;
            // 
            // frmMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 376);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuGerente_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnAddInstrutor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblLogout;
    }
}