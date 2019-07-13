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
    public partial class FrmImprimirOrcamento : Form
    {
        int cod_Orcamento;
        string razaoSocial, nomeFantasia, CNPJ, IE, logradouro, numero, cidade, estado, telefone, celular, email, ValorMaoObra, ValorPeças;
        public FrmImprimirOrcamento(int Cod_Cliente, int Cod_Orcamento, string DataPedido, string dataEntrega, decimal ValorTotal, string produtoFinal, string NomeCliente)
        {
            InitializeComponent();
            cod_Orcamento = Cod_Orcamento;
            VerificarEmpresa();
            verificarOrcamento();
            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Cod_Cliente", Cod_Cliente.ToString()));
            rpc.Add(new ReportParameter("DataPedido", DataPedido));
            rpc.Add(new ReportParameter("DataEntrega", dataEntrega));
            rpc.Add(new ReportParameter("ValorTotal", "R$ " + ValorTotal));
            rpc.Add(new ReportParameter("ProdutoFinal", produtoFinal));
            rpc.Add(new ReportParameter("Contratante", NomeCliente));
            rpc.Add(new ReportParameter("RazaoSocial", razaoSocial));
            rpc.Add(new ReportParameter("NomeFantasia", nomeFantasia));
            rpc.Add(new ReportParameter("CNPJ", CNPJ));
            rpc.Add(new ReportParameter("IE", IE));
            rpc.Add(new ReportParameter("Logradouro", logradouro));
            rpc.Add(new ReportParameter("Numero", numero));
            rpc.Add(new ReportParameter("Cidade", cidade));
            rpc.Add(new ReportParameter("Estado", estado));
            rpc.Add(new ReportParameter("Telefone", telefone));
            rpc.Add(new ReportParameter("Celular", celular));
            rpc.Add(new ReportParameter("Email", email));
            rpc.Add(new ReportParameter("ValorMaoObra", ValorMaoObra));
            rpc.Add(new ReportParameter("ValorPeças", ValorPeças));
            rpOrcamento.LocalReport.SetParameters(rpc);
            rpOrcamento.RefreshReport();
        }

        private void VerificarEmpresa()
        {
            ClassEmpresa empresa = new ClassEmpresa();
            empresa.Consultar();
            if (string.IsNullOrEmpty(empresa.razaoSocial))
                razaoSocial = " ";
            else
                razaoSocial = empresa.razaoSocial;

            if (string.IsNullOrEmpty(empresa.nomeFantasia))
                nomeFantasia = " ";
            else
                nomeFantasia = empresa.nomeFantasia;

            if (string.IsNullOrEmpty(empresa.CNPJ))
                CNPJ = " ";
            else
                CNPJ = empresa.CNPJ;

            if (string.IsNullOrEmpty(empresa.inscricao))
                IE = " ";
            else
                IE = empresa.inscricao;

            if (string.IsNullOrEmpty(empresa.logradouro))
                logradouro = " ";
            else
                logradouro = empresa.logradouro;

            if (string.IsNullOrEmpty(empresa.numero))
                numero = " ";
            else
                numero = empresa.numero;

            if (string.IsNullOrEmpty(empresa.cidade))
                cidade = " ";
            else
                cidade = empresa.cidade;

            if (string.IsNullOrEmpty(empresa.estado))
                estado = " ";
            else
                estado = empresa.estado;

            if (string.IsNullOrEmpty(empresa.telefone))
                telefone = " ";
            else
                telefone = empresa.telefone;

            if (string.IsNullOrEmpty(empresa.celular))
                celular = " ";
            else
                celular = empresa.celular;

            if (string.IsNullOrEmpty(empresa.email))
                email = " ";
            else
                email = empresa.email;
        }

        private void verificarOrcamento()
        {
            ClassOrcamento orcamento = new ClassOrcamento();
            orcamento._Cod_Orcamento = cod_Orcamento;
            orcamento.Buscar();
            ValorMaoObra = orcamento._ValorMaoObra.ToString();
            ValorPeças = orcamento._ValorPeças_Orcamento.ToString();
            
        }

        private void FrmImprimirOrcamento_Load(object sender, EventArgs e)
        {
            this.tabelaOrcamentoTableAdapter.Fill(this.dbControleOrcamentoDataSet.tabelaOrcamento, cod_Orcamento);

            this.rpOrcamento.RefreshReport();            
        }
    }
}
