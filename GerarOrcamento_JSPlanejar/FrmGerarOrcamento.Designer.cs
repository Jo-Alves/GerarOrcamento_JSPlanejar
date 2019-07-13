namespace GerarOrcamento_JSPlanejar
{
    partial class FrmGerarOrcamento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerarOrcamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrcamento = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbConfirmarPagamento = new System.Windows.Forms.Label();
            this.lblExcluirOrcamento = new System.Windows.Forms.Label();
            this.lblAtualizar = new System.Windows.Forms.Label();
            this.lblFinalizarEntrega = new System.Windows.Forms.Label();
            this.lblRecusar = new System.Windows.Forms.Label();
            this.lblAprovar = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.lblNovo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvOrcamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvOrcamento
            // 
            this.dgvOrcamento.AllowUserToAddRows = false;
            this.dgvOrcamento.AllowUserToDeleteRows = false;
            this.dgvOrcamento.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrcamento.ColumnHeadersHeight = 32;
            this.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDataCriacao,
            this.ColSituacao,
            this.ColValorTotal,
            this.ColValidade,
            this.ColCodCliente,
            this.ColCliente,
            this.ColProduto});
            this.dgvOrcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrcamento.Location = new System.Drawing.Point(3, 22);
            this.dgvOrcamento.Name = "dgvOrcamento";
            this.dgvOrcamento.ReadOnly = true;
            this.dgvOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrcamento.Size = new System.Drawing.Size(923, 306);
            this.dgvOrcamento.TabIndex = 0;
            this.dgvOrcamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrcamento_CellClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodigo.DataPropertyName = "Cod_Orcamento";
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 79;
            // 
            // ColDataCriacao
            // 
            this.ColDataCriacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDataCriacao.DataPropertyName = "DataPedido_Orcamento";
            this.ColDataCriacao.HeaderText = "Criado em";
            this.ColDataCriacao.Name = "ColDataCriacao";
            this.ColDataCriacao.ReadOnly = true;
            this.ColDataCriacao.Width = 98;
            // 
            // ColSituacao
            // 
            this.ColSituacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSituacao.DataPropertyName = "Situacao_Orcamento";
            this.ColSituacao.HeaderText = "Situação";
            this.ColSituacao.Name = "ColSituacao";
            this.ColSituacao.ReadOnly = true;
            this.ColSituacao.Width = 86;
            // 
            // ColValorTotal
            // 
            this.ColValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValorTotal.DataPropertyName = "ValorTotal_Orcamento";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColValorTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColValorTotal.HeaderText = "Valor Total";
            this.ColValorTotal.Name = "ColValorTotal";
            this.ColValorTotal.ReadOnly = true;
            // 
            // ColValidade
            // 
            this.ColValidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValidade.DataPropertyName = "EstimativaEntrega_Orcamento";
            this.ColValidade.HeaderText = "Estimativa de entrega";
            this.ColValidade.Name = "ColValidade";
            this.ColValidade.ReadOnly = true;
            this.ColValidade.Width = 162;
            // 
            // ColCodCliente
            // 
            this.ColCodCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCodCliente.DataPropertyName = "Cod_Cliente";
            this.ColCodCliente.HeaderText = "Cód. Cliente";
            this.ColCodCliente.Name = "ColCodCliente";
            this.ColCodCliente.ReadOnly = true;
            this.ColCodCliente.Width = 111;
            // 
            // ColCliente
            // 
            this.ColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCliente.DataPropertyName = "Nome_Cliente";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 76;
            // 
            // ColProduto
            // 
            this.ColProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColProduto.DataPropertyName = "ProdutoFinal_Orcamento";
            this.ColProduto.HeaderText = "Produto";
            this.ColProduto.Name = "ColProduto";
            this.ColProduto.ReadOnly = true;
            this.ColProduto.Width = 83;
            // 
            // lbConfirmarPagamento
            // 
            this.lbConfirmarPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfirmarPagamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarPagamento.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Invoice_icon;
            this.lbConfirmarPagamento.Location = new System.Drawing.Point(739, 14);
            this.lbConfirmarPagamento.Name = "lbConfirmarPagamento";
            this.lbConfirmarPagamento.Size = new System.Drawing.Size(97, 81);
            this.lbConfirmarPagamento.TabIndex = 12;
            this.lbConfirmarPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lbConfirmarPagamento, "Realizar pagamento");
            this.lbConfirmarPagamento.Click += new System.EventHandler(this.lbConfirmarPagamento_Click);
            // 
            // lblExcluirOrcamento
            // 
            this.lblExcluirOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExcluirOrcamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluirOrcamento.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_Delete_icon1;
            this.lblExcluirOrcamento.Location = new System.Drawing.Point(224, 14);
            this.lblExcluirOrcamento.Name = "lblExcluirOrcamento";
            this.lblExcluirOrcamento.Size = new System.Drawing.Size(97, 81);
            this.lblExcluirOrcamento.TabIndex = 11;
            this.lblExcluirOrcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblExcluirOrcamento, "Excluir orçamento");
            this.lblExcluirOrcamento.Click += new System.EventHandler(this.lblExcluirOrcamento_Click);
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("lblAtualizar.Image")));
            this.lblAtualizar.Location = new System.Drawing.Point(135, 14);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(97, 81);
            this.lblAtualizar.TabIndex = 10;
            this.lblAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblAtualizar, "Atualizar orçamento");
            this.lblAtualizar.Click += new System.EventHandler(this.lblAtualizar_Click);
            // 
            // lblFinalizarEntrega
            // 
            this.lblFinalizarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFinalizarEntrega.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarEntrega.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.images;
            this.lblFinalizarEntrega.Location = new System.Drawing.Point(636, 14);
            this.lblFinalizarEntrega.Name = "lblFinalizarEntrega";
            this.lblFinalizarEntrega.Size = new System.Drawing.Size(97, 81);
            this.lblFinalizarEntrega.TabIndex = 9;
            this.lblFinalizarEntrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblFinalizarEntrega, "Finalizar entrega");
            this.lblFinalizarEntrega.Click += new System.EventHandler(this.lblFinalizarEntrega_Click);
            // 
            // lblRecusar
            // 
            this.lblRecusar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecusar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecusar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_Cancel_icon;
            this.lblRecusar.Location = new System.Drawing.Point(430, 14);
            this.lblRecusar.Name = "lblRecusar";
            this.lblRecusar.Size = new System.Drawing.Size(97, 81);
            this.lblRecusar.TabIndex = 8;
            this.lblRecusar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblRecusar, "Recusar orçamento");
            this.lblRecusar.Click += new System.EventHandler(this.lblRecusar_Click);
            // 
            // lblAprovar
            // 
            this.lblAprovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAprovar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovar.Image = ((System.Drawing.Image)(resources.GetObject("lblAprovar.Image")));
            this.lblAprovar.Location = new System.Drawing.Point(327, 14);
            this.lblAprovar.Name = "lblAprovar";
            this.lblAprovar.Size = new System.Drawing.Size(97, 81);
            this.lblAprovar.TabIndex = 7;
            this.lblAprovar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblAprovar, "Aprovar orçamento");
            this.lblAprovar.Click += new System.EventHandler(this.lblAprovar_Click);
            // 
            // lblImprimir
            // 
            this.lblImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImprimir.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.print_icon;
            this.lblImprimir.Location = new System.Drawing.Point(533, 14);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(97, 81);
            this.lblImprimir.TabIndex = 6;
            this.lblImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblImprimir, "Imprimir");
            this.lblImprimir.Click += new System.EventHandler(this.lblImprimir_Click);
            // 
            // lblNovo
            // 
            this.lblNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovo.Image = ((System.Drawing.Image)(resources.GetObject("lblNovo.Image")));
            this.lblNovo.Location = new System.Drawing.Point(33, 14);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(96, 81);
            this.lblNovo.TabIndex = 5;
            this.lblNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.lblNovo, "Novo orçamento");
            this.lblNovo.Click += new System.EventHandler(this.lblNovo_Click);
            // 
            // FrmGerarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 436);
            this.Controls.Add(this.lbConfirmarPagamento);
            this.Controls.Add(this.lblExcluirOrcamento);
            this.Controls.Add(this.lblAtualizar);
            this.Controls.Add(this.lblFinalizarEntrega);
            this.Controls.Add(this.lblRecusar);
            this.Controls.Add(this.lblAprovar);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.lblNovo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmGerarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGerarOrcamento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrcamento;
        private System.Windows.Forms.Label lblNovo;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.Label lblAprovar;
        private System.Windows.Forms.Label lblRecusar;
        private System.Windows.Forms.Label lblFinalizarEntrega;
        private System.Windows.Forms.Label lblAtualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblExcluirOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProduto;
        private System.Windows.Forms.Label lbConfirmarPagamento;
    }
}