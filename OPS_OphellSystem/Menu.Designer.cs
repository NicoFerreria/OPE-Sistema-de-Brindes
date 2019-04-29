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
            this.tStrpBtnCadastroClientes = new System.Windows.Forms.ToolStripButton();
            this.tStrpCadastroClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrpCadastroClientes
            // 
            this.tStrpCadastroClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.tStrpCadastroClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tStrpCadastroClientes.GripMargin = new System.Windows.Forms.Padding(0);
            this.tStrpCadastroClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStrpCadastroClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrpBtnCadastroClientes});
            this.tStrpCadastroClientes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tStrpCadastroClientes.Location = new System.Drawing.Point(0, 0);
            this.tStrpCadastroClientes.MaximumSize = new System.Drawing.Size(0, 40);
            this.tStrpCadastroClientes.MinimumSize = new System.Drawing.Size(0, 40);
            this.tStrpCadastroClientes.Name = "tStrpCadastroClientes";
            this.tStrpCadastroClientes.Size = new System.Drawing.Size(1008, 40);
            this.tStrpCadastroClientes.TabIndex = 1;
            this.tStrpCadastroClientes.Text = "Cadastro de Clientes";
            // 
            // tStrpBtnCadastroClientes
            // 
            this.tStrpBtnCadastroClientes.AutoSize = false;
            this.tStrpBtnCadastroClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStrpBtnCadastroClientes.Image = ((System.Drawing.Image)(resources.GetObject("tStrpBtnCadastroClientes.Image")));
            this.tStrpBtnCadastroClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrpBtnCadastroClientes.Name = "tStrpBtnCadastroClientes";
            this.tStrpBtnCadastroClientes.Size = new System.Drawing.Size(40, 37);
            this.tStrpBtnCadastroClientes.Click += new System.EventHandler(this.tStrpBtnCadastroClientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tStrpCadastroClientes);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tStrpCadastroClientes.ResumeLayout(false);
            this.tStrpCadastroClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrpCadastroClientes;
        private System.Windows.Forms.ToolStripButton tStrpBtnCadastroClientes;
    }
}