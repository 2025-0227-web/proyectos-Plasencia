using System;
using System.Collections.Generic;
using System.Text;
namespace SistemaPagos
{
    // HERENCIA: TarjetaCredito extiende de MetodoPago
    public class TarjetaCredito : MetodoPago
    {
        public string NumeroTarjeta { get; set; }
        public TransaccionSegura Seguridad { get; set; } // Composición

        public TarjetaCredito(string nombreMetodo, string numeroTarjeta, string idSeguridad)
            : base(nombreMetodo) // Envía el nombre a la clase padre
        {
            NumeroTarjeta = numeroTarjeta;
            Seguridad = new TransaccionSegura(idSeguridad);
        }

        // Implementación obligatoria del método abstracto
        public override void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago de ${monto} con {NombreMetodo} (Tarjeta: ****{NumeroTarjeta.Substring(NumeroTarjeta.Length - 4)}).");
            Console.WriteLine($"Transacción validada con Token: {Seguridad.IdTransaccion}");
        }
    }
}
