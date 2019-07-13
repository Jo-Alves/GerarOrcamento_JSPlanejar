namespace GerarOrcamento_JSPlanejar
{
    partial class FrmFechar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFechar));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGerarBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Windows_Close_Program_icon_24x24;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(40, 111);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(207, 56);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar sistema - ESC";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGerarBackup
            // 
            this.btnGerarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarBackup.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.Database_Backup_icon;
            this.btnGerarBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarBackup.Location = new System.Drawing.Point(40, 36);
            this.btnGerarBackup.Name = "btnGerarBackup";
            this.btnGerarBackup.Size = new System.Drawing.Size(207, 56);
            this.btnGerarBackup.TabIndex = 0;
            this.btnGerarBackup.Text = "Gerar Backup - F1";
            this.btnGerarBackup.UseVisualStyleBackColor = true;
            this.btnGerarBackup.Click += new System.EventHandler(this.btnGerarBackup_Click);
            // 
            // FrmFechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 184);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGerarBackup);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFechar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar e Sair";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFechar_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarBackup;
        private System.Windows.Forms.Button btnFechar;
    }
}