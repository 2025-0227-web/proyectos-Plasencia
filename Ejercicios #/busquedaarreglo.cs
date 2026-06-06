using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios__
{
    internal class busqueda_arreglo
    {
        
            public static void Ejecutar()
            {
                int[] numeros = new int[5];

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("Número a buscar: ");
                int buscar = int.Parse(Console.ReadLine());

                bool encontrado = false;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == buscar)
                    {
                        Console.WriteLine($"Encontrado en la posición {i}");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("Número no encontrado.");
                }
            }
        }
    }

