using System;
using OPS_OphellSystem.Cadastros.Classes.CategoriasDeProdutos;
using System.Windows.Forms;
using System.Data;

namespace OPS_OphellSystem.Cadastros.Views.CategoriasDeProdutos
{
    public partial class FrmBuscaCategoriaProduto : Form
    {
        #region "Classes"
        CadastroDeCategorias cadastroCategoria = new CadastroDeCategorias();
        #endregion

        #region "Variaveis"
       
        #endregion

        #region "Metodos"
        public FrmBuscaCategoriaProduto()
        {
            InitializeComponent();
        }
        private void NovoForm()
        {
            try
            {
                CarregaGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaGrid()
        {
            try
            {
                DataTable dtDados = new DataTable();
                dtDados = cadastroCategoria.BuscaTodasAsCategorias();
                dtGridCategoriaProduto.DataSource = dtDados.DefaultView;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fechar()
        {
            if(this.Visible == true)
            {
                this.Hide();
            }
        }
        #endregion

        #region "Funcoes"
        #endregion

        #region "Eventos"
        private void FrmBuscaCategoriaProduto_Shown(object sender, EventArgs e)
        {
            NovoForm();
        }
        private void FrmBuscaCategoriaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar();
            e.Cancel = true;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        #endregion        
    }
}
