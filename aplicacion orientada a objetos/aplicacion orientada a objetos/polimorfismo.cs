using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagos
{
    // POLIMORFISMO / HERENCIA: Otra forma distinta de pagar
    public class Efectivo : MetodoPago
    {
        public double Descuento { get; set; } // Porcentaje de descuento (ej. 0.10 para 10%)

        public Efectivo(string nombreMetodo, double descuento)
            : base(nombreMetodo)
        {
            Descuento = descuento;
        }

        // POLIMORFISMO: Cambia por completo el comportamiento de ProcesarPago
        public override void ProcesarPago(double monto)
        {
            double montoFinal = monto * (1 - Descuento);
            Console.WriteLine($"Procesando pago con {NombreMetodo}.");
            Console.WriteLine($"Monto original: ${monto} -> Monto con descuento aplicado: ${montoFinal}");
        }
    }
}

