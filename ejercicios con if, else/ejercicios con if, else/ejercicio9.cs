using System;

namespace EjerciciosLogica
{
    public static class Ejercicio9
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Máquina de Autoservicio de Bebidas ---");
            Console.WriteLine("Menú disponible:");
            Console.WriteLine("1: Café\n2: Té\n3: Chocolate\n4: Capuchino");
            Console.Write("Presione el número de su elección: ");
            string seleccion = Console.ReadLine();

            switch (seleccion)
            {
                case "1": Console.WriteLine("\nBebida seleccionada: Café. Precio: $1.50"); break;
                case "2": Console.WriteLine("\nBebida seleccionada: Té. Precio: $1.25"); break;
                case "3": Console.WriteLine("\nBebida seleccionada: Chocolate. Precio: $2.00"); break;
                case "4": Console.WriteLine("\nBebida seleccionada: Capuchino. Precio: $2.50"); break;
                default:
                    Console.WriteLine("\nInformación: La opción marcada no está disponible.");
                    break;
            }
        }
    }
}