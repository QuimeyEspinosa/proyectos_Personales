using Entidades;
using SpreadsheetLight;
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

        }

        private void btn_CargarExcel_Click(object sender, EventArgs e)
        {
            FrmDatos frmDatos = new FrmDatos();

            SetFormYPanel(this.panel_Forms, frmDatos);

            frmDatos.Show();
        }

        private void btn_CrearExcelMusifan_Click(object sender, EventArgs e)
        {
            SLDocument slMusifan = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();
            StringBuilder fecha = new StringBuilder();            
            string pathFile;

            fecha.Append(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            pathFile = AppDomain.CurrentDomain.BaseDirectory + $"Lista_Musifan {fecha.ToString()}.xlsx";

            //columnas
            dt.Columns.Add("Proveedor", typeof(string));
            dt.Columns.Add("N° Artículo", typeof(string));
            dt.Columns.Add("Rubro", typeof(string));
            dt.Columns.Add("Marca", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Stock", typeof(string));
            dt.Columns.Add("Iva", typeof(string));
            dt.Columns.Add("Ganancia", typeof(string));
            dt.Columns.Add("P.Compra", typeof(string));
            dt.Columns.Add("P.Público", typeof(string));
            dt.Columns.Add("Origen", typeof(string));
            dt.Columns.Add("P.Compra USD", typeof(string));
            dt.Columns.Add("P.Público USD", typeof(string));

            //filas
            for (int i = 0; i < Comercio.MisProductos.Count; i++)
            {
                dt.Rows.Add(Comercio.MisProductos[i].Proveedor,
                            Comercio.MisProductos[i].NumeroArticulo,
                            Comercio.MisProductos[i].Rubro,
                            Comercio.MisProductos[i].Marca,
                            Comercio.MisProductos[i].Descripcion,
                            Comercio.MisProductos[i].Stock,
                            Comercio.MisProductos[i].Iva,
                            Comercio.MisProductos[i].MargenGanancia,
                            Comercio.MisProductos[i].PrecioVentaCliente,
                            Comercio.MisProductos[i].PrecioVentaPublico,
                            Comercio.MisProductos[i].OrigenProducto,
                            Comercio.MisProductos[i].PrecioVentaClienteUSD,
                            Comercio.MisProductos[i].PrecioVentaPublicoUSD);
            }

            slMusifan.ImportDataTable(1, 1, dt, true);
            slMusifan.AutoFitColumn(1, 13);
            slMusifan.SaveAs(pathFile);
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
    }
}
