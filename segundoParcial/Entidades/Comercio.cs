using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Excepciones;
using Archivos;

namespace EntidadesParcial
{
    public class Comercio : IMostrar<List<Pedido>>
    {

        #region atributos

        private List<Thread> hilosPedidos;
        private List<Pedido> listaPedidos;

        #endregion

        #region propiedades

        public List<Pedido> ListaPedidos
        {
            get { return this.listaPedidos; }
            set { this.listaPedidos = value; }
        }

        #endregion


        #region constructor
        public Comercio()
        {
            this.hilosPedidos = new List<Thread>();
            this.listaPedidos = new List<Pedido>();
        }
        #endregion

        #region metodos

        /// <summary>
        /// Retorna la informacion de cada uno de los pedidos
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Pedido>> elemento)
        {
            Comercio c = (Comercio)elemento;
            StringBuilder sb = new StringBuilder();
            foreach (Pedido item in c.ListaPedidos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Aborta los hilos que esten corriendo
        /// </summary>
        public void FinHilos()
        { 
            if(!object.Equals(this.hilosPedidos,null))
            {
                foreach (Thread item in this.hilosPedidos)
                {
                    if (item.IsAlive)
                        item.Abort();
                }
            }
        }

        /// <summary>
        /// Suma un pedido a la lista de pedidos, en caso que este repetido, lanza una excepcion
        /// retorna un comercio
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Comercio operator +(Comercio c, Pedido p)
        {

            bool flag = false;

            if(!object.Equals(p,null))
            {
                foreach (Pedido item in c.ListaPedidos)
                {
                    if(item == p)
                    {
                        flag = false;
                        throw new PedidoRepetidoException("El pedido ya fue realizado");
                    }
                       
                }
            }

            if(!flag)
            {
                c.listaPedidos.Add(p);

                Thread hiloNuevo = new Thread(p.TiempoHilos);
                c.hilosPedidos.Add(hiloNuevo);
                hiloNuevo.Start();
            }


            return c;
        }

        #endregion
    }
}
