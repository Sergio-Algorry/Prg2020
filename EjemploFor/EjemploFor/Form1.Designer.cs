namespace EjemploFor
{
    partial class frmContador
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
            this.btContar = new System.Windows.Forms.Button();
            this.lblE1 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblE2 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.lblE3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(352, 64);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(75, 23);
            this.btContar.TabIndex = 0;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // lblE1
            // 
            this.lblE1.AutoSize = true;
            this.lblE1.Location = new System.Drawing.Point(32, 45);
            this.lblE1.Name = "lblE1";
            this.lblE1.Size = new System.Drawing.Size(38, 13);
            this.lblE1.TabIndex = 1;
            this.lblE1.Text = "Desde";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(165, 103);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 46);
            this.lblRes.TabIndex = 2;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(32, 64);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 3;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(139, 64);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 4;
            this.txtHasta.TextChanged += new System.EventHandler(this.txtHasta_TextChanged);
            // 
            // lblE2
            // 
            this.lblE2.AutoSize = true;
            this.lblE2.Location = new System.Drawing.Point(139, 45);
            this.lblE2.Name = "lblE2";
            this.lblE2.Size = new System.Drawing.Size(35, 13);
            this.lblE2.TabIndex = 5;
            this.lblE2.Text = "Hasta";
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(246, 64);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(100, 20);
            this.txtPaso.TabIndex = 6;
            // 
            // lblE3
            // 
            this.lblE3.AutoSize = true;
            this.lblE3.Location = new System.Drawing.Point(246, 45);
            this.lblE3.Name = "lblE3";
            this.lblE3.Size = new System.Drawing.Size(31, 13);
            this.lblE3.TabIndex = 7;
            this.lblE3.Text = "Paso";
            // 
            // frmContador
            // 
            this.AcceptButton = this.btContar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 183);
            this.Controls.Add(this.lblE3);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.lblE2);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblE1);
            this.Controls.Add(this.btContar);
            this.Name = "frmContador";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Label lblE1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblE2;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Label lblE3;
    }
}

