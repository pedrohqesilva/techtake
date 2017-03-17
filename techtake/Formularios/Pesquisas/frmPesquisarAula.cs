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
    public partial class frmPesquisarAula : Form
    {
        CamadaDeDados cD = new CamadaDeDados();

        public frmPesquisarAula()
        {
            InitializeComponent();
            CarregarGrid1();
            CarregarGrid2();

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void CarregarGrid1()
        {
            string Sql = "SELECT COUNT(id) FROM Aula WHERE tipo = 'L'";
            int COUNT = int.Parse(cD.DadosPesquisa(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT * FROM vwAula WHERE Tipo = 'L'";
            DataTable dt = cD.DadosPesquisa(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["cod"].ToString();
                string dataS = (dt.Rows[i]["Data"].ToString()).Substring(0, 10);
                string horaS = (dt.Rows[i]["Hora"].ToString()).Substring(0, 5);
                string valorS = dt.Rows[i]["Valor"].ToString();
                string materiaS = dt.Rows[i]["Materia"].ToString();
                string nomeInstrutorS = dt.Rows[i]["Nome do Instrutor"].ToString();
                string nomeAlunoS = dt.Rows[i]["Nome do Aluno"].ToString();

                dtgPesquisa1.Rows.Add(id, materiaS, dataS, horaS, Convert.ToDouble(valorS).ToString("C"), nomeInstrutorS, nomeAlunoS);

                Cod1.Width = 50;
                data1.Width = 100;
                hora1.Width = 60;
                valor1.Width = 98;
                materia1.Width = 140;
                nomeInstrutor1.Width = 140;
                nomeAluno1.Width = 140;                
            }           
        }
        private void CarregarGrid2()
        {
            string Sql = "SELECT COUNT(id) FROM Aula WHERE tipo = 'P'";
            int COUNT = int.Parse(cD.DadosPesquisa(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT * FROM vwAula WHERE Tipo = 'P'";
            DataTable dt = cD.DadosPesquisa(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string ids = dt.Rows[i]["cod"].ToString();
                string dataSs = (dt.Rows[i]["Data"].ToString()).Substring(0, 10);
                string horaSs = (dt.Rows[i]["Hora"].ToString()).Substring(0, 5);
                string valorSs = dt.Rows[i]["Valor"].ToString();
                string nomeInstrutorSs = dt.Rows[i]["Nome do Instrutor"].ToString();
                string nomeAlunoSs = dt.Rows[i]["Nome do Aluno"].ToString();
                
                dtgPesquisa2.Rows.Add(ids, dataSs, horaSs, Convert.ToDouble(valorSs).ToString("C"), nomeInstrutorSs, nomeAlunoSs);

                Cod2.Width = 50;
                data2.Width = 100;
                hora2.Width = 60;
                valor2.Width = 98;
                nomeInstrutor2.Width = 190;
                nomeAluno2.Width = 190;
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
