namespace GerarOrcamento_JSPlanejar
{
    partial class FrmInformarDicaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformarDicaSenha));
            this.panelTela = new System.Windows.Forms.Panel();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lbl_PerguntaSeguranca = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_DicaSenha = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.White;
            this.panelTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTela.Controls.Add(this.lblFechar);
            this.panelTela.Controls.Add(this.lbl_PerguntaSeguranca);
            this.panelTela.Controls.Add(this.btn_Confirmar);
            this.panelTela.Controls.Add(this.txt_DicaSenha);
            this.panelTela.Controls.Add(this.Usuario);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Margin = new System.Windows.Forms.Padding(4);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(452, 161);
            this.panelTela.TabIndex = 0;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.Location = new System.Drawing.Point(428, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(23, 21);
            this.lblFechar.TabIndex = 10;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            this.lblFechar.MouseEnter += new System.EventHandler(this.lblFechar_MouseEnter);
            this.lblFechar.MouseLeave += new System.EventHandler(this.lblFechar_MouseLeave);
            // 
            // lbl_PerguntaSeguranca
            // 
            this.lbl_PerguntaSeguranca.AutoSize = true;
            this.lbl_PerguntaSeguranca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerguntaSeguranca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_PerguntaSeguranca.Location = new System.Drawing.Point(15, 19);
            this.lbl_PerguntaSeguranca.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_PerguntaSeguranca.Name = "lbl_PerguntaSeguranca";
            this.lbl_PerguntaSeguranca.Size = new System.Drawing.Size(0, 19);
            this.lbl_PerguntaSeguranca.TabIndex = 9;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirmar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Ok_icon_24x24;
            this.btn_Confirmar.Location = new System.Drawing.Point(302, 103);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(133, 42);
            this.btn_Confirmar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_Confirmar, "Confirmar");
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // txt_DicaSenha
            // 
            this.txt_DicaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DicaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DicaSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_DicaSenha.Location = new System.Drawing.Point(19, 70);
            this.txt_DicaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DicaSenha.Name = "txt_DicaSenha";
            this.txt_DicaSenha.Size = new System.Drawing.Size(415, 26);
            this.txt_DicaSenha.TabIndex = 4;
            this.txt_DicaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DicaSenha_KeyDown);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usuario.Location = new System.Drawing.Point(15, 47);
            this.Usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(224, 19);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Digite a  resposta de segurança:";
            // 
            // FrmInformarDicaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 161);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformarDicaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informar Dica de Senha";
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.TextBox txt_DicaSenha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label lbl_PerguntaSeguranca;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblFechar;
    }
}