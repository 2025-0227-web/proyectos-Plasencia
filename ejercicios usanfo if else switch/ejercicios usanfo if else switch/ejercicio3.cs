using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 3: Mayor de edad ---");
            Console.Write("Ingresa la edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad >= 18) Console.WriteLine("Es mayor de edad (tiene 18 años o más).");
                else Console.WriteLine("Es menor de edad.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}