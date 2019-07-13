namespace GerarOrcamento_JSPlanejar
{
    partial class FrmFinalizarAtualizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizarAtualizacao));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorPeças = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdutoFinal = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblEstimativaEntrega = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDataEntrega = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Ok_icon_24x24;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(316, 319);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 40);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Materiais - R$:";
            // 
            // lblValorPeças
            // 
            this.lblValorPeças.BackColor = System.Drawing.Color.White;
            this.lblValorPeças.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorPeças.Location = new System.Drawing.Point(125, 51);
            this.lblValorPeças.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPeças.Name = "lblValorPeças";
            this.lblValorPeças.Size = new System.Drawing.Size(121, 26);
            this.lblValorPeças.TabIndex = 3;
            this.lblValorPeças.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto Final - Descrição:";
            // 
            // txtProdutoFinal
            // 
            this.txtProdutoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoFinal.Location = new System.Drawing.Point(17, 215);
            this.txtProdutoFinal.Name = "txtProdutoFinal";
            this.txtProdutoFinal.Size = new System.Drawing.Size(421, 26);
            this.txtProdutoFinal.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Go_back_icon;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(193, 318);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 43);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcrescimo.Location = new System.Drawing.Point(17, 268);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(113, 26);
            this.txtAcrescimo.TabIndex = 7;
            this.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAcrescimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcrescimo_KeyPress);
            this.txtAcrescimo.Leave += new System.EventHandler(this.txtAcrescimo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Acréscimo - R$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Total - R$:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.Aquamarine;
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorTotal.Location = new System.Drawing.Point(157, 269);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(121, 26);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstimativaEntrega
            // 
            this.lblEstimativaEntrega.AutoSize = true;
            this.lblEstimativaEntrega.Location = new System.Drawing.Point(247, 125);
            this.lblEstimativaEntrega.Name = "lblEstimativaEntrega";
            this.lblEstimativaEntrega.Size = new System.Drawing.Size(0, 19);
            this.lblEstimativaEntrega.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Estimativa de entrega:";
            // 
            // btnDataEntrega
            // 
            this.btnDataEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataEntrega.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.calendar_icon;
            this.btnDataEntrega.Location = new System.Drawing.Point(13, 106);
            this.btnDataEntrega.Name = "btnDataEntrega";
            this.btnDataEntrega.Size = new System.Drawing.Size(53, 53);
            this.btnDataEntrega.TabIndex = 28;
            this.btnDataEntrega.Click += new System.EventHandler(this.btnDataEntrega_Click);
            // 
            // FrmFinalizarAtualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 372);
            this.Controls.Add(this.lblEstimativaEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDataEntrega);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAcrescimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdutoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValorPeças);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFinalizar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFinalizarAtualizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Orçamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFinalizarOrcamento_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorPeças;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdutoFinal;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblEstimativaEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btnDataEntrega;
    }
}