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
    public partial class FrmPrevisaoEntrega : Form
    {
        public FrmPrevisaoEntrega()
        {
            InitializeComponent();         
        }

        private void dpDataEntrega_ValueChanged(object sender, EventArgs e)
        {
            string DataAtual = DateTime.Now.ToShortDateString();
            string DataFinal = dpDataEntrega.Text;
            DateTime da = Convert.ToDateTime(DataAtual);
            DateTime df = Convert.ToDateTime(DataFinal);
            TimeSpan ts = df.Subtract(da);

            ndQuantidadeTempo.Text = ts.TotalDays.ToString();
        }

        private void ndQuantidadeTempo_ValueChanged(object sender, EventArgs e)
        {
            string DataAtual = DateTime.Now.ToShortDateString();
            int qt = int.Parse(ndQuantidadeTempo.Text);
            DateTime da = Convert.ToDateTime(DataAtual);
            da = da.AddDays(qt);
            dpDataEntrega.Text = da.ToShortDateString();
        }

        public string DataEntrega { get; set; }
        public string Tempo { get; set; }
        public bool Validade { get; set; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataEntrega = dpDataEntrega.Text;
            Tempo = ndQuantidadeTempo.Value.ToString();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DataEntrega = null;
            Close();
        }

        private void FrmPrevisaoEntrega_Load(object sender, EventArgs e)
        {
            ndQuantidadeTempo_ValueChanged(sender, e);
        }

        private void cbPrevisaoEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrevisaoEntrega.Checked)
            {
                ndQuantidadeTempo.Enabled = false;
                dpDataEntrega.Enabled = false;
                Validade = true;
             }
            else
            {
                ndQuantidadeTempo.Enabled = true;
                dpDataEntrega.Enabled = true;
                Validade = false;
            }
        }
    }
}
