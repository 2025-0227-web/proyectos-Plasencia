using System;

namespace ControlGimnasioExamen
{
    // Clase para representar al miembro del club deportivo
    class Socio
    {
        public int NumeroId;
        public string NombreCompleto;
        public string TipoMembresia; // VIP, Premium, Básica
        public int DiasRestantes;
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Socio socioCandidato = new Socio();
            socioCandidato.NumeroId = 2006;
            socioCandidato.NombreCompleto = "Junior Plasencia";
            socioCandidato.TipoMembresia = "VIP";
            socioCandidato.DiasRestantes = 30;

            
            Console.WriteLine("======= ¡BIENVENIDO AL CLUB DEPORTIVO PLASENCIA! =======");
            Console.WriteLine(">> Escaneando credencial del socio...");
            Console.WriteLine("Nombre: " + socioCandidato.NombreCompleto);
            Console.WriteLine("Pase Tipo: " + socioCandidato.TipoMembresia);
            Console.WriteLine("Días en el contador: " + socioCandidato.DiasRestantes);
            Console.WriteLine("==================================================");
            Console.WriteLine();

            if (socioCandidato.DiasRestantes == 0)
            {
                 
                Console.WriteLine("*** ALERTA EN LA ENTRADA ***");
                Console.WriteLine("Lo sentimos, tu pase se ha quedado en 0 días.");
                Console.WriteLine("¡Dale una visita a los chicos de recepción para recargar!");
            }
            else
            {
                
                Console.WriteLine("--> ¡ACCESO CONCEDIDO! ¡PASE!");
                Console.WriteLine("Revisando qué áreas puedes usar hoy... ");
                Console.WriteLine();

                switch (socioCandidato.TipoMembresia)
                {
                    case "Básica":
                        Console.WriteLine("[INFO] Tienes acceso habilitado para el Área de pesas.");
                        Console.WriteLine("¡KLK A darle duro a la rutina de hoy!");
                        break;

                    case "Premium":
                        Console.WriteLine("[INFO] Tienes acceso a: Área de pesas + La piscina.");
                        Console.WriteLine("¡Excelente para entrenar y luego darte un chapuson!");
                        break;

                    case "VIP":
                        Console.WriteLine("[VIP] ¡Pase Libre Total! Puedes entrar a todas las áreas.");
                        Console.WriteLine("[VIP] Además, tienes reservada tu entrada a las salas de masaje.");
                        Console.WriteLine("¡Disfruta tu entrenamiento de gente rica hoy!");
                        break;

                    default:
                        Console.WriteLine("[ERROR] Ese tipo de membresía no existe en nuestra base de datos.");
                        break;
                }

                
                socioCandidato.DiasRestantes = socioCandidato.DiasRestantes - 1;

                Console.WriteLine();
                Console.WriteLine("==================================================");
                Console.WriteLine("Aviso: Se ha restado un día de su saldo.");
                Console.WriteLine("Te quedan: " + socioCandidato.DiasRestantes + " días para seguir entrenando.");
            }

            
            Console.ReadLine();
        }
    }
}