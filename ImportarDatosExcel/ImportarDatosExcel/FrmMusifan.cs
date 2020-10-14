using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using SpreadsheetLight;

namespace ImportarDatosExcel
{
    public partial class FrmMusifan : Form
    {
        List<Producto> productosMusifan;
        SLDocument slHmg;
        SLDocument slMartcar;
        SLDocument slIntermusicaNacionales;
        SLDocument slIntermusicaImportados;
        //SLDocument slMartinBlust;
        private string pathMartcar = @"C:\Users\Quimey\source\repos\ImportarDatosExcel\ImportarDatosExcel\dataExcel\Lista_Martcar.xlsx";
        private string pathIntermusica = @"C:\Users\Quimey\source\repos\ImportarDatosExcel\ImportarDatosExcel\dataExcel\Lista_Intermusica.xlsx";
        private string pathHmg = @"C:\Users\Quimey\source\repos\ImportarDatosExcel\ImportarDatosExcel\dataExcel\Lista_Hmg.xlsx";
        //private string pathMartinBlust = @"C:\Users\Quimey\source\repos\ImportarDatosExcel\ImportarDatosExcel\dataExcel\Lista_MartinBlust.xlsx";

        public FrmMusifan()
        {
            InitializeComponent();
        }

        private void FrmMusifan_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btn_LimpiarLista_Click(object sender, EventArgs e)
        {
            dgv_ListaMusifan.DataSource = null;
        }

        private void btn_MostrarListaMusifan_Click(object sender, EventArgs e)
        {
            productosMusifan = new List<Producto>();

            slMartcar = new SLDocument(pathMartcar, "Lista de precios");
            slHmg = new SLDocument(pathHmg, "HMG");
            slIntermusicaNacionales = new SLDocument(pathIntermusica, "Lista Nacional");
            slIntermusicaImportados = new SLDocument(pathIntermusica, "Lista Importado");

            ObtenerProductosMartcar(1335, slMartcar);
            ObtenerProductosIntermusicaNacional(productosMusifan, slIntermusicaNacionales);
            ObtenerProductosIntermusicaImportados(productosMusifan, slIntermusicaImportados);
            ObtenerProductosHmg(productosMusifan, slHmg);

            dgv_ListaMusifan.DataSource = productosMusifan;
        }

        private void ObtenerProductosIntermusicaImportados(List<Producto> productos, SLDocument slIntermusica)
        {
            Producto miProducto;
            int fila = 10;

            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                miProducto = new Producto();

                miProducto.Proveedor = "Intermusica";
                miProducto.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                miProducto.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                miProducto.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                miProducto.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);
                miProducto.PrecioVentaClienteUSD = slIntermusica.GetCellValueAsString(fila, 5);
                miProducto.PrecioVentaCliente = slIntermusica.GetCellValueAsString(fila, 6);
                miProducto.Iva = slIntermusica.GetCellValueAsString(fila, 7);
                miProducto.MargenGanancia = slIntermusica.GetCellValueAsString(fila, 8);
                miProducto.PrecioVentaPublicoUSD = slIntermusica.GetCellValueAsString(fila, 9);
                miProducto.PrecioVentaPublico = slIntermusica.GetCellValueAsString(fila, 10);
                miProducto.OrigenProducto = "Importado";

                productosMusifan.Add(miProducto);

                fila++;
            }
        }

        private void ObtenerProductosIntermusicaNacional(List<Producto> productos, SLDocument slIntermusica)
        {
            Producto miProducto;
            int fila = 10;

            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                miProducto = new Producto();

                miProducto.Proveedor = "Intermusica";
                miProducto.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                miProducto.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                miProducto.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                miProducto.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);
                miProducto.PrecioVentaCliente = slIntermusica.GetCellValueAsString(fila, 5);
                miProducto.Iva = slIntermusica.GetCellValueAsString(fila, 6);
                miProducto.MargenGanancia = slIntermusica.GetCellValueAsString(fila, 7);
                miProducto.PrecioVentaPublico = slIntermusica.GetCellValueAsString(fila, 8);
                miProducto.OrigenProducto = "Nacional";

                productosMusifan.Add(miProducto);

                fila++;
            }
        }

        private void ObtenerProductosMartcar(int iLastRow, SLDocument slMartcar)
        {
            Producto miProducto;

            while (iLastRow >= 14)
            {
                if(string.IsNullOrEmpty(slMartcar.GetCellValueAsString(iLastRow, 3)))
                {
                    iLastRow = iLastRow - 4;
                }
                else
                {
                    miProducto = new Producto();

                    miProducto.Proveedor = "Martcar";
                    miProducto.Marca = slMartcar.GetCellValueAsString(iLastRow, 1);
                    miProducto.Rubro = slMartcar.GetCellValueAsString(iLastRow, 2);
                    miProducto.NumeroArticulo = slMartcar.GetCellValueAsString(iLastRow, 3);
                    miProducto.Descripcion = slMartcar.GetCellValueAsString(iLastRow, 4);
                    miProducto.Stock = slMartcar.GetCellValueAsString(iLastRow, 6);
                    miProducto.PrecioVentaCliente = slMartcar.GetCellValueAsString(iLastRow, 7);
                    miProducto.Iva = slMartcar.GetCellValueAsString(iLastRow, 8);
                    miProducto.PrecioVentaPublico = slMartcar.GetCellValueAsString(iLastRow, 9);

                    productosMusifan.Add(miProducto);

                    iLastRow--;
                }                
            }
        }

        private void ObtenerProductosHmg(List<Producto> productos, SLDocument slHmg)
        {
            Producto miProducto;
            int fila = 10;

            while (!string.IsNullOrEmpty(slHmg.GetCellValueAsString(fila, 2)))
            {
                miProducto = new Producto();

                miProducto.Proveedor = "HMG";
                miProducto.Rubro = slHmg.GetCellValueAsString(fila, 2);
                miProducto.Marca = slHmg.GetCellValueAsString(fila, 3);
                miProducto.NumeroArticulo = slHmg.GetCellValueAsString(fila, 4);
                miProducto.Descripcion = slHmg.GetCellValueAsString(fila, 5);
                miProducto.PrecioVentaCliente = slHmg.GetCellValueAsString(fila, 6);
                miProducto.Stock = slHmg.GetCellValueAsString(fila, 8);
                miProducto.Iva = slHmg.GetCellValueAsString(fila, 10);
                //miProducto.MargenGanancia = slHmg.GetCellValueAsString(fila, 16);
                miProducto.PrecioVentaPublico = slHmg.GetCellValueAsString(fila, 17);

                productosMusifan.Add(miProducto);

                fila++;
            }
        }

        private void btn_CrearListaMusifan_Click(object sender, EventArgs e)
        {
            SLDocument slMusifan = new SLDocument();
            int iR = 2;
            int iC = 1;
                        
            if(productosMusifan != null)
            {
                dgv_ListaMusifan.DataSource = productosMusifan;

                foreach(DataGridViewColumn colum in dgv_ListaMusifan.Columns)
                {
                    slMusifan.SetCellValue(1, iC, colum.HeaderText.ToString());
                    iC++;
                }


                foreach (DataGridViewRow row in dgv_ListaMusifan.Rows)
                {
                    slMusifan.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                    slMusifan.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                    slMusifan.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                    slMusifan.SetCellValue(iR, 4, row.Cells[3].Value.ToString());
                    slMusifan.SetCellValue(iR, 5, row.Cells[4].Value.ToString());
                    slMusifan.SetCellValue(iR, 6, row.Cells[5].Value.ToString());
                    slMusifan.SetCellValue(iR, 7, row.Cells[6].Value.ToString());
                    slMusifan.SetCellValue(iR, 8, row.Cells[7].Value.ToString());
                    slMusifan.SetCellValue(iR, 9, row.Cells[8].Value.ToString());
                    slMusifan.SetCellValue(iR, 10, row.Cells[9].Value.ToString());
                    slMusifan.SetCellValue(iR, 11, row.Cells[10].Value.ToString());
                    slMusifan.SetCellValue(iR, 12, row.Cells[11].Value.ToString());
                    slMusifan.SetCellValue(iR, 13, row.Cells[12].Value.ToString());
                    iR++;
                }

                sfv_Excel.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (sfv_Excel.ShowDialog() == DialogResult.OK)
                {
                    slMusifan.SaveAs(sfv_Excel.FileName);
                }                
            }
            else
            {
                MessageBox.Show("El archivo no fue cargado para poder crear una lista");
            }

        }
    }    
}
