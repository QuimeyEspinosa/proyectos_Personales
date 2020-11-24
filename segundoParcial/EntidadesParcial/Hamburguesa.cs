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
                switch (tipoHamburguesa)
                {
                    case ETipoHamburguesa.HamburguesaCompleta:
                        return "Hamburguesa completa";
                    case ETipoHamburguesa.HamburguesaSimple:
                        return "Hamburguesa simple";
                    case ETipoHamburguesa.HamburguesaVegetariana:
                        return "Hamburguesa vegetariana";
                    case ETipoHamburguesa.SinDatos:
                        return "Sin datos";
                }
            }
        }
    }
}
