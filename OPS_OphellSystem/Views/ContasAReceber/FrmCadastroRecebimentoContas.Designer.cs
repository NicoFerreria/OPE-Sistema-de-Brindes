namespace OPS_OphellSystem.Cadastros.Views.ContasAReceber
{
    partial class FrmCadastroRecebimentoContas
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
            this.grpDadosConta = new System.Windows.Forms.GroupBox();
            this.grdContas = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.lblValor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtValorConta = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDataVencimento = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dtpVencimento = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.grpDadosPagamento = new System.Windows.Forms.GroupBox();
            this.lblFormasPagamento = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbFormasPagamento = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFornecedor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtFornecedor = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnAdicionarConta = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGravar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnFornecedor = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnNovoPagamento = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDadosConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVencimento)).BeginInit();
            this.grpDadosPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormasPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosConta
            // 
            this.grpDadosConta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosConta.Controls.Add(this.grdContas);
            this.grpDadosConta.Controls.Add(this.btnAdicionarConta);
            this.grpDadosConta.Controls.Add(this.lblValor);
            this.grpDadosConta.Controls.Add(this.lblDataVencimento);
            this.grpDadosConta.Controls.Add(this.dtpVencimento);
            this.grpDadosConta.Controls.Add(this.txtValorConta);
            this.grpDadosConta.Location = new System.Drawing.Point(12, 136);
            this.grpDadosConta.Name = "grpDadosConta";
            this.grpDadosConta.Size = new System.Drawing.Size(984, 428);
            this.grpDadosConta.TabIndex = 5;
            this.grpDadosConta.TabStop = false;
            this.grpDadosConta.Text = "Dados da Conta";
            // 
            // grdContas
            // 
            this.grdContas.AccessibleName = "Table";
            this.grdContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdContas.Location = new System.Drawing.Point(6, 116);
            this.grdContas.Name = "grdContas";
            this.grdContas.Size = new System.Drawing.Size(972, 293);
            this.grdContas.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.grdContas.TabIndex = 8;
            this.grdContas.Text = "sfDataGrid1";
            // 
            // lblValor
            // 
            this.lblValor.DY = -17;
            this.lblValor.LabeledControl = this.txtValorConta;
            this.lblValor.Location = new System.Drawing.Point(268, 45);
            this.lblValor.Name = "lblValor";
            this.lblValor.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // txtValorConta
            // 
            this.txtValorConta.BeforeTouchSize = new System.Drawing.Size(490, 40);
            this.txtValorConta.Location = new System.Drawing.Point(268, 62);
            this.txtValorConta.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(100, 20);
            this.txtValorConta.TabIndex = 2;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.DY = -17;
            this.lblDataVencimento.LabeledControl = this.dtpVencimento;
            this.lblDataVencimento.Location = new System.Drawing.Point(30, 45);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblDataVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblDataVencimento.TabIndex = 5;
            this.lblDataVencimento.Text = "Vencimento";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtpVencimento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dtpVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpVencimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimento.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtpVencimento.Checked = false;
            this.dtpVencimento.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.dtpVencimento.DropDownImage = null;
            this.dtpVencimento.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.dtpVencimento.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.dtpVencimento.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(175)))), ((int)(((byte)(85)))));
            this.dtpVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimento.Location = new System.Drawing.Point(30, 62);
            this.dtpVencimento.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.dtpVencimento.MinValue = new System.DateTime(((long)(0)));
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.ShowCheckBox = false;
            this.dtpVencimento.Size = new System.Drawing.Size(232, 20);
            this.dtpVencimento.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dtpVencimento.TabIndex = 4;
            this.dtpVencimento.Value = new System.DateTime(2019, 8, 31, 21, 26, 55, 909);
            // 
            // grpDadosPagamento
            // 
            this.grpDadosPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosPagamento.Controls.Add(this.btnFornecedor);
            this.grpDadosPagamento.Controls.Add(this.lblFormasPagamento);
            this.grpDadosPagamento.Controls.Add(this.cmbFormasPagamento);
            this.grpDadosPagamento.Controls.Add(this.lblFornecedor);
            this.grpDadosPagamento.Controls.Add(this.txtFornecedor);
            this.grpDadosPagamento.Controls.Add(this.lblId);
            this.grpDadosPagamento.Controls.Add(this.txtId);
            this.grpDadosPagamento.Location = new System.Drawing.Point(12, 43);
            this.grpDadosPagamento.Name = "grpDadosPagamento";
            this.grpDadosPagamento.Size = new System.Drawing.Size(984, 90);
            this.grpDadosPagamento.TabIndex = 4;
            this.grpDadosPagamento.TabStop = false;
            this.grpDadosPagamento.Text = "Dados do Pagamento";
            // 
            // lblFormasPagamento
            // 
            this.lblFormasPagamento.DY = -17;
            this.lblFormasPagamento.LabeledControl = this.cmbFormasPagamento;
            this.lblFormasPagamento.Location = new System.Drawing.Point(538, 33);
            this.lblFormasPagamento.Name = "lblFormasPagamento";
            this.lblFormasPagamento.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblFormasPagamento.Size = new System.Drawing.Size(108, 13);
            this.lblFormasPagamento.TabIndex = 5;
            this.lblFormasPagamento.Text = "Forma de Pagamento";
            // 
            // cmbFormasPagamento
            // 
            this.cmbFormasPagamento.BackColor = System.Drawing.Color.White;
            this.cmbFormasPagamento.BeforeTouchSize = new System.Drawing.Size(260, 21);
            this.cmbFormasPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormasPagamento.Location = new System.Drawing.Point(538, 50);
            this.cmbFormasPagamento.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.cmbFormasPagamento.Name = "cmbFormasPagamento";
            this.cmbFormasPagamento.Size = new System.Drawing.Size(260, 21);
            this.cmbFormasPagamento.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbFormasPagamento.TabIndex = 4;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.DY = -17;
            this.lblFornecedor.LabeledControl = this.txtFornecedor;
            this.lblFornecedor.Location = new System.Drawing.Point(112, 33);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.BeforeTouchSize = new System.Drawing.Size(490, 40);
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(112, 50);
            this.txtFornecedor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(375, 20);
            this.txtFornecedor.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.DY = -17;
            this.lblId.LabeledControl = this.txtId;
            this.lblId.Location = new System.Drawing.Point(6, 33);
            this.lblId.Name = "lblId";
            this.lblId.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Control;
            this.txtId.BeforeTouchSize = new System.Drawing.Size(490, 40);
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 50);
            this.txtId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.BeforeTouchSize = new System.Drawing.Size(30, 30);
            this.btnAdicionarConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarConta.FlatAppearance.BorderSize = 0;
            this.btnAdicionarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnAdicionarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarConta.Image = global::OPS_OphellSystem.Properties.Resources.AdicionarPadrao28x28;
            this.btnAdicionarConta.IsBackStageButton = false;
            this.btnAdicionarConta.KeepFocusRectangle = false;
            this.btnAdicionarConta.Location = new System.Drawing.Point(374, 52);
            this.btnAdicionarConta.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnAdicionarConta.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(30, 30);
            this.btnAdicionarConta.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGravar.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::OPS_OphellSystem.Properties.Resources.FinalizarBrancoPadrao28x28;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.IsBackStageButton = false;
            this.btnGravar.Location = new System.Drawing.Point(405, 573);
            this.btnGravar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGravar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 40);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Salvar (Ctrl + S)";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BeforeTouchSize = new System.Drawing.Size(30, 30);
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Image = global::OPS_OphellSystem.Properties.Resources.BuscarPadrao28x28;
            this.btnFornecedor.IsBackStageButton = false;
            this.btnFornecedor.KeepFocusRectangle = false;
            this.btnFornecedor.Location = new System.Drawing.Point(493, 41);
            this.btnFornecedor.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnFornecedor.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(30, 30);
            this.btnFornecedor.TabIndex = 6;
            // 
            // btnNovoPagamento
            // 
            this.btnNovoPagamento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnNovoPagamento.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnNovoPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPagamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnNovoPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnNovoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPagamento.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPagamento.ForeColor = System.Drawing.Color.White;
            this.btnNovoPagamento.Image = global::OPS_OphellSystem.Properties.Resources.LimparBrancoPadrao28x28;
            this.btnNovoPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoPagamento.IsBackStageButton = false;
            this.btnNovoPagamento.Location = new System.Drawing.Point(541, 573);
            this.btnNovoPagamento.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnNovoPagamento.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnNovoPagamento.Name = "btnNovoPagamento";
            this.btnNovoPagamento.Size = new System.Drawing.Size(130, 40);
            this.btnNovoPagamento.TabIndex = 6;
            this.btnNovoPagamento.Text = "Novo (Ctrl + N)";
            this.btnNovoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::OPS_OphellSystem.Properties.Resources.Ajuda;
            this.button1.Location = new System.Drawing.Point(956, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroRecebimentoContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 621);
            this.Controls.Add(this.grpDadosPagamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpDadosConta);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovoPagamento);
            this.Name = "FrmCadastroRecebimentoContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contas a Receber";
            this.Load += new System.EventHandler(this.FrmCadastroRecebimentoContas_Load);
            this.grpDadosConta.ResumeLayout(false);
            this.grpDadosConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVencimento)).EndInit();
            this.grpDadosPagamento.ResumeLayout(false);
            this.grpDadosPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormasPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosConta;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grdContas;
        private Syncfusion.Windows.Forms.ButtonAdv btnAdicionarConta;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblValor;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtValorConta;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDataVencimento;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpVencimento;
        private Syncfusion.Windows.Forms.ButtonAdv btnGravar;
        private System.Windows.Forms.GroupBox grpDadosPagamento;
        private Syncfusion.Windows.Forms.ButtonAdv btnFornecedor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFormasPagamento;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFormasPagamento;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblFornecedor;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFornecedor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtId;
        private Syncfusion.Windows.Forms.ButtonAdv btnNovoPagamento;
        private System.Windows.Forms.Button button1;
    }
}