using System;

namespace EjerciciosLogica
{
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Control de Acceso Automático ---");
            Console.Write("Por favor, introduzca su edad: ");

            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad >= 18)
                {
                    Console.WriteLine("\n[ACCESO PERMITIDO] ¡Bienvenido al establecimiento!");
                }
                else
                {
                    Console.WriteLine("\n[ACCESO DENEGADO] Lo sentimos, debes ser mayor de edad para ingresar.");
                }
            }
            else
            {
                Console.WriteLine("Dato inválido. Asegúrese de ingresar un número entero.");
            }
        }
    }
}