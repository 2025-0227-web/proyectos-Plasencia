using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio14
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 14: Conversión de calificaciones ---");
            Console.Write("Ingresa la calificación numérica (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                if (nota >= 90 && nota <= 100) Console.WriteLine("Letra obtenida: A");
                else if (nota >= 80 && nota < 90) Console.WriteLine("Letra obtenida: B");
                else if (nota >= 70 && nota < 80) Console.WriteLine("Letra obtenida: C");
                else if (nota >= 60 && nota < 70) Console.WriteLine("Letra obtenida: D");
                else if (nota >= 0 && nota < 60) Console.WriteLine("Letra obtenida: F");
                else Console.WriteLine("Calificación inválida.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}