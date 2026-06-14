using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio12
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 12: Clasificación de números ---");
            Console.Write("Número 1: "); double.TryParse(Console.ReadLine(), out double n1);
            Console.Write("Número 2: "); double.TryParse(Console.ReadLine(), out double n2);
            Console.Write("Número 3: "); double.TryParse(Console.ReadLine(), out double n3);

            if (n1 > 0 && n2 > 0 && n3 > 0) Console.WriteLine("Todos son positivos.");
            else if (n1 < 0 && n2 < 0 && n3 < 0) Console.WriteLine("Todos son negativos.");
            else if (n1 == 0 || n2 == 0 || n3 == 0) Console.WriteLine("Hay ceros en el grupo.");
            else Console.WriteLine("Son mixtos (positivos y negativos).");
        }
    }
}