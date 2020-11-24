using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesParcial;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidarDosPedidos()
        {
            Comercio c = new Comercio();
            try
            {
                Pedido pedido1 = new Pedido(new Hamburguesa(ETipoHamburguesa.HamburguesaCompleta), 13, "maria","mitre123",9);
                Pedido pedido2 = new Pedido(new Hamburguesa(ETipoHamburguesa.HamburguesaCompleta), 13, "maria", "mitre123", 9);

                c += pedido1;
                c += pedido2;

            }
            catch (Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(PedidoRepetidoException));
            }
        }
    }
}
