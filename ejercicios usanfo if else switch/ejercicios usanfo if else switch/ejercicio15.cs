using System;

namespace ejercicios_usanfo_if_else_switch
{

    public static class Ejercicio15
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 15: Comparación de tres longitudes ---");
            Console.Write("Lado 1: "); double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Lado 2: "); double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Lado 3: "); double.TryParse(Console.ReadLine(), out double c);

            if ((a + b > c) && (a + c > b) && (b + c > a))
                Console.WriteLine("Las longitudes SÍ pueden formar un triángulo.");
            else
                Console.WriteLine("Las longitudes NO cumplen la regla de formación de un triángulo.");
        }
    }
}