﻿namespace OPS_OphellSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tStrpCadastroClientes = new System.Windows.Forms.ToolStrip();
            this.tStrpBtnCadastroClientes = new System.Windows.Forms.ToolStripButton();
            this.btnCadastroCategoria = new System.Windows.Forms.ToolStripButton();
            this.btnCadastrarFornecedores = new System.Windows.Forms.ToolStripButton();
            this.btnCadastroOperadores = new System.Windows.Forms.ToolStripButton();
            this.bntCadastroDeCondicaoPagamento = new System.Windows.Forms.ToolStripButton();
            this.tStrpCadastroClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrpCadastroClientes
            // 
            this.tStrpCadastroClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.tStrpCadastroClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tStrpCadastroClientes.GripMargin = new System.Windows.Forms.Padding(0);
            this.tStrpCadastroClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStrpCadastroClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrpBtnCadastroClientes,
            this.btnCadastroCategoria,
            this.btnCadastrarFornecedores,
            this.btnCadastroOperadores,
            this.bntCadastroDeCondicaoPagamento});
            this.tStrpCadastroClientes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tStrpCadastroClientes.Location = new System.Drawing.Point(0, 0);
            this.tStrpCadastroClientes.MaximumSize = new System.Drawing.Size(0, 40);
            this.tStrpCadastroClientes.MinimumSize = new System.Drawing.Size(0, 40);
            this.tStrpCadastroClientes.Name = "tStrpCadastroClientes";
            this.tStrpCadastroClientes.Size = new System.Drawing.Size(1008, 40);
            this.tStrpCadastroClientes.TabIndex = 1;
            this.tStrpCadastroClientes.Text = "Cadastro de Clientes";
            // 
            // tStrpBtnCadastroClientes
            // 
            this.tStrpBtnCadastroClientes.AutoSize = false;
            this.tStrpBtnCadastroClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStrpBtnCadastroClientes.Image = ((System.Drawing.Image)(resources.GetObject("tStrpBtnCadastroClientes.Image")));
            this.tStrpBtnCadastroClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrpBtnCadastroClientes.Name = "tStrpBtnCadastroClientes";
            this.tStrpBtnCadastroClientes.Size = new System.Drawing.Size(40, 37);
            this.tStrpBtnCadastroClientes.ToolTipText = "Cadastro de Clientes";
            this.tStrpBtnCadastroClientes.Click += new System.EventHandler(this.tStrpBtnCadastroClientes_Click);
            // 
            // btnCadastroCategoria
            // 
            this.btnCadastroCategoria.AutoSize = false;
            this.btnCadastroCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastroCategoria.Image = global::OPS_OphellSystem.Properties.Resources.produtos32x32;
            this.btnCadastroCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastroCategoria.Name = "btnCadastroCategoria";
            this.btnCadastroCategoria.Size = new System.Drawing.Size(40, 37);
            this.btnCadastroCategoria.ToolTipText = "Cadastro de Categrias de Produtos";
            this.btnCadastroCategoria.Click += new System.EventHandler(this.btnCadastroCategoria_Click);
            // 
            // btnCadastrarFornecedores
            // 
            this.btnCadastrarFornecedores.AutoSize = false;
            this.btnCadastrarFornecedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastrarFornecedores.Image = global::OPS_OphellSystem.Properties.Resources.Fornecedores32x32;
            this.btnCadastrarFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarFornecedores.Name = "btnCadastrarFornecedores";
            this.btnCadastrarFornecedores.Size = new System.Drawing.Size(40, 37);
            this.btnCadastrarFornecedores.Text = "Cadastro de Fornecedores";
            this.btnCadastrarFornecedores.ToolTipText = "Cadastro de Fornecedores";
            this.btnCadastrarFornecedores.Click += new System.EventHandler(this.btnCadastrarFornecedores_Click);
            // 
            // btnCadastroOperadores
            // 
            this.btnCadastroOperadores.AutoSize = false;
            this.btnCadastroOperadores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastroOperadores.Image = global::OPS_OphellSystem.Properties.Resources.Operadores32x32;
            this.btnCadastroOperadores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastroOperadores.Name = "btnCadastroOperadores";
            this.btnCadastroOperadores.Size = new System.Drawing.Size(40, 37);
            this.btnCadastroOperadores.Text = "Cadastro de Usuarios";
            this.btnCadastroOperadores.Click += new System.EventHandler(this.btnCadastroOperadores_Click);
            // 
            // bntCadastroDeCondicaoPagamento
            // 
            this.bntCadastroDeCondicaoPagamento.AutoSize = false;
            this.bntCadastroDeCondicaoPagamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bntCadastroDeCondicaoPagamento.Image = global::OPS_OphellSystem.Properties.Resources.CondicoesDePagamento;
            this.bntCadastroDeCondicaoPagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntCadastroDeCondicaoPagamento.Name = "bntCadastroDeCondicaoPagamento";
            this.bntCadastroDeCondicaoPagamento.Size = new System.Drawing.Size(40, 37);
            this.bntCadastroDeCondicaoPagamento.Text = "Cadastro de Condições de Pagamentos";
            this.bntCadastroDeCondicaoPagamento.Click += new System.EventHandler(this.bntCadastroDeCondicaoPagamento_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tStrpCadastroClientes);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tStrpCadastroClientes.ResumeLayout(false);
            this.tStrpCadastroClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrpCadastroClientes;
        private System.Windows.Forms.ToolStripButton tStrpBtnCadastroClientes;
        private System.Windows.Forms.ToolStripButton btnCadastroCategoria;
        private System.Windows.Forms.ToolStripButton btnCadastrarFornecedores;
        private System.Windows.Forms.ToolStripButton btnCadastroOperadores;
        private System.Windows.Forms.ToolStripButton bntCadastroDeCondicaoPagamento;
    }
}