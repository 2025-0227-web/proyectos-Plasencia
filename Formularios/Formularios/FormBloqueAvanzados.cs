using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormBloqueAvanzados : Form
    {
        // Variable para mantener el número oculto del juego (E29)
        private int numeroSecretoE29;

        public FormBloqueAvanzados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bloque 5: Algoritmos Avanzados";

            // Inicializamos el juego con un número aleatorio entre 1 y 10
            Random rnd = new Random();
            numeroSecretoE29 = rnd.Next(1, 11);
        }

        // E26: Manipulación y Concat de Cadenas
        private void btnCalcularE26_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor, escriba una frase o texto para analizar.", "Error");
                return;
            }

            int longitud = texto.Length;
            string mayusculas = texto.ToUpper();
            string minusculas = texto.ToLower();
            char primerCaracter = texto[0];

            MessageBox.Show($"Análisis del Texto:\n\n" +
                            $"- Longitud: {longitud} caracteres.\n" +
                            $"- En MAYÚSCULAS: {mayusculas}\n" +
                            $"- En minúsculas: {minusculas}\n" +
                            $"- Letra inicial: '{primerCaracter}'", "Resultado E26");
        }

        // E27: Funciones con Retorno Personalizadas
        private void btnCalcularE27_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrecioE27.Text, out double precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio base válido.", "Error");
                return;
            }

            // Llamamos a una función avanzada que calcula el ITBIS neto
            double itbisCalculado = CalcularImpuestoNativo(precio);
            double totalNeto = precio + itbisCalculado;

            MessageBox.Show($"Subtotal: ${precio:F2}\n" +
                            $"ITBIS (18% obtenido mediante función): ${itbisCalculado:F2}\n\n" +
                            $"Total de factura: ${totalNeto:F2}", "Resultado E27");
        }

        // Función personalizada con retorno requerida para cumplir el algoritmo avanzado
        private double CalcularImpuestoNativo(double montoBase)
        {
            return montoBase * 0.18;
        }

        // E28: Cálculo de Interés Compuesto
        private void btnCalcularE28_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCapitalE28.Text, out double capital) ||
                !int.TryParse(txtAniosE28.Text, out int anios) || capital <= 0 || anios <= 0)
            {
                MessageBox.Show("Ingrese un capital y cantidad de años válidos y positivos.", "Error");
                return;
            }

            double tasaInteres = 0.05; // 5% de interés anual fijo
            // Fórmula: Capital Final = Capital Inicial * (1 + tasa)^años
            double capitalFinal = capital * Math.Pow((1 + tasaInteres), anios);
            double interesesGanados = capitalFinal - capital;

            MessageBox.Show($"Proyección de Inversión (Tasa: 5%):\n\n" +
                            $"- Capital Inicial: ${capital:F2}\n" +
                            $"- Tiempo: {anios} años\n" +
                            $"- Intereses acumulados ganados: ${interesesGanados:F2}\n\n" +
                            $"Monto total acumulado al final: ${capitalFinal:F2}", "Resultado E28");
        }

        // E29: Juego de Adivinar el Número
        private void btnCalcularE29_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIntentoE29.Text, out int intento) || intento < 1 || intento > 10)
            {
                MessageBox.Show("Por favor, introduzca un número válido entre 1 y 10.", "Error de Rango");
                return;
            }

            if (intento == numeroSecretoE29)
            {
                MessageBox.Show("¡Felicidades, Junior! Adivinaste el número secreto. Vamos a generar uno nuevo.", "¡Ganaste! E29");
                // Reiniciamos el juego de una vez generando otro número aleatorio
                Random rnd = new Random();
                numeroSecretoE29 = rnd.Next(1, 11);
                txtIntentoE29.Clear();
            }
            else
            {
                string pista = intento > numeroSecretoE29 ? "Más bajo" : "Más alto";
                MessageBox.Show($"Incorrecto. Pista: El número secreto es {pista} que {intento}. ¡Inténtalo otra vez!", "Sigue buscando");
            }
        }

        // E30: Reporte Final Resumen de Datos del Sistema
        private void btnCalcularE30_Click(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            MessageBox.Show($"==================================\n" +
                            $"     REPORTE INTEGRAL FINAL\n" +
                            $"==================================\n\n" +
                            $"Módulos Académicos Cargados: 5 Módulos.\n" +
                            $"Total de Ejercicios Operativos: 30 Ejercicios.\n" +
                            $"Estado del Proyecto: Completado y Validado.\n\n" +
                            $"Fecha de Auditoría Interna: {fechaActual}\n" +
                            $"¡Felicidades! Entrega lista y sin errores.", "Sistema Finalizado - Ejercicio 30");
        }
    }
}