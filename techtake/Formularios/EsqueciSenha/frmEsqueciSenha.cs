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
    public partial class frmEsqueciSenha_pt1 : Form
    {
        BLL_Pessoa objPessoa = new BLL_Pessoa();

        public frmEsqueciSenha_pt1()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(290, 374);
            pnl2.Visible = false;
            pnl3.Visible = false;

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            string Cpf, Pt1, Pt2, Pt3, Pt4, CpfFinal;

            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cpf = txtCpf.Text.Replace(" ", "");
            if (txtCpf.Text != "" && Cpf.Length == 11)
            {
                Pt1 = Cpf.Substring(0, 3).ToString();
                Pt2 = Cpf.Substring(3, 3).ToString();
                Pt3 = Cpf.Substring(6, 3).ToString();
                Pt4 = Cpf.Substring(9, 2).ToString();
                CpfFinal = Pt1 + "." + Pt2 + "." + Pt3 + "-" + Pt4;

                if (objPessoa.EsqSenha(txtUsuario.Text, CpfFinal) == true)
                {
                    this.Size = new System.Drawing.Size(290, 404);
                    pnl1.Visible = false;
                    pnl2.Visible = true;
                    pnl3.Visible = false;

                    lblPergunta.Text = objPessoa.PergSecreta;
                }
                else
                {
                    Program.Msg = "Nome de usúario ou CPF inválido, verifique-os!";
                    Program.Erro();
                    txtCpf.Text = "";
                    txtCpf.Focus();
                }
            }
        }

        private void txtResp_TextChanged(object sender, EventArgs e)
        {
            if (txtResp.Text == objPessoa.RespSecreta)
            {
                this.Size = new System.Drawing.Size(290, 372);
                pnl1.Visible = false;
                pnl2.Visible = false;
                pnl3.Visible = true;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pcbCerto2.Visible == true)
            {
                objPessoa.AlterarUsuario(txtSenha2.Text, objPessoa.UsuId);

                Program.Msg = "Senha alterada com sucesso!";
                Program.Sucesso();
                this.Close();
            }
            else
            {
                Program.Msg = "Não foi possivel alterar a senha, verifique os campos!";
                Program.Erro();
            }

            
        }

        #region Mudar a cor do botão Salvar
        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        { btnSalvar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoSalvar2.png"); }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        { btnSalvar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoSalvar1.png"); }
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

        
    }
}
