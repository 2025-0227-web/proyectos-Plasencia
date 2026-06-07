using System;

namespace EjerciciosLogica
{
    public static class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Identificador de Estaciones (Automatización de Jardinería) ---");
            Console.Write("Escriba el nombre de un mes (ej. Enero, Julio...): ");
            string mes = Console.ReadLine().Trim().ToLower();

            // Clasificación estándar basada en trimestres comunes
            switch (mes)
            {
                case "diciembre":
                case "enero":
                case "febrero":
                    Console.WriteLine("\nEstación: Invierno.");
                    break;
                case "marzo":
                case "abril":
                case "mayo":
                    Console.WriteLine("\nEstación: Primavera.");
                    break;
                case "junio":
                case "julio":
                case "agosto":
                    Console.WriteLine("\nEstación: Verano.");
                    break;
                case "septiembre":
                case "octubre":
                case "noviembre":
                    Console.WriteLine("\nEstación: Otoño.");
                    break;
                default:
                    Console.WriteLine("\nEl texto ingresado no coincide con ningún mes del año conocido.");
                    break;
            }
        }
    }
}