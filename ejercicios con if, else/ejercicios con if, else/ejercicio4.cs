using System;

namespace EjerciciosLogica
{
    public static class Ejercicio4
    {
        public static void Ejecutar()
        {
            double saldoDisponible = 8500.50; // Saldo de ejemplo simulado
            Console.WriteLine("--- Cajero Automático ---");
            Console.WriteLine($"Tu saldo disponible actual es de: ${saldoDisponible}");
            Console.Write("Monto en efectivo que deseas retirar: ");

            if (double.TryParse(Console.ReadLine(), out double retiro))
            {
                if (retiro <= saldoDisponible)
                {
                    saldoDisponible -= retiro;
                    Console.WriteLine("\nTransacción autorizada con éxito.");
                    Console.WriteLine($"Por favor, retire su dinero. Nuevo saldo: ${saldoDisponible}");
                }
                else
                {
                    Console.WriteLine("\nOperación cancelada: Fondos Insuficientes.");
                }
            }
            else
            {
                Console.WriteLine("Cantidad digitada no válida.");
            }
        }
    }
}