
using System;

namespace ejercicios_usanfo_if_else_switch
{ 
public static class Ejercicio11
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 11: Cálculo de impuestos ---");
            Console.Write("Ingresa tu salario mensual: ");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                double impuesto = 0;
                if (salario < 10000) impuesto = 0;
                else if (salario <= 30000) impuesto = salario * 0.10;
                else impuesto = salario * 0.20;

                Console.WriteLine($"Impuesto aplicado: {impuesto:C}. Salario neto: {(salario - impuesto):C}");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}