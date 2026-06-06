using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace SistemaPagos
{
    
    public abstract class MetodoPago
    {
        // Propiedades automáticas para almacenar los datos básicos
        public string NombreMetodo { get; set; }

        public MetodoPago(string nombreMetodo)
        {
            NombreMetodo = nombreMetodo;
        }

        // Método abstracto: cada hijo decidirá CÓMO procesar su pago
        public abstract void ProcesarPago(double monto);
    }
}

