using System;

namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        public decimal ObtenerIVA(decimal montoReserva) {
            const decimal porcentaje = 0.16m;
            decimal ivaReserva = porcentaje * montoReserva;
            return ivaReserva;
        }
    }
}
