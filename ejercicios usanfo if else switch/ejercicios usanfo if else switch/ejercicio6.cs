using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio6
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 6: Calificación aprobatoria ---");
            Console.Write("Ingresa la calificación del estudiante (0-100): ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                if (nota >= 60 && nota <= 100) Console.WriteLine("El estudiante aprobó.");
                else if (nota >= 0 && nota < 60) Console.WriteLine("El estudiante reprobó.");
                else Console.WriteLine("Calificación fuera del rango permitido (0-100).");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}