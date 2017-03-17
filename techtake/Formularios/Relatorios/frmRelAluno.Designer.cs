namespace techtake
{
    partial class frmRelAluno
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelAluno));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.relalunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techtakeDataSet = new techtake.techtakeDataSet();
            this.relaluno30dBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relaula30dBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relinstrutor30dBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relinstrutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relalunoTableAdapter = new techtake.techtakeDataSetTableAdapters.relalunoTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relaluno30dTableAdapter = new techtake.techtakeDataSetTableAdapters.relaluno30dTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.relinstrutorTableAdapter = new techtake.techtakeDataSetTableAdapters.relinstrutorTableAdapter();
            this.relinstrutor30dTableAdapter = new techtake.techtakeDataSetTableAdapters.relinstrutor30dTableAdapter();
            this.relaula30dTableAdapter = new techtake.techtakeDataSetTableAdapters.relaula30dTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relalunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techtakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaluno30dBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaula30dBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relinstrutor30dBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relinstrutorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // relalunoBindingSource
            // 
            this.relalunoBindingSource.DataMember = "relaluno";
            this.relalunoBindingSource.DataSource = this.techtakeDataSet;
            // 
            // techtakeDataSet
            // 
            this.techtakeDataSet.DataSetName = "techtakeDataSet";
            this.techtakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relaluno30dBindingSource
            // 
            this.relaluno30dBindingSource.DataMember = "relaluno30d";
            this.relaluno30dBindingSource.DataSource = this.techtakeDataSet;
            // 
            // relaula30dBindingSource
            // 
            this.relaula30dBindingSource.DataMember = "relaula30d";
            this.relaula30dBindingSource.DataSource = this.techtakeDataSet;
            // 
            // relinstrutor30dBindingSource
            // 
            this.relinstrutor30dBindingSource.DataMember = "relinstrutor30d";
            this.relinstrutor30dBindingSource.DataSource = this.techtakeDataSet;
            // 
            // relinstrutorBindingSource
            // 
            this.relinstrutorBindingSource.DataMember = "relinstrutor";
            this.relinstrutorBindingSource.DataSource = this.techtakeDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.relalunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "techtake.Formularios.Relatorios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(574, 140);
            this.reportViewer1.TabIndex = 0;
            // 
            // relalunoTableAdapter
            // 
            this.relalunoTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(559, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 32);
            this.label14.TabIndex = 10;
            this.label14.Text = "RELATÓRIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Todos os alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alunos cadastrados nos últimos 30 dias:";
            // 
            // reportViewer2
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.relaluno30dBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "techtake.Formularios.Relatorios.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(13, 211);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(574, 140);
            this.reportViewer2.TabIndex = 13;
            // 
            // relaluno30dTableAdapter
            // 
            this.relaluno30dTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 648);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(942, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 167);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(58, 453);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 194);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(594, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Aulas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(880, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Instrutores";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.reportViewer6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(329, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 194);
            this.panel4.TabIndex = 17;
            // 
            // reportViewer6
            // 
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.relaula30dBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "techtake.Formularios.Relatorios.Report5.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(13, 39);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.Size = new System.Drawing.Size(574, 140);
            this.reportViewer6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(190, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Aulas dos últimos 30 dias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(277, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Alunos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.reportViewer3);
            this.panel3.Controls.Add(this.reportViewer4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(640, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 368);
            this.panel3.TabIndex = 16;
            // 
            // reportViewer3
            // 
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.relinstrutor30dBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "techtake.Formularios.Relatorios.Report4.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(13, 211);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(574, 140);
            this.reportViewer3.TabIndex = 13;
            // 
            // reportViewer4
            // 
            reportDataSource10.Name = "DataSet1";
            reportDataSource10.Value = this.relinstrutorBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "techtake.Formularios.Relatorios.Report3.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(13, 39);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(574, 140);
            this.reportViewer4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Instrutores cadastrados nos últimos 30 dias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Todos os instrutores:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reportViewer2);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 368);
            this.panel2.TabIndex = 15;
            // 
            // relinstrutorTableAdapter
            // 
            this.relinstrutorTableAdapter.ClearBeforeFill = true;
            // 
            // relinstrutor30dTableAdapter
            // 
            this.relinstrutor30dTableAdapter.ClearBeforeFill = true;
            // 
            // relaula30dTableAdapter
            // 
            this.relaula30dTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1291, 689);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tech&take";
            this.Load += new System.EventHandler(this.frmRelAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relalunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techtakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaluno30dBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relaula30dBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relinstrutor30dBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relinstrutorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relalunoBindingSource;
        private techtakeDataSet techtakeDataSet;
        private techtakeDataSetTableAdapters.relalunoTableAdapter relalunoTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource relaluno30dBindingSource;
        private techtakeDataSetTableAdapters.relaluno30dTableAdapter relaluno30dTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource relinstrutorBindingSource;
        private techtakeDataSetTableAdapters.relinstrutorTableAdapter relinstrutorTableAdapter;
        private System.Windows.Forms.BindingSource relinstrutor30dBindingSource;
        private techtakeDataSetTableAdapters.relinstrutor30dTableAdapter relinstrutor30dTableAdapter;
        private System.Windows.Forms.BindingSource relaula30dBindingSource;
        private techtakeDataSetTableAdapters.relaula30dTableAdapter relaula30dTableAdapter;
    }
}