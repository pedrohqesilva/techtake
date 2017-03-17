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
    public partial class frmMenuAtendenteRegistros : Form
    {
        public frmMenuAtendenteRegistros()
        {
            InitializeComponent();

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPesquisarAlunos pAlunos = new frmPesquisarAlunos();
            pAlunos.Show();
        }
        private void btnAulas_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPesquisarAula pAula = new frmPesquisarAula();
            pAula.Show();
        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFinanceiro Financeiro = new frmFinanceiro();
            Financeiro.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cor dos Botoes
        #region Mudar a cor do botão Aluno
        private void btnAlunos_MouseEnter(object sender, EventArgs e)
        { btnAlunos.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAluno2.png"); }

        private void btnAlunos_MouseLeave(object sender, EventArgs e)
        { btnAlunos.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAluno1.png"); }
        #endregion
        #region Mudar a cor do botão Aula
        private void btnAulas_MouseEnter(object sender, EventArgs e)
        { btnAulas.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAula2.png"); }

        private void btnAulas_MouseLeave(object sender, EventArgs e)
        { btnAulas.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAula1.png"); }
        #endregion
        #region Mudar a cor do botão Financeiro
        private void btnFinanceiro_MouseEnter(object sender, EventArgs e)
        { btnFinanceiro.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoFinanceiro2.png"); }

        private void btnFinanceiro_MouseLeave(object sender, EventArgs e)
        { btnFinanceiro.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoFinanceiro1.png"); }
        #endregion
        #endregion
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

        private void frmMenuAtendenteRegistros_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
