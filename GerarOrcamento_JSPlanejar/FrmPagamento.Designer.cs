namespace GerarOrcamento_JSPlanejar
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.PnVista = new System.Windows.Forms.Panel();
            this.gbParcelas = new System.Windows.Forms.GroupBox();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNParcelas = new System.Windows.Forms.TextBox();
            this.dgv_Parcelas = new System.Windows.Forms.DataGridView();
            this.ColumnNParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbValorParcela = new System.Windows.Forms.GroupBox();
            this.txt_ValorTotalParcelas = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.btn_ConfirmarVenda = new System.Windows.Forms.Button();
            this.btnCancelarVendaVista = new System.Windows.Forms.Button();
            this.btnGerarRepasse = new System.Windows.Forms.Button();
            this.PnVista.SuspendLayout();
            this.gbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).BeginInit();
            this.gbValorParcela.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnVista
            // 
            this.PnVista.BackColor = System.Drawing.Color.White;
            this.PnVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnVista.Controls.Add(this.btnGerarRepasse);
            this.PnVista.Controls.Add(this.gbParcelas);
            this.PnVista.Controls.Add(this.txtTroco);
            this.PnVista.Controls.Add(this.lblTroco);
            this.PnVista.Controls.Add(this.lbl_ValorTotal);
            this.PnVista.Controls.Add(this.label10);
            this.PnVista.Controls.Add(this.txtValorPago);
            this.PnVista.Controls.Add(this.lblValorPago);
            this.PnVista.Controls.Add(this.btn_ConfirmarVenda);
            this.PnVista.Controls.Add(this.btnCancelarVendaVista);
            this.PnVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnVista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnVista.Location = new System.Drawing.Point(0, 0);
            this.PnVista.Name = "PnVista";
            this.PnVista.Size = new System.Drawing.Size(672, 558);
            this.PnVista.TabIndex = 3;
            // 
            // gbParcelas
            // 
            this.gbParcelas.Controls.Add(this.btnGerarParcelas);
            this.gbParcelas.Controls.Add(this.label1);
            this.gbParcelas.Controls.Add(this.txtNParcelas);
            this.gbParcelas.Controls.Add(this.dgv_Parcelas);
            this.gbParcelas.Controls.Add(this.gbValorParcela);
            this.gbParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbParcelas.ForeColor = System.Drawing.Color.Black;
            this.gbParcelas.Location = new System.Drawing.Point(11, 84);
            this.gbParcelas.Name = "gbParcelas";
            this.gbParcelas.Size = new System.Drawing.Size(648, 391);
            this.gbParcelas.TabIndex = 316;
            this.gbParcelas.TabStop = false;
            this.gbParcelas.Text = "Parcelas";
            this.gbParcelas.Visible = false;
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarParcelas.ForeColor = System.Drawing.Color.Black;
            this.btnGerarParcelas.Location = new System.Drawing.Point(84, 334);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(483, 45);
            this.btnGerarParcelas.TabIndex = 317;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 316;
            this.label1.Text = "Nº Parcela:";
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNParcelas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNParcelas.Location = new System.Drawing.Point(52, 41);
            this.txtNParcelas.MaxLength = 2;
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(122, 26);
            this.txtNParcelas.TabIndex = 14;
            this.txtNParcelas.Text = "1";
            this.txtNParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNParcelas.TextChanged += new System.EventHandler(this.txtNParcelas_TextChanged);
            this.txtNParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNParcelas_KeyPress);
            // 
            // dgv_Parcelas
            // 
            this.dgv_Parcelas.AllowUserToAddRows = false;
            this.dgv_Parcelas.AllowUserToDeleteRows = false;
            this.dgv_Parcelas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Parcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Parcelas.ColumnHeadersHeight = 30;
            this.dgv_Parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNParcelas,
            this.ColumnVencimento,
            this.ColumnValorParcela});
            this.dgv_Parcelas.Location = new System.Drawing.Point(52, 73);
            this.dgv_Parcelas.Name = "dgv_Parcelas";
            this.dgv_Parcelas.ReadOnly = true;
            this.dgv_Parcelas.Size = new System.Drawing.Size(515, 194);
            this.dgv_Parcelas.TabIndex = 315;
            // 
            // ColumnNParcelas
            // 
            this.ColumnNParcelas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ColumnNParcelas.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnNParcelas.HeaderText = "Nº da parcela";
            this.ColumnNParcelas.Name = "ColumnNParcelas";
            this.ColumnNParcelas.ReadOnly = true;
            this.ColumnNParcelas.Width = 124;
            // 
            // ColumnVencimento
            // 
            this.ColumnVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.ColumnVencimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnVencimento.HeaderText = "Vencimento";
            this.ColumnVencimento.Name = "ColumnVencimento";
            this.ColumnVencimento.ReadOnly = true;
            this.ColumnVencimento.Width = 112;
            // 
            // ColumnValorParcela
            // 
            this.ColumnValorParcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnValorParcela.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnValorParcela.HeaderText = "Valor da Parcela";
            this.ColumnValorParcela.Name = "ColumnValorParcela";
            this.ColumnValorParcela.ReadOnly = true;
            // 
            // gbValorParcela
            // 
            this.gbValorParcela.Controls.Add(this.txt_ValorTotalParcelas);
            this.gbValorParcela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbValorParcela.ForeColor = System.Drawing.Color.White;
            this.gbValorParcela.Location = new System.Drawing.Point(212, 273);
            this.gbValorParcela.Name = "gbValorParcela";
            this.gbValorParcela.Size = new System.Drawing.Size(178, 55);
            this.gbValorParcela.TabIndex = 314;
            this.gbValorParcela.TabStop = false;
            this.gbValorParcela.Text = "Valor do Parcelamento";
            // 
            // txt_ValorTotalParcelas
            // 
            this.txt_ValorTotalParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorTotalParcelas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorTotalParcelas.Location = new System.Drawing.Point(27, 23);
            this.txt_ValorTotalParcelas.Name = "txt_ValorTotalParcelas";
            this.txt_ValorTotalParcelas.ReadOnly = true;
            this.txt_ValorTotalParcelas.Size = new System.Drawing.Size(122, 26);
            this.txt_ValorTotalParcelas.TabIndex = 13;
            this.txt_ValorTotalParcelas.Text = "R$ 0,00";
            this.txt_ValorTotalParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(30, 148);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(144, 26);
            this.txtTroco.TabIndex = 18;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTroco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTroco_KeyPress);
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Black;
            this.lblTroco.Location = new System.Drawing.Point(26, 123);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(124, 19);
            this.lblTroco.TabIndex = 17;
            this.lblTroco.Text = "Troco ao Cliente:";
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(236, 50);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(0, 31);
            this.lbl_ValorTotal.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(227, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor Total:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(30, 78);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(144, 26);
            this.txtValorPago.TabIndex = 9;
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.ForeColor = System.Drawing.Color.Black;
            this.lblValorPago.Location = new System.Drawing.Point(26, 52);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(137, 19);
            this.lblValorPago.TabIndex = 8;
            this.lblValorPago.Text = "Valor pago - R$ [F]";
            // 
            // btn_ConfirmarVenda
            // 
            this.btn_ConfirmarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConfirmarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfirmarVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConfirmarVenda.Location = new System.Drawing.Point(492, 482);
            this.btn_ConfirmarVenda.Name = "btn_ConfirmarVenda";
            this.btn_ConfirmarVenda.Size = new System.Drawing.Size(164, 60);
            this.btn_ConfirmarVenda.TabIndex = 1;
            this.btn_ConfirmarVenda.Text = "Confirmar - [F10]";
            this.btn_ConfirmarVenda.UseVisualStyleBackColor = true;
            this.btn_ConfirmarVenda.Click += new System.EventHandler(this.btn_ConfirmarPagamento_Click);
            // 
            // btnCancelarVendaVista
            // 
            this.btnCancelarVendaVista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarVendaVista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarVendaVista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVendaVista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVendaVista.Location = new System.Drawing.Point(324, 482);
            this.btnCancelarVendaVista.Name = "btnCancelarVendaVista";
            this.btnCancelarVendaVista.Size = new System.Drawing.Size(162, 60);
            this.btnCancelarVendaVista.TabIndex = 0;
            this.btnCancelarVendaVista.Text = "Cancelar - [ESC]";
            this.btnCancelarVendaVista.UseVisualStyleBackColor = true;
            this.btnCancelarVendaVista.Click += new System.EventHandler(this.btnCancelarVendaVista_Click);
            // 
            // btnGerarRepasse
            // 
            this.btnGerarRepasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRepasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarRepasse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRepasse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarRepasse.Location = new System.Drawing.Point(121, 481);
            this.btnGerarRepasse.Name = "btnGerarRepasse";
            this.btnGerarRepasse.Size = new System.Drawing.Size(197, 60);
            this.btnGerarRepasse.TabIndex = 317;
            this.btnGerarRepasse.Text = "Gerar Repasse - F9";
            this.btnGerarRepasse.UseVisualStyleBackColor = true;
            this.btnGerarRepasse.Visible = false;
            this.btnGerarRepasse.Click += new System.EventHandler(this.btnGerarRepasse_Click);
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 558);
            this.Controls.Add(this.PnVista);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagamento_a_Vista___Dinheiro_KeyDown);
            this.PnVista.ResumeLayout(false);
            this.PnVista.PerformLayout();
            this.gbParcelas.ResumeLayout(false);
            this.gbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcelas)).EndInit();
            this.gbValorParcela.ResumeLayout(false);
            this.gbValorParcela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnVista;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Button btn_ConfirmarVenda;
        private System.Windows.Forms.Button btnCancelarVendaVista;
        private System.Windows.Forms.GroupBox gbParcelas;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNParcelas;
        private System.Windows.Forms.DataGridView dgv_Parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorParcela;
        private System.Windows.Forms.GroupBox gbValorParcela;
        private System.Windows.Forms.TextBox txt_ValorTotalParcelas;
        private System.Windows.Forms.Button btnGerarRepasse;
    }
}