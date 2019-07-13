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
    class ClassUsuario
    {
        string stringConn = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);

        private int Cod_Usuario;       
        private string Usuario;
        private string Senha;
        private string DicaSenha;
        private string PerguntaSeguranca;
        private string RespostaSeguranca;

        public int _Cod_Usuario
        {
            get { return Cod_Usuario; }
            set { Cod_Usuario = value; }
        }        
        public string _Usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string _Senha
        {
            get { return Senha; }
            set { Senha = value; }
        }
        public string _DicaSenha
        {
            get { return DicaSenha; }
            set { DicaSenha = value; }
        }
        public string _PerguntaSeguranca
        {
            get { return PerguntaSeguranca; }
            set { PerguntaSeguranca = value; }
        }
        public string _RespostaSeguranca
        {
            get { return RespostaSeguranca; }
            set { RespostaSeguranca = value; }
        }

        string _sql;
        public bool Cadastrar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Cod_Usuario = @CodUsuario";
            SqlDataAdapter comandoSelect = new SqlDataAdapter(_sql, conexao);
            comandoSelect.SelectCommand.Parameters.AddWithValue("@CodUsuario", _Cod_Usuario);            
            comandoSelect.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comandoSelect.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                _sql = "Insert into Usuario (Usuario_Login, Senha_Login, DicaSenha_Login, PerguntaSeguranca, RespostaSeguranca) Values (@Usuario, @Senha, @DicaSenha, @PerguntaSeguranca, @RespostaSeguranca)";
                SqlCommand comando = new SqlCommand(_sql, conexao);
                comando.Parameters.AddWithValue("@Usuario", _Usuario);
                comando.Parameters.AddWithValue("@Senha", _Senha);
                comando.Parameters.AddWithValue("@DicaSenha", _DicaSenha);
                comando.Parameters.AddWithValue("@PerguntaSeguranca", _PerguntaSeguranca);
                comando.Parameters.AddWithValue("@RespostaSeguranca", _RespostaSeguranca);
                comando.CommandText = _sql;
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
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
        public bool Consultar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Cod_Usuario = @ID";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@ID", _Cod_Usuario);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                _Cod_Usuario = int.Parse(Tabela.Rows[0]["Cod_Usuario"].ToString());
                _Usuario = Tabela.Rows[0]["Usuario"].ToString();
                _Senha = Tabela.Rows[0]["Senha"].ToString();
                _DicaSenha = Tabela.Rows[0]["DicaSenha"].ToString();
                _PerguntaSeguranca = Tabela.Rows[0]["PerguntaSeguranca"].ToString();
                _RespostaSeguranca = Tabela.Rows[0]["RespostaSeguranca"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Atualizar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "UPDATE Usuario SET Usuario_Login = @Usuario, Senha_Login = @Senha, DicaSenha_Login = @DicaSenha, PerguntaSeguranca = @PerguntaSeguranca, RespostaSeguranca = @RespostaSeguranca WHERE Cod_Usuario = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", _Cod_Usuario);
            comando.Parameters.AddWithValue("@Usuario", _Usuario);
            comando.Parameters.AddWithValue("@Senha", Senha);
            comando.Parameters.AddWithValue("@DicaSenha", _DicaSenha);
            comando.Parameters.AddWithValue("@PerguntaSeguranca", _PerguntaSeguranca);
            comando.Parameters.AddWithValue("@RespostaSeguranca", _RespostaSeguranca);
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
            SqlConnection conexao = new SqlConnection(stringConn);
            string _sql = "Delete From Usuario where Cod_Usuario = @ID";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@ID", _Cod_Usuario);
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
        public void RedefinirSenha()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Update Usuario set Senha_Login = @Senha where Usuario_Login = @Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Senha", _Senha);
            comando.Parameters.AddWithValue("@Usuario", _Usuario);
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

        public void VerificarCodigoUsuario()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            SqlCommand comando = new SqlCommand("", conexao);
            comando.CommandText = "Select Max(Cod_Usuario) from Usuario";
            try
            {
                conexao.Open();
                _Cod_Usuario = Convert.ToInt32(comando.ExecuteScalar());
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