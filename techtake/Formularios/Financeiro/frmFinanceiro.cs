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
    public partial class frmFinanceiro : Form
    {
        BLL_Financeiro objFinanceiro = new BLL_Financeiro();
        CamadaDeDados cD = new CamadaDeDados();

        public frmFinanceiro()
        {
            InitializeComponent();
            gridRenda();

            #region Props para bloquear o redimensionamento
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            #endregion
        }

        private void gridRenda()
        {
            DataTable dtRendaTotal = objFinanceiro.RendaTotal();
            if (dtRendaTotal.Rows.Count >= 1)
            {
                if (dtRendaTotal.Rows[0]["Soma total"].ToString() != "")
                    lblRendaCompleta.Text = Convert.ToDouble(dtRendaTotal.Rows[0]["Soma total"].ToString()).ToString("C");
                else
                    lblRendaCompleta.Text = "R$ 0,00";
            }

            DataTable dtRendaTipoL = objFinanceiro.RendaPorTipoL();
            if (dtRendaTipoL.Rows.Count >= 1)
            {
                if (dtRendaTipoL.Rows[0]["SUM(valor)"].ToString() != "")
                    lblRendaLegs.Text = Convert.ToDouble(dtRendaTipoL.Rows[0]["SUM(valor)"].ToString()).ToString("C");
                else
                    lblRendaLegs.Text = "R$ 0,00";
            }

            DataTable dtRendaTipoP = objFinanceiro.RendaPorTipoP();
            if (dtRendaTipoP.Rows.Count >= 1)
            {
                if (dtRendaTipoP.Rows[0]["SUM(valor)"].ToString() != "")
                    lblRendaPrat.Text = Convert.ToDouble(dtRendaTipoP.Rows[0]["SUM(valor)"].ToString()).ToString("C");
                else
                    lblRendaLegs.Text = "R$ 0,00";
            }
            
            DataTable dtRendaInstrutor = objFinanceiro.RendaPorInstrutor();
            if (dtRendaInstrutor.Rows.Count >= 1)
            {
                foreach (DataRow Renda in dtRendaInstrutor.Rows)
                {
                    string nome = Renda["nome"].ToString();
                    string valor = Renda["SUM(valor)"].ToString();

                    dtgRenda.Rows.Add(nome, Convert.ToDouble(valor).ToString("C"));
                }
            }
        }
    }
}
