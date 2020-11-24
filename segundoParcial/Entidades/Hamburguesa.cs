using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesParcial
{
    #region Enumerado
    public enum ETipoHamburguesa
    {
        HamburguesaSimple,
        HamburguesaCompleta,
        HamburguesaVegetariana,
        SinDatos,
    }

    #endregion
    public class Hamburguesa
    {
        #region atributos

        private ETipoHamburguesa tipoHamburguesa;
        #endregion

        #region constructor
        public Hamburguesa(ETipoHamburguesa hamburguesa)
        {
            this.tipoHamburguesa = hamburguesa;
        }
        #endregion

        public string TipoHamburguesa
        {
            get
            {
                string tipo = "";

                switch (tipoHamburguesa)
                {
                    case ETipoHamburguesa.HamburguesaCompleta:
                        tipo = "Hamburguesa completa";
                        break;
                    case ETipoHamburguesa.HamburguesaSimple:
                        tipo = "Hamburguesa simple";
                        break;
                    case ETipoHamburguesa.HamburguesaVegetariana:
                        tipo = "Hamburguesa vegetariana";
                        break;
                    case ETipoHamburguesa.SinDatos:
                        tipo = "Sin datos";
                        break;
                }
                return tipo;
            }
        }
    }
}
