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
using DAL;

namespace techtake
{
    public partial class frmAdicionarPessoa : Form
    {
        CamadaDeDados cD = new CamadaDeDados();
        BLL_Pessoa objPessoa = new BLL_Pessoa();

        public static string Modo = "Cadastrar";
        public static string VarTitulo = "Aluno";

        bool EstadoTeste = false;
        string Sql;

        public frmAdicionarPessoa()
        {
            InitializeComponent();
            IniciarTitulo();
            Estado();

            if (Modo == "Alterar")
            {
                btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAlterar1.png");
                CarregarDados();
            }

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        void Estado()
        {
            Sql = "SELECT * FROM estado";

            cbxEstado.DataSource = cD.DadosPesquisa(Sql);
            cbxEstado.ValueMember = "sigla";
            cbxEstado.DisplayMember = "nome";

            cbxEstado.SelectedIndex = -1;
            cbxEstado.Focus();

            EstadoTeste = true;
            Cidades();

        }
        void TestarEstados(string Est)
        {
            switch (Est)
            {
                case "AC": cbxEstado.Text = "Acre"; break;
                case "AL": cbxEstado.Text = "Alagoas"; break;
                case "AP": cbxEstado.Text = "Amapá"; break;
                case "AM": cbxEstado.Text = "Amazonas"; break;
                case "BA": cbxEstado.Text = "Bahia"; break;
                case "CE": cbxEstado.Text = "Ceará"; break;
                case "DF": cbxEstado.Text = "Distrito Federal"; break;
                case "ES": cbxEstado.Text = "Espírito Santo"; break;
                case "GO": cbxEstado.Text = "Goiás"; break;
                case "MA": cbxEstado.Text = "Maranhão"; break;
                case "MT": cbxEstado.Text = "Mato Grosso"; break;
                case "MS": cbxEstado.Text = "Mato Grosso do Sul"; break;
                case "MG": cbxEstado.Text = "Minas Gerais"; break;
                case "PA": cbxEstado.Text = "Pará"; break;
                case "PB": cbxEstado.Text = "Paraíba"; break;
                case "PR": cbxEstado.Text = "Paraná"; break;
                case "PE": cbxEstado.Text = "Pernambuco"; break;
                case "PI": cbxEstado.Text = "Piauí"; break;
                case "RJ": cbxEstado.Text = "Rio de Janeiro"; break;
                case "RN": cbxEstado.Text = "Rio Grande do Norte"; break;
                case "RS": cbxEstado.Text = "Rio Grande do Sul"; break;
                case "RO": cbxEstado.Text = "Rondônia"; break;
                case "RR": cbxEstado.Text = "Roraima"; break;
                case "SC": cbxEstado.Text = "Santa Catarina"; break;
                case "SP": cbxEstado.Text = "São Paulo"; break;
                case "SE": cbxEstado.Text = "Sergipe"; break;
                case "TO": cbxEstado.Text = "Tocantins"; break;
            }
        }
        void Cidades()
        {
            if (EstadoTeste == true)
            {
                Sql = "SELECT * FROM cidade WHERE uf = '" + (cbxEstado.SelectedIndex + 1) + "' ORDER BY nome ASC";

                cbxCidade.DataSource = cD.DadosPesquisa(Sql);
                cbxCidade.ValueMember = "nome";
                cbxCidade.DisplayMember = "nome";

                cbxCidade.SelectedIndex = -1;
                cbxCidade.Focus();

                if (cbxEstado.Text == "Minas Gerais")
                    cbxCidade.Text = "Belo Horizonte";
            }
        }

        void Limpar()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtNasc.Text = "";
            txtTelefone.Text = "";

            rdbMasc.Checked = false;
            rdbFem.Checked = false;

            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            cbxCidade.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;            
        }
        void IniciarTitulo()
        {
            if (VarTitulo == "Aluno")
            {
                pcbCadAluno.Visible = true;
                pcbCadAtendente.Visible = false;
                pcbCadInstrutor.Visible = false;
            }
            else if (VarTitulo == "Atendente")
            {
                pcbCadAluno.Visible = false;
                pcbCadAtendente.Visible = true;
                pcbCadInstrutor.Visible = false;
            }
            else if (VarTitulo == "Instrutor")
            {
                pcbCadAluno.Visible = false;
                pcbCadAtendente.Visible = false;
                pcbCadInstrutor.Visible = true;
            }

        }

        #region Mudar a cor do botão Cadastrar        
        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            if (Modo == "Cadastrar")
                btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoCadastrar2.png");
            if (Modo == "Alterar")
                btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAlterar2.png");
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            if (Modo == "Cadastrar")
                btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoCadastrar1.png");
            if (Modo == "Alterar")
                btnCadastrar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAlterar1.png");
        }
        #endregion
        #region Mudar a cor do botão Limpar
        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        { btnLimpar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLimpar2.png"); }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        { btnLimpar.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoLimpar.png"); }
        #endregion
        #region Mudar a cor do botão ADD
        private void btnADD_MouseEnter(object sender, EventArgs e)
        { btnAdd.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAdd2.png"); }

        private void btnADD_MouseLeave(object sender, EventArgs e)
        { btnAdd.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoAdd.png"); }
        #endregion
        #region Mudar a cor do botão Remover
        private void btnRemover_MouseEnter(object sender, EventArgs e)
        { btnRemover.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoRemover2.png"); }

        private void btnRemover_MouseLeave(object sender, EventArgs e)
        { btnRemover.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoRemover.png"); }
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


        private void CarregarDados()
        {
            string Sql = "SELECT * FROM vwAlunos WHERE cod = " + frmPesquisarAlunos.idAluno;
            DataTable dt = cD.DadosPesquisa(Sql);
            
            txtNome.Text = dt.Rows[0]["Nome"].ToString();            
            string SEXO = dt.Rows[0]["Sexo"].ToString();
                if (SEXO == "M")
                    rdbMasc.Checked = true;
                else
                    rdbFem.Checked = true;
            txtNasc.Text = (dt.Rows[0]["Data de Nascimento"].ToString()).Substring(0, 10);
            txtCpf.Text = dt.Rows[0]["Cpf"].ToString();
            txtRg.Text = dt.Rows[0]["RG"].ToString();
            txtTelefone.Text = dt.Rows[0]["Telefone"].ToString();
            txtCep.Text = dt.Rows[0]["CEP"].ToString();
            txtLogradouro.Text = dt.Rows[0]["Logradouro"].ToString();
            txtNumero.Text = dt.Rows[0]["Num."].ToString();
            txtComplemento.Text = dt.Rows[0]["Compl."].ToString();
            txtBairro.Text = dt.Rows[0]["Bairro"].ToString();
            cbxCidade.Text = dt.Rows[0]["Cidade"].ToString();
            cbxEstado.Text = dt.Rows[0]["UF"].ToString();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string DataInsert = "";

                string MatriculaInsert = objPessoa.GeradorMatricula();
                string SexoSelecionado = rdbMasc.Checked == true ? "M" : rdbFem.Checked == true ? "F" : "";
                                
                objPessoa.Matricula = MatriculaInsert;
                objPessoa.Nome = txtNome.Text;
                #region objPessoa.Cep = CPF
                txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Cpf = txtCpf.Text.Replace(" ", "");
                if (txtCpf.Text != "" && Cpf.Length == 11)
                {
                    txtCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    objPessoa.Cpf = txtCpf.Text.Replace(",", ".");
                }
                else
                { objPessoa.Cpf = ""; return; }
                #endregion
                #region objPessoa.Cep = RG
                txtRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Rg = txtRg.Text.Replace(" ", "");
                if (txtRg.Text != "" && Rg.Length == 10)
                {
                    txtRg.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    objPessoa.Rg = txtRg.Text.Replace(",", ".");
                }
                else
                { objPessoa.Rg = ""; return; }
                #endregion
                #region objPessoa.Cep = Telefone                
                txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Telefone = txtTelefone.Text.Replace(" ", "");
                if (txtTelefone.Text != "" && Telefone.Length == 11)
                {
                    txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    objPessoa.Telefone = txtTelefone.Text;
                }
                else
                { objPessoa.Telefone = ""; return; }
                #endregion
                #region objPessoa.Cep = Data de Nasc
                txtNasc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Nascimento = txtNasc.Text.Replace(" ", "");
                if (int.Parse(Nascimento.Substring(0, 2)) > 0 && int.Parse(Nascimento.Substring(0, 2)) <= 31 &&
                    int.Parse(Nascimento.Substring(2, 2)) > 0 && int.Parse(Nascimento.Substring(2, 2)) <= 12)
                {
                    if (txtNasc.Text != "" && Nascimento.Length == 8)
                    {
                        txtNasc.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        DataInsert = DateTime.Parse(txtNasc.Text).ToString("yyyy-MM-dd");
                        objPessoa.Nascimento = DataInsert;
                    }
                    else
                    { objPessoa.Nascimento = ""; return; }
                }
                else
                { objPessoa.Nascimento = ""; return; }
                #endregion
                objPessoa.Sexo = SexoSelecionado;
                #region objPessoa.Cep = CEP                
                txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string Cep = txtCep.Text.Replace(" ", "");
                if (txtCep.Text != "" && Cep.Length == 8)
                {
                    txtCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    objPessoa.Cep = txtCep.Text;
                }
                else
                { objPessoa.Cep = ""; return; }
                #endregion
                objPessoa.Logradouro = txtLogradouro.Text;
                objPessoa.Numero = txtNumero.Text;
                objPessoa.Complemento = txtComplemento.Text;
                objPessoa.Bairro = txtBairro.Text;
                objPessoa.Cidade = cbxCidade.Text;
                objPessoa.Uf = cbxEstado.Text;

                objPessoa.Tipo = VarTitulo;

                if (Modo == "Cadastrar")
                { objPessoa.InserirPessoa(); Program.Msg = VarTitulo + " cadastrado com sucesso!"; Program.Sucesso(); this.Close(); }
                if (Modo == "Alterar")
                { objPessoa.Id = frmPesquisarAlunos.idAluno; objPessoa.AlterarPessoa(); Program.Msg = "Registro alterado com sucesso!"; Program.Sucesso(); this.Close(); }

            }
            catch (Exception ex)
            { Program.Msg = ex.Message; Program.Erro(); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Modo == "Cadastrar")
            {
                try
                {
                    ofdAlterarFoto.ShowDialog();

                    Bitmap bmp = new Bitmap(ofdAlterarFoto.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);

                    string[] Endereco = txtNome.Text.Split(' ');

                    pcbFoto.Image = bmp2;
                    pcbFoto.Image.Save(@"..\..\FotosPessoas\" + Endereco[0] + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    //objPessoa.Foto = @"..\\..\\..\\FotosPessoas\\" + Endereco[0] + ".png";
                }
                catch
                {
                    return;
                }
            }
            else if (Modo == "Alterar")
            {
                try
                {
                    ofdAlterarFoto.ShowDialog();

                    Bitmap bmp = new Bitmap(ofdAlterarFoto.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);

                    string[] Endereco = txtNome.Text.Split(' ');

                    pcbFoto.Image = bmp2;
                    pcbFoto.Image.Save(@"..\..\FotosPessoas\" + Endereco[0] + "Nova.png", System.Drawing.Imaging.ImageFormat.Png);
                    //Foto = @"..\\..\\..\\FotosPessoas\\" + Endereco[0] + "Nova.png";
                }
                catch
                {
                    return;
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void cbxEstado_TextChanged(object sender, EventArgs e)
        {
            Cidades();
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        
    }
}
