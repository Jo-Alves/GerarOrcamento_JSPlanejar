using System.Configuration;
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
using ClassProject;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmGerarOrcamento : Form
    {
        int Cod_Orcamento;

        public FrmGerarOrcamento()
        {
            InitializeComponent();
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            FrmNovoOrcamento no = new FrmNovoOrcamento();
            no.ShowDialog();
            CarregarDgv();
            if (dgvOrcamento.Rows.Count > 0)
                dgvOrcamento.CurrentRow.Selected = false;
        }

        private void CarregarDgv()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
                SqlDataAdapter comando = new SqlDataAdapter("", conexao);
                comando.SelectCommand.CommandText = "Select " +
                    "Orcamento.Cod_Orcamento, " +
                    "Orcamento.DataPedido_Orcamento," +
                    "Orcamento.Situacao_Orcamento, Orcamento.ValorTotal_Orcamento,  Orcamento.EstimativaEntrega_Orcamento," +
                    " Cliente.Nome_Cliente, Cliente.Cod_Cliente, Orcamento.ProdutoFinal_Orcamento from Orcamento inner join Cliente on Cliente.Cod_Cliente = Orcamento.Cod_cliente";
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                dgvOrcamento.DataSource = Tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void FrmGerarOrcamento_Load(object sender, EventArgs e)
        {
            string EstimativaEntrega, situacao;
            CarregarDgv();

            for (int i = 0; i < dgvOrcamento.Rows.Count; i++)
            {
                //acessar valor do campo
                EstimativaEntrega = dgvOrcamento.Rows[i].Cells["ColValidade"].Value.ToString();
                Cod_Orcamento = int.Parse(dgvOrcamento.Rows[i].Cells["ColCodigo"].Value.ToString());
                situacao = dgvOrcamento.Rows[i].Cells["ColSituacao"].Value.ToString();
                if (EstimativaEntrega.Length == 10)
                {
                    //convert string em data
                    DateTime dt = Convert.ToDateTime(EstimativaEntrega);
                    int dd_dt = dt.Day;
                    int mm_dt = dt.Month;
                    int yy_dt = dt.Year;
                    //criamos um objeto do Datetime
                    DateTime da = DateTime.Now;
                    int dd_da = da.Day;
                    int mm_da = da.Month;
                    int yy_da = da.Year;
                    if (dd_dt < dd_da && mm_dt <= mm_da && yy_dt <= yy_da && situacao == "Pendente" && situacao != "Entregue" && situacao != "Quitado")
                    {
                        VerificarSituacao();
                        CarregarDgv();
                    }
                }
            }
            if (dgvOrcamento.Rows.Count > 0)
            {
                dgvOrcamento.CurrentRow.Selected = false;
            }
        }
        private void VerificarSituacao()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "update Orcamento set situacao_Orcamento = 'Expirado' where Cod_Orcamento = @Cod";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@Cod", Cod_Orcamento);
            comando.CommandText = _sql;
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

        private void lblAprovar_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (situacao == "Aprovado" || situacao == "Recusado" || situacao == "Pendente")
                    {
                        if (situacao == "Recusado")
                        {
                            DialogResult dr = MessageBox.Show("Deseja aprovar orçamento recusado?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.Yes)
                            {
                                ClassOrcamento orcamento = new ClassOrcamento();
                                orcamento._Cod_Orcamento = Cod_Orcamento;
                                orcamento._Situacao = "Aprovado";
                                orcamento.AtualizarSituacao();
                                CarregarDgv();
                                if (dgvOrcamento.Rows.Count > 0)
                                    dgvOrcamento.CurrentRow.Selected = false;
                            }
                        }
                        else
                        {
                            ClassOrcamento orcamento = new ClassOrcamento();
                            orcamento._Cod_Orcamento = Cod_Orcamento;
                            orcamento._Situacao = "Aprovado";
                            orcamento.AtualizarSituacao();
                            CarregarDgv();
                            if (dgvOrcamento.Rows.Count > 0)
                                dgvOrcamento.CurrentRow.Selected = false;
                        }
                    }
                    else if (situacao == "Entregue")
                        MessageBox.Show("Este serviço já foi concluido! O produto já foi entregue!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Quitado")
                        MessageBox.Show("Este serviço já foi entregue! O produto já foi Quitado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Este orçamento já foi aprovado e o serviço já foi realizado! Obs: Espera do quitamento de todas as parcelas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    MessageBox.Show("Selecione orçamento para ser aprovado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento para ser aprovado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        int Cod_Cliente;
        string NomeCliente, situacao, DataPedido, dataEntrega, produtoFinal;
        decimal ValorTotal;
        private void dgvOrcamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contLinhas = e.RowIndex;
            if (contLinhas > -1)
            {
                DataGridViewRow row = dgvOrcamento.Rows[e.RowIndex];
                Cod_Orcamento = int.Parse(row.Cells["ColCodigo"].Value.ToString());
                Cod_Cliente = int.Parse(row.Cells["ColCodCliente"].Value.ToString());
                NomeCliente = row.Cells["ColCliente"].Value.ToString();
                situacao = row.Cells["ColSituacao"].Value.ToString();
                DataPedido = row.Cells["ColDataCriacao"].Value.ToString();
                dataEntrega = row.Cells["ColValidade"].Value.ToString();
                ValorTotal = decimal.Parse(row.Cells["ColValorTotal"].Value.ToString());
                produtoFinal = row.Cells["ColProduto"].Value.ToString();
            }
        }

        private void lblRecusar_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (situacao == "Aprovado" || situacao == "Reprovado" || situacao == "Pendente")
                    {
                        if (situacao == "Aprovado")
                        {
                            DialogResult dr = MessageBox.Show("Deseja recusar orçamento Aprovado?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.Yes)
                            {
                                ClassOrcamento orcamento = new ClassOrcamento();
                                orcamento._Cod_Orcamento = Cod_Orcamento;
                                orcamento._Situacao = "Recusado";
                                orcamento.AtualizarSituacao();
                                CarregarDgv();
                                if (dgvOrcamento.Rows.Count > 0)
                                    dgvOrcamento.CurrentRow.Selected = false;
                            }
                        }
                        else
                        {
                            ClassOrcamento orcamento = new ClassOrcamento();
                            orcamento._Cod_Orcamento = Cod_Orcamento;
                            orcamento._Situacao = "Recusado";
                            orcamento.AtualizarSituacao();
                            CarregarDgv();
                            if (dgvOrcamento.Rows.Count > 0)
                                dgvOrcamento.CurrentRow.Selected = false;
                        }
                    }
                    else if (situacao == "Entregue")
                        MessageBox.Show("Este serviço já foi concluido! O produto já foi entregue!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Quitado")
                        MessageBox.Show("Este serviço já foi entregue! O produto já foi Quitado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Este orçamento já foi aprovado e o serviço já foi realizado! Obs: Espera do quitamento de todas as parcelas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Selecione orçamento para ser excluido!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento para ser recusado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lbConfirmarPagamento_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (situacao == "Entregue")
                    {
                        FrmPagamentoOpcoes po = new FrmPagamentoOpcoes(ValorTotal, Cod_Orcamento);
                        po.ShowDialog();
                        if (!string.IsNullOrEmpty(po.Situacao))
                        {
                            ClassOrcamento orcamento = new ClassOrcamento();
                            orcamento._Cod_Orcamento = Cod_Orcamento;
                            orcamento._Situacao = po.Situacao;
                            orcamento.AtualizarSituacao();
                            CarregarDgv();
                            if (dgvOrcamento.Rows.Count > 0)
                                dgvOrcamento.CurrentRow.Selected = false;
                        }
                    }
                    else if (situacao == "Quitado")
                        MessageBox.Show("Este serviço já foi entregue! O produto já foi Quitado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Aprovado")
                        MessageBox.Show("O sistem de pagamento será aberto após a a confirmação de entrega!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Recusado")
                        MessageBox.Show("Este orçamento foi recusado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Pendente")
                    {
                        MessageBox.Show("O orçamento deve ser aprovado e o serviço entregue!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Este orçamento já foi aprovado e o serviço já foi realizado! Obs: Espera do quitamento de todas as parcelas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Selecione o orçamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void lblFinalizarEntrega_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (situacao == "Aprovado")
                    {
                        ClassOrcamento orcamento = new ClassOrcamento();
                        orcamento._Cod_Orcamento = Cod_Orcamento;
                        orcamento._Situacao = "Entregue";
                        orcamento.AtualizarSituacao();
                        CarregarDgv();
                        if (dgvOrcamento.Rows.Count > 0)
                            dgvOrcamento.CurrentRow.Selected = false;
                    }
                    else if (situacao == "Entregue")
                        MessageBox.Show("Este serviço já foi concluido! O produto já foi entregue!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Quitado")
                        MessageBox.Show("Este serviço já foi entregue! O produto já foi Quitado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Recusado")
                        MessageBox.Show("Este orçamento foi recusado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else if (situacao == "Pendente")
                    {
                        MessageBox.Show("O orçamento deve ser aprovado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Este orçamento já foi aprovado e o serviço já foi realizado! Obs: Espera do quitamento de todas as parcelas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Selecione o orçamento para ser finalizado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void lblExcluirOrcamento_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.CurrentRow.Selected == true)
            {
                if (situacao == "Aprovado" || situacao == "Recusado"  || situacao == "Pendente" || situacao == "Quitado")
                {
                    DialogResult dr = MessageBox.Show("Deseja mesmo excluir este orçamento?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            ClassItensPeça itensPeça = new ClassItensPeça();
                            ClassOrcamento orcamento = new ClassOrcamento();
                            ClassFormaPagamento formaPagamento = new ClassFormaPagamento();
                            ClassParcelaPagamento parcelaPagamento = new ClassParcelaPagamento();

                            itensPeça._CodOrcamento = Cod_Orcamento;
                            itensPeça.ExcluirItens();
                            parcelaPagamento._Cod_Orcamento = Cod_Orcamento;
                            parcelaPagamento.ExcluirParcelas();
                            formaPagamento._Cod_Orcamento = Cod_Orcamento;
                            formaPagamento.ExcluirFormaPagamento();
                            orcamento._Cod_Orcamento = Cod_Orcamento;
                            orcamento.ExcluirOrcamento();
                            MessageBox.Show("Orçamento excluido com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarDgv();
                            if (dgvOrcamento.Rows.Count > 0)
                                dgvOrcamento.CurrentRow.Selected = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
               else
                    MessageBox.Show("O orçamento (ou produto final) não pode ser excluido, pois o orçamento (ou produto final) não está quitado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Selecione o orçamento a ser excluido!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool VerificarEmpresa()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
           string _sql = "Select * from Empresa";
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            try
            {
                conexao.Open();
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        private void lblImprimir_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (VerificarEmpresa() == true)
                    {
                        Cursor = Cursors.WaitCursor;
                        FrmImprimirOrcamento io = new FrmImprimirOrcamento(Cod_Cliente, Cod_Orcamento, DataPedido, dataEntrega, ValorTotal, produtoFinal, NomeCliente);
                        io.ShowDialog();
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                 DialogResult dr = MessageBox.Show("É necessário cadastrar a empresa para continuar o processo! Deseja fazer o cadastro agora?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.Yes)
                        {
                            FrmEmpresa empresa = new FrmEmpresa();
                            empresa.ShowDialog();
                            if (string.IsNullOrEmpty(empresa.Diretorio))
                                Diretorio = null;
                            else
                            {
                                Diretorio = empresa.Diretorio;
                            }

                            if (VerificarEmpresa() == true)
                            {
                                Cursor = Cursors.WaitCursor;
                                FrmImprimirOrcamento io = new FrmImprimirOrcamento(Cod_Cliente, Cod_Orcamento, DataPedido, dataEntrega, ValorTotal, produtoFinal, NomeCliente);
                                io.ShowDialog();
                                Cursor = Cursors.Default;
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Selecione o orçamento para imprimir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento para imprimir", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string Diretorio { get; set; }

        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvOrcamento.Rows.Count > 0)
            {
                if (dgvOrcamento.CurrentRow.Selected == true)
                {
                    if (situacao == "Aprovado" || situacao == "Recusado" || situacao == "Pendente")
                    {
                        FrmAtualizarOrcamento atualizarOrcamento = new FrmAtualizarOrcamento(Cod_Orcamento, Cod_Cliente, NomeCliente);
                        atualizarOrcamento.ShowDialog();
                        CarregarDgv();
                        if (dgvOrcamento.Rows.Count > 0) dgvOrcamento.CurrentRow.Selected = false;
                    }
                    else
                        MessageBox.Show("Este orçamento não pode ser editado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Selecione o orçamento a ser editado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há orçamento para ser editado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
