using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace techtake
{
    class BLL_Financeiro
    {
        CamadaDeDados objDAL = new CamadaDeDados();
        DataTable DtTable = new DataTable();

        public string MesAtual()
        {
            string MesTexto = "";

            string Sql = "SELECT MONTH(NOW()) AS MSG";
            DtTable = objDAL.DadosPesquisa(Sql);
            
            string Mes = DtTable.Rows[0]["MSG"].ToString();

            #region Meses
            switch (Mes)
            {
                case "1":
                    MesTexto = "Janeiro";
                    break;
                case "2":
                    MesTexto = "Fevereiro";
                    break;
                case "3":
                    MesTexto = "Março";
                    break;
                case "4":
                    MesTexto = "Abril";
                    break;
                case "5":
                    MesTexto = "Maio";
                    break;
                case "6":
                    MesTexto = "Junho";
                    break;
                case "7":
                    MesTexto = "Julho";
                    break;
                case "8":
                    MesTexto = "Agosto";
                    break;
                case "9":
                    MesTexto = "Setembro";
                    break;
                case "10":
                    MesTexto = "Outrubro";
                    break;
                case "11":
                    MesTexto = "Novembro";
                    break;
                case "12":
                    MesTexto = "Dezembro";
                    break;
            }
            #endregion

            return MesTexto;
        }

        public DataTable RendaTotal()
        {
            string Sql = "SELECT SUM(valor) AS 'Soma total' FROM Aula WHERE data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE()";
            DtTable = objDAL.DadosPesquisa(Sql);
            return DtTable;
        }

        public DataTable RendaPorInstrutor()
        {
            string Sql = "SELECT SUM(valor), p.nome FROM Aula a JOIN Pessoa p  ON a.Instrutor_id = p.id WHERE data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE() GROUP BY Instrutor_id";
            DtTable = objDAL.DadosPesquisa(Sql);
            return DtTable;
        }

        public DataTable RendaPorTipoL()
        {
            string Sql = "SELECT SUM(valor), tipo FROM Aula WHERE tipo = 'L' AND data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE() GROUP BY tipo";
            DtTable = objDAL.DadosPesquisa(Sql);
            return DtTable;
        }

        public DataTable RendaPorTipoP()
        {
            string Sql = "SELECT SUM(valor), tipo FROM Aula WHERE tipo = 'P' AND data BETWEEN CURDATE() - INTERVAL 1 MONTH AND CURDATE() GROUP BY tipo";
            DtTable = objDAL.DadosPesquisa(Sql);
            return DtTable;
        }
    }
}
