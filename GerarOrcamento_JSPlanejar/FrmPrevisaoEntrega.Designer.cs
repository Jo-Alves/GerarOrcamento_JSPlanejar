namespace GerarOrcamento_JSPlanejar
{
    partial class FrmPrevisaoEntrega
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
            this.cbPrevisaoEntrega = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ndQuantidadeTempo = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidadeTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPrevisaoEntrega
            // 
            this.cbPrevisaoEntrega.AutoSize = true;
            this.cbPrevisaoEntrega.Location = new System.Drawing.Point(90, 145);
            this.cbPrevisaoEntrega.Name = "cbPrevisaoEntrega";
            this.cbPrevisaoEntrega.Size = new System.Drawing.Size(178, 23);
            this.cbPrevisaoEntrega.TabIndex = 0;
            this.cbPrevisaoEntrega.Text = "Sem Previsão de entrega";
            this.cbPrevisaoEntrega.UseVisualStyleBackColor = true;
            this.cbPrevisaoEntrega.CheckedChanged += new System.EventHandler(this.cbPrevisaoEntrega_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(23, 193);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(159, 47);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "OK";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estimativa de entrega:";
            // 
            // dpDataEntrega
            // 
            this.dpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataEntrega.Location = new System.Drawing.Point(181, 88);
            this.dpDataEntrega.Name = "dpDataEntrega";
            this.dpDataEntrega.Size = new System.Drawing.Size(120, 26);
            this.dpDataEntrega.TabIndex = 3;
            this.dpDataEntrega.ValueChanged += new System.EventHandler(this.dpDataEntrega_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data de entrega:";
            // 
            // ndQuantidadeTempo
            // 
            this.ndQuantidadeTempo.Location = new System.Drawing.Point(181, 39);
            this.ndQuantidadeTempo.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.ndQuantidadeTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantidadeTempo.Name = "ndQuantidadeTempo";
            this.ndQuantidadeTempo.Size = new System.Drawing.Size(120, 26);
            this.ndQuantidadeTempo.TabIndex = 6;
            this.ndQuantidadeTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndQuantidadeTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantidadeTempo.ValueChanged += new System.EventHandler(this.ndQuantidadeTempo_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(188, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 47);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPrevisaoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 275);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.ndQuantidadeTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpDataEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbPrevisaoEntrega);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrevisaoEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previsao de entrega";
            this.Load += new System.EventHandler(this.FrmPrevisaoEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantidadeTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPrevisaoEntrega;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpDataEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndQuantidadeTempo;
        private System.Windows.Forms.Button btnCancelar;
    }
}