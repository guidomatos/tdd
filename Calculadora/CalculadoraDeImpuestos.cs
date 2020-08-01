using System;

namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        const decimal porcentaje = 0.16m;
        public decimal ObtenerIVA(decimal montoReserva) {
            return porcentaje * montoReserva;
        }
        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        {
            return montoReserva * porcentaje;
        }
        public decimal ObtenerMontoTotalReserva(decimal iva, decimal ish, decimal montoReserva)
        {
            return iva + ish + montoReserva;
        }
    }
}
