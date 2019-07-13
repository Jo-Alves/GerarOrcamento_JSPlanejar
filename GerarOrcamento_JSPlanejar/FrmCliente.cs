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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        string Page = null, _sql;
        string StringConexao = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        //Estancia a classe CadastroCliente da biblioteca Cadastro
        CadastroCliente CadastroCliente = new CadastroCliente();
        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Limpar();
            //Ao acionar o botão Novo Cadastro o controle TbCadastroCliente será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroCliente;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtNome.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroCliente'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroCliente);
            }
            // A variável Page recebe vazio
            Page = "";
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
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
                SqlConnection conexao = new SqlConnection(StringConexao);
                //a variável recebe o comando do banco de dados
                _sql = "Select * from Cliente where  " + Busca + " like  '%" + txtPesquisar.Text + "%'";
                //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.CommandText = _sql;
                //Instanciamos a classe DataTable
                DataTable Tabela = new DataTable();
                //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
                comando.Fill(Tabela);
                //Fazemos uma condição
                //Caso exista linha na tabela a instrução será  acionada
                if (Tabela.Rows.Count > 0)
                {
                    dgvDadosCliente.DataSource = Tabela;
                    gbLocalizarCliente.Visible = true;
                    lblStatus.Visible = false;

                    for (int i = 0; i < dgvDadosCliente.Rows.Count; i++)
                    {
                        dgvDadosCliente.Rows[i].Cells[2].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[2].Value.ToString());
                        dgvDadosCliente.Rows[i].Cells[3].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[3].Value.ToString());
                    }
                }
                else
                {
                    gbLocalizarCliente.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = "Nenhum resultado";
                }
            }
            else
            {
                gbLocalizarCliente.Visible = false;
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";
            }
        }

        private void BtnExibirCadastro_Click(object sender, EventArgs e)
        {
            //Fazemos uma Condição para que se Houver dados a instrução abaixo será acionada
            if (gbLocalizarCliente.Visible == true)
            {
                //Ao acionar o botão Novo Cadastro o controle TbCadastroCliente será selecionada e exposta
                tbCadastro.SelectedTab = tbCadastroCliente;
                //O foco será adicionada na caixa de texto 'txtNome'
                txtNome.Focus();
                // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroCliente'
                if (Page == null)
                {
                    tbCadastro.Controls.Add(tbCadastroCliente);
                }
                // A variável Page recebe vazio
                Page = "";
                this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
                this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnCadastrar.Text = "Cadastrar - F11";
                lblCodigo.Text = Codigo;
                txtNome.Text = nome;
                mbCPF.Text = dgvDadosCliente.CurrentRow.Cells[2].Value.ToString();
                mbRG.Text = dgvDadosCliente.CurrentRow.Cells[3].Value.ToString();
                mbCEP.Text = cep;
                txtLogradouro.Text = logradouro;
                txtNumero.Text = numero;
                txtBairro.Text = bairro;
                txtCidade.Text = cidade;
                cbEstado.Text = estado;
                mbTelefone.Text = telefone;
                mbCelular.Text = celular;
                txtEmail.Text = email;
            }
            else
                MessageBox.Show("Selecione uma cadastro para exibir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cbBuscarPor.SelectedIndex = 5;
            txtPesquisar.Focus();
            gbLocalizarCliente.Visible = false;
            lblStatus.Visible = true;
            lblStatus.Location = new Point(103, 282);
            lblStatus.Text = "Aguardando Busca...";
            lblStatus.ForeColor = Color.Black;
            tbCadastro.Controls.Remove(tbCadastroCliente);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
        }

        private void CarregarDgv()
        {
            // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
            //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
            SqlConnection conexao = new SqlConnection(StringConexao);
            //a variável recebe o comando do banco de dados
            _sql = "Select * from Cliente";
            //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            //Instanciamos a classe DataTable
            DataTable Tabela = new DataTable();
            //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
            comando.Fill(Tabela);
            //Fazemos uma condição
            //Caso exista linha na tabela a instrução será  acionada
            if (Tabela.Rows.Count > 0)
            {
                dgvDadosCliente.DataSource = Tabela;
                for (int i = 0; i < dgvDadosCliente.Rows.Count; i++)
                {
                    dgvDadosCliente.Rows[i].Cells[2].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[2].Value.ToString());
                    dgvDadosCliente.Rows[i].Cells[3].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[3].Value.ToString());
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //O tabPage 'tbLocalizarCliente' é selecionado
            tbCadastro.SelectedTab = tbLocalizarCliente;
        }

        ErrorProvider errorProvider = new ErrorProvider();
        string Situacao;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string TextButton = btnCadastrar.Text;
            switch (TextButton)
            {
                case "Incluir - F11":
                    Limpar();
                    this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
                    this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.btnCadastrar.Text = "Cadastrar - F11";
                    break;
                case "Cadastrar - F11":
                    Cadastrar();
                    if (txtNome.Text != "" && Situacao != null)
                    {
                        this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Actions_list_add_icon;
                        this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

                        this.btnCadastrar.Text = "Incluir - F11";
                    }
                    break;
            }
        }

        private void Cadastrar()
        {
            if (txtNome.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Nome'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtNome, "Campo obrigatório!");
                txtNome.Focus();
                return;
            }
            else if ((txtEmail.Text != string.Empty) && (!ValidacaoEmail.validarEmail(txtEmail.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                txtEmail.Focus();
                return;
            }
            else
            {
                try
                {
                    CadastroCliente._StringConn = StringConexao;
                    CadastroCliente.VerificarCodigoCliente();
                    if (lblCodigo.Text != "")
                    {
                        CadastroCliente._Cod_cliente = int.Parse(lblCodigo.Text);
                    }
                    else
                        CadastroCliente._Cod_cliente = 0;

                    CadastroCliente._Nome = txtNome.Text;
                    CadastroCliente._CPF = Security.Cry(mbCPF.Text);
                    CadastroCliente._RG = Security.Cry(mbRG.Text);
                    CadastroCliente._CEP = mbCEP.Text;
                    CadastroCliente._Logradouro = txtLogradouro.Text;
                    CadastroCliente._Numero = txtNumero.Text;
                    CadastroCliente._Bairro = txtBairro.Text;
                    CadastroCliente._Cidade = txtCidade.Text;
                    CadastroCliente._Estado = cbEstado.Text;
                    CadastroCliente._Telefone = mbTelefone.Text;
                    CadastroCliente._Celular = mbCelular.Text;
                    CadastroCliente._Email = txtEmail.Text;
                    if (CadastroCliente.Cadastrar() == true)
                    {
                        MessageBox.Show("Dados cadastrado com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CadastroCliente.VerificarCodigoCliente();
                        lblCodigo.Text = CadastroCliente._Cod_cliente.ToString();
                        CarregarDgv();
                        Situacao = "Cadastrado";
                    }
                    else
                    {
                        MessageBox.Show("Consta cadastrado no sistema um cliente com o mesmo código! Limpe todos os campos para o novo cadastro!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Situacao = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Limpar()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtPesquisar.Clear();
            mbTelefone.Clear();
            mbCelular.Clear();
            mbCEP.Clear();
            mbCPF.Clear();
            lblCodigo.Text = "";
            cbEstado.SelectedIndex = -1;
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
            errorProvider.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            //Limpamos o ErroProvide
            errorProvider.Clear();
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se estiver selecionado em cada indice
            //o Label receberá as os dados abaixo
            if (cbBuscarPor.SelectedIndex == 0)
                lbldados.Text = "Cidade";
            else if (cbBuscarPor.SelectedIndex == 1)
                lbldados.Text = "Celular";
            else if (cbBuscarPor.SelectedIndex == 2)
                lbldados.Text = "Código";
            else if (cbBuscarPor.SelectedIndex == 3)
                lbldados.Text = "Email";
            else if (cbBuscarPor.SelectedIndex == 4)
                lbldados.Text = "Logradouro";
            else if (cbBuscarPor.SelectedIndex == 5)
                lbldados.Text = "Nome";
            else if (cbBuscarPor.SelectedIndex == 6)
                lbldados.Text = "Telefone";
            //O Curso irá focar no campo TxtPesquisar
            txtPesquisar.Focus();
        }

        private void btnNovoCadastro_MouseEnter(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao colocar o cursor do mouse em cima do item
            this.btnNovoCadastro.BackColor = Color.Aquamarine;
            this.btnNovoCadastro.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnNovoCadastro_MouseLeave(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao retirar o cursor do mouse em cima do item
            this.btnNovoCadastro.BorderStyle = BorderStyle.None;
            this.btnNovoCadastro.BackColor = Color.Transparent;
        }

        private void btnExibirCadastro_MouseEnter(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao Colocar o cursor do mouse encima do item
            this.btnExibirCadastro.BorderStyle = BorderStyle.FixedSingle;
            this.btnExibirCadastro.BackColor = Color.Aquamarine;
        }

        private void btnExibirCadastro_MouseLeave(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao retirar o cursor do mouse em cima do item
            this.btnExibirCadastro.BorderStyle = BorderStyle.None;
            this.btnExibirCadastro.BackColor = Color.Transparent;
        }

        private void btnExibirTodos_MouseEnter(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao colocar o cursor do mouse em cima do item
            this.btnExibirTodos.BorderStyle = BorderStyle.FixedSingle;
            btnExibirTodos.BackColor = Color.Aquamarine;
        }

        private void btnExibirTodos_MouseLeave(object sender, EventArgs e)
        {//O plano de fundo e o estilo irá ser acionado ao retirar o cursor do mouse em cima do item
            this.btnExibirTodos.BorderStyle = BorderStyle.None;
            btnExibirTodos.BackColor = Color.Transparent;
        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(StringConexao);
            SqlDataAdapter comando = new SqlDataAdapter("", conexao);
            comando.SelectCommand.CommandText = "Select * from Cliente";
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvDadosCliente.DataSource = Tabela;
                gbLocalizarCliente.Visible = true;
                lblStatus.Visible = false;
                for (int i = 0; i < dgvDadosCliente.Rows.Count; i++)
                {
                    dgvDadosCliente.Rows[i].Cells[2].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[2].Value.ToString());
                    dgvDadosCliente.Rows[i].Cells[3].Value = Security.Dry(dgvDadosCliente.Rows[i].Cells[3].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("O sistema ainda não possui clientes cadastrados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";

            }
        }

        private void btnConsultarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaCEP consultaCep = new ConsultaCEP();
                consultaCep._Cep = mbCEP.Text;
                consultaCep.ConsultarCEP();
                txtLogradouro.Text = consultaCep._Logradouro;
                txtBairro.Text = consultaCep._Bairro;
                txtCidade.Text = consultaCep._Cidade;
                cbEstado.Text = consultaCep._Estado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string Codigo, nome, cpf, rg, cep, logradouro, numero, bairro, cidade, estado, telefone, celular, email;

        private void mbCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                if (mbCPF.MaskCompleted)
                {
                    if (!DOC.ValidaCpf(mbCPF.Text))
                    {
                        MessageBox.Show("O número do CPF é Inválido!", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProvider.SetError(mbCPF, "CPF inválido!");
                        mbCPF.Clear();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                tbCadastro.SelectedTab = tbLocalizarCliente;
            else if (e.KeyCode == Keys.F2)
                if (Page != null)
                {
                    tbCadastro.SelectedTab = tbCadastroCliente;
                }
            if (e.KeyCode == Keys.F3)
                BtnNovoCadastro_Click(sender, e);
            if (e.KeyCode == Keys.F4)
                BtnExibirCadastro_Click(sender, e);
            if (e.KeyCode == Keys.F5)
                btnExibirTodos_Click(sender, e);
            if (e.KeyCode == Keys.F6)
                btnConsultarCEP_Click(sender, e);
            if (e.KeyCode == Keys.F7)
                btnLimpar_Click(sender, e);
            if (e.KeyCode == Keys.F8)
                btnExcluir_Click(sender, e);
            if (e.KeyCode == Keys.F9)
                btnAtualizar_Click(sender, e);
            if (e.KeyCode == Keys.F10)
                btnPesquisar_Click(sender, e);
            if (e.KeyCode == Keys.F11)
                btnCadastrar_Click(sender, e);

        }

        private void dgvDadosCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDadosCliente.SelectedRows.Count > 0)
            {
                Codigo = dgvDadosCliente.SelectedRows[0].Cells["ColCodigo"].Value.ToString();
                nome = dgvDadosCliente.SelectedRows[0].Cells["ColNome"].Value.ToString();
                cpf = dgvDadosCliente.SelectedRows[0].Cells["ColCPF"].Value.ToString();
                rg = dgvDadosCliente.SelectedRows[0].Cells["ColRG"].Value.ToString();
                cep = dgvDadosCliente.SelectedRows[0].Cells["ColCEP"].Value.ToString();
                logradouro = dgvDadosCliente.SelectedRows[0].Cells["ColLogradouro"].Value.ToString();
                bairro = dgvDadosCliente.SelectedRows[0].Cells["ColBairro"].Value.ToString();
                cidade = dgvDadosCliente.SelectedRows[0].Cells["ColCidade"].Value.ToString();
                estado = dgvDadosCliente.SelectedRows[0].Cells["ColEstado"].Value.ToString();
                telefone = dgvDadosCliente.SelectedRows[0].Cells["ColTelefone"].Value.ToString();
                celular = dgvDadosCliente.SelectedRows[0].Cells["ColCelular"].Value.ToString();
                email = dgvDadosCliente.SelectedRows[0].Cells["ColEmail"].Value.ToString();
            }
        }

        private void dgvDadosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow row = dgvDadosCliente.Rows[ContLinhas];
                lblCodigo.Text = row.Cells["ColCodigo"].Value.ToString();
                txtNome.Text = row.Cells["ColNome"].Value.ToString();
                nome = txtNome.Text.Trim();
                Codigo = lblCodigo.Text;
                mbCPF.Text = row.Cells["ColCPF"].Value.ToString();
                mbRG.Text = row.Cells["ColRG"].Value.ToString();
                mbCEP.Text = row.Cells["ColCEP"].Value.ToString();
                txtLogradouro.Text = row.Cells["ColLogradouro"].Value.ToString();
                txtBairro.Text = row.Cells["ColBairro"].Value.ToString();
                txtCidade.Text = row.Cells["ColCidade"].Value.ToString();
                cbEstado.Text = row.Cells["ColEstado"].Value.ToString();
                mbTelefone.Text = row.Cells["ColTelefone"].Value.ToString();
                mbCelular.Text = row.Cells["ColCelular"].Value.ToString();
                txtEmail.Text = row.Cells["ColEmail"].Value.ToString();
            }
            //Ao acionar o botão Novo Cadastro o controle TbCadastroCliente será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroCliente;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtNome.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroCliente'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroCliente);
            }
            // A variável Page recebe vazio
            Page = "";
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "")
            {
                MessageBox.Show("Busque e selecione os dados do cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizarCliente;
            }
            else if (txtNome.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Nome'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtNome, "Campo obrigatório!");
                txtNome.Focus();
                return;
            }
            else if ((txtEmail.Text != string.Empty) && (!ValidacaoEmail.validarEmail(txtEmail.Text)))
            {
                MessageBox.Show("E-mail inválido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                txtEmail.Focus();
                return;
            }
            else
            {
                try
                {
                    CadastroCliente._StringConn = StringConexao;
                    CadastroCliente._Cod_cliente = int.Parse(lblCodigo.Text);
                    CadastroCliente._Nome = txtNome.Text;
                    CadastroCliente._CPF = Security.Cry(mbCPF.Text);
                    CadastroCliente._RG = Security.Cry(mbRG.Text);
                    CadastroCliente._CEP = mbCEP.Text;
                    CadastroCliente._Logradouro = txtLogradouro.Text;
                    CadastroCliente._Numero = txtNumero.Text;
                    CadastroCliente._Bairro = txtBairro.Text;
                    CadastroCliente._Cidade = txtCidade.Text;
                    CadastroCliente._Estado = cbEstado.Text;
                    CadastroCliente._Telefone = mbTelefone.Text;
                    CadastroCliente._Celular = mbCelular.Text;
                    CadastroCliente._Email = txtEmail.Text;
                    CadastroCliente.Atualizar();
                    MessageBox.Show("Dados Alterado com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "")
            {
                MessageBox.Show("Busque e selecione os dados do cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizarCliente;
            }
            else
            {

                try
                {
                    Contarlinhas();
                    CalcularValores();
                    VerificarPendencias();
                    decimal ST = vt - vp;
                    if (ST == vt)
                    {
                        if (contlinhas > 0)
                        {

                            if (MessageBox.Show("Existe movimentações relacionados com o cliente selecionado. Deseja mesmo excluir os dados?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                verificarPagamento_ExcluirCliente();
                                MessageBox.Show("Dados excluido com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarDgv();
                                Limpar();
                                //Cria uma condição
                                //Se não tiver linhas adionadas no datagridView (dgvDadosCliente) o groupBox (gbLocalizarCliente) junto com o datagridView (dgvDadosCliente) não será visível
                                if (dgvDadosCliente.Rows.Count == 0)
                                {
                                    gbLocalizarCliente.Visible = false;
                                    lblStatus.Visible = true;
                                    lblStatus.Text = "Aguardando resposta...";
                                }
                            }
                        }
                        else
                        {                           

                            if (MessageBox.Show("Deseja mesmo excluir os dados do cliente?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                ContarOrcamento();
                                Verificar_ExcluirCliente();
                                for(int i = 0; i < contlinhas; i++)
                                {
                                    itensPeça._CodOrcamento = CodOrcamento;
                                    itensPeça.ExcluirItens();
                                    Orcamento._Cod_Orcamento = CodOrcamento;
                                    Orcamento.ExcluirOrcamento();
                                   
                                    Verificar_ExcluirCliente();
                                }
                                CadastroCliente._StringConn = StringConexao;
                                CadastroCliente._Cod_cliente = int.Parse(lblCodigo.Text);
                                CadastroCliente.Excluir();
                                MessageBox.Show("Dados excluido com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarDgv();
                                Limpar();
                                //Cria uma condição
                                //Se não tiver linhas adionadas no datagridView (dgvDadosCliente) o groupBox (gbLocalizarCliente) junto com o datagridView (dgvDadosCliente) não será visível
                                if (dgvDadosCliente.Rows.Count == 0)
                                {
                                    gbLocalizarCliente.Visible = false;
                                    lblStatus.Visible = true;
                                    lblStatus.Text = "Aguardando resposta...";
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Exclusão negada! Existe valores que deve ser quitado pelo cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ClassOrcamento Orcamento = new ClassOrcamento();
        ClassFormaPagamento FormaPagamento = new ClassFormaPagamento();
        ClassParcelaPagamento ParcelaPagamento = new ClassParcelaPagamento();
        ClassItensPeça itensPeça = new ClassItensPeça();
        int CodOrcamento;

        decimal vp, vt;
        private void VerificarPendencias()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));

            _sql = "Select sum(ParcelaPagamento.Vp_ParcelaPagamento) from Orcamento inner join ParcelaPagamento on Orcamento.Cod_Orcamento=ParcelaPagamento.Cod_Orcamento where  ParcelaPagamento.DP_ParcelaPagamento = '' and Orcamento.Cod_Cliente = @CodCliente";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    vp = 0;
                }
                else
                {
                    vp = decimal.Parse(comando.ExecuteScalar().ToString());
                }
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

        private void CalcularValores()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));

            _sql = "Select sum(ParcelaPagamento.Vp_ParcelaPagamento) from Orcamento inner join ParcelaPagamento on Orcamento.Cod_Orcamento=ParcelaPagamento.Cod_Orcamento where  Orcamento.Cod_Cliente = @CodCliente";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    vt = 0;
                }
                else
                {
                    vt = decimal.Parse(comando.ExecuteScalar().ToString());
                }
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

        private void verificarPagamento_ExcluirCliente()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            try
            {
                conexao.Open();

                _sql = "Select * from Orcamento inner join ParcelaPagamento on Orcamento.Cod_Orcamento=ParcelaPagamento.Cod_Orcamento where Orcamento.Cod_Cliente = @CodCliente";
                for (int i = 0; i < contlinhas; i++)
                {
                    SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                    comando.SelectCommand.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
                    comando.SelectCommand.CommandText = _sql;

                    DataTable Tabela = new DataTable();
                    comando.Fill(Tabela);
                    if (Tabela.Rows.Count > 0)
                    {
                        CodOrcamento = int.Parse(Tabela.Rows[0]["Cod_Orcamento"].ToString());
                        itensPeça._CodOrcamento = CodOrcamento;
                        itensPeça.ExcluirItens();
                        FormaPagamento._Cod_Orcamento = CodOrcamento;
                        FormaPagamento.ExcluirFormaPagamento();
                        ParcelaPagamento._Cod_Orcamento = CodOrcamento;
                        ParcelaPagamento.ExcluirParcelas();
                        Orcamento._Cod_Orcamento = CodOrcamento;
                        Orcamento.ExcluirOrcamento();
                        CadastroCliente._StringConn = StringConexao;
                        CadastroCliente._Cod_cliente = int.Parse(lblCodigo.Text);
                        CadastroCliente.Excluir();
                    }
                }
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

        int contlinhas;
        private void Contarlinhas()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));

            _sql = "Select Count(Orcamento.Cod_Cliente) from Orcamento inner join ParcelaPagamento on Orcamento.Cod_Orcamento=ParcelaPagamento.Cod_Orcamento where Orcamento.Cod_Cliente = @CodCliente";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    contlinhas = 0;
                }
                else
                {
                    contlinhas = int.Parse(comando.ExecuteScalar().ToString());
                }
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

        private void ContarOrcamento()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));

            _sql = "Select Count(Orcamento.Cod_Cliente) from Orcamento where Cod_Cliente = @CodCliente";
            SqlCommand comando = new SqlCommand(_sql, conexao);
            comando.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
            comando.CommandText = _sql;

            try
            {
                conexao.Open();
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    contlinhas = 0;
                }
                else
                {
                    contlinhas = int.Parse(comando.ExecuteScalar().ToString());
                }
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

        private void Verificar_ExcluirCliente()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            try
            {
                conexao.Open();

                _sql = "Select Cod_Orcamento from Orcamento where Orcamento.Cod_Cliente = @CodCliente";
                SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
                comando.SelectCommand.Parameters.AddWithValue("@CodCliente", lblCodigo.Text);
                comando.SelectCommand.CommandText = _sql;

                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    CodOrcamento = int.Parse(Tabela.Rows[0]["Cod_Orcamento"].ToString());
                }
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
    }
}