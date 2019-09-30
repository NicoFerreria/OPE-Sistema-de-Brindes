namespace OPS_OphellSystem.Cadastros.Views.Clientes
{
    partial class FrmClientesListagem
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
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.grdClienteListagem = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.sTip = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            this.btnExcluir = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtPesquisa = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnFechar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAdicionar = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.grdClienteListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClienteListagem
            // 
            this.grdClienteListagem.AccessibleName = "Table";
            this.grdClienteListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClienteListagem.Location = new System.Drawing.Point(12, 90);
            this.grdClienteListagem.Name = "grdClienteListagem";
            this.grdClienteListagem.Size = new System.Drawing.Size(1000, 502);
            this.grdClienteListagem.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.grdClienteListagem.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdClienteListagem.Style.RowHeaderStyle.SelectionMarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdClienteListagem.TabIndex = 2;
            this.grdClienteListagem.Text = "sfDataGrid1";
            this.grdClienteListagem.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.grdClienteListagem_CellDoubleClick);
            this.grdClienteListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdClienteListagem_KeyDown);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43))))), System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29))))));
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(201, 43);
            this.gradientLabel1.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.gradientLabel1.Location = new System.Drawing.Point(12, 9);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(201, 43);
            this.gradientLabel1.TabIndex = 4;
            this.gradientLabel1.Text = "Clientes Listagem";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTip
            // 
            this.sTip.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
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
            this.btnExcluir.TabIndex = 5;
            toolTipInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            toolTipInfo1.Body.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = "Excluir Cliente";
            toolTipInfo1.Footer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Footer.Text = "OPH";
            toolTipInfo1.Header.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo1.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Text = "Cliente";
            this.sTip.SetToolTip(this.btnExcluir, toolTipInfo1);
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
            this.txtPesquisa.TabIndex = 0;
            toolTipInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            toolTipInfo2.Body.ForeColor = System.Drawing.Color.Black;
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Body.Text = "Digite o CNPJ, Fantasia ou Razão social para pesquisa.\r\nPara Carregar todos, tecl" +
    "e enter com o campo vazio.";
            toolTipInfo2.BorderColor = System.Drawing.Color.Transparent;
            toolTipInfo2.Footer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Footer.Text = "OPH";
            toolTipInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo2.Header.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "Clientes";
            this.sTip.SetToolTip(this.txtPesquisa, toolTipInfo2);
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
            this.btnFechar.TabIndex = 3;
            toolTipInfo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            toolTipInfo3.Body.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Body.Text = "Fechar Listagem";
            toolTipInfo3.BorderColor = System.Drawing.Color.Transparent;
            toolTipInfo3.Footer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo3.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Footer.Text = "OPH";
            toolTipInfo3.Header.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo3.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo3.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo3.Header.Text = "Clientes";
            this.sTip.SetToolTip(this.btnFechar, toolTipInfo3);
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
            this.btnAdicionar.TabIndex = 1;
            toolTipInfo4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            toolTipInfo4.Body.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Body.Text = "Adicionar Cliente";
            toolTipInfo4.Footer.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo4.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Footer.Text = "OPH";
            toolTipInfo4.Header.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toolTipInfo4.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            toolTipInfo4.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo4.Header.Text = "Clientes";
            this.sTip.SetToolTip(this.btnAdicionar, toolTipInfo4);
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // FrmClientesListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.grdClienteListagem);
            this.Controls.Add(this.btnAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientesListagem";
            this.ShowInTaskbar = false;
            this.Text = "FrmClientesListagem";
            this.Shown += new System.EventHandler(this.FrmClientesListagem_Shown);
            this.VisibleChanged += new System.EventHandler(this.FrmClientesListagem_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grdClienteListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPesquisa;
        private Syncfusion.Windows.Forms.ButtonAdv btnAdicionar;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grdClienteListagem;
        private Syncfusion.Windows.Forms.ButtonAdv btnFechar;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip sTip;
        private Syncfusion.Windows.Forms.ButtonAdv btnExcluir;
    }
}