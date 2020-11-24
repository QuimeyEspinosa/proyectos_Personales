using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    public class Validaciones
    {

        /// <summary>
        /// verifica que la cadena de caracter recibida sea numerica
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns></returns>
        public static bool EsNumerico(string strNum)
        {
            bool ret = false;
            int cont = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                if (char.IsDigit(strNum[i]))
                    cont++;
            }

            if (cont == strNum.Length)
                ret = true;

            return ret;
        }
        /// <summary>
        /// Valida que la cadena ingresada sea numerica y mayor a cero
        /// </summary>
        /// <param name="strNum"></param>
        /// <returns></returns>
        public static bool NumMayorACero(string strNum)
        {
            bool ret = false;
            if (EsNumerico(strNum))
            {
                int.TryParse(strNum, out int auxNum);
                if (auxNum > 0)
                    ret = true;
            }
            return ret;
        }

        /// <summary>
        /// Verifica la cadena recibida contenga letras
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ContieneLetras(string str)
        {
            bool ret = false;

            int cont = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                    cont++;
            }

            if (cont == str.Length)
                ret = true;

            return ret;
        }

        /// <summary>
        /// Verifica que lo que se haya pasado por parametro sea un domicilio (string alfanumerico)
        /// </summary>
        /// <param name="strDom"></param>
        /// <returns></returns>
        public static bool VerificaDomicilio(string strDom)
        {
            bool ret = false;
            int cont = 0;

            for (int i = 0; i < strDom.Length; i++)
            {
                if (char.IsLetter(strDom[i]) || char.IsDigit(strDom[i]) || strDom == " ")
                    cont++;
            }

            if (cont == strDom.Length)
                ret = true;

            return ret;
        }
    }
}
