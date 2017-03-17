using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techtake
{
    public partial class frmRelAluno : Form
    {
        public frmRelAluno()
        {
            InitializeComponent();
            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void frmRelAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'techtakeDataSet.relaula30d'. Você pode movê-la ou removê-la conforme necessário.
            this.relaula30dTableAdapter.Fill(this.techtakeDataSet.relaula30d);
            // TODO: esta linha de código carrega dados na tabela 'techtakeDataSet.relinstrutor30d'. Você pode movê-la ou removê-la conforme necessário.
            this.relinstrutor30dTableAdapter.Fill(this.techtakeDataSet.relinstrutor30d);
            // TODO: esta linha de código carrega dados na tabela 'techtakeDataSet.relinstrutor'. Você pode movê-la ou removê-la conforme necessário.
            this.relinstrutorTableAdapter.Fill(this.techtakeDataSet.relinstrutor);
            // TODO: esta linha de código carrega dados na tabela 'techtakeDataSet.relaluno30d'. Você pode movê-la ou removê-la conforme necessário.
            this.relaluno30dTableAdapter.Fill(this.techtakeDataSet.relaluno30d);
            // TODO: esta linha de código carrega dados na tabela 'techtakeDataSet.relaluno'. Você pode movê-la ou removê-la conforme necessário.
            this.relalunoTableAdapter.Fill(this.techtakeDataSet.relaluno);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        #region Não permitir o redimensionamento
        //Método que bloqueia o redimensionamento do formulário, deixando-o sempre em fullscreen.
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0112: // Esse é o codigo de uma mensagem referente a barra de titulo do formulario
                    int command = m.WParam.ToInt32() & 0xfff0;
                    // 0xF010 eh o codigo do comando "Restore" 
                    // 0xF120 eh o Duplo Clique da Barra
                    if ((new int[] { 0xF010, 0xF120 }).Contains(command))
                    {
                        // Se for executado qq um desses casos ignorar o comando (nao passar para o windows) ao menos q o form esteje minimizado.. ai continua...
                        if (this.WindowState != FormWindowState.Minimized) return;
                    }
                    break;
            }

            base.WndProc(ref m);
        }
        #endregion
    }
}
