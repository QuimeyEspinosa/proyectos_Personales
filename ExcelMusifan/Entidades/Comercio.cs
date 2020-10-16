using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        static List<Producto> misProductos;

        static Comercio()
        {
            misProductos = new List<Producto>();
        }

        public static List<Producto> MisProductos
        {
            get { return misProductos; }
            set { misProductos = value; }
        }

        public static void AgregarProducto(Producto auxProducto)
        {
            misProductos.Add(auxProducto);
        }
    }
}
