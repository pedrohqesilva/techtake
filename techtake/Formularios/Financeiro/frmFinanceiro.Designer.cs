namespace techtake
{
    partial class frmFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceiro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRendaPrat = new System.Windows.Forms.Label();
            this.lblRendaLegs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgRenda = new System.Windows.Forms.DataGridView();
            this.instrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRendaCompleta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbCadAluno = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 434);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta página é destinada a mostrar a \r\nrenda da autoescola.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblRendaPrat);
            this.panel2.Controls.Add(this.lblRendaLegs);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtgRenda);
            this.panel2.Controls.Add(this.lblRendaCompleta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 319);
            this.panel2.TabIndex = 1;
            // 
            // lblRendaPrat
            // 
            this.lblRendaPrat.BackColor = System.Drawing.Color.Transparent;
            this.lblRendaPrat.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblRendaPrat.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRendaPrat.Location = new System.Drawing.Point(142, 117);
            this.lblRendaPrat.Name = "lblRendaPrat";
            this.lblRendaPrat.Size = new System.Drawing.Size(91, 18);
            this.lblRendaPrat.TabIndex = 12;
            this.lblRendaPrat.Text = "R$ 0,00";
            this.lblRendaPrat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRendaLegs
            // 
            this.lblRendaLegs.BackColor = System.Drawing.Color.Transparent;
            this.lblRendaLegs.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblRendaLegs.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRendaLegs.Location = new System.Drawing.Point(142, 99);
            this.lblRendaLegs.Name = "lblRendaLegs";
            this.lblRendaLegs.Size = new System.Drawing.Size(91, 18);
            this.lblRendaLegs.TabIndex = 11;
            this.lblRendaLegs.Text = "R$ 0,00";
            this.lblRendaLegs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(68, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Legislação:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(91, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prática:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Renda por tipo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Renda por instrutor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgRenda
            // 
            this.dtgRenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instrutor,
            this.valor});
            this.dtgRenda.Location = new System.Drawing.Point(11, 177);
            this.dtgRenda.Name = "dtgRenda";
            this.dtgRenda.ReadOnly = true;
            this.dtgRenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgRenda.Size = new System.Drawing.Size(249, 128);
            this.dtgRenda.TabIndex = 6;
            // 
            // instrutor
            // 
            this.instrutor.HeaderText = "Nome";
            this.instrutor.Name = "instrutor";
            this.instrutor.ReadOnly = true;
            this.instrutor.Width = 140;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 66;
            // 
            // lblRendaCompleta
            // 
            this.lblRendaCompleta.BackColor = System.Drawing.Color.Transparent;
            this.lblRendaCompleta.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblRendaCompleta.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRendaCompleta.Location = new System.Drawing.Point(63, 38);
            this.lblRendaCompleta.Name = "lblRendaCompleta";
            this.lblRendaCompleta.Size = new System.Drawing.Size(144, 25);
            this.lblRendaCompleta.TabIndex = 5;
            this.lblRendaCompleta.Text = "R$ 0,00";
            this.lblRendaCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Renda completa do mês:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbCadAluno
            // 
            this.pcbCadAluno.BackColor = System.Drawing.Color.Transparent;
            this.pcbCadAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbCadAluno.Image = ((System.Drawing.Image)(resources.GetObject("pcbCadAluno.Image")));
            this.pcbCadAluno.Location = new System.Drawing.Point(17, 9);
            this.pcbCadAluno.Name = "pcbCadAluno";
            this.pcbCadAluno.Size = new System.Drawing.Size(291, 55);
            this.pcbCadAluno.TabIndex = 2;
            this.pcbCadAluno.TabStop = false;
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(325, 485);
            this.Controls.Add(this.pcbCadAluno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbCadAluno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRendaPrat;
        private System.Windows.Forms.Label lblRendaLegs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgRenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Label lblRendaCompleta;
        private System.Windows.Forms.Label label3;
    }
}