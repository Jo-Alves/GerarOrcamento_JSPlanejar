namespace GerarOrcamento_JSPlanejar
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPecas = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGerarOrçamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContasClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContasAReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.diversosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblContaCliente = new System.Windows.Forms.Label();
            this.lblAtualizarPecas = new System.Windows.Forms.Label();
            this.lblGerarOrcamento = new System.Windows.Forms.Label();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.lblRodape = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.diversosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.MenuPecas,
            this.empresaToolStripMenuItem,
            this.MenuUsuario});
            this.cadastroToolStripMenuItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.cadastro;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // MenuCliente
            // 
            this.MenuCliente.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Client_icon1;
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuCliente.Size = new System.Drawing.Size(181, 24);
            this.MenuCliente.Text = "Cliente";
            this.MenuCliente.Click += new System.EventHandler(this.MenuCliente_Click);
            // 
            // MenuPecas
            // 
            this.MenuPecas.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.pecas_g;
            this.MenuPecas.Name = "MenuPecas";
            this.MenuPecas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MenuPecas.Size = new System.Drawing.Size(181, 24);
            this.MenuPecas.Text = "Peças";
            this.MenuPecas.Click += new System.EventHandler(this.MenuPecas_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.company_building_icon__128px_;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.MenuEmpresa_Click);
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Users_icon;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.MenuUsuario.Size = new System.Drawing.Size(181, 24);
            this.MenuUsuario.Text = "Usuário";
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGerarOrçamento,
            this.MenuContasClientes,
            this.MenuContasAReceber});
            this.movimentoToolStripMenuItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.download;
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // MenuGerarOrçamento
            // 
            this.MenuGerarOrçamento.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.budget_icon64X64;
            this.MenuGerarOrçamento.Name = "MenuGerarOrçamento";
            this.MenuGerarOrçamento.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuGerarOrçamento.Size = new System.Drawing.Size(270, 24);
            this.MenuGerarOrçamento.Text = "Gerar Orçamento";
            this.MenuGerarOrçamento.Click += new System.EventHandler(this.MenuGerarOrçamento_Click);
            // 
            // MenuContasClientes
            // 
            this.MenuContasClientes.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Invoice_icon;
            this.MenuContasClientes.Name = "MenuContasClientes";
            this.MenuContasClientes.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.G)));
            this.MenuContasClientes.Size = new System.Drawing.Size(270, 24);
            this.MenuContasClientes.Text = "Contas Clientes";
            this.MenuContasClientes.Click += new System.EventHandler(this.MenuContasClientes_Click);
            // 
            // MenuContasAReceber
            // 
            this.MenuContasAReceber.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Invoice_icon;
            this.MenuContasAReceber.Name = "MenuContasAReceber";
            this.MenuContasAReceber.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.MenuContasAReceber.Size = new System.Drawing.Size(270, 24);
            this.MenuContasAReceber.Text = "Contas a receber";
            this.MenuContasAReceber.Click += new System.EventHandler(this.MenuContasAReceber_Click);
            // 
            // diversosToolStripMenuItem
            // 
            this.diversosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCalculadora});
            this.diversosToolStripMenuItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.accessories_calculator_icon;
            this.diversosToolStripMenuItem.Name = "diversosToolStripMenuItem";
            this.diversosToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.diversosToolStripMenuItem.Text = "Diversos";
            // 
            // MenuCalculadora
            // 
            this.MenuCalculadora.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Apps_Calculator_Metro_icon;
            this.MenuCalculadora.Name = "MenuCalculadora";
            this.MenuCalculadora.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.MenuCalculadora.Size = new System.Drawing.Size(203, 24);
            this.MenuCalculadora.Text = "Calculadora";
            this.MenuCalculadora.Click += new System.EventHandler(this.MenuCalculadora_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSobre});
            this.sobreToolStripMenuItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_Help_icon;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // MenuSobre
            // 
            this.MenuSobre.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.About_icon;
            this.MenuSobre.Name = "MenuSobre";
            this.MenuSobre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSobre.Size = new System.Drawing.Size(165, 24);
            this.MenuSobre.Text = "Sobre";
            this.MenuSobre.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Windows_Close_Program_icon;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(61, 23);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // lblContaCliente
            // 
            this.lblContaCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContaCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaCliente.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Invoice_icon;
            this.lblContaCliente.Location = new System.Drawing.Point(632, 27);
            this.lblContaCliente.Name = "lblContaCliente";
            this.lblContaCliente.Size = new System.Drawing.Size(141, 86);
            this.lblContaCliente.TabIndex = 13;
            this.lblContaCliente.Text = "Contas cliente";
            this.lblContaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblContaCliente.Click += new System.EventHandler(this.lbConfirmarPagamento_Click);
            this.lblContaCliente.MouseEnter += new System.EventHandler(this.lblContaCliente_MouseEnter);
            this.lblContaCliente.MouseLeave += new System.EventHandler(this.lblContaCliente_MouseLeave);
            // 
            // lblAtualizarPecas
            // 
            this.lblAtualizarPecas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAtualizarPecas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtualizarPecas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblAtualizarPecas.Image = ((System.Drawing.Image)(resources.GetObject("lblAtualizarPecas.Image")));
            this.lblAtualizarPecas.Location = new System.Drawing.Point(485, 27);
            this.lblAtualizarPecas.Name = "lblAtualizarPecas";
            this.lblAtualizarPecas.Size = new System.Drawing.Size(141, 86);
            this.lblAtualizarPecas.TabIndex = 4;
            this.lblAtualizarPecas.Text = "Peças";
            this.lblAtualizarPecas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblAtualizarPecas.Click += new System.EventHandler(this.lblAtualizarPecas_Click);
            this.lblAtualizarPecas.MouseEnter += new System.EventHandler(this.lblAtualizarPecas_MouseEnter);
            this.lblAtualizarPecas.MouseLeave += new System.EventHandler(this.lblAtualizarPecas_MouseLeave);
            // 
            // lblGerarOrcamento
            // 
            this.lblGerarOrcamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGerarOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGerarOrcamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblGerarOrcamento.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.budget_icon64X64;
            this.lblGerarOrcamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGerarOrcamento.Location = new System.Drawing.Point(329, 27);
            this.lblGerarOrcamento.Name = "lblGerarOrcamento";
            this.lblGerarOrcamento.Size = new System.Drawing.Size(141, 86);
            this.lblGerarOrcamento.TabIndex = 3;
            this.lblGerarOrcamento.Text = "Gerar Orçamento";
            this.lblGerarOrcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGerarOrcamento.Click += new System.EventHandler(this.lblGerarOrcamento_Click);
            this.lblGerarOrcamento.MouseEnter += new System.EventHandler(this.lblGerarOrcamento_MouseEnter);
            this.lblGerarOrcamento.MouseLeave += new System.EventHandler(this.lblGerarOrcamento_MouseLeave);
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCadastroCliente.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Clients_icon64X64;
            this.lblCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCadastroCliente.Location = new System.Drawing.Point(171, 27);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(141, 86);
            this.lblCadastroCliente.TabIndex = 2;
            this.lblCadastroCliente.Text = "Cliente";
            this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCadastroCliente.Click += new System.EventHandler(this.lblCadastroCliente_Click);
            this.lblCadastroCliente.MouseEnter += new System.EventHandler(this.lblCadastroCliente_MouseEnter);
            this.lblCadastroCliente.MouseLeave += new System.EventHandler(this.lblCadastroCliente_MouseLeave);
            // 
            // pbLogoEmpresa
            // 
            this.pbLogoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogoEmpresa.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.JS_Planejar;
            this.pbLogoEmpresa.Location = new System.Drawing.Point(109, 135);
            this.pbLogoEmpresa.Name = "pbLogoEmpresa";
            this.pbLogoEmpresa.Size = new System.Drawing.Size(751, 295);
            this.pbLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoEmpresa.TabIndex = 1;
            this.pbLogoEmpresa.TabStop = false;
            // 
            // lblRodape
            // 
            this.lblRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRodape.Location = new System.Drawing.Point(13, 448);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(973, 25);
            this.lblRodape.TabIndex = 14;
            this.lblRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 473);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.lblContaCliente);
            this.Controls.Add(this.lblAtualizarPecas);
            this.Controls.Add(this.lblGerarOrcamento);
            this.Controls.Add(this.lblCadastroCliente);
            this.Controls.Add(this.pbLogoEmpresa);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerar Orçamento - JS Planejar (lasTechnology2018@gmail.com)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTelaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmTelaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTelaPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuPecas;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuGerarOrçamento;
        private System.Windows.Forms.ToolStripMenuItem MenuContasClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuContasAReceber;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox pbLogoEmpresa;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSobre;
        private System.Windows.Forms.ToolStripMenuItem diversosToolStripMenuItem;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.Label lblGerarOrcamento;
        private System.Windows.Forms.Label lblAtualizarPecas;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCalculadora;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.Label lblContaCliente;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Timer timer;
    }
}

