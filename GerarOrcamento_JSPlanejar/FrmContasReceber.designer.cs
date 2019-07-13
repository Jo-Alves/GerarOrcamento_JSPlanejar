namespace GerarOrcamento_JSPlanejar
{
    partial class FrmContasReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_ValorParcial = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ValorParcela = new System.Windows.Forms.Label();
            this.TabContasReceber = new System.Windows.Forms.TabControl();
            this.tabPage_Parcelas = new System.Windows.Forms.TabPage();
            this.dgvParcela = new System.Windows.Forms.DataGridView();
            this.tabPageCredito = new System.Windows.Forms.TabPage();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvParcelasCredito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TabContasReceber.SuspendLayout();
            this.tabPage_Parcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcela)).BeginInit();
            this.tabPageCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 545);
            this.panel1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_ValorTotal);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(754, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 66);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total - Parcelas(diheiro) + Cartão de Crédito";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.BackColor = System.Drawing.Color.White;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(46, 20);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(250, 26);
            this.lbl_ValorTotal.TabIndex = 1;
            this.lbl_ValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblValorCredito);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(476, 470);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 66);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total a Receber - Cartão de Crédito";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.BackColor = System.Drawing.Color.White;
            this.lblValorCredito.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCredito.ForeColor = System.Drawing.Color.Magenta;
            this.lblValorCredito.Location = new System.Drawing.Point(37, 22);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(188, 25);
            this.lblValorCredito.TabIndex = 1;
            this.lblValorCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_ValorParcial);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(548, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total a Receber - Parcial";
            // 
            // lbl_ValorParcial
            // 
            this.lbl_ValorParcial.AutoSize = true;
            this.lbl_ValorParcial.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorParcial.Location = new System.Drawing.Point(63, 20);
            this.lbl_ValorParcial.Name = "lbl_ValorParcial";
            this.lbl_ValorParcial.Size = new System.Drawing.Size(0, 26);
            this.lbl_ValorParcial.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ValorParcela);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(176, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total a Receber - Parcelas(dinheiro)";
            // 
            // lbl_ValorParcela
            // 
            this.lbl_ValorParcela.BackColor = System.Drawing.Color.White;
            this.lbl_ValorParcela.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorParcela.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_ValorParcela.Location = new System.Drawing.Point(48, 20);
            this.lbl_ValorParcela.Name = "lbl_ValorParcela";
            this.lbl_ValorParcela.Size = new System.Drawing.Size(188, 25);
            this.lbl_ValorParcela.TabIndex = 1;
            this.lbl_ValorParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabContasReceber
            // 
            this.TabContasReceber.Controls.Add(this.tabPage_Parcelas);
            this.TabContasReceber.Controls.Add(this.tabPageCredito);
            this.TabContasReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabContasReceber.Location = new System.Drawing.Point(2, 1);
            this.TabContasReceber.Name = "TabContasReceber";
            this.TabContasReceber.SelectedIndex = 0;
            this.TabContasReceber.Size = new System.Drawing.Size(1192, 489);
            this.TabContasReceber.TabIndex = 0;
            // 
            // tabPage_Parcelas
            // 
            this.tabPage_Parcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Parcelas.Controls.Add(this.dgvParcela);
            this.tabPage_Parcelas.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Parcelas.Name = "tabPage_Parcelas";
            this.tabPage_Parcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Parcelas.Size = new System.Drawing.Size(1184, 457);
            this.tabPage_Parcelas.TabIndex = 1;
            this.tabPage_Parcelas.Text = "Parcelamento(dinheiro) - F1";
            this.tabPage_Parcelas.UseVisualStyleBackColor = true;
            // 
            // dgvParcela
            // 
            this.dgvParcela.AllowUserToAddRows = false;
            this.dgvParcela.AllowUserToDeleteRows = false;
            this.dgvParcela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcela.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcela.ColumnHeadersHeight = 32;
            this.dgvParcela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParcela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column13,
            this.Column12});
            this.dgvParcela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcela.Location = new System.Drawing.Point(3, 3);
            this.dgvParcela.Name = "dgvParcela";
            this.dgvParcela.ReadOnly = true;
            this.dgvParcela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcela.Size = new System.Drawing.Size(1176, 449);
            this.dgvParcela.TabIndex = 0;
            this.dgvParcela.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvParcela_DataBindingComplete);
            // 
            // tabPageCredito
            // 
            this.tabPageCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageCredito.Controls.Add(this.dgvParcelasCredito);
            this.tabPageCredito.Location = new System.Drawing.Point(4, 28);
            this.tabPageCredito.Name = "tabPageCredito";
            this.tabPageCredito.Size = new System.Drawing.Size(1184, 457);
            this.tabPageCredito.TabIndex = 2;
            this.tabPageCredito.Text = "Cartão de Crédito - F2";
            this.tabPageCredito.UseVisualStyleBackColor = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Cod_Cliente";
            this.Column8.HeaderText = "Cód Cliente";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 113;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "Nome_Cliente";
            this.Column9.HeaderText = "Cliente";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 82;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.DataPropertyName = "vp_ParcelaPagamento";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column10.HeaderText = "Valor Parcela";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 124;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.DataPropertyName = "N_ParcelaPagamento";
            this.Column11.HeaderText = "Nº Parcela";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 105;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.DataPropertyName = "Cod_Orcamento";
            this.Column13.HeaderText = "Cód. Orcamento";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 143;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.DataPropertyName = "dv_ParcelaPagamento";
            this.Column12.HeaderText = "Vencimento";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 112;
            // 
            // dgvParcelasCredito
            // 
            this.dgvParcelasCredito.AllowUserToAddRows = false;
            this.dgvParcelasCredito.AllowUserToDeleteRows = false;
            this.dgvParcelasCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParcelasCredito.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelasCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParcelasCredito.ColumnHeadersHeight = 32;
            this.dgvParcelasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParcelasCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvParcelasCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelasCredito.Location = new System.Drawing.Point(0, 0);
            this.dgvParcelasCredito.Name = "dgvParcelasCredito";
            this.dgvParcelasCredito.ReadOnly = true;
            this.dgvParcelasCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelasCredito.Size = new System.Drawing.Size(1182, 455);
            this.dgvParcelasCredito.TabIndex = 1;
            this.dgvParcelasCredito.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvParcelasCredito_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 113;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vp_ParcelaPagamento";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor Parcela";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 124;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "N_ParcelaPagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nº Parcela";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cod_Orcamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cód. Orcamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 143;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dv_ParcelaPagamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vencimento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 112;
            // 
            // FrmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 573);
            this.Controls.Add(this.TabContasReceber);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContasReceber_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.TabContasReceber.ResumeLayout(false);
            this.tabPage_Parcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcela)).EndInit();
            this.tabPageCredito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelasCredito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_ValorParcela;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ValorParcial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.TabControl TabContasReceber;
        private System.Windows.Forms.TabPage tabPage_Parcelas;
        private System.Windows.Forms.DataGridView dgvParcela;
        private System.Windows.Forms.TabPage tabPageCredito;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblValorCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridView dgvParcelasCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}