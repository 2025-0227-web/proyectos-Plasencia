using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio17
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 17: Tipo de triángulo ---");
            Console.Write("Lado 1: "); double.TryParse(Console.ReadLine(), out double l1);
            Console.Write("Lado 2: "); double.TryParse(Console.ReadLine(), out double l2);
            Console.Write("Lado 3: "); double.TryParse(Console.ReadLine(), out double l3);

            if ((l1 + l2 > l3) && (l1 + l3 > l2) && (l2 + l3 > l1))
            {
                if (l1 == l2 && l2 == l3) Console.WriteLine("El triángulo es Equilátero.");
                else if (l1 == l2 || l1 == l3 || l2 == l3) Console.WriteLine("El triángulo es Isósceles.");
                else Console.WriteLine("El triángulo es Escaleno.");
            }
            else Console.WriteLine("Esas medidas no forman un triángulo válido.");
        }
    }
}