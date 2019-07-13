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
    class ClassAutenticacao
    {

        string stringConn = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        private int Cod_Usuario;
        private string Usuario;
        private string Senha;
        private string Funcao;

        public int id
        {
            get { return Cod_Usuario; }
            set { Cod_Usuario = value; }
        }
        public string usuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        public string senha
        {
            get { return Senha; }
            set { Senha = value; }
        }
        public string funcao
        {
            get { return Funcao; }
            set { Funcao = value; }
        }

        public bool Autenticar()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            string _Sql = "Select * from Usuario where Usuario_Login = @Usuario and Senha_Login = @Senha";
            SqlDataAdapter comando = new SqlDataAdapter(_Sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
            comando.SelectCommand.Parameters.AddWithValue("@Senha", senha);            
            comando.SelectCommand.CommandText = _Sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                id = int.Parse(Tabela.Rows[0]["Cod_Usuario"].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
