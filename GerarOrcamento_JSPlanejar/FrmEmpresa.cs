using ClassProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarOrcamento_JSPlanejar
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }
        string Page = null;
        string StringConexao = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        //Estancia a classe Empresa da biblioteca Cadastro
        ClassEmpresa Empresa = new ClassEmpresa();

        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Limpar();
            //Ao acionar o botão Novo Cadastro o controle tbCadastroEmpresa será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroEmpresa;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtNomeFantasia.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroEmpresa'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroEmpresa);
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
                case "Nome Fantasia":
                    Busca = "NomeFantasia_Empresa";
                    break;
                case "Código":
                    Busca = "Cod_Empresa";
                    break;
                case "Telefone":
                    Busca = "Telefone_Empresa";
                    break;
                case "Email":
                    Busca = "Email_Empresa";
                    break;
                case "Logradouro":
                    Busca = "Logradouro_Empresa";
                    break;
                case "Cidade":
                    Busca = "Cidade_Empresa";
                    break;
                case "Celular":
                    Busca = "Celular_Empresa";
                    break;
                case "Razao Social":
                    Busca = "RazaoSocial_Empresa";
                    break;
            }
            if (txtPesquisar.Text != "")
            {               
                // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
                //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
                SqlConnection conexao = new SqlConnection(StringConexao);
                //a variável recebe o comando do banco de dados
                string _sql = "Select * from Empresa where  " + Busca + " like  '%" + txtPesquisar.Text + "%'";
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
                    dgvDadosEmpresa.DataSource = Tabela;
                    gbLocalizarEmpresa.Visible = true;
                    lblStatus.Visible = false;
                }
                else
                {
                    gbLocalizarEmpresa.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = "Nenhum resultado";
                }
            }
            else
            {
                gbLocalizarEmpresa.Visible = false;
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";
            }
        }

        private void BtnExibirCadastro_Click(object sender, EventArgs e)
        {
            try
            {  //Fazemos uma Condição para que se Houver dados a instrução abaixo será acionada
                if (gbLocalizarEmpresa.Visible == true)
                {
                    //Ao acionar o botão Novo Cadastro o controle tbCadastroEmpresa será selecionada e exposta
                    tbCadastro.SelectedTab = tbCadastroEmpresa;
                    //O foco será adicionada na caixa de texto 'txtNome'
                    txtNomeFantasia.Focus();
                    // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroEmpresa'
                    if (Page == null)
                    {
                        tbCadastro.Controls.Add(tbCadastroEmpresa);
                    }
                    // A variável Page recebe vazio
                    Page = "";
                    this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
                    this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    this.btnCadastrar.Text = "Cadastrar - F11";
                    lblCodigo.Text = Codigo;
                    txtRazaoSocial.Text = razaoSocial;
                    txtNomeFantasia.Text = nomeFantasia;
                    mbCNPJ.Text = cpf;
                    mbIE.Text = rg;
                    mbCEP.Text = cep;
                    txtLogradouro.Text = logradouro;
                    txtNumero.Text = numero;
                    txtBairro.Text = bairro;
                    txtCidade.Text = cidade;
                    cbEstado.Text = estado;
                    mbTelefone.Text = telefone;
                    mbCelular.Text = celular;
                    txtEmail.Text = email;
                    if (logoEmpresa != "")
                    {
                        pbImagemLogo.Load(logoEmpresa);
                        Diretorio = logoEmpresa;
                    }
                }
                else
                    MessageBox.Show("Selecione uma cadastro para exibir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            cbBuscarPor.SelectedIndex = 5;
            txtPesquisar.Focus();
            gbLocalizarEmpresa.Visible = false;
            lblStatus.Visible = true;
            lblStatus.Location = new Point(103, 282);
            lblStatus.Text = "Aguardando Busca...";
            lblStatus.ForeColor = Color.Black;
            tbCadastro.Controls.Remove(tbCadastroEmpresa);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
        }

        private void CarregarDgv()
        {
            // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
            //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
            SqlConnection conexao = new SqlConnection(StringConexao);
            //a variável recebe o comando do banco de dados
            string _sql = "Select * from Empresa";
            //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            //Instanciamos a classe DataTable
            DataTable Tabela = new DataTable();
            //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
            comando.Fill(Tabela);
            //Fazemos uma condição
            //Caso exista linha na tabela a instrução será  acionada
            dgvDadosEmpresa.DataSource = Tabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //O tabPage 'tbLocalizarEmpresa' é selecionado
            tbCadastro.SelectedTab = tbLocalizarEmpresa;
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
                    if (txtNomeFantasia.Text != "" && Situacao != null)
                    {
                        this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Actions_list_add_icon;
                        this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

                        this.btnCadastrar.Text = "Incluir - F11";
                    }
                    break;
            }
        }


        private void CriarPasta()
        {
            string Pasta = @"C:\Orçamento_JsPlanejar\Imagens do sistema\";
            if (!Directory.Exists(Pasta))
            {
                Directory.CreateDirectory(Pasta);
            }
        }

        public string Diretorio { get; set; }


        private void Cadastrar()
        {
            if (txtRazaoSocial.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Razão social'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtRazaoSocial, "Campo obrigatório!");
                txtRazaoSocial.Focus();
                return;
            }
            else if (txtNomeFantasia.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Nome fantasia'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtNomeFantasia, "Campo obrigatório!");
                txtNomeFantasia.Focus();
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
                    Empresa.razaoSocial = txtRazaoSocial.Text.Trim();
                    Empresa.nomeFantasia = txtNomeFantasia.Text.Trim();
                    Empresa.CNPJ = mbCNPJ.Text;
                    Empresa.inscricao = mbIE.Text;
                    Empresa.CEP = mbCEP.Text;
                    Empresa.logradouro = txtLogradouro.Text.Trim();
                    Empresa.numero = txtNumero.Text.Trim();
                    Empresa.bairro = txtBairro.Text.Trim();
                    Empresa.cidade = txtCidade.Text.Trim();
                    Empresa.estado = cbEstado.Text.Trim();
                    Empresa.telefone = mbTelefone.Text.Trim();
                    Empresa.celular = mbCelular.Text.Trim();
                    Empresa.email = txtEmail.Text.Trim();
                    if (Diretorio == null)
                    {
                        Diretorio = "";
                    }
                    else if (Diretorio != null)
                    {
                        try
                        {
                            CriarPasta();
                            string ArquivoImagem = Diretorio;
                            string NomedoArquivo = Path.GetFileName(Diretorio);

                            FileInfo fileInfo = new FileInfo(ArquivoImagem);
                            fileInfo.CopyTo(@"C:\Orçamento_JsPlanejar\Imagens do sistema\" + NomedoArquivo);
                            Diretorio = @"C:\Orçamento_JsPlanejar\Imagens do sistema\" + NomedoArquivo;
                        }
                        catch
                        {

                        }
                    }
                    else if (pbImagemLogo.Image == null)
                    {
                        Diretorio = "";
                    }
                    Empresa.logoEmpresa = Diretorio;
                    if (Empresa.Cadastrar() == false)
                    {
                        MessageBox.Show("Dados cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Empresa.VerificarCodigoEmpresa();
                        lblCodigo.Text = Empresa.Cod_Empresa.ToString();
                        CarregarDgv();
                        Situacao = "Cadastrado";
                    }
                    else
                    {
                        MessageBox.Show("Não é permitido mais cadastros!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            txtRazaoSocial.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtLogradouro.Clear();
            txtNomeFantasia.Clear();
            txtNumero.Clear();
            txtPesquisar.Clear();
            mbTelefone.Clear();
            mbCelular.Clear();
            mbCEP.Clear();
            mbCNPJ.Clear();
            lblCodigo.Text = "";
            cbEstado.SelectedIndex = -1;
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
            errorProvider.Clear();
            pbImagemLogo.Image = null;
            Diretorio = null;
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
            lblDados.Text = "Cidade";
            else if (cbBuscarPor.SelectedIndex == 1)
                lblDados.Text = "Celular";
            else if (cbBuscarPor.SelectedIndex == 2)
                lblDados.Text = "Código";
            else if (cbBuscarPor.SelectedIndex == 3)
                lblDados.Text = "Email";
            else if (cbBuscarPor.SelectedIndex == 4)
                lblDados.Text = "Logradouro";
            else if (cbBuscarPor.SelectedIndex == 5)
                lblDados.Text = "Nome Fantasia";
            else if (cbBuscarPor.SelectedIndex == 6)
                lblDados.Text = "RazaoSocial";
            else if (cbBuscarPor.SelectedIndex == 7)
                lblDados.Text = "Telefone";
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
            comando.SelectCommand.CommandText = "Select * from Empresa";
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvDadosEmpresa.DataSource = Tabela;
                gbLocalizarEmpresa.Visible = true;
                lblStatus.Visible = false;
            }
            else
            {
                MessageBox.Show("O sistema ainda não possui a empresa cadastrada!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        string Codigo, razaoSocial, nomeFantasia, cpf, rg, cep, logradouro, numero, bairro, cidade, estado, telefone, celular, email, logoEmpresa;

        private void mbCNPJ_Leave(object sender, EventArgs e)
        {
            try
            {
                if (mbCNPJ.MaskCompleted)
                {
                    if (!DOC.ValidarCNPJ(mbCNPJ.Text))
                    {
                        MessageBox.Show("O número do CNPJ é inválido!", "Validação CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProvider.SetError(mbCNPJ, "CNPJ inválido!");
                        mbCNPJ.Clear();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            Diretorio = null;
            pbImagemLogo.Image = null;
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
           OpenFileDialog AbrirArquivo = new OpenFileDialog();
            AbrirArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF*";
            if (AbrirArquivo.ShowDialog() == DialogResult.OK)
            {
                Diretorio = AbrirArquivo.FileName;
                pbImagemLogo.Load(Diretorio);
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

        private void FrmEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                tbCadastro.SelectedTab = tbLocalizarEmpresa;
            else if (e.KeyCode == Keys.F2)
                if (Page != null)
                {
                    tbCadastro.SelectedTab = tbCadastroEmpresa;
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
            if (e.KeyCode == Keys.F9)
                btnAtualizar_Click(sender, e);
            if (e.KeyCode == Keys.F10)
                btnPesquisar_Click(sender, e);
            if (e.KeyCode == Keys.F11)
                btnCadastrar_Click(sender, e);

        }

        private void dgvDadosEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDadosEmpresa.SelectedRows.Count > 0)
            {
                Codigo = dgvDadosEmpresa.SelectedRows[0].Cells["ColCodigo"].Value.ToString();
                razaoSocial = dgvDadosEmpresa.SelectedRows[0].Cells["ColRazaoSocial"].Value.ToString();
                nomeFantasia = dgvDadosEmpresa.SelectedRows[0].Cells["ColNomeFantasia"].Value.ToString();
                cpf = dgvDadosEmpresa.SelectedRows[0].Cells["ColCNPJ"].Value.ToString();
                rg = dgvDadosEmpresa.SelectedRows[0].Cells["ColIE"].Value.ToString();
                cep = dgvDadosEmpresa.SelectedRows[0].Cells["ColCEP"].Value.ToString();
                logradouro = dgvDadosEmpresa.SelectedRows[0].Cells["ColLogradouro"].Value.ToString();
                bairro = dgvDadosEmpresa.SelectedRows[0].Cells["ColBairro"].Value.ToString();
                cidade = dgvDadosEmpresa.SelectedRows[0].Cells["ColCidade"].Value.ToString();
                estado = dgvDadosEmpresa.SelectedRows[0].Cells["ColEstado"].Value.ToString();
                telefone = dgvDadosEmpresa.SelectedRows[0].Cells["ColTelefone"].Value.ToString();
                celular = dgvDadosEmpresa.SelectedRows[0].Cells["ColCelular"].Value.ToString();
                email = dgvDadosEmpresa.SelectedRows[0].Cells["ColEmail"].Value.ToString();
                logoEmpresa = dgvDadosEmpresa.SelectedRows[0].Cells["ColLogoEmpresa"].Value.ToString();
            }
        }

        private void dgvDadosEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow row = dgvDadosEmpresa.Rows[ContLinhas];
                lblCodigo.Text = row.Cells["ColCodigo"].Value.ToString();
                txtNomeFantasia.Text = row.Cells["ColNomeFantasia"].Value.ToString();
                mbCNPJ.Text = row.Cells["ColCNPJ"].Value.ToString();
                mbIE.Text = row.Cells["ColIE"].Value.ToString();
                mbCEP.Text = row.Cells["ColCEP"].Value.ToString();
                txtLogradouro.Text = row.Cells["ColLogradouro"].Value.ToString();
                txtBairro.Text = row.Cells["ColBairro"].Value.ToString();
                txtCidade.Text = row.Cells["ColCidade"].Value.ToString();
                cbEstado.Text = row.Cells["ColEstado"].Value.ToString();
                mbTelefone.Text = row.Cells["ColTelefone"].Value.ToString();
                mbCelular.Text = row.Cells["ColCelular"].Value.ToString();
                txtEmail.Text = row.Cells["ColEmail"].Value.ToString();
            }
            //Ao acionar o botão Novo Cadastro o controle tbCadastroEmpresa será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroEmpresa;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtNomeFantasia.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroEmpresa'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroEmpresa);
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
                MessageBox.Show("Busque e selecione os dados do Empresa!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizarEmpresa;
            }
            else if (txtRazaoSocial.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Razão social'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtRazaoSocial, "Campo obrigatório!");
                txtRazaoSocial.Focus();
                return;
            }
            else if (txtNomeFantasia.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Nome fantasia'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtNomeFantasia, "Campo obrigatório!");
                txtNomeFantasia.Focus();
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
                   Empresa.Cod_Empresa = int.Parse(lblCodigo.Text);
                    Empresa.razaoSocial = txtRazaoSocial.Text.Trim();
                    Empresa.nomeFantasia = txtNomeFantasia.Text;
                    Empresa.CNPJ = mbCNPJ.Text;
                    Empresa.inscricao = mbIE.Text;
                    Empresa.CEP = mbCEP.Text;
                    Empresa.logradouro = txtLogradouro.Text;
                    Empresa.numero = txtNumero.Text;
                    Empresa.bairro = txtBairro.Text;
                    Empresa.cidade = txtCidade.Text;
                    Empresa.estado = cbEstado.Text;
                    Empresa.telefone = mbTelefone.Text;
                    Empresa.celular = mbCelular.Text;
                    Empresa.email = txtEmail.Text;
                    if (Diretorio == null)
                    {
                        Diretorio = "";
                    }
                    else if (Diretorio != null)
                    {
                        try
                        {
                            CriarPasta();
                            string ArquivoImagem = Diretorio;
                            string NomedoArquivo = Path.GetFileName(Diretorio);

                            FileInfo fileInfo = new FileInfo(ArquivoImagem);
                            fileInfo.CopyTo(@"C:\Orçamento_JsPlanejar\Imagens do sistema\" + NomedoArquivo);
                            Diretorio = @"C:\Orçamento_JsPlanejar\Imagens do sistema\" + NomedoArquivo;
                        }
                        catch
                        {

                        }
                    }
                    else if (pbImagemLogo.Image == null)
                    {
                        Diretorio = "";
                    }
                    Empresa.logoEmpresa = Diretorio;
                    Empresa.Atualizar();
                    MessageBox.Show("Dados Alterado com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
