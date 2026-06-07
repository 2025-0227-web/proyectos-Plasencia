
using System;

namespace EjerciciosLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("         MENÚ DE EJERCICIOS DE LÓGICA        ");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Control de acceso por edad (if/else)");
                Console.WriteLine("2. Sistema de calificaciones (if/else)");
                Console.WriteLine("3. Verificador de números pares/impares (if/else)");
                Console.WriteLine("4. Simulador de cajero automático (if/else)");
                Console.WriteLine("5. Clasificador de temperatura (if/else)");
                Console.WriteLine("6. Selector de días de la semana (switch)");
                Console.WriteLine("7. Calculadora básica (switch)");
                Console.WriteLine("8. Conversor de tipo de usuario (switch)");
                Console.WriteLine("9. Dispensador de bebidas (switch)");
                Console.WriteLine("10. Identificador de estaciones (switch)");
                Console.WriteLine("0. Salir de la aplicación");
                Console.WriteLine("=============================================");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1": Ejercicio1.Ejecutar(); break;
                    case "2": Ejercicio2.Ejecutar(); break;
                    case "3": Ejercicio3.Ejecutar(); break;
                    case "4": Ejercicio4.Ejecutar(); break;
                    case "5": Ejercicio5.Ejecutar(); break;
                    case "6": Ejercicio6.Ejecutar(); break;
                    case "7": Ejercicio7.Ejecutar(); break;
                    case "8": Ejercicio8.Ejecutar(); break;
                    case "9": Ejercicio9.Ejecutar(); break;
                    case "10": Ejercicio10.Ejecutar(); break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}