using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmCarregamentoSistemaGerarOrcamento_JSPlanejar : Form
    {
        public FrmCarregamentoSistemaGerarOrcamento_JSPlanejar()
        {
            InitializeComponent();            
        }

        private void timerCarregar_Tick(object sender, EventArgs e)
        {
            if (pB_Carregar.Value < 100)
            {
                pB_Carregar.Value += 2;
            }
            else
            {
                timerCarregar.Enabled = false;
                this.Visible = false;
                VerificarDataBase();
                if (Retorno == true)
                {
                    VerificarCadastroUsuario();
                    if (Situacao == true)
                    {
                        if (Situacao == true)
                        {
                            FrmAutenticacao autenticacao = new FrmAutenticacao();
                            autenticacao.ShowDialog();
                            this.Visible = false;
                            Application.Exit();
                        }                       
                    }
                    else
                    {
                        FrmUsuario usuario = new FrmUsuario();
                        usuario.ShowDialog();
                        VerificarCadastroUsuario();
                        if (Situacao == true)
                        {
                            if (Situacao == true)
                            {
                                FrmAutenticacao autenticacao = new FrmAutenticacao();
                                autenticacao.ShowDialog();
                                this.Visible = false;
                                Application.Exit();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                            Application.Exit();
                    }
                }
                else
                {
                    FrmRestauracaoSistema restauracaoSistema = new FrmRestauracaoSistema();
                    restauracaoSistema.ShowDialog();
                    VerificarDataBase();
                    if(Retorno == true)
                    {
                        FrmAutenticacao autenticacao = new FrmAutenticacao();
                        autenticacao.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        string stringConnMaster = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexaoMaster"]), _sql;
        bool Retorno;
        private void VerificarDataBase()
        {
            SqlConnection conexao = new SqlConnection(stringConnMaster);
            _sql = "Select * from Sys.Databases where name = 'dbControleOrcamento'";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    Retorno = true;
                }
                else
                {
                    Retorno = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        bool Situacao;       

        private void VerificarCadastroUsuario()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            SqlCommand comando = new SqlCommand("Select * from Usuario", conexao);
            comando.CommandType = CommandType.Text;
            try
            {
                conexao.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    Situacao = true;
                }
                else
                {
                    Situacao = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
