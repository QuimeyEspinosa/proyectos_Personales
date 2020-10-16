using Entidades;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musifan
{
    public partial class FrmPrincipal : Form
    {
        SLDocument slMusifan;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_CargarDatos_Click(object sender, EventArgs e)
        {
            FrmDatos frmDatos = new FrmDatos();

            SetFormYPanel(this.panel_Forms, frmDatos);

            frmDatos.Show();
        }

        private void btn_CrearExcelMusifan_Click(object sender, EventArgs e)
        {
            slMusifan = new SLDocument();
            System.Data.DataTable dt = new System.Data.DataTable();
            StringBuilder fecha = new StringBuilder();

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

            //Importo los datos al documento
            slMusifan.ImportDataTable(1, 1, dt, true);
            //Seteo el estilo del excel
            SetEstiloExcel();
            //Obtengo la dirección del escritorio de la pc en la que se ejecuta el programa
            string direccionEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //Si no existe la carpeta, la creo
            Directory.CreateDirectory(direccionEscritorio + "\\Lista Proveedores");
            //Asigno la fecha de creacion al nombre del excel
            fecha.Append(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            //Guardo el archivo
            slMusifan.SaveAs($"{direccionEscritorio}\\Lista Proveedores\\Lista_Musifan {fecha}.xlsx");

            MessageBox.Show("Creado con éxito!",
                                            "Crear excel",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
        }

        private void SetEstiloExcel()
        {
            //estilo de cabecera
            SLStyle rowHeaderStyle = new SLStyle();
            rowHeaderStyle.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thick, Color.Crimson);
            rowHeaderStyle.SetFont("Century Gothic", 12);
            slMusifan.SetRowStyle(1, rowHeaderStyle);

            //estilo de filas
            SLStyle allRowStyle = new SLStyle();
            allRowStyle.SetBottomBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, Color.DarkGray);
            slMusifan.SetRowStyle(2, Comercio.MisProductos.Count, allRowStyle);

            //estilo de columnas
            SLStyle columnStyle = new SLStyle();
            columnStyle.SetLeftBorder(DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Medium, Color.Black);
            slMusifan.SetColumnStyle(1, 13, columnStyle);

            //expandir columnas automaticamente en base a las celdas
            slMusifan.AutoFitColumn(1, 13);

            //fijo la primer fila
            slMusifan.FreezePanes(1, 0);
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            StringBuilder infoAyuda = new StringBuilder();

            infoAyuda.AppendLine("1) Los excels de los proveedores que se utilizan para la carga de datos deben guardarse dentro de la carpeta 'excels' que se encuentra en la ruta de origen de este programa y su nombre debe corresponder con el siguiente ejemplo:\n");
            infoAyuda.AppendLine("'Lista_Martcar' con formato .xlsx\n");
            infoAyuda.AppendLine("2) El archivo excel creado se guardará y/o se sobreescribirá en una carpeta llamada 'Lista proveedores' en el escritorio\n");
            infoAyuda.AppendLine("3) Puede que la carga de datos demore unos segundos");

            MessageBox.Show($"{infoAyuda}",
                                            "Ayuda",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
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
