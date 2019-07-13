using ClassProject;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarOrcamento_JSPlanejar
{
    class ClassItensPeça
    {
        private int CodItens;
        private int QuantidadeItens;
        private decimal Preco;
        private int CodOrcamento;
        private int CodPeça;

        public int _CodItens
        {
            get { return CodItens; }
            set { CodItens = value; }
        }
        public int _QuantidadeItens
        {
            get { return QuantidadeItens; }
            set { QuantidadeItens  = value; }
        }

        public decimal _Preco
        {
            get { return Preco; }
            set { Preco = value; }
        }
        public int _CodOrcamento
        {
            get { return CodOrcamento; }
            set { CodOrcamento = value; }
        }
        public int _CodPeça
        {
            get { return CodPeça; }
            set { CodPeça = value; }
        }

        public void InserirItens()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "insert into ItensPeça values (@Quantidade, @Preco, @CodOrcamento, @CodPeça)";
            SqlCommand comando = new SqlCommand(_sql,conexao);
            comando.Parameters.AddWithValue("@Quantidade", _QuantidadeItens);
            comando.Parameters.AddWithValue("@Preco", _Preco);
            comando.Parameters.AddWithValue("@CodOrcamento", _CodOrcamento);
            comando.Parameters.AddWithValue("@CodPeça", _CodPeça);
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

        public void AtualizarItens()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Update ItensPeça set Quantidade_Itens = @Quantidade, Preço_itens = @Preco, Cod_Peça = @CodPeça where Cod_Orcamento = @CodOrcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Quantidade", _QuantidadeItens);
            comando.Parameters.AddWithValue("@Preco", _Preco);
            comando.Parameters.AddWithValue("@CodOrcamento", _CodOrcamento);
            comando.Parameters.AddWithValue("@CodPeça", _CodPeça);
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

        public void ExcluirItens()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Delete from ItensPeça where Cod_Orcamento = @CodOrcamento or Cod_Peça = @CodPeça";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodPeça", _CodPeça);
            comando.Parameters.AddWithValue("@CodOrcamento", _CodOrcamento);
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

