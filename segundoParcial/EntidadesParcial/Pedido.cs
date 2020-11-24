using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;
//using System.Windows.Forms;

namespace EntidadesParcial
{
    [Serializable]
    public class Pedido : IMostrar<Pedido>
    {
        #region atributos
        private Hamburguesa hamb;
        private int idPedido;
        private string nombre;
        private string direccion;
        private int numeroCliente;
        private EEstado estado;
        #endregion

        #region Propiedades

        public Hamburguesa Hamb
        {
            get { return this.hamb; }
            set { this.hamb = value; }
        }
        public int IdPedido
        {
            get { return this.idPedido; }
            set { this.idPedido = value; }
        }

        public int NumeroCliente
        {
            get { return this.numeroCliente; }
            set { this.numeroCliente = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        
        #endregion

        #region enumerado
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #endregion

        #region constructor
        /// <summary>
        /// Constructor de instancia
        /// </summary>
        public Pedido()
        {

        }
        /// <summary>
        /// constructor de instancia
        /// </summary>
        /// <param name="hamb"></param>
        /// <param name="idPedido"></param>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        public Pedido(Hamburguesa hamb, int idPedido, string nombre, string direccion, int numCliente)
        {
            this.hamb = hamb;
            this.idPedido = idPedido;
            this.nombre = nombre;
            this.direccion = direccion;
            this.numeroCliente = numCliente;
            this.estado = EEstado.Ingresado;
        }

        #endregion

        #region metodos
        /// <summary>
        /// Dos pedidos son iguales si el numero de IdPedido es el mismo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pedido p1, Pedido p2)
        {
            if (!(object.Equals(p1, null)) && !(object.Equals(p2, null)))
            {
                if (p1.idPedido == p2.idPedido)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Dos pedidos son distintos si el numero de IdPedido es distinto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pedido p1, Pedido p2)
        {
            return !(p1==p2);
        }
        /*
        public bool Guardar(Pedido pedido)
        {
            bool rtn = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;

            ArchivoXml<Pedido> auxTexto = new ArchivoXml<Pedido>();
            rtn = auxTexto.Guardar(path + @"Pedido.txt", pedido); // probar si funciona asi, estaba con el tostring de abajo

            return rtn;
        }
        */
        public static bool GuardarXml(Pedido pedido)
        {
            bool ret = false;
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Pedido.xml";

         //   ret = Guardar(ruta, pedido);

     
            return ret;
        }
        #region delegado
        public delegate void DelegadoEstado(object sender, EventArgs e);
        #endregion

        #region evento
        public event DelegadoEstado InformaEstado;
        #endregion

        /// <summary>
        /// Devuelve un string con todos los datos de un pedido
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}",this.MostrarDatos(this));
          //  sb.AppendFormat("0", this.Nombre); no iria xq ya esta en mostrarDatos
          //  sb.AppendFormat("{0}", this.Direccion);
            sb.AppendFormat("{}",this.NumeroCliente);
            sb.AppendFormat("{0}", this.Estado.ToString());
            return sb.ToString();
        }
        public string MostrarDatos(IMostrar<Pedido> elemento)
        {
            Pedido p = (Pedido)elemento;

            return string.Format("Pedido {0} - {1} -Cliente {2} - direccion {3}", p.idPedido, p.hamb.TipoHamburguesa,p.nombre, p.direccion); // ver si asi funciona Hamburguesa o lo hago a to string
        }
        /// <summary>
        /// se va ordenando el tiempo de vida de cada hilo y de acuerdo a ello el estado que tiene el pedido
        /// a medida que ingresa un pedido se va guardando en la base
        /// </summary>
        public void TiempoHilos()
        {
            try
            {

                while(this.Estado != EEstado.Entregado)
                {
                    if(this.Estado == EEstado.Ingresado)
                    {
                        Thread.Sleep(400);
                        this.Estado = EEstado.EnViaje;
                        this.InformaEstado(this.Estado, EventArgs.Empty);
                    }
                    else
                    {
                        Thread.Sleep(400);
                        this.Estado = EEstado.Entregado;
                        this.InformaEstado(this.Estado, EventArgs.Empty);
                    }
                    //GUARDO EN LA BASE
                    PedidoDAO.GuardoEnBase(this);
                }

            }
            catch (Exception)
            {
            }
        }
        #endregion
    }






}
