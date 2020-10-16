using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musifan
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmDatos frmDatos = new FrmDatos();

            SetFormYPanel(this.panel_Forms, frmDatos);

            frmDatos.Show();
        }

        private void SetFormYPanel(Panel miPanel, Form miForm)
        {
            if (miPanel.Controls.Count > 0)
            {
                miPanel.Controls.RemoveAt(0);
            }
            miForm.TopLevel = false;
            miForm.Dock = DockStyle.Fill;
            miPanel.Controls.Add(miForm);
            miPanel.Tag = miForm;
        }

        private void btn_CargarExcel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
