using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 2: Número par o impar ---");
            Console.Write("Ingresa un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num % 2 == 0) Console.WriteLine($"El número {num} es PAR.");
                else Console.WriteLine($"El número {num} es IMPAR.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}