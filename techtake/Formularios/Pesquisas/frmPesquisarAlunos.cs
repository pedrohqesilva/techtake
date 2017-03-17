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
    public partial class frmPesquisarAlunos : Form
    {
        CamadaDeDados cD = new CamadaDeDados();
        BLL_Pessoa objPessoa = new BLL_Pessoa();
    
        public static string TipoDeFuncionario = "Atendente";
        public static string idAluno;

        public frmPesquisarAlunos()
        {
            InitializeComponent();
            CarregarGrid();
            
            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void CarregarGrid()
        {
            string Sql = "SELECT COUNT(id) FROM Pessoa WHERE tipo = 'Aluno'";
            int COUNT = int.Parse(cD.DadosPesquisa(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT * FROM vwAlunos";
            DataTable dt = cD.DadosPesquisa(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["cod"].ToString();
                string nomeS = dt.Rows[i]["Nome"].ToString();
                string sexoS = dt.Rows[i]["Sexo"].ToString();
                string dtnascS = (dt.Rows[i]["Data de Nascimento"].ToString()).Substring(0, 10);
                string cpfS = dt.Rows[i]["Cpf"].ToString();
                string rgS = dt.Rows[i]["RG"].ToString();
                string telefoneS = dt.Rows[i]["Telefone"].ToString();
                string cepS = dt.Rows[i]["CEP"].ToString();
                string logradouroS = dt.Rows[i]["Logradouro"].ToString();
                string numS = dt.Rows[i]["Num."].ToString();
                string complS = dt.Rows[i]["Compl."].ToString();
                string bairroS = dt.Rows[i]["Bairro"].ToString();
                string cidadeS = dt.Rows[i]["Cidade"].ToString();
                string ufS = dt.Rows[i]["UF"].ToString();

                dtgPesquisa.Rows.Add(id, nomeS, sexoS, dtnascS, cpfS, rgS, telefoneS, cepS, logradouroS, numS, complS, bairroS, cidadeS, ufS);

                Cod.Width = 50;
                nome.Width = 170;
                sexo.Width = 50;
                dtNasc.Width = 100;
                cpf.Width = 100;
                rg.Width = 100;
                telefone.Width = 100;
                cep.Width = 100;
                logradouro.Width = 150;
                num.Width = 60;
                compl.Width = 100;
                bairro.Width = 100;
                cidade.Width = 130;
                uf.Width = 35;
            }
        }

        private void dtgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TipoDeFuncionario == "Atendente")
            {
                frmAdicionarPessoa.Modo = "Alterar";
                frmAdicionarPessoa.VarTitulo = "Aluno";

                idAluno = dtgPesquisa.Rows[e.RowIndex].Cells["Cod"].Value.ToString();

                frmAdicionarPessoa addPessoa = new frmAdicionarPessoa();
                addPessoa.Show();
            }
            else if (TipoDeFuncionario == "Gerente")
            {
                try
                {
                    idAluno = dtgPesquisa.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                    string Nome = dtgPesquisa.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                    DialogResult Resposta = MessageBox.Show(@"Deseja realmente excluir o registro do aluno '" + Nome + "'?",
                                                             "tech&take - Confirmação de Exclusão",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Exclamation,
                                                              MessageBoxDefaultButton.Button2);

                    if (Resposta.ToString().ToUpper() == "YES")
                    {
                        objPessoa.Id = idAluno;
                        objPessoa.ExcluirUsuario();
                        objPessoa.ExcluirPessoa();

                        Program.Msg = "Registro excluido com sucesso!";
                        Program.Sucesso();
                        this.Close();
                    }
                }
                catch (System.Exception ex)
                {
                    Program.Msg = @"O registro está sendo utilizado por algum dado no banco de dados, apague-o e tente novamente!";
                    Program.Erro();
                    this.Close();
                }
            }
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
