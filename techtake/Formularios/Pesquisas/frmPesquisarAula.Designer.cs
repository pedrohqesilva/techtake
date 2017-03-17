namespace techtake
{
    partial class frmPesquisarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarAula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtgPesquisa2 = new System.Windows.Forms.DataGridView();
            this.Cod2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeInstrutor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPesquisa1 = new System.Windows.Forms.DataGridView();
            this.Cod1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeInstrutor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtgPesquisa2);
            this.panel1.Controls.Add(this.dtgPesquisa1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 416);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prática:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Legislativa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(195, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 26);
            this.label14.TabIndex = 9;
            this.label14.Text = "Registro de aulas marcadas:";
            // 
            // dtgPesquisa2
            // 
            this.dtgPesquisa2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPesquisa2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod2,
            this.data2,
            this.hora2,
            this.valor2,
            this.nomeInstrutor2,
            this.nomeAluno2});
            this.dtgPesquisa2.Location = new System.Drawing.Point(15, 267);
            this.dtgPesquisa2.Name = "dtgPesquisa2";
            this.dtgPesquisa2.ReadOnly = true;
            this.dtgPesquisa2.Size = new System.Drawing.Size(681, 134);
            this.dtgPesquisa2.TabIndex = 15;
            // 
            // Cod2
            // 
            this.Cod2.HeaderText = "Cod.";
            this.Cod2.Name = "Cod2";
            this.Cod2.ReadOnly = true;
            this.Cod2.Visible = false;
            // 
            // data2
            // 
            this.data2.HeaderText = "Data";
            this.data2.Name = "data2";
            this.data2.ReadOnly = true;
            // 
            // hora2
            // 
            this.hora2.HeaderText = "Hora";
            this.hora2.Name = "hora2";
            this.hora2.ReadOnly = true;
            // 
            // valor2
            // 
            this.valor2.HeaderText = "Valor";
            this.valor2.Name = "valor2";
            this.valor2.ReadOnly = true;
            // 
            // nomeInstrutor2
            // 
            this.nomeInstrutor2.HeaderText = "Nome do Instrutor";
            this.nomeInstrutor2.Name = "nomeInstrutor2";
            this.nomeInstrutor2.ReadOnly = true;
            // 
            // nomeAluno2
            // 
            this.nomeAluno2.HeaderText = "Nome do Aluno";
            this.nomeAluno2.Name = "nomeAluno2";
            this.nomeAluno2.ReadOnly = true;
            // 
            // dtgPesquisa1
            // 
            this.dtgPesquisa1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgPesquisa1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod1,
            this.materia1,
            this.data1,
            this.hora1,
            this.valor1,
            this.nomeInstrutor1,
            this.nomeAluno1});
            this.dtgPesquisa1.Location = new System.Drawing.Point(15, 93);
            this.dtgPesquisa1.Name = "dtgPesquisa1";
            this.dtgPesquisa1.ReadOnly = true;
            this.dtgPesquisa1.Size = new System.Drawing.Size(681, 135);
            this.dtgPesquisa1.TabIndex = 11;
            // 
            // Cod1
            // 
            this.Cod1.HeaderText = "Cod.";
            this.Cod1.Name = "Cod1";
            this.Cod1.ReadOnly = true;
            this.Cod1.Visible = false;
            // 
            // materia1
            // 
            this.materia1.HeaderText = "Matéria";
            this.materia1.Name = "materia1";
            this.materia1.ReadOnly = true;
            // 
            // data1
            // 
            this.data1.HeaderText = "Data";
            this.data1.Name = "data1";
            this.data1.ReadOnly = true;
            // 
            // hora1
            // 
            this.hora1.HeaderText = "Hora";
            this.hora1.Name = "hora1";
            this.hora1.ReadOnly = true;
            // 
            // valor1
            // 
            this.valor1.HeaderText = "Valor";
            this.valor1.Name = "valor1";
            this.valor1.ReadOnly = true;
            // 
            // nomeInstrutor1
            // 
            this.nomeInstrutor1.HeaderText = "Nome do Instrutor";
            this.nomeInstrutor1.Name = "nomeInstrutor1";
            this.nomeInstrutor1.ReadOnly = true;
            // 
            // nomeAluno1
            // 
            this.nomeAluno1.HeaderText = "Nome do Aluno";
            this.nomeAluno1.Name = "nomeAluno1";
            this.nomeAluno1.ReadOnly = true;
            // 
            // frmPesquisarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisarAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgPesquisa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPesquisa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeInstrutor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeInstrutor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno1;
    }
}