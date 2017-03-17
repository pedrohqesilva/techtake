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
    public partial class frmAdicionarUsuario : Form
    {
        BLL_Pessoa objPessoa = new BLL_Pessoa();

        public frmAdicionarUsuario()
        {
            InitializeComponent();

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        #region Mudar a cor do botão
        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        { btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoCadastrar2.png"); }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        { btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoCadastrar1.png"); }
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

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (txtMatricula.TextLength != 10)
            {
                pcbErrado.Visible = true;
                pcbCerto.Visible = false;
            }

            if (txtMatricula.TextLength == 10)
            {
                if (objPessoa.TestarMatricula(txtMatricula.Text) == true)
                {
                    pcbErrado.Visible = false;
                    pcbCerto.Visible = true;
                }
            }
        }
        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {
            int TamanhoSenha = txtSenha.TextLength;

            if (txtSenha2.TextLength != TamanhoSenha)
            {
                pcbErrado2.Visible = true;
                pcbCerto2.Visible = false;
            }

            if (txtSenha2.TextLength == TamanhoSenha && txtSenha2.Text == txtSenha.Text)
            {
                pcbErrado2.Visible = false;
                pcbCerto2.Visible = true;
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatricula.Text != "" || pcbCerto.Visible == true && pcbErrado.Visible == false)
                {
                    if (txtSenha2.Text != "" && pcbCerto2.Visible == true && pcbErrado2.Visible == false)
                    {
                        objPessoa.Login = txtUsuario.Text;
                        objPessoa.Senha = txtSenha.Text;
                        objPessoa.Email = txtEmail.Text;
                        objPessoa.PerguntaSecreta = cbxPergunta.Text;
                        objPessoa.RespostaSecreta = cbxResposta.Text;
                        
                        objPessoa.InserirUsuario((txtMatricula.Text).ToUpper(), objPessoa.TestarID(txtMatricula.Text));
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
}

        
    }
}
