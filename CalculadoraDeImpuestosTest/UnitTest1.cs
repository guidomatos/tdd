using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpuestosTest
{
    /*
     * Obtener el IVA a partir del monto de una reserva
     * Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
     * Obtener el monto total de la reserva (con impuestos incluidos)
     */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00);

            //Assert
            //iva% = 16%
            //monto reserva = 1550.00
            //1550.00 * .16 = 248.00
            Assert.AreEqual(248.00);
        }
    }
}
