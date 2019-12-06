using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Modelos;
using Modelos;
using Cadastros.Controles;

namespace Views
{
    public partial class FrmBuscaProduto : FrmBusca
    {
        #region "PROPRIEDADES"
        public ProdutoModelo Produto { get; set; }
        private ProdutoControle _controle = new ProdutoControle();
        #endregion
        public FrmBuscaProduto()
        {
            InitializeComponent();
        }
        private void CarregarProduto()
        {
            try
            {
                if (grdResultados.DataSource != null)
                {
                    Produto = (ProdutoModelo)grdResultados.SelectedItem;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fechar(bool confirma = false)
        {
            try
            {
                if (this.Visible == true)
                {
                    if (confirma == true)
                    {
                        CarregarProduto();
                    }
                    else
                    {
                        Produto = null;
                    }
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaListagem()
        {
            try
            {
                var dtDados = _controle.RetornaDataTableTodosProdutos();
                List<ProdutoModelo> lista = new List<ProdutoModelo>();
                for (int i = 0; i < dtDados.Rows.Count; i++)
                {
                    ProdutoModelo p = new ProdutoModelo()
                    {
                        ProdutoID = long.Parse(dtDados.Rows[i]["id"].ToString()),
                        Codigo = long.Parse(dtDados.Rows[i]["codigo"].ToString()),
                        Cor = dtDados.Rows[i]["cor"].ToString(),
                        Descricao = dtDados.Rows[i]["descricao"].ToString(),
                        Nome = dtDados.Rows[i]["nome"].ToString(),
                        Observacao = dtDados.Rows[i]["observacao"].ToString(),
                        Status = dtDados.Rows[i]["status"].ToString() == "1" ? true : false
                };
                lista.Add(p);
            }
                grdResultados.DataSource = null;
            grdResultados.DataSource = lista;
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

#region "Eventos"
private void FrmBuscaProduto_FormClosing(object sender, FormClosingEventArgs e)
{
    Fechar();
    e.Cancel = true;
}
private void btnConfirma_Click(object sender, EventArgs e)
{
    Fechar(true);
}
#endregion

private void FrmBuscaProduto_Shown(object sender, EventArgs e)
{
    CarregaListagem();
}
    }
}
