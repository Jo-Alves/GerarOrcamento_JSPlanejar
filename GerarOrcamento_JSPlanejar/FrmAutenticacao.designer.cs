﻿namespace GerarOrcamento_JSPlanejar
{
    partial class FrmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutenticacao));
            this.panelTela = new System.Windows.Forms.Panel();
            this.linkRedefinicao = new System.Windows.Forms.LinkLabel();
            this.lbl_DicaSenha = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.White;
            this.panelTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTela.Controls.Add(this.linkRedefinicao);
            this.panelTela.Controls.Add(this.lbl_DicaSenha);
            this.panelTela.Controls.Add(this.btn_Entrar);
            this.panelTela.Controls.Add(this.label2);
            this.panelTela.Controls.Add(this.txt_Senha);
            this.panelTela.Controls.Add(this.label1);
            this.panelTela.Controls.Add(this.cb_Usuario);
            this.panelTela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTela.ForeColor = System.Drawing.Color.Black;
            this.panelTela.Location = new System.Drawing.Point(0, 0);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(416, 217);
            this.panelTela.TabIndex = 10;
            // 
            // linkRedefinicao
            // 
            this.linkRedefinicao.AutoSize = true;
            this.linkRedefinicao.Location = new System.Drawing.Point(141, 184);
            this.linkRedefinicao.Name = "linkRedefinicao";
            this.linkRedefinicao.Size = new System.Drawing.Size(104, 19);
            this.linkRedefinicao.TabIndex = 9;
            this.linkRedefinicao.TabStop = true;
            this.linkRedefinicao.Text = "Redefinir Senha";
            this.linkRedefinicao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRedefinicao_LinkClicked);
            // 
            // lbl_DicaSenha
            // 
            this.lbl_DicaSenha.AutoSize = true;
            this.lbl_DicaSenha.ForeColor = System.Drawing.Color.Black;
            this.lbl_DicaSenha.Location = new System.Drawing.Point(141, 156);
            this.lbl_DicaSenha.Name = "lbl_DicaSenha";
            this.lbl_DicaSenha.Size = new System.Drawing.Size(0, 19);
            this.lbl_DicaSenha.TabIndex = 8;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Entrar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.logar;
            this.btn_Entrar.Location = new System.Drawing.Point(31, 103);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(356, 42);
            this.btn_Entrar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_Entrar, "Entrar");
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Senha.Location = new System.Drawing.Point(100, 71);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(257, 26);
            this.txt_Senha.TabIndex = 0;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.BackColor = System.Drawing.Color.White;
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(100, 36);
            this.cb_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(257, 27);
            this.cb_Usuario.TabIndex = 1;
            this.cb_Usuario.SelectedIndexChanged += new System.EventHandler(this.cb_Usuario_SelectedIndexChanged);
            // 
            // FrmAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 217);
            this.Controls.Add(this.panelTela);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticacao do sistema";
            this.Load += new System.EventHandler(this.FrmAutenticacao_Load);
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_DicaSenha;
        private System.Windows.Forms.LinkLabel linkRedefinicao;
    }
}