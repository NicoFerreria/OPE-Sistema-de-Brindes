namespace Views.Modelos
{
    partial class FrmBusca
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
            this.cmbFiltro = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtCriterio = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnPesquisar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.grdResultados = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnConfirma = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lblFiltro = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblCriterio = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCriterio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.White;
            this.cmbFiltro.BeforeTouchSize = new System.Drawing.Size(249, 23);
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.Location = new System.Drawing.Point(12, 53);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(249, 23);
            this.cmbFiltro.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbFiltro.TabIndex = 0;
            // 
            // txtCriterio
            // 
            this.txtCriterio.BeforeTouchSize = new System.Drawing.Size(450, 23);
            this.txtCriterio.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterio.Location = new System.Drawing.Point(267, 53);
            this.txtCriterio.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(450, 23);
            this.txtCriterio.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = global::OPS_OphellSystem.Properties.Resources.BuscarPadrao28x28;
            this.btnPesquisar.IsBackStageButton = false;
            this.btnPesquisar.Location = new System.Drawing.Point(748, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(40, 40);
            this.btnPesquisar.TabIndex = 2;
            // 
            // grdResultados
            // 
            this.grdResultados.AccessibleName = "Table";
            this.grdResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResultados.Location = new System.Drawing.Point(12, 105);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.Size = new System.Drawing.Size(776, 284);
            this.grdResultados.TabIndex = 3;
            this.grdResultados.Text = "sfDataGrid1";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirma.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirma.IsBackStageButton = false;
            this.btnConfirma.Location = new System.Drawing.Point(339, 398);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(130, 40);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirma";
            // 
            // lblFiltro
            // 
            this.lblFiltro.DY = -22;
            this.lblFiltro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.LabeledControl = this.cmbFiltro;
            this.lblFiltro.Location = new System.Drawing.Point(12, 31);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblFiltro.Size = new System.Drawing.Size(73, 18);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtrar por";
            // 
            // autoLabel2
            // 
            this.autoLabel2.DY = -22;
            this.autoLabel2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.LabeledControl = this.grdResultados;
            this.autoLabel2.Location = new System.Drawing.Point(12, 83);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel2.Size = new System.Drawing.Size(83, 18);
            this.autoLabel2.TabIndex = 6;
            this.autoLabel2.Text = "Resultados";
            // 
            // lblCriterio
            // 
            this.lblCriterio.DY = -22;
            this.lblCriterio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.LabeledControl = this.txtCriterio;
            this.lblCriterio.Location = new System.Drawing.Point(267, 31);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblCriterio.Size = new System.Drawing.Size(122, 18);
            this.lblCriterio.TabIndex = 8;
            this.lblCriterio.Text = "Critério da busca";
            // 
            // FrmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.grdResultados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.cmbFiltro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCriterio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFiltro;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt txtCriterio;
        public Syncfusion.Windows.Forms.ButtonAdv btnPesquisar;
        public Syncfusion.WinForms.DataGrid.SfDataGrid grdResultados;
        public Syncfusion.Windows.Forms.ButtonAdv btnConfirma;
        public Syncfusion.Windows.Forms.Tools.AutoLabel lblFiltro;
        public Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        public Syncfusion.Windows.Forms.Tools.AutoLabel lblCriterio;
    }
}