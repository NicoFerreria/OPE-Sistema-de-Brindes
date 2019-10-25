namespace Views
{
    partial class FrmCadastroPerfil
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
            this.txtId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.grdPerfis = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblDescricao = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnNovoOperador = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGravar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BeforeTouchSize = new System.Drawing.Size(195, 23);
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 38);
            this.txtId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 23);
            this.txtId.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BeforeTouchSize = new System.Drawing.Size(195, 23);
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(74, 38);
            this.txtDescricao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(195, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // grdPerfis
            // 
            this.grdPerfis.AccessibleName = "Table";
            this.grdPerfis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPerfis.Location = new System.Drawing.Point(12, 101);
            this.grdPerfis.Name = "grdPerfis";
            this.grdPerfis.Size = new System.Drawing.Size(776, 291);
            this.grdPerfis.TabIndex = 2;
            this.grdPerfis.Text = "sfDataGrid1";
            // 
            // lblId
            // 
            this.lblId.DY = -22;
            this.lblId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.LabeledControl = this.txtId;
            this.lblId.Location = new System.Drawing.Point(12, 16);
            this.lblId.Name = "lblId";
            this.lblId.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblId.Size = new System.Drawing.Size(22, 18);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // lblDescricao
            // 
            this.lblDescricao.DY = -22;
            this.lblDescricao.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.LabeledControl = this.txtDescricao;
            this.lblDescricao.Location = new System.Drawing.Point(74, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblDescricao.Size = new System.Drawing.Size(76, 18);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdv1.BackColor = System.Drawing.Color.Brown;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.buttonAdv1.Enabled = false;
            this.buttonAdv1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.buttonAdv1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = global::OPS_OphellSystem.Properties.Resources.ExcluirBrancoPadrao28x28;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(471, 398);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(130, 40);
            this.buttonAdv1.TabIndex = 15;
            this.buttonAdv1.Text = "Excluir (F8)";
            // 
            // btnNovoOperador
            // 
            this.btnNovoOperador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovoOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnNovoOperador.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnNovoOperador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnNovoOperador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnNovoOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoOperador.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoOperador.ForeColor = System.Drawing.Color.White;
            this.btnNovoOperador.Image = global::OPS_OphellSystem.Properties.Resources.LimparBrancoPadrao28x28;
            this.btnNovoOperador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoOperador.IsBackStageButton = false;
            this.btnNovoOperador.Location = new System.Drawing.Point(335, 398);
            this.btnNovoOperador.Name = "btnNovoOperador";
            this.btnNovoOperador.Size = new System.Drawing.Size(130, 40);
            this.btnNovoOperador.TabIndex = 13;
            this.btnNovoOperador.Text = "Novo (Ctrl+N)";
            this.btnNovoOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoOperador.Click += new System.EventHandler(this.btnNovoOperador_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGravar.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::OPS_OphellSystem.Properties.Resources.FinalizarBrancoPadrao28x28;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.IsBackStageButton = false;
            this.btnGravar.Location = new System.Drawing.Point(199, 398);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 40);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Salvar (Ctrl+S)";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.DY = -22;
            this.autoLabel1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.LabeledControl = this.grdPerfis;
            this.autoLabel1.Location = new System.Drawing.Point(12, 79);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel1.Size = new System.Drawing.Size(70, 18);
            this.autoLabel1.TabIndex = 16;
            this.autoLabel1.Text = "Listagem";
            // 
            // FrmCadastroPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.btnNovoOperador);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grdPerfis);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Name = "FrmCadastroPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Perfil de Usuário";
            this.Shown += new System.EventHandler(this.FrmCadastroPerfil_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroPerfil_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtId;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescricao;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grdPerfis;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDescricao;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv btnNovoOperador;
        private Syncfusion.Windows.Forms.ButtonAdv btnGravar;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}