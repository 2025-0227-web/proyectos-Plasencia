using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class promedionota
    {
      
            public static void Ejecutar()
            {
                Console.Write("Cantidad de notas: ");
                int cantidad = int.Parse(Console.ReadLine());

                double suma = 0;

                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write($"Nota {i}: ");
                    suma += double.Parse(Console.ReadLine());
                }

                double promedio = suma / cantidad;

                Console.WriteLine($"Promedio: {promedio}");
            }
        }
    }

