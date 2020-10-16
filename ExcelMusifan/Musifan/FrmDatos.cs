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

            dgv_Productos.DataSource = Comercio.MisProductos;
        }

        private void cargarProductos()
        {
            cargarProductosIntermusica();
        }

        private void cargarProductosIntermusica()
        {
            Producto nuevoProd;
            string auxIva;
            string auxMargenGanancia;
            int fila;

            fila = 10;
            slIntermusica.SelectWorksheet("Lista Nacional");
            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                nuevoProd = new Producto("Intermusica");
                nuevoProd.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                nuevoProd.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                nuevoProd.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                nuevoProd.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);
                nuevoProd.PrecioVentaCliente = "$ " + slIntermusica.GetCellValueAsDouble(fila, 5).ToString();

                auxIva = slIntermusica.GetCellValueAsDouble(fila, 6).ToString();
                nuevoProd.Iva = ConvertIva(auxIva);

                auxMargenGanancia = slIntermusica.GetCellValueAsDouble(fila, 7).ToString();
                nuevoProd.MargenGanancia = ConvertMargen(auxMargenGanancia);

                nuevoProd.PrecioVentaPublico = "$ " + slIntermusica.GetCellValueAsDouble(fila, 8).ToString();
                nuevoProd.OrigenProducto = "Nacional";

                

                Comercio.AgregarProducto(nuevoProd);
                fila++;
            }

            fila = 10;
            slIntermusica.SelectWorksheet("Lista Importado");
            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                nuevoProd = new Producto("Intermusica");
                nuevoProd.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                nuevoProd.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                nuevoProd.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                nuevoProd.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);

                nuevoProd.PrecioVentaClienteUSD = "us$ " + slIntermusica.GetCellValueAsDouble(fila, 5).ToString();
                nuevoProd.PrecioVentaCliente = "$ " + slIntermusica.GetCellValueAsDouble(fila, 6).ToString();

                auxIva = slIntermusica.GetCellValueAsDouble(fila, 7).ToString();
                nuevoProd.Iva = ConvertIva(auxIva);

                auxMargenGanancia = slIntermusica.GetCellValueAsDouble(fila, 8).ToString();
                nuevoProd.MargenGanancia = ConvertMargen(auxMargenGanancia);

                nuevoProd.PrecioVentaPublicoUSD = "us$ " + slIntermusica.GetCellValueAsDouble(fila, 9).ToString();
                nuevoProd.PrecioVentaPublico = "$ " + slIntermusica.GetCellValueAsDouble(fila, 10).ToString();
                nuevoProd.OrigenProducto = "Importado";

                Comercio.AgregarProducto(nuevoProd);
                fila++;
            }
        }



        private string ConvertMargen(string margenGanancia)
        {
            if (margenGanancia == "0,4")
            {
                margenGanancia = "40%";
            }
            else if (margenGanancia == "0,43")
            {
                margenGanancia = "43%";
            }
            else if (margenGanancia == "0,6")
            {
                margenGanancia = "60%";
            }
            else if (margenGanancia == "0,55")
            {
                margenGanancia = "55%";
            }
            else if (margenGanancia == "0,3")
            {
                margenGanancia = "30%";
            }
            else if (margenGanancia == "0,35")
            {
                margenGanancia = "35%";
            }

            return margenGanancia;
        }
        private string ConvertIva(string iva)
        {
            if (iva == "0,105")
            {
                iva = "10,5%";
            }
            else if (iva == "0,21")
            {
                iva = "21%";
            }

            return iva;
        }
    }
}
