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
    public partial class FrmBaixarPagamento : Form
    {
        int Cod_Orcamento;
        public FrmBaixarPagamento(int Cod_Orcamento, string Vencimento, string ValorParcela, string NumeroParcela, int CodigoCliente, string NomeCliente, int NTParcelas, string DataPedido)
        {
            InitializeComponent();
            this.Cod_Orcamento = Cod_Orcamento;
            txtCodigoCliente.Text = CodigoCliente.ToString();
            this.CodigoCliente = CodigoCliente;
            txtVencimento.Text = Vencimento;
            this.Vencimento = Vencimento;
            NParcela = int.Parse(NumeroParcela);
            txtvalorParcela.Text = "R$ " + ValorParcela;
            txtNParcelas.Text = NumeroParcela + "/" + NTParcelas;
            txtCodigoCliente.Text = CodigoCliente.ToString();
            txtNome.Text = NomeCliente;
            this.ValorParcela = decimal.Parse(ValorParcela);
            this.NTParcelas = NTParcelas;
        }
        int CodigoCliente, NParcela, NTParcelas;
        string Vencimento;
        private void txt_ValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txtValorPago.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }      

        private void lbl_Fechar_Click(object sender, EventArgs e)
        {
            btn_Cancelar_Click(sender, e);
        }
       private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }    
        private void FrmBaixarParcela_Load(object sender, EventArgs e)
        {
          
        }

        string stringConn = Security.Dry(System.Configuration.ConfigurationSettings.AppSettings["CadeiaConexao"]), _sql;

        private void BaixarParcela()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "update ParcelaPagamento set DP_ParcelaPagamento = @DataPagamento, Hp_ParcelaPagamento = @HoraPagamento from ParcelaPagamento inner join Orcamento on ParcelaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento inner join Cliente on Cliente.Cod_Cliente = Orcamento.Cod_Cliente inner join FormaPagamento on FormaPagamento.Cod_Orcamento = Orcamento.Cod_Orcamento where Cliente.Cod_Cliente = @id and FormaPagamento.Descricao_FormaPagamento = 'Dinheiro(Parcelas)' and ParcelaPagamento.DP_ParcelaPagamento = '' AND ParcelaPagamento.N_ParcelaPagamento = @Parcela and Dv_ParcelaPagamento = @Vencimento AND ParcelaPagamento.Cod_Orcamento = @Cod_Orcamento";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@id", CodigoCliente);
            comando.Parameters.AddWithValue("@DataPagamento", DateTime.Now.ToShortDateString());
            comando.Parameters.AddWithValue("@HoraPagamento", DateTime.Now.ToLongTimeString());
            comando.Parameters.AddWithValue("@Cod_Orcamento", Cod_Orcamento);
            comando.Parameters.AddWithValue("@Parcela", NParcela);
            comando.Parameters.AddWithValue("@Vencimento", Vencimento);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        private void btn_Baixa_Click(object sender, EventArgs e)
        {            
            if (txtValorPago.Text != "")
            {
                txt_ValorPago_Leave(sender, e);
                if (ValorPago >= ValorParcela)
                {                   
                    BaixarParcela();
                    InformarParcelaPaga();
                    VerificarSituacao();
                    MessageBox.Show("Pagamento realizado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Valor pago menor que o valor da conta!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtValorPago.Focus();
                }

            }
            else
            {
                MessageBox.Show("Informe o valor pago!", "Mensagem do sistema 'Gerenciamento Caixa Fácil'...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorPago.Focus();
            }
        }

        private void FrmBaixarParcela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                btn_Baixa_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_Cancelar_Click(sender, e);
            }
        }

        decimal ValorPago, Troco, ValorParcela;

        private void txt_ValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtValorPago.Text != "")
                {
                    txtValorPago.Text = Convert.ToDecimal(txtValorPago.Text.Trim()).ToString("0.00");
                    ValorPago = decimal.Parse(txtValorPago.Text);
                    Troco = ValorPago - ValorParcela;
                    txtTroco.Text = "R$ " + Troco.ToString();
                }
                else
                {
                    txtTroco.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorPago.Clear();
            }
        }


        private void VerificarSituacao()
        {
            SqlConnection conexao = new SqlConnection(stringConn);
            _sql = "select count(Cod_Parcela) as conta from ParcelaPagamento where DP_ParcelaPagamento <> '' and Cod_Orcamento = @Cod";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.Parameters.AddWithValue("@Cod", Cod_Orcamento);
            comando.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                int conta = int.Parse(Tabela.Rows[0]["conta"].ToString());
                ClassOrcamento orcamento = new ClassOrcamento();
                orcamento._Cod_Orcamento = Cod_Orcamento;
                if (conta == NTParcelas)
                {
                    orcamento._Situacao = "Quitado";
                    orcamento.AtualizarSituacao();
                }
            }
        }

        private void InformarParcelaPaga()
        {
            try {
                SqlConnection conexao = new SqlConnection(stringConn);
                _sql = "select count(Cod_Parcela) as conta from ParcelaPagamento where DP_ParcelaPagamento <> '' and Cod_Orcamento = @Cod";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@Cod", Cod_Orcamento);
                comando.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    int conta = int.Parse(Tabela.Rows[0]["conta"].ToString());
                    ClassOrcamento orcamento = new ClassOrcamento();
                    orcamento._Cod_Orcamento = Cod_Orcamento;
                    orcamento._Situacao = conta + " de " + NTParcelas + " parcela(s) - Pago";                    
                    orcamento.AtualizarSituacao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
