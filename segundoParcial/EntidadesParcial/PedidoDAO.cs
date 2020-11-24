using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace EntidadesParcial
{
    public class PedidoDAO
    {
        const string conexionStr = "Data Source=[DESKTOP-MACDNF9\\SQLEXPRESS]; Initial Catalog=[Parcial]; integrated security = true";

        #region atributos

        static SqlConnection conexionBD;

        #endregion


        #region constructor

        static PedidoDAO()
        {
            conexionBD = new SqlConnection();
            conexionBD.ConnectionString = conexionStr;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Recibe un pedido por parametro y lo inserta en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static void GuardoEnBase(Pedido p)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[Pedidos] VALUES(@Hamburguesa,@NombreCliente,@DireccionCliente,@IdCliente)"; // probar si va asi o en minuscula cada nombre

                comando.Parameters.Add(new SqlParameter("@Hamburgesa",p.Hamb.TipoHamburguesa)); // va con tostring()?
                comando.Parameters.Add(new SqlParameter("@Nombre", p.Nombre));
                comando.Parameters.Add(new SqlParameter("@Direccion",p.Direccion));
                comando.Parameters.Add(new SqlParameter("@IdPedido",p.IdPedido));
                
                if (conexionBD.State != ConnectionState.Open)
                    conexionBD.Open();

                comando.ExecuteNonQuery();
               }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
            finally
            {
                conexionBD.Close();
            }
           }
        /// <summary>
        /// recibe un string por parametro y devuelve un enum de ETipoHamburguesa correspondiente
        /// </summary>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static ETipoHamburguesa MapeoHamburguesa(string aux)
        {
            switch(aux)
            {
                case "Hamburguesa completa":
                    return ETipoHamburguesa.HamburguesaCompleta;
                case "Hamburguesa simple":
                    return ETipoHamburguesa.HamburguesaSimple;
                case "Hamburguesa Vegetariana":
                    return ETipoHamburguesa.HamburguesaVegetariana;
                default:
                    return ETipoHamburguesa.SinDatos;
            }
        }
        /// <summary>
        /// Retorna en una lista de tipo Pedido, los pedidos guardados en la base de datos
        /// No lo utilizo en el codigo actual
        /// </summary>
        /// <returns></returns>
        public static List<Pedido> GetPedidos()
        {
            List<Pedido> auxPedido = new List<Pedido>();
            try
            {
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexionBD;
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM PEDIDOS";

                SqlDataReader datosPedidos = comando.ExecuteReader();

                while(datosPedidos.Read())
                {
                    auxPedido.Add(new Pedido(new Hamburguesa(MapeoHamburguesa(datosPedidos["Hamburguesa"].ToString())),
                                            int.Parse(datosPedidos["IdPedido"].ToString()), 
                                            datosPedidos["NombreCliente"].ToString(), 
                                            datosPedidos["DireccionCliente"].ToString(), 
                                            int.Parse(datosPedidos["NumeroCliente"].ToString())));
                }

            }
            catch (Exception)
            {
            
            }
            finally
            {
                conexionBD.Close();
            }
            return auxPedido;

        }
        #endregion
    }
}
