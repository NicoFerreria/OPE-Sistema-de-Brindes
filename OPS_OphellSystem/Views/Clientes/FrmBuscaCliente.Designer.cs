namespace Views
{
    partial class FrmBuscaCliente
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCriterio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Size = new System.Drawing.Size(249, 23);
            // 
            // grdResultados
            // 
            this.grdResultados.Location = new System.Drawing.Point(12, 104);
            this.grdResultados.Size = new System.Drawing.Size(776, 285);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(12, 82);
            // 
            // FrmBuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmBuscaCliente";
            this.Text = "Bucar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuscaCliente_FormClosing);
            this.Shown += new System.EventHandler(this.FrmBuscaCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCriterio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}