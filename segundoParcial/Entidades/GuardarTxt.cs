using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace EntidadesParcial
{
    public static class GuardarTxt
    {
        #region metodo de extension
       /// <summary>
       /// Metodo de extension que guarda un archivo de texto en el escritorio de la computadora
       /// </summary>
       /// <returns></returns>
        public static bool Guardar(this string archivo, string texto)
        {
            string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            try
            {
                StreamWriter f = new StreamWriter(pathEscritorio + archivo + ".txt", true);
                f.WriteLine(texto);
                f.WriteLine(DateTime.Now);
                f.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
 

        #endregion
    }
}
