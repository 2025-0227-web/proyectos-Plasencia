using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class contador_positivo_y_negativo
    {
       
            public static void Ejecutar()
            {
                int[] numeros = new int[10];

                int positivos = 0;
                int negativos = 0;
                int ceros = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] > 0)
                        positivos++;
                    else if (numeros[i] < 0)
                        negativos++;
                    else
                        ceros++;
                }

                Console.WriteLine($"Positivos: {positivos}");
                Console.WriteLine($"Negativos: {negativos}");
                Console.WriteLine($"Ceros: {ceros}");
            }
        }
    }

