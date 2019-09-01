namespace OPS_OphellSystem
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
            this.btnMenuCadastros = new System.Windows.Forms.ToolStripSplitButton();
            this.btnMenuCadFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCadOperadores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCadCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuCondicoesPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuContasPagar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuContasReceber = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrpCadastroClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrpCadastroClientes
            // 
            this.tStrpCadastroClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tStrpCadastroClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tStrpCadastroClientes.GripMargin = new System.Windows.Forms.Padding(0);
            this.tStrpCadastroClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStrpCadastroClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCadastros});
            this.tStrpCadastroClientes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tStrpCadastroClientes.Location = new System.Drawing.Point(0, 0);
            this.tStrpCadastroClientes.MinimumSize = new System.Drawing.Size(200, 40);
            this.tStrpCadastroClientes.Name = "tStrpCadastroClientes";
            this.tStrpCadastroClientes.Size = new System.Drawing.Size(200, 700);
            this.tStrpCadastroClientes.TabIndex = 1;
            this.tStrpCadastroClientes.Text = "Cadastro de Clientes";
            // 
            // btnMenuCadastros
            // 
            this.btnMenuCadastros.AutoSize = false;
            this.btnMenuCadastros.DoubleClickEnabled = true;
            this.btnMenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuCadFornecedores,
            this.btnMenuCadOperadores,
            this.btnMenuCadClientes,
            this.btnMenuCadCategorias,
            this.btnMenuCondicoesPagamento,
            this.btnMenuContasPagar,
            this.btnMenuContasReceber});
            this.btnMenuCadastros.Image = global::OPS_OphellSystem.Properties.Resources.Cadastros32x32;
            this.btnMenuCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuCadastros.Name = "btnMenuCadastros";
            this.btnMenuCadastros.Size = new System.Drawing.Size(198, 40);
            this.btnMenuCadastros.Text = "Cadastros";
            this.btnMenuCadastros.ButtonClick += new System.EventHandler(this.btnMenuCadastros_ButtonClick);
            // 
            // btnMenuCadFornecedores
            // 
            this.btnMenuCadFornecedores.Image = global::OPS_OphellSystem.Properties.Resources.Fornecedores32x32;
            this.btnMenuCadFornecedores.Name = "btnMenuCadFornecedores";
            this.btnMenuCadFornecedores.Size = new System.Drawing.Size(199, 22);
            this.btnMenuCadFornecedores.Text = "Fornecedores";
            this.btnMenuCadFornecedores.Click += new System.EventHandler(this.btnMenuCadFornecedores_Click);
            // 
            // btnMenuCadOperadores
            // 
            this.btnMenuCadOperadores.Image = global::OPS_OphellSystem.Properties.Resources.Operadores32x32;
            this.btnMenuCadOperadores.Name = "btnMenuCadOperadores";
            this.btnMenuCadOperadores.Size = new System.Drawing.Size(199, 22);
            this.btnMenuCadOperadores.Text = "Operadores";
            this.btnMenuCadOperadores.Click += new System.EventHandler(this.btnMenuCadOperadores_Click);
            // 
            // btnMenuCadClientes
            // 
            this.btnMenuCadClientes.Image = global::OPS_OphellSystem.Properties.Resources.Clientes32x32;
            this.btnMenuCadClientes.Name = "btnMenuCadClientes";
            this.btnMenuCadClientes.Size = new System.Drawing.Size(199, 22);
            this.btnMenuCadClientes.Text = "Clientes";
            this.btnMenuCadClientes.Click += new System.EventHandler(this.btnMenuCadClientes_Click);
            // 
            // btnMenuCadCategorias
            // 
            this.btnMenuCadCategorias.Image = global::OPS_OphellSystem.Properties.Resources.produtos32x32;
            this.btnMenuCadCategorias.Name = "btnMenuCadCategorias";
            this.btnMenuCadCategorias.Size = new System.Drawing.Size(199, 22);
            this.btnMenuCadCategorias.Text = "Categorias";
            this.btnMenuCadCategorias.Click += new System.EventHandler(this.btnMenuCadCategorias_Click);
            // 
            // btnMenuCondicoesPagamento
            // 
            this.btnMenuCondicoesPagamento.Image = global::OPS_OphellSystem.Properties.Resources.CondicoesDePagamento;
            this.btnMenuCondicoesPagamento.Name = "btnMenuCondicoesPagamento";
            this.btnMenuCondicoesPagamento.Size = new System.Drawing.Size(199, 22);
            this.btnMenuCondicoesPagamento.Text = "Condições Pagamentos";
            this.btnMenuCondicoesPagamento.Click += new System.EventHandler(this.btnMenuCondicoesPagamento_Click);
            // 
            // btnMenuContasPagar
            // 
            this.btnMenuContasPagar.Image = global::OPS_OphellSystem.Properties.Resources.PagamentoPadrao32x32;
            this.btnMenuContasPagar.Name = "btnMenuContasPagar";
            this.btnMenuContasPagar.Size = new System.Drawing.Size(199, 22);
            this.btnMenuContasPagar.Text = "Contas a Pagar";
            this.btnMenuContasPagar.Click += new System.EventHandler(this.btnMenuContasPagar_Click);
            // 
            // btnMenuContasReceber
            // 
            this.btnMenuContasReceber.Image = global::OPS_OphellSystem.Properties.Resources.RecebimentoPadrao32x32;
            this.btnMenuContasReceber.Name = "btnMenuContasReceber";
            this.btnMenuContasReceber.Size = new System.Drawing.Size(199, 22);
            this.btnMenuContasReceber.Text = "Contas a Receber";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OPS_OphellSystem.Properties.Resources.LogoOphell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.tStrpCadastroClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "Menu";
            this.Text = "OPHELL - Sistema de Gestão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MdiChildActivate += new System.EventHandler(this.Menu_MdiChildActivate);
            this.tStrpCadastroClientes.ResumeLayout(false);
            this.tStrpCadastroClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrpCadastroClientes;
        private System.Windows.Forms.ToolStripSplitButton btnMenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCadFornecedores;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCadOperadores;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCadCategorias;
        private System.Windows.Forms.ToolStripMenuItem btnMenuCondicoesPagamento;
        private System.Windows.Forms.ToolStripMenuItem btnMenuContasPagar;
        private System.Windows.Forms.ToolStripMenuItem btnMenuContasReceber;
    }
}