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
    public partial class FrmNovoOrcamento : Form
    {
        int Cod_Cliente, Quantidade, Cod_Peça;
        string Descricao;
        decimal ValorTotal, SubTotal, PrecoUnitario;

        public FrmNovoOrcamento()
        {
            InitializeComponent();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (lblCliente.Text != "" && ValorTotal > 0.00m)
            {
                this.Visible = false;
                FrmFinalizarOrcamento fo = new FrmFinalizarOrcamento(ValorTotal, Cod_Cliente);
                fo.ShowDialog();
                if (fo.voltar == true)
                {
                    this.Visible = true;
                }
                else
                {
                    InserirItens();
                    MessageBox.Show("Orçamento gerado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvitens.Rows.Clear();
                    this.Close();
                }
            }
            else if (lblCliente.Text == "")
            {
                MessageBox.Show("Informe o nome do cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ValorTotal == 0.00m)
            {
                MessageBox.Show("Adicione itens para a finalização do orçamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InserirItens()
        {
            try
            {
                ClassItensPeça itensPeça = new ClassItensPeça();
                ClassOrcamento orcamento = new ClassOrcamento();
                orcamento.GerarCodigoOrcamento();
                int CodOrcamento = orcamento._Cod_Orcamento;
                for (int i = 0; i < dgvitens.Rows.Count; i++)
                {
                    itensPeça._CodPeça = int.Parse(dgvitens.Rows[i].Cells[0].Value.ToString());
                    itensPeça._QuantidadeItens = int.Parse(dgvitens.Rows[i].Cells[2].Value.ToString());
                    itensPeça._Preco = decimal.Parse(dgvitens.Rows[i].Cells[4].Value.ToString());
                    itensPeça._CodOrcamento = CodOrcamento;
                    itensPeça.InserirItens();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (dgvitens.Rows.Count >= 1)
            {
                if (MessageBox.Show("Existe itens em aberto. Deseja mesmo sair sem concluir o orçamento?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
                Close();
        }

        private void btnCancelarTudo_Click(object sender, EventArgs e)
        {
            if (dgvitens.Rows.Count >= 1)
            {
                if (MessageBox.Show("Deseja mesmo cancelar o(s) item(ns)?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dgvitens.Rows.Clear();
                    ValorTotal = 0.00m;
                    lblValorTotal.Text = "R$ " + ValorTotal;
                    Cod_Peça = 0;
                }
                txtDescricaoPecas.Focus();
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantidade.Text))
            { int qt = int.Parse(txtQuantidade.Text);
                if (qt == 0)
                {
                    txtQuantidade.Text = "1";
                }
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Adicione a quantidade!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantidade.Focus();
            }
            else if (Cod_Peça == 0)
            {
                MessageBox.Show("Selecione itens para adicionar!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescricaoPecas.Focus();
            }
            else
            {
                Quantidade = int.Parse(txtQuantidade.Text);
                SubTotal = Quantidade * PrecoUnitario;
                dgvitens.Rows.Add(Cod_Peça, Descricao, Quantidade, PrecoUnitario, SubTotal);
                dgvitens.CurrentRow.Selected = false;
                ValorTotal += SubTotal;
                lblValorTotal.Text = "R$ " + ValorTotal;
                txtDescricaoPecas.Clear();
                txtQuantidade.Text = "1";
                txtDescricaoPecas.Focus();
                Cod_Peça = 0;
            }
        }

        private void dgvitens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegamos o indice da linha do datagrid
            int contLinha = e.RowIndex;
            //caso o índice for maior a instrução abaixo será executada
            if (contLinha > -1)
            {
                DataGridViewRow row = dgvitens.Rows[contLinha];
                SubTotal = decimal.Parse(row.Cells[4].Value.ToString());
            }
        }

        private void txtDescricaoPecas_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricaoPecas.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pnDados.Visible = true;
                    CarregarDGV();
                    if (dgvDadosPeças.Rows.Count > 0)
                        dgvDadosPeças.CurrentRow.Selected = false;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnLancar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back)
            {
                pnDados.Visible = false;
            }
        } 

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLancar_Click(sender, e);
            }
        }

        private void txtDescricaoPecas_DoubleClick(object sender, EventArgs e)
        {
            pnDados.Visible = true;
            CarregarDGV();
            if (dgvDadosPeças.Rows.Count > 0)
                dgvDadosPeças.CurrentRow.Selected = false;
        }

        private void CarregarDGV()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Select * from Peça";
            SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            dgvDadosPeças.DataSource = Tabela;
        }

        private void FrmNovoOrcamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvitens.Rows.Count >= 1)
            {
                if (MessageBox.Show("Existe itens em aberto. Deseja mesmo sair sem concluir o orçamento?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = false;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDadosPeças_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegamos o indice da linha do datagrid
            int contLinha = e.RowIndex;
            //caso o índice for maior a instrução abaixo será executada
            if (contLinha > -1)
            {
                DataGridViewRow row = dgvDadosPeças.Rows[contLinha];
                Cod_Peça = int.Parse(row.Cells[0].Value.ToString());
                Descricao = row.Cells[1].Value.ToString();
                PrecoUnitario = decimal.Parse(row.Cells[2].Value.ToString());
                txtDescricaoPecas.Text = Descricao;
                pnDados.Visible = false;
                txtDescricaoPecas.Focus();
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            if (dgvitens.Rows.Count >= 1)
            {
                //se houver linha selecionada a isntrução abaixo será executada
                //se não o usuário receberá uma mensagem para selecionar itens para cancelamento do item desejado
                if (dgvitens.CurrentRow.Selected == true)
                {
                    //Remove a linha selecionada
                    dgvitens.Rows.Remove(dgvitens.CurrentRow);
                    // a variável ValorTotal irá receber o valor dela subitraindo com o valor do subtTotal irá diminuir
                    ValorTotal -= SubTotal;
                    lblValorTotal.Text = "R$ " + ValorTotal;
                    //Zeramos a variável
                    Cod_Peça = 0;
                    //Se conter linhas no datagrid a seleção do datagrid será removida
                    if (dgvitens.Rows.Count >= 1)
                    {
                        dgvitens.CurrentRow.Selected = false;
                    }
                    txtDescricaoPecas.Focus();
                }
                else
                {
                    MessageBox.Show("Selecione o item a ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricaoPecas.Focus();
                }               
            }
        }

        private void btnDadosCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscarCliente = new FrmBuscarCliente();
            buscarCliente.ShowDialog();
            if (buscarCliente.Codigo != 0)
            {
                Cod_Cliente = buscarCliente.Codigo;
                lblCliente.Text = buscarCliente.Nome;
            }
            txtDescricaoPecas.Focus();
        }

        private void txtDescricaoPecas_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Select * from Peça where Descricao_Peça like '%" + txtDescricaoPecas.Text.Trim() + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            if (!string.IsNullOrEmpty(txtDescricaoPecas.Text.Trim()))
            {
                if (Tabela.Rows.Count > 0)
                {
                    dgvDadosPeças.DataSource = Tabela;
                    pnDados.Visible = true;
                    if (dgvDadosPeças.Rows.Count > 0)
                        dgvDadosPeças.CurrentRow.Selected = false;
                }
            }
            else
            {
                pnDados.Visible = false;
            }
        }
    }
}
