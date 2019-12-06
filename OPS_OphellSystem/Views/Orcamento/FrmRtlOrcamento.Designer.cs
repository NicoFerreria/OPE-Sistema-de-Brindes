namespace Views
{
    partial class FrmRtlOrcamento
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
            this.ImpressaoPedidoVendaTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CabecalhoRelatorioTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ImpressaoPedidoVendaTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CabecalhoRelatorioTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ImpressaoPedidoVendaTOBindingSource
            // 
            this.ImpressaoPedidoVendaTOBindingSource.DataMember = "ImpressaoPedidoVendaTO";
            // 
            // CabecalhoRelatorioTOBindingSource
            // 
            this.CabecalhoRelatorioTOBindingSource.DataMember = "CabecalhoRelatorioTO";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OPS_OphellSystem.Relatorios.RtlOrcamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmRtlOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRtlOrcamento";
            this.Text = "Visualizar Orçamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRtlOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImpressaoPedidoVendaTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CabecalhoRelatorioTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ImpressaoPedidoVendaTOBindingSource;
        private System.Windows.Forms.BindingSource CabecalhoRelatorioTOBindingSource;
    }
}