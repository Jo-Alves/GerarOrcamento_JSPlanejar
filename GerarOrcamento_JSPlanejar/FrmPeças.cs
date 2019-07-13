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
    public partial class FrmPeças : Form
    {
        public FrmPeças()
        {
            InitializeComponent();
        }
        string Page = null;

        //Estancia a classe CadastroCliente da biblioteca Cadastro
        CadastroCliente CadastroCliente = new CadastroCliente();
        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Limpar();
            //Ao acionar o botão Novo Cadastro o controle TbCadastroCliente será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroPecas;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtDescricao.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroCliente'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroPecas);
            }
            // A variável Page recebe vazio
            Page = "";
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Text = "Cadastrar - F11";
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
                //Dentro da instância colomos como parãmetro a string de conexão do banco de dados
                SqlConnection conexao = new SqlConnection(@"Data Source = LOCALHOST\SQLEXPRESS; Initial Catalog = dbControleOrcamento; Integrated Security = True");
                //a variável recebe o comando do banco de dados
                string _sql = "Select * from Pecas where  Desdcricao_Pecas like  '%" + txtPesquisar.Text + "%'";
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
                    dgvDadosPeça.DataSource = Tabela;
                    gbLocalizarPeça.Visible = true;
                    lblStatus.Visible = false;
                }
                else
                {
                    gbLocalizarPeça.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = "Nenhum resultado";
                }
            }
            else
            {
                gbLocalizarPeça.Visible = false;
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";
            }
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Peça._Conexao);
            try
            {
                SqlDataAdapter comando = new SqlDataAdapter("", conexao);
                comando.SelectCommand.CommandText = "Select * from Peça";
                DataTable Tabela = new DataTable();
                comando.Fill(Tabela);
                if (Tabela.Rows.Count > 0)
                {
                    dgvDadosPeça.DataSource = Tabela;
                    gbLocalizarPeça.Visible = true;
                    lblStatus.Visible = false;
                }
                else
                {
                    MessageBox.Show("O sistema ainda não possui peças cadastradas!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Aguardando resposta...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Classes.ClassPeça Peça = new Classes.ClassPeça();
        private void FrmCliente_Load(object sender, EventArgs e)
        {           
            Peça._Conexao = Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]);
            txtPesquisar.Focus();
            gbLocalizarPeça.Visible = false;
            lblStatus.Visible = true;
            lblStatus.Location = new Point(140, 200);
            lblStatus.Text = "Aguardando Busca...";
            lblStatus.ForeColor = Color.Black;
            tbCadastro.Controls.Remove(tbCadastroPecas);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
        }

        private void CarregarDgv()
        {
            // instanciamos a Classe SqlConnection colocando o nome do objeto como conexao
            //Dentro da instância colocamos como parãmetro a string de conexão do banco de dados
            SqlConnection conexao = new SqlConnection(Peça._Conexao);
            //a variável recebe o comando do banco de dados
            string _sql = "Select * from peça";
            //instanciamos a classe SqlDataadapter e como parâmentro ela receberá o comando e a conexão com o banco de dados
            SqlDataAdapter comando = new SqlDataAdapter(_sql, conexao);
            comando.SelectCommand.CommandText = _sql;
            //Instanciamos a classe DataTable
            DataTable Tabela = new DataTable();
            //preenchemos a Tabela com os dados recebidos Pela SQlDataAdapter
            comando.Fill(Tabela);
            //Fazemos uma condição
            //Caso exista linha na tabela a instrução será  acionada
            dgvDadosPeça.DataSource = Tabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //O tabPage 'tbLocalizarCliente' é selecionado
            tbCadastro.SelectedTab = tbLocalizaPecas;
        }

        ErrorProvider errorProvider = new ErrorProvider();
        string Situacao;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //a string de conexão recebe o texto do botão cadastrar
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
                    if (txtDescricao.Text != "" && Situacao != null)
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
            if (txtDescricao.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Descrição'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtDescricao, "Campo obrigatório!");
                txtDescricao.Focus();
                return;
            }
            else if (txtValor.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Valor'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtValor, "Campo obrigatório!");
                txtValor.Focus();
                return;
            }
            else
            {
                try
                {
                    Peça._Conexao = Peça._Conexao;
                    if (lblCodigo.Text == "")
                    {
                        Peça._CodigoPeça = 0;
                    }
                    else
                    {
                        Peça._CodigoPeça = int.Parse(lblCodigo.Text);
                    }
                    Peça._DescricaoPeça = txtDescricao.Text.Trim();
                    Peça._ValorPeça = decimal.Parse(txtValor.Text.Trim());
                    Peça._ComprimentoPeça = txtComprimento.Text.Trim();
                    Peça._UnidadePeça = cbUnidade.Text.Trim();
                    if (Peça.Cadastrar() == true)
                    {
                        MessageBox.Show("Dados cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Peça.VerificarCodigo();
                        lblCodigo.Text = Peça._CodigoPeça.ToString();
                        CarregarDgv();
                        Situacao = "Cadastrado";
                    }
                    else
                    {
                        MessageBox.Show("Consta cadastrado no sistema uma peça com o mesmo código! Limpe todos os campos para o novo cadastro!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtValor.Clear();
            txtDescricao.Clear();
            txtComprimento.Clear();
            txtPesquisar.Clear();          
            lblCodigo.Text = "";
            cbUnidade.SelectedIndex = -1;
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
            this.btnExibirTodos.BorderStyle = BorderStyle.FixedSingle;
            this.btnExibirTodos.BackColor = Color.Aquamarine;
        }

        private void btnExibirCadastro_MouseLeave(object sender, EventArgs e)
        {
            //O plano de fundo e o estilo irá ser acionado ao retirar o cursor do mouse em cima do item
            this.btnExibirTodos.BorderStyle = BorderStyle.None;
            this.btnExibirTodos.BackColor = Color.Transparent;
        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source = LOCALHOST\SQLEXPRESS; Initial Catalog = dbControleOrcamento; Integrated Security = True");
            SqlDataAdapter comando = new SqlDataAdapter("", conexao);
            comando.SelectCommand.CommandText = "Select * from Cliente";
            DataTable Tabela = new DataTable();
            comando.Fill(Tabela);
            if (Tabela.Rows.Count > 0)
            {
                dgvDadosPeça.DataSource = Tabela;
                gbLocalizarPeça.Visible = true;
                lblStatus.Visible = false;
            }
            else
            {
                MessageBox.Show("O sistema ainda não possui clientes cadastrados!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblStatus.Visible = true;
                lblStatus.Text = "Aguardando resposta...";

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                tbCadastro.SelectedTab = tbLocalizaPecas;
            else if (e.KeyCode == Keys.F2)
                if (Page != null)
                {
                    tbCadastro.SelectedTab = tbCadastroPecas;
                }
            if (e.KeyCode == Keys.F3)
                BtnNovoCadastro_Click(sender, e);
            if (e.KeyCode == Keys.F4)
                BtnExibirTodos_Click(sender, e);
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

        private void dgvDadosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ContLinhas = e.RowIndex;
            if (ContLinhas > -1)
            {
                DataGridViewRow row = dgvDadosPeça.Rows[ContLinhas];
                lblCodigo.Text = row.Cells["ColCodigo"].Value.ToString();
                txtDescricao.Text = row.Cells["ColDescricao"].Value.ToString();
                txtValor.Text = row.Cells["ColValor"].Value.ToString();
                txtComprimento.Text = row.Cells["ColComprimento"].Value.ToString();
                cbUnidade.Text = row.Cells["ColUnidade"].Value.ToString();
            }
            //Ao acionar o botão Novo Cadastro o controle TbCadastroCliente será selecionada e exposta
            tbCadastro.SelectedTab = tbCadastroPecas;
            //O foco será adicionada na caixa de texto 'txtNome'
            txtDescricao.Focus();
            // Se a váriável Page for null será adicionada no tabCadastro a tabpage 'tbCadastroCliente'
            if (Page == null)
            {
                tbCadastro.Controls.Add(tbCadastroPecas);
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
                tbCadastro.SelectedTab = tbLocalizaPecas;
            }
            else if (txtDescricao.Text == string.Empty)
            {
                errorProvider.Clear();
                MessageBox.Show("Preencha o campo 'Nome'", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider.SetError(txtDescricao, "Campo obrigatório!");
                txtDescricao.Focus();
                return;
            }
            else
            {

                try
                {
                    Peça._CodigoPeça = int.Parse(lblCodigo.Text);
                    Peça._DescricaoPeça = txtDescricao.Text.Trim();
                    Peça._ValorPeça = decimal.Parse(txtValor.Text.Trim());
                    Peça._ComprimentoPeça = txtComprimento.Text.Trim();
                    Peça._UnidadePeça = cbUnidade.Text.Trim();                    
                    Peça.Atualizar();
                    MessageBox.Show("Dados alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ClassItensPeça itensPeça = new ClassItensPeça();
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lblCodigo.Text == "")
            {
                MessageBox.Show("Busque e selecione os dados do cliente!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCadastro.SelectedTab = tbLocalizaPecas;
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo excluir os dados do cliente?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        VerificarSituacao();

                        if (Situacao_Orcamento == "Não há lançamento!")
                        {
                            Peça._CodigoPeça = int.Parse(lblCodigo.Text);
                            Peça.Excluir();
                            MessageBox.Show("Dados excluido com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarDgv();
                            Limpar();
                            //Cria uma condição
                            //Se não tiver linhas adionadas no datagridView (dgvDadosPeça) o groupBox (gbLocalizarCliente) junto com o datagridView (dgvDadosPeça) não será visível
                            if (dgvDadosPeça.Rows.Count == 0)
                            {
                                gbLocalizarPeça.Visible = false;
                                lblStatus.Visible = true;
                                lblStatus.Text = "Aguardando resposta...";
                            }
                        }

                        else if (Vl1 > 0 && vl2 == 0)
                        {
                            DialogResult dr = MessageBox.Show("A exclusão deste item pode desorganizar alguns orçamento realizados. Deseja mesmo excluir este item?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                            if (dr == DialogResult.Yes)
                            {
                                itensPeça._CodPeça = int.Parse(lblCodigo.Text);
                                itensPeça.ExcluirItens();
                                Peça._CodigoPeça = int.Parse(lblCodigo.Text);
                                Peça.Excluir();
                                MessageBox.Show("Dados excluido com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarDgv();
                                Limpar();
                                //Cria uma condição
                                //Se não tiver linhas adionadas no datagridView (dgvDadosPeça) o groupBox (gbLocalizarCliente) junto com o datagridView (dgvDadosPeça) não será visível
                                if (dgvDadosPeça.Rows.Count == 0)
                                {
                                    gbLocalizarPeça.Visible = false;
                                    lblStatus.Visible = true;
                                    lblStatus.Text = "Aguardando resposta...";
                                }
                            }
                        }

                        else if (vl3 > 1 && vl4 > 0)
                            MessageBox.Show("Há lançamentos de orçamento que impede a exclusão deste item! É necessário excluir o orçamento ou excluir após o quitamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                      
                        else
                            MessageBox.Show("Exclusão negada! Há serviços prestados que não foram totalmente quitados! Só poderá ser realizado a exclusão de algum item após o quitamento!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
        }

        string Situacao_Orcamento;
        private void VerificarSituacao()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Select Orcamento.Cod_Orcamento, Orcamento.Situacao_Orcamento from orcamento inner join ItensPeça on ItensPeça.Cod_Orcamento = Orcamento.Cod_Orcamento inner join Peça on Peça.Cod_Peça = ItensPeça.Cod_Peça where ItensPeça.Cod_Peça = @CodPeça";
            ContarTabela();
            for (int i = 0; i < Cont; i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
                adapter.SelectCommand.Parameters.AddWithValue("@CodPeça", int.Parse(lblCodigo.Text));
                adapter.SelectCommand.CommandText = _sql;
                DataTable Tabela = new DataTable();
                adapter.Fill(Tabela);
                try
                {
                    conexao.Open();

                    if (Tabela.Rows.Count > 0)
                    {
                        Situacao_Orcamento = Tabela.Rows[i]["Situacao_Orcamento"].ToString();
                        if (Situacao_Orcamento == "Quitado")
                        {
                            Vl1 += 1;
                        }
                        else
                        {
                            vl2 = 1;
                        }
                        if (Situacao_Orcamento == "Aprovado" || Situacao_Orcamento == "Recusado" || Situacao_Orcamento == "Pendente")
                            vl3 += 1;
                        else
                            vl4 = 1;
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
        }

        int Cont, Vl1 = 1, vl2, vl3 = 1, vl4;
        private void ContarTabela()
        {
            SqlConnection conexao = new SqlConnection(Security.Dry(ConfigurationSettings.AppSettings["CadeiaConexao"]));
            string _sql = "Select Count(Orcamento.Cod_Orcamento) as count from orcamento inner join ItensPeça on ItensPeça.Cod_Orcamento = Orcamento.Cod_Orcamento inner join Peça on Peça.Cod_Peça = ItensPeça.Cod_Peça where ItensPeça.Cod_Peça = @CodPeça";
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conexao);
            adapter.SelectCommand.Parameters.AddWithValue("@CodPeça", int.Parse(lblCodigo.Text));
            adapter.SelectCommand.CommandText = _sql;
            DataTable Tabela = new DataTable();
            adapter.Fill(Tabela);
            try
            {
                conexao.Open();
                Cont = int.Parse(Tabela.Rows[0]["count"].ToString());
                if (Cont == 0)
                {
                    Situacao_Orcamento = "Não há lançamento!";
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Método que permite a entrada de número e uma virgula após inserção de números
            try
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (((int)e.KeyChar) != ((int)Keys.Back))
                        if (e.KeyChar != ',')
                            e.Handled = true;
                        else if (txtValor.Text.IndexOf(',') > 0)
                            e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                txtValor.Text = decimal.Parse(txtValor.Text.Trim()).ToString("0.00");
            }
        }
    }
}
