using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio5
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 5: Descuento por edad ---");
            Console.Write("Ingresa la edad del usuario: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad > 60) Console.WriteLine("Aplica para el descuento del 50% por ser adulto mayor.");
                else Console.WriteLine("No aplica para el descuento.");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}