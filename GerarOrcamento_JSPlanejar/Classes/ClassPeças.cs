using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerarOrcamento_JSPlanejar.Classes
{
    class ClassPeça
    {
        private string Conexao;
        private int Codigo_Peça;
        private string Descricao_Peça;
        private decimal Valor_Peça;
        private string Comprimento_Peça;
        private string Unidade_Peça;

        public string _Conexao
        {
            get { return Conexao; }
            set { Conexao = value; }
        }
        public int _CodigoPeça
        {
            get { return Codigo_Peça; }
            set { Codigo_Peça = value; }
        }
        public string _DescricaoPeça
        {
            get { return Descricao_Peça; }
            set{ Descricao_Peça = value; }
        }
        public decimal _ValorPeça
        {
            get { return Valor_Peça; }
            set { Valor_Peça = value; }
        }
        public string _ComprimentoPeça
        {
            get { return Comprimento_Peça; }
            set { Comprimento_Peça = value; }
        }
        public string _UnidadePeça
        {
            get { return Unidade_Peça; }
            set { Unidade_Peça = value; }
        }

        string _sql;
        public bool Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(_Conexao);
            _sql = "Select * from Peça where Cod_Peça = @CodPeça";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@CodPeça", _CodigoPeça);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (Tabela.Rows.Count == 0)
            {
                _sql = "Insert into Peça values(@DescricaoPeça, @ValorPeça, @ComprimentoPeça, @UnidadePeça)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@DescricaoPeça", _DescricaoPeça);
                comando.Parameters.AddWithValue("@ValorPeça", _ValorPeça);
                comando.Parameters.AddWithValue("@ComprimentoPeça", _ComprimentoPeça);
                comando.Parameters.AddWithValue("@UnidadePeça", _UnidadePeça);
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
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Atualizar()
        {
            SqlConnection conexao = new SqlConnection(_Conexao);
            _sql = "Update Peça set Descricao_Peça = @DescricaoPeça, Valor_Peça = @ValorPeça, Comprimento_Peça = @ComprimentoPeça, Unidade_Peça = @UnidadePeça where Cod_Peça = @CodigoPeça";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodigoPeça", _CodigoPeça);
            comando.Parameters.AddWithValue("@DescricaoPeça", _DescricaoPeça);
            comando.Parameters.AddWithValue("@ValorPeça", _ValorPeça);
            comando.Parameters.AddWithValue("@ComprimentoPeça", _ComprimentoPeça);
            comando.Parameters.AddWithValue("@UnidadePeça", _UnidadePeça);
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

        public void Excluir()
        {
            SqlConnection conexao = new SqlConnection(_Conexao);
            _sql = "Delete from Peça where Cod_Peça = @CodigoPeça";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodigoPeça", _CodigoPeça);
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

        }

        public void VerificarCodigo()
        {
            SqlConnection conexao = new SqlConnection(_Conexao);
            _sql = "Select max(Cod_Peça) from Peça";
            SqlCommand comando = new SqlCommand(_sql, conexao);            
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
               _CodigoPeça = int.Parse(comando.ExecuteScalar().ToString());
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
