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
    public partial class FrmContasReceber : Form
    {
        public FrmContasReceber()
        {
            InitializeComponent(); 
            ContasReceberParcelaDinheiro();
            ContasReceberCredito();
            ValorContasReceberCredito();
            ValorContasReceberParcelaDinheiro();
            ValorTotalReceber = ValorReceberParcela + ValorReceberCredito;
            lbl_ValorTotal.Text = "R$ " + ValorTotalReceber;
            if (dgvParcelasCredito.Rows.Count > 0)
            {
                dgvParcelasCredito.CurrentRow.Selected = false;
            }
        }

        decimal ValorReceberParcela, ValorReceberCredito, ValorTotalReceber;

        private void ValorContasReceberParcelaDinheiro()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(ParcelaPagamento.Vp_ParcelaPagamento) FROM Cliente INNER JOIN" +
                " orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento where " +
                "FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)' and" +
                " ParcelaPagamento.DP_ParcelaPagamento = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorReceberParcela = 0.00m;
                    lbl_ValorParcela.Text = "R$ " + ValorReceberParcela;
                }
                else
                {
                    ValorReceberParcela = decimal.Parse(comando.ExecuteScalar().ToString());
                    lbl_ValorParcela.Text = "R$ " + ValorReceberParcela;
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

        private void ValorContasReceberCredito()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT sum(ParcelaPagamento.Vp_ParcelaPagamento) " +
                "FROM Cliente INNER JOIN orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente " +
                "INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento where FormaPagamento.Descricao_FormaPagamento = 'Crédito' and ParcelaPagamento.DP_ParcelaPagamento = ''";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.CommandText = _sql;
            try
            {
                conexao.Open();

                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    ValorReceberCredito = 0.00m;
                    lblValorCredito.Text = "R$ " + ValorReceberCredito;
                }
                else
                {
                    ValorReceberCredito = decimal.Parse(comando.ExecuteScalar().ToString());
                    lblValorCredito.Text = "R$ " + ValorReceberCredito;
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

        private void FrmContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                TabContasReceber.SelectedTab = tabPage_Parcelas;
            else if (e.KeyCode == Keys.F2)
                TabContasReceber.SelectedTab = tabPageCredito;
        }       

        string stringConn = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]), _sql;

        private void dgvParcelasCredito_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgvParcelasCredito.ClearSelection();
        }

        private void ContasReceberCredito()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cliente.Cod_Cliente, Cliente.Nome_Cliente, Orcamento.Cod_Orcamento, ParcelaPagamento.N_ParcelaPagamento, ParcelaPagamento.Dv_ParcelaPagamento, ParcelaPagamento.Vp_ParcelaPagamento FROM Cliente INNER JOIN Orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN  FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE(ParcelaPagamento.DP_ParcelaPagamento = '') AND(FormaPagamento.Descricao_FormaPagamento = 'Crédito')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgvParcelasCredito.DataSource = Tabela;
        }

        private void ContasReceberParcelaDinheiro()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "SELECT Cliente.Cod_Cliente, Cliente.Nome_Cliente, Orcamento.Cod_Orcamento, ParcelaPagamento.N_ParcelaPagamento, ParcelaPagamento.Dv_ParcelaPagamento, ParcelaPagamento.Vp_ParcelaPagamento FROM Cliente INNER JOIN Orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento INNER JOIN  FormaPagamento ON FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE(ParcelaPagamento.DP_ParcelaPagamento = '') AND(FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)')";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            dgvParcela.DataSource = Tabela;
        }

        private void dgvParcela_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView dgv;
            dgv = (DataGridView)sender;
            dgvParcela.ClearSelection();
        }
    }
}
