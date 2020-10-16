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
        SLDocument slMartcar;
        SLDocument slIntermusica;
        SLDocument slHmg;
        SLDocument slMartinBlust;
        SLDocument slChromos;
        string pathMartcar = Application.StartupPath + "\\excels\\Lista_Martcar.xlsx";
        string pathIntermusica = Application.StartupPath + "\\excels\\Lista_Intermusica.xlsx";
        string pathHmg = Application.StartupPath + "\\excels\\Lista_Hmg.xlsx";
        string pathMartinBlust = Application.StartupPath + "\\excels\\Lista_MartinBlust.xlsx";
        string pathChromos = Application.StartupPath + "\\excels\\Lista_Chromos.xlsx";

        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            slIntermusica = new SLDocument(pathIntermusica);
            slMartcar = new SLDocument(pathMartcar);
            slHmg = new SLDocument(pathHmg);
            slMartinBlust = new SLDocument(pathMartinBlust);
            slChromos = new SLDocument(pathChromos);

            if (cargarProductos())
            {
                dgv_Productos.DataSource = Comercio.MisProductos;

                MessageBox.Show("Datos cargados con éxito!",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
            }
        }

        private bool cargarProductos()
        {
            bool pudoCargar = false;


            if (cargarProductosMartcar())
            {
                pudoCargar = true;
            }
            else
            {
                MessageBox.Show("No pudo cargarse los datos de Martcar",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }

            if (cargarProductosIntermusica())
            {
                pudoCargar = true;
            }
            else
            {
                MessageBox.Show("No pudo cargarse los datos de Intermusica",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }

            if (cargarProductosHmg())
            {
                pudoCargar = true;
            }
            else
            {
                MessageBox.Show("No pudo cargarse los datos de Hmg",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }

            if (cargarProductosMartinBlust())
            {
                pudoCargar = true;
            }
            else
            {
                MessageBox.Show("No pudo cargarse los datos de Martin Blust",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }

            if (cargarProductosChromos())
            {
                pudoCargar = true;
            }
            else
            {
                MessageBox.Show("No pudo cargarse los datos de Chromos",
                                            "Carga de datos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }


            return pudoCargar;
        }

        private bool cargarProductosMartcar()
        {
            bool pudoCargar = false;
            Producto nuevoProdMartcar;
            int primerFila = 13;
            int ultimaFila = 1500;
            string auxIva;

            slMartcar.SelectWorksheet("Lista de precios");

            while (primerFila < ultimaFila)
            {
                if (string.IsNullOrEmpty(slMartcar.GetCellValueAsString(primerFila, 3)))
                {
                    primerFila++;
                }
                else
                {
                    if (!(string.IsNullOrEmpty(slMartcar.GetCellValueAsString(primerFila, 3))) &&   //verifica que tenga numero de articulo
                        !(string.IsNullOrEmpty(slMartcar.GetCellValueAsString(primerFila, 4))) &&   //verifica que tenga descripción
                        !(string.IsNullOrEmpty(slMartcar.GetCellValueAsString(primerFila, 7))) &&   //verifica que tenga precio cliente
                        !(string.IsNullOrEmpty(slMartcar.GetCellValueAsString(primerFila, 9))))     //verifica que tenga precio público
                    {
                        nuevoProdMartcar = new Producto();

                        nuevoProdMartcar.Proveedor = "Martcar";
                        nuevoProdMartcar.Marca = slMartcar.GetCellValueAsString(primerFila, 1);
                        nuevoProdMartcar.Rubro = slMartcar.GetCellValueAsString(primerFila, 2);
                        nuevoProdMartcar.NumeroArticulo = slMartcar.GetCellValueAsString(primerFila, 3);
                        nuevoProdMartcar.Descripcion = slMartcar.GetCellValueAsString(primerFila, 4);
                        nuevoProdMartcar.Stock = slMartcar.GetCellValueAsString(primerFila, 6);
                        nuevoProdMartcar.PrecioVentaCliente = "$ " + slMartcar.GetCellValueAsDouble(primerFila, 7).ToString();

                        auxIva = slMartcar.GetCellValueAsString(primerFila, 8).ToString();
                        nuevoProdMartcar.Iva = ConvertIva(auxIva);

                        nuevoProdMartcar.PrecioVentaPublico = "$ " + slMartcar.GetCellValueAsInt32(primerFila, 9).ToString();

                        Comercio.AgregarProducto(nuevoProdMartcar);

                        pudoCargar = true;
                        primerFila++;
                    }
                    else
                    {
                        primerFila++;
                    }
                }
            }

            return pudoCargar;
        }
        private bool cargarProductosIntermusica()
        {
            bool pudoCargar = false;
            Producto nuevoProdIntermusica;
            string auxIva;
            string auxMargenGanancia;
            int fila;

            fila = 10;
            slIntermusica.SelectWorksheet("Lista Nacional");
            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                nuevoProdIntermusica = new Producto("Intermusica");
                nuevoProdIntermusica.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                nuevoProdIntermusica.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                nuevoProdIntermusica.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                nuevoProdIntermusica.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);
                nuevoProdIntermusica.PrecioVentaCliente = "$ " + slIntermusica.GetCellValueAsDouble(fila, 5).ToString();

                auxIva = slIntermusica.GetCellValueAsDouble(fila, 6).ToString();
                nuevoProdIntermusica.Iva = ConvertIva(auxIva);

                auxMargenGanancia = slIntermusica.GetCellValueAsDouble(fila, 7).ToString();
                nuevoProdIntermusica.MargenGanancia = ConvertMargen(auxMargenGanancia);

                nuevoProdIntermusica.PrecioVentaPublico = "$ " + slIntermusica.GetCellValueAsDouble(fila, 8).ToString();
                nuevoProdIntermusica.OrigenProducto = "Nacional";

                Comercio.AgregarProducto(nuevoProdIntermusica);
                fila++;
                pudoCargar = true;
            }

            fila = 10;
            slIntermusica.SelectWorksheet("Lista Importado");
            while (!string.IsNullOrEmpty(slIntermusica.GetCellValueAsString(fila, 1)))
            {
                nuevoProdIntermusica = new Producto("Intermusica");
                nuevoProdIntermusica.NumeroArticulo = slIntermusica.GetCellValueAsString(fila, 1);
                nuevoProdIntermusica.Marca = slIntermusica.GetCellValueAsString(fila, 2);
                nuevoProdIntermusica.Rubro = slIntermusica.GetCellValueAsString(fila, 3);
                nuevoProdIntermusica.Descripcion = slIntermusica.GetCellValueAsString(fila, 4);

                nuevoProdIntermusica.PrecioVentaClienteUSD = "us$ " + slIntermusica.GetCellValueAsDouble(fila, 5).ToString();
                nuevoProdIntermusica.PrecioVentaCliente = "$ " + slIntermusica.GetCellValueAsDouble(fila, 6).ToString();

                auxIva = slIntermusica.GetCellValueAsDouble(fila, 7).ToString();
                nuevoProdIntermusica.Iva = ConvertIva(auxIva);

                auxMargenGanancia = slIntermusica.GetCellValueAsDouble(fila, 8).ToString();
                nuevoProdIntermusica.MargenGanancia = ConvertMargen(auxMargenGanancia);

                nuevoProdIntermusica.PrecioVentaPublicoUSD = "us$ " + slIntermusica.GetCellValueAsDouble(fila, 9).ToString();
                nuevoProdIntermusica.PrecioVentaPublico = "$ " + slIntermusica.GetCellValueAsDouble(fila, 10).ToString();
                nuevoProdIntermusica.OrigenProducto = "Importado";

                Comercio.AgregarProducto(nuevoProdIntermusica);
                fila++;
                pudoCargar = true;
            }

            return pudoCargar;
        }
        private bool cargarProductosHmg()
        {
            bool pudoCargar = false;
            Producto nuevoProdHmg;
            int primerFila = 10;

            while (!string.IsNullOrEmpty(slHmg.GetCellValueAsString(primerFila, 2)))
            {
                nuevoProdHmg = new Producto();

                nuevoProdHmg.Proveedor = "HMG";
                nuevoProdHmg.Rubro = slHmg.GetCellValueAsString(primerFila, 2);
                nuevoProdHmg.Marca = slHmg.GetCellValueAsString(primerFila, 3);
                nuevoProdHmg.NumeroArticulo = slHmg.GetCellValueAsString(primerFila, 4);
                nuevoProdHmg.Descripcion = slHmg.GetCellValueAsString(primerFila, 5);
                nuevoProdHmg.PrecioVentaCliente = "$ " + slHmg.GetCellValueAsDouble(primerFila, 6).ToString();
                nuevoProdHmg.Stock = slHmg.GetCellValueAsString(primerFila, 8);

                nuevoProdHmg.Iva = slHmg.GetCellValueAsDouble(primerFila, 10).ToString() + "%";

                //nuevoProdHmg.MargenGanancia = slHmg.GetCellValueAsString(primerFila, 16);
                nuevoProdHmg.PrecioVentaPublico = "$ " + slHmg.GetCellValueAsDouble(primerFila, 17).ToString();

                Comercio.AgregarProducto(nuevoProdHmg);

                primerFila++;
                pudoCargar = true;
            }

            return pudoCargar;
        }
        private bool cargarProductosMartinBlust()
        {
            bool pudoCargar = false;
            Producto nuevoProdMartinBlust;
            int primerFila;
            int ultimaFila = 110;
            string auxNumArticulo;

            primerFila = 14;
            slMartinBlust.SelectWorksheet("CLÁSICA");

            while (primerFila < ultimaFila)
            {
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";

                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "CLÁSICA";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }


            primerFila = 12;
            slMartinBlust.SelectWorksheet("ELÉCTRICA");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "ELÉCTRICA";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 9;
            slMartinBlust.SelectWorksheet("BAJO ELÉCTRICO");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "BAJO ELÉCTRICO";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 14;
            slMartinBlust.SelectWorksheet("BLACK SOUL");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "BLACK SOUL";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 9;
            slMartinBlust.SelectWorksheet("ACÚSTICA 8020");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "ACÚSTICA 8020";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 10;
            slMartinBlust.SelectWorksheet("BAJO ACÚSTICO 8020");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))) &&
                   !(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 7))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "BAJO ACÚSTICO 8020";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 10;
            slMartinBlust.SelectWorksheet(" ACÚSTICA 8515");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "ACÚSTICA 8515";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 9;
            slMartinBlust.SelectWorksheet("LATINO");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "LATINO";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }


            primerFila = 9;
            slMartinBlust.SelectWorksheet("INTERNACIONAL");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "INTERNACIONAL";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 7).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            primerFila = 6;
            slMartinBlust.SelectWorksheet("ACCESORIOS");
            while (primerFila < ultimaFila)
            {
                if (slMartinBlust.GetCellValueAsString(primerFila, 1) == "CÓDIGO")
                {
                    primerFila++;
                }
                if (!(string.IsNullOrEmpty(slMartinBlust.GetCellValueAsString(primerFila, 1))))
                {
                    nuevoProdMartinBlust = new Producto();

                    nuevoProdMartinBlust.Proveedor = "Martin Blust";
                    auxNumArticulo = slMartinBlust.GetCellValueAsString(primerFila, 1);
                    nuevoProdMartinBlust.NumeroArticulo = RemoveCharsBeforeString(auxNumArticulo);
                    nuevoProdMartinBlust.Rubro = "ACCESORIOS";

                    nuevoProdMartinBlust.Marca = "Martin Blust";
                    nuevoProdMartinBlust.Descripcion = slMartinBlust.GetCellValueAsString(primerFila, 2);
                    nuevoProdMartinBlust.PrecioVentaCliente = "$ " + slMartinBlust.GetCellValueAsDouble(primerFila, 8).ToString();

                    Comercio.AgregarProducto(nuevoProdMartinBlust);

                    primerFila++;
                    pudoCargar = true;
                }
                else
                {
                    primerFila++;
                }
            }

            return pudoCargar;
        }
        private bool cargarProductosChromos()
        {
            bool pudoCargar = false;
            Producto nuevoProdChromos;
            int primerFila = 9;
            int ultimaFila = 200;

            while (primerFila < ultimaFila)
            {
                if (slChromos.GetCellValueAsString(primerFila, 2) == "COD ARTICULO")
                {
                    primerFila++;
                }
                else
                {
                    if (!(string.IsNullOrEmpty(slChromos.GetCellValueAsString(primerFila, 2))) &&
                       !(string.IsNullOrEmpty(slChromos.GetCellValueAsString(primerFila, 4))))
                    {
                        nuevoProdChromos = new Producto();

                        nuevoProdChromos.Proveedor = "Chromos";
                        nuevoProdChromos.NumeroArticulo = slChromos.GetCellValueAsString(primerFila, 2);
                        nuevoProdChromos.Descripcion = slChromos.GetCellValueAsString(primerFila, 3);
                        nuevoProdChromos.PrecioVentaCliente = "$ " + slChromos.GetCellValueAsDouble(primerFila, 4).ToString();

                        if (primerFila < 89)
                        {
                            nuevoProdChromos.Stock = slChromos.GetCellValueAsString(primerFila, 6);
                            nuevoProdChromos.Observacion = slChromos.GetCellValueAsString(primerFila, 5);
                            nuevoProdChromos.PrecioVentaPublico = "$ " + slChromos.GetCellValueAsDouble(primerFila, 7).ToString();
                        }
                        else
                        {
                            nuevoProdChromos.Stock = "N/A";
                            nuevoProdChromos.Observacion = slChromos.GetCellValueAsString(primerFila, 6);
                            nuevoProdChromos.PrecioVentaPublico = slChromos.GetCellValueAsString(primerFila, 5);
                        }

                        Comercio.AgregarProducto(nuevoProdChromos);

                        primerFila++;
                        pudoCargar = true;
                    }
                    else
                    {
                        primerFila++;
                    }


                }
            }

            return pudoCargar;
        }



        private string RemoveCharsBeforeString(string auxString)
        {
            auxString.Trim();

            for (int i = 0; i < auxString.Length; i++)
            {
                if (auxString[i].ToString() == " ")
                {
                    auxString = auxString.Remove(i);
                }
            }

            return auxString;
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
            if (iva != "0")
            {
                if (iva == "0.105")
                {
                    iva = "10,5%";
                }
                else if (iva == "0.21")
                {
                    iva = "21%";
                }
            }

            return iva;
        }
    }
}
