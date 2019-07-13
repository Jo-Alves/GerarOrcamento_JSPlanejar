using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmContasClientes : Form
    {
        public FrmContasClientes()
        {
            InitializeComponent();
        }
        private void FrmContasClientes_Load(object sender, EventArgs e)
        {
            dgv_PagamentoParcelas.ClearSelection();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            cod = 0;
            Tabela.Clear();
            dgv_PagamentoParcelas.DataSource = Tabela;
            ValorTotal = 0.00m;
            Vencimento = "";
        }

        private void Limpar()
        {
            txt_nome.Clear();
            lblNome_Cliente.Text = "";
            lblCodigo_Cliente.Text = "";
            lbl_SeparadorDados.Visible = false;                     
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            ValorTotal = 0.00m;
            this.Close();
        }

        private void FrmContasClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Sair_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_Baixar_Click(sender, e);
            }
        }
        int cod = 0;
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente pesquisarCliente = new FrmBuscarCliente();
            pesquisarCliente.ShowDialog();
            if (pesquisarCliente.Codigo > 0)
            {
                txt_nome.Text = pesquisarCliente.Nome;
                lblCodigo_Cliente.Text = pesquisarCliente.Codigo.ToString();
                lblNome_Cliente.Text = pesquisarCliente.Nome;
                lbl_SeparadorDados.Visible = true;
                cod = pesquisarCliente.Codigo;
                PagamentoParcelasCredito();
                if (dgv_PagamentoParcelas.Rows.Count > 0)
                    dgv_PagamentoParcelas.ClearSelection();
            }
        }

        DataTable Tabela;
        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]);
        string _sql;
        private void PagamentoParcelasCredito()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT orcamento.DataPedido_Orcamento, ParcelaPagamento.Cod_Orcamento, ParcelaPagamento.N_ParcelaPagamento, ParcelaPagamento.Dv_ParcelaPagamento, ParcelaPagamento.Vp_ParcelaPagamento FROM Cliente INNER JOIN Orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN FormaPagamento ON Orcamento.Cod_Orcamento = FormaPagamento.Cod_Orcamento INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE (FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)') AND (ParcelaPagamento.DP_ParcelaPagamento = '') AND (Cliente.Cod_Cliente = @id)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@id", cod);
                comando.SelectCommand.CommandText = _sql;
                Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgv_PagamentoParcelas.DataSource = Tabela;
                }
                else
                {
                    Tabela.Clear();
                    dgv_PagamentoParcelas.DataSource = Tabela;
                    MessageBox.Show("Não há conta vinvulado ao cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpar();
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

        private void CarregarDgv()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT orcamento.DataPedido_Orcamento, ParcelaPagamento.Cod_Orcamento, ParcelaPagamento.N_ParcelaPagamento, ParcelaPagamento.Dv_ParcelaPagamento, ParcelaPagamento.Vp_ParcelaPagamento FROM Cliente INNER JOIN Orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN FormaPagamento ON Orcamento.Cod_Orcamento = FormaPagamento.Cod_Orcamento INNER JOIN ParcelaPagamento ON ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento WHERE (FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)') AND (ParcelaPagamento.DP_ParcelaPagamento = '') AND (Cliente.Cod_Cliente = @id)";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@id", cod);
                comando.SelectCommand.CommandText = _sql;
                Tabela = new DataTable();
                comando.Fill(Tabela);
                dgv_PagamentoParcelas.DataSource = Tabela;
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

        decimal ValorTotal;

        private void btn_Baixar_Click(object sender, EventArgs e)
        {
            if (dgv_PagamentoParcelas.Rows.Count > 0)
            {
                if (dgv_PagamentoParcelas.CurrentRow.Selected == true)
                {
                    NomeCliente = lblNome_Cliente.Text.Trim();
                    CodigoCliente = int.Parse(lblCodigo_Cliente.Text);
                    InformarNumeroParcela();
                    FrmBaixarPagamento bp = new FrmBaixarPagamento(Cod_Orcamento, Vencimento, ValorParcela, NumeroParcela, CodigoCliente, NomeCliente, NTParcelas, DataPedido);
                    bp.ShowDialog();
                    CarregarDgv();
                    if (dgv_PagamentoParcelas.Rows.Count > 0)
                        dgv_PagamentoParcelas.CurrentRow.Selected = false;
                }
                else
                {
                    MessageBox.Show("Selecione a parcela para pagamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Informe os dados para baixar o pagamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        int Cod_Orcamento, CodigoCliente, NTParcelas;
        string Vencimento, ValorParcela, NumeroParcela, NomeCliente, DataPedido;
        private void dgv_PagamentoParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cont = e.RowIndex;
            if (Cont > -1)
            {
                DataGridViewRow row = dgv_PagamentoParcelas.Rows[e.RowIndex];
                Cod_Orcamento = int.Parse(row.Cells["ColCod"].Value.ToString());
                NumeroParcela = row.Cells["ColNumero"].Value.ToString();
                Vencimento= row.Cells["ColVencimento"].Value.ToString();
                ValorParcela= row.Cells["ColValor"].Value.ToString();
                DataPedido= row.Cells["ColData"].Value.ToString();
            }
        }

        private void InformarNumeroParcela()
        {
            if (lblCodigo_Cliente.Text == "")
            {
                cod = 0;
            }
            else
            {
                cod = int.Parse(lblCodigo_Cliente.Text);
            }
            SqlConnection conexao = new SqlConnection(stringConn);
            try
            {
                conexao.Open();
                _sql = "SELECT count(ParcelaPagamento.N_ParcelaPagamento) FROM Cliente INNER JOIN Orcamento ON Cliente.Cod_Cliente = Orcamento.Cod_Cliente INNER JOIN FormaPagamento ON Orcamento.Cod_Orcamento = FormaPagamento.Cod_Orcamento INNER JOIN ParcelaPagamento ON Orcamento.Cod_Orcamento = ParcelaPagamento.Cod_Orcamento WHERE (FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)')AND (Cliente.Cod_Cliente = @Cod_CLiente) AND ParcelaPagamento.Cod_Orcamento = @Cod_Orcamento";
                SqlCommand comando = new SqlCommand(_sql, conexao); comando.Parameters.AddWithValue("@Cod_Cliente", cod); comando.Parameters.AddWithValue("@Cod_Orcamento", Cod_Orcamento);
                comando.CommandText = _sql;
                NTParcelas = int.Parse(comando.ExecuteScalar().ToString());

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
    }
}