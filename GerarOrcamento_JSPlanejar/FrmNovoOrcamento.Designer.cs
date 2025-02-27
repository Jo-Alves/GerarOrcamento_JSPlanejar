﻿namespace GerarOrcamento_JSPlanejar
{
    partial class FrmNovoOrcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoOrcamento));
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDescricaoPecas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvitens = new System.Windows.Forms.DataGridView();
            this.ColumnCod_Peças = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreçoSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDados = new System.Windows.Forms.Panel();
            this.dgvDadosPeças = new System.Windows.Forms.DataGridView();
            this.Colcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelarTudo = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnDadosCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitens)).BeginInit();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPeças)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(89, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 19);
            this.lblCliente.TabIndex = 1;
            // 
            // txtDescricaoPecas
            // 
            this.txtDescricaoPecas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoPecas.Location = new System.Drawing.Point(12, 110);
            this.txtDescricaoPecas.Name = "txtDescricaoPecas";
            this.txtDescricaoPecas.Size = new System.Drawing.Size(403, 26);
            this.txtDescricaoPecas.TabIndex = 0;
            this.txtDescricaoPecas.TextChanged += new System.EventHandler(this.txtDescricaoPecas_TextChanged);
            this.txtDescricaoPecas.DoubleClick += new System.EventHandler(this.txtDescricaoPecas_DoubleClick);
            this.txtDescricaoPecas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricaoPecas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Peças:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(430, 110);
            this.txtQuantidade.MaxLength = 4;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(91, 26);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(291, 398);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(170, 48);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "R$ 0,00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvitens);
            this.groupBox1.Location = new System.Drawing.Point(16, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dgvitens
            // 
            this.dgvitens.AllowUserToAddRows = false;
            this.dgvitens.AllowUserToDeleteRows = false;
            this.dgvitens.BackgroundColor = System.Drawing.Color.White;
            this.dgvitens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitens.ColumnHeadersHeight = 30;
            this.dgvitens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvitens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCod_Peças,
            this.Column1,
            this.ColQuantidade,
            this.ColPreço,
            this.ColPreçoSubTotal});
            this.dgvitens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvitens.Location = new System.Drawing.Point(3, 22);
            this.dgvitens.MultiSelect = false;
            this.dgvitens.Name = "dgvitens";
            this.dgvitens.ReadOnly = true;
            this.dgvitens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitens.Size = new System.Drawing.Size(659, 208);
            this.dgvitens.TabIndex = 8;
            this.dgvitens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitens_CellClick);
            // 
            // ColumnCod_Peças
            // 
            this.ColumnCod_Peças.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCod_Peças.DataPropertyName = "Cod_Peça";
            this.ColumnCod_Peças.HeaderText = "Código";
            this.ColumnCod_Peças.Name = "ColumnCod_Peças";
            this.ColumnCod_Peças.ReadOnly = true;
            this.ColumnCod_Peças.Width = 79;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Descrição";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColQuantidade
            // 
            this.ColQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColQuantidade.HeaderText = "Quantidade";
            this.ColQuantidade.Name = "ColQuantidade";
            this.ColQuantidade.ReadOnly = true;
            this.ColQuantidade.Width = 104;
            // 
            // ColPreço
            // 
            this.ColPreço.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPreço.HeaderText = "Preço Unitário";
            this.ColPreço.Name = "ColPreço";
            this.ColPreço.ReadOnly = true;
            this.ColPreço.Width = 122;
            // 
            // ColPreçoSubTotal
            // 
            this.ColPreçoSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPreçoSubTotal.HeaderText = "Preço SubTotal";
            this.ColPreçoSubTotal.Name = "ColPreçoSubTotal";
            this.ColPreçoSubTotal.ReadOnly = true;
            this.ColPreçoSubTotal.Width = 128;
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.dgvDadosPeças);
            this.pnDados.Location = new System.Drawing.Point(12, 143);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(669, 227);
            this.pnDados.TabIndex = 57;
            this.pnDados.Visible = false;
            // 
            // dgvDadosPeças
            // 
            this.dgvDadosPeças.AllowUserToAddRows = false;
            this.dgvDadosPeças.AllowUserToDeleteRows = false;
            this.dgvDadosPeças.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosPeças.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDadosPeças.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosPeças.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colcodigo,
            this.ColDescricao,
            this.ColValor,
            this.ColComprimento,
            this.ColUnidade});
            this.dgvDadosPeças.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDadosPeças.Location = new System.Drawing.Point(0, 0);
            this.dgvDadosPeças.Name = "dgvDadosPeças";
            this.dgvDadosPeças.ReadOnly = true;
            this.dgvDadosPeças.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosPeças.Size = new System.Drawing.Size(669, 227);
            this.dgvDadosPeças.TabIndex = 0;
            this.dgvDadosPeças.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDadosPeças_CellClick);
            // 
            // Colcodigo
            // 
            this.Colcodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Colcodigo.DataPropertyName = "Cod_Peça";
            this.Colcodigo.HeaderText = "Código";
            this.Colcodigo.Name = "Colcodigo";
            this.Colcodigo.ReadOnly = true;
            this.Colcodigo.Width = 79;
            // 
            // ColDescricao
            // 
            this.ColDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescricao.DataPropertyName = "Descricao_Peça";
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.ReadOnly = true;
            // 
            // ColValor
            // 
            this.ColValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColValor.DataPropertyName = "Valor_Peça";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            this.ColValor.Width = 66;
            // 
            // ColComprimento
            // 
            this.ColComprimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColComprimento.DataPropertyName = "Comprimento_Peça";
            this.ColComprimento.HeaderText = "Comprimento";
            this.ColComprimento.Name = "ColComprimento";
            this.ColComprimento.ReadOnly = true;
            this.ColComprimento.Width = 117;
            // 
            // ColUnidade
            // 
            this.ColUnidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColUnidade.DataPropertyName = "Unidade_Peça";
            this.ColUnidade.HeaderText = "Unidade";
            this.ColUnidade.Name = "ColUnidade";
            this.ColUnidade.ReadOnly = true;
            this.ColUnidade.Width = 85;
            // 
            // btnLancar
            // 
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLancar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Computer_Hardware_Enter_icon;
            this.btnLancar.Location = new System.Drawing.Point(528, 110);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(91, 27);
            this.btnLancar.TabIndex = 58;
            this.toolTip.SetToolTip(this.btnLancar, "Lançar");
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_exit_icon;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(714, 319);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(158, 57);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelarTudo
            // 
            this.btnCancelarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTudo.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_Cancel_icon24x24;
            this.btnCancelarTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarTudo.Location = new System.Drawing.Point(714, 256);
            this.btnCancelarTudo.Name = "btnCancelarTudo";
            this.btnCancelarTudo.Size = new System.Drawing.Size(158, 57);
            this.btnCancelarTudo.TabIndex = 4;
            this.btnCancelarTudo.Text = "Cancelar tudo";
            this.btnCancelarTudo.UseVisualStyleBackColor = true;
            this.btnCancelarTudo.Click += new System.EventHandler(this.btnCancelarTudo_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarItem.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Button_Cancel_icon24x24;
            this.btnCancelarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarItem.Location = new System.Drawing.Point(714, 193);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(158, 57);
            this.btnCancelarItem.TabIndex = 3;
            this.btnCancelarItem.Text = "Cancelar item";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProsseguir.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.redo_512;
            this.btnProsseguir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProsseguir.Location = new System.Drawing.Point(714, 130);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(158, 57);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // btnDadosCliente
            // 
            this.btnDadosCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDadosCliente.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Clients_icon64X64;
            this.btnDadosCliente.Location = new System.Drawing.Point(12, 9);
            this.btnDadosCliente.Name = "btnDadosCliente";
            this.btnDadosCliente.Size = new System.Drawing.Size(62, 75);
            this.btnDadosCliente.TabIndex = 56;
            this.btnDadosCliente.Click += new System.EventHandler(this.btnDadosCliente_Click);
            // 
            // FrmNovoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelarTudo);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricaoPecas);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnDadosCliente);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovoOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNovoOrcamento_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitens)).EndInit();
            this.pnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPeças)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnDadosCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtDescricaoPecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnCancelarTudo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvitens;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.DataGridView dgvDadosPeças;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidade;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCod_Peças;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPreço;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPreçoSubTotal;
        private System.Windows.Forms.ToolTip toolTip;
    }
}