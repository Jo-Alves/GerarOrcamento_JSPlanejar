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
    public partial class FrmAutenticacao : Form
    {
        public FrmAutenticacao()
        {
            InitializeComponent();
        }
       
        private void FrmAutenticacao_Load(object sender, EventArgs e)
        {
            txt_Senha.Focus();
            UsuarioSistema();
        }

        private void UsuarioSistema()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select Usuario_Login From Usuario";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            cb_Usuario.DisplayMember = "Usuario_Login";
            cb_Usuario.DataSource = Tabela;
        }

        string stringConn = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ClassAutenticacao autenticacao = new ClassAutenticacao();
        string Senha;
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            EntrarSistema();
        }
        string Funcao;
        private void EntrarSistema()
        {
            Senha = Security.Cry(txt_Senha.Text.Trim());
            autenticacao.usuario = cb_Usuario.Text;
            autenticacao.senha = Senha;
            if (autenticacao.Autenticar() == true)
            {
                this.Visible = false;
                FrmTelaPrincipal tp = new FrmTelaPrincipal();
                tp.ShowDialog();
                Application.Exit();
            }
            else if (txt_Senha.Text == "")
            {
                MessageBox.Show("Digite a sua senha!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Senha.Focus();
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Senha.Clear();
                txt_Senha.Focus();
                InformarDicaSenha();
                linkRedefinicao.Visible = true;
            }
        }

        string PerguntaSeguranca, RespostaSeguranca;
        private void InformarDicaSenha()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Usuario_Login = @Usuario";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", cb_Usuario.Text.Trim());
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    lbl_DicaSenha.Text = "Dica de Senha: " + Security.Dry(dr["DicaSenha_Login"].ToString());
                    PerguntaSeguranca = dr["PerguntaSeguranca"].ToString();
                    RespostaSeguranca = dr["RespostaSeguranca"].ToString();
                }
                else
                {
                    Veriguacao = false;
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

        string DicaSenha, AcaoFechar;
        bool Veriguacao;

        private void VerificarUsuario()
        {

            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "Select * from Usuario where Usuario_Login = @Usuario and RespostaSeguranca = @RespostaSeguranca";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Usuario", cb_Usuario.Text.Trim());
            comando.Parameters.AddWithValue("@RespostaSeguranca", rs);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                SqlDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    Veriguacao = true;
                }
                else
                {
                    Veriguacao = false;
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
        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Entrar_Click(sender, e);
            }
        }

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Senha.Clear();
            txt_Senha.Focus();
            lbl_DicaSenha.Text = "";
            linkRedefinicao.Visible = false;
        }


        string rs;
        private void linkRedefinicao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_Senha.Clear();
            txt_Senha.Focus();
            this.Visible = false;
            FrmInformarDicaSenha vnu = new FrmInformarDicaSenha(PerguntaSeguranca);
            vnu.ShowDialog();

            if (vnu.RespostaSeguranca != "")
            {
                rs = vnu.RespostaSeguranca;

                VerificarUsuario();
                if (Veriguacao == false)
                {

                    while (Veriguacao == false)
                    {
                        MessageBox.Show("A resposta de segurança não bate com a Resposta cadastrada no sistema!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        vnu.ShowDialog();
                        rs = vnu.RespostaSeguranca;
                        if (rs != "")
                        {
                            VerificarUsuario();

                            if (Veriguacao == true)
                            {
                                Veriguacao = true;
                            }
                        }
                        else
                        {
                            Veriguacao = true;
                            AcaoFechar = vnu.AcaoFechar;
                        }
                    }
                    if (AcaoFechar == "Fechar")
                    {
                        this.Visible = true;
                    }
                    else
                    {
                        FrmRedefinicaoSenha rs = new FrmRedefinicaoSenha(cb_Usuario.Text);

                        rs.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    FrmRedefinicaoSenha rs = new FrmRedefinicaoSenha(cb_Usuario.Text);
                    rs.ShowDialog();
                    this.Visible = true;
                }
            }
            else
            {
                this.Visible = true;
            }
        }

    }
}
