using ClassProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarOrcamento_JSPlanejar
{
    class ClassEmpresa
    {
        private int ID;
        private string RazaoSocial;
        private string NomeFantasia;
        private string Cnpj;
        private string InscricaoEstadual;
        private string Logradouro;
        private string Cep;
        private string Numero;
        private string Bairro;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Celular;
        private string Email;
        private string LogoEmpresa;

        public int Cod_Empresa
        {
            get { return ID; }
            set { ID = value; }
        }
        public string razaoSocial
        {
            get { return RazaoSocial; }
            set { RazaoSocial = value; }
        }
        public string nomeFantasia
        {
            get { return NomeFantasia; }
            set { NomeFantasia = value; }
        }
        public string CNPJ
        {
            get { return Cnpj; }
            set { Cnpj = value; }
        }
        public string inscricao
        {
            get { return InscricaoEstadual; }
            set { InscricaoEstadual = value; }
        }
        public string logradouro
        {
            get { return Logradouro; }
            set { Logradouro = value; }
        }
        public string CEP
        {
            get { return Cep; }
            set { Cep = value; }
        }
        public string numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
        }
        public string cidade
        {
            get { return Cidade; }
            set { Cidade = value; }
        }
        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public string celular
        {
            get { return Celular; }
            set { Celular = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string logoEmpresa
        {
            get { return LogoEmpresa; }
            set { LogoEmpresa = value; }
        }


        string stringConn = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;

        public bool Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Empresa";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                _sql = "Insert into empresa values (@Razao, @Nome, @CNPJ, @Inscricao, @logradouro, @CEP, @Numero, @Bairro, @Cidade, @Estado, @Telefone, @Celular, @Email, @LogoEmpresa)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Razao", razaoSocial);
                comando.Parameters.AddWithValue("@Nome", nomeFantasia);
                comando.Parameters.AddWithValue("@CNPJ", CNPJ);
                comando.Parameters.AddWithValue("@Inscricao", inscricao);
                comando.Parameters.AddWithValue("@logradouro", logradouro);
                comando.Parameters.AddWithValue("@CEP", CEP);
                comando.Parameters.AddWithValue("@Numero", numero);
                comando.Parameters.AddWithValue("@Bairro", bairro);
                comando.Parameters.AddWithValue("@Cidade", cidade);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@Telefone", telefone);
                comando.Parameters.AddWithValue("@Celular", celular);
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@LogoEmpresa", logoEmpresa);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conexao.Close();
                }
                return false;
            }
        }
        public void Atualizar()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update  empresa set RazaoSocial_Empresa = @Razao, NomeFantasia_Empresa = @Nome, CNPJ_Empresa =  @CNPJ, InscricaoEstadual_Empresa = @Inscricao, Logradouro_Empresa = @logradouro, CEP_Empresa = @CEP, Numero_Empresa = @Numero, Bairro_Empresa = @Bairro, Cidade_Empresa = @Cidade, Estado_Empresa = @Estado, Telefone_Empresa = @Telefone, Celular_Empresa = @Celular, Email_Empresa = @Email, LogoEmpresa_Empresa = @LogoEmpresa where Cod_Empresa = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", Cod_Empresa); comando.Parameters.AddWithValue("@Razao", razaoSocial);
            comando.Parameters.AddWithValue("@Nome", nomeFantasia);
            comando.Parameters.AddWithValue("@CNPJ", CNPJ);
            comando.Parameters.AddWithValue("@Inscricao", inscricao);
            comando.Parameters.AddWithValue("@logradouro", logradouro);
            comando.Parameters.AddWithValue("@CEP", CEP);
            comando.Parameters.AddWithValue("@Numero", numero);
            comando.Parameters.AddWithValue("@Bairro", bairro);
            comando.Parameters.AddWithValue("@Cidade", cidade);
            comando.Parameters.AddWithValue("@Estado", estado);
            comando.Parameters.AddWithValue("@Telefone", telefone);
            comando.Parameters.AddWithValue("@Celular", celular);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@LogoEmpresa", logoEmpresa);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Empresa";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    razaoSocial = Tabela.Rows[0]["RazaoSocial_Empresa"].ToString();
                    nomeFantasia = Tabela.Rows[0]["NomeFantasia_Empresa"].ToString();
                    CNPJ = Tabela.Rows[0]["CNPJ_Empresa"].ToString();
                    inscricao = Tabela.Rows[0]["InscricaoEstadual_Empresa"].ToString();
                    logradouro = Tabela.Rows[0]["logradouro_Empresa"].ToString();
                    CEP = Tabela.Rows[0]["CEP_Empresa"].ToString();
                    numero = Tabela.Rows[0]["Numero_Empresa"].ToString();
                    bairro = Tabela.Rows[0]["Bairro_Empresa"].ToString();
                    cidade = Tabela.Rows[0]["Cidade_Empresa"].ToString();
                    estado = Tabela.Rows[0]["Estado_Empresa"].ToString();
                    telefone = Tabela.Rows[0]["Telefone_Empresa"].ToString();
                    celular = Tabela.Rows[0]["Celular_Empresa"].ToString();
                    email = Tabela.Rows[0]["Email_Empresa"].ToString();
                    logoEmpresa = Tabela.Rows[0]["LogoEmpresa_Empresa"].ToString();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void VerificarCodigoEmpresa()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "Select Max(Cod_Empresa) from empresa";
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    Cod_Empresa = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}