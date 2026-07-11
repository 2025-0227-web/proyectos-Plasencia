using System;
using System.Windows.Forms;

namespace Formularios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí indicamos que el programa inicie mostrando nuestro Menú Principal
            Application.Run(new FormMenuPrincipal());
        }
    }
}
