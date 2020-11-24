using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {

        /// <summary>
        /// Excepcion que se lanza cuando el ocurre un error al guardar o leer un archivo xml.
        /// </summary>
        /// <param name="e"></param>
        public ArchivosException(Exception e) : base("Archivo excepcion")
        {

        }
    }
}
