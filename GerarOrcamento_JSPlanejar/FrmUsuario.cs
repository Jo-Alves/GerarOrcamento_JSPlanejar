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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        string Page = null;
        string StringConexao = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
        //Estancia a classe Usuario da biblioteca Cadastro
        ClassUsuario Usuario = new ClassUsuario();
        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Limpar();
            //Ao acionar o botão Novo Cadastro o controle TbCadastroUsuario será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroUsuario;
            //O foco será adicionada na caixa de texto 'txtUsuario'
            txtUsuario.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroUsuario'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroUsuario);
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
                case "Usuário":
                    Busca = "Usuario_Login";
                    break;
                case "Código":
                    Busca = "Cod_Usuario";
                    break;
            }
            if (txtPesquisar.Text != "")
            {
                // instanciamos a Classe SqlConnection colocando o usuario do objeto como conexao
                //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
                SqlConnection conexao = new SqlConnection(StringConexao);
                //a variável recebe o comando do banco de dados
                string _sql = "Select * from Usuario where  " + Busca + " like  '%" + txtPesquisar.Text + "%'";
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
                    dgvDadosUsuario.DataSource = Tabela;

                    for (int i = 0; i < dgvDadosUsuario.Rows.Count; i++)
                    {
                       dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value.ToString());
                       dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value.ToString());
                        dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value.ToString());
                    }
                    gbLocalizarUsuario.Visible = true;
                    lblStatus.Visible = false;
                }
                else
                {
                    gbLocalizarUsuario.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = "Nenhum resultado";
                }
            }
            else
            {
                gbLocalizarUsuario.Visible = false;
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";
            }
        }

        private void BtnExibirCadastro_Click(object sender, EventArgs e)
        {
            //Fazemos uma Condição para que se Houver dados a instrução abaixo será acionada
            if (gbLocalizarUsuario.Visible == true)
            {
                //Ao acionar o botão Novo Cadastro o controle TbCadastroUsuario será selecionada e exposta
                tbCadastro.SelectedTab = tbCadastroUsuario;
                //O foco será adicionada na caixa de texto 'txtUsuario'
                txtUsuario.Focus();
                // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroUsuario'
                if (Page == null)
                {
                    tbCadastro.Controls.Add(tbCadastroUsuario);
                }
                // A variável Page recebe vazio
                Page = "";
                this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
                this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnCadastrar.Text = "Cadastrar - F11";
                lblCodigo.Text = Codigo;
                txtUsuario.Text = usuario;
                txtSenha.Text = dgvDadosUsuario.CurrentRow.Cells["ColSenha"].Value.ToString();
                txtDicaSenha.Text = dgvDadosUsuario.CurrentRow.Cells["ColDicaSenha"].Value.ToString();
                cbPerguntaSeguranca.Text = PerguntaSeguranca;
                txtRespostaSeguranca.Text = dgvDadosUsuario.CurrentRow.Cells["ColRespostaseguranca"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione uma cadastro para exibir!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {            
            cbBuscarPor.SelectedIndex = 1;
            txtPesquisar.Focus();
            gbLocalizarUsuario.Visible = false;
            lblStatus.Visible = true;
            lblStatus.Location = new Point(103, 282);
            lblStatus.Text = "Aguardando Busca...";
            lblStatus.ForeColor = Color.Black;
            tbCadastro.Controls.Remove(tbCadastroUsuario);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
        }

        private void CarregarDgv()
        {
            // instanciamos a Classe SqlConnection colocando o usuario do objeto como conexao
            //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
            SqlConnection conexao = new SqlConnection(StringConexao);
            //a variável recebe o comando do banco de dados
            string _sql = "Select * from Usuario";
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
                dgvDadosUsuario.DataSource = Tabela;
                for (int i = 0; i < dgvDadosUsuario.Rows.Count; i++)
                {
                    dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value.ToString());
                    dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value.ToString());
                    dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value.ToString());
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //O tabPage 'tbLocalizarUsuario' é selecionado
            tbCadastro.SelectedTab = tbLocalizarUsuario;
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
                    if (txtUsuario.Text != "" && Situacao != null)
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
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'usuario'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtUsuario, "Campo obrigatório!");
                txtUsuario.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Digite sua Senha", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório!");
                txtSenha.Focus();
                return;
            }
            else if (txtDicaSenha.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Digite a Dica a Senha", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtDicaSenha, "Campo obrigatório!");
                txtDicaSenha.Focus();
                return;
            }
            else  if (cbPerguntaSeguranca.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha ou selecione uma pergunta de segurança", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(cbPerguntaSeguranca, "Campo obrigatório!");
                cbPerguntaSeguranca.Focus();
                return;
            }
            else if (txtRespostaSeguranca.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Responda a pergunta de segurança", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtRespostaSeguranca, "Campo obrigatório!");
                txtRespostaSeguranca.Focus();
                return;
            }
            else if (txtSenha.TextLength < 5)
            {
                errorProvider.Clear();
                MessageBox.Show("A senha deve conter mais de cinco caracteres!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório!");
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    Usuario.VerificarCodigoUsuario();
                    if (lblCodigo.Text != "")
                    {
                        Usuario._Cod_Usuario = int.Parse(lblCodigo.Text);
                    }
                    else
                        Usuario._Cod_Usuario = 0;

                    Usuario._Usuario = txtUsuario.Text;
                    Usuario._Senha = Security.Cry(txtSenha.Text);
                    Usuario._DicaSenha = Security.Cry(txtDicaSenha.Text.Trim());
                    Usuario._PerguntaSeguranca = cbPerguntaSeguranca.Text.Trim();
                    Usuario._RespostaSeguranca = Security.Cry(txtRespostaSeguranca.Text.Trim());
                    if (Usuario.Cadastrar() == false)
                    {
                        MessageBox.Show("Dados cadastrado com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usuario.VerificarCodigoUsuario();
                        lblCodigo.Text = Usuario._Cod_Usuario.ToString();
                        CarregarDgv();
                        Situacao = "Cadastrado";
                    }
                    else
                    {
                        MessageBox.Show("Consta cadastrado no sistema um Usuário com o mesmo código! Limpe todos os campos para o novo cadastro!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtSenha.Clear();
            txtRespostaSeguranca.Clear();
            txtDicaSenha.Clear();           
            txtUsuario.Clear();
            txtPesquisar.Clear();            
            lblCodigo.Text = "";
            cbPerguntaSeguranca.Text = "";
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
            errorProvider.Clear();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //Limpamos o ErroProvide
            errorProvider.Clear();
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O Curso irá focar no campo TxtPesquisar
            if (cbBuscarPor.SelectedIndex == 0)
            {
                lblTitulo.Text = "Código:";
            }
            else if (cbBuscarPor.SelectedIndex == 1)
            {
                lblTitulo.Text = "Usuário:";
            }
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
            comando.SelectCommand.CommandText = "Select * from Usuario";
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvDadosUsuario.DataSource = Tabela;
                for (int i = 0; i < dgvDadosUsuario.Rows.Count; i++)
                {
                    dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColSenha"].Value.ToString());
                    dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColDicaSenha"].Value.ToString());
                    dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value = Security.Dry(dgvDadosUsuario.Rows[i].Cells["ColRespostaSeguranca"].Value.ToString());
                }
                gbLocalizarUsuario.Visible = true;
                lblStatus.Visible = false;               
            }
            else
            {
                MessageBox.Show("O sistema ainda não possui Usuarios cadastrados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";

            }
        }

      string Codigo, usuario, senha, dicaSenha, PerguntaSeguranca, RespostaSeguranca;
       

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                tbCadastro.SelectedTab = tbLocalizarUsuario;
            else if (e.KeyCode == Keys.F2)
                if (Page != null)
                {
                    tbCadastro.SelectedTab = tbCadastroUsuario;
                }
            if (e.KeyCode == Keys.F3)
                BtnNovoCadastro_Click(sender, e);
            if (e.KeyCode == Keys.F4)
                BtnExibirCadastro_Click(sender, e);
            if (e.KeyCode == Keys.F5)
                btnExibirTodos_Click(sender, e);
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

        private void dgvDadosUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDadosUsuario.Columns[e.ColumnIndex].Name == "ColRespostaSeguranca" && e.Value != null)
            {
                dgvDadosUsuario.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
            if (dgvDadosUsuario.Columns[e.ColumnIndex].Name == "ColSenha" && e.Value != null)
            {
                dgvDadosUsuario.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void dgvDadosUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDadosUsuario.SelectedRows.Count > 0)
            {
                Codigo = dgvDadosUsuario.SelectedRows[0].Cells["ColCodigo"].Value.ToString();
                usuario = dgvDadosUsuario.SelectedRows[0].Cells["ColUsuario"].Value.ToString();
                senha = dgvDadosUsuario.SelectedRows[0].Cells["ColSenha"].Value.ToString();
                dicaSenha = dgvDadosUsuario.SelectedRows[0].Cells["ColDicaSenha"].Value.ToString();
                PerguntaSeguranca = dgvDadosUsuario.SelectedRows[0].Cells["ColPerguntaSeguranca"].Value.ToString();
                RespostaSeguranca = dgvDadosUsuario.SelectedRows[0].Cells["ColRespostaSeguranca"].Value.ToString();
            }
        }

       private void dgvDadosUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow row = dgvDadosUsuario.Rows[ContLinhas];
                lblCodigo.Text = row.Cells["ColCodigo"].Value.ToString();
                txtUsuario.Text = row.Cells["ColUsuario"].Value.ToString();
                usuario = txtUsuario.Text.Trim();
                Codigo = lblCodigo.Text;
                txtSenha.Text = row.Cells["ColSenha"].Value.ToString();
                txtDicaSenha.Text = row.Cells["ColDicaSenha"].Value.ToString();
                cbPerguntaSeguranca.Text = row.Cells["ColPerguntaSeguranca"].Value.ToString();
                txtRespostaSeguranca.Text = row.Cells["ColRespostaSeguranca"].Value.ToString();
            }
            //Ao acionar o botão Novo Cadastro o controle TbCadastroUsuario será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroUsuario;
            //O foco será adicionada na caixa de texto 'txtUsuario'
            txtUsuario.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroUsuario'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroUsuario);
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
                MessageBox.Show("Busque e selecione os dados do Usuario!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizarUsuario;
            }
           else if (txtUsuario.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'usuario'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtUsuario, "Campo obrigatório!");
                txtUsuario.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Digite sua Senha", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório!");
                txtSenha.Focus();
                return;
            }
            else if (txtDicaSenha.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Digite a Dica a Senha", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtDicaSenha, "Campo obrigatório!");
                txtDicaSenha.Focus();
                return;
            }
            else if (cbPerguntaSeguranca.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha ou selecione uma pergunta de segurança", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(cbPerguntaSeguranca, "Campo obrigatório!");
                cbPerguntaSeguranca.Focus();
                return;
            }
            else if (txtRespostaSeguranca.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Responda a pergunta de segurança", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtRespostaSeguranca, "Campo obrigatório!");
                txtRespostaSeguranca.Focus();
                return;
            }
            else if (txtSenha.TextLength < 5)
            {
                errorProvider.Clear();
                MessageBox.Show("A senha deve conter mais de cinco caracteres!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtSenha, "Campo obrigatório!");
                txtSenha.Focus();
                return;
            }
            else
            {
                try
                {
                    
                    Usuario._Cod_Usuario = int.Parse(lblCodigo.Text);
                    Usuario._Usuario = txtUsuario.Text;
                    Usuario._Senha = Security.Cry(txtSenha.Text);
                    Usuario._DicaSenha = Security.Cry(txtDicaSenha.Text);
                    Usuario._PerguntaSeguranca = cbPerguntaSeguranca.Text;
                    Usuario._RespostaSeguranca = Security.Cry(txtRespostaSeguranca.Text);
                    Usuario.Atualizar();
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
                MessageBox.Show("Busque e selecione os dados do Usuario!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizarUsuario;
            }
            else
            {             
                if (MessageBox.Show("Deseja mesmo excluir os dados do Usuario?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                  Usuario._Cod_Usuario = int.Parse(lblCodigo.Text);
                    Usuario.Excluir();
                    MessageBox.Show("Dados excluido com sucesso!", "Mensagem do sistema 'GerarOrcamento_JSPlanejar'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDgv();
                    Limpar();
                    //Cria uma condição
                    //Se não tiver linhas adionadas no datagridView (dgvDadosUsuario) o groupBox (gbLocalizarUsuario) junto com o datagridView (dgvDadosUsuario) não será visível
                    if (dgvDadosUsuario.Rows.Count == 0)
                    {
                        gbLocalizarUsuario.Visible = false;
                        lblStatus.Visible = true;
                        lblStatus.Text = "Aguardando resposta...";
                    }
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
