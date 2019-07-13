namespace GerarOrcamento_JSPlanejar
{
    partial class FrmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tbLocalizarUsuario = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbLocalizarUsuario = new System.Windows.Forms.GroupBox();
            this.dgvDadosUsuario = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDicaSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerguntaSeguranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRespostaSeguranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibirTodos = new System.Windows.Forms.Label();
            this.btnExibirCadastro = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tbCadastroUsuario = new System.Windows.Forms.TabPage();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtRespostaSeguranca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPerguntaSeguranca = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDicaSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tbCadastro.SuspendLayout();
            this.tbLocalizarUsuario.SuspendLayout();
            this.gbLocalizarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbCadastroUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tbLocalizarUsuario);
            this.tbCadastro.Controls.Add(this.tbCadastroUsuario);
            this.tbCadastro.Location = new System.Drawing.Point(1, -4);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(732, 589);
            this.tbCadastro.TabIndex = 122131;
            // 
            // tbLocalizarUsuario
            // 
            this.tbLocalizarUsuario.BackColor = System.Drawing.Color.White;
            this.tbLocalizarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalizarUsuario.Controls.Add(this.lblStatus);
            this.tbLocalizarUsuario.Controls.Add(this.gbLocalizarUsuario);
            this.tbLocalizarUsuario.Controls.Add(this.btnExibirTodos);
            this.tbLocalizarUsuario.Controls.Add(this.btnExibirCadastro);
            this.tbLocalizarUsuario.Controls.Add(this.btnNovoCadastro);
            this.tbLocalizarUsuario.Controls.Add(this.groupBox1);
            this.tbLocalizarUsuario.Location = new System.Drawing.Point(4, 28);
            this.tbLocalizarUsuario.Name = "tbLocalizarUsuario";
            this.tbLocalizarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocalizarUsuario.Size = new System.Drawing.Size(724, 557);
            this.tbLocalizarUsuario.TabIndex = 0;
            this.tbLocalizarUsuario.Text = "Localizar Usuário - F1";
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
            // gbLocalizarUsuario
            // 
            this.gbLocalizarUsuario.Controls.Add(this.dgvDadosUsuario);
            this.gbLocalizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbLocalizarUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocalizarUsuario.Location = new System.Drawing.Point(2, 100);
            this.gbLocalizarUsuario.Name = "gbLocalizarUsuario";
            this.gbLocalizarUsuario.Size = new System.Drawing.Size(562, 446);
            this.gbLocalizarUsuario.TabIndex = 1237;
            this.gbLocalizarUsuario.TabStop = false;
            this.gbLocalizarUsuario.Text = "Localizar Usuario";
            // 
            // dgvDadosUsuario
            // 
            this.dgvDadosUsuario.AllowUserToAddRows = false;
            this.dgvDadosUsuario.AllowUserToDeleteRows = false;
            this.dgvDadosUsuario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDadosUsuario.ColumnHeadersHeight = 32;
            this.dgvDadosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDadosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColUsuario,
            this.ColSenha,
            this.ColDicaSenha,
            this.ColPerguntaSeguranca,
            this.ColRespostaSeguranca});
            this.dgvDadosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosUsuario.Location = new System.Drawing.Point(3, 22);
            this.dgvDadosUsuario.MultiSelect = false;
            this.dgvDadosUsuario.Name = "dgvDadosUsuario";
            this.dgvDadosUsuario.ReadOnly = true;
            this.dgvDadosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosUsuario.Size = new System.Drawing.Size(556, 421);
            this.dgvDadosUsuario.TabIndex = 12;
            this.dgvDadosUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosUsuario_CellDoubleClick);
            this.dgvDadosUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDadosUsuario_CellFormatting);
            this.dgvDadosUsuario.SelectionChanged += new System.EventHandler(this.dgvDadosUsuario_SelectionChanged);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodigo.DataPropertyName = "Cod_Usuario";
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 81;
            // 
            // ColUsuario
            // 
            this.ColUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColUsuario.DataPropertyName = "Usuario_Login";
            this.ColUsuario.HeaderText = "Usuário";
            this.ColUsuario.Name = "ColUsuario";
            this.ColUsuario.ReadOnly = true;
            this.ColUsuario.Width = 86;
            // 
            // ColSenha
            // 
            this.ColSenha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSenha.DataPropertyName = "Senha_Login";
            this.ColSenha.HeaderText = "Senha";
            this.ColSenha.Name = "ColSenha";
            this.ColSenha.ReadOnly = true;
            this.ColSenha.Width = 75;
            // 
            // ColDicaSenha
            // 
            this.ColDicaSenha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDicaSenha.DataPropertyName = "DicaSenha_Login";
            this.ColDicaSenha.HeaderText = "Dica Senha";
            this.ColDicaSenha.Name = "ColDicaSenha";
            this.ColDicaSenha.ReadOnly = true;
            this.ColDicaSenha.Width = 110;
            // 
            // ColPerguntaSeguranca
            // 
            this.ColPerguntaSeguranca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPerguntaSeguranca.DataPropertyName = "PerguntaSeguranca";
            this.ColPerguntaSeguranca.HeaderText = "Pergunta Segurança";
            this.ColPerguntaSeguranca.Name = "ColPerguntaSeguranca";
            this.ColPerguntaSeguranca.ReadOnly = true;
            this.ColPerguntaSeguranca.Width = 168;
            // 
            // ColRespostaSeguranca
            // 
            this.ColRespostaSeguranca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColRespostaSeguranca.DataPropertyName = "RespostaSeguranca";
            this.ColRespostaSeguranca.HeaderText = "Resposta Segurança";
            this.ColRespostaSeguranca.Name = "ColRespostaSeguranca";
            this.ColRespostaSeguranca.ReadOnly = true;
            this.ColRespostaSeguranca.Width = 171;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Users_icon;
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
            this.btnExibirCadastro.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Users_icon;
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
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbBuscarPor);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 88);
            this.groupBox1.TabIndex = 1234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Usuario";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(138, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 19);
            this.lblTitulo.TabIndex = 39;
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
            "Código",
            "Usuário"});
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
            // tbCadastroUsuario
            // 
            this.tbCadastroUsuario.BackColor = System.Drawing.Color.White;
            this.tbCadastroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbCadastroUsuario.Controls.Add(this.lblCodigo);
            this.tbCadastroUsuario.Controls.Add(this.txtRespostaSeguranca);
            this.tbCadastroUsuario.Controls.Add(this.label11);
            this.tbCadastroUsuario.Controls.Add(this.cbPerguntaSeguranca);
            this.tbCadastroUsuario.Controls.Add(this.label10);
            this.tbCadastroUsuario.Controls.Add(this.txtDicaSenha);
            this.tbCadastroUsuario.Controls.Add(this.label8);
            this.tbCadastroUsuario.Controls.Add(this.txtSenha);
            this.tbCadastroUsuario.Controls.Add(this.label54);
            this.tbCadastroUsuario.Controls.Add(this.txtUsuario);
            this.tbCadastroUsuario.Controls.Add(this.label53);
            this.tbCadastroUsuario.Controls.Add(this.label16);
            this.tbCadastroUsuario.Controls.Add(this.btnLimpar);
            this.tbCadastroUsuario.Controls.Add(this.btnExcluir);
            this.tbCadastroUsuario.Controls.Add(this.btnAtualizar);
            this.tbCadastroUsuario.Controls.Add(this.btnPesquisar);
            this.tbCadastroUsuario.Controls.Add(this.btnCadastrar);
            this.tbCadastroUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroUsuario.Location = new System.Drawing.Point(4, 28);
            this.tbCadastroUsuario.Name = "tbCadastroUsuario";
            this.tbCadastroUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroUsuario.Size = new System.Drawing.Size(724, 557);
            this.tbCadastroUsuario.TabIndex = 1;
            this.tbCadastroUsuario.Text = "Cadastro Usuário - F2";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(89, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(109, 26);
            this.lblCodigo.TabIndex = 163;
            // 
            // txtRespostaSeguranca
            // 
            this.txtRespostaSeguranca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespostaSeguranca.ForeColor = System.Drawing.Color.Black;
            this.txtRespostaSeguranca.Location = new System.Drawing.Point(98, 215);
            this.txtRespostaSeguranca.MaxLength = 3000;
            this.txtRespostaSeguranca.Name = "txtRespostaSeguranca";
            this.txtRespostaSeguranca.Size = new System.Drawing.Size(176, 26);
            this.txtRespostaSeguranca.TabIndex = 5;
            this.txtRespostaSeguranca.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 162;
            this.label11.Text = "Resposta:";
            // 
            // cbPerguntaSeguranca
            // 
            this.cbPerguntaSeguranca.FormattingEnabled = true;
            this.cbPerguntaSeguranca.Items.AddRange(new object[] {
            "Qual é o nome do seu primeiro animal de estimação?",
            "Quem é o(a) seu(sua) melhor amigo(a)?",
            "Qual é a sua matéria escolar preferida?",
            "Qual é a sua comida Predileta?"});
            this.cbPerguntaSeguranca.Location = new System.Drawing.Point(337, 167);
            this.cbPerguntaSeguranca.Name = "cbPerguntaSeguranca";
            this.cbPerguntaSeguranca.Size = new System.Drawing.Size(357, 27);
            this.cbPerguntaSeguranca.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 19);
            this.label10.TabIndex = 160;
            this.label10.Text = "Selecione ou faça a sua pergunta de segurança:";
            // 
            // txtDicaSenha
            // 
            this.txtDicaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDicaSenha.ForeColor = System.Drawing.Color.Black;
            this.txtDicaSenha.Location = new System.Drawing.Point(204, 112);
            this.txtDicaSenha.MaxLength = 30;
            this.txtDicaSenha.Name = "txtDicaSenha";
            this.txtDicaSenha.Size = new System.Drawing.Size(176, 26);
            this.txtDicaSenha.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 158;
            this.label8.Text = "Digite uma dica de senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(337, 63);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 26);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Black;
            this.label54.Location = new System.Drawing.Point(276, 65);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 19);
            this.label54.TabIndex = 157;
            this.label54.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(89, 63);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(17, 65);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(66, 19);
            this.label53.TabIndex = 156;
            this.label53.Text = "Usuario:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(22, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 19);
            this.label16.TabIndex = 155;
            this.label16.Text = "Código:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.CleanMyMac_1_icon;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(171, 372);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 52);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar - F7";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Actions_edit_delete_icon;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(374, 372);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(172, 52);
            this.btnExcluir.TabIndex = 9;
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
            this.btnAtualizar.Location = new System.Drawing.Point(436, 276);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(172, 52);
            this.btnAtualizar.TabIndex = 8;
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
            this.btnPesquisar.Location = new System.Drawing.Point(258, 276);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(172, 52);
            this.btnPesquisar.TabIndex = 7;
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
            this.btnCadastrar.Location = new System.Drawing.Point(80, 276);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 52);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar - F11";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmUsuario
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
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuario_KeyDown);
            this.tbCadastro.ResumeLayout(false);
            this.tbLocalizarUsuario.ResumeLayout(false);
            this.tbLocalizarUsuario.PerformLayout();
            this.gbLocalizarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCadastroUsuario.ResumeLayout(false);
            this.tbCadastroUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tbLocalizarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TabPage tbCadastroUsuario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label btnNovoCadastro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label btnExibirTodos;
        private System.Windows.Forms.Label btnExibirCadastro;
        private System.Windows.Forms.GroupBox gbLocalizarUsuario;
        private System.Windows.Forms.DataGridView dgvDadosUsuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtRespostaSeguranca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPerguntaSeguranca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDicaSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDicaSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerguntaSeguranca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRespostaSeguranca;
    }
}