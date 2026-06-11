
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante
{
    
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double costoCompra { get; set; }
    }

    
    public class ItemPedido
    {
        public Producto ProductoSeleccionado { get; set; }
        public int Cantidad { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, Producto> menu = new Dictionary<int, Producto>()
            {
                { 1, new Producto { Nombre = "Hamburguesa Clasica", Precio = 350.0 } },
                { 2, new Producto { Nombre = "Pizza de Pepperoni", Precio = 500.0 } },
                { 3, new Producto { Nombre = "Mofongo", Precio = 650.0 } },
                { 4, new Producto { Nombre = "Refresco de Coca Cola", Precio = 120.0 } },
                { 5, new Producto { Nombre = "Yaroa", Precio = 150.0 } }
            };

            
            List<ItemPedido> pedido = new List<ItemPedido>();

            Console.WriteLine("=================================================");
            Console.WriteLine("    🍔 BIENVENIDO A NUESTRO RESTAURANTE EL ANTOJO 🍔");
            Console.WriteLine("=================================================");

            while (true)
            {
                Console.WriteLine("\n--- MENU DISPONIBLE ---");

                
                foreach (var kvp in menu)
                {
                    Console.WriteLine($"[{kvp.Key}] {kvp.Value.Nombre} - ${kvp.Value.Precio:F2}");
                }
                Console.WriteLine("[0] Finalizar pedido y ver cuenta");

                Console.Write("\nIngrese el numero del producto que desea: ");
                int opcion;

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("❌ Entrada invalida. Por favor, ingrese un numero entero.");
                    continue;
                }

                if (opcion == 0)
                {
                    break; 
                }

               
                if (menu.ContainsKey(opcion))
                {
                    Producto prodElegido = menu[opcion];

                    Console.Write($"¿Cuantas unidades de '{prodElegido.Nombre}' desea?: ");
                    int cantidad;
                    if (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0)
                    {
                        Console.WriteLine("❌ Cantidad invalida. Debe ser mayor a 0.");
                        continue;
                    }

                    
                    pedido.Add(new ItemPedido { ProductoSeleccionado = prodElegido, Cantidad = cantidad });
                    Console.WriteLine($"-> ¡{cantidad} x '{prodElegido.Nombre}' agregado al pedido!");
                }
                else
                {
                    Console.WriteLine("❌ Ese numero de producto no existe en el menu. Intente de nuevo.");
                }
            }

            
            Console.WriteLine("\n==============================================");
            Console.WriteLine("        RESUMEN DE LA TRANSACCION");
            Console.WriteLine("==============================================");

            if (pedido.Count == 0)
            {
                Console.WriteLine("No se realizaron ventas en esta transaccion.");
            }
            else
            {
                int totalProductosVendidos = 0;
                double montoTotalVendido = 0;

                Console.WriteLine("{0,-22} {1,-7} {2,-10} {3,-10}", "Producto", "Cant.", "Precio U.", "Subtotal");
                Console.WriteLine("----------------------------------------------");

                foreach (var item in pedido)
                {
                    double subtotal = item.Cantidad * item.ProductoSeleccionado.Precio;

                    Console.WriteLine("{0,-22} {1,-7} ${2,-9:F2} ${3,-10:F2}",
                        item.ProductoSeleccionado.Nombre,
                        item.Cantidad,
                        item.ProductoSeleccionado.Precio,
                        subtotal);

                    totalProductosVendidos += item.Cantidad;
                    montoTotalVendido += subtotal;
                }

                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Cantidad total de productos vendidos: {totalProductosVendidos}");
                Console.WriteLine($"Monto total vendido:                  ${montoTotalVendido:F2}");
            }
            Console.WriteLine("==============================================");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}