using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarImagem();
            InformarLinhasTabelaParcelaCredito();
            VerificarParcelasCredito();
        }

        int conta;
        private void InformarLinhasTabelaParcelaCredito()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]));
                string _sql = "SELECT COUNT(ParcelaPagamento.dv_ParcelaPagamento) AS conta FROM ORCAMENTO INNER JOIN FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE FormaPagamento.Descricao_FormaPagamento = 'crédito' AND ParcelaPagamento.DP_ParcelaPagamento = '' AND dv_ParcelaPagamento = '" + DateTime.Now.ToShortDateString() + "'";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    conta = int.Parse(Tabela.Rows[0]["conta"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int Cod_orcamento;
        private void VerificarParcelasCredito()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]));
                string _sql = "SELECT Orcamento.Cod_orcamento FROM ORCAMENTO INNER JOIN FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE FormaPagamento.Descricao_FormaPagamento = 'crédito' AND ParcelaPagamento.DP_ParcelaPagamento = '' AND ParcelaPagamento.Dv_ParcelaPagamento = '" + DateTime.Now.ToShortDateString() + "'";
                for (int i = 0; i < conta; i++)
                {
                    SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                    comando.SelectCommand.CommandText = _sql;
                    DataTable Tabela = new DataTable();
                    comando.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        Cod_orcamento = int.Parse(Tabela.Rows[0]["Cod_Orcamento"].ToString());
                        VerificarAtualizarParcelas();
                        ContarParcelasPagas();
                        ContarParcelasTotal();
                        ClassOrcamento orcamento = new ClassOrcamento();
                        orcamento._Cod_Orcamento = Cod_orcamento;
                        orcamento._Situacao = NParcelasP + " de " + NTParcela + " parcela(s) - Pago";
                        orcamento.AtualizarSituacao();
                        QuitarParcelasCredito();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitarParcelasCredito()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]));
                string _sql = "select COUNT(ParcelaPagamento.Cod_Orcamento) as Conta from ParcelaPagamento inner join FormaPagamento on formaPagamento.Cod_Orcamento = ParcelaPagamento.Cod_Orcamento where FormaPagamento.Descricao_FormaPagamento='Crédito' and ParcelaPagamento.dp_ParcelaPagamento <> '' and ParcelaPagamento.Cod_Orcamento = @Cod";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@Cod", Cod_orcamento);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    if (NParcelasP == NTParcela)
                    {
                        ClassOrcamento orcamento = new ClassOrcamento();
                        orcamento._Cod_Orcamento = Cod_orcamento;
                        orcamento._Situacao = "Quitado";
                        orcamento.AtualizarSituacao();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int NParcelasP;
        private void ContarParcelasPagas()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]));
                string _sql = "select COUNT(ParcelaPagamento.Cod_Orcamento) as Conta from ParcelaPagamento inner join FormaPagamento on formaPagamento.Cod_Orcamento = ParcelaPagamento.Cod_Orcamento where FormaPagamento.Descricao_FormaPagamento='Crédito' and ParcelaPagamento.Dp_ParcelaPagamento <> '' and ParcelaPagamento.Cod_Orcamento = @Cod";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@Cod", Cod_orcamento);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    NParcelasP = int.Parse(Tabela.Rows[0]["Conta"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int NTParcela;
        private void ContarParcelasTotal()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]));
                string _sql = "select COUNT(ParcelaPagamento.Cod_Orcamento) as Conta from ParcelaPagamento inner join FormaPagamento on formaPagamento.Cod_Orcamento = ParcelaPagamento.Cod_Orcamento where FormaPagamento.Descricao_FormaPagamento='Crédito' and ParcelaPagamento.Cod_Orcamento = @Cod";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@Cod", Cod_orcamento);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    NTParcela = int.Parse(Tabela.Rows[0]["Conta"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ClassParcelaPagamento parcelaPagamento = new ClassParcelaPagamento();
        private void VerificarAtualizarParcelas()
        {
            try
            {
                parcelaPagamento._Cod_Orcamento = Cod_orcamento;
                parcelaPagamento._DataPagamento = DateTime.Now.ToShortDateString();
                parcelaPagamento._HoraPagamento = DateTime.Now.ToLongTimeString();
                parcelaPagamento.AtualizarParcelasCredito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarImagem()
        {
            ClassEmpresa empresa = new ClassEmpresa();
            try
            {
                empresa.Consultar();
                if (!string.IsNullOrEmpty(empresa.logoEmpresa))
                    pbLogoEmpresa.Load(empresa.logoEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuCliente_Click(object sender, EventArgs e)
        {
            FrmCliente Cliente = new FrmCliente();
            Cliente.ShowDialog();
        }

        private void lblCadastroCliente_MouseEnter(object sender, EventArgs e)
        {
            this.lblCadastroCliente.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblCadastroCliente_MouseLeave(object sender, EventArgs e)
        {
            this.lblCadastroCliente.BorderStyle = BorderStyle.None;
        }

        private void lblGerarOrcamento_MouseEnter(object sender, EventArgs e)
        {
            lblGerarOrcamento.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblGerarOrcamento_MouseLeave(object sender, EventArgs e)
        {
            lblGerarOrcamento.BorderStyle = BorderStyle.None;
        }

        private void lblAtualizarPecas_MouseEnter(object sender, EventArgs e)
        {
            lblAtualizarPecas.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblAtualizarPecas_MouseLeave(object sender, EventArgs e)
        {
            lblAtualizarPecas.BorderStyle = BorderStyle.None;
        }

        private void lblCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void MenuPecas_Click(object sender, EventArgs e)
        {
            FrmPeças Peças = new FrmPeças();
            Peças.ShowDialog();
        }

        private void lblAtualizarPecas_Click(object sender, EventArgs e)
        {
            MenuPecas_Click(sender, e);
        }

        private void lblGerarOrcamento_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento gerarOrcamento = new FrmGerarOrcamento();
            gerarOrcamento.ShowDialog();
            if (string.IsNullOrEmpty(gerarOrcamento.Diretorio))
            {
                ClassEmpresa empresa = new ClassEmpresa();
                empresa.Consultar();
                if (!string.IsNullOrEmpty(empresa.logoEmpresa))
                    pbLogoEmpresa.Load(empresa.logoEmpresa);
                else
                    pbLogoEmpresa.Image = Properties.Resources.JS_Planejar;
            }
            else
            {
                if (!string.IsNullOrEmpty(gerarOrcamento.Diretorio))
                    pbLogoEmpresa.Load(gerarOrcamento.Diretorio);
            }
        }

        private void MenuGerarOrçamento_Click(object sender, EventArgs e)
        {
            FrmGerarOrcamento gerarOrcamento = new FrmGerarOrcamento();
            gerarOrcamento.ShowDialog();
            if (string.IsNullOrEmpty(gerarOrcamento.Diretorio))
            {
                ClassEmpresa empresa = new ClassEmpresa();
                empresa.Consultar();
                if (!string.IsNullOrEmpty(empresa.logoEmpresa))
                    pbLogoEmpresa.Load(empresa.logoEmpresa);
                else
                    pbLogoEmpresa.Image = Properties.Resources.JS_Planejar;
            }
            else
            {
                if (!string.IsNullOrEmpty(gerarOrcamento.Diretorio))
                    pbLogoEmpresa.Load(gerarOrcamento.Diretorio);
            }
        }

        private void MenuEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa empresa = new FrmEmpresa();
            empresa.ShowDialog();
            if (string.IsNullOrEmpty(empresa.Diretorio))
                this.pbLogoEmpresa.Image = Properties.Resources.JS_Planejar;
            else
            {
                if (!string.IsNullOrEmpty(empresa.Diretorio))
                    pbLogoEmpresa.Load(empresa.Diretorio);
            }
        }

        private void MenuContasAReceber_Click(object sender, EventArgs e)
        {
            FrmContasReceber cr = new FrmContasReceber();
            cr.ShowDialog();
        }

        private void MenuContasClientes_Click(object sender, EventArgs e)
        {
            FrmContasClientes contasClientes = new FrmContasClientes();
            contasClientes.ShowDialog();
        }

        private void MenuCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Calc.exe");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MenuSair_Click(sender, e);
            }
        }

        private void FrmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmFechar fechar = new FrmFechar();
            fechar.ShowDialog();
            if (fechar.Fechar == false)
            {
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }

        private void lbConfirmarPagamento_Click(object sender, EventArgs e)
        {
            FrmContasClientes contasClientes = new FrmContasClientes();
            contasClientes.ShowDialog();
        }

        private void lblContaCliente_MouseEnter(object sender, EventArgs e)
        {
            lblContaCliente.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblContaCliente_MouseLeave(object sender, EventArgs e)
        {
            lblContaCliente.BorderStyle = BorderStyle.None;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblRodape.Text = DateTime.Now.ToString();
        }
    }
}
