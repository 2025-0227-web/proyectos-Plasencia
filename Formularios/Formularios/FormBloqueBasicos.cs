using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormBloqueBasicos : Form
    {
        public FormBloqueBasicos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bloque de Ejercicios Básicos";
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 01 (Cálculo de Salario)
        // ==========================================
        private void btnCalcularE1_Click(object sender, EventArgs e)
        {
            // Validamos que el usuario introduzca datos válidos para evitar caídas del programa
            if (!double.TryParse(txtHorasE1.Text, out double horastrabajadas) ||
                !double.TryParse(txtTarifaE1.Text, out double tarifa))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de entrada");
                return;
            }

            double salario = 0;

            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * tarifa;
                MessageBox.Show($"El salario es: {salario}", "Resultado - Ejercicio 01");
            }
            else if (horastrabajadas > 40)
            {
                double horasextra = horastrabajadas - 40;
                double tarifaextra = tarifa + (0.5 * tarifa);
                salario = (horasextra * tarifaextra) + (40 * tarifa);
                MessageBox.Show($"El salario neto es: {salario} (incluyendo horas extra)", "Resultado - Ejercicio 01");
            }
            else
            {
                MessageBox.Show("Las horas trabajadas no pueden ser negativas.", "Error");
            }
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 02 (Cálculo de Descuentos)
        // ==========================================
        private void btnCalcularE2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSueldoE2.Text, out double sueldo))
            {
                MessageBox.Show("Por favor, ingrese un sueldo válido.", "Error de entrada");
                return;
            }

            double descuento = 0;
            double sueldoneto = 0;

            if (sueldo <= 1000 && sueldo >= 0)
            {
                descuento = sueldo * 0.1;
                sueldoneto = sueldo - descuento;
                MessageBox.Show($"El descuento es: {descuento}\nEl sueldo neto es: {sueldoneto}", "Resultado - Ejercicio 02");
            }
            else if (sueldo <= 2000 && sueldo >= 0)
            {
                descuento = ((sueldo - 1000) * 0.05) + (1000 * 0.1);
                sueldoneto = sueldo - descuento;
                MessageBox.Show($"El descuento es: {descuento}\nEl sueldo neto es: {sueldoneto}", "Resultado - Ejercicio 02");
            }
            else if (sueldo > 2000)
            {
                descuento = ((sueldo - 2000) * 0.03) + (1000 * 0.05) + (1000 * 0.10);
                sueldoneto = sueldo - descuento;
                MessageBox.Show($"El descuento es: {descuento}\nEl sueldo neto es: {sueldoneto}", "Resultado - Ejercicio 02");
            }
            else
            {
                MessageBox.Show("Error: El sueldo no puede ser negativo.", "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Este método vacío soluciona el error del diseñador
        }


        // ==========================================
        // LÓGICA DEL EJERCICIO 03 (Operaciones Aritméticas)
        // ==========================================
        private void btnCalcularE3_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1E3.Text, out double n1) || !double.TryParse(txtNum2E3.Text, out double n2))
            {
                MessageBox.Show("Ingrese números válidos.", "Error");
                return;
            }

            if (cmbOperacionE3.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una operación matemática.", "Aviso");
                return;
            }

            string operacion = cmbOperacionE3.SelectedItem.ToString();
            double resultado = 0;

            switch (operacion)
            {
                case "Suma": resultado = n1 + n2; break;
                case "Resta": resultado = n1 - n2; break;
                case "Multiplicación": resultado = n1 * n2; break;
                case "División":
                    if (n2 == 0) { MessageBox.Show("No se puede dividir entre cero.", "Error Matemático"); return; }
                    resultado = n1 / n2;
                    break;
            }

            MessageBox.Show($"El resultado de la {operacion} es: {resultado}", "Resultado - Ejercicio 03");
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 04 (Conversión de Unidades)
        // ==========================================
        private void btnCalcularE4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMetrosE4.Text, out double metros) || metros < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad de metros válida y positiva.", "Error");
                return;
            }

            if (cmbUnidadE4.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la unidad a la que desea convertir.", "Aviso");
                return;
            }

            string unidad = cmbUnidadE4.SelectedItem.ToString();
            double conversion = 0;

            switch (unidad)
            {
                case "Centimetros": conversion = metros * 100; break;
                case "Kilometros": conversion = metros / 1000; break;
                case "Millas": conversion = metros * 0.000621371; break;
            }

            MessageBox.Show($"{metros} metros equivalen a {conversion} {unidad}.", "Resultado - Ejercicio 04");
        }

        // ==========================================
        // LÓGICA DEL EJERCICIO 05 (Cálculo de Promedios Ponderados)
        // ==========================================
        private void btnCalcularE5_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNota1E5.Text, out double n1) ||
                !double.TryParse(txtNota2E5.Text, out double n2) ||
                !double.TryParse(txtNota3E5.Text, out double n3))
            {
                MessageBox.Show("Ingrese calificaciones numéricas válidas.", "Error");
                return;
            }

            if (n1 < 0 || n1 > 100 || n2 < 0 || n2 > 100 || n3 < 0 || n3 > 100)
            {
                MessageBox.Show("Las notas deben estar comprendidas entre 0 y 100.", "Rango Incorrecto");
                return;
            }

            double notaFinal = (n1 * 0.30) + (n2 * 0.30) + (n3 * 0.40);
            string estado = (notaFinal >= 70) ? "Aprobado" : "Reprobado";

            MessageBox.Show($"La calificación acumulada es: {notaFinal:F2}\nEstado del estudiante: {estado}", "Resultado - Ejercicio 05");
        }
    }
}