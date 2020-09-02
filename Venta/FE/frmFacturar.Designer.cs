namespace FE
{
    partial class frmFacturar
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
            this.paEncabezado = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btNueva = new System.Windows.Forms.Button();
            this.paPie = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.paRenglones = new System.Windows.Forms.Panel();
            this.lblkRenglones = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNuevoRenglon = new System.Windows.Forms.Button();
            this.paEncabezado.SuspendLayout();
            this.paPie.SuspendLayout();
            this.paRenglones.SuspendLayout();
            this.SuspendLayout();
            // 
            // paEncabezado
            // 
            this.paEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paEncabezado.Controls.Add(this.txtFecha);
            this.paEncabezado.Controls.Add(this.label4);
            this.paEncabezado.Controls.Add(this.txtCuit);
            this.paEncabezado.Controls.Add(this.label3);
            this.paEncabezado.Controls.Add(this.txtCliente);
            this.paEncabezado.Controls.Add(this.label2);
            this.paEncabezado.Controls.Add(this.txtNumero);
            this.paEncabezado.Controls.Add(this.label1);
            this.paEncabezado.Controls.Add(this.btNueva);
            this.paEncabezado.Location = new System.Drawing.Point(12, 12);
            this.paEncabezado.Name = "paEncabezado";
            this.paEncabezado.Size = new System.Drawing.Size(776, 80);
            this.paEncabezado.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(671, 39);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(475, 40);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(131, 20);
            this.txtCuit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CUIT";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(59, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(372, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(670, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Factura";
            // 
            // btNueva
            // 
            this.btNueva.Location = new System.Drawing.Point(3, 4);
            this.btNueva.Name = "btNueva";
            this.btNueva.Size = new System.Drawing.Size(97, 23);
            this.btNueva.TabIndex = 0;
            this.btNueva.Text = "Nueva Factura";
            this.btNueva.UseVisualStyleBackColor = true;
            this.btNueva.Click += new System.EventHandler(this.btNueva_Click);
            // 
            // paPie
            // 
            this.paPie.Controls.Add(this.txtTotal);
            this.paPie.Controls.Add(this.label11);
            this.paPie.Controls.Add(this.txtIVA);
            this.paPie.Controls.Add(this.label10);
            this.paPie.Controls.Add(this.txtBruto);
            this.paPie.Controls.Add(this.label9);
            this.paPie.Location = new System.Drawing.Point(12, 365);
            this.paPie.Name = "paPie";
            this.paPie.Size = new System.Drawing.Size(776, 84);
            this.paPie.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(657, 55);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(547, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "TOTAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(657, 29);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(547, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "IVA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(657, 3);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(100, 20);
            this.txtBruto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(547, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "BRUTO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paRenglones
            // 
            this.paRenglones.Controls.Add(this.lblkRenglones);
            this.paRenglones.Controls.Add(this.textBox8);
            this.paRenglones.Controls.Add(this.label8);
            this.paRenglones.Controls.Add(this.textBox7);
            this.paRenglones.Controls.Add(this.label7);
            this.paRenglones.Controls.Add(this.textBox6);
            this.paRenglones.Controls.Add(this.label6);
            this.paRenglones.Controls.Add(this.textBox5);
            this.paRenglones.Controls.Add(this.label5);
            this.paRenglones.Controls.Add(this.btNuevoRenglon);
            this.paRenglones.Location = new System.Drawing.Point(12, 98);
            this.paRenglones.Name = "paRenglones";
            this.paRenglones.Size = new System.Drawing.Size(776, 261);
            this.paRenglones.TabIndex = 2;
            // 
            // lblkRenglones
            // 
            this.lblkRenglones.AutoSize = true;
            this.lblkRenglones.Location = new System.Drawing.Point(27, 85);
            this.lblkRenglones.Name = "lblkRenglones";
            this.lblkRenglones.Size = new System.Drawing.Size(0, 13);
            this.lblkRenglones.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(657, 31);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "$ Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(522, 31);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "$ Unitario";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(155, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(332, 20);
            this.textBox6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producto";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // btNuevoRenglon
            // 
            this.btNuevoRenglon.Location = new System.Drawing.Point(657, 57);
            this.btNuevoRenglon.Name = "btNuevoRenglon";
            this.btNuevoRenglon.Size = new System.Drawing.Size(100, 23);
            this.btNuevoRenglon.TabIndex = 9;
            this.btNuevoRenglon.Text = "Cargar Producto";
            this.btNuevoRenglon.UseVisualStyleBackColor = true;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paRenglones);
            this.Controls.Add(this.paPie);
            this.Controls.Add(this.paEncabezado);
            this.Name = "Facturar";
            this.Text = "Form1";
            this.paEncabezado.ResumeLayout(false);
            this.paEncabezado.PerformLayout();
            this.paPie.ResumeLayout(false);
            this.paPie.PerformLayout();
            this.paRenglones.ResumeLayout(false);
            this.paRenglones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paEncabezado;
        private System.Windows.Forms.Panel paPie;
        private System.Windows.Forms.Panel paRenglones;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNueva;
        private System.Windows.Forms.Button btNuevoRenglon;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblkRenglones;
    }
}

