namespace GerarOrcamento_JSPlanejar
{
    partial class FrmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tbLocalizarEmpresa = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbLocalizarEmpresa = new System.Windows.Forms.GroupBox();
            this.dgvDadosEmpresa = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibirTodos = new System.Windows.Forms.Label();
            this.btnExibirCadastro = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tbCadastroEmpresa = new System.Windows.Forms.TabPage();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.pbImagemLogo = new System.Windows.Forms.PictureBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mbCEP = new System.Windows.Forms.MaskedTextBox();
            this.mbIE = new System.Windows.Forms.MaskedTextBox();
            this.mbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultarCEP = new System.Windows.Forms.Button();
            this.tbCadastro.SuspendLayout();
            this.tbLocalizarEmpresa.SuspendLayout();
            this.gbLocalizarEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbCadastroEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tbLocalizarEmpresa);
            this.tbCadastro.Controls.Add(this.tbCadastroEmpresa);
            this.tbCadastro.Location = new System.Drawing.Point(1, -4);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(732, 589);
            this.tbCadastro.TabIndex = 122131;
            // 
            // tbLocalizarEmpresa
            // 
            this.tbLocalizarEmpresa.BackColor = System.Drawing.Color.White;
            this.tbLocalizarEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalizarEmpresa.Controls.Add(this.lblStatus);
            this.tbLocalizarEmpresa.Controls.Add(this.gbLocalizarEmpresa);
            this.tbLocalizarEmpresa.Controls.Add(this.btnExibirTodos);
            this.tbLocalizarEmpresa.Controls.Add(this.btnExibirCadastro);
            this.tbLocalizarEmpresa.Controls.Add(this.btnNovoCadastro);
            this.tbLocalizarEmpresa.Controls.Add(this.groupBox1);
            this.tbLocalizarEmpresa.Location = new System.Drawing.Point(4, 28);
            this.tbLocalizarEmpresa.Name = "tbLocalizarEmpresa";
            this.tbLocalizarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocalizarEmpresa.Size = new System.Drawing.Size(724, 557);
            this.tbLocalizarEmpresa.TabIndex = 0;
            this.tbLocalizarEmpresa.Text = "Localizar Empresa - F1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(570, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 31);
            this.lblStatus.TabIndex = 1238;
            // 
            // gbLocalizarEmpresa
            // 
            this.gbLocalizarEmpresa.Controls.Add(this.dgvDadosEmpresa);
            this.gbLocalizarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbLocalizarEmpresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocalizarEmpresa.Location = new System.Drawing.Point(2, 100);
            this.gbLocalizarEmpresa.Name = "gbLocalizarEmpresa";
            this.gbLocalizarEmpresa.Size = new System.Drawing.Size(562, 446);
            this.gbLocalizarEmpresa.TabIndex = 1237;
            this.gbLocalizarEmpresa.TabStop = false;
            this.gbLocalizarEmpresa.Text = "Localizar Empresa";
            // 
            // dgvDadosEmpresa
            // 
            this.dgvDadosEmpresa.AllowUserToAddRows = false;
            this.dgvDadosEmpresa.AllowUserToDeleteRows = false;
            this.dgvDadosEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosEmpresa.ColumnHeadersHeight = 32;
            this.dgvDadosEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDadosEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColRazaoSocial,
            this.ColNomeFantasia,
            this.ColCNPJ,
            this.ColIE,
            this.ColCep,
            this.ColLogradouro,
            this.ColNumero,
            this.ColBairro,
            this.ColCidade,
            this.ColEstado,
            this.ColTelefone,
            this.ColCelular,
            this.ColEmail,
            this.colLogoEmpresa});
            this.dgvDadosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosEmpresa.Location = new System.Drawing.Point(3, 22);
            this.dgvDadosEmpresa.MultiSelect = false;
            this.dgvDadosEmpresa.Name = "dgvDadosEmpresa";
            this.dgvDadosEmpresa.ReadOnly = true;
            this.dgvDadosEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosEmpresa.Size = new System.Drawing.Size(556, 421);
            this.dgvDadosEmpresa.TabIndex = 12;
            this.dgvDadosEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosEmpresa_CellDoubleClick);
            this.dgvDadosEmpresa.SelectionChanged += new System.EventHandler(this.dgvDadosEmpresa_SelectionChanged);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodigo.DataPropertyName = "Cod_Empresa";
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 81;
            // 
            // ColRazaoSocial
            // 
            this.ColRazaoSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRazaoSocial.DataPropertyName = "RazaoSocial_Empresa";
            this.ColRazaoSocial.HeaderText = "Razão Social";
            this.ColRazaoSocial.Name = "ColRazaoSocial";
            this.ColRazaoSocial.ReadOnly = true;
            this.ColRazaoSocial.Width = 120;
            // 
            // ColNomeFantasia
            // 
            this.ColNomeFantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNomeFantasia.DataPropertyName = "NomeFantasia_Empresa";
            this.ColNomeFantasia.HeaderText = "Nome Fantasia";
            this.ColNomeFantasia.Name = "ColNomeFantasia";
            this.ColNomeFantasia.ReadOnly = true;
            this.ColNomeFantasia.Width = 135;
            // 
            // ColCNPJ
            // 
            this.ColCNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCNPJ.DataPropertyName = "CNPJ_Empresa";
            this.ColCNPJ.HeaderText = "CNPJ";
            this.ColCNPJ.Name = "ColCNPJ";
            this.ColCNPJ.ReadOnly = true;
            this.ColCNPJ.Width = 74;
            // 
            // ColIE
            // 
            this.ColIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColIE.DataPropertyName = "InscricaoEstadual_Empresa";
            this.ColIE.HeaderText = "Inscrição Estadual";
            this.ColIE.Name = "ColIE";
            this.ColIE.ReadOnly = true;
            this.ColIE.Width = 157;
            // 
            // ColCep
            // 
            this.ColCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCep.DataPropertyName = "CEP_Empresa";
            this.ColCep.HeaderText = "CEP";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            this.ColCep.Width = 64;
            // 
            // ColLogradouro
            // 
            this.ColLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLogradouro.DataPropertyName = "Logradouro_Empresa";
            this.ColLogradouro.HeaderText = "Logradouro";
            this.ColLogradouro.Name = "ColLogradouro";
            this.ColLogradouro.ReadOnly = true;
            this.ColLogradouro.Width = 112;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumero.DataPropertyName = "Numero_Empresa";
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 88;
            // 
            // ColBairro
            // 
            this.ColBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBairro.DataPropertyName = "Bairro_Empresa";
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Width = 77;
            // 
            // ColCidade
            // 
            this.ColCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCidade.DataPropertyName = "Cidade_Empresa";
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            this.ColCidade.Width = 81;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEstado.DataPropertyName = "Estado_Empresa";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 80;
            // 
            // ColTelefone
            // 
            this.ColTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTelefone.DataPropertyName = "Telefone_Empresa";
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            this.ColTelefone.Width = 92;
            // 
            // ColCelular
            // 
            this.ColCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCelular.DataPropertyName = "Celular_Empresa";
            this.ColCelular.HeaderText = "Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            this.ColCelular.Width = 83;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEmail.DataPropertyName = "Email_Empresa";
            this.ColEmail.HeaderText = "E-mail";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 77;
            // 
            // colLogoEmpresa
            // 
            this.colLogoEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLogoEmpresa.DataPropertyName = "LogoEmpresa_Empresa";
            this.colLogoEmpresa.HeaderText = "Logo Empresa";
            this.colLogoEmpresa.Name = "colLogoEmpresa";
            this.colLogoEmpresa.ReadOnly = true;
            this.colLogoEmpresa.Width = 131;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.company_building_icon__128px_;
            this.btnExibirTodos.Location = new System.Drawing.Point(577, 381);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(139, 165);
            this.btnExibirTodos.TabIndex = 41;
            this.btnExibirTodos.Text = "Exibir Todos - F5";
            this.btnExibirTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            this.btnExibirTodos.MouseEnter += new System.EventHandler(this.btnExibirTodos_MouseEnter);
            this.btnExibirTodos.MouseLeave += new System.EventHandler(this.btnExibirTodos_MouseLeave);
            // 
            // btnExibirCadastro
            // 
            this.btnExibirCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirCadastro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCadastro.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.company_building_icon__128px_;
            this.btnExibirCadastro.Location = new System.Drawing.Point(567, 179);
            this.btnExibirCadastro.Name = "btnExibirCadastro";
            this.btnExibirCadastro.Size = new System.Drawing.Size(149, 170);
            this.btnExibirCadastro.TabIndex = 40;
            this.btnExibirCadastro.Text = "Exibir Cadastro - F4";
            this.btnExibirCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExibirCadastro.Click += new System.EventHandler(this.BtnExibirCadastro_Click);
            this.btnExibirCadastro.MouseEnter += new System.EventHandler(this.btnExibirCadastro_MouseEnter);
            this.btnExibirCadastro.MouseLeave += new System.EventHandler(this.btnExibirCadastro_MouseLeave);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Actions_contact_new_icon;
            this.btnNovoCadastro.Location = new System.Drawing.Point(567, 6);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(146, 145);
            this.btnNovoCadastro.TabIndex = 39;
            this.btnNovoCadastro.Text = "Novo Cadastro - F3";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoCadastro.Click += new System.EventHandler(this.BtnNovoCadastro_Click);
            this.btnNovoCadastro.MouseEnter += new System.EventHandler(this.btnNovoCadastro_MouseEnter);
            this.btnNovoCadastro.MouseLeave += new System.EventHandler(this.btnNovoCadastro_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDados);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbBuscarPor);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 88);
            this.groupBox1.TabIndex = 1234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Empresa";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(138, 22);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(54, 19);
            this.lblDados.TabIndex = 39;
            this.lblDados.Text = "Nome:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 19);
            this.label15.TabIndex = 38;
            this.label15.Text = "Buscar por:";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBuscarPor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Items.AddRange(new object[] {
            "Cidade",
            "Celular",
            "Código",
            "Email",
            "Logradouro",
            "Nome Fantasia",
            "RazaoSocial",
            "Telefone"});
            this.cbBuscarPor.Location = new System.Drawing.Point(6, 45);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(121, 27);
            this.cbBuscarPor.TabIndex = 37;
            this.cbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPor_SelectedIndexChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(133, 45);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(360, 26);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // tbCadastroEmpresa
            // 
            this.tbCadastroEmpresa.BackColor = System.Drawing.Color.White;
            this.tbCadastroEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbCadastroEmpresa.Controls.Add(this.btnLimparImagem);
            this.tbCadastroEmpresa.Controls.Add(this.btnAdicionarImagem);
            this.tbCadastroEmpresa.Controls.Add(this.pbImagemLogo);
            this.tbCadastroEmpresa.Controls.Add(this.txtRazaoSocial);
            this.tbCadastroEmpresa.Controls.Add(this.label11);
            this.tbCadastroEmpresa.Controls.Add(this.btnLimpar);
            this.tbCadastroEmpresa.Controls.Add(this.lblCodigo);
            this.tbCadastroEmpresa.Controls.Add(this.mbCelular);
            this.tbCadastroEmpresa.Controls.Add(this.mbTelefone);
            this.tbCadastroEmpresa.Controls.Add(this.label14);
            this.tbCadastroEmpresa.Controls.Add(this.txtEmail);
            this.tbCadastroEmpresa.Controls.Add(this.label13);
            this.tbCadastroEmpresa.Controls.Add(this.label12);
            this.tbCadastroEmpresa.Controls.Add(this.label10);
            this.tbCadastroEmpresa.Controls.Add(this.cbEstado);
            this.tbCadastroEmpresa.Controls.Add(this.txtCidade);
            this.tbCadastroEmpresa.Controls.Add(this.label9);
            this.tbCadastroEmpresa.Controls.Add(this.txtBairro);
            this.tbCadastroEmpresa.Controls.Add(this.label8);
            this.tbCadastroEmpresa.Controls.Add(this.txtNumero);
            this.tbCadastroEmpresa.Controls.Add(this.label7);
            this.tbCadastroEmpresa.Controls.Add(this.label6);
            this.tbCadastroEmpresa.Controls.Add(this.mbCEP);
            this.tbCadastroEmpresa.Controls.Add(this.mbIE);
            this.tbCadastroEmpresa.Controls.Add(this.mbCNPJ);
            this.tbCadastroEmpresa.Controls.Add(this.label5);
            this.tbCadastroEmpresa.Controls.Add(this.label4);
            this.tbCadastroEmpresa.Controls.Add(this.txtNomeFantasia);
            this.tbCadastroEmpresa.Controls.Add(this.label3);
            this.tbCadastroEmpresa.Controls.Add(this.txtLogradouro);
            this.tbCadastroEmpresa.Controls.Add(this.label2);
            this.tbCadastroEmpresa.Controls.Add(this.label1);
            this.tbCadastroEmpresa.Controls.Add(this.btnAtualizar);
            this.tbCadastroEmpresa.Controls.Add(this.btnPesquisar);
            this.tbCadastroEmpresa.Controls.Add(this.btnCadastrar);
            this.tbCadastroEmpresa.Controls.Add(this.btnConsultarCEP);
            this.tbCadastroEmpresa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroEmpresa.Location = new System.Drawing.Point(4, 28);
            this.tbCadastroEmpresa.Name = "tbCadastroEmpresa";
            this.tbCadastroEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroEmpresa.Size = new System.Drawing.Size(724, 557);
            this.tbCadastroEmpresa.TabIndex = 1;
            this.tbCadastroEmpresa.Text = "Cadastro Empresa - F2";
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparImagem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparImagem.Location = new System.Drawing.Point(540, 198);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(161, 39);
            this.btnLimparImagem.TabIndex = 69;
            this.btnLimparImagem.Text = "Limpar Imagem";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionarImagem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagem.Location = new System.Drawing.Point(540, 150);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(161, 39);
            this.btnAdicionarImagem.TabIndex = 68;
            this.btnAdicionarImagem.Text = "Adicionar Imagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // pbImagemLogo
            // 
            this.pbImagemLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemLogo.Location = new System.Drawing.Point(540, 14);
            this.pbImagemLogo.Name = "pbImagemLogo";
            this.pbImagemLogo.Size = new System.Drawing.Size(161, 124);
            this.pbImagemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemLogo.TabIndex = 67;
            this.pbImagemLogo.TabStop = false;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazaoSocial.Location = new System.Drawing.Point(188, 43);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(303, 26);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 66;
            this.label11.Text = "Razão Social:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.CleanMyMac_1_icon;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(547, 453);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 52);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar - F7";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(40, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(125, 26);
            this.lblCodigo.TabIndex = 63;
            // 
            // mbCelular
            // 
            this.mbCelular.Location = new System.Drawing.Point(326, 459);
            this.mbCelular.Mask = "(00) 00000-0000";
            this.mbCelular.Name = "mbCelular";
            this.mbCelular.Size = new System.Drawing.Size(122, 26);
            this.mbCelular.TabIndex = 13;
            // 
            // mbTelefone
            // 
            this.mbTelefone.Location = new System.Drawing.Point(188, 460);
            this.mbTelefone.Mask = "(00) 0000-0000";
            this.mbTelefone.Name = "mbTelefone";
            this.mbTelefone.Size = new System.Drawing.Size(122, 26);
            this.mbTelefone.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 504);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 19);
            this.label14.TabIndex = 61;
            this.label14.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(44, 526);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(447, 26);
            this.txtEmail.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 19);
            this.label13.TabIndex = 60;
            this.label13.Text = "Celular:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 59;
            this.label12.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 437);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(44, 459);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 27);
            this.cbEstado.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Location = new System.Drawing.Point(43, 388);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(447, 26);
            this.txtCidade.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Location = new System.Drawing.Point(43, 328);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(447, 26);
            this.txtBairro.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 306);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(390, 266);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "CEP:";
            // 
            // mbCEP
            // 
            this.mbCEP.Location = new System.Drawing.Point(43, 211);
            this.mbCEP.Mask = "00000-000";
            this.mbCEP.Name = "mbCEP";
            this.mbCEP.Size = new System.Drawing.Size(100, 26);
            this.mbCEP.TabIndex = 5;
            // 
            // mbIE
            // 
            this.mbIE.Location = new System.Drawing.Point(198, 148);
            this.mbIE.Name = "mbIE";
            this.mbIE.Size = new System.Drawing.Size(100, 26);
            this.mbIE.TabIndex = 4;
            // 
            // mbCNPJ
            // 
            this.mbCNPJ.Location = new System.Drawing.Point(43, 149);
            this.mbCNPJ.Mask = "00,000,000/0000-00";
            this.mbCNPJ.Name = "mbCNPJ";
            this.mbCNPJ.Size = new System.Drawing.Size(149, 26);
            this.mbCNPJ.TabIndex = 3;
            this.mbCNPJ.Leave += new System.EventHandler(this.mbCNPJ_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "IE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "CNPJ:";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFantasia.Location = new System.Drawing.Point(43, 97);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(447, 26);
            this.txtNomeFantasia.TabIndex = 1;
            this.txtNomeFantasia.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNomeFantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nome Fantasia:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogradouro.Location = new System.Drawing.Point(43, 266);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(337, 26);
            this.txtLogradouro.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Logradouro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.edit_validated_icon;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(547, 395);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(172, 52);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar - F9";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.search_icon;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(547, 333);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(172, 52);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar - F10";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Save_icon;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(547, 273);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 52);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar - F11";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultarCEP
            // 
            this.btnConsultarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarCEP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCEP.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.correio1;
            this.btnConsultarCEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCEP.Location = new System.Drawing.Point(149, 207);
            this.btnConsultarCEP.Name = "btnConsultarCEP";
            this.btnConsultarCEP.Size = new System.Drawing.Size(203, 33);
            this.btnConsultarCEP.TabIndex = 6;
            this.btnConsultarCEP.Text = "Consultar CEP - F6";
            this.btnConsultarCEP.UseVisualStyleBackColor = true;
            this.btnConsultarCEP.Click += new System.EventHandler(this.btnConsultarCEP_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 586);
            this.Controls.Add(this.tbCadastro);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEmpresa_KeyDown);
            this.tbCadastro.ResumeLayout(false);
            this.tbLocalizarEmpresa.ResumeLayout(false);
            this.tbLocalizarEmpresa.PerformLayout();
            this.gbLocalizarEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCadastroEmpresa.ResumeLayout(false);
            this.tbCadastroEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tbLocalizarEmpresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TabPage tbCadastroEmpresa;
        private System.Windows.Forms.MaskedTextBox mbCelular;
        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultarCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mbCEP;
        private System.Windows.Forms.MaskedTextBox mbIE;
        private System.Windows.Forms.MaskedTextBox mbCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnNovoCadastro;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label btnExibirTodos;
        private System.Windows.Forms.Label btnExibirCadastro;
        private System.Windows.Forms.GroupBox gbLocalizarEmpresa;
        private System.Windows.Forms.DataGridView dgvDadosEmpresa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.PictureBox pbImagemLogo;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogoEmpresa;
    }
}