

using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio9
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 9: Mayor entre tres números ---");
            Console.Write("Número 1: "); double.TryParse(Console.ReadLine(), out double n1);
            Console.Write("Número 2: "); double.TryParse(Console.ReadLine(), out double n2);
            Console.Write("Número 3: "); double.TryParse(Console.ReadLine(), out double n3);

            double mayor = n1;
            if (n2 > mayor) mayor = n2;
            if (n3 > mayor) mayor = n3;

            Console.WriteLine($"El mayor de los tres números es: {mayor}");
        }
    }
}