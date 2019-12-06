using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPS_OphellSystem;
using Cadastros.Controles;
using Controles;
using Vendas.Controles;
using Modelos;

namespace Views
{
    public partial class FrmRtlOrcamento : Form
    {
        public FrmRtlOrcamento()
        {
            InitializeComponent();
        }
        public OrcamentoModelo Orcamento { get; set; }        
        private RelatorioOrcamentoControle controle = new RelatorioOrcamentoControle();
        private void FrmRtlOrcamento_Load(object sender, EventArgs e)
        {
            if (Orcamento == null) return;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add( new Microsoft.Reporting.WinForms.ReportDataSource("dsFornecedor",controle.GerarRelatorio(Orcamento)));
            this.reportViewer1.RefreshReport();

        }
    }
}
