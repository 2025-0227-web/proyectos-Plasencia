using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio7
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 7: Día de la semana ---");
            Console.Write("Ingresa un número del 1 al 7: ");
            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                switch (dia)
                {
                    case 1: Console.WriteLine("Lunes"); break;
                    case 2: Console.WriteLine("Martes"); break;
                    case 3: Console.WriteLine("Miércoles"); break;
                    case 4: Console.WriteLine("Jueves"); break;
                    case 5: Console.WriteLine("Viernes"); break;
                    case 6: Console.WriteLine("Sábado"); break;
                    case 7: Console.WriteLine("Domingo"); break;
                    default: Console.WriteLine("Número inválido. Debe ser del 1 al 7."); break;
                }
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}