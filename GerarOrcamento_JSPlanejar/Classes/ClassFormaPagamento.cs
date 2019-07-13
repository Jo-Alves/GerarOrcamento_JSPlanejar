using ClassProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarOrcamento_JSPlanejar
{
    class ClassFormaPagamento
    {
        private int Cod_FormaPagamento;
        private string Descricao;
        private int Cod_Orcamento;

        public int _Cod_FormaPagamento
        {
            get { return Cod_FormaPagamento; }
            set { Cod_FormaPagamento = value; }
        }
        public string _Descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
        public int _Cod_Orcamento
        {
            get { return Cod_Orcamento; }
            set { Cod_Orcamento = value; }
        }

        public void DefinirFormaPagamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Insert into FormaPagamento values (@Descricao, @Cod_Orcamento)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Descricao", _Descricao);
            comando.Parameters.AddWithValue("@Cod_Orcamento", _Cod_Orcamento);
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

        public void ExcluirFormaPagamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Delete FormaPagamento where Cod_Orcamento = @Cod_Orcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Cod_Orcamento", _Cod_Orcamento);
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
    }
}
