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
    public partial class frmMenuAtendenteAula : Form
    {
        public frmMenuAtendenteAula()
        {
            InitializeComponent();
        }

        private void btnLegislacao_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdicionarLegislacao addLeg = new frmAdicionarLegislacao();
            addLeg.Show();
        }
        private void btnPratica_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdicionarPratica addPrat = new frmAdicionarPratica();
            addPrat.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region Mudar cor dos botões
        #region Mudar a cor do botão NovoAluno
        private void btnLegislacao_MouseEnter(object sender, EventArgs e)
        { btnLegislacao.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLegislativa2.png"); }

        private void btnLegislacao_MouseLeave(object sender, EventArgs e)
        { btnLegislacao.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLegislativa1.png"); }
        #endregion
        #region Mudar a cor do botão RegistrarAula
        private void btnPratica_MouseEnter(object sender, EventArgs e)
        { btnPratica.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoPratica2.png"); }

        private void btnPratica_MouseLeave(object sender, EventArgs e)
        { btnPratica.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoPratica1.png"); }
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

        private void frmMenuAtendenteAula_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
