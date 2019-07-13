namespace GerarOrcamento_JSPlanejar
{
    partial class FrmContasClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Baixar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_PagamentoParcelas = new System.Windows.Forms.DataGridView();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lbl_SeparadorDados = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblCodigo_Cliente = new System.Windows.Forms.Label();
            this.lblNome_Cliente = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PagamentoParcelas)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Baixar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox13);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 508);
            this.panel1.TabIndex = 0;
            // 
            // btn_Baixar
            // 
            this.btn_Baixar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Baixar.Location = new System.Drawing.Point(7, 439);
            this.btn_Baixar.Name = "btn_Baixar";
            this.btn_Baixar.Size = new System.Drawing.Size(134, 56);
            this.btn_Baixar.TabIndex = 12;
            this.btn_Baixar.Text = "Baixar - F3";
            this.btn_Baixar.UseVisualStyleBackColor = true;
            this.btn_Baixar.Click += new System.EventHandler(this.btn_Baixar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_PagamentoParcelas);
            this.groupBox1.Location = new System.Drawing.Point(4, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 280);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcelas";
            // 
            // dgv_PagamentoParcelas
            // 
            this.dgv_PagamentoParcelas.AllowUserToAddRows = false;
            this.dgv_PagamentoParcelas.AllowUserToDeleteRows = false;
            this.dgv_PagamentoParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_PagamentoParcelas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PagamentoParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PagamentoParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_PagamentoParcelas.ColumnHeadersHeight = 30;
            this.dgv_PagamentoParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_PagamentoParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColNumero,
            this.ColVencimento,
            this.ColValor,
            this.ColData});
            this.dgv_PagamentoParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PagamentoParcelas.Location = new System.Drawing.Point(3, 22);
            this.dgv_PagamentoParcelas.Name = "dgv_PagamentoParcelas";
            this.dgv_PagamentoParcelas.ReadOnly = true;
            this.dgv_PagamentoParcelas.RowHeadersWidth = 30;
            this.dgv_PagamentoParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PagamentoParcelas.Size = new System.Drawing.Size(721, 255);
            this.dgv_PagamentoParcelas.TabIndex = 2;
            this.dgv_PagamentoParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PagamentoParcelas_CellClick);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btn_Limpar);
            this.groupBox13.Controls.Add(this.btn_Buscar);
            this.groupBox13.Controls.Add(this.lbl_SeparadorDados);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.label38);
            this.groupBox13.Controls.Add(this.lblCodigo_Cliente);
            this.groupBox13.Controls.Add(this.lblNome_Cliente);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Controls.Add(this.txt_nome);
            this.groupBox13.ForeColor = System.Drawing.Color.Black;
            this.groupBox13.Location = new System.Drawing.Point(3, 11);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(728, 135);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Cliente:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.Black;
            this.btn_Limpar.Location = new System.Drawing.Point(634, 44);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(81, 38);
            this.btn_Limpar.TabIndex = 21;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.search_icon;
            this.btn_Buscar.Location = new System.Drawing.Point(545, 44);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(83, 38);
            this.btn_Buscar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btn_Buscar, "Buscar");
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lbl_SeparadorDados
            // 
            this.lbl_SeparadorDados.AutoSize = true;
            this.lbl_SeparadorDados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SeparadorDados.ForeColor = System.Drawing.Color.Black;
            this.lbl_SeparadorDados.Location = new System.Drawing.Point(65, 104);
            this.lbl_SeparadorDados.Name = "lbl_SeparadorDados";
            this.lbl_SeparadorDados.Size = new System.Drawing.Size(12, 19);
            this.lbl_SeparadorDados.TabIndex = 19;
            this.lbl_SeparadorDados.Text = "|";
            this.lbl_SeparadorDados.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(65, 81);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(12, 19);
            this.label36.TabIndex = 18;
            this.label36.Text = "|";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(12, 81);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 19);
            this.label37.TabIndex = 17;
            this.label37.Text = "Código";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(77, 81);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 19);
            this.label38.TabIndex = 16;
            this.label38.Text = "Nome";
            // 
            // lblCodigo_Cliente
            // 
            this.lblCodigo_Cliente.AutoSize = true;
            this.lblCodigo_Cliente.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo_Cliente.Location = new System.Drawing.Point(12, 104);
            this.lblCodigo_Cliente.Name = "lblCodigo_Cliente";
            this.lblCodigo_Cliente.Size = new System.Drawing.Size(0, 19);
            this.lblCodigo_Cliente.TabIndex = 15;
            // 
            // lblNome_Cliente
            // 
            this.lblNome_Cliente.AutoSize = true;
            this.lblNome_Cliente.ForeColor = System.Drawing.Color.Black;
            this.lblNome_Cliente.Location = new System.Drawing.Point(80, 104);
            this.lblNome_Cliente.Name = "lblNome_Cliente";
            this.lblNome_Cliente.Size = new System.Drawing.Size(0, 19);
            this.lblNome_Cliente.TabIndex = 14;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(12, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(117, 19);
            this.label29.TabIndex = 7;
            this.label29.Text = "Nome do cliente";
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.White;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Location = new System.Drawing.Point(8, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(531, 26);
            this.txt_nome.TabIndex = 6;
            // 
            // ColCod
            // 
            this.ColCod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCod.DataPropertyName = "Cod_Orcamento";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColCod.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColCod.HeaderText = "Cód. Orçamento";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.Width = 137;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNumero.DataPropertyName = "N_ParcelaPagamento";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColNumero.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColNumero.HeaderText = "Número  da Parcela";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 156;
            // 
            // ColVencimento
            // 
            this.ColVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColVencimento.DataPropertyName = "dv_ParcelaPagamento";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColVencimento.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColVencimento.HeaderText = "Vencimento";
            this.ColVencimento.Name = "ColVencimento";
            this.ColVencimento.ReadOnly = true;
            this.ColVencimento.Width = 104;
            // 
            // ColValor
            // 
            this.ColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValor.DataPropertyName = "Vp_ParcelaPagamento";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.NullValue = null;
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColValor.HeaderText = "Valor Parcela";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 115;
            // 
            // ColData
            // 
            this.ColData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColData.DataPropertyName = "DataPedido_Orcamento";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColData.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColData.HeaderText = "Data  da solicitação";
            this.ColData.Name = "ColData";
            this.ColData.ReadOnly = true;
            this.ColData.Width = 153;
            // 
            // FrmContasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContasClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Clientes";
            this.Load += new System.EventHandler(this.FrmContasClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContasClientes_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PagamentoParcelas)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_SeparadorDados;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblCodigo_Cliente;
        private System.Windows.Forms.Label lblNome_Cliente;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParceladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaVendaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_PagamentoParcelas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_Baixar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
    }
}