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
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();           
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {           
            cbBuscarPor.SelectedIndex = 5;
            CarregarDgv();
            if (dgvDadosCliente.Rows.Count > 0)
                dgvDadosCliente.CurrentRow.Selected = false;
            for (int i = 0; i < dgvDadosCliente.Rows.Count; i++)
            {
                dgvDadosCliente.Rows[i].Cells[2].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[2].Value.ToString());
                dgvDadosCliente.Rows[i].Cells[3].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[3].Value.ToString());
            }
        }

        private void CarregarDgv()
        {
            // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
            //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            //a variável recebe o comando do banco de dados
            string _sql = "Select * from Cliente";
            //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            //Instanciamos a classe DataTable
            DataTable Tabela = new DataTable();
            //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
            comando.Fill(Tabela);
            //Fazemos uma condição
            //Caso exista linha na tabela a instrução será  acionada
            dgvDadosCliente.DataSource = Tabela;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }

        private void dgvDadosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDadosCliente.Rows[e.RowIndex];
            Codigo = int.Parse(row.Cells[0].Value.ToString());
            Nome = row.Cells[1].Value.ToString();
            Close();
        }

        private void dgvDadosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int conLinhas = e.RowIndex;
            if (conLinhas > -1)
            {
                DataGridViewRow row = dgvDadosCliente.Rows[e.RowIndex];
                Codigo = int.Parse(row.Cells[0].Value.ToString());
                Nome = row.Cells[1].Value.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Codigo == 0 && string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Selecione o cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Codigo = 0;
            this.Close();
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscarPor.Text == "Código")
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = true;
                }
            }
            else if (cbBuscarPor.Text == "Celular" || cbBuscarPor.Text == "Telefone")
            {
                if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            // a variável 'Busca' recebe o texto do item 'cbBuscarPor'
            string Busca = cbBuscarPor.Text;
            // fazemos a condição
            switch (Busca)
            {
                case "Nome":
                    Busca = "Nome_Cliente";
                    break;
                case "Código":
                    Busca = "Cod_Cliente";
                    break;
                case "Telefone":
                    Busca = "Telefone_Cliente";
                    break;
                case "Email":
                    Busca = "Email_Cliente";
                    break;
                case "Logradouro":
                    Busca = "Logradouro_Cliente";
                    break;
                case "Cidade":
                    Busca = "Cidade_Cliente";
                    break;
                case "Celular":
                    Busca = "Celular_Cliente";
                    break;
            }
            if (txtPesquisar.Text != "")
            {
                // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
                //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
                SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
                //a variável recebe o comando do banco de dados
                string _sql = "Select * from Cliente where  " + Busca + " like  '%" + txtPesquisar.Text + "%'";
                //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                //Instanciamos a classe DataTable
                DataTable Tabela = new DataTable();
                //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
                comando.Fill(Tabela);
                //Fazemos uma condição
                //Caso exista linha na tabela a instrução será  acionada

                dgvDadosCliente.DataSource = Tabela;
                if(dgvDadosCliente.Rows.Count>0)
                dgvDadosCliente.CurrentRow.Selected = false;
            }
            else
                CarregarDgv();
            if (dgvDadosCliente.Rows.Count > 0)
                dgvDadosCliente.CurrentRow.Selected = false;
        }
    }
}
