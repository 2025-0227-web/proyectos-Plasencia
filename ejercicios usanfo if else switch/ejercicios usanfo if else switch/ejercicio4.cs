using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio4
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 4: Múltiplo de 5 ---");
            Console.Write("Ingresa un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num % 5 == 0) Console.WriteLine($"El número {num} es múltiplo de 5.");
                else Console.WriteLine($"El número {num} no es múltiplo de 5.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}