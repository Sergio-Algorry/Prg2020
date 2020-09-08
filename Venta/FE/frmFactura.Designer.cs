namespace FE
{
    partial class frmFactura
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paRenglones = new System.Windows.Forms.Panel();
            this.lblkRenglones = new System.Windows.Forms.Label();
            this.txtTotRenglon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btNuevoRenglon = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lblErrorEncabezado = new System.Windows.Forms.Label();
            this.paEncabezado.SuspendLayout();
            this.paPie.SuspendLayout();
            this.paRenglones.SuspendLayout();
            this.SuspendLayout();
            // 
            // paEncabezado
            // 
            this.paEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paEncabezado.Controls.Add(this.lblErrorEncabezado);
            this.paEncabezado.Controls.Add(this.btConfirmar);
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
            this.paEncabezado.Size = new System.Drawing.Size(776, 101);
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
            this.paPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paPie.Controls.Add(this.lblTotal);
            this.paPie.Controls.Add(this.lblIVA);
            this.paPie.Controls.Add(this.lblBruto);
            this.paPie.Controls.Add(this.label11);
            this.paPie.Controls.Add(this.label10);
            this.paPie.Controls.Add(this.label9);
            this.paPie.Location = new System.Drawing.Point(12, 365);
            this.paPie.Name = "paPie";
            this.paPie.Size = new System.Drawing.Size(776, 96);
            this.paPie.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(657, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIVA
            // 
            this.lblIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(657, 32);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(100, 23);
            this.lblIVA.TabIndex = 7;
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBruto
            // 
            this.lblBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(657, 6);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(100, 23);
            this.lblBruto.TabIndex = 6;
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(551, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "TOTAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.paRenglones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paRenglones.Controls.Add(this.lblkRenglones);
            this.paRenglones.Controls.Add(this.txtTotRenglon);
            this.paRenglones.Controls.Add(this.label8);
            this.paRenglones.Controls.Add(this.txtUnitario);
            this.paRenglones.Controls.Add(this.label7);
            this.paRenglones.Controls.Add(this.txtProducto);
            this.paRenglones.Controls.Add(this.label6);
            this.paRenglones.Controls.Add(this.txtCantidad);
            this.paRenglones.Controls.Add(this.label5);
            this.paRenglones.Controls.Add(this.btNuevoRenglon);
            this.paRenglones.Enabled = false;
            this.paRenglones.Location = new System.Drawing.Point(12, 119);
            this.paRenglones.Name = "paRenglones";
            this.paRenglones.Size = new System.Drawing.Size(776, 240);
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
            // txtTotRenglon
            // 
            this.txtTotRenglon.Location = new System.Drawing.Point(657, 31);
            this.txtTotRenglon.Name = "txtTotRenglon";
            this.txtTotRenglon.ReadOnly = true;
            this.txtTotRenglon.Size = new System.Drawing.Size(100, 20);
            this.txtTotRenglon.TabIndex = 17;
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
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(522, 31);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 15;
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
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(155, 31);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(332, 20);
            this.txtProducto.TabIndex = 13;
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
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(27, 31);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
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
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(671, 66);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(99, 23);
            this.btConfirmar.TabIndex = 9;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // lblErrorEncabezado
            // 
            this.lblErrorEncabezado.AutoSize = true;
            this.lblErrorEncabezado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncabezado.Location = new System.Drawing.Point(17, 83);
            this.lblErrorEncabezado.Name = "lblErrorEncabezado";
            this.lblErrorEncabezado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEncabezado.TabIndex = 10;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.paRenglones);
            this.Controls.Add(this.paPie);
            this.Controls.Add(this.paEncabezado);
            this.Name = "frmFactura";
            this.Text = "Form1";
            this.paEncabezado.ResumeLayout(false);
            this.paEncabezado.PerformLayout();
            this.paPie.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtTotRenglon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblkRenglones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label lblErrorEncabezado;
    }
}

