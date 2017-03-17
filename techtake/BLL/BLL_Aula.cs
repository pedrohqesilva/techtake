using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace techtake
{
    class BLL_Aula
    {
        CamadaDeDados objDAL = new CamadaDeDados();
        DataTable DtTable = new DataTable();

        #region Variaveis GET e SET para Aula

        string Sql;

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string materia;
        public string Materia
        {
            get { return materia; }
            set
            {
                if (value == "Vazio")
                { materia = ""; return; }

                if (value != "")
                    materia = value;
                else
                    throw new Exception("Selecione alguma matéria e tente novamente!");
            }
        }

        private string aluno;
        public string Aluno
        {
            get { return aluno; }
            set
            {
                if (value != "")
                    aluno = value;
                else
                    throw new Exception("Selecione o aluno que participará da aula e tente novamente!");
            }
        }

        private string instrutor;
        public string Instrutor
        {
            get { return instrutor; }
            set
            {
                if (value != "")
                    instrutor = value;
                else
                    throw new Exception("Selecione o instrutor que irá lecionar a aula e tente novamente!");
            }
        }

        private string data;
        public string Data
        {
            get { return data; }
            set
            {
                if (value != "")
                    data = value;
                else
                    throw new Exception("Data inválida!");
            }
        }

        private string hora;
        public string Hora
        {
            get { return hora; }
            set
            {
                if (value != "")
                    hora = value;
                else
                    throw new Exception("Hora inválida!");
            }
        }

        private double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        public void InserirAula()
        {
            Sql = String.Format(@"INSERT INTO Aula (id, data, hora, valor, tipo, materia, Instrutor_id, Aluno_id)
                                    VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                Data, Hora, Valor, Tipo, Materia, Instrutor, Aluno);

            objDAL.ExecutarComandoSql(Sql);
        }

        public DataTable SelectPessoa(string Tipo)
        {
            string Sql = "SELECT id, nome, tipo FROM pessoa WHERE tipo = '" + Tipo + "'";
            DtTable = objDAL.DadosPesquisa(Sql);
            return DtTable;
        }
    }
}
