using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormBloqueArreglos : Form
    {
        // Declaramos algunos arreglos fijos para las simulaciones del bloque
        private int[] vectorE21 = { 15, 22, 35, 40, 58 };
        private string[] alumnosE25 = new string[5];
        private int contadorE25 = 0;

        public FormBloqueArreglos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bloque 4: Arreglos y Colecciones";
        }

        // E21: Almacenamiento en Vector Lineal
        private void btnCalcularE21_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDatoE21.Text, out int nuevoDato))
            {
                MessageBox.Show("Ingrese un número entero válido.", "Error");
                return;
            }
            // Modificamos el primer elemento para simular inserción dinámica
            vectorE21[0] = nuevoDato;

            string contenido = "Contenido actual del Vector:\n\n";
            for (int i = 0; i < vectorE21.Length; i++)
            {
                contenido += $"Posición [{i}]: {vectorE21[i]}\n";
            }
            MessageBox.Show(contenido, "Resultado E21");
        }

        // E22: Búsqueda de Elementos en Arreglo
        private void btnCalcularE22_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarE22.Text, out int objetivo))
            {
                MessageBox.Show("Ingrese el número que desea buscar.", "Error");
                return;
            }

            int[] datos = { 10, 45, 78, 23, 90, 11, 54 };
            int posicionEncontrada = -1;

            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] == objetivo)
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            if (posicionEncontrada != -1)
            {
                MessageBox.Show($"¡Encontrado! El número {objetivo} está en la posición [{posicionEncontrada}].", "Éxito E22");
            }
            else
            {
                MessageBox.Show($"El número {objetivo} no existe en este arreglo.", "No Encontrado");
            }
        }

        // E23: Ordenamiento de Menor a Mayor (Algoritmo Burbuja Simplificado)
        private void btnCalcularE23_Click(object sender, EventArgs e)
        {
            int[] desordenado = { 89, 12, 45, 2, 67, 34 };
            string original = string.Join(", ", desordenado);

            // Algoritmo de ordenación nativo
            Array.Sort(desordenado);

            string ordenado = string.Join(", ", desordenado);
            MessageBox.Show($"Arreglo Original: [ {original} ]\n\nArreglo Ordenado: [ {ordenado} ]", "Resultado E23");
        }

        // E24: Suma y Promedio de una Matriz 2D
        private void btnCalcularE24_Click(object sender, EventArgs e)
        {
            // Creamos una matriz bidimensional 3x3
            int[,] matriz = {
                { 5, 10, 15 },
                { 20, 25, 30 },
                { 35, 40, 45 }
            };

            int sumaTotal = 0;
            string dibujoMatriz = "Visualización de la Matriz 3x3:\n";

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    sumaTotal += matriz[f, c];
                    dibujoMatriz += $"[{matriz[f, c]}]\t";
                }
                dibujoMatriz += "\n";
            }

            double promedio = (double)sumaTotal / matriz.Length;
            MessageBox.Show($"{dibujoMatriz}\nSuma total de celdas: {sumaTotal}\nPromedio de la matriz: {promedio:F2}", "Resultado E24");
        }

        // E25: Registro de Nombres y Datos en Arreglos
        private void btnCalcularE25_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreE25.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Escriba un nombre válido.", "Error");
                return;
            }

            if (contadorE25 < alumnosE25.Length)
            {
                alumnosE25[contadorE25] = nombre;
                contadorE25++;
                txtNombreE25.Clear();

                string lista = "Alumnos registrados en el arreglo:\n\n";
                for (int i = 0; i < contadorE25; i++)
                {
                    lista += $"{i + 1}. {alumnosE25[i]}\n";
                }
                MessageBox.Show($"¡Registrado con éxito! ({contadorE25}/5)\n\n{lista}", "Registro E25");
            }
            else
            {
                MessageBox.Show("El arreglo ya está lleno. Capacidad máxima alcanzada (5 alumnos).", "Arreglo Lleno");
            }
        }
    }
}
