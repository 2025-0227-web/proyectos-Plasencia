

using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 10: Clasificación de ángulos ---");
            Console.Write("Ingresa el valor del ángulo en grados: ");
            if (double.TryParse(Console.ReadLine(), out double angulo))
            {
                if (angulo < 90 && angulo > 0) Console.WriteLine("Es un ángulo agudo.");
                else if (angulo == 90) Console.WriteLine("Es un ángulo recto.");
                else if (angulo > 90 && angulo < 180) Console.WriteLine("Es un ángulo obtuso.");
                else if (angulo == 180) Console.WriteLine("Es un ángulo llano.");
                else Console.WriteLine("Ángulo fuera de las clasificaciones básicas estándar.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}