using System;

namespace EjerciciosLogica
{
    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Evaluación del Alumno ---");
            Console.Write("Ingrese la calificación numérica del estudiante: ");

            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                if (nota >= 60)
                {
                    Console.WriteLine("\nEstado final: Aprobado. ¡Buen trabajo!");
                }
                else
                {
                    Console.WriteLine("\nEstado final: Reprobado. Requiere reforzamiento.");
                }
            }
            else
            {
                Console.WriteLine("Entrada incorrecta. Ingrese un valor numérico válido.");
            }
        }
    }
}