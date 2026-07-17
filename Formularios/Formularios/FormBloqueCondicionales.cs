using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormBloqueCondicionales : Form
    {
        public FormBloqueCondicionales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bloque de Estructuras Condicionales";
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 06 (Mayor, Menor o Iguales)
        // ==========================================
        private void btnCalcularE6_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumAE6.Text, out double a) ||
                !double.TryParse(txtNumBE6.Text, out double b) ||
                !double.TryParse(txtNumCE6.Text, out double c))
            {
                MessageBox.Show("Por favor, rellene los tres campos con números válidos.", "Faltan datos");
                return;
            }

            if (a == b && b == c)
            {
                MessageBox.Show("Los tres números introducidos son exactamente iguales.", "Resultado - Ejercicio 06");
                return;
            }

            double mayor = a;
            if (b > mayor) mayor = b;
            if (c > mayor) mayor = c;

            double menor = a;
            if (b < menor) menor = b;
            if (c < menor) menor = c;

            MessageBox.Show($"El número MAYOR es: {mayor}\nEl número MENOR es: {menor}", "Resultado - Ejercicio 06");
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 07 (Control de Acceso)
        // ==========================================
        private void btnCalcularE7_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioE7.Text.Trim();
            string clave = txtClaveE7.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe escribir el usuario y la contraseña.", "Campos vacíos");
                return;
            }

            if (usuario.ToLower() == "admin" && clave == "12345")
            {
                MessageBox.Show("¡Acceso concedido al sistema! Bienvenido.", "Éxito - Ejercicio 07");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente de nuevo.", "Acceso Denegado");
            }
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 08 (Clasificación de Edad)
        // ==========================================
        private void btnCalcularE8_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEdadE8.Text, out int edad) || edad < 0 || edad > 125)
            {
                MessageBox.Show("Por favor, introduzca una edad real y válida.", "Error");
                return;
            }

            string categoria = "";
            if (edad <= 12) categoria = "Niño / Infante";
            else if (edad <= 17) categoria = "Adolescente";
            else if (edad <= 64) categoria = "Adulto";
            else categoria = "Adulto Mayor (Tercera Edad)";

            MessageBox.Show($"La persona tiene {edad} años, por lo tanto clasifica como: {categoria}", "Resultado - Ejercicio 08");
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 09 (Impuestos y Descuentos comerciales)
        // ==========================================
        private void btnCalcularE09_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtVentaE09.Text, out double montoVenta) || montoVenta < 0)
            {
                MessageBox.Show("Por favor, introduzca un monto de venta válido.", "Error de entrada");
                return;
            }

            if (cmbClienteE09.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de cliente para aplicar los cálculos.", "Aviso");
                return;
            }

            string tipoCliente = cmbClienteE09.SelectedItem.ToString();
            double impuestoITBIS = montoVenta * 0.18; // 18% Impuesto base estándar
            double descuento = 0;

            // Condicional estructurada diferente según el perfil del cliente
            if (tipoCliente == "Miembro VIP")
            {
                descuento = montoVenta * 0.15; // 15% de descuento VIP
            }
            else if (tipoCliente == "Empleado")
            {
                descuento = montoVenta * 0.25; // 25% de descuento Empleado
            }

            double totalPagar = (montoVenta + impuestoITBIS) - descuento;

            MessageBox.Show($"Subtotal: ${montoVenta:F2}\nImpuesto (18%): +${impuestoITBIS:F2}\nDescuento Aplicado: -${descuento:F2}\n\nTotal Neto a Pagar: ${totalPagar:F2}", "Recibo - Ejercicio 09");
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 10 (Evaluación de Notas por Letras)
        // ==========================================
        private void btnCalcularE10_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNotaE10.Text, out double nota) || nota < 0 || nota > 100)
            {
                MessageBox.Show("Por favor, introduzca una nota válida en el rango de 0 a 100.", "Error de rango");
                return;
            }

            string letraCalificacion = "";
            string mensajeFeedback = "";

            // Lógica condicional anidada para escala literal académica
            if (nota >= 90)
            {
                letraCalificacion = "A";
                mensajeFeedback = "Rendimiento Excelente. ¡Sigue así!";
            }
            else if (nota >= 80)
            {
                letraCalificacion = "B";
                mensajeFeedback = "Buen desempeño. Tienes potencial.";
            }
            else if (nota >= 70)
            {
                letraCalificacion = "C";
                mensajeFeedback = "Suficiente. Aprobado de forma regular.";
            }
            else if (nota >= 60)
            {
                letraCalificacion = "D";
                mensajeFeedback = "Rendimiento Deficiente. Requiere tutorías.";
            }
            else
            {
                letraCalificacion = "F";
                mensajeFeedback = "Reprobado. Debe repetir el módulo obligatoriamente.";
            }

            MessageBox.Show($"Calificación: {nota}\nLetra asignada: {letraCalificacion}\n\nNota del Profesor: {mensajeFeedback}", "Resultado - Ejercicio 10");
        }
    }
}