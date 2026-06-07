
using System;

namespace EjerciciosLogica
{
    public static class Ejercicio6
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Conversor de Calendario Digital ---");
            Console.Write("Introduzca un número entero del 1 al 7: ");
            string entrada = Console.ReadLine();

            switch (entrada)
            {
                case "1": Console.WriteLine("\nEl día correspondiente es: Lunes."); break;
                case "2": Console.WriteLine("\nEl día correspondiente es: Martes."); break;
                case "3": Console.WriteLine("\nEl día correspondiente es: Miércoles."); break;
                case "4": Console.WriteLine("\nEl día correspondiente es: Jueves."); break;
                case "5": Console.WriteLine("\nEl día correspondiente es: Viernes."); break;
                case "6": Console.WriteLine("\nEl día correspondiente es: Sábado."); break;
                case "7": Console.WriteLine("\nEl día correspondiente es: Domingo."); break;
                default:
                    Console.WriteLine("\n[Error]: El número ingresado es inválido. Debe estar entre 1 y 7.");
                    break;
            }
        }
    }
}