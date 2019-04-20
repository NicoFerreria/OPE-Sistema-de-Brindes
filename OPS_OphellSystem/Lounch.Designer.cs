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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lounch));
            this.txtOperador = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.bnTxtOperador = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.btnSair = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOperador
            // 
            this.txtOperador.AcceptsTab = true;
            this.txtOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtOperador.BeforeTouchSize = new System.Drawing.Size(216, 27);
            this.txtOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOperador.CornerRadius = 10;
            this.txtOperador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOperador.FocusBorderColor = System.Drawing.Color.White;
            this.txtOperador.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador.ForeColor = System.Drawing.Color.White;
            this.txtOperador.Location = new System.Drawing.Point(192, 192);
            this.txtOperador.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtOperador.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.OverflowIndicatorToolTipText = "Operador";
            this.txtOperador.Size = new System.Drawing.Size(216, 27);
            this.txtOperador.TabIndex = 1;
            this.txtOperador.UseBorderColorOnFocus = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.txtSenha.BeforeTouchSize = new System.Drawing.Size(216, 27);
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.CornerRadius = 10;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSenha.FocusBorderColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(192, 224);
            this.txtSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSenha.MinimumSize = new System.Drawing.Size(24, 20);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(216, 27);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.ThemesEnabled = false;
            this.txtSenha.UseBorderColorOnFocus = true;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BeforeTouchSize = new System.Drawing.Size(75, 40);
            this.btnLogin.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(43)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.IsBackStageButton = false;
            this.btnLogin.KeepFocusRectangle = false;
            this.btnLogin.Location = new System.Drawing.Point(256, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.btnSair.Location = new System.Drawing.Point(536, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 4;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Lounch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 300);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lounch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Lounch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtOperador;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSenha;
        private Syncfusion.Windows.Forms.ButtonAdv btnLogin;
        private Syncfusion.Windows.Forms.BannerTextProvider bnTxtOperador;
        private Syncfusion.Windows.Forms.ButtonAdv btnSair;
    }
}

