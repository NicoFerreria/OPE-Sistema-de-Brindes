using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastros.Controles;
using Modelos;
using OPS_OphellSystem;

namespace Views
{
    public partial class FrmCadastroPerfil : Form
    {
        PerfilControle controle = new PerfilControle();

        #region "Metodos"
        public FrmCadastroPerfil()
        {
            InitializeComponent();
            CriaGrid();
        }
        private void NovoLoad()
        {
            CarregaListagem();
            txtDescricao.Focus();
        }
        private void CriaGrid()
        {
            try
            {
                utilitarios.CriarColunasGrid(grdPerfis, "id", "ID", TiposColunas.TEXTO, true, false, true);
                utilitarios.CriarColunasGrid(grdPerfis,"descricao","Descrição");

                grdPerfis.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void Gravar()
        {
            try
            {
                PerfilModelo perfil = new PerfilModelo();
                perfil.PerfilId = long.TryParse(txtId.Text,out long id)? id: 0;
                perfil.Descricao = txtDescricao.Text;
                if (controle.Gravar(perfil))
                {
                    MessageBox.Show("Perfil gravado com sucesso!","OPH",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    CarregaListagem();
                }
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void CarregaListagem()
        {
            try
            {
                grdPerfis.DataSource = null;
                grdPerfis.DataSource = controle.RetornaDataTablePerfil();
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        private void LimparCadastro()
        {
            try
            {
                txtId.Text = "";
                txtDescricao.Text = "";
            }catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        #endregion

        #region "Eventos"
        private void FrmCadastroPerfil_Shown(object sender, EventArgs e)
        {
            CarregaListagem();
        }
        private void FrmCadastroPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S) Gravar();
            if (e.KeyCode == Keys.N) LimparCadastro();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        private void btnNovoOperador_Click(object sender, EventArgs e)
        {
            LimparCadastro();
            txtDescricao.Focus();
        }
        #endregion

    }
}
