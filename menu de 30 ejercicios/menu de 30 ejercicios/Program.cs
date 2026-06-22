using System;

namespace LaboratorioEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("=================================================");
                Console.WriteLine("          SISTEMA DE EJERCICIOS COMPLETOS        ");
                Console.WriteLine("=================================================");
                Console.WriteLine("1. Estructuras Secuenciales (Ejercicios 01 al 10)");
                Console.WriteLine("2. Estructuras Condicionales (Ejercicios 11 al 20)");
                Console.WriteLine("3. Estructuras Cíclicas (Ejercicios 21 al 30)");
                Console.WriteLine("4. Salir del programa");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Seleccione una categoría: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": CategoriaSecuenciales(); break;
                    case "2": CategoriaCondicionales(); break;
                    case "3": CategoriaCiclicas(); break;
                    case "4": Console.WriteLine("\nSaliendo del programa... ¡Éxitos!"); break;
                    default:
                        Console.WriteLine("Opción inválida. Presione Enter para intentar de nuevo.");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != "4");
        }

        // =========================================================
        // CATEGORÍA 1: SECUENCIALES (EJERCICIOS DEL 1 AL 10)
        // =========================================================
        static void CategoriaSecuenciales()
        {
            string opc;
            do
            {
                Console.Clear();
                Console.WriteLine("--- ESTRUCTURAS SECUENCIALES (01-10) ---");
                Console.WriteLine(" 1. Ejercicio 01 (Salario Simple)");
                Console.WriteLine(" 2. Ejercicio 02 (Segundos a Minutos)");
                Console.WriteLine(" 3. Ejercicio 03 (Minutos a Días y Horas)");
                Console.WriteLine(" 4. Ejercicio 04 (Área de Triángulo)");
                Console.WriteLine(" 5. Ejercicio 05 (Hipotenusa)");
                Console.WriteLine(" 6. Ejercicio 06 (Circunferencia)");
                Console.WriteLine(" 7. Ejercicio 07 (Raíz y Cubo)");
                Console.WriteLine(" 8. Ejercicio 08 (Calculadora Básica)");
                Console.WriteLine(" 9. Ejercicio 09 (Suma de dos valores)");
                Console.WriteLine("10. Ejercicio 10 (Separar parte fraccionaria)");
                Console.WriteLine(" 0. Volver al menú principal");
                Console.WriteLine("----------------------------------------");
                Console.Write("Seleccione un ejercicio: ");
                opc = Console.ReadLine();

                if (opc == "0") return;

                Console.Clear();
                switch (opc)
                {
                    case "1":
                        {
                            Console.WriteLine("--- EJERCICIO 01: Salario Simple ---");
                            Console.Write("Ingrese horas trabajadas: ");
                            double horas = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese tarifa por hora: ");
                            double tarifa = double.Parse(Console.ReadLine());
                            Console.WriteLine("El salario es: " + (horas * tarifa));
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("--- EJERCICIO 02: Segundos a Minutos ---");
                            Console.Write("Ingrese el tiempo en segundos: ");
                            int segs = int.Parse(Console.ReadLine());
                            int min = segs / 60;
                            int rest = segs % 60;
                            Console.WriteLine("Equivale a " + min + " minutos y " + rest + " segundos.");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("--- EJERCICIO 03: Minutos a Días/Horas/Minutos ---");
                            Console.Write("Ingrese tiempo en minutos: ");
                            int totalMin = int.Parse(Console.ReadLine());
                            int dias = totalMin / 1440;
                            int residuo = totalMin % 1440;
                            int horas = residuo / 60;
                            int min = residuo % 60;
                            Console.WriteLine("Equivale a " + dias + " dias, " + horas + " horas y " + min + " minutos.");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("--- EJERCICIO 04: Área de Triángulo ---");
                            Console.Write("Ingrese base: ");
                            double b = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese altura: ");
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine("El área es: " + ((b * h) / 2));
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("--- EJERCICIO 05: Hipotenusa ---");
                            Console.Write("Cateto 1: ");
                            double c1 = double.Parse(Console.ReadLine());
                            Console.Write("Cateto 2: ");
                            double c2 = double.Parse(Console.ReadLine());
                            double hip = Math.Sqrt((c1 * c1) + (c2 * c2));
                            Console.WriteLine("La hipotenusa es: " + Math.Round(hip, 2));
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("--- EJERCICIO 06: Circunferencia ---");
                            Console.Write("Ingrese el radio: ");
                            double r = double.Parse(Console.ReadLine());
                            Console.WriteLine("Longitud: " + Math.Round(2 * Math.PI * r, 2));
                            Console.WriteLine("Área: " + Math.Round(Math.PI * r * r, 2));
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("--- EJERCICIO 07: Raíz y Cubo ---");
                            Console.Write("Ingrese número: ");
                            double n = double.Parse(Console.ReadLine());
                            Console.WriteLine("Raíz cuadrada: " + Math.Round(Math.Sqrt(n), 2));
                            Console.WriteLine("Cubo: " + Math.Pow(n, 3));
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine("--- EJERCICIO 08: Calculadora Básica ---");
                            Console.Write("Primer número: ");
                            double n1 = double.Parse(Console.ReadLine());
                            Console.Write("Segundo número: ");
                            double n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Suma: " + (n1 + n2));
                            Console.WriteLine("Resta: " + (n1 - n2));
                            Console.WriteLine("Multiplicación: " + (n1 * n2));
                            if (n2 != 0) Console.WriteLine("División: " + (n1 / n2));
                            else Console.WriteLine("No se puede dividir por cero.");
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine("--- EJERCICIO 09: Suma de Números ---");
                            Console.Write("Ingrese valor A: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese valor B: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("La suma total es: " + (a + b));
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine("--- EJERCICIO 10: Parte Fraccionaria ---");
                            Console.Write("Ingrese número con decimales: ");
                            double num = double.Parse(Console.ReadLine());
                            int entera = (int)num;
                            double fraccion = num - entera;
                            Console.WriteLine("Parte entera: " + entera);
                            Console.WriteLine("Parte fraccionaria: " + Math.Round(fraccion, 4));
                            break;
                        }
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();

            } while (opc != "0");
        }

        // =========================================================
        // CATEGORÍA 2: CONDICIONALES (EJERCICIOS DEL 11 AL 20)
        // =========================================================
        static void CategoriaCondicionales()
        {
            string opc;
            do
            {
                Console.Clear();
                Console.WriteLine("--- ESTRUCTURAS CONDICIONALES (11-20) ---");
                Console.WriteLine("11. Ejercicio 11 (Salario y Horas Extras)");
                Console.WriteLine("12. Ejercicio 12 (Descuento de Sueldo)");
                Console.WriteLine("13. Ejercicio 13 (Descuento por Monto)");
                Console.WriteLine("14. Ejercicio 14 (Par o Impar)");
                Console.WriteLine("15. Ejercicio 15 (Determinar Mayor)");
                Console.WriteLine("16. Ejercicio 16 (Aprobado o Reprobado)");
                Console.WriteLine("17. Ejercicio 17 (Identificar Vocal)");
                Console.WriteLine("18. Ejercicio 18 (Positivo o Negativo)");
                Console.WriteLine("19. Ejercicio 19 (Factura e IVA)");
                Console.WriteLine("20. Ejercicio 20 (Control de Caja)");
                Console.WriteLine(" 0. Volver al menú principal");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Seleccione un ejercicio: ");
                opc = Console.ReadLine();

                if (opc == "0") return;

                Console.Clear();
                switch (opc)
                {
                    case "11":
                        {
                            Console.WriteLine("--- EJERCICIO 11: Salario y Horas Extras ---");
                            Console.Write("Ingrese horas trabajadas: ");
                            double h = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese tarifa por hora: ");
                            double t = double.Parse(Console.ReadLine());
                            if (h <= 40)
                            {
                                Console.WriteLine("Salario: " + (h * t));
                            }
                            else
                            {
                                double extras = h - 40;
                                double tarifaExtra = t * 1.5;
                                Console.WriteLine("Salario total: " + ((40 * t) + (extras * tarifaExtra)));
                            }
                            break;
                        }
                    case "12":
                        {
                            Console.WriteLine("--- EJERCICIO 12: Descuento Sueldo ---");
                            Console.Write("Ingrese sueldo: ");
                            double sueldo = double.Parse(Console.ReadLine());
                            double desc = 0;
                            if (sueldo <= 1000) desc = sueldo * 0.10;
                            else if (sueldo <= 2000) desc = (sueldo - 1000) * 0.05 + (1000 * 0.10);
                            else desc = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
                            Console.WriteLine("Descuento: " + desc);
                            Console.WriteLine("Sueldo Neto: " + (sueldo - desc));
                            break;
                        }
                    case "13":
                        {
                            Console.WriteLine("--- EJERCICIO 13: Descuento por Monto ---");
                            Console.Write("Ingrese monto: ");
                            double monto = double.Parse(Console.ReadLine());
                            double descuento = monto > 100 ? monto * 0.10 : monto * 0.02;
                            Console.WriteLine("Monto final a pagar: " + (monto - descuento));
                            break;
                        }
                    case "14":
                        {
                            Console.WriteLine("--- EJERCICIO 14: Par o Impar ---");
                            Console.Write("Ingrese número: ");
                            int num = int.Parse(Console.ReadLine());
                            if (num % 2 == 0) Console.WriteLine("El número es PAR.");
                            else Console.WriteLine("El número es IMPAR.");
                            break;
                        }
                    case "15":
                        {
                            Console.WriteLine("--- EJERCICIO 15: Determinar Mayor ---");
                            Console.Write("Primer número: ");
                            int n1 = int.Parse(Console.ReadLine());
                            Console.Write("Segundo número: ");
                            int n2 = int.Parse(Console.ReadLine());
                            if (n1 > n2) Console.WriteLine("El mayor es: " + n1);
                            else if (n2 > n1) Console.WriteLine("El mayor es: " + n2);
                            else Console.WriteLine("Ambos números son iguales.");
                            break;
                        }
                    case "16":
                        {
                            Console.WriteLine("--- EJERCICIO 16: Promedio Aprobado/Reprobado ---");
                            Console.Write("Nota 1: ");
                            double n1 = double.Parse(Console.ReadLine());
                            Console.Write("Nota 2: ");
                            double n2 = double.Parse(Console.ReadLine());
                            double prom = (n1 + n2) / 2;
                            Console.WriteLine("Promedio: " + prom);
                            if (prom >= 11) Console.WriteLine("Estado: Aprobado");
                            else Console.WriteLine("Estado: Reprobado");
                            break;
                        }
                    case "17":
                        {
                            Console.WriteLine("--- EJERCICIO 17: Primera Vocal ---");
                            Console.Write("Ingrese una letra: ");
                            string letra = Console.ReadLine().ToLower();
                            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                                Console.WriteLine("La letra ingresada ES una vocal.");
                            else
                                Console.WriteLine("La letra ingresada NO es una vocal.");
                            break;
                        }
                    case "18":
                        {
                            Console.WriteLine("--- EJERCICIO 18: Positivo o Negativo ---");
                            Console.Write("Ingrese un número: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n > 0) Console.WriteLine("El número es Positivo.");
                            else if (n < 0) Console.WriteLine("El número es Negativo.");
                            else Console.WriteLine("El número es Cero.");
                            break;
                        }
                    case "19":
                        {
                            Console.WriteLine("--- EJERCICIO 19: Factura con IVA ---");
                            Console.Write("Precio del producto: ");
                            double precio = double.Parse(Console.ReadLine());
                            Console.Write("Cantidad: ");
                            int cant = int.Parse(Console.ReadLine());
                            double subtotal = precio * cant;
                            double iva = subtotal * 0.18;
                            Console.WriteLine("Subtotal: " + subtotal);
                            Console.WriteLine("IVA aplicado (18%): " + iva);
                            Console.WriteLine("Total neto a pagar: " + (subtotal + iva));
                            break;
                        }
                    case "20":
                        {
                            Console.WriteLine("--- EJERCICIO 20: Control de Caja ---");
                            Console.Write("Total Ingresos: ");
                            double ingresos = double.Parse(Console.ReadLine());
                            Console.Write("Total Egresos: ");
                            double egresos = double.Parse(Console.ReadLine());
                            double balance = ingresos - egresos;
                            if (balance > 0) Console.WriteLine("Sobrante positivo en caja: " + balance);
                            else if (balance < 0) Console.WriteLine("Faltante en caja: " + Math.Abs(balance));
                            else Console.WriteLine("La caja está completamente cuadrada en cero.");
                            break;
                        }
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();

            } while (opc != "0");
        }

        // =========================================================
        // CATEGORÍA 3: CÍCLICAS (EJERCICIOS DEL 21 AL 30)
        // =========================================================
        static void CategoriaCiclicas()
        {
            string opc;
            do
            {
                Console.Clear();
                Console.WriteLine("--- ESTRUCTURAS CÍCLICAS (21-30) ---");
                Console.WriteLine("21. Ejercicio 21 (Suma de N Primeros Números)");
                Console.WriteLine("22. Ejercicio 22 (Suma Salarios N Trabajadores)");
                Console.WriteLine("23. Ejercicio 23 (Control Acumulado de Notas)");
                Console.WriteLine("24. Ejercicio 24 (Conteo de Pares e Impares)");
                Console.WriteLine("25. Ejercicio 25 (Calcular Factorial)");
                Console.WriteLine("26. Ejercicio 26 (Tabla de Multiplicar)");
                Console.WriteLine("27. Ejercicio 27 (Sistema de Clave)");
                Console.WriteLine("28. Ejercicio 28 (Generar Secuencia Numérica)");
                Console.WriteLine("29. Ejercicio 29 (Suma de Dígitos)");
                Console.WriteLine("30. Ejercicio 30 (Suma de Rango Especial)");
                Console.WriteLine(" 0. Volver al menú principal");
                Console.WriteLine("------------------------------------");
                Console.Write("Seleccione un ejercicio: ");
                opc = Console.ReadLine();

                if (opc == "0") return;

                Console.Clear();
                switch (opc)
                {
                    case "21":
                        {
                            Console.WriteLine("--- EJERCICIO 21: Suma N Primeros Números ---");
                            Console.Write("Ingrese valor de N: ");
                            int n = int.Parse(Console.ReadLine());
                            int suma = 0;
                            for (int i = 1; i <= n; i++) suma += i;
                            Console.WriteLine("La suma de la serie es: " + suma);
                            break;
                        }
                    case "22":
                        {
                            Console.WriteLine("--- EJERCICIO 22: Suma Salarios N Trabajadores ---");
                            Console.Write("Cantidad de trabajadores: ");
                            int n = int.Parse(Console.ReadLine());
                            double sumaSalarios = 0;
                            for (int i = 1; i <= n; i++)
                            {
                                Console.Write("Salario del trabajador " + i + ": ");
                                sumaSalarios += double.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Suma total de todos los salarios: " + sumaSalarios);
                            break;
                        }
                    case "23":
                        {
                            Console.WriteLine("--- EJERCICIO 23: Control Acumulado de Notas ---");
                            string resp;
                            int aprobados = 0, desaprobados = 0;
                            do
                            {
                                Console.Write("Ingrese una nota (0-20): ");
                                double nota = double.Parse(Console.ReadLine());
                                if (nota >= 10.5) aprobados++; else desaprobados++;
                                Console.Write("¿Deseas ingresar otra nota? (si/no): ");
                                resp = Console.ReadLine().ToLower();
                            } while (resp == "si");
                            Console.WriteLine("Notas Aprobadas: " + aprobados);
                            Console.WriteLine("Notas Desaprobadas: " + desaprobados);
                            break;
                        }
                    case "24":
                        {
                            Console.WriteLine("--- EJERCICIO 24: Conteo de Pares e Impares ---");
                            Console.Write("¿Cuántos números va a registrar?: ");
                            int cant = int.Parse(Console.ReadLine());
                            int pares = 0, impares = 0;
                            for (int i = 1; i <= cant; i++)
                            {
                                Console.Write("Número " + i + ": ");
                                int num = int.Parse(Console.ReadLine());
                                if (num % 2 == 0) pares++; else impares++;
                            }
                            Console.WriteLine("Cantidad de Pares: " + pares);
                            Console.WriteLine("Cantidad de Impares: " + impares);
                            break;
                        }
                    case "25":
                        {
                            Console.WriteLine("--- EJERCICIO 25: Factorial ---");
                            Console.Write("Ingrese número a evaluar: ");
                            int n = int.Parse(Console.ReadLine());
                            long fact = 1;
                            for (int i = 1; i <= n; i++) fact *= i;
                            Console.WriteLine("El Factorial de " + n + " es: " + fact);
                            break;
                        }
                    case "26":
                        {
                            Console.WriteLine("--- EJERCICIO 26: Tabla de Multiplicar ---");
                            Console.Write("Ingrese el número de la tabla que desea ver: ");
                            int tabla = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine(tabla + " x " + i + " = " + (tabla * i));
                            }
                            break;
                        }
                    case "27":
                        {
                            Console.WriteLine("--- EJERCICIO 27: Sistema de Clave ---");
                            string claveCorrecta = "12345";
                            string intento;
                            int intentos = 0;
                            do
                            {
                                Console.Write("Ingrese la clave de seguridad: ");
                                intento = Console.ReadLine();
                                intentos++;
                                if (intento == claveCorrecta)
                                {
                                    Console.WriteLine("¡BIENVENIDO A LA FIESTA!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Clave incorrecta.");
                                }
                            } while (intentos < 5);
                            if (intentos == 5 && intento != claveCorrecta) Console.WriteLine("Ha excedido los intentos permitidos.");
                            break;
                        }
                    case "28":
                        {
                            Console.WriteLine("--- EJERCICIO 28: Secuencia Numérica ---");
                            Console.Write("¿Hasta qué número desea imprimir la secuencia?: ");
                            int max = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= max; i++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine("\nSecuencia terminada.");
                            break;
                        }
                    case "29":
                        {
                            Console.WriteLine("--- EJERCICIO 29: Suma de Dígitos ---");
                            Console.Write("Ingrese un número entero largo: ");
                            int n = Math.Abs(int.Parse(Console.ReadLine()));
                            int sumaDig = 0;
                            while (n > 0)
                            {
                                sumaDig += n % 10;
                                n /= 10;
                            }
                            Console.WriteLine("La suma interna de sus dígitos es: " + sumaDig);
                            break;
                        }
                    case "30":
                        {
                            Console.WriteLine("--- EJERCICIO 30: Suma de Rango Especial ---");
                            Console.Write("Ingrese el número de inicio del rango: ");
                            int inicio = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el número de fin del rango: ");
                            int fin = int.Parse(Console.ReadLine());
                            int acumulador = 0;
                            for (int i = inicio; i <= fin; i++) acumulador += i;
                            Console.WriteLine("La suma de todos los números en ese rango es: " + acumulador);
                            break;
                        }
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();

            } while (opc != "0");
        }
    }
}