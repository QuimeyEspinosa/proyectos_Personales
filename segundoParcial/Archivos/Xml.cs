using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda un tipo de dato en formato xml.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool ret = false;
            try
            {
                if(!(object.Equals(datos, null) && archivo !=null))
                {
                    using (XmlTextWriter escribeArchivo = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer s = new XmlSerializer(typeof(T));
                        s.Serialize(escribeArchivo, datos);
                        ret = true;
                    }
                       
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
            return ret;
        }

        /// <summary>
        /// Lee un archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, T datos)
        {
            bool ret = false;
            try
            {
                if (!(object.Equals(datos, null) && File.Exists(archivo)))
                {
                    using (XmlTextReader leeArchivo = new XmlTextReader(archivo))
                    {
                        XmlSerializer s = new XmlSerializer(typeof(T));
                        datos = (T)s.Deserialize(leeArchivo);
                        ret = true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }


            return ret;
        }
    }
}
