using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio13
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 13: Verificación de año bisiesto ---");
            Console.Write("Ingresa un año: ");
            if (int.TryParse(Console.ReadLine(), out int anio))
            {
                if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
                    Console.WriteLine($"El año {anio} es bisiesto.");
                else
                    Console.WriteLine($"El año {anio} no es bisiesto.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}