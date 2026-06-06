using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class arreglo_numeros
    {
        
            public static void Ejecutar()
            {
                int[] numeros = new int[5];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nNúmeros ingresados:");

                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }

