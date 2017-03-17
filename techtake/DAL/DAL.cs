using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    class CamadaDeDados
    {
        private static string Servidor = "localhost";
        private static string Banco = "techtake";
        private static string User = "root";
        private static string Password = "";

        private string String_Conexao = "Server="    + Servidor +
                                        ";Database=" + Banco +
                                        ";Uid="      + User +
                                        ";Pwd="      + Password;

        public MySqlConnection Conexao;
        
        public bool Conectar()
        {
            try
            {
                Conexao = new MySqlConnection();
                Conexao.ConnectionString = String_Conexao;
                Conexao.Open();
                return true;
            }
            catch
            { return false; }
        }

        public void ExecutarComandoSql(string Sql)
        {
            Conectar();

            MySqlCommand Comando = new MySqlCommand(Sql, Conexao);
            Comando.ExecuteNonQuery();
        }

        public DataTable DadosPesquisa(string Sql)
        {
            Conectar();
            DataTable Dados = new DataTable();
            MySqlDataAdapter dA = new MySqlDataAdapter(Sql, Conexao);
            dA.Fill(Dados);

            return Dados;         
        }
    }
}
