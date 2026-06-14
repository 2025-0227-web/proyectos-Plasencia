  using System;


namespace ejercicios_usanfo_if_else_switch

{
    public static class Ejercicio8
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 8: Número mayor entre dos ---");
            Console.Write("Ingresa el primer número: ");
            double.TryParse(Console.ReadLine(), out double n1);
            Console.Write("Ingresa el segundo número: ");
            double.TryParse(Console.ReadLine(), out double n2);

            if (n1 > n2) Console.WriteLine($"El mayor es: {n1}");
            else if (n2 > n1) Console.WriteLine($"El mayor es: {n2}");
            else Console.WriteLine("Ambos números son iguales.");
        }
    }
}