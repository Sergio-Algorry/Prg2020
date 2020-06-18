namespace EjemploWhile
{
    partial class EjemploWhile
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
            this.bt = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(6, 2);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(75, 23);
            this.bt.TabIndex = 0;
            this.bt.Text = "Arrancar";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(3, 76);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 15);
            this.lbl.TabIndex = 1;
            // 
            // EjemploWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 161);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.bt);
            this.Name = "EjemploWhile";
            this.Text = "EjemploWhile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lbl;
    }
}

