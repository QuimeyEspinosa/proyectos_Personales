using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IArchivo<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Leer(string archivo, T datos);


        /*
         * 
         *   /// <summary>
        /// serializa un objeto en un archivo xml
        /// </summary>
        /// <returns></returns>

        public static T Desearealizar()
        {
            T aux = default(T);
            //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ConfiguracionApp.xml"; // probar esto
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Pedido.xml";
            try
            {

                //Utilizo un objeto de tipo XmlTextReader para poder leer de un archivo XML.
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    //Utilizo un objeto de tipo XmlSerializer para deserializar la lista genérica.
                    XmlSerializer ser = new XmlSerializer((typeof(T)));

                    //Deserializo
                    aux = (T)ser.Deserialize(reader);
                }

                return aux;
            }
            catch (Exception e)
            {
                throw new ExcepcionArchivos(e);
            }
        }

        public static bool Serializar(string ruta, T datos)
        {
          //  string ruta = AppDomain.CurrentDomain.BaseDirectory + "Pedido.xml";
            bool ret = false;
            try
            {
                //escribe
                using (XmlTextWriter auxArchivo = new XmlTextWriter(ruta, Encoding.UTF8)) 
                {
                    XmlSerializer auxEscribe = new XmlSerializer(typeof(T));
                    auxEscribe.Serialize(auxArchivo,datos);
                    ret = true;
                  }
            }
            catch(Exception e)
            {
                throw new ExcepcionArchivos(e);
            }
            return ret;
        }
        /*
        #region metodos
        /// <summary>
        /// Guarda en formato serializado .xml cualquier tipo de clase.
        /// </summary>
        /// <param name="archivo"> Parth del archivo</param>
        /// <param name="datos"> Cualquier tipo de dato a guardar</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            bool ret = false;
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                StreamWriter f = new StreamWriter(archivo);
                s.Serialize(f, datos);
                f.Close();
                ret = true;
            }
            catch (Exception e)
            {
                throw new ExcepcionArchivos(e);
            }

            return ret;
        }

        /// <summary>
        /// Le� archivo serializado .xml y retorna el tipo de clase en salida por parametro.
        /// </summary>
        /// <param name="archivo"> Path del archivo </param>
        /// <param name="datos"> Salida de cualquier tipo de dato leido </param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            bool ret = false;// probar si saco el ret, si no rompe

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                StreamReader f = new StreamReader(archivo);
                datos = (T)s.Deserialize(f);
                f.Close();
                ret = true;
            }
            catch (Exception e)
            {
                throw new ExcepcionArchivos(e);
            }

            return ret;
        }
        #endregion


        */
         
    }
}
