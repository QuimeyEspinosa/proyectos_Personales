namespace Musifan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pb_Musifan = new System.Windows.Forms.PictureBox();
            this.panel_Opciones = new System.Windows.Forms.Panel();
            this.btn_CargarDatos = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_CrearExcelMusifan = new System.Windows.Forms.Button();
            this.panel_Forms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Musifan)).BeginInit();
            this.panel_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Musifan
            // 
            this.pb_Musifan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Musifan.BackgroundImage")));
            this.pb_Musifan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Musifan.Location = new System.Drawing.Point(0, 0);
            this.pb_Musifan.Name = "pb_Musifan";
            this.pb_Musifan.Size = new System.Drawing.Size(192, 54);
            this.pb_Musifan.TabIndex = 0;
            this.pb_Musifan.TabStop = false;
            // 
            // panel_Opciones
            // 
            this.panel_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Opciones.BackColor = System.Drawing.Color.Transparent;
            this.panel_Opciones.Controls.Add(this.btn_CargarDatos);
            this.panel_Opciones.Controls.Add(this.btn_Ayuda);
            this.panel_Opciones.Controls.Add(this.btn_CrearExcelMusifan);
            this.panel_Opciones.Controls.Add(this.pb_Musifan);
            this.panel_Opciones.Location = new System.Drawing.Point(12, 12);
            this.panel_Opciones.Name = "panel_Opciones";
            this.panel_Opciones.Size = new System.Drawing.Size(192, 286);
            this.panel_Opciones.TabIndex = 1;
            // 
            // btn_CargarDatos
            // 
            this.btn_CargarDatos.BackColor = System.Drawing.Color.Crimson;
            this.btn_CargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CargarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarDatos.ForeColor = System.Drawing.Color.White;
            this.btn_CargarDatos.Location = new System.Drawing.Point(3, 83);
            this.btn_CargarDatos.Name = "btn_CargarDatos";
            this.btn_CargarDatos.Size = new System.Drawing.Size(186, 30);
            this.btn_CargarDatos.TabIndex = 4;
            this.btn_CargarDatos.Text = "Cargar Datos";
            this.btn_CargarDatos.UseVisualStyleBackColor = false;
            this.btn_CargarDatos.Click += new System.EventHandler(this.btn_CargarDatos_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.BackColor = System.Drawing.Color.Crimson;
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ayuda.ForeColor = System.Drawing.Color.White;
            this.btn_Ayuda.Location = new System.Drawing.Point(3, 155);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(186, 30);
            this.btn_Ayuda.TabIndex = 3;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = false;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_CrearExcelMusifan
            // 
            this.btn_CrearExcelMusifan.BackColor = System.Drawing.Color.Crimson;
            this.btn_CrearExcelMusifan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CrearExcelMusifan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearExcelMusifan.ForeColor = System.Drawing.Color.White;
            this.btn_CrearExcelMusifan.Location = new System.Drawing.Point(3, 119);
            this.btn_CrearExcelMusifan.Name = "btn_CrearExcelMusifan";
            this.btn_CrearExcelMusifan.Size = new System.Drawing.Size(186, 30);
            this.btn_CrearExcelMusifan.TabIndex = 2;
            this.btn_CrearExcelMusifan.Text = "Crear Excel Musifan";
            this.btn_CrearExcelMusifan.UseVisualStyleBackColor = false;
            this.btn_CrearExcelMusifan.Click += new System.EventHandler(this.btn_CrearExcelMusifan_Click);
            // 
            // panel_Forms
            // 
            this.panel_Forms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Forms.BackColor = System.Drawing.Color.Black;
            this.panel_Forms.Location = new System.Drawing.Point(221, 12);
            this.panel_Forms.Name = "panel_Forms";
            this.panel_Forms.Size = new System.Drawing.Size(822, 286);
            this.panel_Forms.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1055, 310);
            this.Controls.Add(this.panel_Forms);
            this.Controls.Add(this.panel_Opciones);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musifan";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Musifan)).EndInit();
            this.panel_Opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Musifan;
        private System.Windows.Forms.Panel panel_Opciones;
        private System.Windows.Forms.Panel panel_Forms;
        private System.Windows.Forms.Button btn_CrearExcelMusifan;
        private System.Windows.Forms.Button btn_CargarDatos;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}