using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Producto
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

        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string NumeroArticulo { get => numeroArticulo; set => numeroArticulo = value; }
        public string Rubro { get => rubro; set => rubro = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Iva { get => iva; set => iva = value; }
        public string MargenGanancia { get => margenGanancia; set => margenGanancia = value; }
        public string PrecioVentaCliente { get => precioVentaCliente; set => precioVentaCliente = value; }
        public string PrecioVentaPublico { get => precioVentaPublico; set => precioVentaPublico = value; }
        public string PrecioVentaClienteUSD { get => precioVentaClienteUSD; set => precioVentaClienteUSD = value; }
        public string PrecioVentaPublicoUSD { get => precioVentaPublicoUSD; set => precioVentaPublicoUSD = value; }
        public string OrigenProducto { get => origenProducto; set => origenProducto = value; }

        public Producto()
        {
            this.NumeroArticulo = "Sin asignar";
            this.Rubro = "Sin asignar";
            this.Marca = "Sin asignar";
            this.Stock = "Sin asignar";
            this.Iva = "Sin asignar";
            this.MargenGanancia = "Sin asignar";
            this.PrecioVentaCliente = "Sin asignar";
            this.PrecioVentaPublico = "Sin asignar";
            this.OrigenProducto = "Sin asignar";
            this.PrecioVentaClienteUSD = "N/A";
            this.PrecioVentaPublicoUSD = "N/A";
        }

        public Producto(string proveedor) : this()
        {
            this.Proveedor = proveedor;
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
                        string pVentaPublicoUSD) : this(proveedor)
        {
            this.NumeroArticulo = numeroArticulo;
            this.Descripcion = descripcion;
            this.Rubro = rubro;
            this.Marca = marca;
            this.Stock = stock;
            this.Iva = iva;
            this.MargenGanancia = margenGanancia;
            this.PrecioVentaCliente = pVentaCliente;
            this.PrecioVentaPublico = pVentaPublico;
            this.OrigenProducto = origenProducto;
            this.PrecioVentaClienteUSD = pVentaClienteUSD;
            this.PrecioVentaPublicoUSD = pVentaPublicoUSD;
        }
    }
}
