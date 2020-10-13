namespace Persistencia
{
    partial class frmDatos
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
            this.btCrear = new System.Windows.Forms.Button();
            this.btGrabar = new System.Windows.Forms.Button();
            this.btLeer = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(13, 13);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(75, 23);
            this.btCrear.TabIndex = 0;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btGrabar
            // 
            this.btGrabar.Location = new System.Drawing.Point(94, 14);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(75, 23);
            this.btGrabar.TabIndex = 1;
            this.btGrabar.Text = "Grabar";
            this.btGrabar.UseVisualStyleBackColor = true;
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // btLeer
            // 
            this.btLeer.Location = new System.Drawing.Point(175, 14);
            this.btLeer.Name = "btLeer";
            this.btLeer.Size = new System.Drawing.Size(75, 23);
            this.btLeer.TabIndex = 2;
            this.btLeer.Text = "Leer";
            this.btLeer.UseVisualStyleBackColor = true;
            this.btLeer.Click += new System.EventHandler(this.btLeer_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(13, 43);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(775, 395);
            this.DGV.TabIndex = 3;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(256, 14);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 4;
            this.btNuevo.Text = "Nuevo dato";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btLeer);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.btCrear);
            this.Name = "frmDatos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btGrabar;
        private System.Windows.Forms.Button btLeer;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btNuevo;
    }
}

