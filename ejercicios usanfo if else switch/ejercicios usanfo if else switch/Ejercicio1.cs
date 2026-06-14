using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 1: Número positivo, negativo o cero ---");
            Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num > 0) Console.WriteLine("El número es positivo.");
                else if (num < 0) Console.WriteLine("El número es negativo.");
                else Console.WriteLine("El número es cero.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}
