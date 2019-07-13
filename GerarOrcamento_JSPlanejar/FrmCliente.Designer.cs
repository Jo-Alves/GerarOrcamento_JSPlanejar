namespace GerarOrcamento_JSPlanejar
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tbLocalizarCliente = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbLocalizarCliente = new System.Windows.Forms.GroupBox();
            this.dgvDadosCliente = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibirTodos = new System.Windows.Forms.Label();
            this.btnExibirCadastro = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldados = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tbCadastroCliente = new System.Windows.Forms.TabPage();
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
            this.mbRG = new System.Windows.Forms.MaskedTextBox();
            this.mbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultarCEP = new System.Windows.Forms.Button();
            this.tbCadastro.SuspendLayout();
            this.tbLocalizarCliente.SuspendLayout();
            this.gbLocalizarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tbLocalizarCliente);
            this.tbCadastro.Controls.Add(this.tbCadastroCliente);
            this.tbCadastro.Location = new System.Drawing.Point(1, -4);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(732, 589);
            this.tbCadastro.TabIndex = 122131;
            // 
            // tbLocalizarCliente
            // 
            this.tbLocalizarCliente.BackColor = System.Drawing.Color.White;
            this.tbLocalizarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalizarCliente.Controls.Add(this.lblStatus);
            this.tbLocalizarCliente.Controls.Add(this.gbLocalizarCliente);
            this.tbLocalizarCliente.Controls.Add(this.btnExibirTodos);
            this.tbLocalizarCliente.Controls.Add(this.btnExibirCadastro);
            this.tbLocalizarCliente.Controls.Add(this.btnNovoCadastro);
            this.tbLocalizarCliente.Controls.Add(this.groupBox1);
            this.tbLocalizarCliente.Location = new System.Drawing.Point(4, 28);
            this.tbLocalizarCliente.Name = "tbLocalizarCliente";
            this.tbLocalizarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocalizarCliente.Size = new System.Drawing.Size(724, 557);
            this.tbLocalizarCliente.TabIndex = 0;
            this.tbLocalizarCliente.Text = "Localizar Cliente - F1";
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
            // gbLocalizarCliente
            // 
            this.gbLocalizarCliente.Controls.Add(this.dgvDadosCliente);
            this.gbLocalizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbLocalizarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocalizarCliente.Location = new System.Drawing.Point(2, 100);
            this.gbLocalizarCliente.Name = "gbLocalizarCliente";
            this.gbLocalizarCliente.Size = new System.Drawing.Size(562, 446);
            this.gbLocalizarCliente.TabIndex = 1237;
            this.gbLocalizarCliente.TabStop = false;
            this.gbLocalizarCliente.Text = "Localizar Cliente";
            // 
            // dgvDadosCliente
            // 
            this.dgvDadosCliente.AllowUserToAddRows = false;
            this.dgvDadosCliente.AllowUserToDeleteRows = false;
            this.dgvDadosCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNome,
            this.ColCPF,
            this.ColRG,
            this.ColCep,
            this.ColLogradouro,
            this.ColNumero,
            this.ColBairro,
            this.ColCidade,
            this.ColEstado,
            this.ColTelefone,
            this.ColCelular,
            this.ColEmail});
            this.dgvDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosCliente.Location = new System.Drawing.Point(3, 22);
            this.dgvDadosCliente.MultiSelect = false;
            this.dgvDadosCliente.Name = "dgvDadosCliente";
            this.dgvDadosCliente.ReadOnly = true;
            this.dgvDadosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosCliente.Size = new System.Drawing.Size(556, 421);
            this.dgvDadosCliente.TabIndex = 12;
            this.dgvDadosCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosCliente_CellDoubleClick);
            this.dgvDadosCliente.SelectionChanged += new System.EventHandler(this.dgvDadosCliente_SelectionChanged);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodigo.DataPropertyName = "Cod_Cliente";
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 81;
            // 
            // ColNome
            // 
            this.ColNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNome.DataPropertyName = "Nome_Cliente";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 74;
            // 
            // ColCPF
            // 
            this.ColCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCPF.DataPropertyName = "CPF_Cliente";
            this.ColCPF.HeaderText = "CPF";
            this.ColCPF.Name = "ColCPF";
            this.ColCPF.ReadOnly = true;
            this.ColCPF.Width = 63;
            // 
            // ColRG
            // 
            this.ColRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRG.DataPropertyName = "RG_Cliente";
            this.ColRG.HeaderText = "RG";
            this.ColRG.Name = "ColRG";
            this.ColRG.ReadOnly = true;
            this.ColRG.Width = 58;
            // 
            // ColCep
            // 
            this.ColCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCep.DataPropertyName = "CEP_Cliente";
            this.ColCep.HeaderText = "CEP";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            this.ColCep.Width = 64;
            // 
            // ColLogradouro
            // 
            this.ColLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLogradouro.DataPropertyName = "Logradouro_Cliente";
            this.ColLogradouro.HeaderText = "Logradouro";
            this.ColLogradouro.Name = "ColLogradouro";
            this.ColLogradouro.ReadOnly = true;
            this.ColLogradouro.Width = 112;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumero.DataPropertyName = "Numero_Cliente";
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 88;
            // 
            // ColBairro
            // 
            this.ColBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBairro.DataPropertyName = "Bairro_Cliente";
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Width = 77;
            // 
            // ColCidade
            // 
            this.ColCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCidade.DataPropertyName = "Cidade_Cliente";
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            this.ColCidade.Width = 81;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEstado.DataPropertyName = "Estado_Cliente";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 80;
            // 
            // ColTelefone
            // 
            this.ColTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTelefone.DataPropertyName = "Telefone_Cliente";
            this.ColTelefone.HeaderText = "Telefone";
            this.ColTelefone.Name = "ColTelefone";
            this.ColTelefone.ReadOnly = true;
            this.ColTelefone.Width = 92;
            // 
            // ColCelular
            // 
            this.ColCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCelular.DataPropertyName = "Celular_Cliente";
            this.ColCelular.HeaderText = "Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            this.ColCelular.Width = 83;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEmail.DataPropertyName = "Email_Cliente";
            this.ColEmail.HeaderText = "E-mail";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 77;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Client_icon;
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
            this.btnExibirCadastro.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Client_icon;
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
            this.groupBox1.Controls.Add(this.lbldados);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbBuscarPor);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 88);
            this.groupBox1.TabIndex = 1234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Cliente";
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldados.Location = new System.Drawing.Point(138, 22);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(54, 19);
            this.lbldados.TabIndex = 39;
            this.lbldados.Text = "Nome:";
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
            "Nome",
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
            // tbCadastroCliente
            // 
            this.tbCadastroCliente.BackColor = System.Drawing.Color.White;
            this.tbCadastroCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbCadastroCliente.Controls.Add(this.btnLimpar);
            this.tbCadastroCliente.Controls.Add(this.lblCodigo);
            this.tbCadastroCliente.Controls.Add(this.mbCelular);
            this.tbCadastroCliente.Controls.Add(this.mbTelefone);
            this.tbCadastroCliente.Controls.Add(this.label14);
            this.tbCadastroCliente.Controls.Add(this.txtEmail);
            this.tbCadastroCliente.Controls.Add(this.label13);
            this.tbCadastroCliente.Controls.Add(this.label12);
            this.tbCadastroCliente.Controls.Add(this.label10);
            this.tbCadastroCliente.Controls.Add(this.cbEstado);
            this.tbCadastroCliente.Controls.Add(this.txtCidade);
            this.tbCadastroCliente.Controls.Add(this.label9);
            this.tbCadastroCliente.Controls.Add(this.txtBairro);
            this.tbCadastroCliente.Controls.Add(this.label8);
            this.tbCadastroCliente.Controls.Add(this.txtNumero);
            this.tbCadastroCliente.Controls.Add(this.label7);
            this.tbCadastroCliente.Controls.Add(this.label6);
            this.tbCadastroCliente.Controls.Add(this.mbCEP);
            this.tbCadastroCliente.Controls.Add(this.mbRG);
            this.tbCadastroCliente.Controls.Add(this.mbCPF);
            this.tbCadastroCliente.Controls.Add(this.label5);
            this.tbCadastroCliente.Controls.Add(this.label4);
            this.tbCadastroCliente.Controls.Add(this.txtNome);
            this.tbCadastroCliente.Controls.Add(this.label3);
            this.tbCadastroCliente.Controls.Add(this.txtLogradouro);
            this.tbCadastroCliente.Controls.Add(this.label2);
            this.tbCadastroCliente.Controls.Add(this.label1);
            this.tbCadastroCliente.Controls.Add(this.btnExcluir);
            this.tbCadastroCliente.Controls.Add(this.btnAtualizar);
            this.tbCadastroCliente.Controls.Add(this.btnPesquisar);
            this.tbCadastroCliente.Controls.Add(this.btnCadastrar);
            this.tbCadastroCliente.Controls.Add(this.btnConsultarCEP);
            this.tbCadastroCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroCliente.Location = new System.Drawing.Point(4, 28);
            this.tbCadastroCliente.Name = "tbCadastroCliente";
            this.tbCadastroCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroCliente.Size = new System.Drawing.Size(724, 557);
            this.tbCadastroCliente.TabIndex = 1;
            this.tbCadastroCliente.Text = "Cadastro Cliente - F2";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.CleanMyMac_1_icon;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(540, 400);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 52);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "Limpar - F7";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(40, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(173, 26);
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
            this.txtEmail.TabIndex = 53;
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
            // mbRG
            // 
            this.mbRG.Location = new System.Drawing.Point(198, 148);
            this.mbRG.Mask = "00,000,000";
            this.mbRG.Name = "mbRG";
            this.mbRG.Size = new System.Drawing.Size(100, 26);
            this.mbRG.TabIndex = 4;
            // 
            // mbCPF
            // 
            this.mbCPF.Location = new System.Drawing.Point(43, 149);
            this.mbCPF.Mask = "000,000,000-00";
            this.mbCPF.Name = "mbCPF";
            this.mbCPF.Size = new System.Drawing.Size(122, 26);
            this.mbCPF.TabIndex = 3;
            this.mbCPF.Leave += new System.EventHandler(this.mbCPF_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(43, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(447, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nome:";
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
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Actions_edit_delete_icon;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(540, 339);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(172, 52);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir - F8";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.edit_validated_icon;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(540, 278);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(172, 52);
            this.btnAtualizar.TabIndex = 16;
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
            this.btnPesquisar.Location = new System.Drawing.Point(540, 216);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(172, 52);
            this.btnPesquisar.TabIndex = 15;
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
            this.btnCadastrar.Location = new System.Drawing.Point(540, 156);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 52);
            this.btnCadastrar.TabIndex = 14;
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
            // FrmCliente
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
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            this.tbCadastro.ResumeLayout(false);
            this.tbLocalizarCliente.ResumeLayout(false);
            this.tbLocalizarCliente.PerformLayout();
            this.gbLocalizarCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCadastroCliente.ResumeLayout(false);
            this.tbCadastroCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tbLocalizarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TabPage tbCadastroCliente;
        private System.Windows.Forms.MaskedTextBox mbCelular;
        private System.Windows.Forms.MaskedTextBox mbTelefone;
        private System.Windows.Forms.Button btnExcluir;
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
        private System.Windows.Forms.MaskedTextBox mbRG;
        private System.Windows.Forms.MaskedTextBox mbCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnNovoCadastro;
        private System.Windows.Forms.Label lbldados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label btnExibirTodos;
        private System.Windows.Forms.Label btnExibirCadastro;
        private System.Windows.Forms.GroupBox gbLocalizarCliente;
        private System.Windows.Forms.DataGridView dgvDadosCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.Button btnLimpar;
    }
}