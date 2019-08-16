namespace OPS_OphellSystem
{
    partial class Lounch
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lounch));
            this.txtSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.bnTxtOperador = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.pgbLoadSistema = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.mCmbOperadores = new Syncfusion.Windows.Forms.Tools.MultiColumnComboBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbLoadSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCmbOperadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BeforeTouchSize = new System.Drawing.Size(230, 27);
            this.txtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtSenha.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSenha.FocusBorderColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(371, 160);
            this.txtSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtSenha.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(230, 27);
            this.txtSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // pgbLoadSistema
            // 
            this.pgbLoadSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.pgbLoadSistema.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pgbLoadSistema.BackSegments = false;
            this.pgbLoadSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pgbLoadSistema.CustomText = null;
            this.pgbLoadSistema.CustomWaitingRender = false;
            this.pgbLoadSistema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbLoadSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.pgbLoadSistema.ForegroundImage = null;
            this.pgbLoadSistema.Location = new System.Drawing.Point(0, 287);
            this.pgbLoadSistema.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pgbLoadSistema.Name = "pgbLoadSistema";
            this.pgbLoadSistema.SegmentWidth = 12;
            this.pgbLoadSistema.Size = new System.Drawing.Size(613, 29);
            this.pgbLoadSistema.TabIndex = 5;
            this.pgbLoadSistema.TabStop = false;
            this.pgbLoadSistema.Text = "progressBarAdv1";
            this.pgbLoadSistema.ThemesEnabled = false;
            this.pgbLoadSistema.Value = 0;
            this.pgbLoadSistema.Visible = false;
            this.pgbLoadSistema.WaitingGradientWidth = 400;
            // 
            // mCmbOperadores
            // 
            this.mCmbOperadores.AllowNewText = false;
            this.mCmbOperadores.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.mCmbOperadores.BackColor = System.Drawing.Color.White;
            this.mCmbOperadores.BeforeTouchSize = new System.Drawing.Size(230, 21);
            this.mCmbOperadores.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.mCmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCmbOperadores.FlatBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mCmbOperadores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mCmbOperadores.Location = new System.Drawing.Point(371, 99);
            this.mCmbOperadores.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.mCmbOperadores.Name = "mCmbOperadores";
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.Empty;
            metroColorTable1.ArrowPushedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbCheckedBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbNormalBorderColor = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.Empty;
            metroColorTable1.ThumbPushedBorderColor = System.Drawing.Color.Empty;
            this.mCmbOperadores.ScrollMetroColorTable = metroColorTable1;
            this.mCmbOperadores.Size = new System.Drawing.Size(230, 21);
            this.mCmbOperadores.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.mCmbOperadores.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.ErrorImage = null;
            this.pctLogo.Image = global::OPS_OphellSystem.Properties.Resources.FundoLogin;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(365, 316);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 9;
            this.pctLogo.TabStop = false;
            this.pctLogo.WaitOnLoad = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BeforeTouchSize = new System.Drawing.Size(40, 40);
            this.btnSair.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.IsBackStageButton = false;
            this.btnSair.Location = new System.Drawing.Point(454, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BeforeTouchSize = new System.Drawing.Size(94, 40);
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::OPS_OphellSystem.Properties.Resources.Confirma28x28;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.IsBackStageButton = false;
            this.btnLogin.KeepFocusRectangle = false;
            this.btnLogin.Location = new System.Drawing.Point(431, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Lounch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(613, 316);
            this.Controls.Add(this.mCmbOperadores);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pgbLoadSistema);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lounch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Lounch_Load);
            this.Shown += new System.EventHandler(this.Lounch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbLoadSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCmbOperadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSenha;
        private Syncfusion.Windows.Forms.ButtonAdv btnLogin;
        private Syncfusion.Windows.Forms.BannerTextProvider bnTxtOperador;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pgbLoadSistema;
        private Syncfusion.Windows.Forms.Tools.MultiColumnComboBox mCmbOperadores;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}

