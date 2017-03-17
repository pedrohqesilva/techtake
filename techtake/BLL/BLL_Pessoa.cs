using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    class BLL_Pessoa
    {
        CamadaDeDados objDAL = new CamadaDeDados();

        #region Variaveis GET e SET para os dados de Pessoas
        private string id;
        public string Id {
            get { return id; }
            set { id = value; }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set {
                if (value != "" && value.Length >= 3 && value.Contains(" "))
                    nome = value;
                else
                    throw new Exception("O nome está curto ou incompleto! Porfavor, insira o nome completo e tente novamente!");
            }
        }
        private string nascimento;
        public string Nascimento
        {
            get { return nascimento; }
            set {
                if (value != "")
                    nascimento = value;
                else
                    throw new Exception("A data de nascimento está inválida, por favor, altere-a e tente novamente!");
            }
        }
        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set {
                if (value != "")
                    sexo = value;
                else
                    throw new Exception("Por favor, selecione algum sexo e tente novamente!");
            }
        }
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set {
                if (value != "")
                    cpf = value;
                else
                    throw new Exception("O CPF está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string rg;
        public string Rg
        {
            get { return rg; }
            set {
                if (value != "")
                    rg = value;
                else
                    throw new Exception("O RG está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set {
                if (value != "" && value.Length > 2)
                    telefone = value;
                else
                    throw new Exception("O telefone está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string cep;
        public string Cep
        {
            get { return cep; }
            set
            {
                if (value != "" && value.Length == 9)
                    cep = value;
                else
                    throw new Exception("O CEP está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string logradouro;
        public string Logradouro
        {
            get { return logradouro; }
            set {
                if (value != "" && value.Length > 5 && value.Contains(" "))
                    logradouro = value;
                else
                    throw new Exception("O logradouro está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string numero;
        public string Numero
        {
            get { return numero; }
            set {
                if (value != "")
                    numero = value;
                else
                    throw new Exception("O número está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string complemento;
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set {
                if (value != "" && value.Length > 5)
                    bairro = value;
                else
                    throw new Exception("O bairro está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set {
                if (value != "" && value.Length > 4)
                    cidade = value;
                else
                    throw new Exception("A cidade está inválida, por favor, altere-a e tente novamente!");
            }
        }
        private string uf;
        public string Uf
        {
            get { return uf; }
            set {
                if (value != "" && value.Length >= 4)
                    uf = value;
                else
                    throw new Exception("O estado está inválido, por favor, altere-o e tente novamente!");
            }
        }
        #endregion
        #region Variaveis GET e SET para os dados de Usuarios
        private string login;
        public string Login
        {
            get { return login; }
            set {
                if (value != "" && value.Length >= 4)
                    login = value;
                else
                    throw new Exception("O usúario está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set {
                if (value != "" && value.Length > 5)
                    senha = value;
                else
                    throw new Exception("A senha está inválida, por favor, altere-a e tente novamente!");
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set {
                if (value != "" && value.Length > 5 && value.Contains("@") && value.Contains("."))
                    email = value;
                else
                    throw new Exception("O email está inválido, por favor, altere-o e tente novamente!");
            }
        }
        private string perguntaSecreta;
        public string PerguntaSecreta
        {
            get { return perguntaSecreta; }
            set { perguntaSecreta = value;
            }
        }
        private string respostaSecreta;
        public string RespostaSecreta
        {
            get { return respostaSecreta; }
            set {
                if (value != "" && value.Length > 3)
                    respostaSecreta = value;
                else
                    throw new Exception("A resposta está inválida, por favor, altere-a e tente novamente!");
            }
        }
        #endregion
        #region Variáveis:        
        DataTable Data = new DataTable();
        Random Ran = new Random();
        string Sql, SqlNovo;
        
        public string UsuId, PergSecreta, RespSecreta;
        public static string idLogado, tipoLogado, nomeLogado;
        #endregion

        #region Métodos de Pessoas (Aluno, Instrutor e Atendente)
        public void InserirPessoa()
        {
            Sql = String.Format("INSERT INTO Pessoa (id, tipo, matricula, nome, nascimento, sexo, cpf, " +
                                "rg, telefone, cep, logradouro, numero, complemento, bairro, cidade, uf) " +
                                "VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')",
                                Tipo, Matricula, Nome, Nascimento, Sexo, Cpf, Rg, Telefone, Cep, Logradouro, Numero, Complemento, Bairro, Cidade, Uf);
            
            objDAL.ExecutarComandoSql(Sql);
            
            string SqlPesquisa = "SELECT MAX(ID) FROM PESSOA";
            Data = objDAL.DadosPesquisa(SqlPesquisa);
            string MaxID = Data.Rows[0]["MAX(ID)"].ToString();

            if (Tipo == "Aluno")
            {
                SqlNovo = String.Format(@"INSERT INTO NovosAlunos (id, data, Aluno_id)
                                        VALUES(NULL, NOW(), " + MaxID + ")");
                objDAL.ExecutarComandoSql(SqlNovo);
            }
            else if (Tipo == "Instrutor")
            {
                SqlNovo = String.Format(@"INSERT INTO NovosNovosInstrutores (id, data, Instrutor_id)
                                        VALUES(NULL, NOW(), " + MaxID + ")");
                objDAL.ExecutarComandoSql(SqlNovo);
            }
        }
        public void AlterarPessoa()
        {
            Sql = String.Format("UPDATE Pessoa SET nome = '{0}', nascimento = '{1}', sexo = '{2}', cpf = '{3}', rg = '{4}', " +
                                "telefone = '{5}', cep = '{6}', logradouro = '{7}', numero = '{8}', complemento = '{9}', bairro = '{10}', " +
                                "cidade = '{11}', uf = '{12}' WHERE id = '{13}'",
                                Nome, Nascimento, Sexo, Cpf, Rg, Telefone, Cep, Logradouro, Numero, Complemento, Bairro, Cidade, Uf, Id);

            objDAL.ExecutarComandoSql(Sql);
        }
        public void ExcluirPessoa()
        {
            string Sql = String.Format("DELETE FROM Pessoa WHERE id = '{0}'", Id);
            objDAL.ExecutarComandoSql(Sql);
        }
        public DataTable ListarPessoa()
        {
            string Sql = "SELECT * FROM vwPessoa";
            Data = objDAL.DadosPesquisa(Sql);
            return Data;
        }

        public bool TestarMatricula(string nCompleto)
        {
            bool Condicao = true;

            string Sql = "SELECT * FROM vwPessoa WHERE matricula = '" + nCompleto + "'";
            Data = objDAL.DadosPesquisa(Sql);

            if (Data.Rows.Count == 1)
            {
                Condicao = true;
                return Condicao;
            }
            else
            {
                Condicao = false;
                return Condicao;
            }

        }
        public string TestarID(string nCompleto)
        {
            string Sql = "SELECT Cod FROM vwPessoa WHERE matricula = '" + nCompleto + "'";
            Data = objDAL.DadosPesquisa(Sql);

            string IDPESSOA = Data.Rows[0]["cod"].ToString();
            return IDPESSOA;

        }
        #endregion
        #region Métodos de Usuarios
        public void InserirUsuario(string Matricula, string Pessoa_Id)
        {
            Sql = String.Format("INSERT INTO usuario(id, matricula, login, senha, email, perguntaSecreta, respostaSecreta, Pessoa_Id) " +
                                "VALUES(NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                Matricula, Login, Senha, Email, PerguntaSecreta, RespostaSecreta, Pessoa_Id);

            objDAL.ExecutarComandoSql(Sql);
        }
        public void AlterarUsuario(string UsuSenha, string IdUsu)
        {
            Sql = String.Format("UPDATE Usuario SET senha = '{0}' WHERE id = '{1}'",
                                UsuSenha, IdUsu);

            objDAL.ExecutarComandoSql(Sql);
        }
        public void ExcluirUsuario()
        {
            string Sql = String.Format("DELETE FROM Usuario WHERE id = '{0}'", Id);
            objDAL.ExecutarComandoSql(Sql);
        }
        public DataTable ListarUsuarios()
        {
            string Sql = "SELECT * FROM Usuarios";
            Data = objDAL.DadosPesquisa(Sql);
            return Data;
        }
        #endregion

        //Métodos Funcionais:
        public bool VerificarLogin(string LoginUsu, string SenhaUsu)
        {
            bool Condicao = true;

            string Sql = "SELECT u.id, tipo, nome FROM Usuario u JOIN pessoa p ON u.Pessoa_id = p.id WHERE login = '" + LoginUsu + "' AND senha = '" + SenhaUsu + "'";
            Data = objDAL.DadosPesquisa(Sql);

            if (Data.Rows.Count == 1)
            {
                idLogado = Data.Rows[0]["id"].ToString();
                tipoLogado = Data.Rows[0]["tipo"].ToString();
                nomeLogado = Data.Rows[0]["nome"].ToString();

                Condicao = true;
                return Condicao;
            }
            else
            {
                Condicao = false;
                return Condicao;
            }
        }
        public bool VerificarMatricula(string nCompleto)
        {
            bool Condicao = true;
            string Teste;

            Teste = (TestarMatricula(nCompleto)).ToString();

            if (Teste == "False")
            {
                Condicao = false;
                return Condicao;
            }
            else
            {
                Condicao = true;
                return Condicao;
            }
        }
        public string GeradorMatricula()
        {
            string Alf = "ABCDEFGHIJKLMNOPQRSTUVYWXZ";

            string nCompleto;
            string[] lAlf = new string[5];
            string[] Nums = new string[5];

            for (int i = 0; i < 5; i++)
            { lAlf[i] = Alf.Substring(Ran.Next(1, 26), 1); }

            for (int i = 0; i < 5; i++)
            { Nums[i] = Ran.Next(9).ToString(); }

            nCompleto = lAlf[0] + Nums[0] + lAlf[1] + Nums[1] + lAlf[2] +
                        Nums[2] + lAlf[3] + Nums[3] + lAlf[4] + Nums[4];

            //Verificar se a matricula já existe:
            if (VerificarMatricula(nCompleto) == false)
            { return nCompleto; }
            else
            { GeradorMatricula(); return ""; }
        }

        public bool EsqSenha(string LoginUsu, string CpfUsu)
        {
            bool Condicao = true;

            string Sql = "SELECT u.id, login, cpf, perguntaSecreta, respostaSecreta FROM Usuario u JOIN pessoa p ON u.Pessoa_id = p.id WHERE login = '" + LoginUsu + "' AND cpf = '" + CpfUsu + "'";
            Data = objDAL.DadosPesquisa(Sql);

            if (Data.Rows.Count == 1)
            {
                UsuId = Data.Rows[0]["id"].ToString();
                PergSecreta = Data.Rows[0]["perguntaSecreta"].ToString();
                RespSecreta = Data.Rows[0]["respostaSecreta"].ToString();

                Condicao = true;                
                return Condicao;
            }
            else
            {
                UsuId = "";
                PergSecreta = "";
                RespSecreta = "";

                Condicao = false;
                return Condicao;
            }
        }

    }
}
