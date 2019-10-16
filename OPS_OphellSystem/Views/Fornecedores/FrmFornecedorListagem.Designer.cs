namespace OPS_OphellSystem.Cadastros.Views.Fornecedores
{
    partial class FrmFornecedorListagem
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
            this.lblTitulo = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.btnExcluir = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtPesquisa = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnFechar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAdicionar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.grdFornecedorListagem = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFornecedorListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43))))), System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29))))));
            this.lblTitulo.BeforeTouchSize = new System.Drawing.Size(201, 52);
            this.lblTitulo.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.lblTitulo.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 52);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Fornecedores\r\nListagem";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExcluir.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::OPS_OphellSystem.Properties.Resources.ExcluirPadrao32x32;
            this.btnExcluir.IsBackStageButton = false;
            this.btnExcluir.KeepFocusRectangle = false;
            this.btnExcluir.Location = new System.Drawing.Point(858, 12);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnExcluir.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisa.BeforeTouchSize = new System.Drawing.Size(490, 40);
            this.txtPesquisa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.CornerRadius = 5;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPesquisa.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtPesquisa.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.txtPesquisa.Location = new System.Drawing.Point(267, 12);
            this.txtPesquisa.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPesquisa.MinimumSize = new System.Drawing.Size(14, 40);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.NearImage = global::OPS_OphellSystem.Properties.Resources.Pesquisa32x32;
            this.txtPesquisa.Size = new System.Drawing.Size(490, 40);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.UseBorderColorOnFocus = true;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::OPS_OphellSystem.Properties.Resources.FecharPadrao32x32;
            this.btnFechar.IsBackStageButton = false;
            this.btnFechar.KeepFocusRectangle = false;
            this.btnFechar.Location = new System.Drawing.Point(972, 12);
            this.btnFechar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnFechar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnFechar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdicionar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::OPS_OphellSystem.Properties.Resources.Adicionar32x32;
            this.btnAdicionar.IsBackStageButton = false;
            this.btnAdicionar.KeepFocusRectangle = false;
            this.btnAdicionar.Location = new System.Drawing.Point(763, 12);
            this.btnAdicionar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grdFornecedorListagem
            // 
            this.grdFornecedorListagem.AccessibleName = "Table";
            this.grdFornecedorListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFornecedorListagem.Location = new System.Drawing.Point(12, 90);
            this.grdFornecedorListagem.Name = "grdFornecedorListagem";
            this.grdFornecedorListagem.Size = new System.Drawing.Size(1000, 502);
            this.grdFornecedorListagem.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.grdFornecedorListagem.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdFornecedorListagem.Style.RowHeaderStyle.SelectionMarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdFornecedorListagem.TabIndex = 10;
            this.grdFornecedorListagem.Text = "sfDataGrid1";
            this.grdFornecedorListagem.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.grdFornecedorListagem_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::OPS_OphellSystem.Properties.Resources.Ajuda;
            this.button1.Location = new System.Drawing.Point(926, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFornecedorListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdFornecedorListagem);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFornecedorListagem";
            this.Text = "FrmFornecedorListagem";
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFornecedorListagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTitulo;
        private Syncfusion.Windows.Forms.ButtonAdv btnExcluir;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPesquisa;
        private Syncfusion.Windows.Forms.ButtonAdv btnFechar;
        private Syncfusion.Windows.Forms.ButtonAdv btnAdicionar;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grdFornecedorListagem;
        private System.Windows.Forms.Button button1;
    }
}