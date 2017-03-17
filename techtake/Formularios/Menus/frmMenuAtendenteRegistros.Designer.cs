namespace techtake
{
    partial class frmMenuAtendenteRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAtendenteRegistros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFinanceiro);
            this.panel1.Controls.Add(this.btnAulas);
            this.panel1.Controls.Add(this.btnAlunos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 259);
            this.panel1.TabIndex = 0;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.BackgroundImage")));
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(14, 172);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(170, 73);
            this.btnFinanceiro.TabIndex = 2;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            this.btnFinanceiro.MouseEnter += new System.EventHandler(this.btnFinanceiro_MouseEnter);
            this.btnFinanceiro.MouseLeave += new System.EventHandler(this.btnFinanceiro_MouseLeave);
            // 
            // btnAulas
            // 
            this.btnAulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAulas.BackgroundImage")));
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAulas.Location = new System.Drawing.Point(14, 93);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(170, 73);
            this.btnAulas.TabIndex = 1;
            this.btnAulas.UseVisualStyleBackColor = true;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            this.btnAulas.MouseEnter += new System.EventHandler(this.btnAulas_MouseEnter);
            this.btnAulas.MouseLeave += new System.EventHandler(this.btnAulas_MouseLeave);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlunos.BackgroundImage")));
            this.btnAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Location = new System.Drawing.Point(14, 14);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(170, 73);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            this.btnAlunos.MouseEnter += new System.EventHandler(this.btnAlunos_MouseEnter);
            this.btnAlunos.MouseLeave += new System.EventHandler(this.btnAlunos_MouseLeave);
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
            this.btnSair.TabIndex = 11;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenuAtendenteRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(221, 283);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuAtendenteRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.Deactivate += new System.EventHandler(this.frmMenuAtendenteRegistros_Deactivate);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinanceiro;
    }
}