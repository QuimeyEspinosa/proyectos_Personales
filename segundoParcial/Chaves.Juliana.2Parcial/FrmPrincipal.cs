using Chaves.Juliana._2Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesParcial;
using Archivos;
using Excepciones;


namespace Chaves.Juliana._2Parcial
{
    public partial class FrmPrincipal : Form
    {
        Comercio comercio;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.comercio = new Comercio();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
         
            Pedido p = null;
            Hamburguesa h = null;
            if(!(Validaciones.EsNumerico(this.TxtIdCliente.Text) && Validaciones.ContieneLetras(this.TxtNombre.Text) && 
                Validaciones.VerificaDomicilio(this.TxtDireccion.Text) && Validaciones.EsNumerico(this.TxtNumPedido.Text)) && this.CbxHamb.SelectedIndex !=-1)
            {
                int.TryParse(TxtIdCliente.Text, out int idCliente);
                int.TryParse(TxtNumPedido.Text, out int numPedido);
                h = new Hamburguesa((ETipoHamburguesa)this.CbxHamb.SelectedIndex);
                p = new Pedido(h,numPedido,this.TxtNombre.Text, this.TxtDireccion.Text,idCliente);
            }
            try
            {
                this.comercio += p;
                                

            }
            catch (PedidoRepetidoException error)
            {

                MessageBox.Show(error.Message);
            }
            catch(Exception)
            {

            }
            finally
            {
                this.ActualizarEstados();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.comercio.FinHilos();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Pedido>>((IMostrar<List<Pedido>>)comercio);
        }
        /// <summary>
        /// actualiza el estado de cada uno de los listbox segun el estado de los pedidos
        /// </summary>
        private void ActualizarEstados()
        {
            LimpiarListBox();

            foreach (Pedido item in this.comercio.ListaPedidos)
            {
                switch (item.Estado)
                {
                    case Pedido.EEstado.Ingresado:
                        this.LsbPedidos.Items.Add(item);
                        break;

                    case Pedido.EEstado.EnViaje:
                        this.LsbPreparacion.Items.Add(item);
                        break;

                    case Pedido.EEstado.Entregado:
                        this.LsbEntregados.Items.Add(item);
                        break;
                }
            }

            void LimpiarListBox()
            {
                this.LsbPedidos.Items.Clear();
                this.LsbPreparacion.Items.Clear();
                this.LsbEntregados.Items.Clear();
            }

        }
        /// <summary>
        /// Evento que retorna estado del Paquete.
        /// </summary>
        private void PedidoInformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Pedido.DelegadoEstado delegado = new Pedido.DelegadoEstado(PedidoInformaEstado);
                this.Invoke(delegado, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!object.Equals(elemento,null))
            {
                string info = string.Empty;
                Comercio c;
                Pedido p;

                if (elemento is Comercio)
                {
                    c = (Comercio)elemento;
                    foreach (Pedido item in c.ListaPedidos)
                    {
                        info += item.ToString() + "\n";
                    }
                }
                else
                {
                    p = (Pedido)elemento;
                    info += p.ToString() + "\n";
                }

                this.rtbMostrar.Text = info;
                info.Guardar("Pedido");
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                (elemento.MostrarDatos(elemento)).Guardar("Pedido");
            }

        }
    }
}
