using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmPagamento : Form
    {
        decimal ValorTotal;
        string FormasPagamento;
        int Cod_Orcamento;

        public FrmPagamento(string FormasPagamento, decimal ValorTotal, int Cod_Orcamento)
        {
            InitializeComponent();
            this.Cod_Orcamento = Cod_Orcamento;
            lbl_ValorTotal.Text = "R$ " + ValorTotal;
            this.ValorTotal = ValorTotal;
            this.FormasPagamento = FormasPagamento;
            Opcoes();
        }
        public void Opcoes()
        {
            if (FormasPagamento == "Boleto bancário")
            {
                txtTroco.Visible = false;
                this.ClientSize = new Size(672, 249);
                lblTroco.Visible = false;
                this.Text = "Pagamento - Boleto Bancário";
            }
            else if (FormasPagamento == "Dinheiro")
            {
                this.ClientSize = new Size(672, 294);
                this.Text = "Pagamento - Dinheiro";
            }
            else if (FormasPagamento == "Débito")
            {
                txtTroco.Visible = false;
                this.ClientSize = new Size(672, 249);
                lblTroco.Visible = false;
                this.Text = "Pagamento - Débito";
            }
            else if (FormasPagamento == "Crédito")
            {
                txtTroco.Visible = false;
                gbParcelas.Visible = true;
                lblTroco.Visible = false;
                txtTroco.Visible = false;
                lblValorPago.Visible = false;
                txtValorPago.Visible = false;
                this.Text = "Pagamento - Crédito";
            }
            else if (FormasPagamento == "Dinheiro(Parcelas)")
            {
                txtTroco.Visible = false;
                gbParcelas.Visible = true;
                lblTroco.Visible = false;
                txtTroco.Visible = false;
                lblValorPago.Visible = false;
                txtValorPago.Visible = false;
                btnGerarRepasse.Visible = true;
                this.Text = "Pagamento - " + FormasPagamento;
            }
        }

        public string Situacao { get; set; }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtTroco.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVendaVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPagamento_a_Vista___Dinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
                txtValorPago.Focus();
            else if (e.KeyCode == Keys.F9)
                btnGerarParcelas_Click(sender, e);
            else if (e.KeyCode == Keys.F10)
                btn_ConfirmarPagamento_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancelarVendaVista_Click(sender, e);
        }

        private void btn_ConfirmarPagamento_Click(object sender, EventArgs e)
        {
            if (FormasPagamento != "Crédito" && FormasPagamento != "Dinheiro(Parcelas)")
            {
                if (txtValorPago.Text != "")
                {
                    ConfirmarPagamento();
                    Situacao = "Quitado";
                    Close();
                }
                else
                    MessageBox.Show("Informe o Valor a quitar!", "Mensagem de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dgv_Parcelas.Rows.Count > 0)
                {
                    ConfirmarPagamento();
                    Situacao = "Parcelado";
                    Close();
                }
                else
                    MessageBox.Show("Não há parcelas geradas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        ClassFormaPagamento fp = new ClassFormaPagamento();
        ClassParcelaPagamento pp = new ClassParcelaPagamento();
        private void ConfirmarPagamento()
        {   
            if (FormasPagamento == "Crédito" || FormasPagamento == "Dinheiro(Parcelas)")
            {
                try
                {
                    for (int i = 0; i < dgv_Parcelas.Rows.Count; i++)
                    {
                        pp._Nparcela = int.Parse(dgv_Parcelas.Rows[i].Cells[0].Value.ToString());
                        pp._ValorParcela = decimal.Parse(dgv_Parcelas.Rows[i].Cells[2].Value.ToString());
                        pp._DataVencimento = dgv_Parcelas.Rows[i].Cells[1].Value.ToString();
                        pp._DataPagamento = "";
                        pp._HoraPagamento = "";
                        pp._Cod_Orcamento = Cod_Orcamento;
                        pp.GerarParcelaPagamento();
                    }
                    fp._Descricao = FormasPagamento;
                    fp._Cod_Orcamento = Cod_Orcamento;
                    fp.DefinirFormaPagamento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    pp._Nparcela = 1;
                    pp._ValorParcela = ValorTotal;
                    pp._DataVencimento = DateTime.Now.ToShortDateString();
                    pp._DataPagamento = DateTime.Now.ToShortDateString();
                    pp._HoraPagamento = DateTime.Now.ToLongTimeString();
                    pp._Cod_Orcamento = Cod_Orcamento;
                    pp.GerarParcelaPagamento();

                    fp._Descricao = FormasPagamento;
                    fp._Cod_Orcamento = Cod_Orcamento;
                    fp.DefinirFormaPagamento();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        decimal vp, troco, valorParcelado;
        int NParcela;

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            dgv_Parcelas.Rows.Clear();
            NParcela = int.Parse(txtNParcelas.Text);
            string vencimento = DateTime.Now.ToShortDateString();
            DateTime dv = Convert.ToDateTime(vencimento);
            valorParcelado = ValorTotal / NParcela;
            valorParcelado = Math.Round(valorParcelado, 2);
            txt_ValorTotalParcelas.Text = "R$ " + valorParcelado;
           
            for (int i = 1; i <= NParcela; i++)
            {
                dv = dv.AddMonths(1);               
                dgv_Parcelas.Rows.Add(i, dv.ToShortDateString(), valorParcelado);
            }
        }

        private void txtNParcelas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnGerarRepasse_Click(object sender, EventArgs e)
        {
            ClassEmpresa empresa = new ClassEmpresa();
            empresa.Consultar();
            if (dgv_Parcelas.Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(empresa.razaoSocial))
                {
                    ConfirmarPagamento();
                    Situacao = "Parcelado";
                    Cursor = Cursors.WaitCursor;
                    FrmRepasseParcela rp = new FrmRepasseParcela(Cod_Orcamento);
                    rp.ShowDialog();
                    Cursor = Cursors.Default;
                    this.Close();
                }
                else
                    MessageBox.Show("Cadastre a sua empresa para gerar o repasse!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Não há parcelas geradas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtNParcelas_TextChanged(object sender, EventArgs e)
        {
            if (txtNParcelas.Text == "" || txtNParcelas.Text == "0" || txtNParcelas.Text == "00")
            {
                txtNParcelas.Text = "1";
            }
        } 

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text != "")
            {
                vp = decimal.Parse(txtValorPago.Text);
                if (vp >= ValorTotal)
                {
                    troco = vp - ValorTotal;
                    txtTroco.Text = "R$ " + troco;
                }
                else
                    MessageBox.Show("O Valor pago é menor que o valor do serviço!", "Mensagem dos sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                txtTroco.Clear();
        }
    }
}
