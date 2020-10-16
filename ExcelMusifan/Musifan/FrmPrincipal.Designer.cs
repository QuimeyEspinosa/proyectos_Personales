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
            this.btn_CargarExcel = new System.Windows.Forms.Button();
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
            this.panel_Opciones.Controls.Add(this.btn_CargarExcel);
            this.panel_Opciones.Controls.Add(this.pb_Musifan);
            this.panel_Opciones.Location = new System.Drawing.Point(12, 12);
            this.panel_Opciones.Name = "panel_Opciones";
            this.panel_Opciones.Size = new System.Drawing.Size(192, 428);
            this.panel_Opciones.TabIndex = 1;
            // 
            // btn_CargarExcel
            // 
            this.btn_CargarExcel.BackColor = System.Drawing.Color.Crimson;
            this.btn_CargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CargarExcel.ForeColor = System.Drawing.Color.White;
            this.btn_CargarExcel.Location = new System.Drawing.Point(3, 70);
            this.btn_CargarExcel.Name = "btn_CargarExcel";
            this.btn_CargarExcel.Size = new System.Drawing.Size(186, 30);
            this.btn_CargarExcel.TabIndex = 1;
            this.btn_CargarExcel.Text = "Cargar";
            this.btn_CargarExcel.UseVisualStyleBackColor = false;
            this.btn_CargarExcel.Click += new System.EventHandler(this.btn_CargarExcel_Click);
            // 
            // panel_Forms
            // 
            this.panel_Forms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Forms.BackColor = System.Drawing.Color.Black;
            this.panel_Forms.Location = new System.Drawing.Point(221, 12);
            this.panel_Forms.Name = "panel_Forms";
            this.panel_Forms.Size = new System.Drawing.Size(935, 428);
            this.panel_Forms.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1168, 452);
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
        private System.Windows.Forms.Button btn_CargarExcel;
    }
}