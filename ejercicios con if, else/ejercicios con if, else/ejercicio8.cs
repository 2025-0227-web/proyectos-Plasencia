using System;

namespace EjerciciosLogica
{
    public static class Ejercicio8
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- Verificación de Permisos del Sistema ---");
            Console.Write("Ingrese la letra clave de su rol (A, E, T, L): ");
            // Convertimos a mayúsculas para evitar problemas con minúsculas
            string rol = Console.ReadLine().ToUpper();

            switch (rol)
            {
                case "A":
                    Console.WriteLine("\nRol: Administrador. Permisos asignados: Acceso total al sistema y configuraciones globales.");
                    break;
                case "E":
                    Console.WriteLine("\nRol: Editor. Permisos asignados: Modificación, creación y publicación de contenidos.");
                    break;
                case "T": 
                    Console.WriteLine("\nRol: Autor. Permisos asignados: Redacción y edición exclusiva de notas propias.");
                    break;
                case "L":
                    Console.WriteLine("\nRol: Lector. Permisos asignados: Consulta y visualización de datos públicos.");
                    break;
                default:
                    Console.WriteLine("\nAsignación automática: Invitado. Permisos limitados a navegación básica.");
                    break;
            }
        }
    }
}