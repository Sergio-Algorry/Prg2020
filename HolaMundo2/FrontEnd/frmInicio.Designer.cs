namespace FrontEnd
{
    partial class frmInicio
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
            this.lblHola = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btListo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.Location = new System.Drawing.Point(72, 91);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(245, 37);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "HOLA MUNDO";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(79, 26);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // btListo
            // 
            this.btListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListo.Location = new System.Drawing.Point(305, 26);
            this.btListo.Name = "btListo";
            this.btListo.Size = new System.Drawing.Size(75, 23);
            this.btListo.TabIndex = 2;
            this.btListo.Text = "Listo";
            this.btListo.UseVisualStyleBackColor = true;
            this.btListo.Click += new System.EventHandler(this.btListo_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 154);
            this.Controls.Add(this.btListo);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblHola);
            this.Name = "frmInicio";
            this.Text = "Hola gente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btListo;
    }
}

