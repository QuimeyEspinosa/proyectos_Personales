namespace ImportarDatosExcel
{
    partial class FrmMusifan
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
            this.btn_CrearListaMusifan = new System.Windows.Forms.Button();
            this.btn_MostrarListaMusifan = new System.Windows.Forms.Button();
            this.dgv_ListaMusifan = new System.Windows.Forms.DataGridView();
            this.btn_LimpiarLista = new System.Windows.Forms.Button();
            this.ofd_Excel = new System.Windows.Forms.OpenFileDialog();
            this.btn_CargarExcel = new System.Windows.Forms.Button();
            this.sfv_Excel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaMusifan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CrearListaMusifan
            // 
            this.btn_CrearListaMusifan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CrearListaMusifan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CrearListaMusifan.Location = new System.Drawing.Point(507, 10);
            this.btn_CrearListaMusifan.Name = "btn_CrearListaMusifan";
            this.btn_CrearListaMusifan.Size = new System.Drawing.Size(110, 31);
            this.btn_CrearListaMusifan.TabIndex = 0;
            this.btn_CrearListaMusifan.Text = "Crear lista Musifan";
            this.btn_CrearListaMusifan.UseVisualStyleBackColor = true;
            this.btn_CrearListaMusifan.Click += new System.EventHandler(this.btn_CrearListaMusifan_Click);
            // 
            // btn_MostrarListaMusifan
            // 
            this.btn_MostrarListaMusifan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MostrarListaMusifan.Location = new System.Drawing.Point(98, 10);
            this.btn_MostrarListaMusifan.Name = "btn_MostrarListaMusifan";
            this.btn_MostrarListaMusifan.Size = new System.Drawing.Size(152, 31);
            this.btn_MostrarListaMusifan.TabIndex = 1;
            this.btn_MostrarListaMusifan.Text = "Mostrar lista Musifan";
            this.btn_MostrarListaMusifan.UseVisualStyleBackColor = true;
            this.btn_MostrarListaMusifan.Click += new System.EventHandler(this.btn_MostrarListaMusifan_Click);
            // 
            // dgv_ListaMusifan
            // 
            this.dgv_ListaMusifan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ListaMusifan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_ListaMusifan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaMusifan.Location = new System.Drawing.Point(12, 49);
            this.dgv_ListaMusifan.Name = "dgv_ListaMusifan";
            this.dgv_ListaMusifan.Size = new System.Drawing.Size(605, 402);
            this.dgv_ListaMusifan.TabIndex = 2;
            // 
            // btn_LimpiarLista
            // 
            this.btn_LimpiarLista.Location = new System.Drawing.Point(412, 10);
            this.btn_LimpiarLista.Name = "btn_LimpiarLista";
            this.btn_LimpiarLista.Size = new System.Drawing.Size(89, 31);
            this.btn_LimpiarLista.TabIndex = 3;
            this.btn_LimpiarLista.Text = "Limpiar lista";
            this.btn_LimpiarLista.UseVisualStyleBackColor = true;
            this.btn_LimpiarLista.Click += new System.EventHandler(this.btn_LimpiarLista_Click);
            // 
            // ofd_Excel
            // 
            this.ofd_Excel.FileName = "openFileDialog1";
            // 
            // btn_CargarExcel
            // 
            this.btn_CargarExcel.Location = new System.Drawing.Point(12, 12);
            this.btn_CargarExcel.Name = "btn_CargarExcel";
            this.btn_CargarExcel.Size = new System.Drawing.Size(80, 29);
            this.btn_CargarExcel.TabIndex = 4;
            this.btn_CargarExcel.Text = "Cargar Excel";
            this.btn_CargarExcel.UseVisualStyleBackColor = true;
            // 
            // FrmMusifan
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(629, 463);
            this.Controls.Add(this.btn_CargarExcel);
            this.Controls.Add(this.btn_LimpiarLista);
            this.Controls.Add(this.dgv_ListaMusifan);
            this.Controls.Add(this.btn_MostrarListaMusifan);
            this.Controls.Add(this.btn_CrearListaMusifan);
            this.Name = "FrmMusifan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musifan";
            this.Load += new System.EventHandler(this.FrmMusifan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaMusifan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearListaMusifan;
        private System.Windows.Forms.Button btn_MostrarListaMusifan;
        private System.Windows.Forms.DataGridView dgv_ListaMusifan;
        private System.Windows.Forms.Button btn_LimpiarLista;
        private System.Windows.Forms.OpenFileDialog ofd_Excel;
        private System.Windows.Forms.Button btn_CargarExcel;
        private System.Windows.Forms.SaveFileDialog sfv_Excel;
    }
}

