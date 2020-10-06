namespace Sumador
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
            this.btSuma = new System.Windows.Forms.Button();
            this.txtSumando1 = new System.Windows.Forms.TextBox();
            this.txtSumando2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtAcumulado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSuma
            // 
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(288, 16);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 37);
            this.btSuma.TabIndex = 0;
            this.btSuma.Text = "=";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // txtSumando1
            // 
            this.txtSumando1.Location = new System.Drawing.Point(12, 24);
            this.txtSumando1.Name = "txtSumando1";
            this.txtSumando1.Size = new System.Drawing.Size(100, 20);
            this.txtSumando1.TabIndex = 1;
            // 
            // txtSumando2
            // 
            this.txtSumando2.Location = new System.Drawing.Point(162, 24);
            this.txtSumando2.Name = "txtSumando2";
            this.txtSumando2.Size = new System.Drawing.Size(100, 20);
            this.txtSumando2.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(390, 24);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(121, 19);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(28, 29);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "+";
            // 
            // txtAcumulado
            // 
            this.txtAcumulado.Location = new System.Drawing.Point(512, 24);
            this.txtAcumulado.Name = "txtAcumulado";
            this.txtAcumulado.Size = new System.Drawing.Size(100, 20);
            this.txtAcumulado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acumulado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Suma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 81);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAcumulado);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtSumando2);
            this.Controls.Add(this.txtSumando1);
            this.Controls.Add(this.btSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.TextBox txtSumando1;
        private System.Windows.Forms.TextBox txtSumando2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtAcumulado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

