namespace techtake
{
    partial class frmAdicionarLegislacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarLegislacao));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAluno = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pcbCadAluno = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMateria);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.mskHora);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.cbxProfessor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxAluno);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 345);
            this.panel1.TabIndex = 1;
            // 
            // cbxMateria
            // 
            this.cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Items.AddRange(new object[] {
            "Direção Defensiva",
            "Legislação de Trânsito",
            "Primeiros Socorros",
            "Meio Ambiente",
            "Mecânica"});
            this.cbxMateria.Location = new System.Drawing.Point(29, 75);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(202, 24);
            this.cbxMateria.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Materia:";
            // 
            // mskHora
            // 
            this.mskHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mskHora.Location = new System.Drawing.Point(170, 243);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(54, 22);
            this.mskHora.TabIndex = 5;
            this.mskHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(13, 243);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(131, 22);
            this.dtpData.TabIndex = 4;
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(13, 191);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(234, 24);
            this.cbxProfessor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Professor:";
            // 
            // cbxAluno
            // 
            this.cbxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxAluno.FormattingEnabled = true;
            this.cbxAluno.Location = new System.Drawing.Point(13, 139);
            this.cbxAluno.Name = "cbxAluno";
            this.cbxAluno.Size = new System.Drawing.Size(234, 24);
            this.cbxAluno.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(75, 298);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 30);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // pcbCadAluno
            // 
            this.pcbCadAluno.BackColor = System.Drawing.Color.Transparent;
            this.pcbCadAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbCadAluno.BackgroundImage")));
            this.pcbCadAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbCadAluno.Location = new System.Drawing.Point(35, 6);
            this.pcbCadAluno.Name = "pcbCadAluno";
            this.pcbCadAluno.Size = new System.Drawing.Size(225, 63);
            this.pcbCadAluno.TabIndex = 17;
            this.pcbCadAluno.TabStop = false;
            // 
            // frmAdicionarLegislacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 386);
            this.Controls.Add(this.pcbCadAluno);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdicionarLegislacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pcbCadAluno;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cbxProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAluno;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Label label5;
    }
}