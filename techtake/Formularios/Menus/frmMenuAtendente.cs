using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace techtake
{
    public partial class frmMenuAtendente : Form
    {
        BLL_Pessoa objPessoa = new BLL_Pessoa();
        string Log = "sim";

        public frmMenuAtendente()
        {
            InitializeComponent();
            lblNome.Text = "Bem vindo, " + BLL_Pessoa.nomeLogado;
            
            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
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
        #region Mudar cor dos botões
        #region Mudar a cor do botão NovoAluno
        private void btnAddAluno_MouseEnter(object sender, EventArgs e)
        { btnAddAluno.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAddAluno2.png"); }

        private void btnAddAluno_MouseLeave(object sender, EventArgs e)
        { btnAddAluno.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAddAluno1.png"); }
        #endregion
        #region Mudar a cor do botão RegistrarAula
        private void btnAddAula_MouseEnter(object sender, EventArgs e)
        { btnAddAula.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAddAula2.png"); }

        private void btnAddAula_MouseLeave(object sender, EventArgs e)
        { btnAddAula.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAddAula1.png"); }
        #endregion
        #region Mudar a cor do botão Registros
        private void btnRegistros_MouseEnter(object sender, EventArgs e)
        { btnRegistros.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoRegistros2.png"); }

        private void btnRegistros_MouseLeave(object sender, EventArgs e)
        { btnRegistros.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoRegistros1.png"); }
        #endregion
        #endregion
        #region Label Logout
        private void lblLogout_MouseEnter(object sender, EventArgs e)
        { lblLogout.Font = new Font("Calibri Light", 9, FontStyle.Underline); }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        { lblLogout.Font = new Font("Calibri Light", 9, FontStyle.Regular); }
        #endregion

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            frmAdicionarPessoa.Modo = "Cadastrar";
            frmAdicionarPessoa.VarTitulo = "Aluno";

            frmAdicionarPessoa AddAluno = new frmAdicionarPessoa();
            AddAluno.Show();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            frmPesquisarAlunos.TipoDeFuncionario = "Atendente";

            frmMenuAtendenteRegistros mRegistros = new frmMenuAtendenteRegistros();
            mRegistros.Show();
        }

        private void btnAddAula_Click(object sender, EventArgs e)
        {
            frmMenuAtendenteAula mAula = new frmMenuAtendenteAula();
            mAula.Show();
        }

        private void frmMenuGerente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Log == "sim")
                Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Log = "nao";

            frmLogin Login = new frmLogin();
            Login.Show();
            this.Close();

            Log = "sim";
        }
    }
}
