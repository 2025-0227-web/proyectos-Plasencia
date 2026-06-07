using System;

namespace EjerciciosLogica
{
    public static class Ejercicio7
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Calculadora Básica ---");
            Console.Write("Primer número: ");
            double.TryParse(Console.ReadLine(), out double n1);

            Console.Write("Segundo número: ");
            double.TryParse(Console.ReadLine(), out double n2);

            Console.Write("Seleccione el símbolo de la operación (+, -, *, /): ");
            string operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"\nResultado de la suma: {n1 + n2}");
                    break;
                case "-":
                    Console.WriteLine($"\nResultado de la resta: {n1 - n2}");
                    break;
                case "*":
                    Console.WriteLine($"\nResultado de la multiplicación: {n1 * n2}");
                    break;
                case "/":
                    if (n2 != 0)
                        Console.WriteLine($"\nResultado de la división: {n1 / n2}");
                    else
                        Console.WriteLine("\nError: No es matemáticamente posible dividir entre cero.");
                    break;
                default:
                    Console.WriteLine("\nOperador no reconocido por el sistema.");
                    break;
            }
        }
    }
}