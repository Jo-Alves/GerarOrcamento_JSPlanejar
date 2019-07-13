namespace GerarOrcamento_JSPlanejar
{
    partial class FrmPeças
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeças));
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tbLocalizaPecas = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbLocalizarPeça = new System.Windows.Forms.GroupBox();
            this.dgvDadosPeça = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExibirTodos = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tbCadastroPecas = new System.Windows.Forms.TabPage();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tbCadastro.SuspendLayout();
            this.tbLocalizaPecas.SuspendLayout();
            this.gbLocalizarPeça.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPeça)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbCadastroPecas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tbLocalizaPecas);
            this.tbCadastro.Controls.Add(this.tbCadastroPecas);
            this.tbCadastro.Location = new System.Drawing.Point(1, -4);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(732, 589);
            this.tbCadastro.TabIndex = 122131;
            // 
            // tbLocalizaPecas
            // 
            this.tbLocalizaPecas.BackColor = System.Drawing.Color.White;
            this.tbLocalizaPecas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocalizaPecas.Controls.Add(this.lblStatus);
            this.tbLocalizaPecas.Controls.Add(this.gbLocalizarPeça);
            this.tbLocalizaPecas.Controls.Add(this.btnExibirTodos);
            this.tbLocalizaPecas.Controls.Add(this.btnNovoCadastro);
            this.tbLocalizaPecas.Controls.Add(this.groupBox1);
            this.tbLocalizaPecas.Location = new System.Drawing.Point(4, 28);
            this.tbLocalizaPecas.Name = "tbLocalizaPecas";
            this.tbLocalizaPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocalizaPecas.Size = new System.Drawing.Size(724, 557);
            this.tbLocalizaPecas.TabIndex = 0;
            this.tbLocalizaPecas.Text = "Localizar Peças - F1";
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
            // gbLocalizarPeça
            // 
            this.gbLocalizarPeça.Controls.Add(this.dgvDadosPeça);
            this.gbLocalizarPeça.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbLocalizarPeça.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocalizarPeça.Location = new System.Drawing.Point(2, 100);
            this.gbLocalizarPeça.Name = "gbLocalizarPeça";
            this.gbLocalizarPeça.Size = new System.Drawing.Size(562, 249);
            this.gbLocalizarPeça.TabIndex = 1237;
            this.gbLocalizarPeça.TabStop = false;
            this.gbLocalizarPeça.Text = "Localizar Peça";
            // 
            // dgvDadosPeça
            // 
            this.dgvDadosPeça.AllowUserToAddRows = false;
            this.dgvDadosPeça.AllowUserToDeleteRows = false;
            this.dgvDadosPeça.BackgroundColor = System.Drawing.Color.White;
            this.dgvDadosPeça.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosPeça.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescricao,
            this.ColValor,
            this.ColComprimento,
            this.ColUnidade});
            this.dgvDadosPeça.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosPeça.Location = new System.Drawing.Point(3, 22);
            this.dgvDadosPeça.MultiSelect = false;
            this.dgvDadosPeça.Name = "dgvDadosPeça";
            this.dgvDadosPeça.ReadOnly = true;
            this.dgvDadosPeça.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosPeça.Size = new System.Drawing.Size(556, 224);
            this.dgvDadosPeça.TabIndex = 12;
            this.dgvDadosPeça.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosCliente_CellDoubleClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodigo.DataPropertyName = "Cod_Peça";
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 81;
            // 
            // ColDescricao
            // 
            this.ColDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDescricao.DataPropertyName = "Descricao_Peça";
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            this.ColDescricao.Width = 101;
            // 
            // ColValor
            // 
            this.ColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValor.DataPropertyName = "Valor_Peça";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 70;
            // 
            // ColComprimento
            // 
            this.ColComprimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColComprimento.DataPropertyName = "Comprimento_Peça";
            this.ColComprimento.HeaderText = "Comprimento";
            this.ColComprimento.Name = "ColComprimento";
            this.ColComprimento.ReadOnly = true;
            this.ColComprimento.Width = 124;
            // 
            // ColUnidade
            // 
            this.ColUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColUnidade.DataPropertyName = "Unidade_Peça";
            this.ColUnidade.HeaderText = "Unidade";
            this.ColUnidade.Name = "ColUnidade";
            this.ColUnidade.ReadOnly = true;
            this.ColUnidade.Width = 89;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Programming_Show_Property_icon;
            this.btnExibirTodos.Location = new System.Drawing.Point(567, 179);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(149, 170);
            this.btnExibirTodos.TabIndex = 40;
            this.btnExibirTodos.Text = "Exibir Todos- F4";
            this.btnExibirTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExibirTodos.Click += new System.EventHandler(this.BtnExibirTodos_Click);
            this.btnExibirTodos.MouseEnter += new System.EventHandler(this.btnExibirCadastro_MouseEnter);
            this.btnExibirTodos.MouseLeave += new System.EventHandler(this.btnExibirCadastro_MouseLeave);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Files_New_File_icon;
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
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 88);
            this.groupBox1.TabIndex = 1234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localizar Peça";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 39;
            this.label16.Text = "Descrição:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(27, 45);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(493, 26);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // tbCadastroPecas
            // 
            this.tbCadastroPecas.BackColor = System.Drawing.Color.White;
            this.tbCadastroPecas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbCadastroPecas.Controls.Add(this.cbUnidade);
            this.tbCadastroPecas.Controls.Add(this.btnLimpar);
            this.tbCadastroPecas.Controls.Add(this.lblCodigo);
            this.tbCadastroPecas.Controls.Add(this.label8);
            this.tbCadastroPecas.Controls.Add(this.txtComprimento);
            this.tbCadastroPecas.Controls.Add(this.label7);
            this.tbCadastroPecas.Controls.Add(this.txtDescricao);
            this.tbCadastroPecas.Controls.Add(this.label3);
            this.tbCadastroPecas.Controls.Add(this.txtValor);
            this.tbCadastroPecas.Controls.Add(this.label2);
            this.tbCadastroPecas.Controls.Add(this.label1);
            this.tbCadastroPecas.Controls.Add(this.btnExcluir);
            this.tbCadastroPecas.Controls.Add(this.btnAtualizar);
            this.tbCadastroPecas.Controls.Add(this.btnPesquisar);
            this.tbCadastroPecas.Controls.Add(this.btnCadastrar);
            this.tbCadastroPecas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroPecas.Location = new System.Drawing.Point(4, 28);
            this.tbCadastroPecas.Name = "tbCadastroPecas";
            this.tbCadastroPecas.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroPecas.Size = new System.Drawing.Size(724, 557);
            this.tbCadastroPecas.TabIndex = 1;
            this.tbCadastroPecas.Text = "Cadastro Peças - F2";
            // 
            // cbUnidade
            // 
            this.cbUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "UN",
            "PC",
            "KG",
            "MT",
            "MM",
            "CM",
            "LT",
            "CX",
            "M2",
            "M3"});
            this.cbUnidade.Location = new System.Drawing.Point(272, 155);
            this.cbUnidade.MaxLength = 2;
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(77, 27);
            this.cbUnidade.TabIndex = 65;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.CleanMyMac_1_icon;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(44, 230);
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
            this.lblCodigo.Location = new System.Drawing.Point(44, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(173, 26);
            this.lblCodigo.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Unidade";
            // 
            // txtComprimento
            // 
            this.txtComprimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComprimento.Location = new System.Drawing.Point(146, 156);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(100, 26);
            this.txtComprimento.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Comprimento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(43, 97);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(447, 26);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descrição:";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(43, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(86, 26);
            this.txtValor.TabIndex = 7;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 14);
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
            this.btnExcluir.Location = new System.Drawing.Point(286, 230);
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
            this.btnAtualizar.Location = new System.Drawing.Point(540, 230);
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
            this.btnPesquisar.Location = new System.Drawing.Point(540, 116);
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
            this.btnCadastrar.Location = new System.Drawing.Point(542, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(172, 52);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar - F11";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmPeças
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 386);
            this.Controls.Add(this.tbCadastro);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPeças";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de peças";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            this.tbCadastro.ResumeLayout(false);
            this.tbLocalizaPecas.ResumeLayout(false);
            this.tbLocalizaPecas.PerformLayout();
            this.gbLocalizarPeça.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPeça)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbCadastroPecas.ResumeLayout(false);
            this.tbCadastroPecas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tbLocalizaPecas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TabPage tbCadastroPecas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnNovoCadastro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label btnExibirTodos;
        private System.Windows.Forms.GroupBox gbLocalizarPeça;
        private System.Windows.Forms.DataGridView dgvDadosPeça;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidade;
    }
}