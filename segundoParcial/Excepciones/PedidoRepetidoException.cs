using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PedidoRepetidoException : Exception
    {
        /// <summary>
        /// Excepcion que se lanza cuando un pedido esta repetido
        /// </summary>
        /// <param name="e"></param>
        public PedidoRepetidoException(string mensaje) : base(mensaje)
        { 
        
        }

        public PedidoRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
