using ejercicios_usanfo_if_else_switch;
using System;

namespace EjerciciosSeleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=========================================================");
                Console.WriteLine("        MENÚ INTERACTIVO: 20 EJERCICIOS DE C#            ");
                Console.WriteLine("=========================================================");
                Console.ResetColor();

                Console.WriteLine(" 1. Número positivo, negativo o cero");
                Console.WriteLine(" 2. Número par o impar");
                Console.WriteLine(" 3. Mayor de edad");
                Console.WriteLine(" 4. Múltiplo de 5");
                Console.WriteLine(" 5. Descuento por edad");
                Console.WriteLine(" 6. Calificación aprobatoria");
                Console.WriteLine(" 7. Día de la semana");
                Console.WriteLine(" 8. Número mayor entre dos");
                Console.WriteLine(" 9. Mayor entre tres números");
                Console.WriteLine("10. Clasificación de ángulos");
                Console.WriteLine("11. Cálculo de impuestos");
                Console.WriteLine("12. Clasificación de números (Signos)");
                Console.WriteLine("13. Verificación de año bisiesto");
                Console.WriteLine("14. Conversión de calificaciones a letras");
                Console.WriteLine("15. Comparación de tres longitudes (Triángulo)");
                Console.WriteLine("16. Calculadora de descuentos");
                Console.WriteLine("17. Tipo de triángulo");
                Console.WriteLine("18. Evaluación de temperatura");
                Console.WriteLine("19. Conversión de horas a turnos");
                Console.WriteLine("20. Clasificación de IMC");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" 0. Salir del programa");
                Console.ResetColor();
                Console.WriteLine("=========================================================");
                Console.Write("Selecciona una opción (0-20): ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1: Ejercicio1.Ejecutar(); break;
                        case 2: Ejercicio2.Ejecutar(); break;
                        case 3: Ejercicio3.Ejecutar(); break;
                        case 4: Ejercicio4.Ejecutar(); break;
                        case 5: Ejercicio5.Ejecutar(); break;
                        case 6: Ejercicio6.Ejecutar(); break;
                        case 7: Ejercicio7.Ejecutar(); break;
                        case 8: Ejercicio8.Ejecutar(); break;
                        case 9: Ejercicio9.Ejecutar(); break;
                        case 10: Ejercicio10.Ejecutar(); break;
                        case 11: Ejercicio11.Ejecutar(); break;
                        case 12: Ejercicio12.Ejecutar(); break;
                        case 13: Ejercicio13.Ejecutar(); break;
                        case 14: Ejercicio14.Ejecutar(); break;
                        case 15: Ejercicio15.Ejecutar(); break;
                        case 16: Ejercicio16.Ejecutar(); break;
                        case 17: Ejercicio17.Ejecutar(); break;
                        case 18: Ejercicio18.Ejecutar(); break;
                        case 19: Ejercicio19.Ejecutar(); break;
                        case 20: Ejercicio20.Ejecutar(); break;
                        case 0:
                            continuar = false;
                            Console.WriteLine("Saliendo del programa... ¡Éxito!");
                            break;
                        default:
                            Console.WriteLine("Opción fuera de rango. Elige entre 0 y 20.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número entero válido.");
                    opcion = -1;
                }

                if (opcion != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }
    }
}