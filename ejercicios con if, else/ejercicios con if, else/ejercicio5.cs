using System;

namespace EjerciciosLogica
{
    public static class Ejercicio5
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Monitor Meteorológico de Temperatura ---");
            Console.Write("Ingrese la temperatura actual en grados Celsius: ");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                if (celsius < 15)
                {
                    Console.WriteLine("\nAlerta activa: Clima Frío.");
                }
                else if (celsius >= 15 && celsius <= 28)
                {
                    Console.WriteLine("\nCondición actual: Clima Templado.");
                }
                else
                {
                    Console.WriteLine("\nAlerta activa: Clima Cálido.");
                }
            }
            else
            {
                Console.WriteLine("Error al leer el sensor. Asegúrese de escribir un número.");
            }
        }
    }
}