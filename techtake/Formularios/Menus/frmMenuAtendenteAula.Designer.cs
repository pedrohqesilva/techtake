namespace techtake
{
    partial class frmMenuAtendenteAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAtendenteAula));
            this.btnLegislacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPratica = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLegislacao
            // 
            this.btnLegislacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLegislacao.BackgroundImage")));
            this.btnLegislacao.FlatAppearance.BorderSize = 0;
            this.btnLegislacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegislacao.Location = new System.Drawing.Point(14, 14);
            this.btnLegislacao.Name = "btnLegislacao";
            this.btnLegislacao.Size = new System.Drawing.Size(170, 73);
            this.btnLegislacao.TabIndex = 0;
            this.btnLegislacao.Text = " ";
            this.btnLegislacao.UseVisualStyleBackColor = true;
            this.btnLegislacao.Click += new System.EventHandler(this.btnLegislacao_Click);
            this.btnLegislacao.MouseEnter += new System.EventHandler(this.btnLegislacao_MouseEnter);
            this.btnLegislacao.MouseLeave += new System.EventHandler(this.btnLegislacao_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPratica);
            this.panel1.Controls.Add(this.btnLegislacao);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 184);
            this.panel1.TabIndex = 1;
            // 
            // btnPratica
            // 
            this.btnPratica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPratica.BackgroundImage")));
            this.btnPratica.FlatAppearance.BorderSize = 0;
            this.btnPratica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPratica.Location = new System.Drawing.Point(14, 93);
            this.btnPratica.Name = "btnPratica";
            this.btnPratica.Size = new System.Drawing.Size(170, 73);
            this.btnPratica.TabIndex = 1;
            this.btnPratica.Text = " ";
            this.btnPratica.UseVisualStyleBackColor = true;
            this.btnPratica.Click += new System.EventHandler(this.btnPratica_Click);
            this.btnPratica.MouseEnter += new System.EventHandler(this.btnPratica_MouseEnter);
            this.btnPratica.MouseLeave += new System.EventHandler(this.btnPratica_MouseLeave);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(-3, -4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(5, 5);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenuAtendenteAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(221, 208);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuAtendenteAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.Deactivate += new System.EventHandler(this.frmMenuAtendenteAula_Deactivate);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLegislacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPratica;
        private System.Windows.Forms.Button btnSair;
    }
}