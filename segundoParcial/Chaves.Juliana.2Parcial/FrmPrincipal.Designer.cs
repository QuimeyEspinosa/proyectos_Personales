namespace Chaves.Juliana._2Parcial
{
    partial class FrmPrincipal
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblPedidos = new System.Windows.Forms.Label();
            this.LblTdsEntregados = new System.Windows.Forms.Label();
            this.LblDelivery = new System.Windows.Forms.Label();
            this.LblEntregados = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.CbxHamb = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumPedido = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.LsbPedidos = new System.Windows.Forms.ListBox();
            this.LsbPreparacion = new System.Windows.Forms.ListBox();
            this.LsbEntregados = new System.Windows.Forms.ListBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(256, 36);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(151, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar pedido";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblPedidos
            // 
            this.LblPedidos.AutoSize = true;
            this.LblPedidos.Location = new System.Drawing.Point(26, 280);
            this.LblPedidos.Name = "LblPedidos";
            this.LblPedidos.Size = new System.Drawing.Size(55, 13);
            this.LblPedidos.TabIndex = 4;
            this.LblPedidos.Text = "PEDIDOS";
            // 
            // LblTdsEntregados
            // 
            this.LblTdsEntregados.AutoSize = true;
            this.LblTdsEntregados.Location = new System.Drawing.Point(692, 9);
            this.LblTdsEntregados.Name = "LblTdsEntregados";
            this.LblTdsEntregados.Size = new System.Drawing.Size(147, 13);
            this.LblTdsEntregados.TabIndex = 5;
            this.LblTdsEntregados.Text = "TODOS LOS ENTREGADOS";
            // 
            // LblDelivery
            // 
            this.LblDelivery.AutoSize = true;
            this.LblDelivery.Location = new System.Drawing.Point(397, 280);
            this.LblDelivery.Name = "LblDelivery";
            this.LblDelivery.Size = new System.Drawing.Size(102, 13);
            this.LblDelivery.TabIndex = 6;
            this.LblDelivery.Text = "EN PREPARACION";
            // 
            // LblEntregados
            // 
            this.LblEntregados.AutoSize = true;
            this.LblEntregados.Location = new System.Drawing.Point(809, 280);
            this.LblEntregados.Name = "LblEntregados";
            this.LblEntregados.Size = new System.Drawing.Size(82, 13);
            this.LblEntregados.TabIndex = 7;
            this.LblEntregados.Text = "ENTREGADOS";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(666, 147);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(163, 23);
            this.BtnMostrar.TabIndex = 9;
            this.BtnMostrar.Text = "Mostrar pedidos entregados";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // CbxHamb
            // 
            this.CbxHamb.FormattingEnabled = true;
            this.CbxHamb.Location = new System.Drawing.Point(29, 25);
            this.CbxHamb.Name = "CbxHamb";
            this.CbxHamb.Size = new System.Drawing.Size(121, 21);
            this.CbxHamb.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(29, 76);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(29, 135);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(121, 20);
            this.TxtDireccion.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Eliga su hamburguesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Direccion cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero de pedido";
            // 
            // TxtNumPedido
            // 
            this.TxtNumPedido.Location = new System.Drawing.Point(29, 243);
            this.TxtNumPedido.Name = "TxtNumPedido";
            this.TxtNumPedido.Size = new System.Drawing.Size(121, 20);
            this.TxtNumPedido.TabIndex = 19;
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(1045, 538);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(116, 23);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rtbMostrar.Location = new System.Drawing.Point(666, 36);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(495, 96);
            this.rtbMostrar.TabIndex = 22;
            this.rtbMostrar.Text = "";
            // 
            // LsbPedidos
            // 
            this.LsbPedidos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LsbPedidos.FormattingEnabled = true;
            this.LsbPedidos.Location = new System.Drawing.Point(29, 315);
            this.LsbPedidos.Name = "LsbPedidos";
            this.LsbPedidos.Size = new System.Drawing.Size(346, 147);
            this.LsbPedidos.TabIndex = 23;
            // 
            // LsbPreparacion
            // 
            this.LsbPreparacion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LsbPreparacion.FormattingEnabled = true;
            this.LsbPreparacion.Location = new System.Drawing.Point(400, 315);
            this.LsbPreparacion.Name = "LsbPreparacion";
            this.LsbPreparacion.Size = new System.Drawing.Size(366, 147);
            this.LsbPreparacion.TabIndex = 24;
            // 
            // LsbEntregados
            // 
            this.LsbEntregados.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LsbEntregados.FormattingEnabled = true;
            this.LsbEntregados.Location = new System.Drawing.Point(812, 315);
            this.LsbEntregados.Name = "LsbEntregados";
            this.LsbEntregados.Size = new System.Drawing.Size(349, 147);
            this.LsbEntregados.TabIndex = 25;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(29, 188);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(121, 20);
            this.TxtIdCliente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id Cliente";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(1183, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.LsbEntregados);
            this.Controls.Add(this.LsbPreparacion);
            this.Controls.Add(this.LsbPedidos);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtNumPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CbxHamb);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.LblEntregados);
            this.Controls.Add(this.LblDelivery);
            this.Controls.Add(this.LblTdsEntregados);
            this.Controls.Add(this.LblPedidos);
            this.Controls.Add(this.BtnAgregar);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juliana Chaves 2D";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblPedidos;
        private System.Windows.Forms.Label LblTdsEntregados;
        private System.Windows.Forms.Label LblDelivery;
        private System.Windows.Forms.Label LblEntregados;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.ComboBox CbxHamb;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNumPedido;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ListBox LsbPedidos;
        private System.Windows.Forms.ListBox LsbPreparacion;
        private System.Windows.Forms.ListBox LsbEntregados;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label2;
    }
}

