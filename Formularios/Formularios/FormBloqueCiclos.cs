using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormBloqueCiclos : Form
    {
        public FormBloqueCiclos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bloque de Estructuras Repetitivas (Ciclos)";
        }

        // E11: Sumatoria For
        private void btnCalcularE11_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLimiteE11.Text, out int limite) || limite < 1)
            {
                MessageBox.Show("Ingrese un número entero positivo mayor a 0.", "Error");
                return;
            }
            int suma = 0;
            for (int i = 1; i <= limite; i++) { suma += i; }
            MessageBox.Show($"La suma de los números del 1 al {limite} es: {suma}", "Resultado E11");
        }

        // E12: Pares e Impares While
        private void btnCalcularE12_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtHastaE12.Text, out int hasta) || hasta < 1)
            {
                MessageBox.Show("Ingrese un número válido.", "Error");
                return;
            }
            int i = 1, pares = 0, impares = 0;
            while (i <= hasta)
            {
                if (i % 2 == 0) pares++; else impares++;
                i++;
            }
            MessageBox.Show($"Encontrados entre 1 y {hasta}:\n\nNúmeros Pares: {pares}\nNúmeros Impares: {impares}", "Resultado E12");
        }

        // E13: Tabla de Multiplicar
        private void btnCalcularE13_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTablaE13.Text, out int tabla))
            {
                MessageBox.Show("Ingrese un número de tabla válido.", "Error");
                return;
            }
            string resultado = $"Tabla del {tabla}:\n\n";
            for (int i = 1; i <= 12; i++) { resultado += $"{tabla} x {i} = {tabla * i}\n"; }
            MessageBox.Show(resultado, "Resultado E13");
        }

        // E14: Validación Do-While
        private void btnCalcularE14_Click(object sender, EventArgs e)
        {
            string pin = txtPinE14.Text;
            if (pin == "2026")
            {
                MessageBox.Show("PIN Correcto. Sistema Desbloqueado.", "Éxito E14");
            }
            else
            {
                MessageBox.Show("PIN Incorrecto. Intente nuevamente.", "Acceso Denegado");
            }
        }

        // E15: Factorial
        private void btnCalcularE15_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumE15.Text, out int n) || n < 0 || n > 20)
            {
                MessageBox.Show("Ingrese un número entre 0 y 20.", "Error Rango");
                return;
            }
            long factorial = 1;
            for (int i = 1; i <= n; i++) { factorial *= i; }
            MessageBox.Show($"El factorial de {n} es: {factorial}", "Resultado E15");
        }

        // E16: Fibonacci
        private void btnCalcularE16_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTerminosE16.Text, out int t) || t < 1 || t > 30)
            {
                MessageBox.Show("Ingrese términos entre 1 y 30.", "Error");
                return;
            }
            string serie = "0";
            int a = 0, b = 1, siguiente;
            for (int i = 1; i < t; i++)
            {
                siguiente = a + b;
                serie += $", {siguiente}";
                a = b;
                b = siguiente;
            }
            MessageBox.Show($"Serie Fibonacci ({t} términos):\n\n{serie}", "Resultado E16");
        }

        // E17: Inventario
        private void btnCalcularE17_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStockE17.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error");
                return;
            }
            string msg = stock < 10 ? "Alerta: Stock Crítico. ¡Reabastecer!" : "Inventario estable.";
            MessageBox.Show($"Unidades: {stock}\nEstado: {msg}", "Resultado E17");
        }

        // E18: Números Primos
        private void btnCalcularE18_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPrimoE18.Text, out int num))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Error");
                return;
            }
            if (num <= 1) { MessageBox.Show($"{num} NO es un número primo.", "Resultado E18"); return; }
            bool esPrimo = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) { esPrimo = false; break; }
            }
            string res = esPrimo ? "SÍ es primo." : "NO es primo.";
            MessageBox.Show($"{num} {res}", "Resultado E18");
        }

        // E19: Promedio N Números Simulation
        private void btnCalcularE19_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidadE19.Text, out int cant) || cant < 1)
            {
                MessageBox.Show("Ingrese una cantidad de notas válida.", "Error");
                return;
            }
            // Simulación automatizada controlada con bucle para nota aleatoria académica promedio
            Random rnd = new Random();
            double suma = 0;
            for (int i = 0; i < cant; i++) { suma += rnd.Next(65, 101); }
            double prom = suma / cant;
            MessageBox.Show($"Simulación de {cant} estudiantes procesados.\nPromedio del grupo: {prom:F2}", "Resultado E19");
        }

        // E20: Cajero Automático
        private void btnCalcularE20_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRetiroE20.Text, out int monto) || monto <= 0 || monto % 100 != 0)
            {
                MessageBox.Show("El monto debe ser positivo y múltiplo de 100.", "Error de Caja");
                return;
            }
            int billetes1000 = monto / 1000;
            int residuo = monto % 1000;
            int billetes500 = residuo / 500;
            residuo %= 500;
            int billetes100 = residuo / 100;

            MessageBox.Show($"Desglose de Efectivo:\n\nBilletes de $1000: {billetes1000}\nBilletes de $500: {billetes500}\nBilletes de $100: {billetes100}", "Cajero Automático E20");
        }
    }
}