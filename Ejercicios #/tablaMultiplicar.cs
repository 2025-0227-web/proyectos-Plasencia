using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class tablaMultiplicar
    {
            public static void Ejecutar()
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
        }
    }

