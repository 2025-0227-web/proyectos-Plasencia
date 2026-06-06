using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class mayor_y_menor
    {
      
            public static void Ejecutar()
            {
                int[] numeros = new int[10];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                int mayor = numeros[0];
                int menor = numeros[0];

                foreach (int numero in numeros)
                {
                    if (numero > mayor)
                        mayor = numero;

                    if (numero < menor)
                        menor = numero;
                }

                Console.WriteLine($"Mayor: {mayor}");
                Console.WriteLine($"Menor: {menor}");
            }
        }
    }

