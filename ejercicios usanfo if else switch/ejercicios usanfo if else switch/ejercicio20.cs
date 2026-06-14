using System;

namespace ejercicios_usanfo_if_else_switch
{
    public static class Ejercicio20
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Ejercicio 20: Clasificación de IMC ---");
            Console.Write("Ingresa tu peso en kilogramos (kg): ");
            double.TryParse(Console.ReadLine(), out double peso);
            Console.Write("Ingresa tu altura en metros (m) - Ejemplo '1.75': ");
            double.TryParse(Console.ReadLine(), out double altura);

            if (peso > 0 && altura > 0)
            {
                double imc = peso / (altura * altura);
                Console.WriteLine($"Tu Índice de Masa Corporal es: {imc:F2}");

                if (imc < 18.5) Console.WriteLine("Clasificación: Bajo peso");
                else if (imc < 25) Console.WriteLine("Clasificación: Normal");
                else if (imc < 30) Console.WriteLine("Clasificación: Sobrepeso");
                else Console.WriteLine("Clasificación: Obesidad");
            }
            else Console.WriteLine("Los datos de peso y altura deben ser mayores que cero.");
        }
    }
}