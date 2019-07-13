namespace GerarOrcamento_JSPlanejar
{
    partial class FrmRepasseParcela
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbControleOrcamentoDataSet = new GerarOrcamento_JSPlanejar.dbControleOrcamentoDataSet();
            this.TabelaParcelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabelaParcelasTableAdapter = new GerarOrcamento_JSPlanejar.dbControleOrcamentoDataSetTableAdapters.TabelaParcelasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbControleOrcamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaParcelasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TabelaParcelasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GerarOrcamento_JSPlanejar.rpRepasseParcelamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbControleOrcamentoDataSet
            // 
            this.dbControleOrcamentoDataSet.DataSetName = "dbControleOrcamentoDataSet";
            this.dbControleOrcamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabelaParcelasBindingSource
            // 
            this.TabelaParcelasBindingSource.DataMember = "TabelaParcelas";
            this.TabelaParcelasBindingSource.DataSource = this.dbControleOrcamentoDataSet;
            // 
            // TabelaParcelasTableAdapter
            // 
            this.TabelaParcelasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepasseParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRepasseParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repasse Parcela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRepasseParcela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbControleOrcamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaParcelasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TabelaParcelasBindingSource;
        private dbControleOrcamentoDataSet dbControleOrcamentoDataSet;
        private dbControleOrcamentoDataSetTableAdapters.TabelaParcelasTableAdapter TabelaParcelasTableAdapter;
    }
}