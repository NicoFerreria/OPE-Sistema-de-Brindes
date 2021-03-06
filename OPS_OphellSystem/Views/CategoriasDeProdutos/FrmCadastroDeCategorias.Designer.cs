﻿namespace Views
{
    partial class FrmCadastroDeCategorias
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer toggleButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.ToggleButtonRenderer();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            this.grpDadosCategoria = new System.Windows.Forms.GroupBox();
            this.lblCodigoCategoria = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCodigoCategria = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbCor = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblTxtDescricao = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtObservacao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTxtCor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblTxtCategoria = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtCategoria = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTxtId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbCriterioPesquisa = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.txtFiltrar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblListagem = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.grdListagemProdutos = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnBuscar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tgBtnStatus = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.btnNovoProduto = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVoltar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGravar = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnExcluir = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new System.Windows.Forms.Button();
            this.grpDadosCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCategria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCriterioPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListagemProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgBtnStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDadosCategoria
            // 
            this.grpDadosCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDadosCategoria.BackColor = System.Drawing.Color.White;
            this.grpDadosCategoria.Controls.Add(this.lblCodigoCategoria);
            this.grpDadosCategoria.Controls.Add(this.txtCodigoCategria);
            this.grpDadosCategoria.Controls.Add(this.cmbCor);
            this.grpDadosCategoria.Controls.Add(this.lblTxtDescricao);
            this.grpDadosCategoria.Controls.Add(this.autoLabel1);
            this.grpDadosCategoria.Controls.Add(this.lblTxtCor);
            this.grpDadosCategoria.Controls.Add(this.lblTxtCategoria);
            this.grpDadosCategoria.Controls.Add(this.lblTxtId);
            this.grpDadosCategoria.Controls.Add(this.txtObservacao);
            this.grpDadosCategoria.Controls.Add(this.txtDescricao);
            this.grpDadosCategoria.Controls.Add(this.txtCategoria);
            this.grpDadosCategoria.Controls.Add(this.txtId);
            this.grpDadosCategoria.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosCategoria.Location = new System.Drawing.Point(12, 60);
            this.grpDadosCategoria.Name = "grpDadosCategoria";
            this.grpDadosCategoria.Size = new System.Drawing.Size(537, 530);
            this.grpDadosCategoria.TabIndex = 0;
            this.grpDadosCategoria.TabStop = false;
            this.grpDadosCategoria.Text = "Dados da Categoria";
            // 
            // lblCodigoCategoria
            // 
            this.lblCodigoCategoria.DY = -23;
            this.lblCodigoCategoria.LabeledControl = this.txtCodigoCategria;
            this.lblCodigoCategoria.Location = new System.Drawing.Point(109, 24);
            this.lblCodigoCategoria.Name = "lblCodigoCategoria";
            this.lblCodigoCategoria.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblCodigoCategoria.Size = new System.Drawing.Size(119, 19);
            this.lblCodigoCategoria.TabIndex = 11;
            this.lblCodigoCategoria.Text = "Código Produto";
            // 
            // txtCodigoCategria
            // 
            this.txtCodigoCategria.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtCodigoCategria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCategria.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtCodigoCategria.Location = new System.Drawing.Point(109, 47);
            this.txtCodigoCategria.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCodigoCategria.Name = "txtCodigoCategria";
            this.txtCodigoCategria.Size = new System.Drawing.Size(136, 27);
            this.txtCodigoCategria.TabIndex = 2;
            this.txtCodigoCategria.UseBorderColorOnFocus = true;
            this.txtCodigoCategria.TextChanged += new System.EventHandler(this.txtCodigoCategria_TextChanged);
            this.txtCodigoCategria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCategria_KeyPress);
            // 
            // cmbCor
            // 
            this.cmbCor.AllowNewText = false;
            this.cmbCor.AutoComplete = false;
            this.cmbCor.BackColor = System.Drawing.Color.White;
            this.cmbCor.BeforeTouchSize = new System.Drawing.Size(507, 27);
            this.cmbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCor.FlatBorderColor = System.Drawing.Color.Black;
            this.cmbCor.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.Flat;
            this.cmbCor.Location = new System.Drawing.Point(24, 221);
            this.cmbCor.MetroBorderColor = System.Drawing.Color.Black;
            this.cmbCor.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(507, 27);
            this.cmbCor.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbCor.TabIndex = 4;
            // 
            // lblTxtDescricao
            // 
            this.lblTxtDescricao.DY = -23;
            this.lblTxtDescricao.LabeledControl = this.txtObservacao;
            this.lblTxtDescricao.Location = new System.Drawing.Point(24, 251);
            this.lblTxtDescricao.Name = "lblTxtDescricao";
            this.lblTxtDescricao.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTxtDescricao.Size = new System.Drawing.Size(93, 19);
            this.lblTxtDescricao.TabIndex = 9;
            this.lblTxtDescricao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtObservacao.Location = new System.Drawing.Point(24, 274);
            this.txtObservacao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(507, 107);
            this.txtObservacao.TabIndex = 6;
            this.txtObservacao.UseBorderColorOnFocus = true;
            // 
            // autoLabel1
            // 
            this.autoLabel1.DY = -23;
            this.autoLabel1.LabeledControl = this.txtDescricao;
            this.autoLabel1.Location = new System.Drawing.Point(24, 136);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.autoLabel1.Size = new System.Drawing.Size(79, 19);
            this.autoLabel1.TabIndex = 8;
            this.autoLabel1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtDescricao.Location = new System.Drawing.Point(24, 159);
            this.txtDescricao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(507, 27);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.UseBorderColorOnFocus = true;
            // 
            // lblTxtCor
            // 
            this.lblTxtCor.DY = -23;
            this.lblTxtCor.LabeledControl = this.cmbCor;
            this.lblTxtCor.Location = new System.Drawing.Point(24, 198);
            this.lblTxtCor.Name = "lblTxtCor";
            this.lblTxtCor.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTxtCor.Size = new System.Drawing.Size(33, 19);
            this.lblTxtCor.TabIndex = 7;
            this.lblTxtCor.Text = "Cor";
            // 
            // lblTxtCategoria
            // 
            this.lblTxtCategoria.DY = -23;
            this.lblTxtCategoria.LabeledControl = this.txtCategoria;
            this.lblTxtCategoria.Location = new System.Drawing.Point(24, 81);
            this.lblTxtCategoria.Name = "lblTxtCategoria";
            this.lblTxtCategoria.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTxtCategoria.Size = new System.Drawing.Size(51, 19);
            this.lblTxtCategoria.TabIndex = 6;
            this.lblTxtCategoria.Text = "Nome";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtCategoria.Location = new System.Drawing.Point(24, 104);
            this.txtCategoria.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(507, 27);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.UseBorderColorOnFocus = true;
            // 
            // lblTxtId
            // 
            this.lblTxtId.DY = -23;
            this.lblTxtId.LabeledControl = this.txtId;
            this.lblTxtId.Location = new System.Drawing.Point(24, 24);
            this.lblTxtId.Name = "lblTxtId";
            this.lblTxtId.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblTxtId.Size = new System.Drawing.Size(24, 19);
            this.lblTxtId.TabIndex = 5;
            this.lblTxtId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtId.Location = new System.Drawing.Point(24, 47);
            this.txtId.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(79, 27);
            this.txtId.TabIndex = 1;
            this.txtId.TabStop = false;
            // 
            // cmbCriterioPesquisa
            // 
            this.cmbCriterioPesquisa.BackColor = System.Drawing.Color.White;
            this.cmbCriterioPesquisa.BeforeTouchSize = new System.Drawing.Size(220, 21);
            this.cmbCriterioPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioPesquisa.Location = new System.Drawing.Point(555, 84);
            this.cmbCriterioPesquisa.Name = "cmbCriterioPesquisa";
            this.cmbCriterioPesquisa.Size = new System.Drawing.Size(220, 21);
            this.cmbCriterioPesquisa.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmbCriterioPesquisa.TabIndex = 15;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.BeforeTouchSize = new System.Drawing.Size(169, 20);
            this.txtFiltrar.Location = new System.Drawing.Point(781, 85);
            this.txtFiltrar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(169, 20);
            this.txtFiltrar.TabIndex = 14;
            this.txtFiltrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyDown);
            // 
            // lblListagem
            // 
            this.lblListagem.DY = -17;
            this.lblListagem.LabeledControl = this.grdListagemProdutos;
            this.lblListagem.Location = new System.Drawing.Point(555, 124);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Top;
            this.lblListagem.Size = new System.Drawing.Size(213, 13);
            this.lblListagem.TabIndex = 13;
            this.lblListagem.Text = "Listagem (Del - Exclui Produto Selecionado)";
            // 
            // grdListagemProdutos
            // 
            this.grdListagemProdutos.AccessibleName = "Table";
            this.grdListagemProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListagemProdutos.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.grdListagemProdutos.Location = new System.Drawing.Point(555, 141);
            this.grdListagemProdutos.Name = "grdListagemProdutos";
            this.grdListagemProdutos.Size = new System.Drawing.Size(442, 449);
            this.grdListagemProdutos.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.grdListagemProdutos.Style.CurrentCellStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdListagemProdutos.Style.RowHeaderStyle.SelectionMarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.grdListagemProdutos.TabIndex = 12;
            this.grdListagemProdutos.Text = "sfDataGrid1";
            this.grdListagemProdutos.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.grdListagemProdutos_CellDoubleClick);
            this.grdListagemProdutos.CurrentCellKeyDown += new Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventHandler(this.grdListagemProdutos_CurrentCellKeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::OPS_OphellSystem.Properties.Resources.BuscarPadrao28x28;
            this.btnBuscar.IsBackStageButton = false;
            this.btnBuscar.Location = new System.Drawing.Point(956, 72);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tgBtnStatus
            // 
            activeStateCollection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            activeStateCollection1.BorderColor = System.Drawing.Color.Black;
            activeStateCollection1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            activeStateCollection1.Text = "Desativar";
            this.tgBtnStatus.ActiveState = activeStateCollection1;
            this.tgBtnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgBtnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgBtnStatus.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            inactiveStateCollection1.BorderColor = System.Drawing.Color.Black;
            inactiveStateCollection1.ForeColor = System.Drawing.Color.White;
            inactiveStateCollection1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            inactiveStateCollection1.Text = "Ativar";
            this.tgBtnStatus.InactiveState = inactiveStateCollection1;
            this.tgBtnStatus.Location = new System.Drawing.Point(12, 12);
            this.tgBtnStatus.MinimumSize = new System.Drawing.Size(52, 20);
            this.tgBtnStatus.Name = "tgBtnStatus";
            this.tgBtnStatus.Renderer = toggleButtonRenderer1;
            this.tgBtnStatus.Size = new System.Drawing.Size(114, 24);
            this.tgBtnStatus.Slider = sliderCollection1;
            this.tgBtnStatus.TabIndex = 10;
            this.tgBtnStatus.Text = "toggleButton1";
            this.tgBtnStatus.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
            this.tgBtnStatus.VisualStyle = Syncfusion.Windows.Forms.Tools.ToggleButtonStyle.Default;
            this.tgBtnStatus.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.tgBtnStatus_ToggleStateChanged);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnNovoProduto.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.btnNovoProduto.Image = global::OPS_OphellSystem.Properties.Resources.LimparBrancoPadrao28x28;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.IsBackStageButton = false;
            this.btnNovoProduto.Location = new System.Drawing.Point(465, 609);
            this.btnNovoProduto.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnNovoProduto.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(130, 40);
            this.btnNovoProduto.TabIndex = 7;
            this.btnNovoProduto.Text = "Novo (Ctrl+N)";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = global::OPS_OphellSystem.Properties.Resources.FecharPadrao32x32;
            this.btnVoltar.IsBackStageButton = false;
            this.btnVoltar.Location = new System.Drawing.Point(956, 12);
            this.btnVoltar.MaximumSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.MinimumSize = new System.Drawing.Size(40, 40);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 40);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.btnGravar.Location = new System.Drawing.Point(329, 609);
            this.btnGravar.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnGravar.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(130, 40);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Salvar (Ctrl+S)";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.BackColor = System.Drawing.Color.Brown;
            this.btnExcluir.BeforeTouchSize = new System.Drawing.Size(130, 40);
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = global::OPS_OphellSystem.Properties.Resources.ExcluirBrancoPadrao28x28;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.IsBackStageButton = false;
            this.btnExcluir.Location = new System.Drawing.Point(601, 609);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(130, 40);
            this.btnExcluir.MinimumSize = new System.Drawing.Size(130, 40);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 40);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir (F8)";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::OPS_OphellSystem.Properties.Resources.Ajuda;
            this.button1.Location = new System.Drawing.Point(910, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroDeCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.cmbCriterioPesquisa);
            this.Controls.Add(this.tgBtnStatus);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.lblListagem);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grdListagemProdutos);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grpDadosCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCadastroDeCategorias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Categorias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroDeCategorias_FormClosing);
            this.Shown += new System.EventHandler(this.FrmCadastroDeCategorias_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroDeCategorias_KeyDown);
            this.grpDadosCategoria.ResumeLayout(false);
            this.grpDadosCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCategria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCriterioPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListagemProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgBtnStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosCategoria;
        private Syncfusion.Windows.Forms.ButtonAdv btnGravar;
        private Syncfusion.Windows.Forms.ButtonAdv btnBuscar;
        private Syncfusion.Windows.Forms.ButtonAdv btnVoltar;
        private Syncfusion.Windows.Forms.ButtonAdv btnNovoProduto;
        private Syncfusion.Windows.Forms.Tools.ToggleButton tgBtnStatus;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtObservacao;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescricao;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCategoria;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTxtId;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTxtCategoria;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTxtCor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbCor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblTxtDescricao;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblCodigoCategoria;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCodigoCategria;
        private Syncfusion.WinForms.DataGrid.SfDataGrid grdListagemProdutos;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblListagem;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFiltrar;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbCriterioPesquisa;
        private Syncfusion.Windows.Forms.ButtonAdv btnExcluir;
        private System.Windows.Forms.Button button1;
    }
}