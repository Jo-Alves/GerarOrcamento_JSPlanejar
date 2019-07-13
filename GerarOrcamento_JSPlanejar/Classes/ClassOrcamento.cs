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
    class ClassOrcamento
    {
        private int Cod_Orcamento;
        private decimal ValorPeças_Orcamento;
        private decimal ValorTotal_Orcamento;
        private decimal ValorMaoObra;
        private string ProdutoFinal;
        private string DataPedido;
        private string EstimativaEntrga;
        private string Situacao;
        private int CodCliente;

        public int _Cod_Orcamento
        {
            get { return Cod_Orcamento; }
            set { Cod_Orcamento = value; }
        }

        public decimal _ValorPeças_Orcamento
        {
            get { return ValorPeças_Orcamento; }
            set { ValorPeças_Orcamento = value; }
        }

        public decimal _ValorTotal_Orcamento
        {
            get { return ValorTotal_Orcamento; }
            set { ValorTotal_Orcamento = value; }
        }

        public decimal _ValorMaoObra
        {
            get { return ValorMaoObra; }
            set { ValorMaoObra = value; }
        }

        public string _ProdutoFinal
        {
            get { return ProdutoFinal; }
            set { ProdutoFinal = value; }
        }

        public string _DataPedido
        {
            get { return DataPedido; }
            set { DataPedido = value; }
        }

        public string _EstimativaEntrega
        {
            get { return EstimativaEntrga; }
            set { EstimativaEntrga = value; }
        }

        public string _Situacao
        {
            get { return Situacao; }
            set { Situacao = value; }
        }
        public int _CodCliente
        {
            get { return CodCliente; }
            set { CodCliente = value; }
        }
       
        public void GerarOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "insert into Orcamento values (@ValorPeças, @ValorMaoObra, @ValorTotal, @DataPedido, @EstimativaEntrega, @Situacao, @ProdutoFinal, @CodCliente)";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorPeças", _ValorPeças_Orcamento);
            comando.Parameters.AddWithValue("@ValorMaoObra", _ValorMaoObra);
            comando.Parameters.AddWithValue("@ValorTotal", _ValorTotal_Orcamento);
            comando.Parameters.AddWithValue("@DataPedido",_DataPedido);
            comando.Parameters.AddWithValue("@EstimativaEntrega", _EstimativaEntrega);
            comando.Parameters.AddWithValue("@Situacao", _Situacao);
            comando.Parameters.AddWithValue("@ProdutoFinal", _ProdutoFinal);
            comando.Parameters.AddWithValue("@CodCliente", _CodCliente);
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

        public void GerarCodigoOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "select Max(Cod_Orcamento) from Orcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() != DBNull.Value)
                {
                    _Cod_Orcamento = int.Parse(comando.ExecuteScalar().ToString());
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

        public void AtualizarSituacao()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "update Orcamento set Situacao_Orcamento = @Situacao where Cod_Orcamento = @CodOrcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Situacao", _Situacao);
            comando.Parameters.AddWithValue("CodOrcamento", _Cod_Orcamento);
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

        public void AtualizarOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "update Orcamento set ValorPeças_Orcamento = @ValorPeças, ValorMaoObra_Orcamento = @ValorMaoObra, ValorTotal_Orcamento = @ValorTotal, EstimativaEntrega_Orcamento = @EstimativaEntrega, ProdutoFinal_Orcamento = @ProdutoFinal, Situacao_Orcamento = @Situacao where Cod_Orcamento = @CodOrcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ValorPeças", _ValorPeças_Orcamento);
            comando.Parameters.AddWithValue("@ValorMaoObra", _ValorMaoObra);
            comando.Parameters.AddWithValue("@ValorTotal", _ValorTotal_Orcamento);
            comando.Parameters.AddWithValue("@EstimativaEntrega", _EstimativaEntrega);
            comando.Parameters.AddWithValue("@ProdutoFinal", _ProdutoFinal);
            comando.Parameters.AddWithValue("@Situacao", _Situacao);
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

        public void ExcluirOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Delete from orcamento where Cod_Orcamento = @Codigo";
                SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", _Cod_Orcamento);
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

        public void Buscar()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Select ValorPeças_Orcamento, ValorMaoObra_Orcamento from orcamento where Cod_Orcamento = @Codigo";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Codigo", _Cod_Orcamento);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    _ValorPeças_Orcamento = decimal.Parse(dr["ValorPeças_Orcamento"].ToString());
                    _ValorMaoObra = decimal.Parse(dr["ValorMaoObra_Orcamento"].ToString());
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
