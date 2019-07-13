using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmRepasseParcela : Form
    {
        int Cod_Orcamento;
        public FrmRepasseParcela(int Cod_Orcamento)
        {
            InitializeComponent();
            this.Cod_Orcamento = Cod_Orcamento;
            VerificarEmpresa();
            ReportParameterCollection parametro = new ReportParameterCollection();
            parametro.Add(new ReportParameter("RazaoSocial", razaoSocial));
            parametro.Add(new ReportParameter("Endereco", logradouro));
            parametro.Add(new ReportParameter("Numero", numero));
            parametro.Add(new ReportParameter("Cidade", cidade));
            parametro.Add(new ReportParameter("Estado", estado));
            parametro.Add(new ReportParameter("Telefone", telefone));
            parametro.Add(new ReportParameter("CNPJ", CNPJ));
            reportViewer1.LocalReport.SetParameters(parametro);
            reportViewer1.RefreshReport();
        }

        string razaoSocial, CNPJ, logradouro, numero, cidade, estado, telefone;
        private void VerificarEmpresa()
        {
            ClassEmpresa empresa = new ClassEmpresa();
            empresa.Consultar();
            if (string.IsNullOrEmpty(empresa.razaoSocial))
                razaoSocial = " - ";
            else
                razaoSocial = empresa.razaoSocial;

            if (string.IsNullOrEmpty(empresa.CNPJ))
                CNPJ = " - ";
            else
                CNPJ = empresa.CNPJ;

            if (string.IsNullOrEmpty(empresa.logradouro))
                logradouro = " - ";
            else
                logradouro = empresa.logradouro;

            if (string.IsNullOrEmpty(empresa.numero))
                numero = " - ";
            else
                numero = empresa.numero;

            if (string.IsNullOrEmpty(empresa.cidade))
                cidade = " - ";
            else
                cidade = empresa.cidade;

            if (string.IsNullOrEmpty(empresa.estado))
                estado = " - ";
            else
                estado = empresa.estado;

            if (string.IsNullOrEmpty(empresa.telefone))
                telefone = " - ";
            else
                telefone = empresa.telefone;

        }

        private void FrmRepasseParcela_Load(object sender, EventArgs e)
        {

            try
            {
                this.TabelaParcelasTableAdapter.Fill(this.dbControleOrcamentoDataSet.TabelaParcelas, Cod_Orcamento);

                this.reportViewer1.RefreshReport();
            }
            catch
            {

            }
        }
    }
}
