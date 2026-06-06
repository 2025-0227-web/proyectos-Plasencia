using System;
using System.Collections.Generic;

namespace SistemaPagos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Métodos de Pago (POO) ===\n");

            // 1. Instanciamos los objetos usando Herencia
            TarjetaCredito miTarjeta = new TarjetaCredito("Tarjeta Visa", "1234567890123456", "TX-998877");
            Efectivo miEfectivo = new Efectivo("Pago en Efectivo", 0.10); // 10% de descuento

            // 2. Probamos el Encapsulamiento
            Console.WriteLine("--- Prueba de Encapsulamiento ---");
            miTarjeta.Seguridad.IdTransaccion = "TX-NuevoId123"; // Asignación válida
            miTarjeta.Seguridad.IdTransaccion = "abc"; // Intento inválido (Falla validación)
            Console.WriteLine();

            // 3. Probamos el Polimorfismo y la Abstracción
            Console.WriteLine("--- Prueba de Polimorfismo ---");
            // Agrupamos diferentes métodos de pago en una sola lista de la clase abstracta padre
            List<MetodoPago> pasarelaPagos = new List<MetodoPago> { miTarjeta, miEfectivo };

            double cuentaTotal = 1500.00;

            foreach (var metodo in pasarelaPagos)
            {
                // Cada objeto ejecuta SU propia lógica de ProcesarPago
                metodo.ProcesarPago(cuentaTotal);
                Console.WriteLine("---------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}