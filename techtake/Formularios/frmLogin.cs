using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using BLL;

namespace techtake
{
    public partial class frmLogin : Form
    {
        CamadaDeDados Banco = new CamadaDeDados();
        BLL_Pessoa objPessoa = new BLL_Pessoa();

        public frmLogin()
        {
            InitializeComponent();    
            
            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        void Login()
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {                
                this.Hide();
                frmMenuAtendente menuAtendente = new frmMenuAtendente();
                menuAtendente.Show();
                return;
            }

            try
            {
                if (txtUsuario.Text != "" && txtSenha.Text != "")
                {
                    if (objPessoa.VerificarLogin(txtUsuario.Text, txtSenha.Text) == true)
                    {
                        switch (BLL_Pessoa.tipoLogado)
                        {
                            case "Atendente":
                                {
                                    this.Hide();
                                    frmMenuAtendente menuAtendente = new frmMenuAtendente();
                                    menuAtendente.Show();
                                }
                                break;
                            case "Gerente":
                                {
                                    this.Hide();
                                    frmMenuGerente menuGerente = new frmMenuGerente();
                                    menuGerente.Show();
                                }
                                break;
                            default:
                                {
                                    Program.Msg = "Usuario não cadastrado, \nou não possui acesso ao sistema!";
                                    Program.Erro();
                                }
                                break;
                        }
                    }
                    else
                    {
                        Program.Msg = "Usuario ou senha inválidos";
                        Program.Erro();
                    }
                }
                else
                {
                    Program.Msg = "Usuario ou senha inválidos";
                    Program.Erro();
                }
            }
            catch
            {
                Program.Msg = "Banco de dados não conectado!";
                Program.Erro();
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        { Login(); }
        private void btnEntrarEnter_Click(object sender, EventArgs e)
        { Login(); }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        { Application.Exit(); }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            frmEsqueciSenha_pt1 EsqueciPt1 = new frmEsqueciSenha_pt1();
            EsqueciPt1.ShowDialog();
        }

        private void btnAddNovoUsuario_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario AddUsuario = new frmAdicionarUsuario();
            AddUsuario.Show();
        }

        #region Mudar cor dos botões
        #region Mudar a cor do botão Login
        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        { btnEntrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLogin2.png"); }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        { btnEntrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLogin1.png"); }
        #endregion
        #region Mudar a cor do botão Add
        private void btnAddNovoUsuario_MouseEnter(object sender, EventArgs e)
        { btnAddNovoUsuario.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\AddNovoUsuario2.png"); }

        private void btnAddNovoUsuario_MouseLeave(object sender, EventArgs e)
        { btnAddNovoUsuario.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\AddNovoUsuario1.png"); }
        #endregion
        #endregion
        #region Label "Esqueci minha senha"
        private void lblEsqueciSenha_MouseEnter(object sender, EventArgs e)
        { lblEsqueciSenha.Font = new Font("Calibri Light", 9, FontStyle.Underline); }

        private void lblEsqueciSenha_MouseLeave(object sender, EventArgs e)
        { lblEsqueciSenha.Font = new Font("Calibri Light", 9, FontStyle.Regular); }
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

