﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPS_OphellSystem.Cadastros.Views.CondicoesDePagamento
{
    public partial class FrmCadastroDeCondicoesDePagamento : Form
    {
        #region "Metodos"
        public FrmCadastroDeCondicoesDePagamento()
        {
            InitializeComponent();
        }
        private void Fechar()
        {
            try
            {
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH");
            }
        }
        private void CarregaComboTiposPagamento()
        {
            try
            {
                cmbTipo.Items.Clear();
                cmbTipo.Items.Add("BOLETO");
                cmbTipo.Items.Add("CREDITO");
                cmbTipo.Items.Add("DEBITO");
                cmbTipo.Items.Add("CHEQUE");
                cmbTipo.Items.Add("ESPECIE");
                cmbTipo.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "OPH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Eventos"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        #endregion

        private void FrmCadastroDeCondicoesDePagamento_Shown(object sender, EventArgs e)
        {
            CarregaComboTiposPagamento();
        }
    }
}