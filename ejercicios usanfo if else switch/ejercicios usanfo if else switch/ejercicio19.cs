using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio19
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 19: Conversión de horas a turnos ---");
            Console.Write("Ingresa la hora en formato de 24 horas (0-23): ");
            if (int.TryParse(Console.ReadLine(), out int hora))
            {
                if (hora >= 6 && hora <= 11) Console.WriteLine("Turno: Mañana");
                else if (hora >= 12 && hora <= 17) Console.WriteLine("Turno: Tarde");
                else if (hora >= 18 && hora <= 23) Console.WriteLine("Turno: Noche");
                else if (hora >= 0 && hora <= 5) Console.WriteLine("Turno: Madrugada");
                else Console.WriteLine("Hora fuera del rango establecido (0-23).");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}