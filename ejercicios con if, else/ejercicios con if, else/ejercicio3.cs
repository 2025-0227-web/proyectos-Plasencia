using System;

namespace EjerciciosLogica
{
    public static class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Herramienta de Análisis Matemático ---");
            Console.Write("Escriba un número entero: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"\nEl número {numero} está clasificado como: Número Par.");
                }
                else
                {
                    Console.WriteLine($"\nEl número {numero} está clasificado como: Número Impar.");
                }
            }
            else
            {
                Console.WriteLine("Error: Debe digitar obligatoriamente un número entero.");
            }
        }
    }
}