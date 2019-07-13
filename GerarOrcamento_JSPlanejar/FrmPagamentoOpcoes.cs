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
    public partial class FrmPagamentoOpcoes : Form
    {
        decimal ValorTotal;
        int Cod_Orcamento;
        public FrmPagamentoOpcoes(decimal ValorTotal, int Cod_Orcamento)
        {
            InitializeComponent();
            this.ValorTotal = ValorTotal;
            this.Cod_Orcamento = Cod_Orcamento;
        }

        public string Situacao { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbFormasPagamento.SelectedIndex > -1)
            {
                FrmPagamento pvd = new FrmPagamento(cbFormasPagamento.Text, ValorTotal, Cod_Orcamento);
                this.Visible = false;
                pvd.ShowDialog();
                if (!string.IsNullOrEmpty(pvd.Situacao))
                    Situacao = pvd.Situacao;
                this.Close();
            }
            else
            {
                MessageBox.Show("Informa a opção de pagaemnto!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbFormasPagamento.Focus();
            }
        }
    }
}
