using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string proveedor;
        string numeroArticulo;
        string rubro;
        string marca;
        string descripcion;        
        string stock;
        string iva;
        string margenGanancia;
        string precioVentaCliente;
        string precioVentaPublico;
        string precioVentaClienteUSD;
        string precioVentaPublicoUSD;
        string origenProducto;


        public Producto()
        {
            this.rubro = "Sin asignar";
            this.marca = "Sin asignar";
            this.stock = "Sin asignar";
            this.iva = "Sin asignar";
            this.MargenGanancia = "Sin asignar";
            this.precioVentaCliente = "Sin asignar";
            this.precioVentaPublico = "Sin asignar";
            this.OrigenProducto = "Sin asignar";
            this.precioVentaClienteUSD = "Sin asignar";
            this.precioVentaPublicoUSD = "Sin asignar";
        }

        public Producto(string proveedor, string numeroArticulo) : this()
        {
            this.Proveedor = proveedor;
            this.numeroArticulo = numeroArticulo;
        }

        public Producto(string proveedor,
                        string numeroArticulo,
                        string descripcion,
                        string rubro,
                        string marca,
                        string stock,
                        string iva,
                        string pVentaCliente,
                        string pVentaPublico,
                        string margenGanancia,
                        string origenProducto,
                        string pVentaClienteUSD,
                        string pVentaPublicoUSD) : this(proveedor, numeroArticulo)
        {
            this.rubro = rubro;
            this.marca = marca;
            this.descripcion = descripcion;
            this.stock = stock;
            this.iva = iva;
            this.MargenGanancia = margenGanancia;
            this.precioVentaCliente = pVentaCliente;
            this.precioVentaPublico = pVentaPublico;
            this.OrigenProducto = origenProducto;
            this.precioVentaClienteUSD = pVentaClienteUSD;
            this.precioVentaPublicoUSD = pVentaPublicoUSD;
        }


        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string NumeroArticulo { get => numeroArticulo; set => numeroArticulo = value; }
        public string Rubro { get => rubro; set => rubro = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }        
        public string Stock { get => stock; set => stock = value; }
        public string Iva { get => iva + "%"; set => iva = value; }
        public string MargenGanancia { get => margenGanancia; set => margenGanancia = value; }
        public string PrecioVentaCliente { get => "$" + precioVentaCliente; set => precioVentaCliente = value; }
        public string PrecioVentaPublico { get => "$" + precioVentaPublico; set => precioVentaPublico = value; }
        public string OrigenProducto { get => origenProducto; set => origenProducto = value; }
        public string PrecioVentaClienteUSD { get => "USD " + precioVentaClienteUSD; set => precioVentaClienteUSD = value; }
        public string PrecioVentaPublicoUSD { get => "USD " + precioVentaPublicoUSD; set => precioVentaPublicoUSD = value; }
    }
}
