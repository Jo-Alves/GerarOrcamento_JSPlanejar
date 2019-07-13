namespace GerarOrcamento_JSPlanejar
{
    partial class FrmImprimirOrcamento
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirOrcamento));
            this.rpOrcamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbControleOrcamentoDataSet = new GerarOrcamento_JSPlanejar.dbControleOrcamentoDataSet();
            this.tabelaOrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaOrcamentoTableAdapter = new GerarOrcamento_JSPlanejar.dbControleOrcamentoDataSetTableAdapters.tabelaOrcamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleOrcamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpOrcamento
            // 
            this.rpOrcamento.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrcamento";
            reportDataSource1.Value = this.tabelaOrcamentoBindingSource;
            this.rpOrcamento.LocalReport.DataSources.Add(reportDataSource1);
            this.rpOrcamento.LocalReport.ReportEmbeddedResource = "GerarOrcamento_JSPlanejar.rpOrcamento.rdlc";
            this.rpOrcamento.Location = new System.Drawing.Point(0, 0);
            this.rpOrcamento.Name = "rpOrcamento";
            this.rpOrcamento.ServerReport.BearerToken = null;
            this.rpOrcamento.Size = new System.Drawing.Size(1200, 658);
            this.rpOrcamento.TabIndex = 0;
            // 
            // dbControleOrcamentoDataSet
            // 
            this.dbControleOrcamentoDataSet.DataSetName = "dbControleOrcamentoDataSet";
            this.dbControleOrcamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaOrcamentoBindingSource
            // 
            this.tabelaOrcamentoBindingSource.DataMember = "tabelaOrcamento";
            this.tabelaOrcamentoBindingSource.DataSource = this.dbControleOrcamentoDataSet;
            // 
            // tabelaOrcamentoTableAdapter
            // 
            this.tabelaOrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImprimirOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.rpOrcamento);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImprimirOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar impressão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImprimirOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbControleOrcamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaOrcamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpOrcamento;
        private System.Windows.Forms.BindingSource tabelaOrcamentoBindingSource;
        private dbControleOrcamentoDataSet dbControleOrcamentoDataSet;
        private dbControleOrcamentoDataSetTableAdapters.tabelaOrcamentoTableAdapter tabelaOrcamentoTableAdapter;
    }
}