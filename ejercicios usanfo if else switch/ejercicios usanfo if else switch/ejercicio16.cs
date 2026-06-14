using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio16
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 16: Calculadora de descuentos ---");
            Console.Write("Ingresa el precio del producto: ");
            if (double.TryParse(Console.ReadLine(), out double precio))
            {
                double descuento = 0;
                if (precio < 50) descuento = 0;
                else if (precio <= 100) descuento = precio * 0.05;
                else descuento = precio * 0.10;

                Console.WriteLine($"Descuento: {descuento:C}. Total definitivo a pagar: {(precio - descuento):C}");
            }
            else Console.WriteLine("Entrada no válida.");
        }
    }
}