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
    public partial class frmAdicionarPratica : Form
    {
        BLL_Aula objAula = new BLL_Aula();
        public static double ValorAulaPratica = 50.00;

        public frmAdicionarPratica()
        {
            InitializeComponent();
            CarregarComboBox();

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        void CarregarComboBox()
        {
            cbxAluno.DataSource     = objAula.SelectPessoa("Aluno");
            cbxAluno.DisplayMember  = "Nome";
            cbxAluno.ValueMember    = "Id";
            cbxAluno.SelectedIndex  = -1;

            cbxProfessor.DataSource     = objAula.SelectPessoa("Instrutor");
            cbxProfessor.DisplayMember  = "Nome";
            cbxProfessor.ValueMember    = "Id";
            cbxProfessor.SelectedIndex  = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objAula.Valor = ValorAulaPratica;
                objAula.Tipo = "P";

                objAula.Materia = "Vazio";
                objAula.Aluno = cbxAluno.SelectedValue.ToString();
                objAula.Instrutor = cbxProfessor.SelectedValue.ToString();
                objAula.Data = Convert.ToDateTime(dtpData.Text).ToString("yyyy-MM-dd");
                #region objAula.Hora = Hora
                mskHora.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Hora = mskHora.Text.Replace(" ", "");
                if (mskHora.Text != "" && Hora.Length == 4)
                {
                    int Hora1 = int.Parse(mskHora.Text.Substring(0, 2));
                    int Hora2 = int.Parse(mskHora.Text.Substring(2, 2));

                    if (Hora1 < 24 && Hora2 < 60)
                    {
                        mskHora.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        objAula.Hora = mskHora.Text;
                    }
                    else
                    { mskHora.Focus(); objAula.Hora = ""; return; }
                }
                else
                { mskHora.Focus(); objAula.Hora = ""; return; }
                #endregion                     

                objAula.InserirAula();
                Program.Msg = "Aula prática, registrada com sucesso, o aluno está sendo aguardado no dia " + dtpData.Text + ", no horario de " + mskHora.Text + "!";
                Program.Sucesso();
                this.Close();

            }
            catch (Exception ex)
            { Program.Msg = ex.Message; Program.Erro(); }
        }

        #region Mudar a cor do botão Cadastrar
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
                    if ((new int[] { 0xF120 }).Contains(command))
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
