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
    public partial class FrmAtualizarOrcamento : Form
    {
        int Cod_Cliente, Quantidade, Cod_Peça, Cod_Orcamento;
        string Descricao, EstimativaEntrega, ProdutoFinal;
        decimal ValorTotal, SubTotal, PrecoUnitario, Acrescimo, valorTotalOrcamento;

        public FrmAtualizarOrcamento(int Cod_Orcamento, int Cod_Cliente, string NomeCliente)
        {
            InitializeComponent();
            this.Cod_Orcamento = Cod_Orcamento;
            lblCliente.Text = NomeCliente;
            this.Cod_Cliente = Cod_Cliente;
            CarregarItens();
            CarregarOrcamento();
        }

        private void CarregarOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
                adapter.SelectCommand.CommandText = "Select * from Orcamento where orcamento.Cod_orcamento = " + Cod_Orcamento;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    lblValorTotal.Text = Tabela.Rows[0]["ValorPeças_Orcamento"].ToString();
                    ValorTotal = decimal.Parse(Tabela.Rows[0]["ValorPeças_Orcamento"].ToString());
                    Acrescimo = decimal.Parse(Tabela.Rows[0]["ValorMaoObra_Orcamento"].ToString());
                    valorTotalOrcamento = decimal.Parse(Tabela.Rows[0]["ValorTotal_Orcamento"].ToString());
                    EstimativaEntrega = Tabela.Rows[0]["EstimativaEntrega_Orcamento"].ToString();
                    ProdutoFinal = Tabela.Rows[0]["ProdutoFinal_Orcamento"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarItens()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("", conexao);
                adapter.SelectCommand.CommandText = "Select Peça.Cod_Peça, Peça.Descricao_Peça, ItensPeça.quantidade_Itens, Peça.Valor_Peça, ItensPeça.Preço_Itens from ItensPeça inner join peça on Peça.Cod_Peça = ItensPeça.Cod_peça inner join orcamento on orcamento.Cod_Orcamento = ItensPeça.Cod_Orcamento where orcamento.Cod_orcamento = " + Cod_Orcamento;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                dgvItens.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (lblCliente.Text != "" && ValorTotal > 0.00m)
            {
                this.Visible = false;
                FrmFinalizarAtualizacao fa = new FrmFinalizarAtualizacao(ValorTotal, Cod_Cliente, Acrescimo, valorTotalOrcamento, EstimativaEntrega, ProdutoFinal, Cod_Orcamento, update);
                fa.ShowDialog();
                if (fa.voltar == true)
                {
                    this.Visible = true;
                }
                else
                {
                    AtualizarItens();
                    MessageBox.Show("Orçamento gerado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        ClassItensPeça itensPeça = new ClassItensPeça();
        
        private void AtualizarItens()
        {
            try
            {
                if (update == false)
                {
                    itensPeça._CodOrcamento = Cod_Orcamento;
                    itensPeça.ExcluirItens();
                    for (int i = 0; i < dgvItens.Rows.Count; i++)
                    {
                        itensPeça._CodPeça = int.Parse(dgvItens.Rows[i].Cells[0].Value.ToString());
                        itensPeça._QuantidadeItens = int.Parse(dgvItens.Rows[i].Cells[2].Value.ToString());
                        itensPeça._Preco = decimal.Parse(dgvItens.Rows[i].Cells[4].Value.ToString());
                        itensPeça._CodOrcamento = Cod_Orcamento;
                        itensPeça.InserirItens();
                    }
                }
                else
                {
                    itensPeça._CodOrcamento = Cod_Orcamento;
                    itensPeça.ExcluirItens();
                    for (int i = 0; i < dgvItensAtualizar.Rows.Count; i++)
                    {
                        itensPeça._CodPeça = int.Parse(dgvItensAtualizar.Rows[i].Cells[0].Value.ToString());
                        itensPeça._QuantidadeItens = int.Parse(dgvItensAtualizar.Rows[i].Cells[2].Value.ToString());
                        itensPeça._Preco = decimal.Parse(dgvItensAtualizar.Rows[i].Cells[4].Value.ToString());
                        itensPeça._CodOrcamento = Cod_Orcamento;
                        itensPeça.InserirItens();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void btnCancelarTudo_Click(object sender, EventArgs e)
        {
            if (pnItensAtualizar.Visible == false)
            {
                if (dgvItens.Rows.Count >= 1)
                {
                    if (MessageBox.Show("Deseja mesmo cancelar o(s) item(ns)?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pnItensAtualizar.Visible = true;
                        ValorTotal = 0.00m;
                        lblValorTotal.Text = "R$ " + ValorTotal;
                        Cod_Peça = 0;
                        x = 1;
                    }
                    txtDescricaoPecas.Focus();
                }
                else
                {
                    MessageBox.Show("Não há item para ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricaoPecas.Focus();
                }
            }
            else
            {
                if (dgvItensAtualizar.Rows.Count >= 1)
                {
                    if (MessageBox.Show("Deseja mesmo cancelar o(s) item(ns)?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        dgvItensAtualizar.Rows.Clear();
                        ValorTotal = 0.00m;
                        lblValorTotal.Text = "R$ " + ValorTotal;
                        Cod_Peça = 0;
                    }
                    txtDescricaoPecas.Focus();
                }
                else
                {
                    MessageBox.Show("Não há item para ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricaoPecas.Focus();
                }
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

        bool update = false;
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
                if (pnItensAtualizar.Visible == false)
                {
                    pnItensAtualizar.Visible = true;
                    for (int i = 0; i < dgvItens.Rows.Count; i++)
                    {
                        dgvItensAtualizar.Rows.Add(dgvItens.Rows[i].Cells[0].Value, dgvItens.Rows[i].Cells[1].Value, dgvItens.Rows[i].Cells[2].Value, dgvItens.Rows[i].Cells[3].Value, dgvItens.Rows[i].Cells[4].Value);
                    }
                    dgvItensAtualizar.Rows.Add(Cod_Peça, Descricao, Quantidade, PrecoUnitario, SubTotal);
                    if (dgvItensAtualizar.Rows.Count > 0)
                        dgvItensAtualizar.CurrentRow.Selected = false;
                }
                else
                {
                    dgvItensAtualizar.Rows.Add(Cod_Peça, Descricao, Quantidade, PrecoUnitario, SubTotal);
                    dgvItensAtualizar.CurrentRow.Selected = false;
                }
                ValorTotal += SubTotal;
                lblValorTotal.Text = "R$ " + ValorTotal;
                txtDescricaoPecas.Clear();
                txtQuantidade.Text = "1";
                txtDescricaoPecas.Focus();
                Cod_Peça = 0;
                update = true;
            }
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegamos o indice da linha do datagrid
            int contLinha = e.RowIndex;
            //caso o índice for maior a instrução abaixo será executada
            if (contLinha > -1)
            {
                DataGridViewRow row = dgvItens.Rows[contLinha];
                SubTotal = decimal.Parse(row.Cells[4].Value.ToString());
            }
        }

        private void txtDescricaoPecas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLancar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back)
            {
                pnDados.Visible = false;
            }
        }

        private void FrmAtualizarOrcamento_Load(object sender, EventArgs e)
        {
            dgvItens.CurrentRow.Selected = false;

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
            pnItensAtualizar.Visible = false;
            CarregarDGV();
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
            if (this.Visible == true)
            {
                if (pnItensAtualizar.Visible == false)
                {
                    if (dgvItens.Rows.Count >= 1)
                    {
                        if (MessageBox.Show("Existe itens em aberto. Deseja mesmo sair sem atualizar o orçamento?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
                else
                {
                    if (dgvItensAtualizar.Rows.Count >= 1)
                    {
                        if (MessageBox.Show("Existe itens em aberto. Deseja mesmo sair sem atualizar o orçamento?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            }
        }

        int x;
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

                // fazemos uma condição com a variável x
                // por padrão ela recebe zero
                //se ela for igual a zero ela passa a receber um inteiro
                //caso for adicionado mais itens a condição irá para a condição 'se não' e a 'pnItensAtualizar' irá ser vísivel
                if (x == 0)
                {
                    x = 1;
                }
                else
                {
                    pnItensAtualizar.Visible = true;
                }
                txtDescricaoPecas.Focus();

            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            if (pnItensAtualizar.Visible == false)
            {
                if (dgvItens.Rows.Count >= 1)
                {
                    //se houver linha selecionada a isntrução abaixo será executada
                    //se não o usuário receberá uma mensagem para selecionar itens para cancelamento do item desejado
                    if (dgvItens.CurrentRow.Selected == true)
                    {
                        //Remove a linha selecionada
                        dgvItens.Rows.Remove(dgvItens.CurrentRow);
                        // a variável ValorTotal irá receber o valor dela subitraindo com o valor do subtTotal irá diminuir
                        ValorTotal -= SubTotal;
                        lblValorTotal.Text = "R$ " + ValorTotal;
                        //Zeramos a variável
                        Cod_Peça = 0;
                        //Se conter linhas no datagrid a seleção do datagrid será removida
                        if (dgvItens.Rows.Count >= 1)
                        {
                            dgvItens.CurrentRow.Selected = false;
                        }
                        txtDescricaoPecas.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Selecione o item a ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescricaoPecas.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Não há item para ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricaoPecas.Focus();
                }
            }
            else
            {
                if (dgvItensAtualizar.Rows.Count >= 1)
                {
                    //se houver linha selecionada a isntrução abaixo será executada
                    //se não o usuário receberá uma mensagem para selecionar itens para cancelamento do item desejado
                    if (dgvItensAtualizar.CurrentRow.Selected == true)
                    {
                        //Remove a linha selecionada
                        dgvItensAtualizar.Rows.Remove(dgvItensAtualizar.CurrentRow);
                        // a variável ValorTotal irá receber o valor dela subitraindo com o valor do subtTotal irá diminuir
                        ValorTotal -= SubTotal;
                        lblValorTotal.Text = "R$ " + ValorTotal;
                        //Zeramos a variável
                        Cod_Peça = 0;
                        //Se conter linhas no datagrid a seleção do datagrid será removida
                        if (dgvItensAtualizar.Rows.Count >= 1)
                        {
                            dgvItensAtualizar.CurrentRow.Selected = false;
                        }
                        txtDescricaoPecas.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Selecione o item a ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDescricaoPecas.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Não há item para ser cancelado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricaoPecas.Focus();
                }
            }
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
