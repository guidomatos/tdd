using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpuestosTest
{
    /*
     ** Obtener el IVA a partir del monto de una reserva
     ** Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
     ** Obtener el monto total de la reserva (con impuestos incluidos)
            Impuestos a considerar: iva, ish
            %iva = 0.16
            %ish = 0.03
            monto reserva = 1550
     */
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //Assert
            //iva% = 16%
            //monto reserva = 1550.00
            //1550.00 * .16 = 248.00
            Assert.AreEqual(248.00m, iva);
        }

        [TestMethod]
        public void ISHTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            //ish% = 3%
            //monto reserva = 1550.00
            //1550.00 * .03 = 46.50
            Assert.AreEqual(46.50m, ish);
        }

        [TestMethod]
        public void MontoTotalReservaTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);
            decimal montoTotalReserva = ci.ObtenerMontoTotalReserva(iva, ish, 1550m);

            //Assert
            //iva = 248
            //ish = 46.5
            //monto reserva = 1550
            //1550.00 + 248 + 46.5 = 1844.5
            Assert.AreEqual(1844.5m, montoTotalReserva);
        }
    }
}
