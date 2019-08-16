namespace OPS_OphellSystem.Cadastros.Views.CategoriasDeProdutos
{
    partial class FrmBuscaCategoriaProduto
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
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn3 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn4 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.btnVoltar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.dtGridCategoriaProduto = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCategoriaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::OPS_OphellSystem.Properties.Resources.Voltar32x32;
            this.btnVoltar.IsBackStageButton = false;
            this.btnVoltar.Location = new System.Drawing.Point(712, 16);
            this.btnVoltar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 40);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtGridCategoriaProduto
            // 
            this.dtGridCategoriaProduto.AccessibleName = "Table";
            this.dtGridCategoriaProduto.AllowEditing = false;
            this.dtGridCategoriaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridCategoriaProduto.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dtGridCategoriaProduto.BackColor = System.Drawing.Color.White;
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.HeaderText = "ID";
            gridTextColumn1.MappingName = "id_prod";
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn2.HeaderText = "Código";
            gridTextColumn2.MappingName = "codigo_prod";
            gridTextColumn3.AllowEditing = false;
            gridTextColumn3.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn3.HeaderText = "Categoria";
            gridTextColumn3.MappingName = "categoria_prod";
            gridTextColumn4.AllowEditing = false;
            gridTextColumn4.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn4.HeaderText = "Descrição";
            gridTextColumn4.MappingName = "desc_prod";
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn5.HeaderText = "Cor";
            gridTextColumn5.MappingName = "cor_prod";
            gridTextColumn6.AllowEditing = false;
            gridTextColumn6.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn6.HeaderText = "Status";
            gridTextColumn6.MappingName = "status_prod";
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn1);
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn2);
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn3);
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn4);
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn5);
            this.dtGridCategoriaProduto.Columns.Add(gridTextColumn6);
            this.dtGridCategoriaProduto.Location = new System.Drawing.Point(24, 120);
            this.dtGridCategoriaProduto.Name = "dtGridCategoriaProduto";
            this.dtGridCategoriaProduto.Size = new System.Drawing.Size(744, 304);
            this.dtGridCategoriaProduto.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.dtGridCategoriaProduto.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::OPS_OphellSystem.Properties.Resources.Buscar32x32;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(16, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Buscar Categoria";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.UseCompatibleTextRendering = true;
            // 
            // FrmBuscaCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtGridCategoriaProduto);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscaCategoriaProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuscaCategoriaProduto_FormClosing);
            this.Shown += new System.EventHandler(this.FrmBuscaCategoriaProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCategoriaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnVoltar;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dtGridCategoriaProduto;
        private System.Windows.Forms.Label lblTitulo;
    }
}