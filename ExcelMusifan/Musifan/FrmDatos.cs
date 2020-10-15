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
using SpreadsheetLight;
using Entidades;

namespace Musifan
{
    public partial class FrmDatos : Form
    {
        List<Producto> misProductos = new List<Producto>();
        SLDocument slIntermusica;
        string pathIntermusica = Application.StartupPath + "\\excels\\Lista_Intermusica.xlsx";

        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            slIntermusica = new SLDocument(pathIntermusica);
            cargarProductos();
            dgv_Productos.DataSource = misProductos;
        }

        private void cargarProductos()
        {
            cargarProductosIntermusica("Lista Importado", "Importado");
            cargarProductosIntermusica("Lista Nacional", "Nacional");
            cargarProductosIntermusica("Lista Sub Distribucion", "Sub Distribucion");
        }


        private void cargarProductosIntermusica(string hoja, string origen)
        {
            Producto nuevoProd = new Producto("Intermusica");
            int fila = 10;

            slIntermusica.SelectWorksheet(hoja);
            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                nuevoProd.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                nuevoProd.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                nuevoProd.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                nuevoProd.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);
                nuevoProd.PrecioVentaClienteUSD = slIntermusica.GetCellValueAsString(fila, 5);
                nuevoProd.PrecioVentaCliente = slIntermusica.GetCellValueAsString(fila, 6);
                nuevoProd.Iva = slIntermusica.GetCellValueAsString(fila, 7);
                nuevoProd.MargenGanancia = slIntermusica.GetCellValueAsString(fila, 8);
                nuevoProd.PrecioVentaPublicoUSD = slIntermusica.GetCellValueAsString(fila, 9);
                nuevoProd.PrecioVentaPublico = slIntermusica.GetCellValueAsString(fila, 10);
                nuevoProd.OrigenProducto = origen;

                misProductos.Add(nuevoProd);
                fila++;
            }

        }
    }
}
