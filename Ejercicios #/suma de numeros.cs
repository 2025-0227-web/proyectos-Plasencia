using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int contador = 1;

        // El ciclo se repite mientras el contador no pase de 100
        while (contador <= 100)
        {
            suma = suma + contador; // Sumamos el número actual
            contador++;             // Pasamos al siguiente número
        }

        Console.WriteLine("La suma de los primeros 100 números es: " + suma);
    }
}