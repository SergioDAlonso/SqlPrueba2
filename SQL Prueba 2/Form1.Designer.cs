namespace SQL_Prueba_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVDiscos = new System.Windows.Forms.DataGridView();
            this.pBxTapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDiscos
            // 
            this.dGVDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDiscos.Location = new System.Drawing.Point(12, 12);
            this.dGVDiscos.Name = "dGVDiscos";
            this.dGVDiscos.Size = new System.Drawing.Size(552, 214);
            this.dGVDiscos.TabIndex = 0;
            this.dGVDiscos.SelectionChanged += new System.EventHandler(this.dGVDiscos_SelectionChanged);
            // 
            // pBxTapa
            // 
            this.pBxTapa.Location = new System.Drawing.Point(570, 12);
            this.pBxTapa.Name = "pBxTapa";
            this.pBxTapa.Size = new System.Drawing.Size(218, 214);
            this.pBxTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxTapa.TabIndex = 1;
            this.pBxTapa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBxTapa);
            this.Controls.Add(this.dGVDiscos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBxTapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDiscos;
        private System.Windows.Forms.PictureBox pBxTapa;
    }
}

