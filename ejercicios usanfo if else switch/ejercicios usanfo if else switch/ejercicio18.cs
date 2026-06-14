using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio18
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 18: Evaluación de temperatura ---");
            Console.Write("Ingresa la temperatura en °C: ");
            if (double.TryParse(Console.ReadLine(), out double temp))
            {
                if (temp < 0) Console.WriteLine("Hace mucho frío");
                else if (temp <= 20) Console.WriteLine("Clima fresco");
                else if (temp <= 30) Console.WriteLine("Clima agradable");
                else Console.WriteLine("Hace mucho calor");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}