using System;

namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        const decimal porcentaje = 0.16m;
        public decimal ObtenerIVA(decimal montoReserva) {
            return porcentaje * montoReserva;
        }
    }
}
