namespace GerarOrcamento_JSPlanejar
{
    partial class FrmRestauracaoSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestauracaoSistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiretório = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btn_RestaurarSistema = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDiretório);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btn_RestaurarSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 164);
            this.panel1.TabIndex = 1;
            // 
            // txtDiretório
            // 
            this.txtDiretório.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiretório.Location = new System.Drawing.Point(20, 37);
            this.txtDiretório.Name = "txtDiretório";
            this.txtDiretório.ReadOnly = true;
            this.txtDiretório.Size = new System.Drawing.Size(268, 26);
            this.txtDiretório.TabIndex = 44;
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrir.Image = global::GerarOrcamento_JSPlanejar.Properties.Resources.folder_documents_icon__1_;
            this.btnAbrir.Location = new System.Drawing.Point(294, 29);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(111, 41);
            this.btnAbrir.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btnAbrir, "Abrir arquivo");
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btn_RestaurarSistema
            // 
            this.btn_RestaurarSistema.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_RestaurarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RestaurarSistema.Image = ((System.Drawing.Image)(resources.GetObject("btn_RestaurarSistema.Image")));
            this.btn_RestaurarSistema.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_RestaurarSistema.Location = new System.Drawing.Point(20, 88);
            this.btn_RestaurarSistema.Name = "btn_RestaurarSistema";
            this.btn_RestaurarSistema.Size = new System.Drawing.Size(394, 63);
            this.btn_RestaurarSistema.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btn_RestaurarSistema, "Restaurar sistema");
            this.btn_RestaurarSistema.UseVisualStyleBackColor = true;
            this.btn_RestaurarSistema.Click += new System.EventHandler(this.btn_RestaurarSistema_Click);
            // 
            // FrmRestauracaoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 164);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestauracaoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retauração do Sistema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_RestaurarSistema;
        private System.Windows.Forms.TextBox txtDiretório;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}