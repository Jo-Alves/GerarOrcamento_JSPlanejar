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
    class ClassParcelaPagamento
    {
        private int N_parcela;
        private decimal ValorParcela;
        private string DataVencimento;
        private string DataPagamento;
        private string HoraPagamento;
        private int Cod_Orcamento;

        public int _Nparcela
        {
            get { return N_parcela; }
            set { N_parcela = value; }
        }
        public decimal _ValorParcela
        {
            get { return ValorParcela; }
            set { ValorParcela = value; }
        }
        public string _DataVencimento
        {
            get { return DataVencimento; }
            set { DataVencimento = value; }
        }
        public string _DataPagamento
        {
            get { return DataPagamento; }
            set { DataPagamento = value; }
        }
        public string _HoraPagamento
        {
            get { return HoraPagamento; }
            set { HoraPagamento = value; }
        }
        public int _Cod_Orcamento
        {
            get { return Cod_Orcamento; }
            set { Cod_Orcamento = value; }
        }

        public void GerarParcelaPagamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Insert into ParcelaPagamento values (@N_Parcela, @ValorParcela, @DataVencimento, @DataPagamento, @HoraPagamento, @CodOrcamento)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@N_Parcela", _Nparcela);
            comando.Parameters.AddWithValue("@ValorParcela", _ValorParcela);
            comando.Parameters.AddWithValue("@DataVencimento", _DataVencimento);
            comando.Parameters.AddWithValue("@DataPagamento", _DataPagamento);
            comando.Parameters.AddWithValue("@HoraPagamento", _HoraPagamento);
            comando.Parameters.AddWithValue("@CodOrcamento", _Cod_Orcamento);
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

        public void ExcluirParcelas()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Delete from ParcelaPagamento where Cod_Orcamento = @CodOrcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);           
            comando.Parameters.AddWithValue("@CodOrcamento", _Cod_Orcamento);
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

        public void AtualizarParcelasCredito()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Update ParcelaPagamento set Dp_ParcelaPagamento = @DataPagamento, " +
                "Hp_ParcelaPagamento = @HoraPagamento from ParcelaPagamento inner join FormaPagamento on FormaPagamento.Cod_Orcamento = ParcelaPagamento.Cod_Orcamento where " +
                "FormaPagamento.Descricao_FormaPagamento = 'Crédito' and ParcelaPagamento.dv_ParcelaPagamento = @DataVencimento and ParcelaPagamento.Cod_Orcamento = @Cod";
            SqlCommand comando = new SqlCommand(_sql, conexao); comando.Parameters.AddWithValue("@Cod", _Cod_Orcamento); comando.Parameters.AddWithValue("@DataVencimento", DateTime.Now.ToShortDateString());
            comando.Parameters.AddWithValue("@DataPagamento", _DataPagamento);
            comando.Parameters.AddWithValue("@HoraPagamento", _HoraPagamento);
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
