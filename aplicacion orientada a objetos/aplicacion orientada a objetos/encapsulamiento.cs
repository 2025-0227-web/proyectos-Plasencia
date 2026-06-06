using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPagos
{
    
    public class TransaccionSegura
    {
        private string _idTransaccion; // Atributo privado (oculto al exterior)

        public string IdTransaccion
        {
            get { return _idTransaccion; }
            set
            {
                // Validación simple: no permitimos IDs vacíos o demasiado cortos
                if (!string.IsNullOrEmpty(value) && value.Length >= 6)
                {
                    _idTransaccion = value;
                }
                else
                {
                    Console.WriteLine("Error: ID de transacción no válido o inseguro.");
                }
            }
        }

        public TransaccionSegura(string idInicial)
        {
            _idTransaccion = idInicial;
        }
    }
}

